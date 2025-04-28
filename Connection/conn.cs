using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;

namespace Connection
{
    public abstract class conn
    {
        private static string connection = "Data Source=MSI;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False;";

        public static int getIdStudent(string name, string plate)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT id FROM estudiantes WHERE nombre=@name AND matricula=@plate", conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@plate", plate);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0);
                        }
                    }
                }
            }
            return -1;
        }

        public static string getStudentName(int id)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT nombre FROM estudiantes WHERE id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString(0);
                        }
                    }
                }
            }
            return "";
        }

        /* Not Implemented Method Yet*/
        //public static int getIdDetention()
        //{
        //    using (SqlConnection conn = new SqlConnection(connection))
        //    {
        //        conn.Open();
        //        using (SqlCommand cmd = new SqlCommand("SELECT id FROM students WHERE nombre=@name, matricula=@plate"))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@name", name);
        //            cmd.Parameters.AddWithValue("@plate", plate);
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    return reader.GetInt32(0);
        //                }
        //            }
        //        }
        //    }
        //    return -1;
        //}

        public static bool addEstudiante(string name, string plate, int age, string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AddEstudiante", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    cmd.Parameters.AddWithValue("@nombre_in",name);
                    cmd.Parameters.AddWithValue("@matricula_in",plate);
                    cmd.Parameters.AddWithValue("@edad_in",age);
                    cmd.Parameters.AddWithValue("@telefono_in",phoneNumber);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public static bool addDetencion(int idStudent, string reason, string typeDetention, string state, string grade, int detentionNum, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("AddDetencion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    cmd.Parameters.AddWithValue("@id_estudiante_in", idStudent);
                    cmd.Parameters.AddWithValue("@motivo_in", reason);
                    cmd.Parameters.AddWithValue("@tipo_detencion_in",typeDetention);
                    cmd.Parameters.AddWithValue("@estado_in",state);
                    cmd.Parameters.AddWithValue("@curso_estudiante_in",grade);
                    cmd.Parameters.AddWithValue("@num_detenciones_in",detentionNum);
                    cmd.Parameters.AddWithValue("@fecha_in",date);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public static bool delEstudiante(int id)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteEstudiante", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    cmd.Parameters.AddWithValue("@id_in", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public static bool delDetencion(int id)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteDetencion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    cmd.Parameters.AddWithValue("@id_in",id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }


        public static bool uptEstudiante(int id, string name, string plate, int age, string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateEstudiante", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    cmd.Parameters.AddWithValue("@id_in",id);
                    cmd.Parameters.AddWithValue("@nombre_in",name);
                    cmd.Parameters.AddWithValue("@matricula_in",plate);
                    cmd.Parameters.AddWithValue("@edad_in",age);
                    cmd.Parameters.AddWithValue("@telefono_in",phoneNumber);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public static bool uptDetencion(int id, int idStudent, string reason, string typeDetention, string state, string grade, int detentionNum, DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateDetencion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    cmd.Parameters.AddWithValue("@id_in", id);
                    cmd.Parameters.AddWithValue("@id_estudiante_in",idStudent);
                    cmd.Parameters.AddWithValue("@motivo_in",reason);
                    cmd.Parameters.AddWithValue("@tipo_detencion_in",typeDetention);
                    cmd.Parameters.AddWithValue("@estado_in",state);
                    cmd.Parameters.AddWithValue("@curso_estudiante_in",grade);
                    cmd.Parameters.AddWithValue("@num_detenciones_in",detentionNum);
                    cmd.Parameters.AddWithValue("@fecha_in",date);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }


        public static DataTable consultEstudiante()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarEstudiantes", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static List<string> GetMatriculas(string studentName)
        {
            List<string> matriculas = new List<string>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT matricula FROM estudiantes WHERE nombre=@name", conn))
                {
                    cmd.Parameters.AddWithValue("@name", studentName);
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            matriculas.Add(reader.GetString(0));
                        }
                        return matriculas;
                    }
                }
            }
        }

        public static List<string> GetMatriculas(int id)
        {
            List<string> matriculas = new List<string>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT matricula FROM estudiantes WHERE id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            matriculas.Add(reader.GetString(0));
                        }
                        return matriculas;
                    }
                }
            }
        }

        public static DataTable consultDetencion()
        {

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("ConsultarDetencion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@result_message", "");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

    }
}
