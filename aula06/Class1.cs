using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06
{
    internal class Cachorro
    {
        private string nameDog;
        private string nameMaster;
        public int ageDog;

       /* public Cachorro(string nameDog, string nameMaster, int ageDog)
        {
            this.nameDog = nameDog;
            this.nameMaster = nameMaster;
            this.ageDog = ageDog;
        }*/

        public string getNameDog()
        {
            return nameDog;
        }

        public void setNameDog(string nameDog)
        {
            this.nameDog = nameDog;
        }

        public string getNameMaster()
        {
            return nameMaster;
        }

        public void setNameMaster(string nameMaster)
        {
            this.nameMaster = nameMaster;
        }

    }
}
