using Leds;
using System.IO.Ports;
using System.Linq.Expressions;
using System.Windows.Markup;

namespace Cube
{
    //hier komt led config voor hoofd prog
    internal class LightCube
    {
        Led[] myLeds = new Led[27];

        public LightCube()
        {
            for (int i = 0; i < 27; i++)
                myLeds[i] = new Led();
        }
        //reset leds nogmaals
        public void Reset()
        {
            for (int i = 0; i < 27; i++)
            {
                myLeds[i].Reset();
            }            
        }
        //data versturen naar serielport
        public void Senddata (SerialPort mijnPoort)
        {
            for (int i = 0; i < 27; i++)
            {
                mijnPoort.Write(myLeds[i].Getdata(),0,3);
            }
        }
        //leds oproepen in juiste vorm
        public void Cube()
        {
            myLeds[0].SetColor(true, false, false);
            myLeds[1].SetColor(true, false, false);
            myLeds[2].SetColor(true, false, false);
            myLeds[3].SetColor(true, false, false);
            myLeds[5].SetColor(true, false, false);
            myLeds[6].SetColor(true, false, false);
            myLeds[7].SetColor(true, false, false);
            myLeds[8].SetColor(true, false, false);

            myLeds[9].SetColor(false, true, false);
            myLeds[10].SetColor(false, true, false);
            myLeds[11].SetColor(false, true, false);
            myLeds[12].SetColor(false, true, false);
            myLeds[14].SetColor(false, true, false);
            myLeds[15].SetColor(false, true, false);
            myLeds[16].SetColor(false, true, false);
            myLeds[17].SetColor(false, true, false);

            myLeds[18].SetColor(false, false, true);
            myLeds[19].SetColor(false, false, true);
            myLeds[20].SetColor(false, false, true);
            myLeds[21].SetColor(false, false, true);
            myLeds[23].SetColor(false, false, true);
            myLeds[24].SetColor(false, false, true);
            myLeds[25].SetColor(false, false, true);
            myLeds[26].SetColor(false, false, true);
        }

        public void Driehoek()
        {
            myLeds[0].SetColor(true, false, false);
            myLeds[1].SetColor(true, false, false);
            myLeds[2].SetColor(true, false, false);
            myLeds[4].SetColor(true, false, false);

            myLeds[9].SetColor(false, true, false);
            myLeds[10].SetColor(false, true, false);
            myLeds[11].SetColor(false, true, false);
            myLeds[13].SetColor(false, true, false);
            myLeds[16].SetColor(false, true, false);

            myLeds[18].SetColor(false, false, true);
            myLeds[19].SetColor(false, false, true);
            myLeds[20].SetColor(false, false, true);
            myLeds[22].SetColor(false, false, true);
        }

        public void Kruis()
        {
            myLeds[0].SetColor(true, false, false);
            myLeds[2].SetColor(true, false, false);
            myLeds[4].SetColor(true, false, false);
            myLeds[6].SetColor(true, false, false);
            myLeds[8].SetColor(true, false, false);

            myLeds[9].SetColor(false, true, false);
            myLeds[11].SetColor(false, true, false);
            myLeds[13].SetColor(false, true, false);
            myLeds[15].SetColor(false, true, false);
            myLeds[17].SetColor(false, true, false);

            myLeds[18].SetColor(false, false, true);
            myLeds[20].SetColor(false, false, true);
            myLeds[22].SetColor(false, false, true);
            myLeds[24].SetColor(false, false, true);
            myLeds[26].SetColor(false, false, true);
        }
        public void Circel()
        {
            myLeds[1].SetColor(true, false, false);
            myLeds[3].SetColor(true, false, false);
            myLeds[5].SetColor(true, false, false);
            myLeds[7].SetColor(true, false, false);

            myLeds[10].SetColor(false, true, false);
            myLeds[12].SetColor(false, true, false);
            myLeds[14].SetColor(false, true, false);
            myLeds[16].SetColor(false, true, false);

            myLeds[19].SetColor(false, false, true);
            myLeds[21].SetColor(false, false, true);
            myLeds[23].SetColor(false, false, true);
            myLeds[25].SetColor(false, false, true);
        }
    }
}
