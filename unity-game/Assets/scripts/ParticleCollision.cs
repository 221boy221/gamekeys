using UnityEngine;
using System.Collections;

public class ParticleCollision : MonoBehaviour {

    void OnParticleCollision(GameObject other) {
        Rigidbody body = other.rigidbody;
        if (body) {
            Vector3 direction = other.transform.position - transform.position;
            direction = direction.normalized;
            body.AddForce(direction * 5);
        }
    }

}
