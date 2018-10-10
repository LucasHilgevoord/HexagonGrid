using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexCell : MonoBehaviour {

    GameObject child;
    [SerializeField]
    private Material[] mat;

    // Use this for initialization
    void Start () {
        child = transform.GetChild(0).gameObject;
        Coloring(Random.Range(0, 2));
    }
	
	// Update is called once per frame
	void Update () {
    }

    void Coloring(int num) {
        if (num == 1) {
            child.GetComponent<Renderer>().material = mat[0];
        }
        else {
            child.GetComponent<Renderer>().material= mat[1];
        }

    }
}
