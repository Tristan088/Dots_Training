using Unity.Entities;
using UnityEngine;


[GenerateAuthoringComponent]
public struct PaddleMoveData : IComponentData
{

    public int direction;
    public float speed;



}
