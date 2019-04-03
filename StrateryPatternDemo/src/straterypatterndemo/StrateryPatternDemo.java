/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package straterypatterndemo;

import FlyBehivor.FlyInTheKitchen;
import FlyBehivor.FlyNoWay;
import FlyBehivor.FlyWithWings;
import FlyBehivor.IFlyBehivor;
import QuackBehivor.IQuackBehivor;
import QuackBehivor.MuteQuack;
import QuackBehivor.Quack;

/**
 *
 * @author VinhQuang
 */
public class StrateryPatternDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
       Duck donaldDuck = new Duck(new FlyNoWay(), new Quack(),"Donald");
       System.out.println("Disney Channel");
       donaldDuck.display();
       
       IFlyBehivor flyWithWings = new FlyWithWings();
       IQuackBehivor muteQuack = new MuteQuack();
       donaldDuck.setFlyBehivor(flyWithWings);
       donaldDuck.setQuackBehivor(muteQuack);
        
       System.out.println("Fox Channel");
       donaldDuck.display();
       
       IFlyBehivor flyInChicken = new FlyInTheKitchen();
       donaldDuck.setFlyBehivor(flyInChicken);
       donaldDuck.setQuackBehivor(muteQuack);
       
       System.out.println("Chao vit: ");
       donaldDuck.display();
    }
    
}
