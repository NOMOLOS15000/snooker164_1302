using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private float waitSecound = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waitSecound > 0f)
            waitSecound  -= Time.deltaTime;
        else
            StartCoroutine(LoadNewScene());

    }

    private IEnumerator LoadNewScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync("Scene01");
        while(!oper.isDone)
        {
            slider.value = oper.progress / 0.9f;
            yield return new WaitForSeconds(2f);
        }
    }


}
