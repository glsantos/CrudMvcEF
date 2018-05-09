using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CrudMvc.Models{

    public class EscolaContext:DbContext{


        // Construtor do DbContext
        public EscolaContext() : base("CrudMvc_teste"){

            Database.CreateIfNotExists();
        }

        //Setando o Context da Tabela, em ALUNO(Model) e nomenado-a de ALUNO
        public DbSet<Aluno> Alunos { get ; set;}
    }
}