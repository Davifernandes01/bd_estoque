

create table Produtos(
  id int not null primary key IDENTITY,
  nome varchar(30) not null,
  descricao text not null,
  quantidade int not null,
  preco_unit decimal(10,2) not null,
  ultima_data_entrada datetime not null,
  ultima_data_saida dateTime,

--CONSTRAINTS para evitar que o numero de quantidade seja menor que 0
 CONSTRAINT cnk_quantidade check ( quantidade >= 0)
)

select * from Produtos;
select * from hist_Entrada;

insert into Produtos(nome, descricao, quantidade, ultima_data_entrada, ultima_data_saida,preco_unit)
values ('tv 32', 'tv top',33,GETDATE(),GETDATE(), 70.00)
--criação dos index
create  NONCLUSTERED INDEX idx_Produto_id
on Produtos (id)

CREATE NONCLUSTERED INDEX idx_Produto_data_entrada
on Produtos (ultima_data_entrada)

create NONCLUSTERED index idx_Produto_data_saida
on Produtos(ultima_data_saida)

--TRIGGER para inserir dados do produto na tabela de entrada

go
CREATE trigger add_Entrada
on Produtos
for INSERT
AS
    BEGIN          declare @id_produto int,
                  @quantidadeProduto int,
                  @precoUnit int,
                  @dataEntrada datetime

            SELECT @id_produto = id, @quantidadeProduto = quantidade, @dataEntrada = ultima_data_entrada,
            @precoUnit = preco_unit from inserted


            insert into hist_Entrada(id_produto,quantidade,preco_unit,data_entrada) VALUES
              (@id_produto,@quantidadeProduto, @precoUnit,@dataEntrada)

    end
go

--procedures para diminuir ou aumentar a quantidade de algum produto(quando necessario)
go
create procedure AumentarQuantidadeProduto
      @id int,
      @quantidade INT
      AS
        BEGIN

            UPDATE Produtos
            set quantidade = quantidade + @quantidade
            where id = @id
        end
        
go

go
create procedure diminuirQuantidadeProduto
      @id int,
      @quantidade INT
      AS
        BEGIN

            UPDATE Produtos
            set quantidade = quantidade - @quantidade
            where id = @id
        end
        
go

/*A tabela "Produtos" armazenará as informações dos produtos em estoque, 
incluindo seu nome, descrição, preço, quantidade disponível, 
data de entrada e data de saída.*/