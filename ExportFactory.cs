using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Proyecto21
{
    class ExportFactory
    {
        public static Exporter ExporterFactory()
        {
            var type = ConfigurationManager.AppSettings["format"];
            if (type == "txt") return new TXTExporter();
            if (type == "html") return new HTMLExporter();
            throw new Exception("Non-supported format!!!");
        }
    }
}