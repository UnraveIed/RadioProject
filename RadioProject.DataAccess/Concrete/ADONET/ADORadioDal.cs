using Microsoft.Data.SqlClient;
using RadioProject.DataAccess.Abstract;
using RadioProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RadioProject.DataAccess.Concrete.ADONET
{
    public class ADORadioDal : IRadioDal
    {
        public void Add(Radio entity)
        {
            using (SqlCommand command =
                new SqlCommand("insert into Radios (Name,Frequency,isOnline) values (@Name,@Frequency,@isOnline)"))
            {
               
                command.Parameters.AddWithValue("@Name", entity.Name);
                command.Parameters.AddWithValue("@Frequency", entity.Frequency);
                command.Parameters.AddWithValue("@isOnline", entity.isOnline);
                VTYS.SqlExecuteNonQuery(command);
            }
        }

        public void Delete(Radio entity)
        {
            using (SqlCommand command =
                new SqlCommand("delete from Radios where RadioId=@RadioId "))
            {
                command.Parameters.AddWithValue("@RadioId", entity.RadioId);
                VTYS.SqlExecuteNonQuery(command);
            }
        }

        public Radio Get(Expression<Func<Radio, bool>> filter)
        {
            return null;
        }

        public List<Radio> GetAll(Expression<Func<Radio, bool>> filter = null)
        {
            var radioList = new List<Radio>();
            SqlCommand cmd = new SqlCommand("Select * from Radios");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Radio radio = new Radio
                {
                    RadioId = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                    Frequency = Convert.ToDouble(reader[2]),
                    isOnline = (bool)reader[3]
                };

                radioList.Add(radio);
            }
            return radioList;
        }

        public void Update(Radio entity)
        {
            using (SqlCommand command =
                new SqlCommand("update Radios set Name=@Name, Frequency=@Frequency, isOnline=@isOnline where RadioId=@RadioId "))
            {
                command.Parameters.AddWithValue("@RadioId", entity.RadioId);
                command.Parameters.AddWithValue("@Name", entity.Name);
                command.Parameters.AddWithValue("@Frequency", entity.Frequency);
                command.Parameters.AddWithValue("@isOnline", entity.isOnline);
                VTYS.SqlExecuteNonQuery(command);
            }
        }
    }
}
