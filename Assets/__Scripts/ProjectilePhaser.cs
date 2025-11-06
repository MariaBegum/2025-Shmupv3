using UnityEngine;

public class ProjectilePhaser : MonoBehaviour
{
    public float speed = 20f;
    public float frequency = 10f;
    public float magnitude = 0.5f;
    private Vector3 axis;
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        axis = transform.right;
    }

    void Update()
    {
        pos += transform.up * Time.deltaTime * speed;
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
    }
}
