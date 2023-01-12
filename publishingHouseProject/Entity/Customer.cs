using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publishingHouseProject.Entity
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerBirth { get; set; }
        public string CustomerGender { get; set; } 
        public virtual ICollection<Order> Orders { get; set; }
    }
}
