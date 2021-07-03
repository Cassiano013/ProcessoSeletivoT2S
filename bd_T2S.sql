CREATE DATABASE bd_T2S;
USE bd_T2S;
CREATE TABLE tb_Conteiner(
	cd_Conteiner INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nm_Cliente_Conteiner VARCHAR (40) NOT NULL,
    nm_Numero_Conteiner VARCHAR (11) NOT NULL,
    nm_Tipo_Conteiner VARCHAR (2) NOT NULL,
    nm_Status_Conteiner VARCHAR (1) NOT NULL,
    nm_Categoria_Conteiner VARCHAR (1) NOT NULL
);
CREATE TABLE tb_Movimentacao(
	cd_Movimentacao INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nm_Tipo_Movimentacao VARCHAR (2) NOT NULL,
    nm_DHInicio_Movimentacao VARCHAR (20) NOT NULL,
    nm_DHFim_Movimentacao VARCHAR (20) NOT NULL,
    cd_Conteiner INT,
    CONSTRAINT fk_Conteiner_Movimentacao FOREIGN KEY (cd_Conteiner) REFERENCES tb_Conteiner (cd_Conteiner)
);