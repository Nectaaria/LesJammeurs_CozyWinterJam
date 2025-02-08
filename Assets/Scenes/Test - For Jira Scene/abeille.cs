using UnityEngine;

public class abeille : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.tag == "Green")
        { //Si le game object qui est rencontré par l'objet est vert alors affiché
            Debug.Log("Collision with a Green");
        }
    }
    }
