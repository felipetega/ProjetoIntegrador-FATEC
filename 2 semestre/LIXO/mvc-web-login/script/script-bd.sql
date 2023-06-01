create table carro(
	id int not null identity(1,1),
	nome varchar(100) not null,
	cor varchar(50) not null,
	dataFabricacao date,
	valor decimal(8,2),
	constraint pk_carro primary key (id)
);


create table [login](
	id int not null identity(1,1),
	usuario varchar(100) not null,
	senha char(50) not null
	constraint pk_login primary key (id)
);

insert into carro (nome, cor, dataFabricacao, valor)
	values('Gol','branca', '1985-06-13', 15000);

insert into login (usuario, senha) values ('zeca','123');