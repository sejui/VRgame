#pragma strict



var pushPower = 2.0;
public var clip : AudioClip; 

function Start(){
	

}
function OnControllerColliderHit (hit: ControllerColliderHit){
	if(hit.gameObject.tag == "box"){
		var body : Rigidbody = hit.collider.attachedRigidbody;
		var m_audio: AudioSource = GetComponent.<AudioSource>();


		//if there's no rigidbody
		if(body == null || body.isKinematic) return;

		//we are not pushing items below us
		if(hit.moveDirection.y < -0.3) return;

		//Calculate push direction from move direction,
    	// we only push objects to the sides never up and down
		var pushDir : Vector3 = Vector3 (hit.moveDirection.x,0,hit.moveDirection.z);

		//apply push
		body.velocity = pushDir * pushPower;
		//apply sound effect
		if(!m_audio.isPlaying) m_audio.PlayOneShot(clip);

	}
	    if (hit.moveDirection.y > 0.01) return;
}