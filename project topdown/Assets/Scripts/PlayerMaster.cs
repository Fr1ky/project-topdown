using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMaster : MonoBehaviour {

    public int curHp;
    public int maxHp;

    public int curMp;
    public int maxMp;

    public Slider hpBar;

	// Use this for initialization
	void Start () {
        hpBar.maxValue = maxHp;
	}
	
	// Update is called once per frame
	void Update () {
        checkPlayerStatus();
	}

   void checkPlayerStatus()
    {

        hpBar.value = curHp;
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
