using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.NetCode;
using UnityEngine;

namespace Network.Server.Systems
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

        //[BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var ecb = new EntityCommandBuffer(Allocator.Temp);
            foreach ((
                    RefRO<SimpleRPC> simpleRPC,
                    RefRO<ReceiveRpcCommandRequest> receiveRpcCommandRequest,
                    var entity
                    )
                in SystemAPI.Query<
                         RefRO<SimpleRPC>,
                         RefRO<ReceiveRpcCommandRequest>>().WithEntityAccess())
            {
                Debug.Log($"Recevied RPC: {simpleRPC.ValueRO.Value} from {receiveRpcCommandRequest.ValueRO.SourceConnection}");
                ecb.DestroyEntity(entity);
            }
            ecb.Playback(state.EntityManager);
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        
        }
    }
}
