using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfonso_Marina_App
{
    class Conexion_BD
    {
        public void conexion()
        {
           
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "alan.database.windows.net";
                builder.UserID = "admin2";
                builder.Password = "password01.";
                builder.InitialCatalog = "bd_alfonso_marina";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    
                    Console.WriteLine("Conexion Correcta\n");
                    
                        
                    }
                
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Console.ReadLine();
        }
    }
}

