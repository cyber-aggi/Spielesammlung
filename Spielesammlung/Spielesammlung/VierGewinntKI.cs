using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Name: Arthur Agt
/// Klasse: FI191
/// Datum: 30.04.2021 (Erstelldatum)
/// Anmerkung: Die Klasse setzt einen Algorithmus zum Spielen von 4 Gewinnt um.
/// Der Code ist von der Lösung eines anderen Programmierers inspieriert: https://www.youtube.com/watch?v=dCLFA-eHDg0
/// </summary>

namespace Spielesammlung
{
    class VierGewinntKI
    {
        //Attribute
        //Spieler1 -> rot
        //Spieler2 -> gelb (ki)
        int spalteNaechterZug;
        private Random rnd; //für zufällige Züge
        //private int[] obersteSteine; //ein Array, indem der Oberste Stein jeder Zeile gespeichert ist
        private int spaltenAnzahl;
        private int zeilenAnazhl;
        private Dictionary<Tuple<int, int>, int> spielbrett;
        ///spielbrett:
        ///Key -> (spalte, zeile); value -> 1 (Spieler 1) oder 2 (Spieler 2)
        ///Es werden nur gesetzte Spielsteine gespeichert, leere Plätze werden dargestellt, indem sie in 'spielbrett' nicht existieren
        private VierGewinntForm ui; //Windows Forms, auf der das Spiel dargestellt wird
        private Dictionary<int, int[]> quads; //ein Dictionary, das alle möglichen Quads speichert
        ///quads (ein Dictonary stellt eine Auflistung von Schlüsseln und Werten dar):
        ///Key -> Ein einfacher Zähler
        ///Value -> int[2]: int[0] -> Anzahl der Steine von Spieler 1; int[1] -> Anzahl der Steine von Spieler 2
        private Dictionary<Tuple<int, int>, List<int>> felderUndIndexe; //ein Dictonary, das für jedes Feld die Indexe aller Tupel speichert
        ///felderUndIndexe 
        ///Key -> die Koordinaten eines Feldes
        ///Value --> der Index jedes Quads, zu dem dieses Feld gehört

        //int[][] richtungen = new int[8][] //es gibt 8 Richtung jede in 2 Dimensionen -> 2 ints
        //{
        //    // {spalte, zeile}
        //    new int [2] { -1, -1},  //nach links oben   -> Index 0
        //    new int [2] { 0, -1},   //nach oben         -> Index 1
        //    new int [2] { 1, -1},   //nach rechts oben  -> Index 2
        //    new int [2] { -1, 0},   //nach links        -> Index 3
        //    new int [2] { 1, 0},    //nach rechts       -> Index 4
        //    new int [2] { -1, 1},   //nach links unten  -> Index 5
        //    new int [2] { 0, 1},    //nach unten        -> Index 6
        //    new int [2] { 1, 1},    //nach rechts unten -> Index 7
        //};

        readonly Tuple<int, int>[] richtungen = new Tuple<int, int>[8] //es gibt 8 Richtungen
        {
            new Tuple<int, int>(-1, -1),  //nach links oben   -> Index 0
            new Tuple<int, int>(0, -1),   //nach oben         -> Index 1
            new Tuple<int, int>(1, -1),   //nach rechts oben  -> Index 2
            new Tuple<int, int>(-1, 0),   //nach links        -> Index 3
            new Tuple<int, int> ( 1, 0),    //nach rechts       -> Index 4
            new Tuple<int, int> (-1, 1),   //nach links unten  -> Index 5
            new Tuple<int, int> ( 0, 1),    //nach unten        -> Index 6
            new Tuple<int, int> ( 1, 1),    //nach rechts unten -> Index 7
        };

        //Konstruktor
        public VierGewinntKI(VierGewinntForm ui)
        {
            //Benutzeroberfläche, auf der das Spiel angezeigt wird, wird über den Konstruktor übergeben
            this.ui = ui;

            //Instanziieren von rnd
            rnd = new Random();

            //Initialisieren von spalten- und zeilenAnzahl
            //Standardmäßig ist ein Spielbrett 7x6 Felder groß
            spaltenAnzahl = 7;
            zeilenAnazhl = 6;

            //instanziieren von Spielbrett
            spielbrett = new Dictionary<Tuple<int, int>, int>();

            ////Instanziiern von obersteSteine
            //obersteSteine = new int[spaltenAnzahl];
            ////Initialisieren von obersteSteine
            //for (int i = 0; i < spaltenAnzahl; i++)
            //{
            //    //-1 bedeutet, dass kein Stein in der Spalte liegt
            //    obersteSteine[i] = -1;
            //}

            //Initialisieren von 'felderUndIndexe'
            felderUndIndexe = new Dictionary<Tuple<int, int>, List<int>>();
            for (int i = 0; i < spaltenAnzahl * zeilenAnazhl; i++)
            {
                felderUndIndexe.Add(Tuple.Create(i % spaltenAnzahl, i / spaltenAnzahl), new List<int>());
                //Erklärung dazu ganz am Ende dieser Datei
            }

            //Initialisieren von 'quads'
            quads = ErmittleQuads();
        }

        public void MacheZug()
        {
            //int aktuellSpalte;

            //do
            //{
            //    if (SpielfeldVoll())
            //        throw new IndexOutOfRangeException("Das Spielfeld ist voll!");

            //    //wähle zufällig, in welche Spalte ein Stein gesetzt werden sollen
            //    aktuellSpalte = rnd.Next(0, 7);
            //    //ist diese Spalte voll, wird einfach eine neue Zufallszahl gewählt
            //} while (obersteSteine[aktuellSpalte] >= zeilenAnazhl - 1);

            Computer();
            //obersteSteine[spalteNaechterZug]++;
            //SetzteStein(Tuple.Create(spalteNaechterZug, ErmittleErsteFreieZeile(spalteNaechterZug)), false);
            ui.DrawBlock(spalteNaechterZug);
        }

        public void GebeZug(int spalte)
        {
            SetzteStein(Tuple.Create(spalte, ErmittleErsteFreieZeile(spalte)), true);
        }

        //public bool SpielfeldVoll()
        //{
        //    return obersteSteine.All(obersterStein => obersterStein >= zeilenAnazhl - 1);
        //}

        public Tuple<int, int>[] QuadPositionen(int spalte, int zeile, Tuple<int, int> richtung) //Methodennamen anpassen
        //erstellt einen Quad von der durch 'spalte' und 'zeile' definierten Position aus in die Richtung 'richtung' 
        {
            //aus Richtung werden die x und die y Koordinate extrahiert -> dient lediglich der besseren Lesbarkeit des Codes
            int spaltenRichtung = richtung.Item1;
            int zeilenRichtung = richtung.Item2;

            //zunächst muss geprüft werden, ob der Quod überhaupt in den Grenzen des Spielfelds liegt
            int neueSpalte = spalte + 3 * spaltenRichtung;
            int neueZeile = zeile + 3 * zeilenRichtung;
            if (neueSpalte < 0 || neueSpalte >= spaltenAnzahl || neueZeile < 0 || neueZeile >= zeilenAnazhl)
            {
                return null;
            }

            //jetzt kann der Quad erstellt und zurückgegeben werden
            //Tuple<int, int>[] positionen = new Tuple<int, int>[4](); //in quad umbennenen
            Tuple<int, int>[] positionen = new Tuple<int, int>[4];

            for (int i = 0; i < 4; i++)
            {
                positionen[i] = Tuple.Create(spalte + spaltenRichtung * i, zeile + zeilenRichtung * i);
            }

            return positionen;
        }

        public Dictionary<int, int[]> ErmittleQuads() //Initialisiert 'quads'
        {
            Dictionary<int, int[]> tmp_quads = new Dictionary<int, int[]>();
            int zaehler = 0; //dies ist der Zähler für das Dictionary
            List<Tuple<int, int>[]> bekanntePositionen = new List<Tuple<int, int>[]>(); //-> notwendig, um Redundanzen zu vermeiden

            //alle Zellen durchgehen
            for (int i = 0; i < spaltenAnzahl * zeilenAnazhl; i++)
            {
                //alle möglichen Richtungen durchgehen
                foreach (Tuple<int, int> richtung in richtungen)
                {
                    //Erklärung zur Berechnung Zeile und Spalte anhand von i ist ganz am Ende der Klasse
                    Tuple<int, int>[] positionen = QuadPositionen(i % spaltenAnzahl, i / spaltenAnzahl, richtung);


                    if (positionen == null || PositionVorhanden(bekanntePositionen, positionen))
                    //kein gültiger Quad gefunden oder der gefundene Quad wurde bereits gefunden
                    {
                        continue;
                    }
                    else
                    {
                        bekanntePositionen.Add(positionen);
                        tmp_quads.Add(zaehler, new int[2] { 0, 0 });
                        //am Anfang ist das Spielfeld leer, also ist in jedem Quad kein Stein egal von wem
                        foreach (Tuple<int, int> position in positionen)
                        {
                            felderUndIndexe[position].Add(zaehler);
                        }
                        zaehler++;
                    }
                }
            }

            return tmp_quads;
        }

        public bool PositionVorhanden(List<Tuple<int, int>[]> bekanntePositionen, Tuple<int, int>[] positionen)
        ///In der Methode 'ErmittleQuads' wird eine Methode benötigt, die prüft, ob die Werte eines 
        ///Tupelarray bereits in einem andere Tupelarray aus einer Liste vorhanden sind.
        ///Gibt ture zurück, wenn die Werte eins Elements der Liste alle in dem Tupel-Array 'positionen' vorhanden sind
        {
            foreach (Tuple<int, int>[] item in bekanntePositionen)
            {
                if (item.All(x => positionen.Contains(x)))
                {
                    return true;
                }
            }
            return false;
        }

        public bool SetzteStein(Tuple<int, int> position, bool spieler)
        {
            //Spieler 1 -> rot -> true
            //Spieler 2 -> gelb -> ki -> false

            bool gewonnen = false; //über die Quads kann man direkt prüfen, ob ein Spieler gewonnen hat
            spielbrett[position] = spieler ? 1 : 2;
            //obersteSteine[position.Item1]++;

            foreach (int index in felderUndIndexe[position])
            {
                quads[index][spieler ? 0 : 1]++;
                if (quads[index][spieler ? 0 : 1] == 4)
                {
                    gewonnen = true;
                }
            }

            return gewonnen;
        }

        public void LoescheStein(Tuple<int, int> position, bool spieler)
        //die KI probiert einen Stein zu setzten, bewertet das Spielbrett danach und löscht den Zug wieder -> deswegen braucht man diese Methode
        {
            spielbrett.Remove(position);
            //obersteSteine[position.Item1]--;
            foreach (int index in felderUndIndexe[position])
            {
                quads[index][spieler ? 0 : 1]--;
            }
        }

        public int Bewerte()
        //bewertet nicht Zug, sondern Position
        {
            int score = 0; //siehe Ende der Funktion
            //jeden auf dem Spielbrett gesetzten Stein durchgehen
            foreach (Tuple<int, int> position in spielbrett.Keys)
            {
                //jeden Quad, der an der aktuellen Stelle (äußere foreach-Schleife) betrachten
                foreach (int index in felderUndIndexe[position])
                {
                    int rot, gelb;
                    rot = quads[index][0]; //Anzahl der roten Steine im Quad
                    gelb = quads[index][1]; //Anzahl der gelben Steine im Quad
                    if (gelb > 0 && rot > 0)
                    //Ein Quad mit sowohl roten, als auch gelben Steine hilft keinem Spieler und wird deshalb nicht bewertet
                    {
                        continue;
                    }
                    else
                    {
                        score -= gelb * 10;
                        score += rot * 10;
                    }
                }
            }

            return score;
            ///score = 0 -> Spielbrett ausgeglichen
            ///score < 0 -> gelb hat bessere Position
            ///score > 0 -> rot hat bessere Position
        }

        public List<Tuple<int, int>> ErmittleZuege()
        //Ermittelt alle möglichen Züge, ein Zug ist möglich, wenn eine Spalte noch nicht voll ist
        {
            List<Tuple<int, int>> zuege = new List<Tuple<int, int>>();
            for (int spalte = 0; spalte < spaltenAnzahl; spalte++)
            {
                if (!PruefeSpalte(spalte)) continue;
                int zeile = ErmittleErsteFreieZeile(spalte);
                zuege.Add(Tuple.Create(spalte, zeile));
            }

            return zuege;
        }

        //public bool Spieler(Tuple<int, int> position, bool spieler)
        //{
        //    return SetzteStein(position, spieler);
        //}

        public bool Computer()
        {
            List<Tuple<int, Tuple<int, int>>> bewerteteZuege = new List<Tuple<int, Tuple<int, int>>>();
            int score;
            bool gewonnen;

            //jeden möglichen Zug ausprobieren
            foreach (Tuple<int, int> zug in ErmittleZuege())
            {
                gewonnen = SetzteStein(zug, false);
                score = MiniMax(6, -999999, 999999, false, gewonnen);
                LoescheStein(zug, false); //dadurch wird  das Spielfeld wieder zurückgesetzt
                bewerteteZuege.Add(Tuple.Create(score, zug));
            }

            bewerteteZuege.Sort();

            Tuple<int, int> besterZug = bewerteteZuege[0].Item2;

            spalteNaechterZug = besterZug.Item1;
            return SetzteStein(besterZug, false);
        }

        private int MiniMax(int suchtiefe, int alpha, int beta, bool spieler, bool gewonnen)
        {
            ///Minimax probiert einen Zug aus und wechselt dann die Seiten, bis die Suchtiefe erreicht ist
            //wenn schon jemand gewonnen hat, muss der Algorithmus nicht mehr ausgeführt werden
            if (gewonnen)
            {
                return spieler ? 99999 + suchtiefe : -99999 - suchtiefe;
                //suchtiefe sorgt dafür, dass das Programm immer den schnellsten Weg zum Sieg wählt
            }
            //wenn die gewünschte Suchtiefe erreicht ist oder das Spielfeld voll ist, kann das Spielfeld bewertet werden
            if (suchtiefe == 0 || spielbrett.Count() == spaltenAnzahl * zeilenAnazhl)
            {
                return Bewerte();
            }

            spieler = !spieler;

            int wert = spieler ? -999999 : 999999;
            int score = 0;

            foreach (Tuple<int, int> zug in ErmittleZuege())
            {
                gewonnen = SetzteStein(zug, spieler);
                score = MiniMax(suchtiefe - 1, alpha, beta, spieler, gewonnen);
                LoescheStein(zug, spieler); //Züge werden ausprobiert und nicht tatsächlich geseztt, daher müssen sie auch zurückgesetzt werden
                if (spieler)
                {
                    if (score > wert) wert = score;
                    if (wert > alpha) alpha = wert;
                }
                else
                {
                    if (score < wert) wert = score;
                    if (wert < beta) beta = wert;
                }
                if (alpha >= beta)
                {
                    break;
                }
            }

            return wert;
        }

        public int ErmittleErsteFreieZeile(int spalte)
        {
            for (int zeile = zeilenAnazhl - 1; zeile > -1; zeile--)
            {
                if (!(spielbrett.ContainsKey(Tuple.Create(spalte, zeile))))
                //wenn die Position nicht im Spielfeld vorhanden ist
                {
                    return zeile;
                }
            }

            return -1;
        }

        public bool PruefeSpalte(int spalte)
        {
            if (spielbrett.ContainsKey(Tuple.Create(spalte, 0)))
            {
                return false;
            }
            if (spalte >= 0 && spalte < spaltenAnzahl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

///Ermitteln der X- und Y-Koordinate aus einer Ganzzahl i:
///Vorstellung: man beginnt oben links und geht Zeile für Zeile jede Zelle von links nach
///rechts durch, wobei jede Zelle eine Ganzzahl i bekommt.
///Dann ist die X-Koordinate (die Spalte): i % Gesamtzahl der Spalten
///Dann ist die Y-Koordinate (die Zeile): i / Gesamtzahl der Spalten
///
///Beispiele:
///1. Spielfeld(7 Spalten, 6 Zeilen), Zelle(Spalte 3 -> Index 2, Zeile 2 -> Index 1), i = 9
///-> Spalte berechnen: 9 % 7 = 2
///-> Zeile berechnen:  9 / 7 = 1 
///Zeile und Spalte wie erwartet
///2. Spielfeld(7 Spalten, 6 Zeilen), Zelle(Spalte 3 -> Index 2, Zeile 2 -> Index 1), i = 23
///-> Spalte berechnen: 23 % 7 = 2
///-> Zeile berechnen:  23 / 7 = 3 
///Zeile und Spalte wie erwartet