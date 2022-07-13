using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;
    Vector2 movement;
    public Vector2 mousePos;
    public GameObject staff;
    public GameObject spawnPoint;
    public bool dead;
    public Staff staffAction;

    private void Start()
    {
        staffAction = gameObject.GetComponentInChildren<Staff>();
    }
    void Update()
    {
        if (!dead)
        {
            // ----------------------- Inputs ----------------------- //

            mousePos = Input.mousePosition;
            mousePos.Normalize();
            // A-B = Vector from A To B
            Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            // Normalize else Quaternion if pure
            diff = diff.normalized;
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            rigidbody.MovePosition(new Vector2(transform.position.x, transform.position.y) + movement.normalized * Time.fixedDeltaTime * speed);

            // Let's use quaternions for the staff rotation.

            // Add the Angle (Atan2 gets Vector to angle in radians) convert to degrees.
            // Either of these can work. : )
            staff.transform.rotation = Quaternion.AngleAxis(Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg - 90, Vector3.forward);
            //staff.transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg - 90);

            // ----------------------- Shooting ----------------------- //

            if (Input.GetMouseButton(0))
            {
                staffAction.Fire(mousePos);
            }
        }
    }
}
