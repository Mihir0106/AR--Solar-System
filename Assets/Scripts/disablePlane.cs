using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disablePlane : MonoBehaviour
{
    public GameObject Manager;
    // Start is called before the first frame update
    public void Disable()
    {
        Manager.SetActive(false);
    }
    public void able()
    {
        Manager.SetActive(true);
    }


}
