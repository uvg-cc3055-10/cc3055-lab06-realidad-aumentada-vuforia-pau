using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
/*Paul Belches 17088
 Rodrigo Morales 17027
 Laboratorio 6
 9/05/18*/
public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler 
{
    private VirtualButtonBehaviour virtualBtn;
    public Animator birdAnim;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //Metodo para poner el sonido
        birdAnim.SetTrigger("sing");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       
    }

    // Use this for initialization
    void Start () {
        //Metodo para obtener el boton
        virtualBtn = GetComponent<VirtualButtonBehaviour>();
        virtualBtn.RegisterEventHandler(this);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
