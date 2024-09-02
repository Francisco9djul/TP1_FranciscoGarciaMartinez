// See https://aka.ms/new-console-template for more information

using  BibliotecaTP1;




var funciones = new Funciones();
int i = 1;


while (i == 1){
    
    Console.WriteLine("---------------MENU PRINCIPAL---------------");
    Console.WriteLine("1) Funciones Matematicas");
    Console.WriteLine("2) Funciones strings");
    Console.WriteLine("3) Funciones logicas");
    Console.WriteLine("4) salir");
    Console.WriteLine();

    Console.Write("elija una operacion a realizar:");
    Console.WriteLine();
    string op = Console.ReadLine();
    Console.WriteLine();

    switch (op)
    {
        case "1":
            Console.WriteLine("---------------MENU Funciones Matematicas---------------");
            Console.WriteLine("1) SUMA");
            Console.WriteLine("2) RESTA");
            Console.WriteLine("3) MULTIPLICACION");
            Console.WriteLine("4) DIVISION");
            Console.WriteLine("5) MODULO");
            Console.WriteLine("6) SALIR");
            Console.WriteLine();
            Console.Write("elija una operacion a realizar:");
            Console.WriteLine();
            string op1 = Console.ReadLine();

            if (op1 == "6")
            {
                Console.WriteLine();
                Console.Write("'Ha salido al MENU PRINCIPAL'");
                Console.WriteLine();

            }
                if (op1 != "6")
            {
                Console.Write("Introduzca el primer valor numerico:");
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo valor numerico:");
            Console.WriteLine();
            int y = int.Parse(Console.ReadLine());

            
                    switch (op1)
                    {
                    case "1":
                        Console.WriteLine("Suma: " + funciones.Sumar(x, y));
                        break;
                    case "2":
                        Console.WriteLine("Resta: " + funciones.Restar(x, y));
                        break;
                    case "3":
                        Console.WriteLine("Multiplicacion: " + funciones.Multiplicar(x, y));
                        break;
                        case "4":
                        if (y==0) {
                            Console.WriteLine("ERROR: Se intento dividir por 0");
                            break;
                        }
                        Console.WriteLine("Division: " + funciones.Dividir(x, y));
                        break;
                    case "5":
                        Console.WriteLine("Modulo: " + funciones.Modulo(x, y));
                        break;
                    case "6":
                        Console.WriteLine("'Ha salido al menu principal'.");
                        break;
                    default:
                        Console.WriteLine("'ERROR vuelva a intentar'.");
                        break;
                    }
            }
            Console.WriteLine();
            break;

        case "2":
            Console.WriteLine("---------------MENU Funciones Strings---------------");
            Console.WriteLine("1) CONCATENAR");
            Console.WriteLine("2) CONCATENAR MAYUSCULAS");
            Console.WriteLine("3) SALIR");
            Console.WriteLine(); Console.WriteLine();
            Console.Write("elija una operacion a realizar:");
            Console.WriteLine();
            string op2 = Console.ReadLine();

            if (op2 == "3")
            {
                Console.WriteLine();
                Console.Write("'Ha salido al MENU PRINCIPAL'");
                Console.WriteLine();

            }

            if (op2 != "3")
            {

                Console.Write("Introduzca el primer String:");
                Console.WriteLine();
                string s1 = Console.ReadLine();
                Console.Write("Introduzca el segundo String:");
                Console.WriteLine();
                string s2 = Console.ReadLine();

                switch (op2)
                {
                    case "1":
                        Console.WriteLine("String Concatenado: " + funciones.Concatenar(s1, s2));
                        break;
                    case "2":
                        Console.WriteLine("String Concatenado en MAYUS: " + funciones.ConcatenarMayusculas(s1, s2));
                        break;
                    case "3":
                        Console.WriteLine("'Ha salido al menu principal'.");
                        break;
                    default:
                        Console.WriteLine("'ERROR vuelva a intentar'.");
                        break;
                }


            }
            Console.WriteLine();
            break;

        case "3":

            Console.WriteLine("--------------- Funciones Logicas---------------");
            Console.WriteLine();
            
      

            
                Console.Write("Introduzca el primer valor numerico:");
                Console.WriteLine();
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Introduzca el segundo valor numerico:");
                Console.WriteLine();
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (funciones.Mayor(n1, n2))
                {
                   Console.WriteLine("El primer numero es mayor. ");
                }
                else if (funciones.Igual(n1, n2))
                {
                    Console.WriteLine("Son iguales.");
                }
                else
                {
                    Console.WriteLine("El primer numero es menor.");
                }


            Console.WriteLine();
            break;

        case "4":
            Console.WriteLine("'Ha salido'.");
            i = 0;
            break;
        default:
            Console.WriteLine("'ERROR vuelva a intentar'.");
            break;



    }


}