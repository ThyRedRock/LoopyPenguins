using UnityEngine;
using UnityEngine.InputSystem;

public class Loops : MonoBehaviour 
{
	// reference to penguin prefab object
	public GameObject penguinPrefab;

	// location where penguins start on the left
	public float xStart = -4.0f;

	// amount of space to place between penguins
	public float xOffset = 2.0f;

	// number of penguins to create
	public int numPenguins = 5;

	// Use this for initialization
	void Start () 
	{
		// STUDENT CODE GOES HERE
		int i = 0;
		while (i < numPenguins)
		{
			float xLocation = xStart + (i * xOffset);
			Instantiate(penguinPrefab, new Vector3(xLocation, 0, 0), Quaternion.identity);

			i++; //increment the loop var
    }
		Instantiate (penguinPrefab, new Vector3(0,0,0), Quaternion.identity);

		for (int i=0; i<numPenguins; i++)
		{
			float xLocation = xStart + (i * xOffset);
			Instantiate(penguinPrefab, new Vector3(xLocation, 0, 0), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () 
	{
        // if the space bar was just pressed
        bool clicked = InputSystem.actions.FindAction("Jump").WasPressedThisFrame();
        if (clicked)
        {
			// get all of game objects with the "penguin" tag
			GameObject[] penguins = GameObject.FindGameObjectsWithTag ("penguin");
			int i = penguins.Length-1;
			// STUDENT CODE GOES HERE
			do
			{
				penguins[i].SetActive(false);
				i--;
			}
			while (i >= 0);
		}
		
	}
}
