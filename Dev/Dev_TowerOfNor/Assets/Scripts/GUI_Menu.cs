using UnityEngine;
using System.Collections;

public class GUI_Menu : MonoBehaviour {

    private bool OpenMenu;
    private string selectedMenu;

	// Use this for initialization
	void Start () {
        this.OpenMenu = false;
        this.selectedMenu = "MainMenu";

	
	}

	// Update is called once per frame
	void Update () {


	}

    void OnGUI()
    {

        if (OpenMenu == true)
        {
            switch (selectedMenu)
            {

                case "MainMenu":
                    {
                        //Show MainMenu
                        MainMenu();

                        break;
                    }
                case "Options":
                    {
                        //Show Options
                        OptionsTab();
                        break;
                    }
                default:
                    {

                        break;
                    }
            }
        }
    }

    // Toggles the Main Menu On / off when the user presses start
    public void ToggleMenu()
    {
        if (OpenMenu == true)
            this.OpenMenu = false;
        else
            this.OpenMenu = true;
    }


    private void MainMenu()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.Label("MainMenu");
        if (GUILayout.Button("Options"))
            selectedMenu = "Options";
        GUILayout.EndArea();
    }
    private void OptionsTab()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height), "Options");
        GUILayout.Label("Master Volume");
        GUILayout.Label("Music Volume");
        GUILayout.Label("Sound Fx Volume");
        if (GUILayout.Button("Graphic Option"))
        { 
            
        }
        GUILayout.EndArea();
    }
}
