using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.DataBase
{
    public interface IDao
    {
        void Insert(object item);
        List<object> getList();
        void update(object item);
        void delete(object item);
    }
}
