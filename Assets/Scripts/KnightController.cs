using UnityEngine;

// ReSharper disable once CheckNamespace
public class KnightController : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float MaxSpeed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var move = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(move * MaxSpeed, _rb.velocity.y);

        var animator = GetComponent<Animator>();
        
    }
}
