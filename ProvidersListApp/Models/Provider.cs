using System;
using System.ComponentModel.DataAnnotations;

namespace ProvidersListApp.Models
{
    public class Provider : Person
    {
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Data de Reg.:")]
        public DateTime DtTimeRegistry { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Nascimento/Fundação:")]
        public DateTime DtBirthday { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "RG/Insc. Estadual:")]
        public string Document02 { get; set; }

        public Provider() { }

        public Provider(DateTime dtTimeRegistry, DateTime dtBirthday, int id, PersonType personType, string name, string document01)
            : base(id, personType, name, document01)
        {
            this.DtTimeRegistry = DateTime.Now;
            this.DtBirthday = dtBirthday;
        } 

    }
}
