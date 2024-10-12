using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankType tankType;
        public Material tankMaterial;
    }

    public TankView tankView;
    public List<Tank> tanks;

    void Start()
    {

    }

    public void CreateTank(TankType tankType)
    {

        if(tankType == TankType.GreenTank)
        {
            TankModel tankModel = new TankModel(tanks[0].movementSpeed, tanks[0].rotationSpeed, tanks[0].tankType, tanks[0].tankMaterial);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankType == TankType.RedTank)
        {
            TankModel tankModel = new TankModel(tanks[2].movementSpeed, tanks[2].rotationSpeed, tanks[2].tankType, tanks[2].tankMaterial);
            TankController tankController = new TankController(tankModel, tankView);
        }
        else if(tankType == TankType.BlueTank)
        {
            TankModel tankModel = new TankModel(tanks[1].movementSpeed, tanks[1].rotationSpeed, tanks[1].tankType, tanks[1].tankMaterial);
            TankController tankController = new TankController(tankModel, tankView);
        }        
    }    
}
