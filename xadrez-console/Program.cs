using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('c', 7);

            Console.WriteLine(posicao);
            Console.WriteLine(posicao.ToPosicao());

            Console.ReadLine();
        }
    }
}
