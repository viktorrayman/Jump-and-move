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
        if (transform.position.y < spawnPoint.position.y + 1f) // ��������, ��� ����� ��������� � ���� ������
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
        if (collision.gameObject == finishLine) // ��������, ��� ����� ������� �������� �����
        {
            transform.position = spawnPoint.position; // ����� ������ � ������ ������
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
        if (transform.position.y < spawnPoint.position.y + 1f) // ��������, ��� ����� ��������� � ���� ������
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
        if (collision.gameObject == finishLine) // ��������, ��� ����� ������� �������� �����
        {
            transform.position = spawnPoint.position; // ����� ������ � ������ ������
        }
        else // ���� ����� ���������� � ������������
        {
            transform.position = spawnPoint.position; // ������� ������ � ����� ������
        }
    }
}
