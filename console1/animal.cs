using System; 
namespace Console1 {   
    class Animal {
        public void move() {
            Console.WriteLine("moving...");
        }
    }

    class Dog: Animal {
        public void bark(){
            Console.WriteLine("Wuaw");
        } 
    }

    class Cat: Animal {
        public void sound( ){
            Console.WriteLine("Miau");
        }
    }

    class Bird: Animal {
        public void fly(){
            
        }
    }
}