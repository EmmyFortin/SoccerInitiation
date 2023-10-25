using UnityEngine;

public class MoveControls : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;
    [SerializeField] private KeyCode up = KeyCode.W;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode right = KeyCode.D;
    [SerializeField] private KeyCode down = KeyCode.S;
    void Update()
    {
        if (Input.GetKey(up))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(down))
        { 
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(left)) { 
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(right))
        {
            transform.Rotate(0, 1, 0);
        }
    }
}
