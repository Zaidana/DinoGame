using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    public float timer = 0;
    public TextMeshProUGUI textTimer;

    public static GameManager Instance {  get; private set; }   
    private void Awake()
    {
       if(Instance != null && Instance != this)
                {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        textTimer.text = string.Format("{0:00000}", timer);
    }

    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true); 
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("DinoGame");
    }
}
