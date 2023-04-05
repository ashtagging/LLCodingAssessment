# LL Coding Assessment

My solution for the LL Coding Assessment is based upon the following required functionality and rules

## Available Actions

The solution incorporates the following actions
- Adding and deleting items within a folder.
- Adding and deleting folders.
- Moving items or folders (along with the contents, it is a folder being moved.)
- Searching for a folder or item (this function should apply to any folder and return all items or folders matching.)

## Business Rules

- Each item and folder must have a name.
- Folders can contain items or folders.
- Items cannot contain anything.
- Moving a folder should move everything contained within the folder.
- Deleting a folder should delete everything contained in the folder.

## Solution Description

This implementation consists of two methods that can be called to retrieve all the items of a specific type across all categories and folders.

GetItemsByName is a  method that performs a recursive search for items with the specified name in the provided folder and its subfolders. It takes the current folder and the desired item name as parameters. The method then iterates through each node in the current folder. If the node is an Item with the specified name, it adds it to the items list. If the node is a Folder, the method calls itself recursively to search for matching items within that folder.

GetAllItemsByName is a method that can be called from outside the Tree class. It takes the desired item name as a parameter and starts the search from the root folder of the tree. This method then returns the list of items with the specified name found across all categories and folders in the tree.

```csharp
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

```
