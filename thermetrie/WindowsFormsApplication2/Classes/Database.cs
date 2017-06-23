using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Classes
{
    class Database
    {
        MySqlConnection connection;

        /// <summary>
        /// Alias Insertion en base de données
        /// </summary>
        /// <param name="query">requete SQL</param>
        /// <param name="parameters">parametres associés</param>
        public static void quickExecute(String query, Dictionary<String, String> parameters)
        {
            Database db = new Database();
            db.connect();
            db.execute(query, parameters);
            db.disconnect();
        }



        /// <summary>
        /// Connexion à la base avec les constantes prédéfinies dans ressources.resx
        /// </summary>
        public void connect()
        {
            connection = new MySqlConnection("SERVER=" + Properties.Resources.DATABASE_HOST + ";DATABASE=" + Properties.Resources.DATABASE_NAME + ";UID=" + Properties.Resources.DATABASE_LOGIN + ";PASSWORD=" + Properties.Resources.DATABASE_PASSWORD + ";CharSet=utf8;");
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Erreur d'accée a la base de donnée");
            }
        }

        /// <summary>
        /// Déconnexion de la base instanciée
        /// </summary>
        public void disconnect()
        {
            connection.Close();
        }

        /// <summary>
        /// Méthode d'insertion de donnée en base (instanciée)
        /// </summary>
        /// <param name="query">requete SQL</param>
        /// <param name="parameters"></param>
        public void execute(String query, Dictionary<String, String> parameters)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            foreach (KeyValuePair<String, String> kvp in parameters)
            {
                command.Parameters.AddWithValue(kvp.Key, kvp.Value);
            }

            command.ExecuteNonQuery();


        }


        /// <summary>
        /// Effectue une requete type select et retourne une liste de dictionnaire de résultats
        /// </summary>
        /// <param name="query">requete SQL</param>
        /// <returns></returns>
        public static List<Dictionary<String, String>> select(String query)
        {
            return select(query, new Dictionary<String, String>());
        }

        /// <summary>
        /// Effectue une requete type select et retourne une liste de dictionnaire de résultats
        /// </summary>
        /// <param name="query">Requete SQL</param>
        /// <param name="parameters">Valeurs de la requete</param>
        /// <returns></returns>
        public static List<Dictionary<String, String>> select(String query, Dictionary<String, String> parameters)
        {

            List<Dictionary<String, String>> results = new List<Dictionary<String, String>>();
            MySqlConnection connection = new MySqlConnection("SERVER=" + Properties.Resources.DATABASE_HOST + ";DATABASE=" + Properties.Resources.DATABASE_NAME + ";UID=" + Properties.Resources.DATABASE_LOGIN + ";PASSWORD=" + Properties.Resources.DATABASE_PASSWORD + ";");
            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Erreur d'accée a la base de donnée");
            }

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            foreach (KeyValuePair<String, String> kvp in parameters)
            {
                command.Parameters.AddWithValue(kvp.Key, kvp.Value);
            }
            MySqlDataReader resultset = null;


            resultset = command.ExecuteReader();



            while (resultset.Read())
            {
                Dictionary<String, String> line = new Dictionary<String, String>();

                for (int i = 0; i < resultset.FieldCount; i++)
                {
                    line[resultset.GetName(i)] = resultset.GetValue(i).ToString();
                }
                results.Add(line);
            }

            connection.Close();
            return results;
        }
    }
}
