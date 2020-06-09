using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

public class FaceDirectionSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref Rotation rotation, in MoveData moveData) => 
        {
            if (!moveData.Direction.Equals(float3.zero))
            {
                quaternion targetRotation = quaternion.LookRotationSafe(moveData.Direction, math.up());
                rotation.Value = math.slerp(rotation.Value, targetRotation, moveData.TurnSpeed);
            }
        }).WithoutBurst().Run();
    }
}
