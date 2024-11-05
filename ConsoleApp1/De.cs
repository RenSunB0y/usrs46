using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuatreVingtEtUn
{
    internal class De
    {"
        public int NbFaces;
        private Random random = new Random();

        public De(int nbFaces = 6)
        {
            this.NbFaces = nbFaces;
        }

        public int Face { get; private set; }

        public override string ToString()
        {
            string toString = String.Format("Vous avez lancé un dé à {0} faces et vous avez obtenu un {1}", this.NbFaces, this.Face);
            return toString;
        }

        public int Lancer()
        {
            this.Face = random.Next(1, NbFaces + 1);
            return this.Face;
        }
    }
}
