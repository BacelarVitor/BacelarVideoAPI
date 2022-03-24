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
    public class FilmeRepository : IFilmeRepository
    {
        private readonly IConfiguration _configuration;
        public FilmeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> AddAsync(Filme entity)
        {
            entity.DataCriacao = DateTime.Now;
            var sql = "INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) Values (@Titulo, @Sinopse, @Direcao, @Capa, @Generos, @Duracao, @AnoLancamento, @DataCriacao);";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Filme WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Filme> GetAsync(int id)
        {
            var sql = "SELECT * FROM Filme WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Filme>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Filme>> GetAllAsync()
        {
            var sql = "SELECT * FROM Filme;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var result = await conn.QueryAsync<Filme>(sql);
                return result;
            }
        }

        public async Task<int> UpdateAsync(Filme entity)
        {
            entity.DataAtualizacao = DateTime.Now;
            var sql = "UPDATE Filme SET Titulo = @Titulo, Sinopse = @Sinopse, Direcao = @Direcao, Capa = @Capa, Generos = @Generos, Duracao = @Duracao, AnoLancamento = @AnoLancamento, DataAtualizacao = @DataAtualizacao WHERE Id = @Id;";
            using (var conn = new SqlConnection(_configuration.GetConnectionString("IntcomConnection")))
            {
                await conn.OpenAsync();
                var affectedRows = await conn.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
