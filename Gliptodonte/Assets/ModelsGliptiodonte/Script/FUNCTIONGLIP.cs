 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class FUNCTIONGLIP : MonoBehaviour
{
    public GameObject target;
    public Animator ani;
    public bool  _target;
    private Renderer rend;
    private void Update()
    {
        if (target == null) { _target = false; return; }
        else { _target = true; }
        
    }
    public void Rotate()
    {
        if (_target)
        {
            target.transform.Rotate(-Vector3.up * 40f* Time.deltaTime);
        }
    }
    public void Walk() {
        if (_target)
        {
            print(ani.GetBool("Walk"));
            StartCoroutine(Walking());
        }
    }
    IEnumerator Walking() {
       
        ani.SetBool("Walk", true);
        print(ani.GetBool("Walk"));
        yield return new WaitForSeconds(15f);
        ani.SetBool("Walk", false);
    }
    public void Atack() {
        print("Atack");
        if (_target)
        {
            StartCoroutine(CaptureIt());
        }
}

    IEnumerator CaptureIt()
    {

        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string fileName = "Screenshot" + timeStamp + ".png";
        string pathToSave = fileName;
        rend.enabled = false;
        ScreenCapture.CaptureScreenshot(pathToSave);
        yield return new WaitForEndOfFrame();
        rend.enabled = true;
    }

}
