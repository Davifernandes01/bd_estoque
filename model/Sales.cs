using Product;

namespace Sales{

    class sales {

        public int id {get ; private set;}
        public product product{get; private set;}
        public int quantity{get; private set;} 
        public decimal Total_Amount{get; private set;} 
        public DateTime dateOfSales{get; private set;}

        public sales(int id, product product, int quantity, decimal Total_Amount, DateTime dateOfSales) {

                this.id = id;
                this.product = product;
                if(quantity < product.quantity){
                    
                    product.isDecreaseAmount(quantity);//dimuindo a quantidade de produtos
                    this.quantity = quantity;
                }
                
                this.Total_Amount = Total_Amount;

                this.dateOfSales = dateOfSales;
                product.get_last_Departure_date(dateOfSales); // passando a data de venda da classe sales, para
                //a classe products
        }

            public void UpdateQuantity(int amount){

                    if(amount >= product.quantity){
                        quantity = amount;
                        product.isDecreaseAmount(amount);
                    }
            }

            public void UpdateAmount(decimal money){

                Total_Amount =  money;
            }

            public void UpdateDateOfSales(DateTime date){

                dateOfSales = date;
                product.get_last_Departure_date(date);//atualizando la na classes product
            }
        }
    }
