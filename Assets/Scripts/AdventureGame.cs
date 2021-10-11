using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
  //Create a field in Unity, type, variable name. Able to load file into these fields 
  [SerializeField] Text textComponent;
  [SerializeField] State startingState;

  //type State, then assign to a variable  
  State theCurrentState;

  // Start is called before the first frame update
  void Start()
  {
    //the theCurrentState will be the startingState state file loaded in Unity, state file will have the method of GetStateStory
    theCurrentState = startingState;
    textComponent.text = theCurrentState.GetStateStory();
  }

  // Update is called once per frame
  void Update()
  {
    ManageState();
  }

  private void ManageState()
  {
    // type State[] is replaced with var. since we know that GetNextStates() return an array
    var nextStates = theCurrentState.GetNextStates();
    for (int index = 0; index < nextStates.Length; index++)
    {
      if (Input.GetKeyDown(KeyCode.Alpha1 + index))
      {
        theCurrentState = nextStates[index];
      }
    }
    textComponent.text = theCurrentState.GetStateStory();
  }
}
