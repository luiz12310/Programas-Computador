using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provaPweb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante1 = new Fabricante("Positivo", 100);
            Fabricante fabricante2 = new Fabricante("LeNovo", 101);

            Programa app1 = new Programa("Youtube", "app de músicas", "https:/youtube" ,1, 20);
            Programa app2 = new Programa("Facebook", "app de memes", "https:/facebook", 2, 30);
            Programa app3 = new Programa("instagram", "app de fotos", "https:/instagram", 3, 20);

            List<Programa> programas = new List<Programa>();

            programas.Add(app1);
            programas.Add(app2);
            programas.Add(app3);

            Computador computador1 = new Computador("intel 7.0", 512, fabricante1, null);
            Computador computador2 = new Computador("intel 7.0", 512, fabricante2, null);
            Computador computador3 = new Computador("intel 15.0", 1024, fabricante1, null);

            List<Computador> computadores = new List<Computador>();

            computadores.Add(computador1);
            computadores.Add(computador2);
            computadores.Add(computador3);
 
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Informações de computadores");
            for (var indice = 0; indice < computadores.Count; indice++)
            {
                Console.WriteLine("Computador " + (indice + 1) + " " + computadores[indice].mostrarDados());
            }

            Console.WriteLine("Informações de programas");
            for (var indice = 0; indice < programas.Count; indice++)
            {
                Console.WriteLine("Programa " + (indice + 1) + " " + computadores[indice].mostrarDados());
            }
            Console.WriteLine("--------------------------------------------------------");

            computadores[0].addPrograma(programas[0]);
            Console.WriteLine("Adicionando ao computador 1 o programa " + computadores[0].programa.getNomePrograma());

            Console.WriteLine(computadores[0].programa.getNomePrograma() + " está sendo executado no computador 1");
            double valor = computadores[0].memoriaSendoUsadaMomento(programas[0].getMemoria(), computadores[0].getQtMemoria());
            Console.WriteLine("O computador 1 tem memória " + computadores[0].getQtMemoria() + " e o programa tem memória de " + programas[0].getMemoria());
            Console.WriteLine("Você tem " + valor + " de memória restante no computador 1");
            Console.WriteLine("--------------------------------------------------------");

            computadores[2].addPrograma(programas[2]);
            Console.WriteLine("Adicionando ao computador 2 o programa " + computadores[2].programa.getNomePrograma());

            Console.WriteLine(computadores[2].programa.getNomePrograma() + " está sendo executado no computador 3");
            double valor3 = computadores[2].memoriaSendoUsadaMomento(programas[2].getMemoria(), computadores[2].getQtMemoria());
            Console.WriteLine("O computador 3 tem memória " + computadores[2].getQtMemoria() + " e o programa tem memória de " + programas[2].getMemoria());
            Console.WriteLine("Você tem " + valor3 + " de memória restante no computador 3");
            Console.WriteLine("--------------------------------------------------------");

            if (computadores[0].checarProgramaUsando() == "Usando programa")
            {
                Console.WriteLine("Computador 1 está executando um programa");
                computadores[0].removerPrograma();
                computadores[0].addPrograma(programas[1]);
                Console.WriteLine("Agora você está usando no computador 1 o programa " + computadores[0].programa.getNomePrograma());
                Console.WriteLine("--------------------------------------------------------");
            }

            if (computadores[2].checarProgramaUsando() == "Usando programa")
            {
                Console.WriteLine("Computador 3 está executando um programa");

                if (computadores[2].programa.getNomePrograma() == programas[2].getNomePrograma())
                {
                    Console.WriteLine("Esse programa já está em uso");
                }

                Console.WriteLine("Você ainda está usando no computador 2 o programa " + computadores[2].programa.getNomePrograma());
                Console.WriteLine("--------------------------------------------------------");
            }

            Console.WriteLine("Finalizando programa");
            Console.ReadLine();
        }
    }
}
