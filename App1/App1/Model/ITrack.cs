using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    public interface ITrack
    {
        int Segment { get; set; }

        string Name { get; set; }

        Activity Activity { get; set; }
    }
}
