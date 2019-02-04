
namespace tnsping
{
    using Oracle.ManagedDataAccess.Client;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var tns = args[0];
            OracleConnection con = new OracleConnection(tns.ToString());

            try
            {
                con.Open();
                Console.WriteLine("Connected to Oracle Database {0}", con.ServerVersion);
                Console.WriteLine("Press RETURN to exit.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
