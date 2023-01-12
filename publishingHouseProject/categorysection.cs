using publishingHouseProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publishingHouseProject
{
    public partial class categorysection : Form
    {
        Context db= new Context();
        public categorysection()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dg_categoryınformation.DataSource = db.Category.ToList();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=tb_categoryname.Text;
            db.Category.Add(category);
            db.SaveChanges();
            dg_categoryınformation.DataSource=db.Category.ToList();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_categoryıd.Text);
            var x = db.Category.Find(id);
            x.CategoryName = tb_categoryname.Text;
            db.SaveChanges();
            dg_categoryınformation.DataSource = db.Category.ToList();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

            if (tb_categoryıd.Text != "")
            {
                int id = Convert.ToInt32(tb_categoryıd.Text);
                var categor = db.Category.FirstOrDefault(x => x.Id == id);
                db.Category.Remove(categor);
            }
            else
            {
                int idsecim = int.Parse(dg_categoryınformation.CurrentRow.Cells[0].Value.ToString()); //işaretleyerek
                var categor = db.Category.FirstOrDefault(x => x.Id == idsecim);
                db.Category.Remove(categor);
            }
            db.SaveChanges();
            dg_categoryınformation.DataSource = db.Category.ToList();
        }
    }
}
