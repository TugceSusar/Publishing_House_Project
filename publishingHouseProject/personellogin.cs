using publishingHouseProject.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publishingHouseProject
{
    public partial class personellogin : Form
    {
        Context db=new Context();
        void customerlist()
        {
            dgv_personel.DataSource=db.Customer.ToList();
        }
        void orderlist()
        {
            dgv_personel.DataSource = db.Order.ToList();
        }
        public personellogin()
        {
            InitializeComponent();
        }
        public string username;
        
        private void personellogin_Load(object sender, EventArgs e)
        {

          

            foreach (var personel in db.Personel)
            {
                if (username == personel.PersonelUsername)
                {
                    tb_personelıd.Text = personel.Id.ToString();
                    tb_personelname.Text = personel.PersonelName;
                    tb_personelgender.Text = personel.PersonelGender;
                    tb_personelcommunication.Text = personel.PersonelCommunication;
                    tb_personelauthority.Text = personel.PersonelAuthority;
                    tb_subofficeıd.Text = personel.SubOfficeId.ToString();

                }

            }

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            customersection customersection = new customersection();
            customersection.ShowDialog();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            ordersection ordersection = new ordersection();
            ordersection.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
