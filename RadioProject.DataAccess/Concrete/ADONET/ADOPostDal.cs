using Microsoft.Data.SqlClient;
using RadioProject.DataAccess.Abstract;
using RadioProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RadioProject.DataAccess.Concrete.ADONET
{
    public class ADOPostDal : IPostDal
    {
        public void Add(Post entity)
        {
            using (SqlCommand command = new SqlCommand("insert into Posts (Title,Details) values (@Title,@Details)"))
            {
                command.Parameters.AddWithValue("@Title", entity.Title);
                command.Parameters.AddWithValue("@Details", entity.Details);
                VTYS.SqlExecuteNonQuery(command);
            }
        }

        public void Delete(Post entity)
        {
            using (SqlCommand command =
                new SqlCommand("delete from Posts where PostId=@PostId "))
            {
                command.Parameters.AddWithValue("@RadioId", entity.PostId);
                VTYS.SqlExecuteNonQuery(command);
            }
        }

        public Post Get(Expression<Func<Post, bool>> filter)
        {
            return null;
        }

        public List<Post> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            var postList = new List<Post>();
            SqlCommand cmd = new SqlCommand("Select * from Posts");

            SqlDataReader reader = VTYS.SqlExecuteReader(cmd);
            while (reader.Read())
            {
                Post post = new Post
                {
                    PostId = Convert.ToInt32(reader[0]),
                    Title = reader[1].ToString(),
                    Details = reader[2].ToString()
                   
                };

                postList.Add(post);
            }
            return postList;
        }

        public void Update(Post entity)
        {
            using (SqlCommand command = new SqlCommand("update Posts set Title=@Title, Details=@Details where PostId=@PostId"))
            {
                command.Parameters.AddWithValue("@PostId", entity.PostId);
                command.Parameters.AddWithValue("@Title", entity.Title);
                command.Parameters.AddWithValue("@Details", entity.Details);
                VTYS.SqlExecuteNonQuery(command);
            }
        }
    }
}
