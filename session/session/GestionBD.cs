using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace session
{
    internal class GestionBD
    {

        private MySqlConnection con;
        ObservableCollection<SPT> liste;
        static GestionBD gestionBD = null;

        public GestionBD()
        {
            this.con = new MySqlConnection("Server=localhost;Database=final;Uid=root;Pwd=root;");
            liste = new ObservableCollection<SPT>();
        }

        public static GestionBD getInstance()
        {
            if (gestionBD == null)
                gestionBD = new GestionBD();

            return gestionBD;
        }

        public ObservableCollection<SPT> getSPT()
        {
            liste.Clear();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select * from SPT";

            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {

                SPT c = new SPT()
                {
                    Frais = r.GetDouble("frais"),
                    Vehicule = r.GetString("vehicule"),
                    PourcentageSPT = r.GetDouble("pourcentageSPT")
                };
                liste.Add(c);
            }
            r.Close();
            con.Close();

            return liste;
        }

    }
}
