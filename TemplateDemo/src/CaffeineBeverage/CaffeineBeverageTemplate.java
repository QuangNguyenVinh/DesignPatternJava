/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CaffeineBeverage;

/**
 *
 * @author VinhQuang
 */
public abstract class CaffeineBeverageTemplate 
{
    public final void prepareRecipe()
    {
        boidWater();
        pourInCup();
        brew();
        addCondiments();
    }


    private void boidWater() {
        System.out.println("Boil water....");
    }

    private void pourInCup() {
         System.out.println("Pour it in cup!");
    }
    
    public abstract void brew();
    public abstract void addCondiments();
    
}
