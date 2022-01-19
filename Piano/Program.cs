using System;
using System.Collections.Generic;

namespace Piano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piano");
            NotasMusicais notas = new NotasMusicais();

            IList<INota> doReMiFa = new List<INota>() {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),

                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("re"),
                notas.Pega("re"),

                notas.Pega("do"),
                notas.Pega("sol"),
                notas.Pega("fa"),
                notas.Pega("mi"),
                notas.Pega("mi"),
                notas.Pega("mi"),

                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa")
            };

            Piano piano = new Piano();
            piano.Toca(doReMiFa);
        }
    }
}
