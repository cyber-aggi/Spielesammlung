using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Spielesammlung
{
    static class Highscore
    {
        //Diese Methode liest in eine string[][] alle Scores der Spiel, welches übergeben wurde
        //Die Rückgabestruktur ist daten[i][0] = Benutzer; daten[i][1] = Score; daten[i][2] = Zeit(als string)
        static string[][] datenLesen(string spiel)
        {
            List<string[]> daten=new List<string[]>();
            List<string> zeile=new List<string>();
            try
            {
                OracleConnection con = new OracleConnection();
                OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
                OracleCommand oraCom = new OracleCommand();
                OracleDataReader oraDR;
                ocsb.Password = "christoph";
                ocsb.UserID = "FI191_CWILCKEN";
                ocsb.DataSource = "oracle.s-atiw.de:1521/atiwora";
                con.ConnectionString = ocsb.ConnectionString;
                con.Open();
                oraCom.Connection = con;
                string sql = "select benutzer, score, zeit from highscore where spiel = '"+spiel + "'";
                oraCom.CommandText = sql;
                oraDR = oraCom.ExecuteReader();
                while (oraDR.Read())
                {
                    for(int i = 0; i < oraDR.FieldCount; i++)
                    {
                        zeile.Add(oraDR.GetValue(i).ToString());
                    }
                    daten.Add(zeile.ToArray());
                    zeile.Clear();
                }
                con.Close();
            }
            catch (Exception fehler)
            {
                throw new Exception(fehler.Message);
            }

            return daten.ToArray();
        }

        //Diese Methode fügt Daten in die Datenbank ein.
        //Es wird das Spiel, der Benutzer und der Score übergeben
        //Der Zeitpunkt wird durch einen Trigger innerhalb de Datenbank erstellt.
        static void datenEinfuegen(string spiel, string benutzer, int score)
        {
            string befehl;
            try
            {
                OracleConnection con = new OracleConnection();
                OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
                OracleCommand oraCom = new OracleCommand();
                ocsb.Password = "christoph";
                ocsb.UserID = "FI191_CWILCKEN";
                ocsb.DataSource = "oracle.s-atiw.de:1521/atiwora";
                con.ConnectionString = ocsb.ConnectionString;
                con.Open();
                oraCom.Connection = con;
                befehl = "insert into highscore (score, benutzer, spiel) values (" + score + ", '" + benutzer + "', '" + spiel + "')";
                oraCom.CommandText = befehl;
                oraCom.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception fehler)
            {
                throw new Exception(fehler.Message);
            }
        }
    }
}
