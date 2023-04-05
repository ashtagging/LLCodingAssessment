using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public List<Item> GetAllItemsByName(string itemName)
        {
            return GetItemsByName(Root, itemName);
        }

        private List<Item> GetItemsByName(Folder folder, string itemName)
        {
            List<Item> items = new List<Item>();

            foreach (var node in folder.Nodes)
            {
                if (node is Item item && item.Name == itemName)
                {
                    items.Add(item);
                }

                if (node is Folder subFolder)
                {
                    items.AddRange(GetItemsByName(subFolder, itemName));
                }
            }

            return items;
        }
    }
}