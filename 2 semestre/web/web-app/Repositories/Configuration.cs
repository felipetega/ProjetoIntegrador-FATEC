namespace web_app.Repositories
{
    public class Configuration
    {
            public static string getConnectionString()
            {
                return "Server=LAB03-D04\\SQLEXPRESS;Database=Loja;Trusted_Connection=True;TrustServerCertificate=True;";
            }
        }
    }
