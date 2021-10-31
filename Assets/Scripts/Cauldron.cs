using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public static float potionTotal;

    void Start()
    {
        potionTotal = 0;
        GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = PersistanceManager.instance.dropInCauldron;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("brush"))
        {
            potionTotal = 0f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("water"))
        {
            potionTotal += 6.71f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("sugar"))
        {
            potionTotal += 8.59f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("spice"))
        {
            potionTotal += 9.1f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("gold"))
        {
            potionTotal += 4.08f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("fish"))
        {
            potionTotal += 1.17f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("catnip"))
        {
            potionTotal += 2.41f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("fluff"))
        {
            potionTotal += 3.34f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("clock"))
        {
            potionTotal += 5.13f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("DNA"))
        {
            potionTotal += 7.27f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("rose"))
        {
            potionTotal += 10.82f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("morphSpell"))
        {
            potionTotal += 12.47f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }
        if (collision.collider.tag.Equals("emoteSpell"))
        {
            potionTotal += 11.49f;
            Debug.Log(potionTotal);
            GetComponent<AudioSource> ().Play ();
        }  
    }
}
