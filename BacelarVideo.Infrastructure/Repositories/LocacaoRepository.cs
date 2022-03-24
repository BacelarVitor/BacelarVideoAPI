using Dapper;
using IntcomTestApp.Core.Entities;
using IntcomTestApp.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace IntcomTestApp.Infrastructure.Repositories
{
    public class LocacaoRepository : ILocacaoRepository
    {
        private readonly IConfiguration _configuration;
        public LocacaoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> AddAsync(Locacao entity)
        {
            entity.DataCriacao = DateTime.Now;
            var sql = "INSERT INTO Locacao (FilmeId, ClienteId, Ativa, DataCriacao) Values (@FilmeId, @ClienteId, @Ativa, @DataCriacao);";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Locacao WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Locacao> GetAsync(int id)
        {
            var sql = "SELECT * FROM Locacao WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Locacao>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<Locacao> GetByClienteIdAndFilmeIdAsync(int clienteId, int filmeId)
        {
            var sql = "SELECT TOP 1 * FROM Locacao WHERE ClienteId = @ClienteId AND FilmeId = @FilmeId ORDER BY Id Desc;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Locacao>(sql, new { ClienteId = clienteId, FilmeId = filmeId });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Locacao>> GetAllAsync()
        {
            var sql = "SELECT * FROM Locacao;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Locacao>(sql);
                return result;
            }
        }

        public async Task<IEnumerable<Locacao>> GetAllByClienteIdAsync(int ClienteId)
        {
            var sql = "SELECT Id, ClienteId, Distinct(FilmeId), Ativa, DataDevolucao, DataCriacao, DataAtualizacao FROM Locacao WHERE ClienteId = @ClienteId;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Locacao>(sql, new { ClienteId });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Locacao entity)
        {
            entity.DataAtualizacao = DateTime.Now;
            entity.DataDevolucao = DateTime.Now;
            var sql = "UPDATE Locacao SET FilmeId = @FilmeId, ClienteId = @ClienteId, Ativa = @Ativa, DataDevolucao = @DataDevolucao, DataAtualizacao = @DataAtualizacao WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
