/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pizzafactorydemo;

/**
 *
 * @author VinhQuang
 */
public class PizzaFactoryDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        // TODO code application logic here
        PizzaStore nyPizzaStore = new NYPizzaStore();
        Pizza nyPizza = nyPizzaStore.orderPizza("cheese");
        
        System.out.println("Deliver... " + nyPizza.getName());
        
        System.out.println("\nAnother Pizza order!\n");
        PizzaStore chgPizzaStore = new ChicagoPizzaStore();
        Pizza chgPizza = chgPizzaStore.orderPizza("veggie");
        
        System.out.println("Deliver..." + chgPizza.getName());
    }
    
}
