using System;

namespace p
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string n)
        {
            nombre = n;
            monto = 0;
        }

        public void Depositar(int mon)
        {
            monto = monto + mon;
        }

        public void Extraer(int mon)
        {
            monto = monto - mon;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }

    class Banco
    {
        private Cliente c1, c2, c3;

        public Banco()
        {
            c1 = new Cliente("elian");
            c2 = new Cliente("frank");
            c3 = new Cliente("mileisa");
        }

        public void Operar()
        {
            c1.Depositar(200);
            c2.Depositar(250);
            c3.Depositar(200);
            c3.Extraer(110);
        }

        public void DepositosTotales()
        {
            int t = c1.RetornarMonto() +
                    c2.RetornarMonto() +
                    c3.RetornarMonto();
            Console.WriteLine("El total de dinero es:" + t);
            c1.Imprimir();
            c2.Imprimir();
            c3.Imprimir();
        }

        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }
}
