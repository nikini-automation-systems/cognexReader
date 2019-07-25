using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Data.SqlClient;


namespace CongnexProFood
{
    class Program
            {
        static SerialPort SP;
        SqlConnection con;
        
        
        static void Main(string[] args)
                    {
            SqlConnection con;
            string str;
            string bcode;
            string logtime;
            SP = new SerialPort();
            SP.PortName = "COM6";
            SP.BaudRate = 9600;
            SP.DtrEnable = true;
            //SP.WriteLine("+");
            //SP.ReadTimeout = 500;
            try
            {
             str = @"Data Source=localhost;Initial Catalog=Cognex;Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                Console.Write("SQL Connection Open; Press any key to continue");
                Console.ReadLine();

                SP.Open();
                

                while (true)
                    
                {
                   
                    bcode = SP.ReadLine();
                    logtime = DateTime.Now.ToString();
                    Console.WriteLine(logtime + " : " + bcode);
                    string query = "INSERT INTO bcodelog (bcode,logtime) VALUES('"+bcode+"','" +logtime+"')";
                    SqlCommand ins = new SqlCommand(query, con);
                     ins.ExecuteNonQuery();

                    

                }
            }
        catch(SqlException x)
            {

            }
            
            
            }




    }
}
