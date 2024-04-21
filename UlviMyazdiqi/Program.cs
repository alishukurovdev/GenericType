
using System.Threading.Channels;
using UlviMyazdiqi.Models;

namespace UlviMyazdiqi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new ("AB106");
            Group ab207 = new ("AB207");

            List<Student> students = new();
            students.Add(new Student("Ali","Shukurov",20,200,ab106));
            students.Add(new Student("Emil","Pasayev",17,299,ab106));
            students.Add(new Student("BSamir","Karimov",22,301,ab207));
            students.Add(new Student("Sahin","Alizade",23,400,ab207));

            Console.WriteLine("AB106 qrupunda oxuyanlar");
            students.FindAll(s => s.Group == ab106).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Crediti 300den az olan telebeler");
            students.FindAll(s => s.Credits < 300).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" butun telebelerin Ad soyadini yan yana ");
            students.FindAll(s => s ==s).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Adinda b herfi olan telebeler");
            students.FindAll(s => s.Name.ToLower().Contains("b")).ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Telebeleri kredit sayina gore siralari");
            students.OrderBy(s => s.Credits).ToList().ForEach(s => Console.WriteLine(s.Name + " " + s.Credits));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Umumi kreditlerin cemi");
            Console.WriteLine(students.Sum(s => s.Credits));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("18yasindan asagi telebe varmi?");
            Console.WriteLine(students.Any(s=>s.Age<18));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Butun telebeler en az 250 kredit odeyibmi?");
            Console.WriteLine(students.All(s => s.Credits > 250));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Kredit sayi cox olan en kicik telebe.");
            Console.WriteLine(students.OrderBy(p => p.Credits).FirstOrDefault());



            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Serbest task: (Vicdanlilar uchun)\r\n" +
                "Muellim men vicdaliyam:)");

        }
        
    }
}

