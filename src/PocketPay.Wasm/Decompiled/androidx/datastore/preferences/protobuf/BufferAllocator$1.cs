namespace WillowMaze.Wasm.Decompiled;


class BufferAllocator$1 : androidx.datastore.preferences.protobuf.BufferAllocator {
    BufferAllocator$1() {
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer GPNaexTXXVtjnfBT(java.nio.byteBuffer byteBuffer) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(byteBuffer);
    }

    public static java.nio.byteBuffer KtBoGJprSbdGKWjl(int i) {
        return java.nio.byteBuffer.allocateDirect(i);
    }

    public static androidx.datastore.preferences.protobuf.AllocatedBuffer MwRLJwPEsVOAxThC(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.AllocatedBuffer.wrap(bArr);
    }

    public override androidx.datastore.preferences.protobuf.AllocatedBuffer AllocateDirectBuffer(int i) {
        return GPNaexTXXVtjnfBT(KtBoGJprSbdGKWjl(i));
    }

    public override androidx.datastore.preferences.protobuf.AllocatedBuffer AllocateHeapBuffer(int i) {
        return mwRLJwPEsVOAxThC(new byte[i]);
    }
}

