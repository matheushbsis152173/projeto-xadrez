using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Xadrez {
    class Program {
        static void Main(string[] args) {
            int V_inicial, vazao, tempo, V_Final;

            V_inicial = int.Parse(Console.ReadLine());
            vazao = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            if (vazao * tempo > V_inicial) {
                Console.WriteLine("Não é possivel");
            }
            else {
                V_Final = V_inicial - (vazao * tempo);
                Console.WriteLine(V_Final);
            }
            Console.ReadLine();
        }
    }
}
