using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownLookRotation : MonoBehaviour
{
    [SerializeField] private Transform lookPoint;
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        LookRotate(direction);
    }

    private void LookRotate(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotz) > 90f;
    }
}
