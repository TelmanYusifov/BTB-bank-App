using BTB_Expense_system.Database;
using BTB_Expense_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTB_Expense_system
{
    public partial class RegisterLoginForm : Form
    {
        public RegisterLoginForm()
        {
            InitializeComponent();

            #region Login Register events
            registercontrol.btn_operation.Click += Btn_operation_Register;
            logincontrol.btn_operation.Click += Btn_operation_Login;
            #endregion
        }

        private void Btn_operation_Login(object sender, EventArgs e)
        {
            
        }

        private void Btn_operation_Register(object sender, EventArgs e)
        {
            string email = registercontrol.txbx_email.Text;
            string password = registercontrol.txbx_password.Text;
            User user = new User
            {
                Email = email,
                Password = password
            };
            ValidationContext vc = new ValidationContext(user);
            List<ValidationResult> vr = new List<ValidationResult>();
            if (Validator.TryValidateObject(user,vc,vr,true))
            {
                if (!string.IsNullOrEmpty(email))
                {
                    DbContext dbContext = new DbContext();
                    User currentuser = dbContext.Users.Find(x => x.Email == email);
                    if(currentuser == null)
                    {

                    }
                }
            }
        }

        private void RegisterLoginForm_Load(object sender, EventArgs e)
        {
            registercontrol.btn_operation.Text = "Register";
            logincontrol.btn_operation.Text = "Login";
        }
    }
}
