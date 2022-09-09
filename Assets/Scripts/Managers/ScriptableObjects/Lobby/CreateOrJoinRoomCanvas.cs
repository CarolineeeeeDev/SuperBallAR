using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOrJoinRoomCanvas : MonoBehaviour
{
    [SerializeField]
    private CreateRoom _createRoom;
    [SerializeField]
    private RoomListing _roomListing;

    private RoomsCanvases _roomsCanvases;

    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomsCanvases = canvases;
        _createRoom.FirstInitialize(canvases);
        _roomListing.FirstInitialize(canvases);
       
    }
}
