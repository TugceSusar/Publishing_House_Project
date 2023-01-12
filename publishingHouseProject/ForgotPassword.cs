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

    public partial class ForgotPassword : Form
    {

        Context db = new Context();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        static public string name = "";
        static public string username = "";
        static public string password = "";
        static public string passwordagain = "";
        static public string question = "";
        static public string answer = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel();

            foreach (var item in db.Personel)
            {
                if (item.PersonelName==tbupdate_name.Text)
                {
                    item.PersonelUsername = tbupdate_username.Text;
                    item.PersonelPassword = tbupdate_password.Text;
                    db.Personel.Add(item);
                    db.SaveChanges();
                }
            }
        }

    

    }
}
