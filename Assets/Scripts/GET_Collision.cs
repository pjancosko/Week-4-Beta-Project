using UnityEngine;

public class GET_Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerObject"))
        {
            print("Trigger Entered");

            // Change the color to red
            Renderer renderer = other.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.red;
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TriggerObject"))
        {
            print("Trigger Stay");
            // No action needed here since the object will be destroyed in OnTriggerExit
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TriggerObject"))
        {
            print("Trigger Exit");

            // No action needed here since we are no longer destroying the object
        }
    }
}