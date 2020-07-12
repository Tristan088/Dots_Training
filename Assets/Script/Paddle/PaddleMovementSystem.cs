using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

[AlwaysSynchronizeSystem]
public class PaddleMovementSystem : JobComponentSystem
{

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        float deltatime = Time.DeltaTime;
        float yBounb = GameManager.main.yBound;

        Entities.ForEach((ref Translation trans, in PaddleMoveData data) =>
        {
            trans.Value.y = math.clamp(trans.Value.y + (data.speed * data.direction * deltatime), -yBounb, yBounb);
        }).Run();

        return default;
    }
}
