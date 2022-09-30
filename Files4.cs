using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Serialization
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TE_CSharp
{
    /// <summary>
    /// [Serializable] -> Attribute used in the concept of Serialization
    /// </summary>
    [Serializable]
    class Serialize_Demo
    {
        public int empid;
        public string empname;
        public string empdept;

        public static void Main()
        {
            Serialize_Demo demo = new Serialize_Demo();
            demo.empid = 100;
            demo.empname = "John";
            demo.empdept = "IT";

            //Base(IFormatter)->Derived(BinaryFormatter)
            //BinaryFormatter->Serilalize and DeSerialize
            IFormatter formatter = new BinaryFormatter();

            //Base(Stream-abstract class)->Derived(FileStream)
            Stream stream = new FileStream(@"E:\TESerialize.txt",FileMode.OpenOrCreate, FileAccess.ReadWrite,FileShare.None);
            //Invoke the Serialize method from BinaryFormatter 
            formatter.Serialize(stream, demo); //stream(instance of the Filestream),demo(instance of the class i.e demo.empid & demo.empname)
            stream.Close();

            //Base(Stream-abstract class)->Derived(FileStream)
            stream = new FileStream(@"E:\TESerialize.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            //formatter.Deserialize(stream)->fetch the details from the TESerialize.txt
            //(Serialize_Demo)formatter.Deserialize(stream) -> typecast the fetched details into object and store in serialize_Demo instance
            Serialize_Demo serialize_Demo =(Serialize_Demo)formatter.Deserialize(stream);
            Console.WriteLine(serialize_Demo.empid); //100
            Console.WriteLine(serialize_Demo.empname); //John
            Console.WriteLine(serialize_Demo.empdept); //IT
        }

    }
}
