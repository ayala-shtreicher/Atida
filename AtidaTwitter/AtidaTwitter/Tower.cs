using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtidaTwitter
{
   public enum EType { Rectangular =1, Triangle =2}
    public class Tower
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public EType eType { get; set; }
    }
}
