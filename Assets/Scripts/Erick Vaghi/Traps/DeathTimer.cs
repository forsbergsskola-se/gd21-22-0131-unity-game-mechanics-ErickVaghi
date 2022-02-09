using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTimer : MonoBehaviour
{
    [SerializeField] private float deathTimeCounter;
    [SerializeField] private float deathTime = 10f;
    [SerializeField] private GameObject player;

    private void Start()
    {
        deathTimeCounter = deathTime;
    }

    public void Update()
    {
        Destroy(player);
        deathTimeCounter -= Time.deltaTime;
        if (deathTimeCounter < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
