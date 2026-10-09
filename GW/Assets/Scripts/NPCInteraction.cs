using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;

    private bool isDialogueOpen;
    private PlayerMovement currentPlayer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();

            if (player != null)
            {
                currentPlayer = player;
                player.SetCurrentNPC(this);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();

            if (player != null)
            {
                player.ClearCurrentNPC();
                currentPlayer = null;
            }
        }
    }

    public void Interact()
    {
        isDialogueOpen = !isDialogueOpen;
        dialoguePanel.SetActive(isDialogueOpen);

        if (currentPlayer != null)
        {
            currentPlayer.SetCanMove(!isDialogueOpen);
        }
    }
}