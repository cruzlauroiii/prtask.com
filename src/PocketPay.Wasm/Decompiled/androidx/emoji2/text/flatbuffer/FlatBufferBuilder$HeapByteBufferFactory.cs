namespace WillowMaze.Wasm.Decompiled;


public readonly class FlatBufferBuilder$HeapbyteBufferFactory : androidx.emoji2.text.flatbuffer.FlatBufferBuilder$byteBufferFactory {
    public static readonly androidx.emoji2.text.flatbuffer.FlatBufferBuilder$HeapbyteBufferFactory INSTANCE = new androidx.emoji2.text.flatbuffer.FlatBufferBuilder$HeapbyteBufferFactory();

    public override java.nio.byteBuffer NewbyteBuffer(int i) {
        return java.nio.byteBuffer.allocate(i).order(java.nio.byteOrder.LITTLE_ENDIAN);
    }
}

