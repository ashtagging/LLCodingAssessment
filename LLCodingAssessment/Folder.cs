
namespace LLCodingAssessment
{
    // Folder class that can contain Folders or Items (Nodes)
    public class Folder : Node
    {
        public List<Node> Nodes { get; set; }

        public Folder(string name) : base(name)
        {
            Nodes = new List<Node>();
        }

        public void AddItem(string name)
        {
            Nodes.Add(new Item(name));
        }

        public void AddFolder(string name)
        {
            Nodes.Add(new Folder(name));
        }

        public void DeleteNode(Node node)
        {
            Nodes.Remove(node);
        }

        public void MoveNode(Folder targetFolder, Node node)
        {
            Nodes.Remove(node);
            targetFolder.Nodes.Add(node);
        }

        public List<Node> SearchNode(string searchString)
        {
            List<Node> searchResults = new List<Node>();

            foreach (var node in Nodes)
            {
                if (node.Name.Contains(searchString))
                {
                    searchResults.Add(node);
                }

                // Recursion to search nodes in other folders down the hierarchy
                if (node is Folder folder)
                {
                    searchResults.AddRange(folder.SearchNode(searchString));
                }
            }

            return searchResults;
        }
    }
}
