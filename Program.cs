using EF6.Data;
using EF6.Domain;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF6App
{
    class Program
    {
        private static FootballLeagueDbContext context = new FootballLeagueDbContext();
        static async Task Main(string[] args)
        {
            var teams = context.Teams.ToList();
            var CsakABayern = teams.Where(x=>x.Name.Contains("Bay")).ToList();
            var NameSubstring =  teams.Select(x => x.Name.Substring(0,3)).ToList();
        




            Console.ReadLine();

        }

      
    }
}
