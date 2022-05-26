
using System.Diagnostics;


namespace WinFormsApp1
{
    public class BackOffice
    {
        public int Id { get; set; }
        public string? Path { get; set; }
        public string? Version { get; set; }
        public string? Edition { get; set; }

        public List<BackOffice> Search()
        {
            var files = new List<string>();
            var filesEdgeDefault = new List<string>();
            IEnumerable<string> filesEdgeChain = files.Except(filesEdgeDefault);



            DriveInfo.GetDrives().ToList().ForEach(drive =>
            {
                files.AddRange(EnumerateAllFiles(drive.RootDirectory.FullName, "BackOffice.exe")); //как в лист добавить сптсок элементов
            });
            foreach (var file in files)
            {

                FileVersionInfo fileProperties = FileVersionInfo.GetVersionInfo(file);
                var defaultEdgeDirectories = new List<string>();
                var restoPluginDeliveryFile = EnumerateAllFiles(Directory.GetParent(file).ToString(), "Resto.Plugin.Delivery.dll");
                foreach (var f in restoPluginDeliveryFile)
                {

                    defaultEdgeDirectories.Add(Directory.GetParent(Directory.GetParent(f).FullName).FullName);
                }
                foreach (var dir in defaultEdgeDirectories)
                {
                    if (file.Contains(dir))
                    {
                        filesEdgeDefault.Add(file);
                    }
                }

            }

            List<BackOffice> backOfficeDirectories = new List<BackOffice>();
            foreach (var file in filesEdgeChain)
            {

                BackOffice office = new BackOffice { Path = FileVersionInfo.GetVersionInfo(file).FileName, Version = FileVersionInfo.GetVersionInfo(file).FileVersion, Edition = "Chain" };
                backOfficeDirectories.Add(office);

            }

            foreach (var file in filesEdgeDefault)
            {
                BackOffice office = new BackOffice { Path = FileVersionInfo.GetVersionInfo(file).FileName, Version = FileVersionInfo.GetVersionInfo(file).FileVersion, Edition = "Default" };
                backOfficeDirectories.Add(office);
            }
            return backOfficeDirectories;
        }
        public IEnumerable<string> EnumerateAllFiles(string path, string pattern)
        {

            IEnumerable<string> files = null;
            try { files = Directory.EnumerateFiles(path, pattern); }
            catch (Exception ex)
            { }

            if (files != null)
            {
                foreach (var file in files) yield return file;
            }

            IEnumerable<string> directories = null;
            try { directories = Directory.EnumerateDirectories(path); }
            catch (Exception ex)
            { }

            if (directories != null)
            {
                foreach (var file in directories.SelectMany(d => EnumerateAllFiles(d, pattern)))
                {
                    yield return file;
                }
            }
        }
    }
}
