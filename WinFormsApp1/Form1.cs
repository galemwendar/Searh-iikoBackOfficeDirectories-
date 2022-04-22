namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                var offices = db.BackOffice.ToList();
                dataGridView1.DataSource = offices;

            }
        }
    }
}