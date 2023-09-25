using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
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
           string InitialPath = @"T:\WKH_EXC\Trash\cbec\die Datei data.csv";
           string NewPath = @"C:\TraineeOffice\beginning\die Datei data.csv";

           try
        {
            File.Copy(InitialPath, NewPath, true);
            Console.WriteLine("The file was copied successfully.");
        }
            catch (Exception ex)
        {
            Console.WriteLine("The file cannot be copied. " + ex.Message);

        }


        // 2. Kopiere die Datei unter einem anderen Namen
        string InitialPath2 = @"C:\TraineeOffice\beginning\die Datei data.csv";
        string NewPath2 = @"C:\TraineeOffice\beginning\die neue Datei data.csv";

        try
        {
            File.Copy(InitialPath2, NewPath2, true);
            Console.WriteLine("The file name was changed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("The file name cannot be changed. " + ex.Message);
        }


        // 3. Lösche die kopierte Datei wieder
        try
        {
            File.Delete(NewPath2);
            Console.WriteLine("The file was deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("The file cannot be deleted. " + ex.Message);
        }

        
        }
    }
}
