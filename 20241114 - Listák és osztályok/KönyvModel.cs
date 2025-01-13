using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241114___Listák_és_osztályok
{
    public class KönyvModel
    {
        private string szerző;
        private string cím;
        
        public string Cím { 
            get => cím; 
            set => cím = value; 
        }
        public string Szerző { 
            get => szerző; 
            set => szerző = value; 
        }

        public KönyvModel(string szerző, string cím)
        {
            this.Cím    = cím;
            this.Szerző = szerző;
        }

        public override string ToString()
        {
            return string.Format($"{this.Szerző}: {this.Cím}");
        }
    }
}
