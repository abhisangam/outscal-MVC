using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody tankRigidbody;

    public TankController(TankModel tankModel, TankView tankView)
    {
        this.tankModel = tankModel;
        this.tankView = GameObject.Instantiate<TankView>(tankView);
        tankRigidbody = this.tankView.GetRigidbody();

        this.tankModel.SetTankController(this);
        this.tankView.SetTankController(this);

        this.tankView.ChangeColor(tankModel.tankMaterial);
    }

    public void Move(float movement, float speed)
    {
        tankRigidbody.velocity = tankView.transform.forward * movement * speed;
    }

    public void Rotate(float rotation, float speed)
    {
        Vector3 rotationVector = new Vector3(0f, rotation * speed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(rotationVector * Time.deltaTime);
        tankRigidbody.MoveRotation(tankRigidbody.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
