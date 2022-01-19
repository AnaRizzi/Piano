using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Piano
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota nota in musica)
            {
                if (nota.Frequencia == 0)
                {
                    Task.Delay(500).Wait();
                }
                else
                {
                    Console.Beep(nota.Frequencia, 500);
                }
            }

        }
    }
}
