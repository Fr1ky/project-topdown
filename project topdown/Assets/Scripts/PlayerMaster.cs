using UnityEngine;
using System.Collections;

public class PlayerMaster : MonoBehaviour {

    public int curHp;
    public int maxHp;

    public int curMp;
    public int maxMp;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        checkPlayerStatus();
	}

   void checkPlayerStatus()
    {
        if(curHp > maxHp)
        {
            curHp = maxHp;
        }
        if (curMp > maxMp)
        {
            curMp = maxMp;
        }

        if(curHp <= 0)
        {
            Debug.Log("You have died!");
        }
    }
}
