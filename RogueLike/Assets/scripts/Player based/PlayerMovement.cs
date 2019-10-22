﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode, SelectionBase]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _MoveDelay = .2f;
    [SerializeField] private float _HorizontalMoveDistance = .25f;
    [SerializeField] private float _VerticalMoveDistance = .5f;

    private bool _permitMove = false;
    private bool _StartedCoroutine = false;
    private Vector2 newPos;
    private void Start()
    {
        newPos = gameObject.transform.position;
    }
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            if (_permitMove)
            {
                MoveCharacter();
            }
            if (!_StartedCoroutine)
            {
                StartCoroutine("Countdown");
            }
        }
    }

    private void MoveCharacter()
    {
        float X_Speed = Input.GetAxisRaw("Horizontal") * _HorizontalMoveDistance;
        float Y_Speed = Input.GetAxisRaw("Vertical") * _VerticalMoveDistance;

        newPos += new Vector2(X_Speed, Y_Speed);
        //Debug.Log("newPos: " + newPos);
        gameObject.transform.position = newPos;

    }



    private IEnumerator Countdown()
    {
        _StartedCoroutine = true;

        float normalizedTime = 0;
        while (normalizedTime <= 1f)
        {
            _permitMove = false;
            normalizedTime += Time.deltaTime / _MoveDelay;
            yield return null;
        }
        _permitMove = true;
        _StartedCoroutine = false;
    }
}

//☺ ♪ └ ╠ ← ╪ Ω ÷ ╢
//☻ ♫ ┴ ═ ∟ ┘ δ ≈ ╖
//♥ ☼ ┬ ╬ ↔ ┌ ∞ ° ╕
//♦ ► ├ ╧ ▲ █ φ ∙ ╣
//♣ ◄ ─ ╨ ▼ ▄ ε ╗ ║
//♠ ↕ ┼ ╤ # ▌ ∩ ╝ ¤
//• ‼ ╞ § ╥ ▐ ≡ ░ †
//◘ ¶ ╟ ▬ ╙ ▀ ± ▒ ‡
//○ ‰ ╚ ↨ ╘ µ ≥ ▓ ⌐
//◙ ≈ ╔ ↑ ╒ τ ≤ │ ¬
//♂ ╛ ╩ ↓ ╓ Φ ⌠ ┤ º
//♀ ┐ ╦ → ╫ Θ ⌡ ╡ I
