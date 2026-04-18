namespace WillowMaze.Wasm.Decompiled;

public interface NfcTransceiver
{
    void Destroy();
    bool IsCardPresent();
    byte[] Transceive(byte[] P0);
}
