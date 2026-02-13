using System.Diagnostics;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if(Data == 0)
        {
            Data = value;
        }
        if(value == Data)
        {
            
        }
        else
        {
             if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        }

       
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if(value == Data)
        {
            return true;
        }
        Debug.WriteLine((value < Data));
        if(value < Data)
        {
            if(Left is null)
            {
                
            }
            else 
            {
                Debug.WriteLine(Left is not null);
                Left.Contains(value);
            }
            
        }
        else
        {
            Debug.WriteLine(Right is not null);
            if(Right is null)
            {
                
            }
            else
            {
                Debug.WriteLine("Right: "+(value < Data));
                Right.Contains(value);
                
            }
            
        }
        
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}