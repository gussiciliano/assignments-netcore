using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentsNetcore.Helpers;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;
using AssignmentsNetcore.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Configuration;

namespace AssignmentsNetcore.Api.V1.Controllers
{
    [Route("/api/v1/[controller]")]
    public class AccountApiController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IHtmlLocalizer<AccountApiController> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public AccountApiController(UserManager<User> userManager,
                                    SignInManager<User> signInManager,
                                    IUnitOfWork unitOfWork,
                                    IConfiguration configuration,
                                    IHtmlLocalizer<AccountApiController> localizer)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._configuration = configuration;
            this._localizer = localizer;
            this._unitOfWork = unitOfWork;
        }

        public UserManager<User> UserManager { get => this._userManager; }
        public SignInManager<User> SignInManager { get => this._signInManager; }
        public IConfiguration Configuration { get => this._configuration; }
        public IHtmlLocalizer<AccountApiController> Localizer { get => this._localizer; }
        public IUnitOfWork UnitOfWork { get => this._unitOfWork; }

        [HttpPost("SignIn")]
        public async Task<object> SignIn([FromBody] LoginViewModel loginViewModel)
        {
            var result = await SignInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false);
            object response;
            if (result.Succeeded)
            {
                var appUser = UserManager.Users.SingleOrDefault(r => r.Email == loginViewModel.Email);
                Response.StatusCode = StatusCodes.Status200OK;
                var configVariables = new Dictionary<string, string>
                {
                    { "key", Configuration["Jwt:Key"] },
                    { "expire", Configuration["Jwt:ExpireDays"] },
                    { "issuer", Configuration["Jwt:Issuer"] },
                };
                response = new { Token = AccountHelper.GenerateJwtToken(loginViewModel.Email, appUser, configVariables) };
            }
            else if (result.IsNotAllowed)
            {
                Response.StatusCode = StatusCodes.Status401Unauthorized;
                response = new { Message = Localizer["account_login_confirm_email"].Value };
            }
            else
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
                if (string.IsNullOrEmpty(loginViewModel.Email) || string.IsNullOrEmpty(loginViewModel.Password))
                    response = new { Message = Localizer["account_login_failed_empty_fields"].Value };
                else
                    response = new { Message = Localizer["account_login_failed"].Value };
            }
            return Json(response);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("Me")]
        public async Task<IActionResult> Me()
        {
            return Json(await UserManager.FindByEmailAsync(User.Identity.Name));
        }
    }
}
