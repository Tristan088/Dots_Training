using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]

public struct PaddleMoveData : IComponentData
{
    public int direction;
    public float speed;
}
