namespace WillowMaze.Wasm.Decompiled;


public abstract class byteOutput {
    public abstract void Write(byte b) throws java.io.IOException;

    public abstract void Write(java.nio.byteBuffer byteBuffer) throws java.io.IOException;

    public abstract void Write(byte[] bArr, int i, int i2) throws java.io.IOException;

    public abstract void WriteLazy(java.nio.byteBuffer byteBuffer) throws java.io.IOException;

    public abstract void WriteLazy(byte[] bArr, int i, int i2) throws java.io.IOException;
}

