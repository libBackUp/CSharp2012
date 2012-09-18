using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls
{
    public partial class PhoneNumber : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string _phoneNumber;
        public string PhoneNumberValue
        {
            get
            {
                _phoneNumber = string.Format("({0}){1}-{2}");
                return _phoneNumber;
            }
        }
    }
}