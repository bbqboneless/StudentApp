using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto21
{
    class HTMLExporter : Exporter
    {
        public HTMLExporter()
        {
            GetDataFacade df = new GetDataFacade(); ;
        }
        public override bool Download(List<Score> s, string fn)
        {
            try
            {
                using (TextWriter html = new StreamWriter(fn + ".html"))
                {
                    html.Write($"<table>");
                    html.Write($"<tr><th>Subject</th><th>Score</th></tr>");
                    foreach (Score sc in s)
                    {
                        Subject sb = df.GetSubject(sc.subject_id);
                        //User un = df.GetUser(sc.student);
                        html.Write($"<tr><td>" + sb.name + "</td>");
                        html.Write($"<td>" + sc.score + "</td></tr>");
                        html.WriteLine();
                    }
                    html.WriteLine();
                }
            }
            catch (Exception E)
            {
                return false;
            }
            return true;
        }
    }
}
