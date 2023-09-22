using Product;

namespace Sales{

    class sales {

      
        public product product{get; private set;}
        public int quantity{get; private set;} 
        public decimal Total_Amount{get; private set;} 
        public DateTime dateOfSales{get; private set;}

        public sales( product product, int quantity, decimal Total_Amount, DateTime dateOfSales) {


                if(product == null){
                    throw new ArgumentException("produto não encontrado");
                }
                if (Total_Amount == 0){
                    throw new ArgumentException("valor invalido");
                }

               
                this.product = product;

            
                if(quantity < product.quantity){
                    
                    product.isDecreaseAmount(quantity);//dimuindo a quantidade de produtos
                    this.quantity = quantity;
                }else{
                    throw new ArgumentException("erro na venda, quantidade invalida");
                }
               
               
                
                this.Total_Amount = Total_Amount;

                this.dateOfSales = dateOfSales;
                product.get_last_Departure_date(dateOfSales); // passando a data de venda da classe sales, para
                //a classe products

                
        }

            public void UpdateQuantity(int amount){

                    if(amount < product.quantity){
                        throw new ArgumentException("valor maior que a quantidade disponivel");
                    }
                quantity = amount;
                 product.isDecreaseAmount(amount);
            }

            public void UpdateAmount(decimal money){

                if(money == 0){
                    throw new ArgumentException("valor não pode ser igual a zero");
                }
                Total_Amount =  money;
            }

            public void UpdateDateOfSales(DateTime date){

                dateOfSales = date;
                product.get_last_Departure_date(date);//atualizando la na classes product
            }
        }
    }
