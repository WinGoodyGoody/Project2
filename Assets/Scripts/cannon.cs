using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cannon : MonoBehaviour
{
    public GameObject bullet;
    public float[] numbers;
    float countTotal=0;

	//Count for cannon balls or bullets
	public int numberBullets;
	public Text countText;

    // Use this for initialization
    void Start()
    {
        //print( Add(x, y));
        print(Add(numbers));
		// Initialise number of bullets to zero
		numberBullets = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
			numberBullets = numberBullets + 1;
			countText.text = "Cannon Balls Fired: " + numberBullets.ToString ();
        }
    }

    void Fire()
	// Bring bullet into existance
    { 
		Instantiate(bullet, transform.position, transform.rotation); 
	}

    float Add (float[] numbers)
    {
       

        for (int i = 0; i <  numbers.Length; i++)
        {
            countTotal += numbers[i];
                }
        return countTotal;
    }
}
