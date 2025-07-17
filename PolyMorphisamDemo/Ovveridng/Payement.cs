using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisamDemo.Ovveridng
{
    public class Payement
    {
        public virtual void Pay()
        {
            Console.WriteLine("I am a payement class");
        }


    }

    public class CrediCard : Payement
    {
        public override void Pay()
        {
            Console.WriteLine("I am a Credit card class");
        }
    }
}
