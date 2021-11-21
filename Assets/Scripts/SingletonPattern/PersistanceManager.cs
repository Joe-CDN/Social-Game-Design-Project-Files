using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistanceManager : MonoBehaviour
{
    public static PersistanceManager instance { get; private set; }

    public AudioClip dropInCauldron;
    public AudioClip titleMusic;

    public int score;

    public bool useJoystick = false;
    public bool grabObject = false;
    public bool playing = false;    

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
}
