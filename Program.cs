using Newtonsoft.Json;
using System;
using System.IO;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Price = 10,
                Name = "A",
                Colour = "white"
            };
           
            //Directory.CreateDirectory(@"C:\Users\Hp\BP201") ;
            //File.Create(@"C:\Users\Hp\BP201\lnr.txt");
            //StreamWriter streamWriter = new StreamWriter(@"C:\Users\Hp\BP201\lnr.txt");
            //streamWriter.WriteLine("Salam");
            //streamWriter.Close();
            //using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Hp\BP201\lnr.txt"))
            //{
            //    streamWriter.WriteLine("Salam");
            //};
           //string p1 = JsonConvert.SerializeObject(product);
           // using (StreamWriter txt = new StreamWriter(@"C:\Users\Hp\Desktop\Elnara\Json\Json\json.json1"))
           // {
           //     txt.Write(p1);
           // }
            string result;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Hp\Desktop\Elnara\Json\Json\json.json1"))
            {
                result = streamReader.ReadToEnd();
            }
            var parseJson = JsonConvert.DeserializeObject<Product>(result);
            Console.WriteLine(parseJson.Price);
        }
    }
}
