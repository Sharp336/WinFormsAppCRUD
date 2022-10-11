using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppCRUD.Views
{
    public interface IBuyerView
    {
        string BuyerID { get; set; }
        string BuyerLogin { get; set; }
        string BuyerPassword { get; set; }
        string BuyerPhoneNumber { get; set; }
        string BuyerAdress { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetBuyerListBindingSource(BindingSource buyerList);
        void Show();
    }
}
