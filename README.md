# Spielesammlung

## Liste der Spiele
- Vier Gewinnt  (VierGewinntForm)
- Tic-Tac-Toe  (TicTacToeForm)
- Kniffel (KniffelForm)


## Links
https://trello.com/b/1hZ6cLn7/spielesammlung


## Contribution
Für jedes Feature einen eigenen Branch -> wenn fertig Pull-Request in den Main-Branch stellen


## Highscore
Eintragen mit `Highscore.datenEinfuegen(spielename, gewinner, punkte_sieger);`


**Ermitteln des Gewinnernamens, wenn dieser nicht angegeben wurde**

    HighscoreNameForm DialogHighscore = new HighscoreNameForm(gewinner);
    if (DialogHighscore.ShowDialog() == DialogResult.OK)
    {
    	gewinner = DialogHighscore.tB_name.Text;
    }
    //Setzt den Gewinner auf "" damit kein Highscoreeinrag ausgeführt wird
    else
    {
        gewinner = "";
    }
    DialogHighscore.Dispose();
