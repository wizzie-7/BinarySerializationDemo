using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BinarySerializationDemo
{
    [Serializable] //serializing an object to binary
    public class Employee
    {
        public string EmployeeName { get; set; } = "Vivek Jadhav";
        public int EmployeeId { get; set; } = 1001;
    }
    
    class BinarySerializationEx
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            FileStream fileStream = new FileStream(@"D:\wizzie\DOT NET\Questions1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, emp);
            //Console.WriteLine(formatter.Serialize(fileStream, emp));

            Employee deemp = new Employee();
            FileStream fileStream1 = new FileStream(@"D:\wizzie\DOT NET\Questions1.txt", FileMode.Create);
            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter.Serialize(fileStream1, deemp);

        }
    }
}
