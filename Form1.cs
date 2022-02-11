using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void Cgorbe(int ev, double meret)
		{
            if (ev == 1)
            {
				Előre(meret);
				
            }

            if (ev > 1)
            {
				Jobbra(90);

				Cgorbe(ev - 1, meret * 0.5);

				Balra(90);


				Cgorbe(ev - 1, meret * 0.5);
				Cgorbe(ev - 1, meret * 0.5);

				Balra(90);

				Cgorbe(ev - 1, meret / 2);
				Jobbra(90);
            }
		}

		void Koch_fraktal(int ev, int meret)
        {
            if (ev == 1)
            {
				Előre(meret);
            }

            else if (ev > 1)
            {
				Koch_fraktal(ev - 1, meret / 3);

				Balra(60);

				Koch_fraktal(ev - 1, meret / 3);

				Jobbra(120);

				Koch_fraktal(ev - 1, meret / 3);

				Balra(60);

				Koch_fraktal(ev - 1, meret / 3);
            }
        }



		void Egy_fraktal(int ev, double meret)
        {
            if (ev == 1)
            {
				Előre(meret);
            }

            else if (ev > 1)
            {
				Egy_fraktal(ev - 1, meret / 3);

				Jobbra(60);

				Egy_fraktal(ev - 1, meret / 3);
				

				Balra(120);

				Egy_fraktal(ev - 1, meret / 3);
				Egy_fraktal(ev - 1, meret / 3);
				

				Jobbra(120);

				Egy_fraktal(ev - 1, meret / 3);

				Balra(60);
            }
        }

		void FELADAT()
		{




			Teleport(közép.X - 150, közép.Y + 100, észak);

			Jobbra(90);

			//Cgorbe(6, 100);

			Egy_fraktal(6, 100);

			
		}
	}
}
