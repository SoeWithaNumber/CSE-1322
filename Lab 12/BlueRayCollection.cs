using System;
class BlueRayCollection{
    private Node head = null;
    public BlueRayCollection(){
        
    }
    public void add(string title, string director, int yearOfRelease, double cost){
        Node newNode = new Node();
        newNode.data = new BlueRayDisk(title, director, yearOfRelease, cost);
        if(head == null){
            head = newNode;
            return;
        }

        Node temp = new Node();
        temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newNode;
    }
    public void showAll(){
        Node temp = new Node();
        temp = head;
        while(temp != null){
            Console.WriteLine(temp.data);
            temp = temp.Next;
        }
    }
}