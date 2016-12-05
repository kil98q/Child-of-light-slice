using UnityEngine;
using System.Collections;

public class InfiniteScroll : MonoBehaviour {
    public GameObject Player;
    public Renderer rend;
    public Camera Cam;
    public bool Manual;
    public float scrollSpeed;
	void Start () {
        //transform.localScale = new Vector3(Cam / 2 * (Screen.width / Screen.height), cam.orthographicSize / 2, 0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (!Manual)
        {
            scrollSpeed = Player.GetComponent<Rigidbody2D>().velocity.x / 100 * Time.timeScale;
        }
        
        rend.material.mainTextureOffset = new Vector2(rend.material.mainTextureOffset.x + (scrollSpeed * Time.fixedDeltaTime),0);
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y,transform.position.z);
	}
}
