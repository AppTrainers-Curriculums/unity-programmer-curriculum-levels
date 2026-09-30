using UnityEngine;

// Model answer for the Level 1 entry test practical task.
// Waits, closes the doors, rides up to the target floor and announces each floor.
public class Elevator : MonoBehaviour
{
    // ---- Settings ----
    string buildingName = "AppTrainers Tower";
    int targetFloor = 3;
    float floorHeight = 2f;     // the height of one floor, in units
    float speed = 1.5f;         // units per second
    float waitTime = 2f;        // seconds before the doors close

    // ---- State: these change while the game runs ----
    float timer = 0f;
    bool isMoving = false;
    bool hasArrived = false;
    string currentFloor = "Ground floor";

    void Start()
    {
        Debug.Log("Welcome to " + buildingName + ". Going to floor " + targetFloor);
    }

    void Update()
    {
        // Nothing left to do once we've arrived
        if (hasArrived)
        {
            return;
        }

        if (!isMoving)
        {
            WaitForDoors();
        }
        else
        {
            Ride();
        }
    }

    // Waits a few seconds, then starts moving
    void WaitForDoors()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            isMoving = true;
            Debug.Log("Doors closing");
        }
    }

    // Moves up, announces each new floor, and stops at the target floor
    void Ride()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);

        float height = transform.position.y;
        string floor = GetFloorName(height);

        if (floor != currentFloor)
        {
            currentFloor = floor;
            Debug.Log("Now passing: " + floor);
        }

        if (height >= targetFloor * floorHeight)
        {
            hasArrived = true;
            Debug.Log("Arrived at floor " + targetFloor + ". Doors opening.");
        }
    }

    // Returns the name of the floor at a given height
    string GetFloorName(float height)
    {
        if (height >= 6f)
        {
            return "Floor 3";
        }
        else if (height >= 4f)
        {
            return "Floor 2";
        }
        else if (height >= 2f)
        {
            return "Floor 1";
        }
        return "Ground floor";
    }
}
