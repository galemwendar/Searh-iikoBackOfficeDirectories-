

using System.Diagnostics;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public class BackClient
    {
        public string NormilizeURL(string mUrl)
        {
            if (!mUrl.Contains("https://") && mUrl.Contains("iiko.it"))
            {
                mUrl = "https://" + mUrl;
            }

            else if (!mUrl.Contains("http://") && !mUrl.Contains("iiko.it"))
            {
                mUrl = "http://" + mUrl;
            }

            if (!mUrl.Contains("/resto"))
            { mUrl = mUrl + "/resto"; }

            return mUrl;
        }
        public ServerProperties GetServerProperties(string mUrl)
        {



            var url = NormilizeURL(mUrl) + "/get_server_info.jsp?encoding=UTF-8";
            UrlService urlService = new UrlService();

            var serverProperties = urlService.GetServerProperties(url);
            return serverProperties;
        }
        public void BackClientConfigEdit(string url, string login)
        {

            var serverProperties = GetServerProperties(url);
            string roamingpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string backclientconfig = "";
            if (serverProperties.Edition == "chain")
            {
                backclientconfig = roamingpath + @"\iiko\Chain\Default\config\backclient.config.xml";
            }
            else
            {
                backclientconfig = roamingpath + @"\iiko\Rms\Default\config\backclient.config.xml";
            }

            XElement userList = XElement.Load(backclientconfig);
            userList.RemoveAll();


            var uriparser = new Uri(url);
            var serverListXml = new XElement("ServersList",
                                        new XElement("ServerName", serverProperties.ServerName),
                                        new XElement("Version", serverProperties.Version),
                                        new XElement("ComputerName", serverProperties.computerName),
                                        new XElement("Protocol", uriparser.Scheme),
                                        new XElement("ServerAddr", uriparser.Host),
                                        new XElement("ServerSubUrl", uriparser.PathAndQuery),
                                        new XElement("Port", uriparser.Port.ToString()),
                                        new XElement("IsPresent", serverProperties.isPresent)
                                        );


            userList.Add(serverListXml);
            var loginXElement = new XElement("Login", login);
            userList.Element("ServersList").AddAfterSelf(loginXElement);
            userList.Save(backclientconfig);

        }

        public void CloseBackOffice()
        {
            Process[] allBackOfficeProcess = Process.GetProcessesByName("BackOffice");
            foreach (var backOfficeProcess in allBackOfficeProcess)
            {
                backOfficeProcess.Kill();
            }

        }
    }
}
