using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class zombieScript2 : MonoBehaviour
{
    //declare the transform of our goal (where the navmesh agent will move towards) and our navmesh agent (in this case our zombie)
    //public int score;
    public Transform goal;
    public NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {

        //create references
        goal = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        //set the navmesh agent's desination equal to the main camera's position (our first person character)
        agent.destination = goal.position;
        //start the walking animation
        GetComponent<Animation>().Play("walk");



    }


    //for this to work both need colliders, one must have rigid body, and the zombie must have is trigger checked.
    void OnTriggerEnter(Collider col)
    {

        //first disable the zombie's collider so multiple collisions cannot occur
        GetComponent<CapsuleCollider>().enabled = false;
        //destroy the bullet
        Destroy(col.gameObject);
        //stop the zombie from moving forward by setting its destination to it's current position
        agent.destination = gameObject.transform.position;
        //stop the walking animation and play the falling back animation
        GetComponent<Animation>().Stop();
        GetComponent<Animation>().Play("fallingback");


        //destroy this zombie in six seconds.
        Destroy(gameObject, 1);
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 1)
        {
            SceneManager.LoadScene("GameOver");
        }

        //
        //instantiate a new zombie
        //  GameObject zombie = Instantiate(Resources.Load("zombie", typeof(GameObject))) as GameObject;



        //set the coordinates for a new vector 3
        //float randomX = UnityEngine.Random.Range(-12f, 12f);
        //float constantY = .01f;
        //float randomZ = UnityEngine.Random.Range(-13f, 13f);
        //set the zombies position equal to these new coordinates
        //zombie.transform.position = new Vector3(randomX, constantY, randomZ);

        //if the zombie gets positioned less than or equal to 3 scene units away from the camera we won't be able to shoot it
        //so keep repositioning the zombie until it is greater than 3 scene units away. 
        /*if (Vector3.Distance(gameObject.transform.position, Camera.main.transform.position) < 4)
        {

        SceneManager.LoadScene("GameOver");
        }*/

    }

}

