using Dapper;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Core.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IntcomTestApp.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IConfiguration _configuration;
        public ClienteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> AddAsync(Cliente entity)
        {
            entity.DataCriacao = DateTime.Now;
            var sql = "INSERT INTO Cliente (Nome, Email, Senha, DataCriacao) Values (@Nome, @Email, @Senha, @DataCriacao);";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Cliente WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Cliente> GetAsync(int id)
        {
            var sql = "SELECT * FROM Cliente WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Cliente>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<Cliente> GetLoginCredentialsAsync(string Email, string Senha)
        {
            var sql = "SELECT * FROM Cliente WHERE Email = @Email AND Senha = @Senha;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Cliente>(sql, new { Email, Senha });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var sql = "SELECT * FROM Cliente;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Cliente>(sql);
                return result;
            }
        }

        public async Task<int> UpdateAsync(Cliente entity)
        {
            entity.DataAtualizacao = DateTime.Now;
            var sql = "UPDATE Cliente SET Nome = @Nome, Email = @Email, Senha = @Senha, DataAtualizacao = @DataAtualizacao WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
