use Loja3

create table login (
	id int primary key identity(1,1),
	usuario varchar(255),
	senha varchar(255)
)

select * from produto

INSERT INTO login (usuario, senha)
VALUES ('zeca', 'senha');

select id, nome, cor, dataFabricacao, valor from carro

create table carro(
	id int primary key identity(1,1),
	nome varchar(255),
	cor varchar(255),
	dataFabricacao date,
	valor decimal
)
