using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint, Player;

    private void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startPoint.transform.position;
            other.gameObject.GetComponent<CameraShake>().CameraShakeFunction();
        }

        if (other.gameObject.CompareTag("Player"))
        {
            GameObject firePart = Instantiate(other.transform.Find("Fire").gameObject, transform.position, Quaternion.identity);
            firePart.transform.parent = null;
            firePart.SetActive(true);
            Player.SetActive(false);
            //Player.transform.position = startPoint.transform.position;
            //Invoke(nameof(BornAgain), 1);
            StartCoroutine(BornAgain());  
        }
    }

    IEnumerator BornAgain()
    {
        Player.transform.position = startPoint.transform.position + new Vector3(0,1,0);
        Player.transform.eulerAngles = Vector3.zero;
        yield return new WaitForSeconds(1);
        Player.SetActive(true);
        Player.transform.Find("Magic").GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(1.0f);
        Player.transform.Find("Magic").GetComponent<ParticleSystem>().Stop();
    }
    
}