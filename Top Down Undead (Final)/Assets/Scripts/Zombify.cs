using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Zombify : MonoBehaviour

{
    public int coinCount = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            coinCount = coinCount + 1;
            Destroy(collision.gameObject);
            if (coinCount > 0)
            {
                SceneManager.LoadScene("Zombie");
            }
        }
    }
}
