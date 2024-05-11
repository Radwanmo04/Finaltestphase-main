using UnityEngine;

public class Garbage : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;
    private GarbageManager garbageManager;
    private void Start()
    {
        garbageManager = GarbageManager.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            garbageManager.ChangeGarbage(value);
            Destroy(gameObject);
        }
    }
}
