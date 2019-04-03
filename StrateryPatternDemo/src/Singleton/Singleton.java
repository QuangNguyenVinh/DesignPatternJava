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
public class Singleton {
    private static Singleton instance;
    protected Singleton(){};
    int x = 0;

    public int getX() {
        return x;
    }

    public void setX(int x) {
        this.x = x;
    }
    public static Singleton Instance()
    {
        if( instance == null)
            instance = new Singleton();
       return instance;
    }
    
}
