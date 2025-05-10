using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Collider myCollider;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myCollider = GetComponent<Collider>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myCollider.enabled = false;
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Dropping object!");
            myMeshRenderer.enabled = true;
            myCollider.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
