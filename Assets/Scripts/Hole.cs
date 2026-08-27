using Unity.VisualScripting;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.GetComponent<Ball>();

        if (b != null && b.Point > 0)
        {
            GameManager.instance.ShowNotText(b.Point);
            Destroy(b.gameObject);
        }
        else
        {
            GameManager.instance.ShowGameoverScreen();
        }
    }


}
