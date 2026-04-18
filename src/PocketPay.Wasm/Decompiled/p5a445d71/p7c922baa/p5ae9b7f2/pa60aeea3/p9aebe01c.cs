namespace WillowMaze.Wasm.Decompiled;


public interface p9aebe01c {
    void close() throws java.io.IOException;

    int getReceiveLimit() throws java.io.IOException;

    int getSendLimit() throws java.io.IOException;

    int receive(byte[] bArr, int i, int i2, int i3) throws java.io.IOException;

    void send(byte[] bArr, int i, int i2) throws java.io.IOException;
}

