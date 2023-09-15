create table Fornecedores(
    id int not null PRIMARY key IDENTITY,
    nome varchar(50) not null,
    contato VARCHAR(11) not null
)
--index
CREATE NONCLUSTERED index idx_id_fornecedores
on Fornecedores(id)

-------------------------------------------

create table endereco(
    id int not null primary key IDENTITY,
    id_cliente int not null,
    rua VARCHAR(20) not null,
    bairo varchar(20) not null,
    cidade varchar(20) not null
)

--fk
alter table endereco
add CONSTRAINT fk_id_cliente FOREIGN key (id_cliente) REFERENCES Fornecedores(id)

--index

create NONCLUSTERED INDEX idx_id_End_id_cliente
on endereco (id, id_cliente)


--A tabela "Fornecedores" conterá as informações dos fornecedores que fornecem os produtos para o estoque, 
--como nome, endereço e informações de contato.