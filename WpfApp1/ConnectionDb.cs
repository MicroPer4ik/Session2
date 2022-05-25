using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1
{
    public static class ConnectionDb
    {
        public static ContextDb Context { get; set; }
        public static Users User { get; set; }
    }
}
