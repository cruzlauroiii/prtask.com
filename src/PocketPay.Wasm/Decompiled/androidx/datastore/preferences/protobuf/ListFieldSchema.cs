namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
interface ListFieldSchema {
    void makeImmutableListAt(java.lang.object obj, long j);

    <L> void mergeListsAt(java.lang.object obj, java.lang.object obj2, long j);

    <L> java.util.List<L> mutableListAt(java.lang.object obj, long j);
}

