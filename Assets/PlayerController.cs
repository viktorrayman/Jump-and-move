/*using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    public Transform spawnPoint;
    public GameObject finishLine;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < spawnPoint.position.y + 1f) // проверка, что игрок находится в зоне спавна
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpForce;
            }

            float moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == finishLine) // проверка, что игрок пересек финишную линию
        {
            transform.position = spawnPoint.position; // спавн игрока в начале уровня
        }
    }
}
*/
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    public Transform spawnPoint;
    public GameObject finishLine;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < spawnPoint.position.y + 1f) // проверка, что игрок находится в зоне спавна
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector2.up * jumpForce;
            }

            float moveInput = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == finishLine) // проверка, что игрок пересек финишную линию
        {
            transform.position = spawnPoint.position; // спавн игрока в начале уровня
        }
        else // если игрок столкнулся с препятствием
        {
            transform.position = spawnPoint.position; // вернуть игрока в точку спавна
        }
    }
}
