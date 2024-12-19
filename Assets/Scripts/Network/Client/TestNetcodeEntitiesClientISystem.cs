using Unity.Burst;
using Unity.Entities;

namespace Network.Client
{
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
    partial struct TestNetcodeEntitiesClientISystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
        
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
        
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        
        }
    }
}
