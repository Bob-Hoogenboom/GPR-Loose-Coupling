using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Lesson5 gunCollection = new Lesson5();
    public void Start()
    {
        TestLesson5();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            gunCollection.Shoot("RPG");
            Debug.Log(gunCollection.GetAmmo("RPG"));
        }
    }

    void TestLesson5()
    {

        gunCollection.AddItem("RPG", 200);
        gunCollection.AddItem("Sling Shot", 10);
        gunCollection.AddItem("Dessert Eagle", 6);
        gunCollection.AddItem("Revolver", 6);

        //test
        var item = gunCollection.GetGun("RPG");
        Debug.Log(gunCollection.GetAmmo("RPG"));
        Debug.Log(item);
    }

}
