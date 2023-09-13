namespace Suppliers{

    class suppliers{

        public int id {get; private set;}
        public string name {get; private set;}
        public string phone {get; private set;}

        public suppliers(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }
    }

}