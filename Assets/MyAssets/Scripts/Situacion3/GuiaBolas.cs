using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UIElements;

public class GuiaBolas : MonoBehaviour
{

	public GameObject[] objetivos;
	public float fuerza;
	public GameObject cambiaEscena;

	public float velocidadMinima;
	public float maximunAngle;
	private bool trampaActivada; //Indica que ya hay una corrutina ejecutándose

	//private void Start()
	//{
	//    StartCoroutine(Prueba());
	//}

	//public void OnCollisionEnter(Collision collision)
	//{
	//	//Debug.Log(collision.gameObject.name);
	//	if (collision.gameObject.name == "SledgeHammer")
	//	{
	//		GameObject objetivo = buscarObjetivoMasCercano();
	//		Debug.Log(objetivo.name);
	//		StartCoroutine(Guiar(objetivo));
	//		//StartCoroutine(Prueba());
	//	}
	//}

	private void Update()
	{
		if (GetComponent<Rigidbody>().velocity.sqrMagnitude > velocidadMinima && !trampaActivada)
		{
			trampaActivada = true;
			GameObject objetivo = buscarObjetivoMasCercano();
			StartCoroutine(Guiar(objetivo));
		}

		//if (!trampaActivada)
		//{
		//          GameObject objetivo = buscarObjetivoMasCercano();
		//          Vector3 direccion = new Vector3(objetivo.transform.position.x - transform.position.x, objetivo.transform.position.y - transform.position.y, objetivo.transform.position.z - transform.position.z);
		//          float angle = Vector3.Angle(GetComponent<Rigidbody>().velocity, direccion);
		//          Debug.Log(angle);
		//          if (angle < maximunAngle && angle > 0)
		//          {
		//              trampaActivada = true;
		//              StartCoroutine(Guiar(objetivo));
		//          }
		//      }

	}

	public GameObject buscarObjetivoMasCercano()
	{
		GameObject objetivo = null;
		float distanciaMinima = Mathf.Infinity;
		foreach (GameObject obj in objetivos)
		{
			if (obj.activeSelf == false) continue;
			Vector3 vector = new Vector3(obj.transform.position.x - transform.position.x, obj.transform.position.y - transform.position.y, obj.transform.position.z - transform.position.z);
			if (vector.magnitude < distanciaMinima)
			{
				distanciaMinima = vector.magnitude;
				objetivo = obj;
			}
		}
		return objetivo;
	}

	public IEnumerator Guiar(GameObject gameObject)
	{



		while (true)
		{
			yield return new WaitForFixedUpdate(); //Creo que con update no funciona porque hace cosas con físicas o algo así
			Debug.Log("Moviendeo");

			Vector3 direccion = new Vector3(gameObject.transform.position.x - transform.position.x, gameObject.transform.position.y - transform.position.y, gameObject.transform.position.z - transform.position.z);
			if (direccion.magnitude < 0.1)
			{
				trampaActivada = false;
				GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
				gameObject.SetActive(false);
				bool algunoActivo = false;
				foreach (GameObject obj in objetivos)
				{
					if (obj.activeSelf == true)
					{
						algunoActivo = true;
						break;
					}
				}
				if (!algunoActivo) 
				{
					cambiaEscena.GetComponent<CambiarEscena>().saltarEscena();
				}
				yield break;
			}
			direccion = direccion.normalized;
			this.gameObject.GetComponent<Rigidbody>().AddForce(direccion * fuerza * Time.fixedDeltaTime, ForceMode.Force);

		}
		
	}


}
