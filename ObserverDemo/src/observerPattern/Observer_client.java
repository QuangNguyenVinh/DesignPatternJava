/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package observerPattern;

/**
 *
 * @author VinhQuang
 */
public class Observer_client implements Subjects.IObserverSubjects
{
    Subjects subject ;

    public Observer_client() 
    {
        subject = new Subjects();
        subject.setObserver(this);
    }
    
    
    @Override
    public void update(int res) {
        System.out.println("Result: " + res);
    }

    public Subjects getSubject() {
        return subject;
    }
    
    
    
}
