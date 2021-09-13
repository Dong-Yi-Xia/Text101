using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
  //Create a field in Unity, type, variable name. Able to load file into these fields 
  [SerializeField] Text textComponent;
  [SerializeField] State startingState;

  //call the public class State, then assign to a variable  
  State theCurrentState;

  // Start is called before the first frame update
  void Start()
  {
    //the theCurrentState will be the startingStateFool state file loaded in Unity
    theCurrentState = startingState;
    textComponent.text = theCurrentState.GetStateStory();
  }

  // Update is called once per frame
  void Update()
  {

  }
}
