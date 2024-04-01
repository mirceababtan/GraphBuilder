using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Data
{
    internal class Vertex
    {
        public required Point Position { get; set; }

        public required double Radius { get; set; }

        public string Notation { get; set; } = "";
    }
}
