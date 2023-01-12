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
    

    public partial class ordersection : Form
    {
        Context db = new Context();
        public ordersection()
        {
            InitializeComponent();
        }

        private void ordersection_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            dg_order.DataSource = db.Order.ToList();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Id = int.Parse(tb_orderId.Text);
            order.OrderDate= DateTime.Parse(tb_orderdate.Text);
            order.ItemId = int.Parse(tb_orderıtemıd.Text);
            order.ItemName=tb_orderıtemname.Text;
            order.CustomerId=int.Parse(tb_ordercustomerıd.Text);
            order.CustomerName=tb_ordercustomername.Text;
            order.PersonelId = int.Parse(tb_orderpersıd.Text);
            order.PersonelName = tb_orderpername.Text;
            order.UnityPrice = int.Parse(tb_orderunityprice.Text);
            order.OrderAmount = int.Parse(tb_orderamount.Text);
            order.OrderTotalPrice = int.Parse(tb_ordertotalprice.Text);
            db.Order.Add(order);
            db.SaveChanges();
            dg_order.DataSource=db.Order.ToList();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tb_orderId.Text);
            var x = db.Order.Find(id);
            x.OrderDate= DateTime.Parse(tb_orderdate.Text);
            x.ItemId = int.Parse(tb_orderıtemıd.Text);
            x.ItemName= tb_orderıtemname.Text;
            x.CustomerId= int.Parse(tb_ordercustomerıd.Text);
            x.CustomerName = tb_ordercustomername.Text;
           x.PersonelId = int.Parse(tb_orderpersıd.Text);
            x.PersonelName = tb_orderpername.Text;
            x.UnityPrice = int.Parse(tb_orderunityprice.Text);
            x.OrderAmount = int.Parse(tb_orderamount.Text);
            x.OrderTotalPrice = int.Parse(tb_ordertotalprice.Text);
            db.SaveChanges();
            dg_order.DataSource = db.Order.ToList();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (tb_orderId.Text != "")
            {
                int id = Convert.ToInt32(tb_orderId);
                var orde = db.Order.FirstOrDefault(x => x.Id == id);
                db.Order.Remove(orde);
            }
            else
            {
                int idsecim = int.Parse(dg_order.CurrentRow.Cells[0].Value.ToString()); //işaretleyerek
                var orde = db.Order.FirstOrDefault(x => x.Id == idsecim);
                db.Order.Remove(orde);
            }
            db.SaveChanges();
            dg_order.DataSource = db.Order.ToList();

        }
    }
}
