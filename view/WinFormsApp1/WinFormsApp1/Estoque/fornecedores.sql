create table Fornecedores(
    id int not null PRIMARY key IDENTITY,
    nome varchar(50) not null,
    contato VARCHAR(11) not null
)
--index
CREATE NONCLUSTERED index idx_id_fornecedores
on Fornecedores(id)

-------------------------------------------

	