# bd_estoque
<h2>regras de negocio utilizada feito pelo chatGpt!</h2>

<h4>

1. Tabela "Produtos":
   - Colunas: ID (identificador único), Nome, Descrição, Preço, Quantidade, Data de Entrada, Data de Saída.
   - A tabela "Produtos" armazenará as informações dos produtos em estoque, incluindo seu nome, descrição, preço, 
   quantidade disponível, data de entrada e data de saída (se aplicável).

2. Tabela "Fornecedores":
   - Colunas: ID (identificador único), Nome Contato.
   - A tabela "Fornecedores" conterá as informações dos fornecedores que fornecem os produtos para o estoque, 
   como nome e informações de contato.

   2.1
      tabela "endereços"
      -contendo informações de endereco de cada fornecedor

3. Tabela "Vendas":
   - Colunas: ID (identificador único), ProdutoID, Quantidade, Valor Total, Data de Venda.
   - A tabela "Vendas" registrará as informações das vendas realizadas, incluindo o ID do produto vendido, 
   a quantidade vendida, o valor total da venda e a data em que a venda foi efetuada.

4. Tabela "Entradas":
   - Colunas: ID (identificador único), ProdutoID, Quantidade, Data de Entrada.
   - A tabela "Entradas" será usada para registrar as informações das entradas de novos produtos no estoque, 
   incluindo o ID do produto, a quantidade recebida e a data de entrada.

5. Regras de negócio:
   - A quantidade de produtos em estoque deve ser atualizada automaticamente sempre que ocorrer uma venda ou entrada de novos produtos.
   - O estoque não pode ter um valor negativo. É necessário implementar verificações 
   para evitar que a quantidade em estoque fique abaixo de zero.
   - Ao registrar uma venda, é necessário verificar se a quantidade solicitada está disponível no estoque.
    Caso contrário, a venda não deve ser concluída.
   - É importante manter registros precisos das datas de entrada e saída de produtos para permitir uma gestão adequada do estoque.</h4>


<p>Para fazer as regras de negocio, utilizei das trigger, a trigger 'ajusta_quantidade_produto' confere se a quantidade vendida seja menor
que a quantidade que está no estoque, depois de conferida, ela substrai a quantiade, assim mantendo o estoque atualizado, a trigger 'add_entrada
  serve para quando adicionar um produto, o produto tambem será adicionado automaticamente na tabela de hist_entrada, para manter o historico
  de entrada atualizado', utilizei tbm o CHECK para não ter produtos com quantidade negativa e etc</p>

  <p>falta algumas coisas, como relatorios ,consultas e etc, mas aos poucos vou fazendo isso</p>
