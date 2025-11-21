using UnityEngine;
 
public class LeverScript : MonoBehaviour
{
    [SerializeField] private bool isLeverTrue;
 
    [Header("Lever"),SerializeField] private Transform leverTransform;
 
    [SerializeField] Vector3 leverTrueRotation,
                                leverFalseRotation;
    private Quaternion leverTargetRotation;
 
    [SerializeField] private float leverLerpSpeed;
 
 
    [Header("Gate"), SerializeField] private Transform gateTransform;
 
    [SerializeField] Vector3 gateTruePosition,
                                gateFalsePosition;
    private Vector3 gateTargetPosition;
 
    [SerializeField] private float gateLerpSpeed;
 
    void Start()
    {
        SetLeverState(true); // Here, we are setting the default state of the lever
    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            SwapLeverState();
        }
 
        leverTransform.localRotation = Quaternion.Slerp(leverTransform.localRotation, leverTargetRotation, leverLerpSpeed * Time.deltaTime);
        gateTransform.localPosition = Vector3.Lerp(gateTransform.localPosition, gateTargetPosition, gateLerpSpeed * Time.deltaTime);
    }
 
    public void SetLeverState(bool leverState)
    {
        if (leverState)
        {
            leverTargetRotation.eulerAngles = leverTrueRotation;
            gateTargetPosition = gateTruePosition;
        }
        else
        {
            leverTargetRotation.eulerAngles = leverFalseRotation;
            gateTargetPosition = gateFalsePosition;
        }
    }
 
    public void SwapLeverState()
    {
        isLeverTrue = !isLeverTrue;
 
        SetLeverState(isLeverTrue);
    }
}
 
 