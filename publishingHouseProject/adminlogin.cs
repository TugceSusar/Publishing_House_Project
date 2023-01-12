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
    public partial class adminlogin : Form
    {
        Context db=new Context();
        public adminlogin()
        {
            InitializeComponent();
        }

       
        public string username;
        private void adminlogin_Load(object sender, EventArgs e)
        {


            foreach (var personel in db.Personel)
            {
                if (username == personel.PersonelAuthority)
                {
                    tb_adminpersonelıd.Text = personel.Id.ToString();
                    tb_adminpersonelname.Text = personel.PersonelName;
                    tb_adminpersonelgender.Text = personel.PersonelGender;
                    tb_adminpersonelcommunication.Text = personel.PersonelCommunication;
                    tb_adminpersonelauthority.Text = personel.PersonelAuthority;
                    tb_adminsubofficeıd.Text = personel.SubOfficeId.ToString();

                }

            }


        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            personelsection personelsection = new personelsection();
            personelsection.ShowDialog();
        }

        private void btn_suboffice_Click(object sender, EventArgs e)
        {
            suboffice suboffice = new suboffice();
            suboffice.ShowDialog();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            categorysection categorysection = new categorysection();
            categorysection.ShowDialog();
            
        }

        private void btn_ıtem_Click(object sender, EventArgs e)
        {
            ItemSection ıtem = new ItemSection();
            ıtem.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
