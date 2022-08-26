using System;

namespace API.Models{
    public class User{

        public User(){
            CreatedAt = DateTime.Now;
        }
        public string Login {get; set;} //Attributes
        public string Password {get; set;}//Attributes
        public DateTime CreatedAt {get; set;}//Attributes
    }
}