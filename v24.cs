namespace v24 {
    class Kalkulator
    {
        private string tulisan = "Rumus Volume Balok" ;
        public string tampil(){
            return tulisan;
        } 
        protected int alas;

        public int kali(int a, int b){
            return this.alas = a * b;
        }
    }

    class Rumus:Kalkulator 
    {
        public int balok(int t) {
            return this.alas * t;
        } 
    }
}
