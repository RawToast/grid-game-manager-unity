using UnityEngine;

public class Goal : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D other) {
        print("You win! Next level coming up");
        Grd.Level.NextLevel();
    }
}