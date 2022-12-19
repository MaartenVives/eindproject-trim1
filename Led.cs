using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leds
{
    internal class Led
    {
        byte[] data = new byte[3];

        // method voor kleur
        public void SetColor(bool red,bool green,bool blue)
        {
            if (red)
                data[0] = 0xff;
            else
                data[0] = 0x00;

            if (green)
                data[1] = 0xff;
            else
                data[1] = 0x00;

            if (blue)
                data[2] = 0xff;
            else
                data[2] = 0x00;

        }

        // return data
        public byte[] Getdata()
        {
            return data;
        }
        // resten van de leds
        public void Reset()
        {
          for (int i = 0; i < 3;i++)
          {
                data[i] = 0;
          }
        }
    }
}
