using UnityEngine;
using System.Collections;

public class PairsContoller : MonoBehaviour {

    public GameObject drop1;
    public GameObject drop2;
    //public Color c1 = Color.black;
    //public Color c2 = Color.black;
    private LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        //lineRenderer.SetColors(c1, c2);
        Vector3[] points = new Vector3[] {drop1.transform.position, drop2.transform.position};
        lineRenderer.SetPositions(points);
	}
	
	// Update is called once per frame
	void Update () {
        if (drop1 == null || drop2 == null) {
            Destroy(gameObject);
        }
	}
}
