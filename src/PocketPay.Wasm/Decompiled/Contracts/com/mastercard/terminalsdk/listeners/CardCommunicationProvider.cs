namespace WillowMaze.Wasm.Decompiled;

public interface CardCommunicationProvider
{
    bool ConnectReader();
    bool DisconnectReader();
    string GetDescription();
    long GetPreviousCommandExecutionTime();
    bool IsCardPresent();
    bool IsReaderConnected();
    bool RemoveCard();
    byte[] SendReceive(byte[] P0);
    CardCommunicationProvider$ConnectionObject WaitForCard();
}
