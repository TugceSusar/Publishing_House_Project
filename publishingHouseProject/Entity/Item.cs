using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publishingHouseProject.Entity
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
       //public PictureBox ItemCode { get; set; }
        public  string ItemName { get; set; }
        public  string ItemWriterName { get; set; }
        public double ItemUnityPrice { get; set; }
        public int ItemStock { get; set; }
        public string Explanation { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
