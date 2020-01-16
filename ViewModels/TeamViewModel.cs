using SkijumpingTeams.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkijumpingTeams.ViewModels
{
    public class TeamViewModel
    {
        public Team Team { get; set; }
        public IEnumerable<Jumper> Jumpers { get; set; }
        public IEnumerable<Coach> Coaches { get; set; }
    }
}
