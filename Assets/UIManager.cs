using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void JalankanGameScene()
	{
		SceneManager.LoadScene ("Scene2");
	}

    public void JalankanGameScene2()
	{
		SceneManager.LoadScene ("aboutscene");
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
