namespace ScrapingAhCuanto
{
    internal class Conexion
    {
        private string datasource = @"23.101.176.60";//your server
        private string database = "AhCuantoUPCDB"; //your database name
        private string username = "UsrAdminAhCuanto"; //username of server to connect
        private string password = "w&PH4nEKXx9B"; //password

        //your connection string 
        private string connString ;

        public Conexion()
        {
            connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
        }


        string getConection()
        {
            return connString;
        }


    }
}
