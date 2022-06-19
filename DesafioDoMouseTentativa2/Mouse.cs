using System;

namespace DesafioDoMouseTentativa2
{
    class Mouse
    {
        public PosicoesMouse Posicao { get; private set; }
        public Mouse()
        {
            Posicao = PosicoesMouse.Centro;
        }

        public void Movimentar(MovimentosMouse movimento)
        {
            if (movimento == MovimentosMouse.Direita)
            {
                MovimentarDireita();
            }
            else if (movimento == MovimentosMouse.Esquerda)
            {
                MovimentarEsquerda();
            }
            else if (movimento == MovimentosMouse.Cima)
            {
                MovimentarCima();
            }
            else if (movimento == MovimentosMouse.Baixo)
            {
                MovimentarBaixo();
            }
        }

        private void MovimentarDireita()
        {
            if (Posicao == PosicoesMouse.Centro)
            {
                Posicao = PosicoesMouse.CentroDireita;
            }
            else if (Posicao == PosicoesMouse.BaixoCentro)
            {
                Posicao = PosicoesMouse.BaixoDireita;
            }
            else if (Posicao == PosicoesMouse.CimaCentro)
            {
                Posicao = PosicoesMouse.CimaDireita;
            }
            else if (Posicao == PosicoesMouse.CimaEsquerda)
            {
                Posicao = PosicoesMouse.CimaCentro;
            }
            else if (Posicao == PosicoesMouse.CentroEsquerda)
            {
                Posicao = PosicoesMouse.Centro;
            }
            else if (Posicao == PosicoesMouse.BaixoEsquerda)
            {
                Posicao = PosicoesMouse.BaixoCentro;
            }
            else
            {
                throw new Exception("Você não pode mover o mouse para essa posição");
            }
        }
        private void MovimentarEsquerda()
        {
            if (Posicao == PosicoesMouse.CimaDireita)
            {
                Posicao = PosicoesMouse.CimaCentro;
            }
            else if (Posicao == PosicoesMouse.CentroDireita)
            {
                Posicao = PosicoesMouse.Centro;
            }
            else if (Posicao == PosicoesMouse.BaixoDireita)
            {
                Posicao = PosicoesMouse.BaixoCentro;
            }
            else if (Posicao == PosicoesMouse.CimaCentro)
            {
                Posicao = PosicoesMouse.CimaEsquerda;
            }
            else if (Posicao == PosicoesMouse.Centro)
            {
                Posicao = PosicoesMouse.CentroEsquerda;
            }
            else if (Posicao == PosicoesMouse.BaixoCentro)
            {
                Posicao = PosicoesMouse.BaixoEsquerda;
            }
            else
            {
                throw new Exception("Você não pode mover o mouse para essa posição");
            }
        }
        private void MovimentarCima()
        {
            if (Posicao == PosicoesMouse.BaixoDireita)
            {
                Posicao = PosicoesMouse.CentroDireita;
            }
            else if (Posicao == PosicoesMouse.CentroDireita)
            {
                Posicao = PosicoesMouse.CimaDireita;
            }
            else if (Posicao == PosicoesMouse.BaixoCentro)
            {
                Posicao = PosicoesMouse.Centro;
            }
            else if (Posicao == PosicoesMouse.Centro)
            {
                Posicao = PosicoesMouse.CimaCentro;
            }
            else if (Posicao == PosicoesMouse.BaixoEsquerda)
            {
                Posicao = PosicoesMouse.CentroEsquerda;
            }
            else if (Posicao == PosicoesMouse.CentroEsquerda)
            {
                Posicao = PosicoesMouse.CimaEsquerda;
            }
            else
            {
                throw new Exception("Você não pode mover o mouse para essa posição");
            }
        }
        private void MovimentarBaixo()
        {
            if (Posicao == PosicoesMouse.CimaEsquerda)
            {
                Posicao = PosicoesMouse.CentroEsquerda;
            }
            else if (Posicao == PosicoesMouse.CentroEsquerda)
            {
                Posicao = PosicoesMouse.BaixoEsquerda;
            }
            else if (Posicao == PosicoesMouse.CimaCentro)
            {
                Posicao = PosicoesMouse.Centro;
            }
            else if (Posicao == PosicoesMouse.Centro)
            {
                Posicao = PosicoesMouse.BaixoCentro;
            }
            else if (Posicao == PosicoesMouse.CimaDireita)
            {
                Posicao = PosicoesMouse.CentroDireita;
            }
            else if (Posicao == PosicoesMouse.CentroDireita)
            {
                Posicao = PosicoesMouse.BaixoDireita;
            }
            else
            {
                throw new Exception("Você não pode mover o mouse para essa posição");
            }
        }
    }
}
