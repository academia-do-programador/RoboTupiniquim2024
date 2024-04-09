namespace RoboTupiniquim.ConsoleApp
{
    public class Robo
    {
        public int PosicaoX;
        public int PosicaoY;
        public char Direcao;

        public void Mover()
        {
            if (Direcao == 'N')
                PosicaoY++;

            else if (Direcao == 'S')
                PosicaoY--;

            else if (Direcao == 'O')
                PosicaoX--;

            else if (Direcao == 'L')
                PosicaoX++;
        }

        public void VirarDireita()
        {
            if (Direcao == 'N')
                Direcao = 'L';

            else if (Direcao == 'L')
                Direcao = 'S';

            else if (Direcao == 'S')
                Direcao = 'O';

            else if (Direcao == 'O')
                Direcao = 'N';

        }

        public void VirarEsquerda()
        {
            if (Direcao == 'N')
                Direcao = 'O';

            else if (Direcao == 'O')
                Direcao = 'S';

            else if (Direcao == 'S')
                Direcao = 'L';

            else if (Direcao == 'L')
                Direcao = 'N';
        }
    }
}
