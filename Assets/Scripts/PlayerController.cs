using UnityEngine;
using UnityEngine.SceneManagement;
using Articy.Unity;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float rotationSpeed = 1f; // Speed of camera rotation
    private float jumpForce = 3.5f;
    private bool isGrounded = true; // Check if the player is on the ground
    private bool canJump = true; // Check if the player can jump

    private Rigidbody playerRB;
    private DialogueManager dialogueManager;
    private ArticyObject availableDialogue;
    private Camera mainCamera;

    // Variables to limit vertical camera rotation
    private float verticalRotation = 0f;
    private float maxVerticalAngle = 100f;

    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody>();
        dialogueManager = FindObjectOfType<DialogueManager>();
        mainCamera = Camera.main; // Get the main camera
    }

    void Update()
    {
        PlayerInteraction();
        RotateCamera(); // Call the method to rotate the camera
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && canJump)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    // Simple player movement
    void PlayerMovement()
    {
        // Remove movement control while in dialogue
        if (dialogueManager.DialogueActive)
            return;

        // Get input direction relative to camera
        Vector3 inputDirection = GetInputDirection();

        // Move the player in the input direction
        playerRB.velocity = new Vector3(inputDirection.x * speed, playerRB.velocity.y, inputDirection.z * speed);
    }

    // Rotate the camera based on player input
    void RotateCamera()
    {
        if (!dialogueManager.DialogueActive)
        {
            float horizontalInput = Input.GetAxis("Mouse X"); // Get mouse input for horizontal rotation

            // Rotate the player horizontally
            transform.Rotate(Vector3.up * horizontalInput * rotationSpeed);

            // Rotate the camera vertically
            float verticalInput = Input.GetAxis("Mouse Y"); // Get mouse input for vertical rotation
            verticalRotation -= verticalInput * rotationSpeed; // Invert the input for natural feel
            verticalRotation = Mathf.Clamp(verticalRotation, -maxVerticalAngle, maxVerticalAngle);

            // Apply vertical rotation to the camera
            mainCamera.transform.localEulerAngles = new Vector3(verticalRotation, 0f, 0f);
        }
    }

    // Get input direction relative to camera rotation
    Vector3 GetInputDirection()
    {
        // Get camera forward direction without vertical component
        Vector3 cameraForward = mainCamera.transform.forward;
        cameraForward.y = 0f;
        cameraForward = cameraForward.normalized;

        // Get camera right direction without vertical component
        Vector3 cameraRight = mainCamera.transform.right;
        cameraRight.y = 0f;
        cameraRight = cameraRight.normalized;

        // Get input direction based on horizontal and vertical input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDirection = (cameraForward * verticalInput) + (cameraRight * horizontalInput);

        // Normalize the input direction to ensure consistent speed in all directions
        if (inputDirection.magnitude > 1f)
            inputDirection.Normalize();

        return inputDirection;
    }

    // Jump function
    void Jump()
    {
        playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false; // Player is now in the air
        canJump = false; // Prevent double jumping
    }

    // All interactions and key inputs player can use
    void PlayerInteraction()
    {
        // Key option to start dialogue when near NPC
        if (Input.GetKeyDown(KeyCode.E) && availableDialogue)
        {
            dialogueManager.StartDialogue(availableDialogue);
        }

        // Key option to abort dialogue
        if (dialogueManager.DialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            dialogueManager.CloseDialogueBox();
        }

        // Key option to reset entire scene
        if (Input.GetKeyDown(KeyCode.L))
        {
            RestartScene();
        }
    }

    // Simple scene restart for testing purposes
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Trigger Enter/Exit used to determine if interaction with NPC is possible
    void OnTriggerEnter(Collider aOther)
    {
        var articyReferenceComp = aOther.GetComponent<ArticyReference>();
        if (articyReferenceComp)
        {
            availableDialogue = articyReferenceComp.reference.GetObject();
        }

    }

    void OnTriggerExit(Collider aOther)
    {
        if (aOther.GetComponent<ArticyReference>() != null)
        {
            availableDialogue = null;
        }
    }

    // Check if player is grounded
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Player is grounded
            canJump = true; // Reset double jump prevention
        }
    }
}
