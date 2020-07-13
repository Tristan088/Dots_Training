using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;



[AlwaysSynchronizeSystem]
public class PaddleMoveSystem : JobComponentSystem
{

    


    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {

        float deltaTime = Time.DeltaTime;
        float yBound = GameManager.main.yBound;


        Entities.ForEach((ref Translation trans, in PaddleMoveData data) =>
        {
            trans.Value.y = math.clamp(trans.Value.y + (data.direction * data.speed * deltaTime), -yBound, yBound);
        }).Run();

        return default;
    }
}
