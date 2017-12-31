using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private float speed;

    private void FixedUpdate() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rig.velocity =
                new Vector2(-1 * speed * Time.deltaTime, rig.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            rig.velocity =
                new Vector2(1 * speed * Time.deltaTime, rig.velocity.y);
        }
        else {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }
        

        if (Input.GetKey(KeyCode.UpArrow)) {
            rig.velocity =
                new Vector2(rig.velocity.x, 1 * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow)) {
            rig.velocity =
                new Vector2(rig.velocity.x, -1 * speed * Time.deltaTime);
        }
        else {
            rig.velocity = new Vector2(rig.velocity.x, 0);
        }

        
        Grd.Score.AddToScore(1);
        
        transform.position =
            new Vector3(transform.position.x,
                transform.position.y, 0);
    }
}