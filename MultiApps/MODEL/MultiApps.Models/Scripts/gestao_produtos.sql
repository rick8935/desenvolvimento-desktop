CREATE DATABASE IF NOT EXISTS gestao_produtos;

USE gestao_produtos;

CREATE TABLE IF NOT EXISTS produto(
	id INT NOT NULL AUTO_INCREMENT,
    categoria VARCHAR(255) NOT NULL,
    nome VARCHAR(255) NOT NULL,
    preco DECIMAL NOT NULL,
    quantidade_estoque INT NOT NULL,
    imagem VARCHAR(500),
	status BIT,
    
    PRIMARY KEY (id)
);


ALTER TABLE produto ADD COLUMN descricao VARCHAR(500)