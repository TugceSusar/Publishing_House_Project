using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publishingHouseProject.Entity
{
    public class Order
    {
        [Key]

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get;set; }
        public int PersonelId { get; set; }
        public string PersonelName { get; set; }
        public double UnityPrice { get; set; }
        public int OrderAmount { get; set; }
        public double OrderTotalPrice { get; set; }
       
        public virtual Personel Personel { get; set; }
        public virtual Item Item { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
