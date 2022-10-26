using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miscript : MonoBehaviour
{
    [SerializeField] private bool booleano;
    private int cont;

    [SerializeField] private GameObject cubo;

    private void Awake()
    {
        cont = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(cont);
    }

    // Update is called once per frame
    void Update()
    {
        if (booleano)
        {
            Debug.Log(cont++);
            cubo.transform.position = new Vector3(cubo.transform.position.x + .1f, cubo.transform.position.y, cubo.transform.position.z);
        }
    }
}
