using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using publishingHouseProject.Entity;
namespace publishingHouseProject
{
    public partial class Form1 : Form
    {
        Context db = new Context();
        public string username;
        public string ıd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username = tb_user.Text;
            pb_book.Parent = this;
            pb_book.BackColor = Color.Transparent;
            lbl_welcome.Parent = pb_book;
            lbl_welcome.BackColor = Color.Transparent;
            lbl_click.Parent = pb_book;
            lbl_click.BackColor = Color.Transparent;
            bt_click.Parent = pb_book;
            bt_click.BackColor = Color.Transparent;
            linklbl_forgot.Parent = pb_book;
            linklbl_forgot.BackColor = Color.Transparent;
        }
        private void tb_password_Enter(object sender, EventArgs e)
        {
            if (tb_password.Text == "PASSWORD")
            {
                tb_password.Text = "";
                tb_password.ForeColor = Color.White;
                tb_password.PasswordChar = '*';
            }
        }
        bool logincontrol = false;
        private void bt_click_Click(object sender, EventArgs e)
        {
            foreach (var person in db.Personel)
            {
                if (person.PersonelUsername==tb_user.Text && person.PersonelPassword==tb_password.Text&&person.PersonelAuthority=="admin")
                {
                    logincontrol = true;
                    MessageBox.Show("Admin Girişi Başarılı");
                    adminlogin adminlogin = new adminlogin();
                    adminlogin.username = person.PersonelUsername;
                    adminlogin.ShowDialog();
                }
                else if (person.PersonelUsername == tb_user.Text && person.PersonelPassword == tb_password.Text && person.PersonelAuthority == "personel")
                {
                    logincontrol=true;

                    MessageBox.Show("Personel Girişi Başarılı");
                    personellogin personellogin = new personellogin();
                    personellogin.username = person.PersonelUsername;
                    personellogin.ShowDialog();
                }
            }
            if (logincontrol==false)
            {
                MessageBox.Show(" Giriş Başarısız...");
            }
        }

        private void tb_user_Enter(object sender, EventArgs e)
        {
            if (tb_user.Text == "USERNAME")
            {
                tb_user.Text = "";
            }
        }
        private void tb_user_Leave(object sender, EventArgs e)
        {
            if (tb_user.Text == "")
            {
                tb_user.Text = "USERNAME";
            }
        }
    }
}



