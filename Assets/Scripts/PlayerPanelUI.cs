using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Stations;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerPanelUI : MonoBehaviour
{
    [SerializeField] private Player playerID;
    [Header("UI References")]
    [SerializeField] private Image middleIcon, northSprite, southSprite, eastSprite, westSprite;
    
    [Header("UI Keys Data")]
    [SerializeField] private PlayerPanelStationSprites[] panelStationSprites;
    
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
            transform.DOScale(Vector2.zero, .5f);
        }
        else
        {
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
            
            transform.DOScale(Vector3.one, .7f).SetEase(Ease.OutBack);
            transform.DORotate(Vector3.forward * 360, .7f, RotateMode.FastBeyond360).SetRelative().SetEase(Ease.OutExpo);
        }
    }

    [Serializable]
    public class PlayerPanelStationSprites
    {
        public Station.StationTypeEnum stationType;
        public Sprite middleIcon, northSprite, southSprite, eastSprite, westSprite;
    }
}
