/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pizza.example;

/**
 *
 * @author Admin
 */
public abstract class PizzaStore {
   
    public Pizza orderPizza(String type){
        Pizza pizza = createPizza(type);
        System.out.println("_Dang lam banh pizza "+ pizza.getName()+ "  ");
        pizza.bake();
        pizza.cut();
        pizza.box();
        return pizza;
    }
    abstract Pizza createPizza(String item);
    
}
