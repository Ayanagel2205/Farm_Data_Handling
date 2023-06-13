using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPen : MonoBehaviour
{

    [SerializeField] GameObject myAnimal;
    [SerializeField] AnimalBasics aniStats;

    
    
    private float attentionP;
    private float cleanlinessP;
    private float energyP;
    private float hungerP;



    private float Attention_Max = 5;
    private float Cleanliness_Max = 10;
    private float Energy_Max = 35;


    private float Hunger_Max = 25;
    private float Booster_Max = 25;



    // Start is called before the first frame update
    void Start()
    {
        penAtten();
        penClean();
        penEnergy();
        penHunger();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        




    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PenKeeper") ) {

            InvokeRepeating("addToAttention",2f,2f);
            
            
        
        }


        if (collision.tag.Equals("FarmVolunteer"))
        {

            InvokeRepeating("addToCleanliness", 2f, 2f);

        }

        if (collision.tag.Equals("Herder"))
        {
            InvokeRepeating("addToEnergy", 2f, 2f);

        }
        if (collision.tag.Equals("Feeder"))
        {

            InvokeRepeating("subtractHunger", 2f, 2f);

        }

    }





    public void addToAttention()
    {
        if(aniStats.getAttention() < aniStats.getMaxAtten())
        {
 
            float addAtten;

      
            addAtten= aniStats.getAttention() + 2;
            aniStats.setAttention(addAtten);



        }


       




    }


    public void addToCleanliness()
    {

        if (aniStats.getCleanliness() < aniStats.getMaxClean())
        {
            float addClean;

        addClean = aniStats.getCleanliness() + 2;
        aniStats.setClean(addClean);


        }

    }


    public void addToEnergy()
    {

        if (aniStats.getEnergy() < aniStats.getMaxEnergy() )
        {
 
            float addEnergy;

        addEnergy = aniStats.getEnergy() + 2;
        aniStats.setEnergy(addEnergy);


        }


    }



    public void subtractHunger()
    {

        if (aniStats.getHunger() <= aniStats.getHunger())
        {
            
        float subHunger;


        subHunger = aniStats.getHunger() - 2;
        aniStats.setHunger(subHunger);




        }

    }



    public void penAtten()
    {
        float penAtt;
        penAtt = aniStats.getAttention() - 0.1f;
        aniStats.setAttention(penAtt);

    }

    public void penClean()
    {
        float penCleanli;
        penCleanli = aniStats.getCleanliness() - 0.5f;
        aniStats.setClean(penCleanli);


    }

    public void penEnergy()
    {
        float penEn;
        penEn = aniStats.getEnergy() - 2f;
        aniStats.setEnergy(penEn);


    }

    public void penHunger()
    {
        float penHung;
        penHung = aniStats.getHunger() + 3f;
        aniStats.setHunger(penHung);


    }




}
