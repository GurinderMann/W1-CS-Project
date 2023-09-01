using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_C__Project
{
    public class Calcolo

    {

        Contribuente Contribuente { get; set; }
        public static List<Lista> lista = new List<Lista>();


        public void Run()
        {
            do
            {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Scegli un opzione");
            Console.WriteLine(" 1)    Inserimento di una nuova dichiarazione di un contribuente");
            Console.WriteLine(" 2)    La lista completa di tutti i contribuenti che sono stati analizzati.");
            Console.WriteLine(" 3)    Esci dal Programma");
            Console.WriteLine("==============================================================");
            string risposta = Console.ReadLine();
         
           
            if (risposta == "1")
            {

                Console.WriteLine("Inserisci il nome");
                string Nome = Console.ReadLine(); 
                Console.WriteLine("Inserisci il cognome");
                string Cognome = Console.ReadLine();
                Console.WriteLine("Inserisci data di nascita");
                string DataNascita = Console.ReadLine();
                Console.WriteLine("Inserisci il codice fiscale");
                string CodiceFiscale = Console.ReadLine();
                Console.WriteLine("Inserisci Sesso");
                string Sesso = Console.ReadLine();
                Console.WriteLine("Inserisci Comune di residenza");
                string ComuneResidenza = Console.ReadLine();
                Console.WriteLine("Inserisci Reddito annuale");
                double RedditoAnnuale = Convert.ToDouble(Console.ReadLine());
                Contribuente nuovoContribuente = new Contribuente(Nome, Cognome, DataNascita, CodiceFiscale, Sesso, ComuneResidenza, RedditoAnnuale);

             
                double imposta = 0.0; 

                if (RedditoAnnuale <= 15000)
                {
                    imposta = RedditoAnnuale * 0.23;
                }
                else if (RedditoAnnuale > 15.000 && RedditoAnnuale <= 28000)
                {
                    imposta = 3450 + (RedditoAnnuale - 15000) * 0.27;
                }
                else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
                {
                    imposta = 6960 + (RedditoAnnuale - 28000) * 0.38;
                }
                else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
                {
                    imposta = 17220 + (RedditoAnnuale - 55000) * 0.41;
                }
                else
                {
                    imposta = 25420 + (RedditoAnnuale - 75000) * 0.43;
                }

                
                lista.Add(new Lista 
                { 
                    Nome = Nome, 
                    Cognome = Cognome,
                    ImpostaDaVersare = imposta 

                });

                Console.WriteLine("==============================================================");
                Console.WriteLine($"Nome: {Nome} {Cognome} ");
                Console.WriteLine($"Nato il: {DataNascita} [{Sesso}]");
                Console.WriteLine($"Comune di Residenza: {ComuneResidenza}  ");
                Console.WriteLine($"Codice fiscale: {CodiceFiscale}");
                Console.WriteLine($"Reddito Annuale: {RedditoAnnuale.ToString("#,0.00")}");
                Console.WriteLine($"Imposta: {imposta.ToString("#,0.00")}");
                Console.WriteLine("==============================================================");
                }
            else if (risposta == "2")
            {
                
                if (lista.Count > 0)
                {
                    Console.WriteLine("Lista completa di tutti i Contribuenti");
                        foreach (var item in lista)
                        {
                            Console.WriteLine($" Nome : {item.Nome}");
                            Console.WriteLine($" Cognome : {item.Cognome}");
                            Console.WriteLine($" Imposta da versare : {item.ImpostaDaVersare.ToString("#,0.00")}");
                            Console.WriteLine("==============================================================");
                        }  
                }
            }
            else if (risposta == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Non hai selezionato un opzione corretta");
                }
            } while (true);

        }
    }     
 }
    



