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
        createTank();
    }

    private void createTank()
    {
        TankModel tankModel = new TankModel(tanks[2].movementSpeed, tanks[2].rotationSpeed, tanks[2].tankType, tanks[2].tankMaterial);
        TankController tankController = new TankController(tankModel, tankView);
    }    
}
