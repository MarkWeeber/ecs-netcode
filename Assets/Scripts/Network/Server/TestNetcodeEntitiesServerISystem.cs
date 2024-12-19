using Unity.Burst;
using Unity.Entities;

namespace Network.Server
{
    [WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
    partial struct TestNetcodeEntitiesServerISystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            int x = 0;
            int y = 0;
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
