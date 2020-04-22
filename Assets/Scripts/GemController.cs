using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        this.gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Detected collision between " + this.gameObject.GetComponent<SpriteRenderer>().sprite.name + " and " + collision.collider.name);

        int scoreChange = 0;

        switch (this.gameObject.GetComponent<SpriteRenderer>().sprite.name)
        {
            case "blue_gem":
                scoreChange = 1;
                break;
            case "red_gem":
                scoreChange = 2;
                break;
            case "green_gem":
                scoreChange = 3;
                break;
            case "white_gem":
                scoreChange = 4;
                break;
            default:
                Debug.Log("Gem Name Error");
                break;
        }

        this.gameManager.Score += scoreChange;
        this.gameObject.SetActive(false);
    }
}
