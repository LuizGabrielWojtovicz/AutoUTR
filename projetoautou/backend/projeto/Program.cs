using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Site
{
    class BaseDeDados : DbContext
    {
        public BaseDeDados(DbContextOptions options) : base(options) { }

        public DbSet<Contador> Contador { get; set; } = null!;
        public DbSet<Colaborador> Colaborador { get; set; } = null!;
        public DbSet<Reacoes> Reacoes { get; set; } = null!;

    }

    class Program
    {
        static void Main(string[] args)
        {
          	 var builder = WebApplication.CreateBuilder(args);

            var connectionString =
                builder.Configuration.GetConnectionString("BancoDeDados")
                ?? "Data Source=BancoDeDados.db";
            builder.Services.AddSqlite<BaseDeDados>(builder.Configuration.GetConnectionString("BaseDeDados") ?? "Data Source=BaseDeDados.db");

            builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));


            var app = builder.Build();

            app.UseCors();
      
            //Cliente CRUD:


            //mostrar tudo:
            app.MapGet(
                "/contador",
                (BaseDeDados banco) =>
                {
                    return banco.Contador.ToList();
                }
            );

            //mostra determinado cliente
            app.MapGet(
                "/contador/{id}",
                (BaseDeDados banco, long id) =>
                {
                    return banco.Contador.Find(id);
                }
            );

            //adicionar cliente
            app.MapPost(
                "/contador",
                (BaseDeDados banco, Contador contador) =>
                {
                    banco.Contador.Add(contador);
                    banco.SaveChanges();

                    return "Contador adicionado!!!";
                }
            );

            //atualizar do cliente
            app.MapPost(
                "/contador/atualizar/{id}",
                (BaseDeDados banco, Contador contadorAtualizado, long id) =>
                {
                    var contador = banco.Contador.Find(id);

                    if (contador == null)
                    {
                        return "contador não existe";
                    }

                    contador.idColaborador = contadorAtualizado.idColaborador;
                    contador.idReacoes = contadorAtualizado.idReacoes;
                    banco.SaveChanges();

                    return "Contador atualizado!!!";
                }
            );

            //deletar cliente:
            app.MapPost(
                "/contador/deletar/{id}",
                (BaseDeDados banco, long id) =>
                {
                    var contador = banco.Contador.Find(id);

                    if (contador == null)
                    {
                        return "contador não existe";
                    }

                    banco.Remove(contador);
                    banco.SaveChanges();

                    return "Contador deletado!!!";
                }
            );

//Cliente CRUD:


            //mostrar tudo:
            app.MapGet(
                "/colaborador",
                (BaseDeDados banco) =>
                {
                    return banco.Colaborador.ToList();
                }
            );

            //mostra determinado cliente
            app.MapGet(
                "/colaborador/{id}",
                (BaseDeDados banco, long id) =>
                {
                    return banco.Colaborador.Find(id);
                }
            );

            //adicionar cliente
            app.MapPost(
                "/colaborador",
                (BaseDeDados banco, Colaborador colaborador) =>
                {
                    banco.Colaborador.Add(colaborador);
                    banco.SaveChanges();

                    return "Colaborador adicionado!!!";
                }
            );

            //atualizar do cliente
            app.MapPost(
                "/colaborador/atualizar/{id}",
                (BaseDeDados banco, Colaborador colaboradorAtualizado, long id) =>
                {
                    var colaborador = banco.Colaborador.Find(id);

                    if (colaborador == null)
                    {
                        return "Colaborador não existe";
                    }

                    colaborador.matricula = colaboradorAtualizado.matricula;
                    colaborador.nome = colaboradorAtualizado.nome;
                    colaborador.sobrenome = colaboradorAtualizado.sobrenome;
                    colaborador.email = colaboradorAtualizado.email;
                    colaborador.departamento = colaboradorAtualizado.departamento;
                    colaborador.cargo = colaboradorAtualizado.cargo;
                    banco.SaveChanges();

                    return "Colaborador atualizado!!!";
                }
            );

            //deletar cliente:
            app.MapPost(
                "/colaborador/deletar/{id}",
                (BaseDeDados banco, long id) =>
                {
                    var colaborador = banco.Colaborador.Find(id);

                    if (colaborador == null)
                    {
                        return "colaborador não existe";
                    }

                    banco.Remove(colaborador);
                    banco.SaveChanges();

                    return "Colaborador deletado!!!";
                }
            );

            //mostrar tudo:
            app.MapGet(
                "/reacoes",
                (BaseDeDados banco) =>
                {
                    return banco.Reacoes.ToList();
                }
            );

            //mostra determinado cliente
            app.MapGet(
                "/reacoes/{id}",
                (BaseDeDados banco, long id) =>
                {
                    return banco.Reacoes.Find(id);
                }
            );

            //adicionar cliente
            app.MapPost(
                "/reacoes",
                (BaseDeDados banco, Reacoes reacoes) =>
                {
                    banco.Reacoes.Add(reacoes);
                    banco.SaveChanges();

                    return "reacoes adicionado!!!";
                }
            );

            //atualizar do cliente
            app.MapPost(
                "/reacoes/atualizar/{id}",
                (BaseDeDados banco, Reacoes reacoesAtualizado, long id) =>
                {
                    var reacoes = banco.Reacoes.Find(id);

                    if (reacoes == null)
                    {
                        return "reacoes não existe";
                    }

                    reacoes.like = reacoesAtualizado.like;
                    reacoes.orgulho = reacoesAtualizado.orgulho;
                    reacoes.excelenteTrabalho = reacoesAtualizado.excelenteTrabalho;
                    reacoes.colaboracao = reacoesAtualizado.colaboracao;
                    banco.SaveChanges();

                    return "Reacoes atualizado!!!";
                }
            );

            //deletar cliente:
            app.MapPost(
                "/reacoes/deletar/{id}",
                (BaseDeDados banco, long id) =>
                {
                    var reacoes = banco.Reacoes.Find(id);

                    if (reacoes == null)
                    {
                        return "reacoes não existe";
                    }

                    banco.Remove(reacoes);
                    banco.SaveChanges();

                    return "reacoes deletado!!!";
                }
            );

            app.Run("https://localhost:7098");
        }
    }
}