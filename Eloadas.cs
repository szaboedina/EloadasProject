using NUnit.Framework;
using System;

namespace EloadasProject
{
    public class Eloadas
    {
        bool[,] foglalasok;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama < 1 || helyekSzama < 1)
            {
                throw new ArgumentException("A számoknak pozitívnak kell, hogy lenniük.");
            }
            
            this.foglalasok = new bool[sorokSzama,helyekSzama];
            for (int i = 0 ; i < sorokSzama; i++)
            {
                for (int j = 0 ; j < helyekSzama; j++)
                {
                    foglalasok[i,j] = false;
                }
            }


        }
        public bool Lefoglal() {
            
                for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < foglalasok.GetLength(1); j++)
                    {
                        if (foglalasok[i, j] == false) {
                            foglalasok[i, j] = true;
                            return true;
                        }
                    }
                }
            return false;   
        }


        public int SzabadHelyek() {
            int szabadHelyekSzama = 0;
                for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                    for (int j = 0; j < foglalasok.GetLength(1); j++)
                    {
                        if (foglalasok[i, j] == false)
                        {
                            szabadHelyekSzama++;
                        }
                    }
                }
            return szabadHelyekSzama;

        }
        public bool Teli() {
            if (SzabadHelyek() == 0) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Foglalt(int sorSzam, int helySzam) {
            if (foglalasok[sorSzam, helySzam] == true) {
                return false;
            }
            return true;
        }


    }
}
