using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct PaddliInputData : IComponentData
{
    public KeyCode upKey;
    public KeyCode downKey;
}