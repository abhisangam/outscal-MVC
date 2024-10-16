using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    [SerializeField] private Rigidbody tankRigidbody;
    private float movement;
    private float rotation;

    private MeshRenderer[] childrenMeshRenderers;
    [SerializeField] private BulletController bulletController;
    private Transform bulletLauncherTransform;
    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
    void Start()
    {
        tankRigidbody = GetComponent<Rigidbody>();

        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform, false);
        cam.transform.position = new Vector3(0f, 3f, -4f);

        bulletLauncherTransform = gameObject.transform.Find("BulletLauncher");
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");

        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }

        if(rotation != 0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
        }

        if(Input.GetMouseButtonDown(0))
        {
            fireShell();
        }
    }

    public Rigidbody GetRigidbody()
    {
        return tankRigidbody;
    }

    public void ChangeColor(Material material)
    {
        if(childrenMeshRenderers == null)
        {
            childrenMeshRenderers = GetComponentsInChildren<MeshRenderer>();
        }

        foreach (MeshRenderer renderer in childrenMeshRenderers)
        {
            renderer.material = material;
        }
    }

    private void fireShell()
    {
        GameObject.Instantiate(bulletController, bulletLauncherTransform.position, bulletLauncherTransform.rotation)
            .SetInitialVelocity(bulletLauncherTransform.forward * 40);
    }
}
