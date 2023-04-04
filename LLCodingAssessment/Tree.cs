using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLCodingAssessment
{
    // Tree class to Model the Node structure 
    public class Tree
    {
        // Root Node (Folder) of the tree
        public Folder Root { get; set; } 

        // Retrieve all items of a particular type across all folders
        public List<Item> GetAllItemsOfType<T>()
        {
            // search all nodes within the tree
            // return a list of items that are of the specified type
        }
    }
}
