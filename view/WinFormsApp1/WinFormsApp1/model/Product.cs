
namespace Product 
{
    class product {

       public int id { get;  private set;}
        public string name { get ; private set;}
        public string description { get; private set;}  
        public int quantity { get; private set;} //quantidade

        public decimal UnityValue { get; private set;}
        public  DateTime last_Delivery_date { get; private set;} //data de entrada
        public DateTime last_Departure_date {get; private set;}// data de saida

        public product( string name, string description, int amount,decimal UnityValue, 
        DateTime last_Delivery_date)
        {

           

            if (string.IsNullOrWhiteSpace(name)){
                 throw new ArgumentException("Nome inválido ou vazio!!");
            }
               
            

            if(string.IsNullOrWhiteSpace(description)){
                throw new ArgumentException("Descrição inválida ou vazia");
            }
                
         
            if(amount == 0 ){

                throw new Exception("Quantidade inválida!!!");
            }

            if (UnityValue == 0)
            {
                throw new Exception("Valor unitario errado, por favor corrija!!");
            }
           
             this.name = name;
             this.description = description;
             quantity = amount;
             this.UnityValue = UnityValue;
             this.last_Delivery_date = last_Delivery_date;    
          
            
        }


        public int isIncreaseAmount(int amount){ //metado para aumentar a quantidade do produto
            if(amount <= 0){

               throw new ArgumentException("valor menor ou igual a zero!!");
                
            }
            return quantity += amount;
          
        }

        public int isDecreaseAmount(int amount){ //metado para diminuir a quantidade de produto

           if(amount > quantity){
                throw new ArgumentException("valor não pode ser maior que a quantidade atual");
           }

                return  quantity-= amount;  
        }

        public string UpdateDescription(string update){ // metado para atualizar a descricao

            if (string.IsNullOrWhiteSpace(update)){

               throw new ArgumentException("descrição não pode ser vazio!!");
                
            }

                return description = update;
            
        }

        public string UpdateName(string name){// metado para  atualizar o nome do produto
            if(string.IsNullOrWhiteSpace(name)){
                
                
                throw new ArgumentException("nome não poder ser vazio");
             
            }

            return this.name = name;
        }

        public DateTime get_last_Departure_date( DateTime date){//metado para setar a data de saida

            
            return last_Departure_date = date;
        }


        public decimal TotalNoteValue(){

           return UnityValue * quantity;
        }

        //metados toString, hashcode e equals

        public override string ToString()
        {
            return string.Format
            ("Produto: [nome: {0}], [descriçaõ: {1}], [quantidade: {2}], [data de entrada: {3}], [data de saida: {4}] "
            , name,description, quantity, last_Delivery_date, last_Departure_date);
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