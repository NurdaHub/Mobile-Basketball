using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;

    private int count = 0;
    private const string countText = "Count : ";

    private void Start()
    {
        ResetCount();
    }

    public void ResetCount()
    {
        count = 0;
        counterText.text = countText + count;
    }

    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        counterText.text = countText + count;
    }
}
