using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PersistanceManager : MonoBehaviour
{
    public static PersistanceManager instance { get; private set; }
    public AudioClip dropInCauldron;

    public int score;

    public Text scoreLabel;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        scoreLabel.text = "Score: " + score;
    }
}
