using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCRUD.Models
{
    internal interface IBuyerRepository
    {
        void Add(BuyerModel buyerModel);
        void Edit(BuyerModel buyerModel);
        int Delete(int id);
        IEnumerable<BuyerModel> GetAll();
        IEnumerable<BuyerModel> GetByValue(string value);
        int CountAll();
        int CountSpecific(string value);
    }
}
