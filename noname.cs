using BepInEx;
using UnityEngine;

[BepInPlugin("com.yn.ym", "Your Mod Name", "1.0.0")]
public class YourModName : BaseUnityPlugin
{
    private bool showGUI = false;

    private void OnGUI()
    {
        if (showGUI)
        {
            // Draw the GUI box
            GUI.Box(new Rect(10, 10, 200, 100), "Your Mod Menu");

            // Add a button to enable ghost mode
            if (GUI.Button(new Rect(20, 40, 180, 30), "Enable Ghost Mode"))
            {
                EnableGhostMode();
            }

            // Add a button to disable ghost mode
            if (GUI.Button(new Rect(20, 80, 180, 30), "Disable Ghost Mode"))
            {
                DisableGhostMode();
            }
        }
    }

    private void Update()
    {
        // Toggle the GUI display with the "G" key
        if (Input.GetKeyDown(KeyCode.G))
        {
            showGUI = !showGUI;
        }
    }

    private void EnableGhostMode()
    {
        Debug.Log("Ghost Mode Enabled!");
        // Insert logic for enabling ghost mode here
    }

    private void DisableGhostMode()
    {
        Debug.Log("Ghost Mode Disabled!");
        // Insert logic for disabling ghost mode here
    }
}
