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
    public partial class customersection : Form
    {
        Context db = new Context();
        public customersection()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_newcustomerıd.Text != "")
            {
                int id = Convert.ToInt32(tb_newcustomerıd);
                var custom = db.Customer.FirstOrDefault(x => x.Id == id);
                db.Customer.Remove(custom);
            }
            else
            {
                int idsecim = int.Parse(dg_customer.CurrentRow.Cells[0].Value.ToString()); //işaretleyerek
                var custom = db.Customer.FirstOrDefault(x => x.Id == idsecim);
                db.Customer.Remove(custom);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerName = tb_newcustomername.Text;
            customer.CustomerBirth = tb_newcustomerbirth.Text;
            customer.CustomerGender = tb_newcustomergender.Text;
            customer.Orders = new List<Order>();
            db.Customer.Add(customer);
            db.SaveChanges();
            dg_customer.DataSource = db.Customer.ToList();


        }

        private void customersection_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dg_customer.DataSource = db.Customer.ToList();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_newcustomerıd.Text.ToString());
            var x = db.Customer.Find(id);
            x.CustomerName = tb_newcustomername.Text;
            x.CustomerBirth = tb_newcustomerbirth.Text;
            x.CustomerGender = tb_newcustomergender.Text;
            db.SaveChanges();
            dg_customer.DataSource = db.Customer.ToList();
        }

    }
}
