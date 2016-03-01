using System;
using System.Drawing;

namespace BootstrapASP
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                lblMessage.ForeColor = Color.Black;
                lblMessage.Text = string.Empty;

                var controller = new IdentityManager.Controllers.IdentityDocumentController();
                var isValidResponse = controller.IsValidRsaId(txtId.Text);

                lblMessage.Text = isValidResponse ? "Valid RSA Id" : "Invalid RSA Id";
            }
        }

        private bool IsValidInput()
        {
            lblMessage.Text = string.Empty;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Invalid Input";

                return false;
            }

            return true;
        }
    }
}