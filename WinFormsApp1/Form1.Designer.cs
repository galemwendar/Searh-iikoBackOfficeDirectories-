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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewBackOffices = new System.Windows.Forms.DataGridView();
            this.dataGridViewServers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_Servers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_NameChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.btn_AddServer = new System.Windows.Forms.Button();
            this.btn_SearchBackOffice = new System.Windows.Forms.Button();
            this.btn_OpenBackOffice = new System.Windows.Forms.Button();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Passwd = new System.Windows.Forms.TextBox();
            this.btn_CloseAllBackClient = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_CustomName = new System.Windows.Forms.TextBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackOffices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).BeginInit();
            this.contextMenuStrip_Servers.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBackOffices
            // 
            this.dataGridViewBackOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBackOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBackOffices.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewBackOffices.MultiSelect = false;
            this.dataGridViewBackOffices.Name = "dataGridViewBackOffices";
            this.dataGridViewBackOffices.RowHeadersWidth = 51;
            this.dataGridViewBackOffices.RowTemplate.Height = 29;
            this.dataGridViewBackOffices.Size = new System.Drawing.Size(996, 594);
            this.dataGridViewBackOffices.TabIndex = 0;
            // 
            // dataGridViewServers
            // 
            this.dataGridViewServers.ColumnHeadersHeight = 29;
            this.dataGridViewServers.ContextMenuStrip = this.contextMenuStrip_Servers;
            this.dataGridViewServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServers.Location = new System.Drawing.Point(3, 106);
            this.dataGridViewServers.MultiSelect = false;
            this.dataGridViewServers.Name = "dataGridViewServers";
            this.dataGridViewServers.ReadOnly = true;
            this.dataGridViewServers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewServers.RowTemplate.Height = 29;
            this.dataGridViewServers.RowTemplate.ReadOnly = true;
            this.dataGridViewServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewServers.Size = new System.Drawing.Size(996, 486);
            this.dataGridViewServers.TabIndex = 1;
            // 
            // contextMenuStrip_Servers
            // 
            this.contextMenuStrip_Servers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Servers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NameChange,
            this.toolStripMenuItem_Open,
            this.toolStripMenuItem_Delete});
            this.contextMenuStrip_Servers.Name = "contextMenuStrip_Servers";
            this.contextMenuStrip_Servers.Size = new System.Drawing.Size(170, 76);
            // 
            // toolStripMenuItem_NameChange
            // 
            this.toolStripMenuItem_NameChange.Name = "toolStripMenuItem_NameChange";
            this.toolStripMenuItem_NameChange.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem_NameChange.Text = "Change name";
            this.toolStripMenuItem_NameChange.Click += new System.EventHandler(this.toolStripMenuItem_NameChange_Click);
            // 
            // toolStripMenuItem_Open
            // 
            this.toolStripMenuItem_Open.Name = "toolStripMenuItem_Open";
            this.toolStripMenuItem_Open.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem_Open.Text = "Open";
            this.toolStripMenuItem_Open.Click += new System.EventHandler(this.toolStripMenuItem_Open_Click);
            // 
            // toolStripMenuItem_Delete
            // 
            this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            this.toolStripMenuItem_Delete.Size = new System.Drawing.Size(169, 24);
            this.toolStripMenuItem_Delete.Text = "Delete";
            this.toolStripMenuItem_Delete.Click += new System.EventHandler(this.toolStripMenuItem_Delete_Click);
            // 
            // tb_Url
            // 
            this.tb_Url.Location = new System.Drawing.Point(112, 14);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(328, 27);
            this.tb_Url.TabIndex = 2;
            this.tb_Url.TextChanged += new System.EventHandler(this.tb_Url_TextChanged);
            // 
            // btn_AddServer
            // 
            this.btn_AddServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddServer.Location = new System.Drawing.Point(889, 12);
            this.btn_AddServer.Name = "btn_AddServer";
            this.btn_AddServer.Size = new System.Drawing.Size(104, 29);
            this.btn_AddServer.TabIndex = 3;
            this.btn_AddServer.Text = "Add";
            this.btn_AddServer.UseVisualStyleBackColor = true;
            this.btn_AddServer.Click += new System.EventHandler(this.btn_AddServer_Click);
            // 
            // btn_SearchBackOffice
            // 
            this.btn_SearchBackOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SearchBackOffice.Location = new System.Drawing.Point(828, 603);
            this.btn_SearchBackOffice.Name = "btn_SearchBackOffice";
            this.btn_SearchBackOffice.Size = new System.Drawing.Size(171, 48);
            this.btn_SearchBackOffice.TabIndex = 4;
            this.btn_SearchBackOffice.Text = "Search";
            this.btn_SearchBackOffice.UseVisualStyleBackColor = true;
            this.btn_SearchBackOffice.Click += new System.EventHandler(this.btn_SearchBackOffice_Click);
            // 
            // btn_OpenBackOffice
            // 
            this.btn_OpenBackOffice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OpenBackOffice.Location = new System.Drawing.Point(854, 2);
            this.btn_OpenBackOffice.Name = "btn_OpenBackOffice";
            this.btn_OpenBackOffice.Size = new System.Drawing.Size(139, 48);
            this.btn_OpenBackOffice.TabIndex = 5;
            this.btn_OpenBackOffice.Text = "Open";
            this.btn_OpenBackOffice.UseVisualStyleBackColor = true;
            this.btn_OpenBackOffice.Click += new System.EventHandler(this.btn_OpenBackOffice_Click);
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(8, 57);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(230, 27);
            this.tb_Login.TabIndex = 6;
            // 
            // tb_Passwd
            // 
            this.tb_Passwd.Location = new System.Drawing.Point(8, 133);
            this.tb_Passwd.Name = "tb_Passwd";
            this.tb_Passwd.Size = new System.Drawing.Size(230, 27);
            this.tb_Passwd.TabIndex = 7;
            // 
            // btn_CloseAllBackClient
            // 
            this.btn_CloseAllBackClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CloseAllBackClient.Location = new System.Drawing.Point(3, 2);
            this.btn_CloseAllBackClient.Name = "btn_CloseAllBackClient";
            this.btn_CloseAllBackClient.Size = new System.Drawing.Size(145, 48);
            this.btn_CloseAllBackClient.TabIndex = 8;
            this.btn_CloseAllBackClient.Text = "Close All";
            this.btn_CloseAllBackClient.UseVisualStyleBackColor = true;
            this.btn_CloseAllBackClient.Click += new System.EventHandler(this.btn_CloseAllBackClient_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 693);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Servers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewServers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1002, 654);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_CloseAllBackClient);
            this.panel2.Controls.Add(this.btn_OpenBackOffice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 53);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close All";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_CustomName);
            this.panel1.Controls.Add(this.tb_Search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_Url);
            this.panel1.Controls.Add(this.btn_AddServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 97);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add name";
            // 
            // tb_CustomName
            // 
            this.tb_CustomName.Location = new System.Drawing.Point(535, 14);
            this.tb_CustomName.Name = "tb_CustomName";
            this.tb_CustomName.Size = new System.Drawing.Size(328, 27);
            this.tb_CustomName.TabIndex = 7;
            // 
            // tb_Search
            // 
            this.tb_Search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_Search.Location = new System.Drawing.Point(0, 70);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(996, 27);
            this.tb_Search.TabIndex = 6;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add server";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewBackOffices, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_SearchBackOffice, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1002, 654);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tb_Login);
            this.tabPage3.Controls.Add(this.tb_Passwd);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1008, 660);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Properties";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 693);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBackOffices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).EndInit();
            this.contextMenuStrip_Servers.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

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
        private Button btn_CloseAllBackClient;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tabPage3;
        private Panel panel2;
        private Button button1;
        private TextBox tb_Search;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox tb_CustomName;
        private ContextMenuStrip contextMenuStrip_Servers;
        private ToolStripMenuItem toolStripMenuItem_NameChange;
        private ToolStripMenuItem toolStripMenuItem_Open;
        private ToolStripMenuItem toolStripMenuItem_Delete;
        private Label label5;
    }
}