using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks.Dataflow;
using System.Transactions;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 
           1. Kopiere aus T:\WKH_EXC\Trash\cbec\ die Datei data.csv auf deine Festplatte C:\..... (Freie Wahl möglich)
           2. Kopiere die Datei unter einem anderen Namen
           3. Lösche die kopierte Datei wieder
           4. Kopiere die Datei in ein Variables Verzeichnis, welches der Nutzer selbst setzen kann
           5. Probiere eine Datei einzulesen, welche nicht existiert. Behalte die Lösung im Hinterkopf wenn du zukünftig Dateien einliest, damit du hier keinen Fehler bekommst!!!
           6. Lese Datei mittels einem C#- Programm ein
           7. Teile die Einträge am Separator und gebe die ersten 10 Zeilen mit einem Tabulator separiert aus.
           8. Gebe nur die Einträge aus, welche vom Alter jünger als 20 und männlich sind
           9. Speichere diese in einer neuen CSV-Datei mit dem Namen „JungeHüpfer.csv“
           10. Erstelle eine Schleife welche die Einträge nach Alter separieren. (Gewichte_18.csv, Gewichte_19.csv ……. Bis  Alter 100) 
           */

           // 1. Kopiere aus T:\WKH_EXC\Trash\cbec\ die Datei data.csv auf deine Festplatte C:\..... (Freie Wahl möglich)
           // 2. Kopiere die Datei unter einem anderen Namen
           string filepath = @"T:/WKH_EXC/Trash/cbec/data.csv";
           FileInfo fi = new FileInfo(filepath);

           // fi.CopyTo("C:/TraineeOffice/beginning/copy_data.csv");


           // 3. Lösche die kopierte Datei wieder
           // FileInfo fileToDelete = new FileInfo("C:/TraineeOffice/beginning/copy_data.csv");
           // fileToDelete.Delete();
           

           // 4. Kopiere die Datei in ein Variables Verzeichnis, welches der Nutzer selbst setzen kann
           // Console.WriteLine("Wohin willst du die Datei kopieren?");
           // string newpath = Console.ReadLine();
           // fi.CopyTo(newpath);
           // Wohin willst du die Datei kopieren?
           //C:/TraineeOffice/beginning/abcd

           // 5. Probiere eine Datei einzulesen, welche nicht existiert. Behalte die Lösung im Hinterkopf wenn du zukünftig Dateien einliest, damit du hier keinen Fehler bekommst!!!
            /* if(fi.Exists)
            { 
                fi.CopyTo("C:/TraineeOffice/beginning/copy_data.csv");
            }
            else
            {
                Console.WriteLine("Diese Datei existiert nicht." + filepath);
            }
            */


            // 6. Lese Datei mittels einem C#- Programm ein
            /* if(fi.Exists)
            {
                StreamReader reader = new StreamReader(filepath, Encoding.UTF8);
                
                List<string> myEntries = new List<string> ();
                while(!reader.EndOfStream)
                {
                    myEntries.Add(reader.ReadLine());
                }
                Console.WriteLine(myEntries[0]);
                Console.WriteLine(myEntries.Count);
            }

            else
            {
                Console.WriteLine("Diese Datei existiert nicht." + filepath);
            }
            */
        
            // 7. Teile die Einträge am Separator und gebe die ersten 10 Zeilen mit einem Tabulator separiert aus.
            //  8. Gebe nur die Einträge aus, welche vom Alter jünger als 20 und männlich sind

            //  9. Speichere diese in einer neuen CSV-Datei mit dem Namen „JungeHüpfer.csv“
            /*if(fi.Exists)
            {
                StreamReader reader = new StreamReader(filepath, Encoding.UTF8);
                
                List<string[]> myEntries = new List<string[]> ();
                while(!reader.EndOfStream)
                {
                    myEntries.Add(reader.ReadLine().Split(';'));
                }
                List<string[]> malesunder20 = myEntries
                                                        .Where(w => w[0] == "m" && Convert.ToInt16(w[2]) < 20)
                                                        .ToList();
                
                using(StreamWriter writer = new StreamWriter("C:/TraineeOffice/beginning/JungeHuepfer.csv", false, Encoding.UTF8))
                {
                    foreach(string [] entry in malesunder20)
                    {
                        writer.WriteLine(string.Join("\t", entry));
                    }
                }
                */

                // Console.WriteLine(myEntries.Where(w => w[0] == "m" && Convert.ToInt16(w[2]) < 20).Count()); //Count how many males < 20 years old

                /*foreach(string[] entry in malesunder20)
                {
                    Console.WriteLine(string.Join("\t", entry));
                }
            }
             else
            {
                Console.WriteLine("Diese Datei existiert nicht." + filepath);
            }
            */



            // Aufgabe: baue die Zeile drüber in eine For-Each Schleife; mit If-Bedingung um das selbe zu erziehlen.
            /* List<string[]> myEntries = new List<string[]> ();
            foreach(string [] value in myEntries)
            {
                if (value [0] == "m" && Convert.ToInt32(value[2]) < 20)
            {
                Console.WriteLine(string.Join("\t", value));
            }

            else
            {
                Console.WriteLine("Diese Datei existiert nicht." + filepath);
            }
            }
            */


            // 10. Erstelle eine Schleife welche die Einträge nach Alter separieren. (Gewichte_18.csv, Gewichte_19.csv ……. Bis  Alter 100) 
            if(fi.Exists)
            {
                StreamReader reader = new StreamReader(filepath, Encoding.UTF8);
                
                List<string[]> myEntries = new List<string[]> ();
                string headerLine = reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    myEntries.Add(reader.ReadLine().Split(';'));
                }
                Console.WriteLine(string.Join("\t", myEntries[0]));
                Console.WriteLine(myEntries.Count);   

                int endAlter = 100;

                for(int alter = 18; alter < endAlter; alter++)
                {
                       Console.WriteLine("Aktuell bin ich: " + alter);
                
                List<string[]> gefilterEintrage = myEntries
                                                        .Where(w => Convert.ToInt16(w[2]) == alter)
                                                        .ToList(); 
                
                using(StreamWriter writer = new StreamWriter("C:/TraineeOffice/beginning/Gewichte_{alter}.csv", true, Encoding.UTF8))
                {
                        foreach(string[] entry in gefilterEintrage)
                {
                    writer.WriteLine(string.Join('\t', entry));
                }
                }
                }
            }
                
        }
    }
}

