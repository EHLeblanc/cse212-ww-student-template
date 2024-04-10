public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2

        //                      50
        //          25                               75
        //                               63                      88
        //                                                  81          94        

        // Find is a Node contains a value
        // IF value == Data
        //      RETURN TRUE
        // ELSE IF value > Data
        //      IF Right != NULL
        //          RETURN FALSE
        //      ELSE
        //          Right.Contains( value )
        // ELSE IF value < Data
        //      IF Left != NULL
        //          RETURN FALSE
        //      ELSE
        //          Left.Contains( value )



        if (value == Data)
        {
            return true;
        }
        else if (value > Data)
        {
            if (Right != null)
                return false;
            else
                Right.Contains(value);
        }
        else if (value < Data)
        {     
              if (Left != null)
                return false;
              else
                Left.Contains(value);
        }
        
    }

    public int GetHeight() {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}