using System.Text;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next!;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        if (l1 == null) return null!;
        if (l2 == null) return null!;
        ListNode current1 = l1;
        ListNode current2 = l2;
        ListNode? resultlist = null;
        ListNode? reverselist = null;
        int addOne = 0;
        int sum = 0;
        while (current1 != null || current2 != null)
        {
            if (addOne > 0)
            {
                resultlist = new ListNode(1, resultlist);
                addOne = 0;
            }
            else
            {
                resultlist = new ListNode(0, resultlist);
            }
            sum = resultlist.val + (current1 != null ? current1.val : 0) + (current2 != null ? current2.val : 0);
            resultlist.val = sum % 10;  // remainder 
            addOne = sum / 10;    // quotient 
            if (current1 != null)
            {
                current1 = current1.next;
            }
            if (current2 != null)
            {
                current2 = current2.next;
            }
        }
        if (addOne > 0)
        {
            resultlist = new ListNode(1, resultlist);
        }
        while (resultlist != null)
        {
            reverselist = new ListNode(resultlist.val, reverselist);
            resultlist = resultlist.next;
        }
        return reverselist!;

    }

    public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
    {
        int carry = 0;
        ListNode dummy = new ListNode(0);
        ListNode pre = dummy;

        while (l1 != null || l2 != null || carry == 1)
        {
            int sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            carry = sum < 10 ? 0 : 1;
            pre.next = new ListNode(sum % 10);
            pre = pre.next;

            if (l1 != null)
            {
                l1 = l1.next;
            }

            if (l2 != null)
            {
                l2 = l2.next;
            }
        }

        return dummy.next;

    }

    public List<int> printAllNodes(ListNode? next = null)
    {
        List<int> list = new List<int>();   
        ListNode? current = next;
        while (current != null)
        {
            list.Add(current.val);
            current = current.next;
        }
        return list;
    }

    public ListNode Append(ListNode head, int data)
    {
        ListNode newNode = new ListNode(data);
        if (head == null)
        {
            head = newNode;
        } else
        {
            ListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
        return head;
    }
    static void Main()
    {
        //int[] nums1 = { };
        //int[] nums2 = { };

        //int[] nums1 = { 0 };
        //int[] nums2 = { 0 };

        //int[] nums1 = { 2, 4, 3 };
        //int[] nums2 = { 5, 6, 4 };

        //int[] nums1 = { 9, 9, 9, 9, 9, 9, 9 };
        //int[] nums2 = { 9, 9, 9, 9 };

        //int[] nums1 = { 9, 9, 9, 9 };
        //int[] nums2 = { 9, 9, 9, 9, 9, 9, 9 };

        //int[] nums1 = { 9 };
        //int[] nums2 = { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

        //int[] nums1 = { 2, 4, 9 };
        //int[] nums2 = { 5, 6, 4, 9 };

        int[] nums1 = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
        int[] nums2 = { 4, 6, 5 };

        ListNode? l1 = null;
        ListNode? l2 = null;
        Solution sol = new Solution();
        foreach (int x in nums1)
        {
            l1 = sol.Append(l1!, x);
        }
        foreach (int x in nums2)
        {
            l2 = sol.Append(l2!, x);
        }
        ListNode res = sol.AddTwoNumbers(l1!, l2!);
        Console.WriteLine(String.Join("", sol.printAllNodes(res)));
    }
}