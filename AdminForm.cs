using CoffeeManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManager
{
    public partial class AdminForm : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public AdminForm(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        void ChangeAccount(int type)
        {

        }
    }
}
