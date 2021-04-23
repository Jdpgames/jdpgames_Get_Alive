using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public GameObject CorazonesPanel;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {   
            // si entra el player que es reconocido por su tag, reproduce sonido muerte,
            // apaga los corazones de la UI, y llama a levelManager para comunicar que esta muerto.

            sfx.instance.AudioJohnDead();
            CorazonesPanel.SetActive(false);
            LevelManager.Instance.PlayerDead();

            

        }

    }
}
