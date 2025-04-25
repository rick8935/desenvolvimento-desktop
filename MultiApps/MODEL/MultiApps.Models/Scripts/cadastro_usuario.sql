CREATE DATABASE IF NOT EXISTS cadastro_dev;

USE cadastro_dev;

CREATE TABLE IF NOT EXISTS usuario (
	id INT NOT NULL AUTO_INCREMENT,
	nome VARCHAR(255) NOT NULL,
    cpf VARCHAR(50) NOT NULL,
	email VARCHAR(255) NOT NULL,
    senha VARCHAR(255) NOT NULL,
    data_cadastro TIMESTAMP NOT NULL,
    data_alteracao DATETIME,
    data_ultimoacesso DATETIME,
    status ENUM ("inativo", "ativo", "todos") NOT NULL,
    
    PRIMARY KEY (id)
)