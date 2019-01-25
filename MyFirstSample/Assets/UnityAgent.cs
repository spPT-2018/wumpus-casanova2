using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAgent : MonoBehaviour
{
  public Vector3 Position
  {
    get { return gameObject.transform.position; }
    set { gameObject.transform.position = value; }
  }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
      public static UnityAgent Instantiate()
      {
        var _object = GameObject.Instantiate(Resources.Load("Wum/Prefabs/CnvAgent"), 
                                             new Vector3(0,1.35f,0), 
                                             Quaternion.identity) as GameObject;
        var cube = _object.GetComponent<UnityAgent>();
        return cube;
      }
}
                                                                                                                                                                                                                                                               