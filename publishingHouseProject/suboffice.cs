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
    public partial class suboffice : Form
    {
        Context db = new Context();
        public suboffice()
        {
            InitializeComponent();
        }

        private void suboffice_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dg_subofficesection.DataSource = db.Suboffice.ToList();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            SubOffice subOffice = new SubOffice();
            subOffice.SubOfficeName = tb_subofficename.Text;
            subOffice.Addreess = tb_subofficeaddress.Text;
            subOffice.CityId = int.Parse(tb_subofficecıtyıd.Text);
            db.Suboffice.Add(subOffice);
            db.SaveChanges();
            dg_subofficesection.DataSource = db.Suboffice.ToList();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_subofficeıd.Text);
            var x = db.Suboffice.Find(id);
            x.Id = int.Parse(tb_subofficeıd.Text);
            x.SubOfficeName = tb_subofficename.Text;
            x.Addreess=tb_subofficeaddress.Text;
            x.CityId = int.Parse(tb_subofficecıtyıd.Text);
            db.SaveChanges();
            dg_subofficesection.DataSource = db.Suboffice.ToList();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_subofficeıd.Text != "")
            {
                int id = Convert.ToInt32(tb_subofficeıd.Text);
                var suboffic = db.Suboffice.FirstOrDefault(x => x.Id == id);
                db.Suboffice.Remove(suboffic);
            }
            else
            {
                int idsecim = int.Parse(dg_subofficesection.CurrentRow.Cells[0].Value.ToString()); //işaretleyerek
                var suboffic = db.Suboffice.FirstOrDefault(x => x.Id == idsecim);
                db.Suboffice.Remove(suboffic);
            }
            db.SaveChanges();
            dg_subofficesection.DataSource = db.Suboffice.ToList();
        }
    }
}
