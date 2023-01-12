namespace publishingHouseProject
{
    partial class categorysection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_admin = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_categoryname = new System.Windows.Forms.TextBox();
            this.tb_categoryıd = new System.Windows.Forms.TextBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_categoryname = new System.Windows.Forms.Label();
            this.lbl_categoryıd = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.dg_categoryınformation = new System.Windows.Forms.DataGridView();
            this.pnl_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_categoryınformation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_admin
            // 
            this.pnl_admin.BackColor = System.Drawing.Color.White;
            this.pnl_admin.Controls.Add(this.dateTimePicker1);
            this.pnl_admin.Controls.Add(this.tb_categoryname);
            this.pnl_admin.Controls.Add(this.tb_categoryıd);
            this.pnl_admin.Controls.Add(this.lbl_category);
            this.pnl_admin.Controls.Add(this.lbl_categoryname);
            this.pnl_admin.Controls.Add(this.lbl_categoryıd);
            this.pnl_admin.Location = new System.Drawing.Point(12, 12);
            this.pnl_admin.Name = "pnl_admin";
            this.pnl_admin.Size = new System.Drawing.Size(409, 119);
            this.pnl_admin.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 10, 16, 44, 59, 0);
            // 
            // tb_categoryname
            // 
            this.tb_categoryname.Location = new System.Drawing.Point(272, 72);
            this.tb_categoryname.Name = "tb_categoryname";
            this.tb_categoryname.Size = new System.Drawing.Size(126, 22);
            this.tb_categoryname.TabIndex = 7;
            // 
            // tb_categoryıd
            // 
            this.tb_categoryıd.Location = new System.Drawing.Point(272, 44);
            this.tb_categoryıd.Name = "tb_categoryıd";
            this.tb_categoryıd.Size = new System.Drawing.Size(126, 22);
            this.tb_categoryıd.TabIndex = 6;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(12, 11);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(235, 20);
            this.lbl_category.TabIndex = 5;
            this.lbl_category.Text = "Category Information";
            // 
            // lbl_categoryname
            // 
            this.lbl_categoryname.AutoSize = true;
            this.lbl_categoryname.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryname.Location = new System.Drawing.Point(13, 77);
            this.lbl_categoryname.Name = "lbl_categoryname";
            this.lbl_categoryname.Size = new System.Drawing.Size(133, 16);
            this.lbl_categoryname.TabIndex = 1;
            this.lbl_categoryname.Text = "Category Name";
            // 
            // lbl_categoryıd
            // 
            this.lbl_categoryıd.AutoSize = true;
            this.lbl_categoryıd.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryıd.Location = new System.Drawing.Point(13, 48);
            this.lbl_categoryıd.Name = "lbl_categoryıd";
            this.lbl_categoryıd.Size = new System.Drawing.Size(106, 16);
            this.lbl_categoryıd.TabIndex = 0;
            this.lbl_categoryıd.Text = "Category ID";
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.Black;
            this.bt_delete.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.White;
            this.bt_delete.Location = new System.Drawing.Point(299, 141);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(122, 47);
            this.bt_delete.TabIndex = 10;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.Black;
            this.bt_update.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(158, 141);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(122, 47);
            this.bt_update.TabIndex = 9;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.Black;
            this.bt_add.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.White;
            this.bt_add.Location = new System.Drawing.Point(12, 141);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(122, 47);
            this.bt_add.TabIndex = 8;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dg_categoryınformation
            // 
            this.dg_categoryınformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_categoryınformation.Location = new System.Drawing.Point(12, 194);
            this.dg_categoryınformation.Name = "dg_categoryınformation";
            this.dg_categoryınformation.RowHeadersWidth = 51;
            this.dg_categoryınformation.RowTemplate.Height = 24;
            this.dg_categoryınformation.Size = new System.Drawing.Size(409, 185);
            this.dg_categoryınformation.TabIndex = 11;
            // 
            // categorysection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(428, 391);
            this.Controls.Add(this.dg_categoryınformation);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.pnl_admin);
            this.Name = "categorysection";
            this.Text = "Category Section";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_admin.ResumeLayout(false);
            this.pnl_admin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_categoryınformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_admin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_categoryname;
        private System.Windows.Forms.TextBox tb_categoryıd;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_categoryname;
        private System.Windows.Forms.Label lbl_categoryıd;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dg_categoryınformation;
    }
}