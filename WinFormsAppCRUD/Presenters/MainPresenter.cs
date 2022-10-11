using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppCRUD.Models;
using WinFormsAppCRUD.Views;
using WinFormsAppCRUD._Repositories;

namespace WinFormsAppCRUD.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowBuyerView += ShowBuyersView;
        }

        private void ShowBuyersView(object sender, EventArgs e)
        {
            IBuyerView view = BuyerView.GetInstace((MainView)mainView);
            IBuyerRepository repository = new BuyerRepository(sqlConnectionString);
            new BuyerPresenter(view, repository);
        }
    }
}
