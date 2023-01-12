namespace publishingHouseProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_click = new System.Windows.Forms.Label();
            this.bt_click = new System.Windows.Forms.Button();
            this.cb_rememberme = new System.Windows.Forms.CheckBox();
            this.linklbl_forgot = new System.Windows.Forms.LinkLabel();
            this.pb_book = new System.Windows.Forms.PictureBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("Copperplate Gothic Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_welcome.Location = new System.Drawing.Point(209, 88);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(373, 36);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Welcome to Epitaph";
            this.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_click
            // 
            this.lbl_click.AutoSize = true;
            this.lbl_click.BackColor = System.Drawing.Color.Transparent;
            this.lbl_click.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_click.ForeColor = System.Drawing.Color.White;
            this.lbl_click.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_click.Location = new System.Drawing.Point(264, 411);
            this.lbl_click.Name = "lbl_click";
            this.lbl_click.Size = new System.Drawing.Size(189, 16);
            this.lbl_click.TabIndex = 3;
            this.lbl_click.Text = "Please, Click to Login";
            this.lbl_click.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bt_click
            // 
            this.bt_click.BackColor = System.Drawing.Color.Transparent;
            this.bt_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_click.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_click.ForeColor = System.Drawing.Color.White;
            this.bt_click.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_click.Location = new System.Drawing.Point(432, 399);
            this.bt_click.Name = "bt_click";
            this.bt_click.Size = new System.Drawing.Size(109, 40);
            this.bt_click.TabIndex = 4;
            this.bt_click.Text = "Click";
            this.bt_click.UseVisualStyleBackColor = false;
            this.bt_click.Click += new System.EventHandler(this.bt_click_Click);
            // 
            // cb_rememberme
            // 
            this.cb_rememberme.AutoSize = true;
            this.cb_rememberme.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_rememberme.Location = new System.Drawing.Point(328, 338);
            this.cb_rememberme.Name = "cb_rememberme";
            this.cb_rememberme.Size = new System.Drawing.Size(122, 18);
            this.cb_rememberme.TabIndex = 10;
            this.cb_rememberme.Text = "Remember Me";
            this.cb_rememberme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_rememberme.UseVisualStyleBackColor = true;
            // 
            // linklbl_forgot
            // 
            this.linklbl_forgot.AutoSize = true;
            this.linklbl_forgot.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_forgot.LinkColor = System.Drawing.Color.White;
            this.linklbl_forgot.Location = new System.Drawing.Point(321, 359);
            this.linklbl_forgot.Name = "linklbl_forgot";
            this.linklbl_forgot.Size = new System.Drawing.Size(135, 14);
            this.linklbl_forgot.TabIndex = 14;
            this.linklbl_forgot.TabStop = true;
            this.linklbl_forgot.Text = "Forgot Password";
            // 
            // pb_book
            // 
            this.pb_book.BackColor = System.Drawing.Color.Black;
            this.pb_book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_book.Image = ((System.Drawing.Image)(resources.GetObject("pb_book.Image")));
            this.pb_book.Location = new System.Drawing.Point(0, 0);
            this.pb_book.Name = "pb_book";
            this.pb_book.Size = new System.Drawing.Size(787, 552);
            this.pb_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_book.TabIndex = 1;
            this.pb_book.TabStop = false;
            //this.pb_book.Click += new System.EventHandler(this.pb_book_Click);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.BackColor = System.Drawing.Color.Black;
            this.tb_password.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tb_password.Location = new System.Drawing.Point(302, 295);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(171, 22);
            this.tb_password.TabIndex = 6;
            this.tb_password.Text = "PASSWORD";
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.Enter += new System.EventHandler(this.tb_password_Enter);
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.Color.Black;
            this.tb_user.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_user.Location = new System.Drawing.Point(302, 255);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(171, 22);
            this.tb_user.TabIndex = 18;
            this.tb_user.Text = "USERNAME";
            this.tb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_user.Enter += new System.EventHandler(this.tb_user_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(787, 552);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.linklbl_forgot);
            this.Controls.Add(this.cb_rememberme);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_click);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.bt_click);
            this.Controls.Add(this.pb_book);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_click;
        private System.Windows.Forms.Button bt_click;
        private System.Windows.Forms.CheckBox cb_rememberme;
        private System.Windows.Forms.LinkLabel linklbl_forgot;
        private System.Windows.Forms.PictureBox pb_book;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user;
    }
}

