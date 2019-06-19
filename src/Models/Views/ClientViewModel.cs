using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class ClientViewModel : BaseEntityViewModel
    {
        public ClientViewModel() : base() { }

        public ClientViewModel(Client client) : base(client)
        {
            this.Name = client.Name;
        }

        public string Name { get; set; }
    }
}
