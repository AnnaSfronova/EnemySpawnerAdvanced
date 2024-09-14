using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Target _target;

    private void Update()
    {
        transform.LookAt(_target.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.TryGetComponent(out Target target))
            Destroy(gameObject);
    }

    public void Init(Vector3 position, Target target)
    {
        transform.position = position;
        _target = target;
    }
}
