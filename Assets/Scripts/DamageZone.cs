using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Add debug statements for troubleshooting
        if (other == null)
        {
            Debug.LogError("Collider2D is null!");
            return;
        }

        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
        else
        {
            Debug.LogWarning("RubyController not found on the colliding GameObject.");
        }
    }
}
