using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Stations;
using UnityEngine;

public enum Player
{
    Player1, 
    Player2
}

public class StationController : MonoBehaviour
{
    public static Dictionary<Player, StationController> PlayersMap = new Dictionary<Player, StationController>();

    public Action<Player, Station> OnEnterStation;
    public Action<Player> OnExitStation;

    [SerializeField] private Player playerID;
    public Player PlayerID => playerID;

    private Station currentStation;
    private Station defaultStation;
    private PlayerInputController playerInputController;

    private void Awake()
    {
        PlayersMap[playerID] = this;
    }

    void Start()
    {
        playerInputController = GetComponent<PlayerInputController>();
        defaultStation = GetComponent<NoStationMovement>();
        currentStation = defaultStation;
        currentStation.Inject(playerInputController);
        OnExitStation?.Invoke(playerID);
    }

    /**
     * returns to the default station.
     */
    public void ExitStation()
    {
        currentStation.Eject(playerInputController);
        currentStation = defaultStation;
        currentStation.Inject(playerInputController);
        
        OnExitStation?.Invoke(playerID);
    }

    public void EnterStation(Station station)
    {
        currentStation.Eject(playerInputController);
        currentStation = station;
        currentStation.Inject(playerInputController);
        
        OnEnterStation?.Invoke(playerID, station);
    }
}
