using Unity.Burst;
using Unity.Entities;
using Unity.NetCode;
using UnityEngine;

namespace Network.Client.Systems
{
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
    partial struct TestNetcodeEntitiesClientISystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
        
        }

        //[BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                // Send RPC to Server
                var rpcEntity = state.EntityManager.CreateEntity();
                state.EntityManager.AddComponentData(rpcEntity, new SimpleRPC
                {
                    Value = 42
                });
                state.EntityManager.AddComponentData(rpcEntity, new SendRpcCommandRequest());
                Debug.Log("Rpc Sent to Server");
            }
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        
        }
    }
}
