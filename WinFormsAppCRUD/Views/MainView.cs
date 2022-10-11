using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppCRUD.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnBuyers.Click += delegate { ShowBuyerView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowBuyerView;
        public event EventHandler ShowSupplierView;
        public event EventHandler ShowCharacteristicsView;

    }
}
