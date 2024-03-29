using System.Collections;
using UnityEngine;


    public class Seed : MonoBehaviour
    {
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(true);
        }
    }

}
