using AbcLinguasApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AbcLinguasApi.Dados
{
    public class AbcLinguasContext : DbContext
    {
        public AbcLinguasContext(DbContextOptions<AbcLinguasContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoCurso>()
                .HasKey(ac => new { ac.AlunoId, ac.CursoId });
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlunoCurso> AlunosCursos { get; set; }
    }
}
