﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//para poder usar la Interfaz Usuario necesitas declarar la UI en el UnityEngine
// Introducción a este código.

//Esta hecho para que al momento de colisionar se desactive un checkpoint y 
//se sume un nivel para tener de referencia la dificultad del juego.
public class CodeUI : MonoBehaviour {
	//Como estamos en el level 1, entonces tenemos que hacer la cuenta desde el 1	
	public static int LevelQuantity = 0;
	//tenemos que poner de referencia el Texto, porque convertiremos un número 
	//a text.
	Text LevelText;

	// Use this for initialization
	void Start () {
		//Las cosas en el Start se activan o referencian al momento de iniciar
		//el juego. En este caso referenciamos desde inicia la cuenta
		LevelQuantity = 0;
		//Tenemos que especificar cual será el objeto a modificar. En este caso
		//hacemos que busque el "LevelQuantityText, el cual recuperará el 
		//componente texto y a todo esto lo llamaremos LevelText.
        LevelText = GameObject.Find("LevelQuantityText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Queremos que haga acciones al momento de colisionar, por lo que declaramos
	// void OnTriggerEnter, recuerda que todo es 3D, no mezcles 2D y 3D, después
	// declaramos el tipo de acción y al final el nombre de que le pondremos
	// a nuestra coalision
	void OnTriggerEnter(Collider LevelCheck)
	{	
		//Tiene que comparar un tag o una etiqueta, la cual nombraremos 
		//"CheckPoint", al compararla y hacer coalisión, se activará el 
		//siguiente código.
		if(LevelCheck.tag == "Player")
		{	
			//Desactivaremos el objeto
			gameObject.SetActive(false);
			//Hacemos que la suma que llevaba el contador sume + 1;
			LevelQuantity++;
			//convertimos el número dentro del código a un string, el cual va a
			//ser mostrado en una pantalla de la UI como "palabra".
			LevelText.text = LevelQuantity.ToString();
		}
	}
}