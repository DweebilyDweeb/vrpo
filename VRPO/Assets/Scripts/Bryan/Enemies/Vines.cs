using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vines : MonoBehaviour 
{
    public List<Rope> listOfVines = new List<Rope>();

    private bool boatReleased = false;
    // Use this for initialization
	void Start () 
    {
		for(int i = 0; i < transform.childCount; i++)
        {
            listOfVines.Add(transform.GetChild(i).GetComponent<Rope>());
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!boatReleased)
        {
            int cutCount = 0;

            if (listOfVines.Count == 1)
            {
                if (listOfVines[0].isCut)
                    cutCount++;

                if (cutCount > 0)
                    ReleaseBoat();
            }
            else
            {
                for (int i = 0; i < listOfVines.Count - 1; i++)
                {
                    if (listOfVines[i].isCut)
                        cutCount++;

                    if (i == listOfVines.Count - 1)
                        if (cutCount == (listOfVines.Count - 1)) { ReleaseBoat(); }
                }
            }
        }
	}

    void ReleaseBoat()
    {
        boatReleased = true;
        GameObject.FindGameObjectWithTag("Boat").GetComponent<BoatScriptedMovement>().isOnTheMove = true;
        StartCoroutine(DespawnVineList());
    }

    private IEnumerator DespawnVineList()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }
}
