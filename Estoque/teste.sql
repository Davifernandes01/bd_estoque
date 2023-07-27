--testando os inserts
--tabela produto
insert into Produtos(nome,descricao,quantidade,ultima_data_entrada)
VALUES
  ('produto a','produto bom',30,GETDATE());
GO

INSERT into Produtos(nome,descricao,quantidade,ultima_data_entrada)
VALUES
    ('produto b', 'produto top', 40, GETDATE())

GO
SELECT * from Produtos

--tabela entrada(os dados tem que ir pra la automaticamente

SELECT * from hist_Entrada;

--testando as vendas(a quantidade de produtos na tabela produtos tem que diminuir) e a ultima_data_saida tem que ser adicionada

insert into Vendas(id_produto,quantidade,valor_Total,data_venda)
values(2,35,600.00,GETDATE())

insert into Vendas(id_produto,quantidade,valor_Total,data_venda)
values(2,2,600.00,GETDATE())

insert into vendas(id_produto,quantidade,valor_Total,data_venda)
values(1,14,200.00,GETDATE())

SELECT * from Vendas

--tudo funcionando!!

--testando a procedure(mesmo não tendo motivo pra ela existir)
exec AumentarQuantidadeProduto @id = 1, @quantidade = 10 --funcionando

--view para saber os produtos vendidos com seu nome e a quantidade vendida

select * from vendasProdutos