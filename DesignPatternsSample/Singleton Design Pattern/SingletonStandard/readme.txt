/*
 * To ensure the class has only one instance, we mark the constructor as private.
 * So, we can only instantiate this class from within the class.
 * 
 * We create a static variable that will hold the instance of the class.
 * Then, we create a static method that provides the instance of the singleton class.
 * This method checks if an instance of the singleton class is available.
 * It creates an instance, if its not available; Otherwise, it returns the available instance.
 */