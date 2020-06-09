using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public class MoveData : IComponentData
{
    public float3 Direction;
    public float Speed;
    public float TurnSpeed;
}
