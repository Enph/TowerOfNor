using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

    public float PlayerMovementSpeed = 10.0f;
    public float PlayerRotationSpeed = 180.0f;
    public float PlayerJumpHeight = 10.0f;
    public float Gravity = 20.0f;
    private int jumpCount = 0;
    public GUI_Menu menuScript;





	// Use this for initialization
	void Start () {
        Physics.gravity = new Vector3(0.0f, -Gravity, 0.0f);
        

	}
	
	// Update is called once per frame
	void Update () {
        Movement();
        UserInputs();
	}

    void OnCollisionEnter()
    {
        //Debug.print("Collided");
        jumpCount = 0; // Reset the jump count when player touches the ground
    }

	void Movement()
	{
        // Vertical Movement , This should be on the Z Axis
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * PlayerMovementSpeed);
        // Horizontal Movement , this should be on the X Axis. Strafing happens if both vertical and horizontal are used
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * PlayerMovementSpeed, 0, 0);
        // Rotate player on Y Axis.
        //transform.Rotate(0, Input.GetAxis("RightStick") * Time.deltaTime * PlayerRotationSpeed, 0, 0);
	}

    void UserInputs()
    {
        // A Button is read from Input Positive Button "joystick button 0"
        if (Input.GetButtonDown("360_AButton"))
        {
            Debug.print("A Button!");
        }

        // B Button is read from Input Positive Button "joystick button 1"
        if (Input.GetButtonDown("360_BButton"))
        {
            Debug.print("B Button!");
        }

        // X Button is read from Input Positive Button "joystick button 2"
        if (Input.GetButtonDown("360_XButton"))
        {
            Debug.print("X Button!");
        }

        // Y Button is read from Input Positive Button "joystick button 3"
        if (Input.GetButtonDown("360_YButton"))
        {
            Debug.print("Y Button!");
        }

        // Left Bumper is read from Input Positive Button "joystick button 4"
        if (Input.GetButtonDown("360_LeftBumper"))
        {
            Debug.print("Left Bumper!");
        }

        // Right Bumper is read from Input Positive Button "joystick button 5"
        if (Input.GetButtonDown("360_RightBumper") && jumpCount < 2)
        {
            Debug.print("Right Bumper!");
            gameObject.rigidbody.velocity = new Vector3(0.0f,10.0f,0.0f);
            jumpCount++;
        }

        // Back Button is read from Input Positive Button "joystick button 6"
        if (Input.GetButtonDown("360_BackButton"))
        {
            Debug.print("Back Button!");
        }

        // Start Button is read from Input Positive Button "joystick button 7"
        if (Input.GetButtonDown("360_StartButton"))
        {
            Debug.print("Start Button!");
            menuScript.ToggleMenu();
        }

        // Left Thumbstick Button is read from Input Positive Button "joystick button 8"
        if (Input.GetButtonDown("360_LeftJoyStickButton"))
        {
            Debug.print("Left Thumbstick Button!");
        }

        // Right Thumbstick Button is read from Input Positive Button "joystick button 9"
        if (Input.GetButtonDown("360_RightJoyStickButton"))
        {
            Debug.print("Right Thumbstick Button!");
        }

        // Triggers are read from the 3rd Joystick Axis and read from a Sensitivity rating from -1 to 1
        //
        // Right Trigger is activated when pressure is above 0, or the dead zone.
        if (Input.GetAxis("360_Triggers") > 0.001)
        {
            Debug.print("Right Trigger!");
        }

        // Right Trigger is activated when pressure is under 0, or the dead zone.
        if (Input.GetAxis("360_Triggers") < 0)
        {
            Debug.print("Left Trigger!");
        }

        // The D-PAD is read from the 6th(Horizontal) and 7th(Vertical) Joystick Axes and read from a Sensitivity rating from -1 to 1, similar to the Triggers.
        //
        // Right D-PAD Button is activated when pressure is above 0, or the dead zone.
        if (Input.GetAxis("360_HorizontalDPAD") > 0.001)
        {
            Debug.print("Right D-PAD Button!");
        }

        // Left D-PAD Button is activated when pressure is under 0, or the dead zone.
        if (Input.GetAxis("360_HorizontalDPAD") < 0)
        {
            Debug.print("Left D-PAD Button!");
        }

        // Up D-PAD Button is activated when pressure is above 0, or the dead zone.
        if (Input.GetAxis("360_VerticalDPAD") > 0.001)
        {
            Debug.print("Up D-PAD Button!");
        }

        // Down D-PAD Button is activated when pressure is under 0, or the dead zone.
        if (Input.GetAxis("360_VerticalDPAD") < 0)
        {
            Debug.print("Down D-PAD Button!");
        }
    }
}
