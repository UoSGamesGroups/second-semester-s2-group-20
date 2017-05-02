using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Destroyer : MonoBehaviour {

	public float timer;
    public int scoreValue;
    public int scoreValue1;
    private BasketPoints basketpoints;
    private BasketPoints2 basketpoints2;

    void Start()
    {
        GameObject basketpointsObject = GameObject.FindWithTag("Basket");
        if (basketpointsObject !=null)
        {
            basketpoints = basketpointsObject.GetComponent<BasketPoints>();
        }
        GameObject basketpoints2Object = GameObject.FindWithTag("Basket1");
        if (basketpointsObject !=null)
        {
            basketpoints2 = basketpoints2Object.GetComponent<BasketPoints2>();
        }
    }

 

	void Update () 
	{
		timer += 1.0f * Time.deltaTime;
		if (timer >= 5) 
		{
			GameObject.Destroy (gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Basket") {
			basketpoints.AddScore (scoreValue);
		}
		if (collision.gameObject.tag == "Basket1") {
			basketpoints2.AddScore1 (scoreValue1);
		}
	}
}