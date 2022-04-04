using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto21
{
    class TXTExporter : Exporter
    {
        public TXTExporter()
        {
            GetDataFacade df = new GetDataFacade(); ;
        }
        public override bool Download(List<Score> s, string fn)
        {
            try
            {
                using (TextWriter txt = new StreamWriter(fn + ".txt"))
                {
                    foreach (Score sc in s)
                    {
                        Subject sb = df.GetSubject(sc.subject_id);
                        User un = df.GetUser(sc.student);
                        txt.Write(un.name);
                        txt.WriteLine();
                        txt.Write(sb.name + " ");
                        txt.Write(sc.score);
                    }
                    txt.WriteLine();
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