namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação você deseja realizar?");
            Console.WriteLine("1 - Soma.");
            Console.WriteLine("2 - Subtração.");
            Console.WriteLine("3 - Divisão.");
            Console.WriteLine("4 - Multiplicação.");
            Console.WriteLine("5 - Sair.");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Selecione um opção: ");
            short escolha = short.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            switch(escolha)
            {
                case 1: Soma(); break;

                case 2: Subtracao(); break;

                case 3: Divisao(); break;

                case 4: Multiplicacao(); break;

                case 5: Console.WriteLine("Programa Encerrado."); Environment.Exit(0); break;

                default: Console.WriteLine("Opção inválida."); break;
            }
        }


        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();

            Console.WriteLine("Deseja continuar? Digite s ou n. ");
            char continuaConta = char.Parse(Console.ReadLine());

            if (continuaConta == 's'){
                Soma();
            }
            else if (continuaConta == 'n'){
                Menu();
            }
            else{
                Console.Clear();
                while(continuaConta != 's' || continuaConta != 'n'){
                    
                    Console.WriteLine("Comando Inválido. Digite novamente (s ou n): ");
                    continuaConta = char.Parse(Console.ReadLine());

                    if (continuaConta == 's'){
                        Soma();
                    }
                    else if (continuaConta == 'n'){
                        Menu();
                    }
                    else{
                        Console.Clear();
                    }
                }

            }
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();

            Console.WriteLine("Deseja continuar? Digite s ou n. ");
            char continuaConta = char.Parse(Console.ReadLine());

            if (continuaConta == 's'){
                Subtracao();
            }
            else if (continuaConta == 'n'){
                Menu();
            }
            else{
                Console.Clear();
                while(continuaConta != 's' || continuaConta != 'n'){
                    
                    Console.WriteLine("Comando Inválido. Digite novamente (s ou n): ");
                    continuaConta = char.Parse(Console.ReadLine());

                    if (continuaConta == 's'){
                        Subtracao();
                    }
                    else if (continuaConta == 'n'){
                        Menu();
                    }
                    else{
                        Console.Clear();
                    }
                }

            }
            
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();
            
            Console.WriteLine("Deseja continuar? Digite s ou n. ");
            char continuaConta = char.Parse(Console.ReadLine());

            if (continuaConta == 's'){
                Divisao();
            }
            else if (continuaConta == 'n'){
                Menu();
            }
            else{
                Console.Clear();
                while(continuaConta != 's' || continuaConta != 'n'){
                    
                    Console.WriteLine("Comando Inválido. Digite novamente (s ou n): ");
                    continuaConta = char.Parse(Console.ReadLine());

                    if (continuaConta == 's'){
                        Divisao();
                    }
                    else if (continuaConta == 'n'){
                        Menu();
                    }
                    else{
                        Console.Clear();
                    }
                }

            }
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();
            
            Console.WriteLine("Deseja continuar? Digite s ou n. ");
            char continuaConta = char.Parse(Console.ReadLine());

            if (continuaConta == 's'){
                Multiplicacao();
            }
            else if (continuaConta == 'n'){
                Menu();
            }
            else{
                Console.Clear();
                while(continuaConta != 's' || continuaConta != 'n'){
                    
                    Console.WriteLine("Comando Inválido. Digite novamente (s ou n): ");
                    continuaConta = char.Parse(Console.ReadLine());

                    if (continuaConta == 's'){
                        Multiplicacao();
                    }
                    else if (continuaConta == 'n'){
                        Menu();
                    }
                    else{
                        Console.Clear();
                    }
                }

            }
        }
    }
}

