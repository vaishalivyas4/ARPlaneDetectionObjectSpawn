using System.Collections;
using UnityEngine;

public class Anim : MonoBehaviour
{
    private void Update()
    {
    }


    public void playAnimation()
    {
        Debug.Log("hy");
        GetComponent<Animation>().Play("Jump In Place");
        // StartCoroutine(delay());
        //  GetComponent<Animation>().Play("jumping");

        // GameObject obj = Instantiate(prefab) as GameObject;
        // anim = obj.GetComponent<Animation>();
    }

    private void Stand()
    {
        GetComponent<Animation>().Play("Jump In Place");
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(2.5f);
        // stand();
    }
}