using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrepareGame : MonoBehaviour
{
    [SerializeField] private GameControllerScript gameController;
    [SerializeField] private GameObject backgroundred;
    [SerializeField] private ParticleSystem particles;

    public float timeLeft;

    private void OnEnable()
    {
        particles.Stop();
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {
            if (SceneManager.GetActiveScene().name == "MainScene")
            {
                LogUtil.SendLog(StatusEnum.N�oConcluiu);
                Debug.Log("N�o concluiu");
            }
            SceneManager.LoadScene("MainScene");
        }
    }

    public void OnMouseDown()
    {
        backgroundred.SetActive(false);
        gameController.StartGame();
    }

}
