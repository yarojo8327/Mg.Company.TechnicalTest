using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mg.Company.Infraestructure.Core.Entities
{
    public class ContractType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Description { get; set; }
       

        [Required]
        public bool Active { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
