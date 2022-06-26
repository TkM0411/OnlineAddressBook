using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineAddressBook.App.Entities
{
    [Table("AddressBook")]
    public class AddressBookEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        public override string ToString()
        {
            return Address.Contains(",") ? $"{Id},{Name},{PhoneNumber},{ string.Format("\"{0}\"", Address)}" : $"{Id},{Name},{PhoneNumber},{Address}";
        }
    }
}