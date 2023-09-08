

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

       ListNode Head = new ListNode();
       ListNode current = Head;
       int carry = 0;
      while ( l1 != null || l2 != null || carry != 0 )
      {

        int num1 = 0;
        int num2 = 0;
        if(l1 != null ) {num1 = l1.val;}
        if(l2 != null ) {num2 = l2.val;}

        int sum = num1 + num2 + carry;

        current.next = new ListNode(sum % 10);
        carry = sum / 10; 
       

        if (l1 != null) l1 = l1.next;
        if(l2!= null) l2 = l2.next;

        current = current.next; 


      }


    return Head.next;





}


ListNode firstnumber = new ListNode(2, new ListNode(4, new ListNode(3, null))); // 342

ListNode secondnumber = new ListNode(5, new ListNode(6, new ListNode(4, null))); // 465


ListNode answer = AddTwoNumbers(firstnumber, secondnumber);

Console.WriteLine(answer.next.next.val);



public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}