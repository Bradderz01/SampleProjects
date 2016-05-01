using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    internal class Track : ITrack
    {
        public int Segment { get; set; } = 0;

        public string Name { get; set; } = "test";

        public Activity Activity { get; set; } = Activity.NotSet;
    }
}
