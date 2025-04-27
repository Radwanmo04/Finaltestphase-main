using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public Animator anim;

    // Update is called once per frame
    public void CameraShakeFunction()
    {
        anim.SetTrigger("Death");
    }
}
