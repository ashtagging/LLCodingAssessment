
namespace LLCodingAssessment
{
    // Folder class that can contain Folders or Items (Nodes)
    internal class Folder : Node
    {
        // Need to be able to add or delete items within a folder
        // Add and delete folders
        // Each folder can contain items or folders -> Nodes 

        public List<Node> Nodes { get; set; }

        // Add a node to the folder 
        public void AddNode(Node node)
        {
            Nodes.Add(node);
        }

        // Remove a single node from the folder
        public void RemoveNode(Node node)
        {
            Nodes.Remove(node);
        }

        // Deletes the folder and the nodes within it
        public void DeleteFolder()
        {
            // recursiion to delete 
            foreach (Node node in Nodes)
            {
                if (node is Folder folder)
                {
                    folder.DeleteFolder();
                }
            }

            // Remove the folder from its parent folder
            ParentFolder.RemoveNode(this);
        }

        // Moves the folder and all its contents to a new parent folder
        public void MoveFolder(Folder newParent)
        {
            // Remove the folder from the old parent folder and add it to the new parent folder
            ParentFolder.RemoveNode(this);

            newParent.AddNode(this);
          
            foreach (Node node in Nodes)
            {
                if (node is Folder folder)
                {
                    folder.MoveFolder(this);
                }
            }
        }
    }
}
