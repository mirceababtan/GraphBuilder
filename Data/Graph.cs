using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Data
{
    internal class Graph
    {
        public List<Vertex>? Vertices {  get; set; }

        public int[,]? EdgeMap { get; set; }

        public int EdgeCount { get; set; }
    }
}
