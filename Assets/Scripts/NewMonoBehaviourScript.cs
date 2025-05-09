using Unity.Cinemachine;
using UnityEngine;

public class CinemachineRotationSwitcher : MonoBehaviour
{
    private CinemachineCamera vcam;
   
    private CinemachineRotationComposer rotationComposer;
   
    public void Start()
    {
        vcam = GetComponent<CinemachineCamera>();     
      
       
        DisableAllRotationControls();
    }

    public void SwitchRotationMode(string mode)
    {
        DisableAllRotationControls();

        
    }

    public void DisableAllRotationControls()
    { 
        if (rotationComposer != null) rotationComposer.enabled = false;     
    }
}