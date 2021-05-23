using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovieController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CargarMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CargarMenu()
    {
        yield
        return new WaitForSeconds(69.5f);

        SceneManager.LoadScene("MainMenu");

    }




}
