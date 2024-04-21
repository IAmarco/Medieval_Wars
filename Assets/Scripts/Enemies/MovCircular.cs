using UnityEngine;

namespace Enemies
{
    

public class MovCircular : MonoBehaviour
{
    
       public float velocidad = 2f;
       public float movVal;
    

    // Update is called once per frame
    private void Update()
    {
        movVal += Time.deltaTime * velocidad;
        float x = Mathf.Sin(movVal);
        float y = Mathf.Cos(movVal);

        
        transform.position = new Vector3(x+7.1f , y+6, 0);
    }
}
}