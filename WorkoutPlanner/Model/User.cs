using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutPlanner.Model
{
    class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Patronomic { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
