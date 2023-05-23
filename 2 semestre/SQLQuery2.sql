create table produto
(
	id int identity(1,1) PRIMARY KEY,
	nome varchar(255),
	descricao varchar(255),
	preco decimal(5,2),
	urlImagem varchar(255),

)

select * from produto
alter table produto
where id=3

UPDATE produto
SET urlImagem = '.\Produto\Eu.JPG'
WHERE id=3;
