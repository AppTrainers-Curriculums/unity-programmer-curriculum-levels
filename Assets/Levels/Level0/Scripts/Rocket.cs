using UnityEngine;

// Counts down, launches the rocket and flies it to orbit.
// Attach this to the Rocket object.
public class Rocket : MonoBehaviour
{
    // ---- Tune these numbers, then press Play ----
    int countdownSeconds = 5;   // seconds before liftoff
    float climbSpeed = 2f;      // how fast the rocket climbs (units per second)
    float orbitHeight = 12f;    // the height where the mission is complete
    float fuel = 100f;          // fuel in the tank at liftoff
    float burnRate = 10f;       // fuel burned every second while climbing

    // ---- The rocket's state: these change while the game runs ----
    int secondsLeft;
    float timer = 0f;
    bool isLaunched = false;
    bool missionOver = false;
    string currentStage = "Launch pad";

    // Start runs once, when the game starts
    void Start()
    {
        secondsLeft = countdownSeconds;
        Debug.Log("Countdown started: T-minus " + secondsLeft);
    }

    // Update runs every frame
    void Update()
    {
        // Once the mission is over, there is nothing left to do
        if (missionOver)
        {
            return;
        }

        if (!isLaunched)
        {
            RunCountdown();
        }
        else
        {
            Fly();
        }
    }

    // Counts down one second at a time, then launches
    void RunCountdown()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;
            secondsLeft--;

            if (secondsLeft > 0)
            {
                Debug.Log("T-minus " + secondsLeft);
            }
            else
            {
                Launch();
            }
        }
    }

    void Launch()
    {
        isLaunched = true;
        Debug.Log("LIFTOFF!");
    }

    // Moves the rocket up, burns fuel and checks how the mission is going
    void Fly()
    {
        transform.Translate(0f, climbSpeed * Time.deltaTime, 0f);
        fuel -= burnRate * Time.deltaTime;

        float height = transform.position.y;
        CheckStage(height);

        if (height >= orbitHeight)
        {
            EndMission(true);
        }
        else if (fuel <= 0f)
        {
            EndMission(false);
        }
    }

    // Prints a message only when the rocket enters a new stage
    void CheckStage(float height)
    {
        string stage = GetStageName(height);

        if (stage != currentStage)
        {
            currentStage = stage;
            Debug.Log("Now entering: " + stage);
        }
    }

    // Returns the name of the stage for a given height
    string GetStageName(float height)
    {
        if (height >= 10f)
        {
            return "Space";
        }
        else if (height >= 6f)
        {
            return "Upper atmosphere";
        }
        else if (height >= 2f)
        {
            return "Lower atmosphere";
        }
        return "Launch pad";
    }

    // Ends the mission and reports how it went
    void EndMission(bool success)
    {
        missionOver = true;

        if (success)
        {
            Debug.Log("ORBIT REACHED! Mission success. Fuel left: " + fuel);
        }
        else
        {
            Debug.Log("OUT OF FUEL at height " + transform.position.y + ". Mission failed.");
        }
    }
}
