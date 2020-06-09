using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class PlayerMovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref Translation pos, in MoveData moveData) =>
        {
            float3 normalizedDir = math.normalizesafe(moveData.Direction);
            Debug.Log(normalizedDir);
            pos.Value += normalizedDir * moveData.Speed * deltaTime;
        }).WithoutBurst().Run();
    }
}
