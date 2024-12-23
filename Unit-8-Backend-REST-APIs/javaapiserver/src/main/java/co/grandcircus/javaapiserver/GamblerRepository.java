package co.grandcircus.javaapiserver;

import org.springframework.data.jpa.repository.JpaRepository;


// Our repo is a subclass of JpaRepository 
// We need to have all the methods JpaRepository says we should have
// SB will use Dependency Injection to instantiate an object for us with methods containing the defualt behavior
// We have to tell JpaRepositor the model class and the datatype of the Id of the model
//      (use the Java wrapper class for the data type - primitive types not allowed)
public interface GamblerRepository extends JpaRepository<Gambler, Integer>{

}
