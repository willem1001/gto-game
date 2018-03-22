﻿using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public readonly List<Player> _players;
    private int _currentPlayer;

    void Start()
    {
        foreach (var player in _players)
        {
            player.EndTurn();
        }

       GetCurrentPlayer().StartTurn();
    }

    public void NextTurn()
    {
        GetCurrentPlayer().GetComponentInChildren<TileSelect>().ClearSelection();
        GetCurrentPlayer().EndTurn();
        _currentPlayer++;
        if (_currentPlayer >= _players.Count)
        {
            _currentPlayer = 0;
        }
       GetCurrentPlayer().StartTurn();
    }

    public Player GetCurrentPlayer()
    {
        return _players[_currentPlayer];
    }
}
