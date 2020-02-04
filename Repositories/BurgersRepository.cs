using System;
using System.Collections.Generic;
using System.Data;
using burgershackapi.Models;
using Dapper;

namespace burgershackapi.Repositories
{
    public class BurgersRepository
    {
        private readonly IDbConnection _db;
        public BurgersRepository(IDbConnection db)
        {
            _db = db;
        }
        internal IEnumerable<Burger> Get()
        {
            string sql = "SELECT * FROM burgers";
            return _db.Query<Burger>(sql);
        }

        internal Burger GetById(int Id)
        {
            string sql = "SELECT * FROM burgers WHERE id = @Id";
            return _db.QueryFirstOrDefault<Burger>(sql, new { Id });
        }

        internal Burger Create(Burger newData)
        {
            string sql = @"
            INSERT INTO burgers 
            (name, description, price) 
            VALUES 
            (@Name, @Description, @Price);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, newData);
            newData.Id = id;
            return newData;
        }

        internal void Edit(Burger update)
        {

            string sql = @"
            UPDATE burgers
            SET 
            name = @Name,
            description = @Description,
            price = @Price
            WHERE id = @Id; 
            ";
            _db.Execute(sql, update);
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM burgers WHERE id = @id";
            _db.Execute(sql, new { id });
        }
    }
}