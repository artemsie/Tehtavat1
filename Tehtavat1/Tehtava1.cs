using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Tehtava1
    {

        //Tehtävä 1: Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
        //Arttu Siekkinen
        //Pvm: 10.09.2017
        public static void Teht1()
        {
            int luku;
            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("Yksi");
            }

            else if (luku == 2)
            {
                Console.WriteLine("Kaksi");
            }

            else if (luku == 3)
            {
                Console.WriteLine("Kolme");
            }
            else
            {
                Console.WriteLine("Anna joku muu luku");
            }
        }

        //Tehtävä 2: Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
        //Arttu Siekkinen
        //Pvm: 10.09.2017
        public static void Teht2()
        {
            int luku;
            Console.WriteLine("Anna pistemäärä: ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 0 || luku == 1)
            {
                Console.WriteLine("Koulunumero on: 0");
            }

            else if (luku == 2 || luku == 3)
            {
                Console.WriteLine("Koulunumero on: 1");
            }

            else if (luku == 4 || luku == 5)
            {
                Console.WriteLine("Koulunumero on: 2");
            }

            else if (luku == 6 || luku == 7)
            {
                Console.WriteLine("Koulunumero on: 3");
            }

            else if (luku == 8 || luku == 9)
            {
                Console.WriteLine("Koulunumero on: 4");
            }
            else if (luku == 10 || luku == 12)
            {
                Console.WriteLine("Koulunumero on: 5");
            }

        }

        //Tehtävä 3: Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
        //Arttu Siekkinen
        //Pvm: 10.09.2017
        public static void Teht3()
        {
            float luku1;
            float luku2;
            float luku3;
            Console.WriteLine("Anna kolme lukua: ");
            luku1 = float.Parse(Console.ReadLine());
            luku2 = float.Parse(Console.ReadLine());
            luku3 = float.Parse(Console.ReadLine());

            Console.WriteLine(luku1 + luku2 + luku3);
            Console.WriteLine((luku1 + luku2 + luku3) / 3);
        }

        //Tehtävä 4: Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
        //Arttu Siekkinen
        //Pvm: 11.09.2017
        public static void Teht4()
        {
            int luku;
            Console.WriteLine("Anna ika: ");
            luku = int.Parse(Console.ReadLine());

            if (luku < 18)
            {
                Console.WriteLine("Alaikainen");
            }
            else if (luku >= 18 && luku <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
        }

        //Tehtävä 5: Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
        //Arttu Siekkinen
        //Pvm: 11.09.2017
        public static void Teht5()
        {
            int tun;
            int min;
            int sek;
            Console.WriteLine("Anna sekunnit: ");
            sek = int.Parse(Console.ReadLine());

            tun = sek / 3600;
            sek = sek % 3600;
            min = sek / 60;
            sek = sek & 60;

            Console.Write("Antamasi sekuntiaika voidaan ilmaista muodossa: " + tun + " tuntia " + min + " minuuttia " + sek + " sekuntia ");
        }

        //Tehtävä 6: Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
        //Arttu Siekkinen
        //Pvm: 11.09.2017
        public static void Teht6()
        {
            double kilometri;
            double kulutus;
            double kustannukset;
            double bensa = 0.0702;
            double raha = 1.595;
            Console.WriteLine("Anna matka: ");
            kilometri = double.Parse(Console.ReadLine());

            kulutus = kilometri * bensa;
            kustannukset = kulutus * raha;

            Console.Write("Bensaa kuluu: " + kulutus + " kustannukset: " + kustannukset);
        }

        //Tehtävä 7: Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
        //Arttu Siekkinen
        //Pvm: 11.09.2017
        public static void Teht7()
        {
            int vuosi;
            Console.WriteLine("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());

            if (vuosi % 400 == 0)
                Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
            else if (vuosi % 100 == 0)
                Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
            else if (vuosi % 4 == 0)
                Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
            else
                Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
        }

        //Tehtävä 8: Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
        //Arttu Siekkinen
        //Pvm: 12.09.2017
        public static void Teht8()
        {
            int luku1;
            Console.WriteLine("Anna ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());

            int luku2;
            Console.WriteLine("Anna toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());

            int luku3;
            Console.WriteLine("Anna kolmas luku: ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3)
            {
                Console.WriteLine("Suurin luku on: {0}", luku1);
            }
            else if (luku2 > luku1 && luku2 > luku3)
            {
                Console.WriteLine("Suurin luku on: {0}", luku2);
            }
            else if (luku3 > luku1 && luku3 > luku2)
            {
                Console.WriteLine("Suurin luku on: {0}", luku3);
            }
        }

        //Tehtävä 9: Tee ohjelma, joka kysyy käyttäjältä lukuja kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
        //Arttu Siekkinen
        //Pvm: 12.09.2017
        public static void Teht9()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Anna luku: ");
                int luku;
                if (int.TryParse(Console.ReadLine(), out luku))
                {
                    if (luku == 0)
                        break;
                    sum += luku;
                }
            }
            Console.WriteLine("Lukujen summa on: " + sum);
        }



        //Tehtävä 12: Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
        //Arttu Siekkinen
        //Pvm: 12.09.2017
        public static void Teht12()
        {
            int[] luvut = new int[5];

            Console.WriteLine("Anna luku: ");
            luvut[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku: ");
            luvut[4] = int.Parse(Console.ReadLine());

            for (int i = 4; i < luvut.Length; i++) Console.WriteLine("luvut ovat: " + luvut[4] + luvut[3] + luvut[2] + luvut[1] + luvut[0]);

        }
    }    
}

