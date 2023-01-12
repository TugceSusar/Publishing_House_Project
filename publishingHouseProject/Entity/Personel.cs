using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publishingHouseProject.Entity
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }
        public string PersonelName { get; set; }
        public string PersonelGender { get; set; }
        public string PersonelCommunication { get; set; }
        public string PersonelUsername { get; set; }    
        public string PersonelPassword { get; set; }
        public string PersonelAuthority { get; set; }
        public int SubOfficeId { get; set; }

        public virtual SubOffice SubOffice { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
