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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace publishingHouseProject
{
    public partial class personelsection : Form
    {
        Context db = new Context();
        public personelsection()
        {
            InitializeComponent();
        }

        private void personelsection_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dg_personelınformation.DataSource = db.Personel.ToList();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.PersonelName = tb_personelname.Text;
            personel.PersonelGender=tb_personelgender.Text;
            personel.PersonelCommunication = mtb_personelcommunication.Text;
            personel.PersonelAuthority=tb_personelauthority.Text;
            personel.SubOfficeId = int.Parse(tb_subofficeıd.Text);
            db.Personel.Add(personel);
            db.SaveChanges();
            dg_personelınformation.DataSource = db.Personel.ToList();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_personelıd.Text);
            var x = db.Personel.Find(id);
            x.PersonelName = tb_personelname.Text;
            x.PersonelGender = tb_personelgender.Text;
            x.PersonelCommunication= mtb_personelcommunication.Text;
            x.PersonelAuthority=tb_personelauthority.Text;
            x.SubOfficeId = int.Parse(tb_subofficeıd.Text);
            db.SaveChanges();
            dg_personelınformation.DataSource = db.Personel.ToList();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_personelıd.Text != "")
            {
                int id = Convert.ToInt32(tb_personelıd.Text);
                var person = db.Personel.FirstOrDefault(x => x.Id == id);
                db.Personel.Remove(person);
            }
            else
            {
                int idsecim = int.Parse(dg_personelınformation.CurrentRow.Cells[0].Value.ToString()); //işaretleyerek
                var person = db.Personel.FirstOrDefault(x => x.Id == idsecim);
                db.Personel.Remove(person);
            }
            db.SaveChanges();
            dg_personelınformation.DataSource = db.Personel.ToList();
        }
    }
}
