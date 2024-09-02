namespace BibliotecaTP1
{
    public class Funciones
    {
        //Funciones Matematicas

        public int Sumar(int x, int y)
        {
            return (x + y);
        }

        public int Restar(int x, int y)
        {
            return (x - y);
        }

        public int Multiplicar(int x, int y)
        {
            return (x * y);
        }

        public int Dividir(int x, int y)
        {
           
            return (x / y);

        }

        public int Modulo(int x, int y)
        {
            return (x % y);

        }

        //Funciones de Strings

        public string Concatenar(string x, string y)
        {
            return x + y;
        }

        public string ConcatenarMayusculas(string x, string y)
        {
            return (x.ToUpper() + y.ToUpper());
        }
        //Funciones de Logica

        public bool Mayor(int x, int y)
        {
            return (x > y);
        }

        public bool Igual(int x, int y)
        {
            return (x == y);
        }



    }
}