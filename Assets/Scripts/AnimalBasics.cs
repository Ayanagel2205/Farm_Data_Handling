using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimalBasics : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float attention;
    [SerializeField] private float cleanliness;
    [SerializeField] private float energy;
    [SerializeField] private float hunger;

    [SerializeField] private TMP_Text AttentionText;
    [SerializeField] private TMP_Text CleanlinessText;
    [SerializeField] private TMP_Text EnergyText;

    [SerializeField] private TMP_Text HungerText;

    [SerializeField] private TMP_Text healthText;

    // private float healthPoints;



    private float attention_Max = 5;
    private float cleanliness_Max = 10;
    private float energy_Max = 35;


    private float hunger_Max = 25;
    private float Booster_Max = 25;





    void Start()
    {
        // getHealthPoints(attention,cleanliness,energy,hunger);

        setHealthPoints(attention, cleanliness, energy, hunger);

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public float getAttention()
    {
        return attention;


    }

    public float getCleanliness()
    {
        return cleanliness;


    }

    public float getEnergy()
    {
        return energy;


    }

    public float getHunger()
    {
        return hunger;


    }

    public void setHealthPoints(float A, float C, float E, float H)
    {
        float healthPoints = (A + C + E) - H;
        healthText.text = $"{healthPoints}";

    }


    public float getMaxAtten()
    {
        return attention_Max;


    }

    public float getMaxClean()
    {

        return cleanliness_Max;


    }


    public float getMaxEnergy()
    {

        return energy_Max;

    }

    public float getMaxHunger()
    {

        return hunger_Max;

    }









    public void setAttention(float inAtten)
    {
        attention = inAtten;
        AttentionText.text = $"{attention}";

    }

    public void setClean(float inClean)
    {
        cleanliness = inClean;
        CleanlinessText.text = $"{cleanliness}";


    }

    public void setEnergy(float inEnergy)
    {
        energy = inEnergy;
        EnergyText.text = $"{energy}";


    }

    public void setHunger(float inHunger)
    {
        hunger = inHunger;
        HungerText.text = $"{hunger}";


    }

    /*public void setHealth()
    {
        float health = attention + cleanliness + energy - hunger;
        healthText.text = $"{health}";

        
    }*/
   





}
