using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumBuilder
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Benevenuto nel curriculm builder");
            Console.WriteLine("Per cominciare, inserisci il tuo nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Perfetto,"+ nome +" ora inserisci il tuo cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Il tuo numero di telefono?");
            string numeroTel = Console.ReadLine();
            Console.WriteLine("E la tua email");
            string email = Console.ReadLine();
            InformazioniPersonali info = new InformazioniPersonali(nome,cognome,numeroTel,email);
            Cv cv = new Cv();
            cv.Info= info;
            cv.StudiEffettuati = new List<Studi>{ };
            cv.Impieghi = new List<Impiego> { };
           
            bool conditionStudio = true;
            while (conditionStudio)
            {
                Console.WriteLine("Inserisci un nuovo campo studio, premi 1 per continuare oppure 2 per concludere");
                string choice = Console.ReadLine();
                if (choice =="1")
                {
                    Console.WriteLine("Che tipo di qualifica hai ottenuto?");
                    string tipo = Console.ReadLine();
                    Console.WriteLine("In quale istituto hai studiato?");
                    string istituto = Console.ReadLine();
                    Console.WriteLine("Qualifica?");
                    string qualifica = Console.ReadLine();
                    Console.WriteLine("Data di inzio?");
                    string inizio = Console.ReadLine();
                    Console.WriteLine("Data di fine?");
                    string fine = Console.ReadLine();

                    Studi studio = new Studi(qualifica,istituto,tipo,inizio,fine);
                    cv.StudiEffettuati.Add(studio);


                    
              

                }if(choice =="2")
                {
                    conditionStudio = false;
                    bool conditionImpiego = true;
                    Console.WriteLine("Ora inserisci le tue esperienze lavorative...");
                    while (conditionImpiego)
                    {
                        Console.WriteLine("In quale azienda?");
                        string azienda = Console.ReadLine();
                        Console.WriteLine("Che ruolo hai ricoperto?");
                        string jobTitle = Console.ReadLine();
                        Console.WriteLine("Quali compiti svolgevi?");
                        string compiti = Console.ReadLine();
                        Console.WriteLine("Dai una breve descrizione di questo lavoro");
                        string descrizione = Console.ReadLine();
                        Console.WriteLine("Data di inzio");
                        string inizio = Console.ReadLine();
                        Console.WriteLine("Data di fine?");
                        string fine = Console.ReadLine();
                        Console.WriteLine("Premi 1 per aggiungerne ancora o 2 per Concludere");
                        string JobChoice = Console.ReadLine();
                        Esperienza esperienza = new Esperienza(azienda,jobTitle, inizio, fine, descrizione, compiti);
                        Impiego impiego = new Impiego();
                        impiego.Esperienza = esperienza;
                        cv.Impieghi.Add(impiego);
                        if(JobChoice == "2")
                        {
                            conditionImpiego=false;
                            Console.WriteLine("Perfetto abbiamo finito");
                            cv.GetCv();


                        }
                    }

                }

                
                
            }
            



            Console.ReadLine();
        }
    }
}
