using System;

namespace DesafioDoMouseTentativa2
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarInterface();
        }



        private static void MostrarInterface()
        {
            var mouse = new Mouse();

            while (true)
            {
                try
                {
                    Console.Clear();
                    MostrarPosicaoMouse(mouse.Posicao);                    
                    Console.WriteLine($"Você pode mover o mouse nas seguintes posições: 4 para {MovimentosMouse.Esquerda}, 6 para {MovimentosMouse.Direita}," +
                        $" 8 para {MovimentosMouse.Cima}, 2 para {MovimentosMouse.Baixo}");
                    Console.WriteLine("Ou aperte 0 para Sair");
                    var posicaoUsuario = Console.ReadLine();

                    if (posicaoUsuario == "2")
                    {
                        mouse.Movimentar(MovimentosMouse.Baixo);
                        Console.WriteLine("Sua posição atual é " + mouse.Posicao);
                    }
                    else if (posicaoUsuario == "8")
                    {
                        mouse.Movimentar(MovimentosMouse.Cima);
                        Console.WriteLine("Sua posição atual é " + mouse.Posicao);
                    }
                    else if (posicaoUsuario == "4")
                    {
                        mouse.Movimentar(MovimentosMouse.Esquerda);
                        Console.WriteLine("Sua posição atual é " + mouse.Posicao);
                    }
                    else if (posicaoUsuario == "6")
                    {
                        mouse.Movimentar(MovimentosMouse.Direita);
                        Console.WriteLine("Sua posição atual é " + mouse.Posicao);
                    }
                    else if (posicaoUsuario == "0")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido");
                        Console.ReadKey();
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }

        //O código abaixo foi escrito por @tato.barbosa
        private static void MostrarPosicaoMouse(PosicoesMouse posicao)
        {
            Console.Write("\n");
            string[,] posicoes = new string[3, 3] { { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" }, { "[ ]", "[ ]", "[ ]" } };

            foreach (int i in Enum.GetValues(typeof(PosicoesMouse)))
            {
                if (i == ((int)posicao))
                {
                    var row = i / 3;
                    var column = i % 3;

                    posicoes[row, column] = "[X]";
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(posicoes[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }        
    }
}
