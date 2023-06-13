using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerManager : MonoBehaviour
{

    private string attenW = "Pen Keeper";
    private string cleanW = "Farm Volunteer";
    private string energyW = "Header";

    private string hungerW = "Feeder";

    [SerializeField] private GameObject aniWorker;
    [SerializeField] private float workerValue;
    [SerializeField] private float worker;

    private float attenWValue = 0.1f;
    private float cleanWValue = 0.5f;
    private float energyWValue = 2f;

    private float hungerWValue = 3f;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addAttributeValue(int attri) {

        attri += 5;
    
    }




}
