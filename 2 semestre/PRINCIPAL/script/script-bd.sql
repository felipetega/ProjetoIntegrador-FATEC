create table carro(
	id int not null identity(1,1),
	nome varchar(100) not null,
	cor varchar(50) not null,
	dataFabricacao date,
	valor decimal(8,2),
	constraint pk_carro primary key (id)
);

USE [Loja]
create table [login](
	id int not null identity(1,1),
	usuario varchar(100) not null,
	senha char(50) not null
	constraint pk_login primary key (id)
);

insert into carro (nome, cor, dataFabricacao, valor)
	values('Gol','branca', '1985-06-13', 15000);

insert into login (usuario, senha) values ('zeca','123');

insert into login (usuario, senha) values ('adriano','456');

select *
from [dbo].[login]

use [Loja]
create table postagem
(
	id int identity not null,
	usuario varchar(50) not null,
	descricao varchar(200) not null,
	urlImagem varchar(max) not null,
	curtidas int not null,
	constraint pk_postagem primary key (id)
);

create table produto
(
	id int identity not null,
	nome varchar(100) not null,
	descricao varchar(200) not null,
	preco decimal (5,2) not null,
	urlImagem varchar (max) not null,
	constraint pk_produto primary key (id)
);

select *	
from [dbo].[produto]