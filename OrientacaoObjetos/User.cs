namespace OrientacaoObjetos{
    class User{
        private string nome;
        private string senha;

        public string getNome(){
            return nome;
        }

        public string getSenha(){
            return senha;
        }
        public void setNome(string nome){
            this.nome = nome;
        }
        public void setSenha(string senha){
            this.senha = senha;
        }
    }
}

