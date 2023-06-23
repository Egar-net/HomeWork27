using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IDataVisualizer<T>
    {
        void VisualizeData();
    }

    public abstract class DataStrukture
    {
        protected List<object> data;

        public DataStrukture()
        {
            data = new List<object>();
        }
    }
}
