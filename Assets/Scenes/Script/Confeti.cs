using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confeti : MonoBehaviour
{
    public GameObject conffeti;
    // Start is called before the first frame update
   

    public void Click()
    {
        GameObject ob = Instantiate(conffeti);
        Destroy(ob, 2.5f);
    }
}
