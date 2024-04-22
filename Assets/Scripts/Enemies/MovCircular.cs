using UnityEngine;

namespace Enemies
{
    

public class MovCircular : MonoBehaviour
{
    
       public float velocidad = 2f;
       public float movVal;
       public bool scriptHabilitado = true;
       
    

    // Update is called once per frame
    private void Update()
    {
        if (scriptHabilitado)
        {
         movVal += Time.deltaTime * velocidad;
         float x = Mathf.Sin(movVal);
         float y = Mathf.Cos(movVal);

        
         transform.position = new Vector3(0.8f*(x+7.1f) , 0.8f*(y+7), 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            scriptHabilitado = false;
        }
    }

}

}