using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsAppCRUD.Views
{
    public partial class BuyerView : Form, IBuyerView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public BuyerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageBuyerDetail);
            btnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            btnAddNew.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageBuyerList);
                tabControl1.TabPages.Add(tabPageBuyerDetail);
                tabPageBuyerDetail.Text = "Add new buyer";
            };
            btnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageBuyerList);
                tabControl1.TabPages.Add(tabPageBuyerDetail);
                tabPageBuyerDetail.Text = "Edit buyer";
            };
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageBuyerDetail);
                    tabControl1.TabPages.Add(tabPageBuyerList);
                }
                MessageBox.Show(Message);
            };
            btnCancel.Click += delegate 
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageBuyerDetail);
                tabControl1.TabPages.Add(tabPageBuyerList);
            };
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected buyer?", "Warning",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string BuyerID { get => txtBuyerId.Text; set { txtBuyerId.Text = value; } }
        public string BuyerLogin { get => txtBuyerLogin.Text; set { txtBuyerLogin.Text = value; } }
        public string BuyerPassword { get => txtBuyerPassword.Text; set { txtBuyerPassword.Text = value; } }
        public string BuyerPhoneNumber { get => txtBuyerPhoneNumber.Text; set { txtBuyerPhoneNumber.Text = value; } }
        public string BuyerAdress { get => txtBuyerAdress.Text; set { txtBuyerAdress.Text = value; } }
        public string SearchValue { get => txtSearch.Text; set { txtSearch.Text = value; } }
        public bool IsEdit { get => isEdit; set {isEdit = value; } }
        public bool IsSuccessful { get => isSuccessful; set { isSuccessful = value; } }
        public string Message { get => message; set { message = value; } }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler DeleteEvent;

        public void SetBuyerListBindingSource(BindingSource buyerList)
        {
            dataGridView.DataSource = buyerList;
        }

        private static BuyerView instance;
        public static BuyerView GetInstace(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new BuyerView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

    }
}
