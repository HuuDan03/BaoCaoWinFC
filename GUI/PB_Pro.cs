using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
     class PB_Pro
    {
        private string name;
        private byte[] anh;
        
        

        public PB_Pro()
        {
        }

        public PB_Pro(string name, byte[] anh)
        {
            this.Name = name;
            this.Anh = anh;
           
        }

        public string Name { get => name; set => name = value; }
        public byte[] Anh { get => anh; set => anh = value; }
        
    }
}
