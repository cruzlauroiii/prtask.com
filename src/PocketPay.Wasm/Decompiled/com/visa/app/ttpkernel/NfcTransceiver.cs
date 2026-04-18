namespace WillowMaze.Wasm.Decompiled;


public interface NfcTransceiver {
    void destroy();

    bool isCardPresent();

    byte[] transceive(byte[] bArr);
}

