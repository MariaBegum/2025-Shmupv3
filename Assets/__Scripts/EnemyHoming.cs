using UnityEngine;

public class EnemyHoming : MonoBehaviour
{
    public float speed = 5f;
    private Transform hero;

    void Start()
    {
        hero = GameObject.FindWithTag("Hero").transform;
    }

    void Update()
    {
        if (hero == null) return;
        Vector3 direction = (hero.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
}
