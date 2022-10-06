namespace Curs_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"../../../graf.txt");
            int n = int.Parse(load.ReadLine());

            int[,] a = new int[n, n];

            string buffer;

            while((buffer = load.ReadLine()) != null)
            {
                string[] t = buffer.Split(' ');
                int Ns = int.Parse(t[0]);
                int Ne = int.Parse(t[1]);

                a[Ns, Ne] = 1;
                a[Ne, Ns] = 1;
            }

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{a[i, j]} ");
                Console.WriteLine();
            }

            int counter = 0, nrImpar = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 1) counter++;
                }
                if(counter % 2 == 1) nrImpar++;
            }

            if (nrImpar > 2)
                Console.WriteLine("Graful nu este Eulerian.");
            else
                Console.WriteLine("Graful este Eulerian");

            load.Close();
        }
    }
}