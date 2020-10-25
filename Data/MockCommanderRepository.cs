using System.Collections.Generic;
using Commander.Models;

namespace commander.Data
{
    public class MockCommanderRepository : IcommanderRepository
    {
        public IEnumerable<Command> GetAppCommands()
        {
            // throw new System.NotImplementedException();
            var commands= new List<Command>
            {
                 new Command{Id = 0 ,Name = "Milad",Family = "Majidian",PhoneNumber = "09171745340"},
                 new Command{Id = 1 ,Name = "Babak",Family = "Bayat",PhoneNumber = "09173199117"},
                 new Command{Id = 2 ,Name = "Behrouz",Family = "Afrasiabi",PhoneNumber = "09366266222"},
                 new Command{Id = 3 ,Name = "Elnaz",Family = "Rahimi",PhoneNumber = "09336266266"},

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
           return new Command{
                Id = 0 ,
                Name = "Milad",
                Family = "Family",
                PhoneNumber = "09171745340"
           };
        }
    }
}