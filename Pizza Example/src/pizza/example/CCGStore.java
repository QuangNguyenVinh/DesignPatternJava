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
public class CCGStore extends PizzaStore{
    @Override
    Pizza createPizza(String item){
        if(item.equals("cheese"))
            return new CCGStyleCheesPizza();
        else if(item.equals("pepperoni"))
            return new CCGStylePepperoniPizza();
        return null;
    }
    
}
