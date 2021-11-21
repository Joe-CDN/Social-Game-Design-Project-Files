using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObserverPattern
{
    //Events
    public abstract class ObjectEvents
    {
        public abstract void SpawnObject();
    }

    //public class LoadWin : PlayerEvents
    //{
    //    public override  void LoadWinScreen()
    //    {
    //        SceneManager.LoadScene("Win");
    //    }
    //}
}
