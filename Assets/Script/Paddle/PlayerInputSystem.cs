﻿
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;


[AlwaysSynchronizeSystem]

public class PlayerInputSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {

        Entities.ForEach((ref PaddleMoveData moveData, in PaddliInputData inputData) =>
        {
            moveData.direction = 0;
            moveData.direction += Input.GetKey(inputData.upKey) ? 1 : 0;
            moveData.direction -= Input.GetKey(inputData.downKey) ? 1 : 0;
        }).Run();

        return default;
    }
}