
using System.ComponentModel.DataAnnotations;

namespace ProvidersListApp.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Tipo Pessoa:")]
        public PersonType PersonType { get; set; }
        
        [Required(ErrorMessage = "{0} required")]        
        [Display(Name = "Nome/Nome Fantasia")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "CPF/CNPJ:")]
        public string Document01 { get; set; }

        public Person() {  }
        public Person(int id, PersonType personType, string name, string document01)
        {
            Id = id;
            PersonType = personType;
            Name = name;
            Document01 = document01;
        }
    }
}
