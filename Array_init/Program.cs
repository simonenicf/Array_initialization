using System;

namespace Array_init
{
    class Program
    {
        static void Main()
        {
            Room[,] newRoom = new Room[5, 6];
        }
    }

    class Room
    {
        public Tile [,] myTileArray;

        public Room (int width, int height)
        {
            myTileArray = new Tile [width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    myTileArray[i, j] = new Tile();
                }
            }
        }

    }


    class Tile
    {

    }

}
