using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCRUD.Views
{
    public interface IMainView
    {
        event EventHandler ShowBuyerView;
        event EventHandler ShowSupplierView;
        event EventHandler ShowCharacteristicsView;
    }
}
