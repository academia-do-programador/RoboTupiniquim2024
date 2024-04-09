namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int robosEnviados = 2;

            Robo[] robos = new Robo[robosEnviados];

            for (int robo = 0; robo < robosEnviados; robo++)
            {
                string[] coordenadas = Console.ReadLine().Split(' ');

                Robo roboAtual = new Robo();

                roboAtual.PosicaoX = Convert.ToInt32(coordenadas[0]);
                roboAtual.PosicaoY = Convert.ToInt32(coordenadas[1]);
                roboAtual.Direcao = Convert.ToChar(coordenadas[2]);

                char[] ordens = Console.ReadLine().ToCharArray();

                for (int ordem = 0; ordem < ordens.Length; ordem++)
                {
                    char ordemAtual = ordens[ordem];

                    if (ordemAtual == 'E')
                        roboAtual.VirarEsquerda();

                    else if (ordemAtual == 'D')
                        roboAtual.VirarDireita();

                    else if (ordemAtual == 'M')
                        roboAtual.Mover();
                }

                robos[robo] = roboAtual;
            }

            Console.Clear();

            for (int robo = 0; robo < robos.Length; robo++)
            {
                Console.WriteLine($"{robos[robo].PosicaoX} {robos[robo].PosicaoY} {robos[robo].Direcao}");
            }

            Console.ReadLine();
        }
    }
}
