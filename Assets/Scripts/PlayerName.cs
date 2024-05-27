using Photon.Pun;
using TMPro;

public class PlayerName : MonoBehaviourPunCallbacks
{
    public TMP_Text playerName;

    [PunRPC]
    public void SetNameText(string name)
    {
        playerName.text = name;
    }

}
