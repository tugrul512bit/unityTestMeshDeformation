using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    public static int sayac { get; set; }
    public static System.Random r { get; set; }
    // Use this for initialization
    public static Material m=null;
    void Start () {
        if (r == null)
            r = new System.Random();
        sayac++;
        if (m == null)
            m = GetComponent<Renderer>().sharedMaterial;
        else
            GetComponent<Renderer>().material = m;

    }


}
