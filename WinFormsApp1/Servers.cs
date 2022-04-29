using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Servers
    {
        public int Id { get; set; }
        
        public string? URL { get; set; }
        public string? Version { get; set; }
        public string? Edition { get; set; }
        public string? ServerCustomName { get; set; }
    }
}
