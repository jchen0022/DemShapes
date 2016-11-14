using UnityEngine;
using System.Collections;

public class PairsContoller : MonoBehaviour {

    public GameObject drop1;
    public GameObject drop2;
    private LineRenderer lineRenderer;
    public Color c1 = Color.red;
    public Color c2 = Color.blue;

	// Use this for initialization
	void Start () {
        c1 = Color.yellow;
        c2 = Color.green;
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Particles/Alpha Blended"));
        lineRenderer.SetColors(c1, c2);
        Vector3[] points = new Vector3[] {drop1.transform.position, drop2.transform.position};
        lineRenderer.SetPositions(points);
	}
	
	// Update is called once per frame
	void Update () {
        if (drop1 == null || drop2 == null) {
            Destroy(gameObject);
        }
	}

    void OnDestory() {
        Destroy(this.GetComponent<Renderer>().material);
    }
}
