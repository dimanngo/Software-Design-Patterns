/*
 * To ensure the class has only one instance, we mark the constructor as private.
 * So, we can only instantiate this class from within the class.
 * 
 * We create a static variable that will hold the instance of the class.
 * Then, we create a static method that provides the instance of the singleton class.
 * This method checks if an instance of the singleton class is available.
 * It creates an instance, if its not available; Otherwise, it returns the available instance.
 */


 /*
 Breaking Singleton questions you may get in interviews:
 Even though we avoided multiple instance creation of singleton class by using Double checked locking or Eager instance creation, instances can still be created by:
 – cloning
 – reflection
 – Sub-classing singleton class
 */

 /*
 How to avoid Singleton instance creation by cloning?
 We can create a copy of an object using clone() method.
 To avoid creating a clone of our singleton class, we can do the following:
 – Implement MethodwiseClone()
 – Override the clone() method and throw CloneNotSupportedException from it.
 */

 /*
 How to avoid Singleton class instance creation through Reflection?
 To avoid instance creation through reflection, throw an exception from constructor if it already has an instance.
 */

 /*
 How to avoid a subclass creating singleton instance?
 If you just provide a private constructor, a subclass cannot instantiate it to create another instance.
 */

 /*
 Uses of Singleton Design Pattern:
 Logger:
 Singleton pattern is a good option for the Logger class when we want to create one log file with the logged messages.
 If we have more than one instances of Logger in the application, a new log will be created with every instance.
 
 Cache:
 We can use Singleton pattern to implement caches as that provides a single global access to it.
 */

 /*
 Why singleton pattern is considered an Anti-pattern?
 – Singletons aren’t easy to handle with unit tests. You can’t control their instantiation and they may retain state across invocations.
 – Memory allocated to an Singleton can’t be freed.
 – In multithreaded environment, access to the singleton object may have to be guarded (e.g. via synchronization).
 – Singletons promote tight coupling between classes, so it is hard to test
 */

 /*
 Difference between Static class and Singleton Pattern:
 – In c# a static class cannot implement an interface. When a single instance class needs to implement an interface for some business reason or IoC purposes,
 you can use the Singleton pattern without a static class.
 – You can clone the object of Singleton but, you can not clone the static class object
 – Singleton object stores in Heap but, static object stores in stack
 – A singleton can be initialized lazily or asynchronously while a static class is generally initialized when it is first loaded
 */