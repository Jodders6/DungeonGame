namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        public string NextRoom { get; private set; }
        public string Item { get; private set; }

        public Room(string description, string nextRoom = null, string item = null)
        {
            this.description = description;
            NextRoom = nextRoom;
            Item = item;
        }


        public string GetDescription()
        {
            return description + (Item != null ? $" You notice {Item} lying on the floor.": "");
        }

        public string PickUpItem()
        {
            if (Item != null)
            {
                string pickedItem = Item;
                Item = null;
                return pickedItem;
            }
            return null;

        }
    }
}