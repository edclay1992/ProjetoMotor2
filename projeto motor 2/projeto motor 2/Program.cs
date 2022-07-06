using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_motor_2
{




    namespace ConsoleApp1
    {
        internal class Program
        {
            static double[] valor;
            
            static void maior()
            {
                double maior;
                int i = 0;
                int contador;
               
                maior = 0;
                contador = 0;

                for (i = 0; i < valor.Length; ++i)
                {


                    if (valor[i] > maior)
                    {

                        maior = valor[i];
                        contador = i;
                    }
                }
                Console.WriteLine("Maior valor: {0} - motor {1}", maior, contador + 1);
            }
            static void menor()
            {
                double menor;
                int i = 0;
                int contador1;


                menor = 999999999;
                contador1 = 0;

                for (i = 0; i < valor.Length; ++i)
                {

                   
                    if (valor[i] == 0) 
                    {
                    }
                    else
                        if (valor[i] < menor)
                    {
                        menor = valor[i];
                        contador1 = i;
                    }
                }
                Console.WriteLine("Menor valor: {0} - motor {1}", menor, contador1 + 1);
            }
            static void lancar()
            {
                int motor;
                do
                {
                    Console.WriteLine("Qual o motor ?");
                    motor = int.Parse(Console.ReadLine());
                }
                while (motor < 1 || motor > 15);

                Console.WriteLine("Qual o valor ?");
                valor[motor - 1] += double.Parse(Console.ReadLine());

                Console.WriteLine("Valor registrado!");

            }
            static void mostrar()
            {
                int motor;
                double total;

                total = 0;
                for (motor = 0; motor < 15; motor++)
                {
                    Console.WriteLine("Motor {0}: R$ {1}",
                    motor + 1, valor[motor]);
                    total += valor[motor];
                }
                Console.WriteLine("-------");
                Console.WriteLine("Total: R$ {0}", total);


            }
            static void Main(string[] args)
            {

                valor = new double[15];
                int op;
                double resultado;
                int i = 0;

                resultado = 0;

                do
                {
                    
                    Console.WriteLine("0. Sair");
                    Console.WriteLine("1. Lançar valor");
                    Console.WriteLine("2. Mostrar valores");
                    Console.WriteLine("3. Maior e Menor valor e respectivos motores");
                    Console.WriteLine("Sua opção: ");
                    op = int.Parse(Console.ReadLine());

                    Console.Clear();
                    switch (op)
                    {
                        case 1:
                            {
                                lancar();
                                break;
                            }
                        case 2:
                            {
                                mostrar();
                                break;
                            }
                        case 3:
                            {
                                for (i = 0; i < valor.Length; ++i)
                                {
                                    if (valor[i] > resultado)
                                    {
                                        resultado = valor[i];
                                    }
                                }
                                if (resultado >= 1)                               
                                {
                                    maior();
                                    menor();
                                    
                                }else
                                  Console.WriteLine("ATÉ O MOMENTO, NÃO HOUVE GASTO EM NENHUM MOTOR.");
                            }
                            break;
                    }
                }
                while (op != 0);
            }
        }
    }
}
    

