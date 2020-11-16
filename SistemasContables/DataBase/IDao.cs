using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.DataBase
{
    public interface IDao
    {
        bool Insert(object item);
        List<object> getList();
        bool update(object item);
        bool delete(object item);
    }
}
