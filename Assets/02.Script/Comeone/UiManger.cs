using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �� ���� ��� ���
using UnityEngine.SceneManagement;

public class UiManger : MonoBehaviour
{
   
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayScene");
    }
    public void QuitGame()
    {
#if UNITY_EDITOR //  ��ó���� : �������� �̸� ����� ������ �ִ�.
    UnityEditor.EditorApplication.isPlaying = false;
        // ����Ƽ���� ������ �� �� �¿� ����
#else //  ���忡������
        Application.Quit();
#endif
    }

}
