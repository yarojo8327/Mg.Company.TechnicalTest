using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mg.Company.Infraestructure.Core.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Document { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(20)]
        public string SecondSurname { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public decimal SalaryValue { get; set; }


        [ForeignKey("ContractType")]
        public int ContractTypeId { get; set; }

        public virtual ContractType ContractType { get; set; }

    }
}
