using System.ComponentModel.DataAnnotations;

namespace ProvidersListApp.Models
{
    public class Company : Person
    {

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Estado:")]
        public UF Uf { get; set; }

        public Company() { }
        public Company(int id, PersonType personType, string name, string document01, UF Uf)
            : base(id, PersonType.JURIDICA, name, document01) {

            this.Uf = Uf;
        }
        
    }
}
