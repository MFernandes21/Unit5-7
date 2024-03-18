using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void PlaySFX()
    {
        print("play sfx!!!");
        AudioManager.instance.PlaySFX("Button");
    }
}
