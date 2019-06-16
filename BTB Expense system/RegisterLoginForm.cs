using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            
        }

        private void RegisterLoginForm_Load(object sender, EventArgs e)
        {
            registercontrol.btn_operation.Text = "Register";
            logincontrol.btn_operation.Text = "Login";
        }
    }
}
