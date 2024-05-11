using TMPro;
using UnityEngine;

public class GarbageManager : MonoBehaviour
{
    public static GarbageManager instance;

    private int garbage;
    [SerializeField] private TMP_Text garbageDisplay;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    private void OnGUI()
    {
        garbageDisplay.text = garbage.ToString();
    }
    public void ChangeGarbage(int amount)
    {
        garbage += amount;
    }
}
