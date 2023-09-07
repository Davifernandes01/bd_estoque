
using System.Security.Cryptography;
namespace Product 
{
    class Product {

        public int id { get;  private set;}
        public string name { get ; private set;}
        public string description { get; private set;}  
        public int quantity { get; private set;} //quantidade
        public  DateTime last_Delivery_date { get; private set;} //data de entrada
        public DateTime last_Departure_date {get; private set;}// data de saida

        public Product(int id, string name, string description, int amount, 
        DateTime last_Delivery_date)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            quantity = amount;
            this.last_Delivery_date = last_Delivery_date;
          
            
        }


        public int isIncreaseAmount(int amount){ //metado para aumentar a quantidade do produto
            if(amount > 0){

                quantity += amount;
                
            }

            return quantity;
        }

        public int isDecreaseAmount(int amount){ //metado para diminuir a quantidade de produto

            if(amount > 0){

                quantity-= amount;
                
            }

                return quantity;    
        }

        public string UpdateDescription(string update){ // metado para atualizar a descricao

            if (string.IsNullOrWhiteSpace(update)){

               return "";
                
            }

                return description = update;
            
        }

        public string UpdateName(string name){// metado para  atualizar o nome do produto
            if(string.IsNullOrWhiteSpace(name)){
                
                
                return "";
             
            }

            return this.name = name;
        }

        public DateTime get_last_Departure_date( DateTime date){//metado para setar a data de saida

            return last_Departure_date = date;
        }

        //metados toString, hashcode e equals

        public override string ToString()
        {
            return string.Format
            ("Produto [id: {0}], [nome: {1}], [descriçaõ: {2}], [quantidade: {3}], [data de entrada: {4}], [data de saida: {5}] ",
            id, name,description, quantity, last_Delivery_date, last_Departure_date);
        }


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}