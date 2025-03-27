using System.Collections;
using UnityEngine;

public class VHSTransitionYOutubeWithVHSPro : MonoBehaviour
{


    public postVHSPro VHSProScript;

    bool ChangedState = false;

    public AudioSource Source;

    public AudioClip Clip;

    public GameObject Player1;
    public GameObject Player2;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {



        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.T) && ChangedState == false)
        {


            ChangedState = true;

            // run the CO

            StartCoroutine(VHSEffectCO());

        }



    }



    IEnumerator VHSEffectCO()
    {



        Source.PlayOneShot(Clip);

        // do the trasition

        // bleed amount = 1
        // film grain = 0.016
        // signal adjustY = 1f

        VHSProScript.bleedAmount = 15;
        VHSProScript.filmGrainAmount = 0.1f;
        VHSProScript.signalShiftY = 2f;

        yield return new WaitForSeconds(0.05f);

        VHSProScript.bleedAmount = 1;
        VHSProScript.filmGrainAmount = 0.016f;
        VHSProScript.signalShiftY = 1f;

        yield return new WaitForSeconds(0.05f);

        VHSProScript.bleedAmount = 15;
        VHSProScript.filmGrainAmount = 0.1f;
        VHSProScript.signalShiftY = 2f;

        yield return new WaitForSeconds(0.05f);

        VHSProScript.bleedAmount = 1;
        VHSProScript.filmGrainAmount = 0.016f;
        VHSProScript.signalShiftY = 1f;

        yield return new WaitForSeconds(0.05f);

        VHSProScript.bleedAmount = 15;
        VHSProScript.filmGrainAmount = 0.1f;
        VHSProScript.signalShiftY = 2f;

        yield return new WaitForSeconds(0.05f);

        VHSProScript.bleedAmount = 1;
        VHSProScript.filmGrainAmount = 0.016f;
        VHSProScript.signalShiftY = 1f;

        yield return new WaitForSeconds(0.05f);

        VHSProScript.bleedAmount = 15;
        VHSProScript.filmGrainAmount = 0.1f;
        VHSProScript.signalShiftY = 2f;

        yield return new WaitForSeconds(0.05f);

        VHSProScript.bleedAmount = 1;
        VHSProScript.filmGrainAmount = 0.016f;
        VHSProScript.signalShiftY = 1f;


        // change the cameras


        Player1.SetActive(false);

        Player2.SetActive(true);


        // change the cameras



    }






}
