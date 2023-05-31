use Loja3

create table produto(
	id int primary key identity(1,1),
	nome varchar(255),
	descricao varchar(255),
	preco decimal,
	urlImagem varchar(255)
)

create table postagem(
	id int primary key identity(1,1),
	usuario varchar(255),
	descricao varchar(255),
	urlImagem varchar(255),
	curtidas int
)

create table tb_login(
	id int primary key identity(1,1),
	nome varchar(255),
	senha varchar(255),
	isAdm bit
)