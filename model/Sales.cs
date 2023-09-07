namespace Sales{

    class Sales {

        public int id {get ; private set;}
        public int id_product{get; private set;}
        public int quantity{get; private set;} 
        public decimal Total_Amount{get; private set;} 
        public DateTime dateOfSales{get; private set;}

        public Sales(int id, int id_product, int quantity, decimal total_amount, DateTime dateOfSales) {

                this.id = id;
                this.id_product = id_product;
                this.quantity = quantity;
                this.Total_Amount = total_amount;
        }

        }
    }
