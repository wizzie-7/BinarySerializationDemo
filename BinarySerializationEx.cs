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
            FileStream fileStream = new FileStream(@"D:\wizzie\DOT NET\Questions2.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, emp);
            //Employee deserializedSampledemo = (Employee)formatters.Deserialize(fileStreams);
            //Console.WriteLine(emp.EmployeeName,emp.EmployeeId);

            //Employee deemp = new Employee();
            FileStream fileStreams = new FileStream(@"D:\wizzie\DOT NET\Questions3.txt", FileMode.Open);
            BinaryFormatter formatters = new BinaryFormatter();
            Employee deserializedSampledemo = (Employee)formatters.Deserialize(fileStreams);
            Console.WriteLine($"ApplicationName { deserializedSampledemo.EmployeeName} --- ApplicationId       { deserializedSampledemo.EmployeeId}");

        }
    }
}
