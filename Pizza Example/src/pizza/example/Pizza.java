/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pizza.example;

import java.util.ArrayList;

/**
 *
 * @author Admin
 */
public abstract class Pizza {
    String name;
    String sauce;
    ArrayList<String> toppings = new ArrayList<>();
    void prepare(){
        System.out.println(" Dang chuan bi "+ name);
        System.out.println(" Them sot  "+ sauce);
        System.out.println(" Them : ");
        for(String topping : toppings){
            System.out.println(" "+topping);
        }
        
    }
    void bake(){
        System.out.println("Nau banh trong 5 phut");
        
    }
    void cut(){
        System.out.println("Cat banh lam 8 manh ");
        
    }
    void box(){
        System.out.println("Cho banh vao hop vuong ");
    }

    public String getName() {
        return name;
    }

    
    
}

