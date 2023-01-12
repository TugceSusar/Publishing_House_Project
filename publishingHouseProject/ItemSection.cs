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
    public partial class ItemSection : Form
    {
        Context db = new Context();

        public ItemSection()
        {
            InitializeComponent();
        }
        private void ıtem_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dg_ıtemınformation.DataSource = db.Item.ToList();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Item ıtem = new Item();
            ıtem.ItemName = tb_Itemname.Text;
            ıtem.ItemWriterName=tb_Itemname.Text;
            ıtem.ItemUnityPrice=int.Parse(tb_Itemunityprice.Text);
            ıtem.ItemStock = int.Parse(tb_Itemstock.Text);
            ıtem.Explanation = tb_Explanation.Text;
            ıtem.CategoryId=int.Parse(tb_Itemcategoryıd.Text);
            db.Item.Add(ıtem);
            db.SaveChanges();
            dg_ıtemınformation.DataSource=db.Item.ToList();

        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_ItemId.Text);
            var x = db.Item.Find(id);
            x.ItemName=tb_Itemname.Text;
            x.ItemWriterName = tb_Itemwritername.Text;
            x.ItemUnityPrice = int.Parse(tb_Itemunityprice.Text);
            x.ItemStock = int.Parse(tb_Itemstock.Text);
            x.Explanation = tb_Explanation.Text;
            x.CategoryId = int.Parse(tb_Itemcategoryıd.Text);
            db.SaveChanges();
            dg_ıtemınformation.DataSource = db.Item.ToList();
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (tb_ItemId.Text != "")
            {
                int id = Convert.ToInt32(tb_ItemId.Text);
                var ıte = db.Item.FirstOrDefault(x => x.Id == id);
                db.Item.Remove(ıte);
            }
            else
            {
                int idsecim = int.Parse(dg_ıtemınformation.CurrentRow.Cells[0].Value.ToString()); //işaretleyerek
                var ite = db.Item.FirstOrDefault(x => x.Id == idsecim);
                db.Item.Remove(ite);
            }
            db.SaveChanges();
            dg_ıtemınformation.DataSource = db.Item .ToList();
        }
    }
}
