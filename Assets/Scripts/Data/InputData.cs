using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public class InputData : IComponentData
{
    public KeyCode UpKey;
    public KeyCode DownKey;
    public KeyCode RightKey;
    public KeyCode LeftKey;
}
