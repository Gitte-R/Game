using Krig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Krig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CardDeck NewCardsDeck = new CardDeck();
            //Der angives hvor mange sæt kort der skal være i spillet. Her 3 kort.
            NewCardsDeck.CreateCardDeck(3);

        }
    }
}


//I kortspillet Krig bliver et sæt spillekort (52 stk.) fordelt mellem 2 spillere. Hver spiller vender ét kort ad gangen. Den spiller der har kortet med den højeste værdi vinder omgangen og får begge kort.

//Lav en winforms udgave af spillet hvor de 52 kort fordeles tilfældigt mellem 2 spillere, hvoraf den ene er computeren.
//I denne udgave af spillet har Kongen den højeste værdi efterfulgt af Dronning, Knægt og videre ned indtil Es som laveste kort.

//Den spiller, som vinder runden får tildelt 2 point. Hvis begge kort har ens værdi, tildeles begge spillere 1 point.
//Spillet ender, når alle kort er blevet spillet og hver kort må kun spilles én gang.

//Lav en klasse (Card) til at holde styr på de forskellige kort og en klasse (Game) til at styre et enkelt spil. Hvordan du repræsentere et sæt spillekort i Game klassen, vil jeg lade være op til dig. Det kan f.eks. være et array, en List eller Dictionary.

//I klassen Game kan du lave en metode (f.eks. FillDeck), der udfylder array'et med værdierne for de 52 unikke kort.
//Lav derudover også en metode (f.eks. SelectCard), som du kan kalde to gange for hver omgang. Denne metode skal vælge et kort (samme kort/værdi må ikke vælges 2 gange i løbet af et spil).

//På grænsefladen skal der være en knap (Deal). Denne skal starte en runde og derefter gøres usynlig. Når spillet går i gang, skal der i stedet vises en knap (Play). Hver gang denne trykkes, skal der spilles 2 nye kort.

//Sørg for at applikationen holder styr på, hvilke kort der er spillet og hvilken spiller, der har fået point.


//Version 2:
//    Denne opgave bygger videre på den tidligere opgave med at genskabe kortspillet Krig.

//Ændre den tidligere applikation sådan at den kan håndtere mere end 2 spillere. Hvordan antallet af spillere vælges eller om det er en fast værdi i programmet er op til dig.

//Applikationen skal kunne:

//Vise score for alle spillere for hver runde
//Tage højde for, at et enkelt sæt af 52 kort måske ikke er nok til at kunne spille spillet. Sørg for at for hver 2 spillere, skal der tilføjes et ekstra sæt af 52 kort til det totale antal kort.
//Hvis én spiller har det højeste kort, får den spiller 2 point
//Hvis flere spillere har det højeste kort, får de alle 1 point
//Hvis du ikke har lavet den forrige opgave, kan du tage udgangspunkt i den version vi startede med at lave på webinaret den 5/4. Den solution kan downloades fra Webinar liste, hvor der vil være et link.


//Version 3:
//    I den oprindelige version af spillet Krig, var der ikke krav om nogen særlig "pæn" måde at vise information om den enkelte runde. Det skal vi have lavet om på.

//Du skal derfor lave en ændring i din applikation sådan, at for hver runde skal den grafiske grænseflade vise de kort som spilles. En måde at vise dette på, kunne være som vist nedenfor.



//For at kunne vise disse billeder, har jeg lagt en zip file med billeder for de enkelte kort her.

//Hvis du ikke tidligere har arbejdet med visning af billeder på en Windows Form, så kan du kigge på den kontrol der hedder PictureBox. Den har en Image og en ImageLocation property, som kan benyttes til at angive hvilket billede der skal vises.

//I skærmbilledet ovenfor, er de enkelte scores sat ind i en GroupBox kontrol. Det er den, der giver rammen og hvor der står "Scores".

//Hvis du ikke har lavet den oprindelige opgave, kan du på Webinar liste finde en version vi startede med at lave på webinaret den 5/4. Du er også velkommen til at implementere denne funktionalitet på din Multiplayer version.