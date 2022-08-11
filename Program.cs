// ******* 1 ******* // 

// using Csharp.SingletonAndStaticConstructor;

// Database d = Database.GetDatabase;
// Database d2 = Database.GetDatabase;

// ------------------------------------------------------------------------------------------- //

// ******* 2 ******* // 

// using Csharp.Polimorfizm;

// BaseClass a = new DerivedClass();

// DerivedClass b = new NestedDerivedClass();

// NestedDerivedClass c = (NestedDerivedClass)b;

// Console.WriteLine(a is NestedDerivedClass); //False
// Console.WriteLine(a is DerivedClass); //True

// Console.WriteLine(b is NestedDerivedClass); //True
// Console.WriteLine(b is DerivedClass); //True
// Console.WriteLine(b is BaseClass); //True

// ------------------------------------------------------------------------------------------- //

// ******* 3 ******* // 

// using Csharp.Constructor;

// Example a = new();

// Example b = new("Second");

// Example c = new("Second","Third");


// ------------------------------------------------------------------------------------------- //

// ******* 4 ******* // 

// using Csharp.Init;

// Example e = new Example(){
//     MyProperty = 1,
//     MyProperty2 = "2",
//     MyProperty3 = "3"
// };

// // Init only props take value only when initilasing
// e.MyProperty = 1; 

// Example2 e2 = new Example2(){
//     MyProperty = 1,
//     MyProperty2 = "2",
//     MyProperty3 = "3"
// };

// ------------------------------------------------------------------------------------------- //


