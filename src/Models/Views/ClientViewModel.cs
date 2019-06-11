using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class ClientViewModel : BaseEntityViewModel
    {
        public ClientViewModel(Client client) : base()
        {
            this.Name = client.Name;
        }
        [Required]
        public string Name { get; set; }
    }
}
