using System.Diagnostics;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public string mName = string.Empty;

        public Form1()
        {

            InitializeComponent();
            GridUpdate();
            CheckPropetries();

        }
        private void GridUpdate()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var servers = db.Servers.ToList();
                dataGridViewServers.DataSource = servers;
                var offices = db.BackOffice.ToList();
                dataGridViewBackOffices.DataSource = offices;
            }
        }
        private void CheckPropetries()
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.Login) || string.IsNullOrEmpty(Properties.Settings.Default.Passwd))
            {
                MessageBox.Show("Настройки пусты");
            }
            else
            {
                tb_Login.Text = Properties.Settings.Default.Login;
                tb_Passwd.Text = Properties.Settings.Default.Passwd;
            }
        }

        private void btn_AddServer_Click(object sender, EventArgs e)
        {
            BackClient backClient = new BackClient();
            string mUrl = tb_Url.Text;
            string url = backClient.NormilizeURL(mUrl);
            var serverProperties = backClient.GetServerProperties(url);
            if (ServerAlreadyExist(url) != true)
            {
                //if (ServerNeedUpdate(url, serverProperties.Version) == true)
                //{
                //    UpdateServer(url);
                //}
                AddServer();


            }
            else { MessageBox.Show("Server already exist!"); }


            tb_Url.Clear();
            tb_CustomName.Clear();
        }
        private bool ServerAlreadyExist(string url)
        {
            bool exist = false;
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var server in db.Servers)
                {
                    if (server.URL == url)
                    { exist = true; }


                }

            }
            return exist;
        }
        //private bool ServerNeedUpdate(string url, string version)
        //{
        //   bool need = false;
        //   BackClient backClient = new BackClient();
        //   var serverProperties = backClient.GetServerProperties(url);
        //    if (serverProperties.Version != version)
        //   {
        //        need = true;
        //   }


        //    return need;
        //}

        private void AddServer()
        {
            BackClient backClient = new BackClient();
            string mUrl = tb_Url.Text;
            string customName = tb_CustomName.Text;
            string url = backClient.NormilizeURL(mUrl);
            var serverProperties = backClient.GetServerProperties(url);
            using (ApplicationContext db = new ApplicationContext())
            {
                try
                {

                    Servers server = new Servers();
                    server.Edition = serverProperties.Edition;
                    server.Version = serverProperties.Version;
                    server.URL = url;
                    server.ServerCustomName = customName;
                    db.Servers.Add(server);
                    db.SaveChanges();
                    MessageBox.Show("Объекты успешно сохранены");
                    //var servers = db.Servers.ToList();
                    //dataGridViewServers.DataSource = servers;
                    GridUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //private void UpdateServer(string url)
        //{
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        foreach (var server in db.Servers)
        //        {
        //            BackClient backClient = new BackClient();
        //            var serverProperties = backClient.GetServerProperties(url);
        //            server.Version = serverProperties.Version;
        //            db.Servers.Update(server);
        //            db.SaveChanges();
        //            MessageBox.Show("Server version update!");
        //        }
        //    }
        //}
        private void btn_SearchBackOffice_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                BackOffice backOffice = new BackOffice();
                List<BackOffice> backOfficeDirectories = backOffice.Search();


                foreach (var file in backOfficeDirectories)
                {
                    db.BackOffice.Add(file);
                    db.SaveChanges();
                }


                MessageBox.Show("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                //var offices = db.BackOffice.ToList();
                //dataGridViewBackOffices.DataSource = offices;
                GridUpdate();

            }
        }

        private void btn_OpenBackOffice_Click(object sender, EventArgs e)
        {
            var server = dataGridViewServers.CurrentRow;
            var version = server.Cells[2].Value.ToString();
            var edition = server.Cells[3].Value.ToString();
            var url = server.Cells[1].Value.ToString();
            //if (ServerNeedUpdate(url,version))
            //{
            //    UpdateServer(url);
            //}

            try
            {


                string pathToBackOffice = Match(version, edition);
                if (pathToBackOffice != null)
                {
                    Open(pathToBackOffice);
                }
                else
                {
                    MessageBox.Show("pathToBackOffice Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var login = tb_Login.Text;
            var passwd = tb_Passwd.Text;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(passwd) != null)
            {
                BackClient backClient = new BackClient();
                backClient.BackClientConfigEdit(url, login);
                Authorization authorization = new Authorization();
                authorization.AuthorizationMetod(passwd);
            }
            else { MessageBox.Show("login and password are empty"); }

        }
        private string Match(string version, string edition)
        {
            string pathToBackOffice = null;


            if (version != null && edition != null)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    db.BackOffice.ToList();
                    foreach (var file in db.BackOffice.ToList())
                    {
                        if (file.Version.ToLower() == version.ToLower() && edition.ToLower() == file.Edition.ToLower())
                        {
                            pathToBackOffice = file.Path.ToString();
                        }
                        else
                        {


                        }
                    }
                }
            }
            else { MessageBox.Show("version and edition not found"); }
            return pathToBackOffice;

        }
        private void Open(string pathToBackOffice)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = pathToBackOffice;
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_CloseAllBackClient_Click(object sender, EventArgs e)
        {

            BackClient backClient = new BackClient();
            backClient.CloseBackOffice();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if (tb_Search.Text != null)
                using (ApplicationContext db = new ApplicationContext())
                {
                    var servers = db.Servers.ToList().FindAll(x => x.URL.Contains($"{tb_Search.Text}") || x.ServerCustomName.Contains($"{tb_Search.Text}") ||
                                    x.Version.Contains($"{tb_Search.Text}") || x.Edition.Contains($"{tb_Search.Text}"));
                    if (servers != null)
                    {
                        dataGridViewServers.DataSource = servers;
                    }
                }
        }

        private void tb_Url_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            var server = dataGridViewServers.CurrentRow;
            var version = server.Cells[2].Value.ToString();
            var edition = server.Cells[3].Value.ToString();
            var url = server.Cells[1].Value.ToString();
            //if (ServerNeedUpdate(url,version))
            //{
            //    UpdateServer(url);
            //}

            try
            {


                string pathToBackOffice = Match(version, edition);
                if (pathToBackOffice != null)
                {
                    Open(pathToBackOffice);
                }
                else
                {
                    MessageBox.Show("pathToBackOffice Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var login = tb_Login.Text;
            var passwd = tb_Passwd.Text;
            if (login != null && passwd != null)
            {
                BackClient backClient = new BackClient();
                backClient.BackClientConfigEdit(url, login);
                Authorization authorization = new Authorization();
                authorization.AuthorizationMetod(passwd);
            }
            else { MessageBox.Show("login and password are empty"); }

        }

        public void toolStripMenuItem_NameChange_Click(object sender, EventArgs e)
        {

            var currentServer = dataGridViewServers.CurrentRow;
            try
            {
                NameForm nameDialog = new NameForm
                {
                    Owner = this
                };
                nameDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                var server = db.Servers.ToList().FindAll(x => x.URL.Contains(currentServer.Cells[1].Value.ToString()));
                if (server != null)
                {
                    foreach (var s in server)
                    {
                        s.ServerCustomName = mName;
                        db.Update(s);
                        db.SaveChanges();

                    }
                }
                else
                {
                    MessageBox.Show("Server for name change not found!");
                }
            }

            GridUpdate();
        }

        private void toolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_SaveProps_Click(object sender, EventArgs e)
        {
            if (tb_Login.Text !=null && tb_Login.Text.Length > 0 && tb_Passwd.Text != null && tb_Passwd.Text.Length > 0)
            {
                Properties.Settings.Default.Login = tb_Login.Text;
                Properties.Settings.Default.Passwd = tb_Passwd.Text;
                Properties.Settings.Default.Save();
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Login) && !string.IsNullOrEmpty(Properties.Settings.Default.Passwd))
                {
                    MessageBox.Show("Настройки сохранены!");
                }
                else
                { MessageBox.Show("Настройки не сохранены!"); }
                { MessageBox.Show("Настройки не сохранены!"); }
                
            }
        }
    }
}