namespace WillowMaze.Wasm.Decompiled;

public interface P9aebe01c
{
    void Close();
    int GetReceiveLimit();
    int GetSendLimit();
    int Receive(byte[] P0, int P1, int P2, int P3);
    void Send(byte[] P0, int P1, int P2);
}
