using UnityEngine;

// Prints the mission briefing in the Console when the game starts.
// Attach this to the MissionControl object.
public class MissionBriefing : MonoBehaviour
{
    // Start runs once, when the game starts
    void Start()
    {
        // The mission details: one variable of each basic type
        string rocketName = "Falcon";
        int crewSize = 3;
        float fuelTons = 12.5f;
        bool weatherIsClear = true;

        Debug.Log("=== MISSION BRIEFING ===");
        Debug.Log("Rocket: " + rocketName);
        Debug.Log("Crew: " + crewSize + " astronauts");
        Debug.Log("Fuel: " + fuelTons + " tons");

        // Each astronaut needs 2 tons of supplies
        int suppliesTons = crewSize * 2;
        Debug.Log("Supplies: " + suppliesTons + " tons");

        // The launch can only go ahead in clear weather with enough fuel
        if (weatherIsClear && fuelTons >= 10)
        {
            Debug.Log("Status: GO for launch");
        }
        else
        {
            Debug.Log("Status: NO GO, launch delayed");
        }
    }
}
