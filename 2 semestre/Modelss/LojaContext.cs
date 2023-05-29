using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace web_app.Modelss;

public partial class LojaContext : DbContext
{
    public LojaContext()
    {
    }

    public LojaContext(DbContextOptions<LojaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carro> Carros { get; set; }

    public virtual DbSet<Postagem> Postagems { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<TbLogin> TbLogins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAB03-D04\\SQLEXPRESS;Database=Loja;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_carro");

            entity.ToTable("carro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cor");
            entity.Property(e => e.DataFabricacao)
                .HasColumnType("date")
                .HasColumnName("dataFabricacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Postagem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__postagem__3213E83F2679A939");

            entity.ToTable("postagem");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Curtidas).HasColumnName("curtidas");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.UrlImagem)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("urlImagem");
            entity.Property(e => e.Usuario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__produto__3213E83FD7450099");

            entity.ToTable("produto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Preco)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("preco");
            entity.Property(e => e.UrlImagem)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("urlImagem");
        });

        modelBuilder.Entity<TbLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_login__3213E83FB9D77207");

            entity.ToTable("tb_login");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsAdm).HasColumnName("isAdm");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
