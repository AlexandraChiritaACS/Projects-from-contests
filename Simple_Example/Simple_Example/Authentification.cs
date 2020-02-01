using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Example
{
    public class Authentification : CodeActivity
    {

        [Category ("Input")]
        public InArgument<string> User { get; set; }

        [Category("Input")]
        public InArgument<string> Password { get; set; }

        // Adresa de email, pentru trimiterea informatiilor
        [Category("Output")]
        public OutArgument<string> Email { get; set; }

        [Category("Output")]
        public OutArgument<bool> Connected { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            //Connected.Set(context, false);
                SqlConnection connessione = new SqlConnection("Server=tcp:contentprotector.database.windows.net,1433;Initial Catalog=Registrations;Persist Security Info=False;User ID=admin123;Password=iesiafara123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                connessione.Open();
                SqlCommand cmd = new SqlCommand("select * from AccessAuth", connessione);
                SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // Autentificare cu succes
                    if (dr.GetString(0).Equals(User.Get(context).ToString()) && dr.GetString(2).Equals(Password.Get(context).ToString()))
                    {
                        Email.Set(context, dr.GetString(1));
                        Connected.Set(context, true);
                        break;
                    }

                }
            }
                
                dr.Close();
                connessione.Close();
               
        }
    }
}
