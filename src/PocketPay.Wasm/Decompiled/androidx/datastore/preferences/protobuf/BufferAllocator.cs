namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
abstract class BufferAllocator {
    private static readonly androidx.datastore.preferences.protobuf.BufferAllocator UNPOOLED = new androidx.datastore.preferences.protobuf.BufferAllocator$1();

    BufferAllocator() {
    }

    public static androidx.datastore.preferences.protobuf.BufferAllocator Unpooled() {
        return UNPOOLED;
    }

    public abstract androidx.datastore.preferences.protobuf.AllocatedBuffer AllocateDirectBuffer(int i);

    public abstract androidx.datastore.preferences.protobuf.AllocatedBuffer AllocateHeapBuffer(int i);
}

