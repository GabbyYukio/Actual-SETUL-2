using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace FPSETUL2
{
    class Program
    {
        static void p1()
        {
            //declarare si input n
            int n;
            Console.WriteLine("Dati numarul de elemente introduse de tastatura: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valorile: ");
            int input, s = 0;//s folosim pentru a numara numerele pare si input pentru a introduce numerele de la tastatura
            while(n!=0)//citire elemente din secventa de n numere
            {
                //input de la tastatura
                Console.Write(">>> ");
                input=int.Parse(Console.ReadLine());

                //verificare daca numarul curent este par
                if (input % 2 == 0)
                    s++;//adaugare la s
                n--;//scadem n pentru fiecare elemenet din secventa verificat
            }
            Console.WriteLine("S-au introdus {0} numere pare", s);//output
        }

        static void p2()
        {
            //date de intrare: n
            int n;
            Console.WriteLine("Dati numarul de elemente introduse de tastatura: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valorile: ");
            int input, pare=0, zero=0, impare=0;
            while (n != 0)
            {

                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                    zero++;
                else if (input % 2 == 0)
                    pare++;
                else
                    impare++;
            }
            Console.WriteLine("S-au introdus {0} zerouri, {1} numere pare si {2} numere impare", zero,pare,impare);
            Console.ReadLine();

        }

        static void p3()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente introduse de tastatura: ");
            n = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = 1; i <= n; i++)
                s = s + i;
            Console.WriteLine("Suma numerelor este {0}",s);
        }

        static void p4()
        {
            int n, a;
            Console.WriteLine("Dati numarul pe care doriti sa il cautati: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati numarul de elemente din secventa: ");
            n = int.Parse(Console.ReadLine());

            int input,poz=-1, copie_n=n;
            while (n != 0)
            {
                n--;//scadem mai intai n-ul pentru fiecare numar introdus

                //input din secventa
                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());

                //verificare daca 
                if (input == a)
                {
                    poz = copie_n - n;
                    break;
                }
                
            }
            if(poz==-1)
                Console.WriteLine("Nu s-a gasit numarul {0}",a);
            Console.WriteLine("S-a gasit pe pozitia {0}",poz);
        }

        static void p5()
        {
            int n, s = 0, input;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            n = int.Parse(Console.ReadLine());

            int copie_n = n;
            while (n != 0)
            {

                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());
                if(input==copie_n-n-1)
                    s++;
            }

            Console.WriteLine("S-au gasit {0} care sunt egal cu pozitia din secventa",s);
        }

        static void p6()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            n = int.Parse(Console.ReadLine());


            int input, previnput;
            bool ordine=true;
            Console.Write(">>> ");
            previnput=int.Parse(Console.ReadLine());
            while (n-1 != 0)
            {

                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());
                if (input < previnput)
                    ordine = false;
                previnput = input;
                n--;
            }
            if (ordine == false)
                Console.WriteLine("Numerele nu au fost date in ordine crescatoare");
            else
                Console.WriteLine("Numarele au fost date in ordine crescatoare");
        }

        static void p7()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente introduse de tastatura: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati valorile: ");
            int input, pare = 0, zero = 0, impare = 0;
            while (n != 0)
            {

                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                    zero++;
                else if (input % 2 == 0)
                    pare++;
                else
                    impare++;
            }                                   
        }
        static int fibonacci(int n)
        {
            if (n <= 1)
                return 1;
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }
        static void p8()
        {
            int n;
            Console.WriteLine("Dati termenul lui fibonacci pe care il doriti: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Termenul al {0}-lea este {1}",n,fibonacci(n));
            Console.ReadLine();
        }

        static void p9()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Introduceti valorile secventei: ");
            Console.Write(">>> ");
            bool descresc = true, cresc = false;
            int input, previnput=int.Parse(Console.ReadLine());
            while(n-1!=0)
            {
                Console.Write(">>> ");
                input=int.Parse(Console.ReadLine());
                if (input < previnput)
                    descresc = false;
                if(input> previnput)
                    cresc = false;
                previnput=input;
                n--;
            }
            if(descresc==cresc)
                Console.WriteLine("Secventa nu este monotona");
            else
            {
                if(descresc==true)
                    Console.WriteLine("Secventa este monotona descrescatoare");
                else
                    Console.WriteLine("Secventa este monotona crescatoare");
            }
        }

        static void p10()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Introduceti valorile secventei: ");
            Console.Write(">>> ");
            
            int input, previnput = int.Parse(Console.ReadLine()), max=0,consec=0;
            while (n - 1 != 0)
            {
                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());
                if (previnput == input)
                     consec++;
                else
                {
                    if(consec>max)
                        max = consec;
                    consec=0;
                }
                previnput=input;
                n--;
            }
            Console.WriteLine("Numarul maxim de numere egal consecutive este {0}",max);
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        static int inversat(int n)//functie care returneaza oglinditul parametrului n
        {
            int oglindit = 0;
            while (n != 0)
            {
                oglindit = oglindit * 10 + n % 10;
                n--;
            }
            return oglindit;
        }

        static void p11()
        {
            //inputul lui n
            int n;
            Console.WriteLine ("Dati numarul de elemente din secventa: ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Introduceti valorile secventei: ");
            int input, s=0;
            while(n!=0)
            {
                //input elemente
                Console.Write(">>> ");
                input=int.Parse(Console.ReadLine());

                //adunam la suma total inversatul elementului
                s = s + inversat(input);//inversatul il obtinem cu metoda scrisa mai sus
                n--;
            }
            Console.WriteLine("Suma inverselor numerelor este: ",s);
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }

        static void p12()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());

            int input, s=0;
            bool cuvant = false;
            while(n!=0)
            {
                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());
                if(input!=0)
                {
                    if(cuvant==false)
                    {
                        s++;
                        cuvant = true;
                    }
                    
                }
                else
                    cuvant = false;
                n--;
            }
            Console.WriteLine("Printre elementele din secventa, s-au gasit {0} cuvinte",s);
        }
        static char[] rotire_stanga(string s)//rotire spre stanga a string-ului parametru
        {
            char[] placeholder = s.ToCharArray();
            char memorat = placeholder[0];
            for(int i=0 ;i<s.Length-1;i--)
                  placeholder[i]=placeholder[i-1];
            placeholder[s.Length]= memorat;
            return placeholder;
        }

        static bool verificare_crescator(string s)//verifica daca stringul este in ordine crescatoare
        {
            char[] sir = s.ToCharArray();
            for(int i=0; i<sir.Length;i++)
            {
                if (sir[i] > sir[i + 1])
                    return false;
            }
            return true;
        }
        static bool verificare_descrescator(string s)//verifica daca string-ul are valori in ordine descrescatoare
        {
            char[] sir = s.ToCharArray();
            for (int i = 0; i < sir.Length; i++)
            {
                if (sir[i] <sir[i + 1])
                    return false;
            }
            return true;
        }

        static void p13()
        {
            //input numarul n
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());

            //folosim string-uri pentru a memora si roti secventa
            string input="";
            Console.WriteLine("Dati valorile elementelor secventei: ");
            while (n != 0)//citim de la tastatura n numere
            {
                Console.Write(">>> ");//inputul de la consoala
                input=input+Console.ReadLine();//concatanam inputul precedent cu cel nou intr-un singur sir
                n--;
            }
            bool verificat = false;//declaram verificat sa fie false ca atuncea cand verificam ca secventa e crescatoare sa ii dam true
            for(int i=0; i<input.Length-1; i++)//putem roti doar de n-1 ori, ca altfel revine la forma initiala
            {
                if(verificare_crescator(input)==true)//verificam daca e crescatoare folosind o metoda creata mai sus
                {
                    //daca a gasit terminam toata functia if si schimbam verificat in adevarat
                    verificat = true;
                    break;
                }
                rotire_stanga(input);
                
            }
            if(verificat==true)//daca s-a gasit atuncea se va apela acest if
                Console.WriteLine("Seventa este un sir crescator rotit");
            else//daca nu s-a gasit deloc in toate n-1 rotirile va printa acest mesaj
                Console.WriteLine("Secventa nu este un sir crescator rotit");
        }

        static void p14()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());

            string input="";
            Console.WriteLine("Dati valorile elementelor secventei: ");
            while (n  != 0)//punem sa citim de la consola n numere
            {
                Console.Write(">>> ");//inputul
                input = input + Console.ReadLine();//pe care il concatanam cu inputul precedent
                n--;
            }

            //procedam ca la p13
            bool verificat_cresc = false, verificat_descresc = true;//dar folosim doua bool-uri: una pentru cresc si alta pentru descresc
            for (int i = 1; i <= input.Length; i++)
            {
                if (verificare_crescator(input) == true)//daca se gaseste ca fie e cresc dam break si schimbam bool-ul corespunzator
                {
                    verificat_cresc = true;
                    break;
                }
                else if (verificare_descrescator(input) == true)//analog verificam daca nu e si descrescator 
                {
                    verificat_descresc = true;
                    break;
                }
                rotire_stanga(input);
                
            }
            if(verificat_descresc==true)
                Console.WriteLine("Secventa este o secventa monotona rotita descrescatoare");
            else if(verificat_cresc==true)
                Console.WriteLine("Secventa este o secventa monotona rotita crescatoare");
            else
                Console.WriteLine("Secventa nu este o secventa monotona rotita");
        }
        static bool verificare_bitonic(string s)
        {
            char[] sir = s.ToCharArray();
            int i = 0;
            while(i < sir.Length)
            {
                if (sir[i] > sir[i + 1])
                    break;
            }
            int j = sir.Length - i;
            while(j<sir.Length)
            {
                if (sir[i] < sir[i + 1])
                    break;
            }
            if (j + i == sir.Length)
                return true;
            else
                return false;

        }
        static void p15()
        {
            //input n
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());


            //input elemente secventa
            string input = "";
            Console.WriteLine("Dati valorile elementelor secventei: ");
            while (n != 0)
            {
                Console.Write(">>> ");
                input = input + Console.ReadLine();
                n--;
            }
            if(verificare_bitonic(input) == true)
                Console.WriteLine("Sirul este bitonic");
            else
                Console.WriteLine("Sirul nu este bitonic");
            Console.ReadLine();

        }

        static void p16()
        {
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());

            string input = "";
            Console.WriteLine("Dati valorile elementelor secventei: ");
            while (n != 0)//punem sa citim de la consola n numere
            {
                Console.Write(">>> ");//inputul
                input = input + Console.ReadLine();//pe care il concatanam cu inputul precedent
                n--;
            }

            bool verificat = false;
            for(int i=0; i<input.Length; i++)
            {
                if(verificare_bitonic(input) == true)
                {
                    verificat = true;
                    break;
                }
                rotire_stanga(input);
            }
            if(verificat == true)
                Console.WriteLine("Secventa este bitonica rotita");
            else
                Console.WriteLine("Secventa nu este bitonica rotita");
        }

        static void p17()
        {
            //input n
            int n;
            Console.WriteLine("Dati numarul de elemente din secventa: ");
            Console.Write(">>> ");
            n = int.Parse(Console.ReadLine());

            //input-variabila care sa retina valoarea curenta din secventa
            //deschis-numara cate paranteze deschise adica cate elemente cu 0
            //inchis-numara cate paranteze inchise adica cate elemente cu 1
            //max_incuibare-cel mai mare nr de incuibare disponibil
            //numarul de incuibari pentru fiecare 0 sau 1 consecutiv
            int input, deschis = 0, inchis = 0, max_incuibare = 1, prev_incuibare = 1;

            //false- inseamna ca ultimul input a fost 0 si true inseamna ca a fost 1
            bool flip = true;
            Console.WriteLine("Dati valorile elementelor secventei: ");

            while (n != 0)//punem sa citim de la consola n numere
            {
                //citirea
                Console.Write(">>> ");
                input = int.Parse(Console.ReadLine());

                //daca valoarea este 0 
                
                if (input == 0)
                {
                    deschis++;
                    if(flip==false)//si valoarea precedenta a fost tot 0
                    {
                        prev_incuibare++;//marim incuibarea
                    }
                    else//astfel
                    {
                        flip = false;//setam ca numarul precedent este 0
                        if (prev_incuibare > max_incuibare)//comparam daca incuibarea precedenta e mai mare decat maximul
                            max_incuibare = prev_incuibare;//schimbam valorile
                        prev_incuibare = 1;//resetam incuibarea precedenta
                    }
                }
                else
                {
                    inchis++;
                    if (flip == true)
                        prev_incuibare++;
                    else
                    {
                        flip = true;
                        if(prev_incuibare>max_incuibare)
                            max_incuibare = prev_incuibare;
                        prev_incuibare = 1;
                    }
                }
                //daca valoarea este 1 adica se inchide o paranteza adaugam 1 pentru inchis
                
            }
            //daca deschis sau inchis e impar inseamna ca secventa nu este valida
            if (inchis % 2 != 0 || deschis % 2 != 0)
                Console.WriteLine("Nu este o secventa valida");
            else
                Console.WriteLine("Este o secventa valida cu maximul de incuibare fiind {0}", max_incuibare);
        }


        static void Main(string[] args)
        {
            //p1();
            //p2();
            //p3();
            //p4();
            //p5();
            //p6();
            //p7();
            //p8();
            //p9();
            //p10();
            //p11();
            //p12();
            //p13();
            //p14();
            //p15();
            //p16();
            //p17();
        }
    }
}
