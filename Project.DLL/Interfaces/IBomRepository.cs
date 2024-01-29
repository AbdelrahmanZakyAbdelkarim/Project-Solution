using Project.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DLL.Interfaces
{
    internal interface IBomRepository
    {
        IEnumerable<BOM> GetAll();

        BOM Get(int id);

        int Add(BOM entity);

        int Update(BOM entity);

        int Delete(BOM entity);

    }
}
