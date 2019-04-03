/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package straterypatterndemo;

import FlyBehivor.IFlyBehivor;
import QuackBehivor.IQuackBehivor;

/**
 *
 * @author VinhQuang
 */
public class Duck {
    IFlyBehivor flyBehivor;
    IQuackBehivor quackBehivor;
    String name;

    public Duck(IFlyBehivor flyBehivor, IQuackBehivor quackBehivor, String name) {
        this.flyBehivor = flyBehivor;
        this.quackBehivor = quackBehivor;
        this.name = name;
    }

    public void setFlyBehivor(IFlyBehivor flyBehivor) {
        this.flyBehivor = flyBehivor;
    }

    public void setQuackBehivor(IQuackBehivor quackBehivor) {
        this.quackBehivor = quackBehivor;
    }
    
    public void performQuack()
    {
        System.out.println(quackBehivor.quack());
    }
    
    public void performFly()
    {
        System.out.println(flyBehivor.fly());
    }
    public void display()
    {
        System.out.println("Hello " + name );
        performQuack();
        performFly();
    }
}
