using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones : MonoBehaviour {

    public Animator Dividir;
    public Animator Multiplicar;
    public Animator Suma;
    public Animator Resta;


    public Button Di;
    public Button Mu;
    public Button Su;
    public Button Re;

    public SceneChanger sceneChanger;
    // Use this for initialization
    void Start () {
        Button B_1 = Di.GetComponent<Button>();
        B_1.onClick.AddListener(TaskOnDi);
        Button B_2 = Mu.GetComponent<Button>();
        B_2.onClick.AddListener(TaskOnMu);
        Button B_3 = Su.GetComponent<Button>();
        B_3.onClick.AddListener(TaskOnSu);
        Button B_4 = Re.GetComponent<Button>();
        B_4.onClick.AddListener(TaskOnRe);
    }
	
    public void TaskOnDi()
    {
        Dividir.SetTrigger("Dividir");
        StartCoroutine(DividirCo());
    }

    public void TaskOnMu()
    {
        Multiplicar.SetTrigger("Multiplicar");
        StartCoroutine(MultiplicarCo());
    }

    public void TaskOnSu()
    {
        Suma.SetTrigger("Suma");
        StartCoroutine(SumaCo());
    }

    public void TaskOnRe()
    {
        Resta.SetTrigger("Resta");
        StartCoroutine(RestaCo());
    }

    IEnumerator DividirCo()
    {
        yield return new WaitForSeconds(1);
        sceneChanger.ChangeSceneTo("DividirScene");
    }

    IEnumerator MultiplicarCo()
    {
        yield return new WaitForSeconds(1);
        sceneChanger.ChangeSceneTo("MultiplicarScene");
    }

    IEnumerator SumaCo()
    {
        yield return new WaitForSeconds(1);
        sceneChanger.ChangeSceneTo("SumaScene");
    }

    IEnumerator RestaCo()
    {
        yield return new WaitForSeconds(1);
        sceneChanger.ChangeSceneTo("RestaScene");
    }
}
