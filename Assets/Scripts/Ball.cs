using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject uiGameOver;
    public GameObject Particles;
    public float speed = 5;
    public Vector2 dir;
    private Vector2 origPos;
    public TextMeshProUGUI Player1;
    public TextMeshProUGUI Player2;

    public GameState Game;

    void Start()
    {
        origPos = transform.position;
    }

    public void Play()
    {
        Game = new GameState();
        transform.position = origPos;
        float result = Random.Range(0f, 1f);
        if (result < 0.5)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
    }

    float hitDir(Vector2 ballPos, Vector2 paddlePos, float paddleHeight)
    {
        return (ballPos.y - paddlePos.y) / paddleHeight;
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.name == "RedPaddle")
        {
            var particle = Instantiate(Particles, c.contacts[0].point, Quaternion.identity);
            Destroy(particle, 1.0f);
            float y = hitDir(transform.position, c.transform.position, c.collider.bounds.size.y);
            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (c.gameObject.name == "GreenPaddle")
        {
            var particle = Instantiate(Particles, c.contacts[0].point, Quaternion.identity);
            Destroy(particle, 1.0f);
            float y = hitDir(transform.position, c.transform.position, c.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        if (c.gameObject.name == "LeftBounds")
        {
            Game.ScoreRight();
            Player2.text = Game.rightScore.ToString();
            if (Game.rightScore >= 2)
            {
                GetComponent<Rigidbody2D>().velocity = dir * 0;
                uiGameOver.SetActive(true);
            }
            else
            {
                transform.position = origPos;
            }
        }
        if (c.gameObject.name == "RightBounds")
        {
            Game.ScoreLeft();
            Player1.text = Game.leftScore.ToString();
            if (Game.leftScore >= 2)
            {
                GetComponent<Rigidbody2D>().velocity = dir * 0;
                uiGameOver.SetActive(true);
            }
            else
            {
                transform.position = origPos;
            }
        }
    }
}