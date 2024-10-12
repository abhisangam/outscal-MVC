using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankType type;
    public Material tankMaterial;

    public TankModel(float movementSpeed, float rotationSpeed, TankType type, Material material)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        this.type = type;
        this.tankMaterial = material;
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}
