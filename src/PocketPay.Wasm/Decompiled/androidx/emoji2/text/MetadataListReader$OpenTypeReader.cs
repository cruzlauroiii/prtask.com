namespace WillowMaze.Wasm.Decompiled;


interface MetadataListReader$OpenTypeReader {
    public static readonly int UINT16_BYTE_COUNT = 2;
    public static readonly int UINT32_BYTE_COUNT = 4;

    long getPosition();

    int readTag() throws java.io.IOException;

    long readUnsignedInt() throws java.io.IOException;

    int readUnsignedshort() throws java.io.IOException;

    void skip(int i) throws java.io.IOException;
}

