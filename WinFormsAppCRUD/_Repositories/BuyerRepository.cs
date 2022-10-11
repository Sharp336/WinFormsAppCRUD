using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WinFormsAppCRUD.Models;

namespace WinFormsAppCRUD._Repositories
{
    public class BuyerRepository : BaseRepository, IBuyerRepository
    {
        public BuyerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void Add(BuyerModel buyerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Buyer values (@login, @password, @phone, @adress)";
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = buyerModel.Login;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = buyerModel.Password;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = buyerModel.Phone_Number;
                command.Parameters.Add("@adress", SqlDbType.VarChar).Value = buyerModel.Adress;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Buyer where ID_Buyer=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(BuyerModel buyerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Buyer 
                                        set Buyer_Login= @login, Buyer_Password = @password, Buyer_Phone_Number = @phone, Buyer_Address = @adress 
                                        where ID_Buyer = @id";
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = buyerModel.Login;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = buyerModel.Password;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = buyerModel.Phone_Number;
                command.Parameters.Add("@adress", SqlDbType.VarChar).Value = buyerModel.Adress;
                command.Parameters.Add("@id", SqlDbType.Int).Value = buyerModel.ID;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<BuyerModel> GetAll()
        {
            var buyerList = new List<BuyerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Buyer order by ID_Buyer desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var buyerModel = new BuyerModel();
                        buyerModel.ID = (int)reader[0];
                        buyerModel.Login = reader[1].ToString();
                        buyerModel.Password = reader[2].ToString();
                        buyerModel.Phone_Number = reader[3].ToString();
                        buyerModel.Adress = reader[4].ToString();
                        buyerList.Add(buyerModel);
                    }
                }
            }
            return buyerList;
        }

        public IEnumerable<BuyerModel> GetByValue(string value)
        {
            var buyerList = new List<BuyerModel>();
            int buyerID = Int32.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string buyerPhone = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from Buyer
                                        where ID_Buyer=@id or Buyer_Phone_Number like @phone+'%' 
                                        order by ID_Buyer desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = buyerID;
                command.Parameters.Add("@phone", SqlDbType.VarChar).Value = buyerPhone;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var buyerModel = new BuyerModel();
                        buyerModel.ID = (int)reader[0];
                        buyerModel.Login = reader[1].ToString();
                        buyerModel.Password = reader[2].ToString();
                        buyerModel.Phone_Number = reader[3].ToString();
                        buyerModel.Adress = reader[4].ToString();
                        buyerList.Add(buyerModel);
                    }
                }
            }
            return buyerList;
        }
    }
}
