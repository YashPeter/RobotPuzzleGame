using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData{

    //tile and item on specific postition//
    Tile tile;
    Item item;
    //constructor that makes new tile and items and sets the inicialized tiles and items//
    public MapData(int tile, int item)
    {
        this.tile = new Tile(tile);
        this.item = new Item(item);
    }
    //getters and setters//
    public int returnTileType()
    {
        return tile.returnType();
    }

    public int returnItemType()
    {
        return item.returnType();
    }

    public void setTileType(int t)
    {
        tile.setType(t);
    }

    public void setItemType(int i)
    {
        item.setType(i);
    }
}
