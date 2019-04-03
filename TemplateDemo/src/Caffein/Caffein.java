/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Caffein;

import CaffeineBeverage.CaffeineBeverageTemplate;

/**
 *
 * @author VinhQuang
 */
public class Caffein extends CaffeineBeverageTemplate{

    @Override
    public void brew() {
        System.out.println("Put caffe in cup!");
    }

    @Override
    public void addCondiments() {
        System.out.println("Add sugar or milk!");
    }
    
}
