﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;        //Allows us to use Lists. 

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;                //Static instance of GameManager which allows it to be accessed by any other script.
    public static GameObject building;
    public static int money = 3000;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);


        //Call the InitGame function to initialize the first level 
        InitGame();
    }

    //Initializes the game for each level.
    void InitGame()
    {


    }



    //Update is called every frame.
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePos.z = 0;
        
         if (Input.GetMouseButtonDown(0)) {
          
         if(building) {
            Instantiate(building,mousePos,Quaternion.identity); 
            
         } else {
             Debug.Log("Not able to construt");
         }

         }
           

    }

    public void updateMoney(int value) {
        money += value;
    }

      public static void changeBuilding(GameObject nextBuilding) {
        building = nextBuilding;
    }


}