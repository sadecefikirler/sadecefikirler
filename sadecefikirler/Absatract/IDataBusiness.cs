using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sadecefikirler.Absatract
{
    public interface IDataBusiness<T> where T : class
    {
        void InsertData(T model);
        void UpdateData(T model);
        void DeleteData(T model);
        T SelectData(int id);
        List<T> ListData();
    }
}
