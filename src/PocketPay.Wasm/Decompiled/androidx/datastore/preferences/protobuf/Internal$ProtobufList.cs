namespace WillowMaze.Wasm.Decompiled;


public interface Internal$ProtobufList<E> : java.util.List<E>, java.util.RandomAccess {
    bool isModifiable();

    void makeImmutable();

    androidx.datastore.preferences.protobuf.Internal$ProtobufList<E> mutableCopyWithCapacity(int i);
}

