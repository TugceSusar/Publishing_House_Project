using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publishingHouseProject.Entity
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public virtual string RegionName { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
