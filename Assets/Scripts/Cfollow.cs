using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cfollow : MonoBehaviour
{

  public GameObject runner;
  public Vector3 offset;

  void Start(){
  	offset = transform.position - runner.transform.position;
  }
  private void LateUpdate(){
  	transform.position = runner.transform.position + offset;
  }
}
