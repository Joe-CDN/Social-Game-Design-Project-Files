using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject StartPos;
    public GameObject EndPos;
    
    bool approach = true;
    int randPotRequest = 0;
    float potionTotalRequested = 0f;
    float fraction = 0;
    public float speed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        RequestPotion();
    }

    // Update is called once per frame
    void Update()
    {
        if(approach == true){
            if (fraction < 1) {
                fraction += Time.deltaTime * speed;

                Vector3 interpolatedPosition = Vector3.Lerp(StartPos.transform.position, EndPos.transform.position, fraction);

                this.transform.position = interpolatedPosition;
            }
        }
        if(approach == false){
            if (fraction < 1) {
                fraction += Time.deltaTime * speed;
                
                Vector3 interpolatedPosition = Vector3.Lerp(EndPos.transform.position, StartPos.transform.position, fraction);

                this.transform.position = interpolatedPosition;

                if (fraction >= 1) {
                    approach = true;
                    RequestPotion();
                    this.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
                    fraction = 0;
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag.Equals("purePot")){
            if(potionTotalRequested == 27.77f){
                ResetNPC(collision);             
            }            
        }
        if (collision.collider.tag.Equals("goldPot")){
            if(potionTotalRequested == 23.26f){
                ResetNPC(collision);
            } 
        }
        if (collision.collider.tag.Equals("sadPot")){
            if(potionTotalRequested == 29.18f){
                ResetNPC(collision);
            }
        }
        if (collision.collider.tag.Equals("lovePot")){
            if(potionTotalRequested == 50.61f){
                ResetNPC(collision);
            }
        }
        if (collision.collider.tag.Equals("catFaePot")){
            if(potionTotalRequested == 30.21f){
                ResetNPC(collision);
            }
        }
        if (collision.collider.tag.Equals("timePot")){
            if(potionTotalRequested == 26.19f){
                ResetNPC(collision);
            }
        }
        if (collision.collider.tag.Equals("truthPot")){
            if(potionTotalRequested == 14.88f){
                ResetNPC(collision);
            }
        }
        if (collision.collider.tag.Equals("happyPot")){
            if(potionTotalRequested == 23.42f){
                ResetNPC(collision);
            }
        }
    }
    void ResetNPC(Collision collision)
    {
        Destroy(collision.gameObject);
        fraction = 0;
        approach = false;
        this.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        PersistanceManager.instance.score += 10;
    }
    void RequestPotion()
    {
        randPotRequest = Random.Range(0,3);

        if(randPotRequest == 0){
            potionTotalRequested = 27.77f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(0.6509434f, 0.6349769f, 0.6349769f);
        }
        if(randPotRequest == 1){
            potionTotalRequested = 23.26f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(1f, 0.8382407f, 0f);
        }
        if(randPotRequest == 2){
            potionTotalRequested = 29.18f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(0.1437f, 0.01331432f, 0.4150943f);
        }
        if(randPotRequest == 3){
            potionTotalRequested = 50.61f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(1f, 0f, 0.9095554f);
        }
        if(randPotRequest == 4){
            potionTotalRequested = 30.21f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(0f, 1f, 0.7181935f);
        }
        if(randPotRequest == 5){
            potionTotalRequested = 17.6f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(0f, 0.4150943f, 0.05119479f);
        }
        if(randPotRequest == 6){
            potionTotalRequested = 17.6f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(0f, 0.4150943f, 0.05119479f);
        }
        if(randPotRequest == 7){
            potionTotalRequested = 23.42f;
            this.GetComponentInChildren<MeshRenderer>().material.color = new Color(0f, 0.4665077f, 0f);
        }
    }
}
