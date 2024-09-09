using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

void ChangeColorBack()
{
    Renderer parentRenderer = transform.parent.GetComponent<Renderer>();
    if (parentRenderer != null)
    {
        parentRenderer.material.color = Color.red;
    }
}


public void OnCollisionEnter(Collision collision)
    {
        Renderer parentRenderer = transform.parent.GetComponent<Renderer>();
        if (parentRenderer != null)
        {
            parentRenderer.material.color = Color.green;
            Invoke("ChangeColorBack", 5f); // Change color back after 5 seconds
        }

        if (collision.gameObject.CompareTag("Projectile"))
        {
            GameManager.Instance.IncrementScore();

            // Hide target after 5 seconds
            Invoke("HideTarget", 5f);
        }
    }

    void HideTarget()
    {
        gameObject.SetActive(false);
    }



}
