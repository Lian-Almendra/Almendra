namespace Almendra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            data data = new data();

            List<Info> list = data.GetInfo();           
            foreach(var info in informations)
            {
                Console.WriteLine($"Name: {info.Name}\n Course: {info.Course}\n Age: {info.Age}\n\n");
            }*/

            //ORDERBY
            List<Info> names = list.OrderBy(x => x.Age).OrderBy(x => x.Course).ToList();

            foreach (var info in names)
            {
                Console.WriteLine($"Name: {info.Name}\n Course: {info.Course}\n Age: {info.Age}\n\n");

            }

            //GROUPBY
            var grouped = names.GroupBy(x => x.Course);

            foreach (var info in grouped)
            {
                Console.WriteLine($"Course: {info.Key}");
            }

            //FIRST OR DEFAULT

            List<Info> ages = list.OrderByDescending(x => x.Age).ToList();

            var oldest = ages.OrderByDescending(x => x.Age).ToList().FirstOrDefault();
            Console.WriteLine($"Oldest Age is {oldest?.Age}");




















            //var oldestStudent = names.Select(x => x.Name).Where(x => x.).ToList();
            //var oldestStudent = names.Where(x.);
            //var oldestStudent = names.Select(x => x.Name).Where(x => x.Age == 100);
            //Console.WriteLine($"Name of Oldest Student is {oldestStudent.Name}");










            /*Info info1 = new Info();
            info1.Course = "DIT 2-1"; 
            info1.Name = "Geia Almendra";
            info1.Age = 19;

            Info info2 = new Info();
            info2.Course = "DIT 2-1";
            info2.Name = "Xienna";
            info2.Age = 19;

            Info info3 = new Info();
            info3.Course = "DIT 2-1";
            info3.Name = "Pat";
            info3.Age = 22;

            List<Info> list = new List<Info>();
            list.Add(info1);
            list.Add(info2);
            list.Add(info3);

            foreach (Info info in list)
            {
                Console.WriteLine($"Name: {info.Name}\n Course: {info.Course}\n Age: {info.Age}");

            }*/
        }
    }
}