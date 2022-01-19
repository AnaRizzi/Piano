using System;
using System.Collections.Generic;

namespace Piano
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 500);
            }

        }
    }
}
