CREATE TABLE colaboradores(id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
saldo DECIMAL(6,2),
telefone VARCHAR(100),
estado VARCHAR(100),
cidade VARCHAR(100),
bairro VARCHAR(100),
cep VARCHAR(100),
logradouro VARCHAR(100),
numero VARCHAR(100),
complemento DECIMAL(3),
nome_sujo BIT,
altura DECIMAL(3,1),
peso DECIMAL (4,2)
);
SELECT*FROM colaboradores;
