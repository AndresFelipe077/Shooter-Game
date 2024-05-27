using Photon.Pun;
using UnityEngine;

public class Launcher : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;

    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
        OnJoinedRoom();
    }

    /*public override void OnConnectedToMaster()
    {
        Debug.Log("Connect to master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }*/

    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);
    }

}
