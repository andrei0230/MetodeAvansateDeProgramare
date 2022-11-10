using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_02
{
    public class Graf
    {
        public List<Vertex> Vertices;
        public List<Edge> Edges;
        public int[,] Matrix;
        public static float inf = 1e10f;
        
        private List<int> ToR;

        public Graf()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }

        public void LoadFromFile(string filename)
        {
            TextReader reader = new StreamReader(filename);

            int n = int.Parse(reader.ReadLine());
            Matrix = new int[n, n];

            string buffer;

            for(int i = 0; i < n; i++)
            {
                buffer = reader.ReadLine();
                Vertex local = new Vertex(buffer);
                local.Idx = i;
                Vertices.Add(local);
            }
            
            while((buffer=reader.ReadLine()) != null)
            {
                Edge edge = new Edge(buffer);
                Edges.Add(edge);
            }

            reader.Close();

            foreach(Edge edge in Edges)
            {
                Matrix[edge.Start.Idx, edge.End.Idx] = (int)edge.Cost;
                Matrix[edge.End.Idx, edge.Start.Idx] = (int)edge.Cost;
            }
        }

        public List<string> View(System.Windows.Forms.ListBox A)
        {
            List<string> t = new List<string>();
            string b;
            for(int i=0; i < Matrix.GetLength(0); i++)
            {
                b = "";
                for(int j = 0; j < Matrix.GetLength(1); j++)
                {
                    b += Matrix[i, j];
                    b += " ";
                }
                t.Add(b);
                A.Items.Add(b);
            }
            return t;
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

        public void Color()
        {
            int n = Vertices.Count;
            int[] colors = new int[n];

            for(int i = 0; i < n; i++)
            {
                colors[i] = -1;
            }

            colors[0] = 0;

            bool[] Lc = new bool[n];
            

            for(int i = 1; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Lc[j] = false;
                }

                for(int j = 0; j < n; j++)
                {
                    if (Matrix[i,j] != 0)
                    {
                        if (colors[j] != -1)
                        {
                            Lc[colors[j]] = true;
                        }
                    }
                }

                int idx = 0;

                while (Lc[idx])
                {
                    idx++;
                }

                colors[i] = idx;
            }
            
            for(int i = 0; i < n; i++)
            {
                Vertices[i].color = colors[i];
            }
        }

        public List<int> BFS(int ns)
        {
            List<int> tor = new List<int>();
            Queue<int> A = new Queue<int>();
            bool[] v = new bool[Vertices.Count];
            v[ns] = false;
            
            A.Enqueue(ns);

            while(A.Count != 0)
            {
                int x = A.Dequeue();
                tor.Add(x);
                v[x] = true;
                for(int i = 0; i < Vertices.Count; i++)
                {
                    if (Matrix[x,i] != 0 && !v[i])
                    {
                        v[i] = true;
                        A.Enqueue(i);
                    }
                }
            }

            return tor;
        }

        public List<int> DFS(int ns)
        {
            bool[] v = new bool[Vertices.Count];
            v[ns] = true;
            ToR = new List<int>();
            DFSUtils(ns, v);
            return ToR;
        }

        public void DFSUtils(int ns, bool[] v)
        {
            ToR.Add(ns);
            for(int i = 0; i < Vertices.Count; i++)
            {
                if (Matrix[ns, i] != 0 && !v[i])
                {
                    v[i] = true;
                    DFSUtils(i, v);
                }
                    
            }
        }

        public float[] DIJKSTRA(int ns)
        {
            float[] D = new float[Vertices.Count];

            for(int i = 0; i < Vertices.Count; i++)
            {
                D[i] = inf;
            }

            Queue<int> A = new Queue<int>();

            D[ns] = 0;
            A.Enqueue(ns);

            while(A.Count > 0)
            {
                int t = A.Dequeue();
                for(int i = 0; i < Vertices.Count; i++ )
                {
                    if (Matrix[t,i] != 0)
                    {
                        if (D[t] + Matrix[t,i] < D[i])
                        {
                            D[i] = D[t] + Matrix[t,i];
                            A.Enqueue(i);
                        }
                    }
                }
            }

            return D;
        }
        
        public int[] v;

        public int[] Hamilton(int ns)
        {
  
            v = new int[Vertices.Count];
            int[] s = new int[Vertices.Count];
            bool[] b = new bool[Vertices.Count];
            bk(0, Vertices.Count, s, b);
            return v;
        }

        public void bk(int k, int n, int[] s, bool[] b)
        {
            if(k>=n)
            {
                bool ok = true;
                for(int i = 0; i < n-1; i++)
                {
                    if (Matrix[s[i], s[i+1]] == 0)
                        ok = false;
                }
                if(ok)
                {
                    for(int i = 0; i < n; i++)
                    {
                        v[i] = s[i];
                    }
                }
            }

            for(int i = 0; i < n; i++)
            {
                if(!b[i])
                {
                    b[i] = true;
                    s[k] = i;
                    bk(k+1,n,s,b);
                    b[i] = false;
                }
            }
        }
    }
}
