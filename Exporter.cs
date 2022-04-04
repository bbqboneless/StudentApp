using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto21
{
    abstract class Exporter
    {
        //pura interfaz, referir a los concretos de una forma general
        public abstract bool Download(List<Score> s, string fn);
        protected GetDataFacade df = new GetDataFacade();
    }
}