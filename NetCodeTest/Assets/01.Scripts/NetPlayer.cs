using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetPlayer : NetworkBehaviour {
    private void Update(){
        
        if(!IsOwner) return;

        Vector3 movedir = new Vector3(0, 0, 0);

        if(Input.GetKey(KeyCode.W)) movedir.z = +1f;
        if(Input.GetKey(KeyCode.S)) movedir.z = -1f;
        if(Input.GetKey(KeyCode.A)) movedir.x = -1f;
        if(Input.GetKey(KeyCode.D)) movedir.x = +1f;

        float moveSpeed = 3f;
        transform.position += movedir * moveSpeed * Time.deltaTime;
    }
}
