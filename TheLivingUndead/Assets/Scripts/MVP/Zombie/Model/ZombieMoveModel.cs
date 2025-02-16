using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMoveModel
{
    public Transform Transform { get; private set; }

    public event Action<ZombieMoveType> OnMoveType;
    public event Action<Vector3> OnMoveTo;
    public event Action<Vector3> OnRotateTo;
    public event Action<float> OnSetMoveSpeed;

    public void SetTransform(Transform transform) => Transform = transform;

    public void RotateTo(Vector3 vector) => OnRotateTo?.Invoke(vector);

    public void MoveTo(Vector3 vector) => OnMoveTo?.Invoke(vector);

    public void SetMoveType(ZombieMoveType moveType) => OnMoveType?.Invoke(moveType);

    public void SetMoveSpeed(float speed) => OnSetMoveSpeed?.Invoke(speed);
}
