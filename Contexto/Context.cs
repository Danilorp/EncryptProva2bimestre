using EncryptProva.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EncryptProva.Contexto
{
    public class Context : DbContext
    {
        public DbSet<dadosencrypt> dadosencrypts { get; set; }


    }
}