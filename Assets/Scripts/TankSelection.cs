using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    public void OnBlueTankSelected()
    {
        tankSpawner.CreateTank(TankType.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void OnRedTankSelected()
    {
        tankSpawner.CreateTank(TankType.RedTank);
        this.gameObject.SetActive(false);
    }

    public void OnGreenTankSelected()
    {
        tankSpawner.CreateTank(TankType.GreenTank);
        this.gameObject.SetActive(false);
    }
}
