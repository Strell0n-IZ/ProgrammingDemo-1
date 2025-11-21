using Unity.VisualScripting;
using UnityEngine;

public interface IInteractable
{
    public void SwapInteract();
}


public class Interaction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform InteractorSource; 
    public float Range;


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(InteractorSource.position, transform.TransformDirection(Vector3.forward), out hit, Range))
            {
                if (hit.collider.TryGetComponent<LeverScript>(out LeverScript lever))
                {
                    lever.SwapLeverState();
                }
            }

            /*Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, Range))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)) 
                {
                    interactObj.SwapInteract();
                }
            }*/
        }
    }
}