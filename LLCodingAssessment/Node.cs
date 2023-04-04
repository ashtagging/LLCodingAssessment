namespace LLCodingAssessment
{
    // Node class represents a single element in the tree (Item, Folder)
    public class Node
    {        
        public string Name { get; set; }

        public Node(string name)
        {
            Name = name;
        }
    }
}