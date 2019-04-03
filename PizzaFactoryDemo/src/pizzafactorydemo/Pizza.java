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
public abstract class Pizza 
{
    String name;
    public void prepare()
    {
        
        System.out.println("Prepare..." + name);
    }
    public void bake()
    {
        System.out.println("Bake...");
    }
    public void cut()
    {
        System.out.println("Cut...");
    }
    public void box()
    {
        System.out.println("Box...");
    }
    public String getName() 
    {
        return name;
    }
    
    
}
