using System; 
namespace Console1 {
    class Program {
        public static void makeSound(Animal animal){
            if (animal is Dog){
                (animal as Dog).bark();
            } else if (animal is Cat) {
                (animal as Cat).sound();
            } else {
                Console.WriteLine("No sound!");
            }
        }

        public static void Main (string[] args) {
            var max = new Dog();
            // max.bark();

            var squishi = new Cat();
            // squishi.sound();

            var x = new Bird();

            makeSound(max);
            makeSound(squishi);
            makeSound(x);
        }
    }
}