using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLauncher : MonoBehaviourPunCallbacks
{
    public TMP_InputField usernameInput;

    public TMP_Text buttonText;

    public void OnClickConnect()
    {
        if (usernameInput.text.Length >= 1)
        {
            PhotonNetwork.NickName = usernameInput.text;

            PlayerPrefs.SetString("PlayerName", usernameInput.text);

            buttonText.text = "Loading...";
            PhotonNetwork.ConnectUsingSettings();

            Debug.Log(usernameInput.text);
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("To new scene");
        SceneManager.LoadScene("Playground");
    }

}
