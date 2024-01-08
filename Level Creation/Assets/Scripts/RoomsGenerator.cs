using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RoomsGenerator : MonoBehaviour
{
    public GameObject FirstRoom;
    public GameObject placeToSpawn;

    public GameObject[] TopRooms;
    public GameObject[] LeftRooms;
    public GameObject[] RightRooms;
    public GameObject[] BottomRooms;

    public Direction direction;

    private int rand;
    private bool spawned = false;
    private float waitTime = 3f;

    string[] size = new string[] { "Small", "Medium", "Big"};
    public enum Direction
    {
        Top,
        Bottom,
        Left,
        Right,
        None
    }

    private void Start()
    {
        Instantiate(FirstRoom, placeToSpawn.transform.position, Quaternion.identity);
        
    }

    public void Spawn()
    {
        string randomSize = size[Random.Range(0, size.Length)];



        if(direction == Direction.Top)
        {
            rand = Random.Range(0, TopRooms.Length);
            Instantiate(TopRooms[rand], transform.position, TopRooms[rand].transform.rotation);
        }
        else if (direction == Direction.Bottom)
        {
            rand = Random.Range(0, TopRooms.Length);
            Instantiate(BottomRooms[rand], transform.position, BottomRooms[rand].transform.rotation);
        }
        else if (direction == Direction.Left)
        {
            rand = Random.Range(0, LeftRooms.Length);
            Instantiate(LeftRooms[rand], transform.position, LeftRooms[rand].transform.rotation);
        }
        else if (direction == Direction.Bottom)
        {
            rand = Random.Range(0, RightRooms.Length);
            Instantiate(RightRooms[rand], transform.position, RightRooms[rand].transform.rotation);
        }
    }
}
