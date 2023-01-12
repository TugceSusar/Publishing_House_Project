using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publishingHouseProject.Entity
{
    public class SubOffice
    {
        [Key]
        public int Id { get; set; }
        public string SubOfficeName { get; set; }
        public string Addreess { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public virtual ICollection<Personel> Personels { get; set; }
    }
}
