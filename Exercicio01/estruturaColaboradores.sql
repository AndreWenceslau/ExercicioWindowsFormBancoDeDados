
CREATE TABLE colaboradores(id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
cpf VARCHAR(14),
salario DECIMAL(6,2),
sexo VARCHAR(10),
cargo VARCHAR(100),
programador BIT,

);
SELECT*FROM colaboradores;