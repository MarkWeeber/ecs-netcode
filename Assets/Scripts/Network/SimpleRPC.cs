using Unity.NetCode;

namespace Network
{
    public struct SimpleRPC : IRpcCommand
    {
        public int Value;
    }
}
