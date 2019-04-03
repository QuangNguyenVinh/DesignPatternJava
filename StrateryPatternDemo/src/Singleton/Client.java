/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Singleton;

/**
 *
 * @author VinhQuang
 */
public class Client {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Singleton s1 = Singleton.Instance();
        s1.setX(5);
        System.out.println("Gia tri x cua s1: " + s1.getX());
        
        Singleton s2 = Singleton.Instance();
        System.out.println("Gia tri x cua s2: " + s2.getX());
        
    }
    
}
