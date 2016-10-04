using Chinook.Framework.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ///Assuming the customer is logged in, we could get his/her customer ID. But, for now, pretend the CustomerID is 1
            int customerID = 1;
            CustomerManager manager = new CustomerManager();
            var theProfile = manager.GetProfile(customerID);
            //TODO: Get the rest of the items here!
        }
    }
}