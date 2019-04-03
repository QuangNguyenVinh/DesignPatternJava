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
public class PizzaExample {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        PizzaStore nyStore = new NYStore(); 
        PizzaStore ccgStore = new CCGStore();
        Pizza pizza = nyStore.orderPizza("cheese");
        System.out.println(" "+pizza.getName()+"\n");
        pizza = ccgStore.orderPizza("pepperoni");
        System.out.println(" "+pizza.getName()+ "\n");
        
    }
    
}
