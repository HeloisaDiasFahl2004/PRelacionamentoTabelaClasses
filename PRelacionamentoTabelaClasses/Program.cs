using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;
using System.Data.Entity;
namespace PRelacionamentoTabelaClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Team t = new Team() { Name = "Mercedes" };
             BaseContext context = new BaseContext();
            //  // context.Teams.Add(t);
            // // context.SaveChanges();
            //  var team = context.Teams.ToList();

            //  foreach (var item in team)
            //  {
            //      Console.WriteLine(item.ToString());//exibe nome das equipes
            //  }
            //  Console.ReadKey();
            //  Console.WriteLine("Nome da equipe: ");
            //  string n = Console.ReadLine();
            //  Team ts = new Team();
            //  foreach (var item in team)
            //  {
            //      if (n == item.Name)//exibe nome das equipes
            //      {
            //          ts = item;
            //      }
            //  }
            //  Car c = new Car() { Name = "Relampago  F1", Team = ts };
            //  context.Cars.Add(c);
            //  context.SaveChanges();


            var cars = new BaseContext().Cars.Include(item => item.Team);
            foreach (var item in cars)
            {
                Console.WriteLine("\n" + item.ToString());
            }

            Console.ReadKey();
        }
    }
}
