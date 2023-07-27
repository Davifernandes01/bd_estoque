create table hist_Entrada(
  id int not null PRIMARY key IDENTITY,
  id_produto int NOT NUll,
  quantidade int not null,
  data_entrada datetime not null,
--fk
  CONSTRAINT fk_id_produto_entrada FOREIGN key (id_produto) REFERENCES Produtos(id)

  
)

--index

create NONCLUSTERED index idx_entrada_id
on hist_Entrada (id)