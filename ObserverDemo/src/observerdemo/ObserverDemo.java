/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerdemo;

import observerPattern.Observer_client;
import observerPattern.Subjects;

/**
 *
 * @author VinhQuang
 */
public class ObserverDemo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
        // TODO code application logic here
        Observer_client observer = new Observer_client();
        Subjects subject = observer.getSubject();
        
        subject.add(4, 5);
    }
    
}
