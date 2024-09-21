namespace Contact_Info
{
    partial class Contact
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
            this.et_fname = new System.Windows.Forms.TextBox();
            this.tv_fname = new System.Windows.Forms.Label();
            this.tv_lname = new System.Windows.Forms.Label();
            this.et_lname = new System.Windows.Forms.TextBox();
            this.tv_contact = new System.Windows.Forms.Label();
            this.et_contact = new System.Windows.Forms.TextBox();
            this.tv_address = new System.Windows.Forms.Label();
            this.et_address = new System.Windows.Forms.TextBox();
            this.tv_email = new System.Windows.Forms.Label();
            this.et_email = new System.Windows.Forms.TextBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.tv_gender = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.et_search = new System.Windows.Forms.TextBox();
            this.dgv_db_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_db_data)).BeginInit();
            this.SuspendLayout();
            // 
            // et_fname
            // 
            this.et_fname.Location = new System.Drawing.Point(136, 77);
            this.et_fname.Name = "et_fname";
            this.et_fname.Size = new System.Drawing.Size(196, 22);
            this.et_fname.TabIndex = 0;
            this.et_fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tv_fname
            // 
            this.tv_fname.AutoSize = true;
            this.tv_fname.Location = new System.Drawing.Point(34, 83);
            this.tv_fname.Name = "tv_fname";
            this.tv_fname.Size = new System.Drawing.Size(72, 16);
            this.tv_fname.TabIndex = 1;
            this.tv_fname.Text = "First Name";
            this.tv_fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // tv_lname
            // 
            this.tv_lname.AutoSize = true;
            this.tv_lname.Location = new System.Drawing.Point(34, 111);
            this.tv_lname.Name = "tv_lname";
            this.tv_lname.Size = new System.Drawing.Size(94, 16);
            this.tv_lname.TabIndex = 3;
            this.tv_lname.Text = "Second Name";
            // 
            // et_lname
            // 
            this.et_lname.Location = new System.Drawing.Point(136, 105);
            this.et_lname.Name = "et_lname";
            this.et_lname.Size = new System.Drawing.Size(196, 22);
            this.et_lname.TabIndex = 2;
            // 
            // tv_contact
            // 
            this.tv_contact.AutoSize = true;
            this.tv_contact.Location = new System.Drawing.Point(34, 139);
            this.tv_contact.Name = "tv_contact";
            this.tv_contact.Size = new System.Drawing.Size(52, 16);
            this.tv_contact.TabIndex = 5;
            this.tv_contact.Text = "Contact";
            // 
            // et_contact
            // 
            this.et_contact.Location = new System.Drawing.Point(136, 133);
            this.et_contact.Name = "et_contact";
            this.et_contact.Size = new System.Drawing.Size(196, 22);
            this.et_contact.TabIndex = 4;
            // 
            // tv_address
            // 
            this.tv_address.AutoSize = true;
            this.tv_address.Location = new System.Drawing.Point(34, 167);
            this.tv_address.Name = "tv_address";
            this.tv_address.Size = new System.Drawing.Size(58, 16);
            this.tv_address.TabIndex = 7;
            this.tv_address.Text = "Address";
            // 
            // et_address
            // 
            this.et_address.Location = new System.Drawing.Point(136, 161);
            this.et_address.Name = "et_address";
            this.et_address.Size = new System.Drawing.Size(196, 22);
            this.et_address.TabIndex = 6;
            // 
            // tv_email
            // 
            this.tv_email.AutoSize = true;
            this.tv_email.Location = new System.Drawing.Point(34, 195);
            this.tv_email.Name = "tv_email";
            this.tv_email.Size = new System.Drawing.Size(41, 16);
            this.tv_email.TabIndex = 9;
            this.tv_email.Text = "Email";
            // 
            // et_email
            // 
            this.et_email.Location = new System.Drawing.Point(136, 189);
            this.et_email.Name = "et_email";
            this.et_email.Size = new System.Drawing.Size(196, 22);
            this.et_email.TabIndex = 8;
            // 
            // cb_gender
            // 
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cb_gender.Location = new System.Drawing.Point(136, 217);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(121, 24);
            this.cb_gender.TabIndex = 10;
            // 
            // tv_gender
            // 
            this.tv_gender.AutoSize = true;
            this.tv_gender.Location = new System.Drawing.Point(34, 225);
            this.tv_gender.Name = "tv_gender";
            this.tv_gender.Size = new System.Drawing.Size(52, 16);
            this.tv_gender.TabIndex = 11;
            this.tv_gender.Text = "Gender";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(31, 257);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(112, 257);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(193, 257);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(274, 257);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(274, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(141, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // et_search
            // 
            this.et_search.Location = new System.Drawing.Point(433, 22);
            this.et_search.Name = "et_search";
            this.et_search.Size = new System.Drawing.Size(275, 22);
            this.et_search.TabIndex = 17;
            this.et_search.TextChanged += new System.EventHandler(this.et_search_TextChanged);
            // 
            // dgv_db_data
            // 
            this.dgv_db_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_db_data.Location = new System.Drawing.Point(355, 68);
            this.dgv_db_data.Name = "dgv_db_data";
            this.dgv_db_data.RowHeadersWidth = 51;
            this.dgv_db_data.RowTemplate.Height = 24;
            this.dgv_db_data.Size = new System.Drawing.Size(741, 370);
            this.dgv_db_data.TabIndex = 18;
            this.dgv_db_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_db_data_CellContentClick);
            this.dgv_db_data.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_db_data_RowHeaderMouseClick);
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.dgv_db_data);
            this.Controls.Add(this.et_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tv_gender);
            this.Controls.Add(this.cb_gender);
            this.Controls.Add(this.tv_email);
            this.Controls.Add(this.et_email);
            this.Controls.Add(this.tv_address);
            this.Controls.Add(this.et_address);
            this.Controls.Add(this.tv_contact);
            this.Controls.Add(this.et_contact);
            this.Controls.Add(this.tv_lname);
            this.Controls.Add(this.et_lname);
            this.Controls.Add(this.tv_fname);
            this.Controls.Add(this.et_fname);
            this.Name = "Contact";
            this.Text = "Basic Contact";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_db_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox et_fname;
        private System.Windows.Forms.Label tv_fname;
        private System.Windows.Forms.Label tv_lname;
        private System.Windows.Forms.TextBox et_lname;
        private System.Windows.Forms.Label tv_contact;
        private System.Windows.Forms.TextBox et_contact;
        private System.Windows.Forms.Label tv_address;
        private System.Windows.Forms.TextBox et_address;
        private System.Windows.Forms.Label tv_email;
        private System.Windows.Forms.TextBox et_email;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label tv_gender;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox et_search;
        private System.Windows.Forms.DataGridView dgv_db_data;
    }
}

