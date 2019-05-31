using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatten
{


    class FactorypatternExample
    {

        //static void Main()
        //{
        //    ConnectionFactory createcon = null;

        //    Console.Write("Enter the Connection details: ");
        //    string car = Console.ReadLine();

        //    switch (car)
        //    {
        //        case "SQL":
        //            createcon = new CreateSQLconnection("SQL Server Connection String");
        //            break;
        //        case "MYSQL":
        //            createcon = new CreateMySQLconnection("MySQL Server Connection String");
        //            break;
        //        default:
        //            break;
        //    }

        //    Connection con = createcon.GetConnection();
        //    Console.WriteLine(con.ConnectionName);

        //    // Wait for user
        //    Console.ReadKey();
        //}
    }

    public abstract class Connection
    {
        public abstract String ConnectionName { get; set; }
    }

    public class Sql : Connection
    {
        private string _connectionName;

        public Sql(string connectionName)
        {
            _connectionName = connectionName;
        }

        public override string ConnectionName {
            get { return _connectionName; }
            set { _connectionName = value; }
        }
    }

    public class MySql : Connection
    {
        private string _connectionName;

        public MySql(string connectionName)
        {
            _connectionName = connectionName;
        }

        public override string ConnectionName
        {
            get { return _connectionName; }
            set { _connectionName = value; }
        }
    }

    public abstract class ConnectionFactory
    {
        public abstract Connection GetConnection();
    }

    public class CreateSQLconnection : ConnectionFactory
    {
        private string _connstring;
        public CreateSQLconnection(string constring)
        {
            _connstring = constring;
        }

        public override Connection GetConnection()
        {
            return new Sql(_connstring);
        }
    }

    public class CreateMySQLconnection : ConnectionFactory
    {
        private string _connstring;
        public CreateMySQLconnection(string constring)
        {
            _connstring = constring;
        }

        public override Connection GetConnection()
        {
            return new Sql(_connstring);
        }
    }

}
