create table Vendas(
  id int not null PRIMARY key IDENTITY, 
  quantidade int not null,
  valor_Total decimal(10,2) not null,
  data_venda DATETIME


)




alter table vendas
add nome_produto varchar(50) not null

alter table Vendas
add constraint fk_nome_produtos foreign key (nome_produto) references Produtos(nome)

alter table Vendas
add valor_total decimal(10,2)
--criação do index
create NONCLUSTERED INDEX idx_id_vendas
on Vendas (id)

go
--trigger feita para comparar se a quantidade da venda é menor que a quantidade de produtos disponiveis
create trigger ajusta_quantidade_produto
on Vendas
FOR INSERT
  AS
  BEGIN
      DECLARE @quantidadeVendida int,
            @produtoID int,
            @data datetime,
            @quantidadeDisponivel int

            --TABELA PRODUTOS
            SELECT @quantidadeDisponivel = quantidade
            from Produtos
            where id = @produtoID

            --TABELA VENDAS
            SELECT @quantidadeVendida = quantidade,@produtoID= id_produto, @data = data_venda from inserted

          if @quantidadeDisponivel < @quantidadeVendida
                RAISERROR('quantidade do produto indisponivel no estoque',14,1)
          ELSE
               update Produtos       
                set quantidade = quantidade - @quantidadeVendida,
                ultima_data_saida = @data
                where id = @produtoID
            
end   

go


go
create VIEW vendasProdutos
as
SELECT v.data_venda,v.valor_Total,p.nome, v.quantidade
from Vendas v
inner join Produtos p on p.id = v.id_produto


