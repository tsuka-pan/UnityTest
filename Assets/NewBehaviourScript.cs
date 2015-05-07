using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float speed; //必ずインスペクタにでてくる．
	public GameObject goalText; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed); //Time.deltaTime = 前のフレームからの差分
		//transform.Translate (Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * speed); //Time.deltaTime = 前のフレームからの差分
		transform.position += new Vector3 (Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 
		                                   Input.GetAxis("Vertical") * Time.deltaTime * speed);

		if(Input.GetKeyDown (KeyCode.Space)){
			rigidbody.AddForce (Vector3.up * 300);
		}
	}


	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "Medal") {
			Debug.Log ("Goal!");
			goalText.SetActive(true);
		}
	}
}
