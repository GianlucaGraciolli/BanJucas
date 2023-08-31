using PrjtAula01.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace PrjtAula01
{
    public static class UsuarioLogado
    {
        public static int IdCliente { get; set; }
        public static string? Nome { get; set; }
        public static DateTime? DataNasc { get; set; }
        public static string? Logradouro { get; set; }
        public static string? NumeroLogradouro { get; set; }
        public static string? Email { get; set; }
        public static string? Cidade { get; set; }
        public static string? Estado { get; set; }
        public static string? Cpf { get; set; }
        public static string? Celular { get; set; }
        public static string? SenhaLogin { get; set; }
        public static string? Rg { get; set; }
        public static string? Cep { get; set; }
        public static string? Genero { get; set; }
        public static Decimal Renda { get; set; }
        



        public static List<Conta> Contas = new List<Conta>();



        public static void Deslogar()
        {
            UsuarioLogado.IdCliente = 0;
            UsuarioLogado.Nome = String.Empty;
            UsuarioLogado.DataNasc = null;
            UsuarioLogado.Logradouro = String.Empty;
            UsuarioLogado.NumeroLogradouro = String.Empty;
            UsuarioLogado.Cidade = String.Empty;
            UsuarioLogado.Estado = String.Empty;
            UsuarioLogado.Cpf = String.Empty;
            UsuarioLogado.Celular = String.Empty;
            UsuarioLogado.SenhaLogin = String.Empty;
            UsuarioLogado.Contas.Clear();
            UsuarioLogado.Genero = String.Empty;
            UsuarioLogado.Renda = 0;
            UsuarioLogado.Email = String.Empty;
            UsuarioLogado.Rg = String.Empty;

        }
    }
}
