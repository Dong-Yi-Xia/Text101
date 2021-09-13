using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CreateAssetMenu will create a new menu in assest create, for this public class as a ScriptableObject
[CreateAssetMenu(menuName = "StateFlow")]
public class State : ScriptableObject
{
  //create a text area field, field in unity, type, variable name
  [TextArea(10, 14)] [SerializeField] string storyText;

  public string GetStateStory()
  {
    return storyText;
  }

}
