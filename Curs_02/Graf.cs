using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_02
{
    public class Graf
    {
        public List<Vertex> Vertices;
        public List<Edge> Edges;

        public Graf()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void LoadFromFile(string filename)
        {
            TextReader reader = new StreamReader(filename);

            int n = int.Parse(reader.ReadLine());

            string buffer;

            for(int i = 0; i < n; i++)
            {
                buffer = reader.ReadLine();
                Vertex local = new Vertex(buffer);
                Vertices.Add(local);
            }
            
            while((buffer=reader.ReadLine()) != null)
            {
                Edge edge = new Edge(buffer);
                Edges.Add(edge);
            }
        }

        public void Draw(Graphics h)
        {
            foreach(Vertex v in Vertices)
            {
                v.Draw(h);
            }
            foreach(Edge e in Edges)
            {
                e.Draw(h);
            }
        }

    }
}
