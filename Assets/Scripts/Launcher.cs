using Photon.Pun;
using UnityEngine;

public class Launcher : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab; // Cambiado a GameObject para mayor flexibilidad
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Joining random or creating a room");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined to room in function");

        if (playerPrefab != null)
        {
            GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);
            Debug.Log(player);

            // Asegurarse de que el RPC y el nombre del jugador estén configurados correctamente
            player.GetComponent<PhotonView>().RPC("SetNameText", RpcTarget.AllBuffered, PlayerPrefs.GetString("PlayerName", "Player"));
        }
        else
        {
            Debug.LogError("Player prefab is not assigned in the Inspector");
        }
    }

}
