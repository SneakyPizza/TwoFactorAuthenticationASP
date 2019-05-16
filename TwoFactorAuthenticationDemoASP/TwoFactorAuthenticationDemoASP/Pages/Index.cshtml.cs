using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Web;

namespace TwoFactorAuthenticationDemoASP.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            string un = Request.Form["tb_Username"].ToString();
            string pw = Request.Form["tb_Password"].ToString();
            LoginUser(un, pw);
        }

        private void LoginUser(string username, string password)
        {
            if(!string.IsNullOrWhiteSpace(username)&& !string.IsNullOrWhiteSpace(password))
            {

            } else
            {
                Console.WriteLine("not validated");
                
            }
        }

    }
}
