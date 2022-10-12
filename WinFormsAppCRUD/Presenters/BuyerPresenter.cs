using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppCRUD.Models;
using WinFormsAppCRUD.Views;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsAppCRUD.Presenters
{
    internal class BuyerPresenter
    {
        private IBuyerView view;
        private IBuyerRepository repository;
        private BindingSource buyersBindingSource;
        private IEnumerable<BuyerModel> buyerList;
        private int BuyerCount;
        public BuyerPresenter(IBuyerView view, IBuyerRepository repository)
        {
            this.buyersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.view.SearchEvent += SearchBuyer;
            this.view.AddNewEvent += AddNewBuyer;
            this.view.EditEvent += LoadSelectedBuyerToEdit;
            this.view.DeleteEvent += DeleteSelectedBuyer;
            this.view.SaveEvent += SaveBuyer;
            this.view.CancelEvent += CancelAction;
            this.view.SetBuyerListBindingSource(buyersBindingSource);
            LoadAllBuyerList();
            this.view.Show();

        }

        private void LoadAllBuyerList()
        {
            buyerList = repository.GetAll();
            buyersBindingSource.DataSource = buyerList;
            view.BuyerCount = repository.CountAll().ToString();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
        }


        private void LoadSelectedBuyerToEdit(object? sender, EventArgs e)
        {
            var buyer = (BuyerModel)buyersBindingSource.Current;
            view.BuyerID = buyer.ID.ToString();
            view.BuyerLogin = buyer.Login;
            view.BuyerPassword = buyer.Password;
            view.BuyerPhoneNumber = buyer.Phone_Number;
            view.BuyerAdress = buyer.Adress;
            view.IsEdit = true;
        }

        private void SaveBuyer(object? sender, EventArgs e)
        {
            var model = new BuyerModel();
            model.ID = Convert.ToInt32(view.BuyerID);
            model.Login = view.BuyerLogin;
            model.Password = view.BuyerPassword;
            model.Phone_Number = view.BuyerPhoneNumber;
            model.Adress = view.BuyerAdress;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Buyer edited successfuly";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Buyer added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllBuyerList();
                CleanviewFields();
            }
            catch (Exception ex)
            {

                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.BuyerID = "0";
            view.BuyerLogin = "";
            view.BuyerPassword = "";
            view.BuyerPhoneNumber = "";
            view.BuyerAdress = "";
        }

        private void AddNewBuyer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchBuyer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                buyerList = repository.GetByValue(this.view.SearchValue);
                view.BuyerCount = repository.CountSpecific(this.view.SearchValue).ToString();
            }
            else 
            { 
                buyerList = repository.GetAll();
                view.BuyerCount = repository.CountAll().ToString();
            }

            buyersBindingSource.DataSource = buyerList;
        }
        private void DeleteSelectedBuyer(object? sender, EventArgs e)
        {
            try
            {
                var buyer = (BuyerModel)buyersBindingSource.Current;
                repository.Delete(buyer.ID);
                view.IsSuccessful = true;
                view.Message = "Buyer deleted successfully";
                LoadAllBuyerList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete buyer";
            }
        }
    }
}
