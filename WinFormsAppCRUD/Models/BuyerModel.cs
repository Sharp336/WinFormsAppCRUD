using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WinFormsAppCRUD.Models
{
    public class BuyerModel
    {
        private int iD;
        private string login;
        private string password;
        private string phone_Number;
        private string adress;

        [DisplayName("ID_Buyer")]
        public int ID
        { get => iD; set => iD = value; }

        [DisplayName("Buyer Login")]
        [Required(ErrorMessage ="Buyer login is required")]
        [StringLength(32, MinimumLength =8, ErrorMessage ="Buyer login must be between 8 and 32 characters")]
        public string Login 
        { get => login; set => login = value; }

        [DisplayName("Buyer Password")]
        [Required(ErrorMessage = "Buyer password is required")]
        [StringLength(32, MinimumLength = 1, ErrorMessage = "Buyer password must be between 1 and 32 characters")]
        public string Password 
        { get => password; set => password = value; }

        [DisplayName("Buyer Phone Number")]
        [Required(ErrorMessage = "Buyer phone number is required")]
        [StringLength(32, MinimumLength = 1, ErrorMessage = "Buyer phone number must be 17 characters long")]
        public string Phone_Number 
        { get => phone_Number; set => phone_Number = value; }

        [DisplayName("Buyer Adress")]
        [Required(ErrorMessage = "Buyer adress number is required")]
        public string Adress 
        { get => adress; set => adress = value; }
    }
}
