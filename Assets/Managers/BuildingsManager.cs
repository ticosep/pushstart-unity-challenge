using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsManager : MonoBehaviour
{
   
   public void changeCurrentBuilding (GameObject type) {
      GameManager.changeBuilding(type);
   }    
}
