using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerPanelUI : MonoBehaviour
{
    [SerializeField] private Player playerID;
    [SerializeField] private PlayerPanelStationSprites[] panelStationSprites;
    [SerializeField] private Image middleIcon, northSprite, southSprite, eastSprite, westSprite;
    private SerializedDictionary<Station.StationTypeEnum, PlayerPanelStationSprites> stationToSprites;
    private StationController playerStationController;

    private void Start()
    {
        playerStationController = StationController.PlayersMap[playerID];
        playerStationController.OnEnterStation += OnEnterStation;
        playerStationController.OnExitStation += OnExitStation;
    }

    private void OnExitStation(Player p)
    {
        if (playerID != p) return;
        UpdateControlsUI(Station.StationTypeEnum.NoStation);
    }

    private void OnEnterStation(Player p, Station station)
    {
        if (playerID != p) return;
        UpdateControlsUI(station.StationType);
    }

    private void UpdateControlsUI(Station.StationTypeEnum stationType)
    {
        PlayerPanelStationSprites panelSprites = null;
        foreach (var p in panelStationSprites)
        {
            if (p.stationType == stationType)
            {
                panelSprites = p;
                break;
            }
        }

        if (panelSprites == null)
        {
            panelSprites = new PlayerPanelStationSprites(); // all sprites are null.
        }

        middleIcon.enabled = (bool) panelSprites.middleIcon;
        middleIcon.sprite = panelSprites.middleIcon;
        
        northSprite.enabled = (bool) panelSprites.northSprite;
        northSprite.sprite = panelSprites.northSprite;
        
        southSprite.enabled = (bool) panelSprites.southSprite;
        southSprite.sprite = panelSprites.southSprite;

        eastSprite.enabled = (bool) panelSprites.eastSprite;
        eastSprite.sprite = panelSprites.eastSprite;
        
        westSprite.enabled = (bool) panelSprites.westSprite;
        westSprite.sprite = panelSprites.westSprite;
    }

    [Serializable]
    public class PlayerPanelStationSprites
    {
        public Station.StationTypeEnum stationType;
        public Sprite middleIcon, northSprite, southSprite, eastSprite, westSprite;
    }
}
