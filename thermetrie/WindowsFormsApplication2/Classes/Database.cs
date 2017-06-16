﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Classes
{
    class Database
    {

        public static  void insert(String query, Dictionary<String, String> parameters)
        {
            MySqlConnection connection = startConnect();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            foreach (KeyValuePair<String, String> kvp in parameters)
            {
                command.Parameters.AddWithValue(kvp.Key, kvp.Value);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }


        /// <summary>
        /// Effectue une requete type select et retourne une liste de dictionnaire de résultats
        /// </summary>
        /// <param name="query">Requete SQL</param>
        /// <param name="parameters">Valeurs de la requete</param>
        /// <returns></returns>
        public static List<Dictionary<String, String>> select(String query,Dictionary<String,String> parameters)
        {
            List<Dictionary<String, String>> results = new List<Dictionary<String, String>>();
            MySqlConnection connection = startConnect();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            foreach (KeyValuePair<String, String> kvp in parameters)
            {
                command.Parameters.AddWithValue(kvp.Key, kvp.Value);
            }
            MySqlDataReader resultset = command.ExecuteReader();
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

        public static MySqlConnection startConnect()
        {
            MySqlConnection connection = new MySqlConnection("SERVER=" + Properties.Resources.DATABASE_HOST + ";DATABASE=" + Properties.Resources.DATABASE_NAME + ";UID=" + Properties.Resources.DATABASE_LOGIN + ";PASSWORD=" + Properties.Resources.DATABASE_PASSWORD + ";");
            connection.Open();
            return connection;
        }
    }
}
