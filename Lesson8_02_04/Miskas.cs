using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_02_04
{
    internal class Miskas
    {
        public List<string> Medziai;

        public Miskas(List<string> medziai)
        {
            Medziai = medziai;
        }

        public void PasodintiMedį(string medis)
        {
            Medziai.Add(medis);
        }
    }
}
