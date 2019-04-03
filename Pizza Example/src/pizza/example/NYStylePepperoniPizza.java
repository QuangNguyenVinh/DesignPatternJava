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
public class NYStylePepperoniPizza extends Pizza{

    public NYStylePepperoniPizza() {
        name = "banh pizza phong cach NY ";
        sauce = "nuoc sot mayonera";
        toppings.add("them cari bot ot");
    }
    
    @Override
    void cut(){
        System.out.println("Ngu ma phanh banh");
    }
}
