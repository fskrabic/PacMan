using UnityEngine;
using System.Collections;

public class PacmanMove : MonoBehaviour {
    public float speed = 0.4f;
    Vector2 dest = Vector2.zero;
    public bool p = false;
    private GameObject gc;
    

    void Start() {
        dest = transform.position;
        gc = GameObject.FindWithTag("proba");
    } 
     
    bool valid(Vector2 dir) {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }

    void FixedUpdate() {
        p = gc.GetComponent<GameController>().playing;
        if (p) {
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);
        
        if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
            dest = (Vector2)transform.position + Vector2.up;
        if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
            dest = (Vector2)transform.position + Vector2.right;
        if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
            dest = (Vector2)transform.position - Vector2.up;
        if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
            dest = (Vector2)transform.position - Vector2.right;
        
        Vector2 dir = dest - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
        }
    }

    
}