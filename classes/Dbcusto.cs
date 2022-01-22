using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class Dbcusto : DbContext 
    {
        public DbSet<Participante> Participante { get; set; }
        public DbSet<CustoCetip> CustoCetip { get; set; }
        public DbSet<Emails> Emails { get; set; }

        public string DbPath { get; private set; }

        public Dbcusto()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"db_teste.db"; 
            Console.WriteLine(DbPath);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    }

    public class Participante
    {
        public int Id { get; set; }
        public long Conta { get; set; }
        public string? Nome { get; set; }
        public string? Containterna { get; set; }
        public string? Cnpj { get; set; }
                      
    }

    public class CustoCetip
    {
        public int Id { get; set; }
        public long Periodo { get; set; }
        public long ContaCetip { get; set; }
        public string? Nome { get; set; }
        public double Valor { get; set; }
    }

    public class Emails
    {
        public int Id { get; set; }
        public long ContaCetip { get; set; }
        public string? Email { get; set; }
        

    }
}
