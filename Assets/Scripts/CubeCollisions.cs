using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisions : MonoBehaviour
{
    [SerializeField] private GameObject _sparksPrefab;
    [SerializeField] private GameObject _cubeParticlesPrefab;
    private void OnCollisionEnter(Collision collision)
    {
        var sparks = Instantiate(_sparksPrefab, transform.position, transform.rotation);
        if (collision.transform.tag == "Ground")
        {
            var cube = Instantiate(_cubeParticlesPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
