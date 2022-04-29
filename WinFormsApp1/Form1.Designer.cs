namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBackOffices = new System.Windows.Forms.DataGridView();
            this.dataGridViewServers = new System.Windows.Forms.DataGridView();
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.btn_AddServer = new System.Windows.Forms.Button();
            this.btn_SearchBackOffice = new System.Windows.Forms.Button();
            this.btn_OpenBackOffice = new System.Windows.Forms.Button();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Passwd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBackOffices
            // 
            this.dataGridViewBackOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackOffices.Location = new System.Drawing.Point(3, 246);
            this.dataGridViewBackOffices.MultiSelect = false;
            this.dataGridViewBackOffices.Name = "dataGridViewBackOffices";
            this.dataGridViewBackOffices.RowHeadersWidth = 51;
            this.dataGridViewBackOffices.RowTemplate.Height = 29;
            this.dataGridViewBackOffices.Size = new System.Drawing.Size(803, 201);
            this.dataGridViewBackOffices.TabIndex = 0;
            // 
            // dataGridViewServers
            // 
            this.dataGridViewServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServers.Location = new System.Drawing.Point(3, 7);
            this.dataGridViewServers.MultiSelect = false;
            this.dataGridViewServers.Name = "dataGridViewServers";
            this.dataGridViewServers.ReadOnly = true;
            this.dataGridViewServers.RowHeadersWidth = 51;
            this.dataGridViewServers.RowTemplate.Height = 29;
            this.dataGridViewServers.RowTemplate.ReadOnly = true;
            this.dataGridViewServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServers.Size = new System.Drawing.Size(803, 233);
            this.dataGridViewServers.TabIndex = 1;
            // 
            // tb_Url
            // 
            this.tb_Url.Location = new System.Drawing.Point(850, 12);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(517, 27);
            this.tb_Url.TabIndex = 2;
            // 
            // btn_AddServer
            // 
            this.btn_AddServer.Location = new System.Drawing.Point(1239, 54);
            this.btn_AddServer.Name = "btn_AddServer";
            this.btn_AddServer.Size = new System.Drawing.Size(128, 29);
            this.btn_AddServer.TabIndex = 3;
            this.btn_AddServer.Text = "Add";
            this.btn_AddServer.UseVisualStyleBackColor = true;
            this.btn_AddServer.Click += new System.EventHandler(this.btn_AddServer_Click);
            // 
            // btn_SearchBackOffice
            // 
            this.btn_SearchBackOffice.Location = new System.Drawing.Point(1225, 409);
            this.btn_SearchBackOffice.Name = "btn_SearchBackOffice";
            this.btn_SearchBackOffice.Size = new System.Drawing.Size(128, 29);
            this.btn_SearchBackOffice.TabIndex = 4;
            this.btn_SearchBackOffice.Text = "Search";
            this.btn_SearchBackOffice.UseVisualStyleBackColor = true;
            this.btn_SearchBackOffice.Click += new System.EventHandler(this.btn_SearchBackOffice_Click);
            // 
            // btn_OpenBackOffice
            // 
            this.btn_OpenBackOffice.Location = new System.Drawing.Point(1239, 111);
            this.btn_OpenBackOffice.Name = "btn_OpenBackOffice";
            this.btn_OpenBackOffice.Size = new System.Drawing.Size(128, 29);
            this.btn_OpenBackOffice.TabIndex = 5;
            this.btn_OpenBackOffice.Text = "Open";
            this.btn_OpenBackOffice.UseVisualStyleBackColor = true;
            this.btn_OpenBackOffice.Click += new System.EventHandler(this.btn_OpenBackOffice_Click);
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(975, 179);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(230, 27);
            this.tb_Login.TabIndex = 6;
            // 
            // tb_Passwd
            // 
            this.tb_Passwd.Location = new System.Drawing.Point(975, 223);
            this.tb_Passwd.Name = "tb_Passwd";
            this.tb_Passwd.Size = new System.Drawing.Size(230, 27);
            this.tb_Passwd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 450);
            this.Controls.Add(this.tb_Passwd);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.btn_OpenBackOffice);
            this.Controls.Add(this.btn_SearchBackOffice);
            this.Controls.Add(this.btn_AddServer);
            this.Controls.Add(this.tb_Url);
            this.Controls.Add(this.dataGridViewServers);
            this.Controls.Add(this.dataGridViewBackOffices);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewBackOffices;
        private DataGridView dataGridViewServers;
        private TextBox tb_Url;
        private Button btn_AddServer;
        private Button btn_SearchBackOffice;
        private Button btn_OpenBackOffice;
        private TextBox tb_Login;
        private TextBox tb_Passwd;
    }
}