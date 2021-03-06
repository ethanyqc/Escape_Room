﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe2 : MonoBehaviour
{
    public string code = "201212";
    private string input = "";
    private int len = 6;
    private Animator animator;
    //GameObject object;
    public UnityEngine.UI.Text Text;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button0;

    private AudioSource beep;

    void Start()
    {
        animator = GetComponent<Animator>();
        beep = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void OnMouseOver()
    {
        if (Input.GetKeyDown("1"))
        {
            beep.Play();
            input = input + "1";
            button1.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co1());
        }
        if (Input.GetKeyDown("2"))
        {
            beep.Play();
            input = input + "2";
            button2.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co2());
        }

        if (Input.GetKeyDown("3"))
        {
            beep.Play();
            input = input + "3";
            button3.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co3());
        }
        if (Input.GetKeyDown("4"))
        {
            beep.Play();
            input = input + "4";
            //GetComponent.<AudioSource>().PlayOneShot(myClip);
            button4.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co4());
        }
        if (Input.GetKeyDown("5"))
        {
            beep.Play();
            input = input + "5";
            button5.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co5());
        }
        if (Input.GetKeyDown("6"))
        {
            beep.Play();
            input = input + "6";
            button6.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co6());
        }
        if (Input.GetKeyDown("7"))
        {
            beep.Play();
            input = input + "7";
            button7.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co7());
        }
        if (Input.GetKeyDown("8"))
        {
            beep.Play();
            input = input + "8";
            button8.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co8());
        }
        if (Input.GetKeyDown("9"))
        {
            beep.Play();
            input = input + "9";
            button9.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co9());
        }
        if (Input.GetKeyDown("0"))
        {
            beep.Play();
            input = input + "0";
            button0.GetComponent<Renderer>().material.color = Color.red;
            StartCoroutine(co0());
        }

    }

    void FixedUpdate()
    {
        if (input == code)
        {
            //object.SetActive(true);
            Text.color = Color.green;
            StartCoroutine(open());
        }
        if (input.Length > len)
        {
            input = "";
        }
        Text.text = input;
    }


    IEnumerator co1()
    {
        yield return new WaitForSeconds(0.1f);
        button1.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co2()
    {
        yield return new WaitForSeconds(0.1f);
        button2.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co3()
    {
        yield return new WaitForSeconds(0.1f);
        button3.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co4()
    {
        yield return new WaitForSeconds(0.1f);
        button4.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co5()
    {
        yield return new WaitForSeconds(0.1f);
        button5.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co6()
    {
        yield return new WaitForSeconds(0.1f);
        button6.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co7()
    {
        yield return new WaitForSeconds(0.1f);
        button7.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co8()
    {
        yield return new WaitForSeconds(0.1f);
        button8.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co9()
    {
        yield return new WaitForSeconds(0.1f);
        button9.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator co0()
    {
        yield return new WaitForSeconds(0.1f);
        button0.GetComponent<Renderer>().material.color = Color.white;
    }
    IEnumerator open()
    {
        //Debug.Log("HANDLE open");
        yield return new WaitForSeconds(0.2f);
        Destroy(Text);
        animator.SetTrigger("doorCode_open");
    }



}
