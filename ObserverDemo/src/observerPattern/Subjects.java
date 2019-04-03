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
public class Subjects 
{
    IObserverSubjects observer;

    public void setObserver(IObserverSubjects observer) {
        this.observer = observer;
    }
    public void add(int x, int y)
    {
        observer.update(x + y);
    }
    public interface IObserverSubjects
    {
        void update(int res);
    }
}
