using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PullBack : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    Camera cm;
    Vector2 force;
    Vector3 startingPoint;
    Vector3 endingPoint;

    LineRenderer lr;

    public GameObject ball;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(ball);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        cm = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x >= 0)
        {
            if (rb.velocity.y >= 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    startingPoint = cm.ScreenToWorldPoint(Input.mousePosition);
                    startingPoint.z = -15f;

                    if (lr == null)
                    {
                        lr = GetComponent<LineRenderer>();
                    }
                    lr.enabled = true;
                    lr.positionCount = 2;
                    lr.SetPosition(0, transform.position);
                }

                if (Input.GetMouseButton(0))
                {
                    Vector3 currentPoint = cm.ScreenToWorldPoint(Input.mousePosition);
                    currentPoint.z = -15f;

                    endingPoint = cm.ScreenToWorldPoint(Input.mousePosition);
                    endingPoint.z = -15f;

                    lr.SetPosition(1, endingPoint);
                }

                if (Input.GetMouseButtonUp(0))
                {
                    force = new Vector2(Mathf.Clamp(startingPoint.x - endingPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startingPoint.y - endingPoint.y, minPower.y, maxPower.y));
                    rb.AddForce(force * power, ForceMode2D.Impulse);


                    lr.enabled = false;
                }
            }
        }
    }
}
