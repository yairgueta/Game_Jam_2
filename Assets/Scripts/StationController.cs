using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class StationController : MonoBehaviour
{
    [SerializeField] private Station currentStation;
    private Station defaultStation;
    private PlayerInputController playerInputController;

    void Start()
    {
        playerInputController = GetComponent<PlayerInputController>();
        defaultStation = GetComponent<NoStationMovement>();
        currentStation = defaultStation;
        currentStation.Inject(playerInputController);
    }

    /**
     * returns to the default station.
     */
    public void ExitStation()
    {
        currentStation.Eject(playerInputController);
        currentStation = defaultStation;
        currentStation.Inject(playerInputController);
    }

    public void EnterStation(Station station)
    {
        currentStation.Eject(playerInputController);
        currentStation = station;
        currentStation.Inject(playerInputController);
    }
}
