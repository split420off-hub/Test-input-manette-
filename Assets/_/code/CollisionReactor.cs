using UnityEngine;
using UnityEngine.Events;

public class CollisionReactor : MonoBehaviour
{
    
    public UnityEvent _OnCollisionEnter;
    public UnityEvent _OnCollisionStay;
    public UnityEvent _OnCollisionExit;

    public void OnCollisionEnter(Collision collision)
    {
        _OnCollisionEnter.Invoke();
        Debug.Log("Booom");
    }

    public void OnCollisionStay(Collision collision)
    {
        _OnCollisionStay.Invoke();
    }

    public void OnCollisionExit(Collision collision)
    {
        _OnCollisionExit.Invoke();
    }
}
