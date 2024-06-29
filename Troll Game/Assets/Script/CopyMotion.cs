using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{
    public Transform targetLimb;
    public ConfigurableJoint cj;
    public bool mirror;
    public bool thigh;

    // Start is called before the first frame update
    void Start()
    {
        cj = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!mirror)
        {
            cj.targetRotation = targetLimb.localRotation;
        }
        else
        {
            cj.targetRotation = Quaternion.Inverse(targetLimb.rotation);
        }
    }
}
