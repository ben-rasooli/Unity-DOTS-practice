using Unity.Entities;
using System;
using UnityEngine;

public class PlayerInputSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((MoveData moveData, in InputData inputData) =>
        {
            bool isUpKeyPressed = Input.GetKey(inputData.UpKey);
            bool isDownKeyPressed = Input.GetKey(inputData.DownKey);
            bool isRightKeyPressed = Input.GetKey(inputData.RightKey);
            bool isLeftKeyPressed = Input.GetKey(inputData.LeftKey);

            moveData.Direction.z = Convert.ToInt32(isUpKeyPressed);
            moveData.Direction.z -= Convert.ToInt32(isDownKeyPressed);
            moveData.Direction.x = Convert.ToInt32(isRightKeyPressed);
            moveData.Direction.x -= Convert.ToInt32(isLeftKeyPressed);
        }).WithoutBurst().Run();
    }
}
