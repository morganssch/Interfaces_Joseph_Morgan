using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Joseph_Morgan
{
    internal interface IGenre
    {
        string ESRB { get; set; }
        string Genre { get; set; }
        string Title { get; set; }

        string describe();
    }
}
