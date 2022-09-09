using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class PlayerListing : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform _content;
    [SerializeField]
    private PlayerListingSetting _playerListing;
    //[SerializeField]
    //private Text _readyUpText=null;

    private List<PlayerListingSetting> _listings = new List<PlayerListingSetting>();
    private RoomsCanvases _roomsCanvases;
    private bool _ready = false;

    private void Awake()
    {
        
    }

    public override void OnLeftRoom()
    {
        for (int i = 0; i < _listings.Count; i++)
        {
            Destroy(_listings[i].gameObject);
        }
        _listings.Clear();
    }

    public override void OnEnable()
    {
        base.OnEnable();
        //SetReadyUp(false);
        GetCurrentRoomPlayers();
    }

    public override void OnDisable()
    {
        base.OnDisable();
        for (int i=0;i< _listings.Count;i++)
        {
            Destroy(_listings[i]);
        }
        _listings.Clear();
    }

    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomsCanvases = canvases;
    }

    //private void SetReadyUp(bool state)
    //{
    //    _ready = state;
    //    if (_ready)
    //        _readyUpText.text = "R";
    //    else
    //        _readyUpText.text = "N";
    //}

    private void GetCurrentRoomPlayers()
    {
        Debug.Log("GetCurrentRoomPlayers");
        if (!PhotonNetwork.IsConnected)
            return;
        if (PhotonNetwork.CurrentRoom == null || PhotonNetwork.CurrentRoom.Players == null)
            return;
        
        foreach (KeyValuePair<int,Photon.Realtime.Player> playerInfo in PhotonNetwork.CurrentRoom.Players)
        {
            AddPlayerListing(playerInfo.Value);
        }
        
    }

    private void AddPlayerListing(Photon.Realtime.Player player)
    {
        Debug.Log("AddPlayerListing");
        int index = _listings.FindIndex(x => x.Player == player);
        if (index != -1)
        {
            _listings[index].SetPlayerInfo(player);
        }
        else
        {
            PlayerListingSetting listing = Instantiate(_playerListing, _content);
            if (listing != null)
            {
                listing.SetPlayerInfo(player);
                _listings.Add(listing);
            }
        }
        
    }
    public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    {
        Debug.Log("PlayerEnterRoom");
        AddPlayerListing(newPlayer);
    }

    public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer)
    {
        Debug.Log("PlayerLeftRoom");
        int index = _listings.FindIndex(x => x.Player == otherPlayer);
        if (index != -1)
        {
            Destroy(_listings[index].gameObject);
            _listings.RemoveAt(index);
            Debug.Log(_listings);
        }
      
        
    }

    public void OnClick_StartGame()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.CurrentRoom.IsOpen = false;
            PhotonNetwork.CurrentRoom.IsVisible = false;
            //PhotonNetwork.LoadLevel("ARMultipleObjects");
            PhotonNetwork.LoadLevel("Main");
        }
        
    }
   
}
