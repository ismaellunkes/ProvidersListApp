using System.ComponentModel.DataAnnotations;

namespace ProvidersListApp.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Telefone:")]
        public string PhoneNumber { get; set; }

        public Phone() { }

        public Phone(int id, Person person, string phoneNumber)
        {
            Id = id;
            Person = person;
            PhoneNumber = phoneNumber;
        }
    }
}
