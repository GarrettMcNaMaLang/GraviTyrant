using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private InputActionAsset playerControls;

    [SerializeField] private string actionMapName = "PlayerMovement";

    [SerializeField] private string movement = "WASD3DMovement";
    private Rigidbody rb;

    CinemachineCamera camera;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        camera = GetComponentInChildren<CinemachineCamera>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
