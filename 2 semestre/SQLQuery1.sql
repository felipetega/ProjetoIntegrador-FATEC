select * from produto

ALTER TABLE produto
DROP COLUMN imagem;

ALTER TABLE produto
ADD urlImagem VARCHAR(255);
