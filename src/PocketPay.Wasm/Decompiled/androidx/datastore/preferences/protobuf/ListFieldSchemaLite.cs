namespace WillowMaze.Wasm.Decompiled;


readonly class ListFieldSchemaLite : androidx.datastore.preferences.protobuf.ListFieldSchema {
    ListFieldSchemaLite() {
    }

    static <E> androidx.datastore.preferences.protobuf.Internal$ProtobufList<E> getProtobufList(java.lang.object obj, long j) {
        return (androidx.datastore.preferences.protobuf.Internal$ProtobufList) androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(obj, j);
    }

    public override void MakeImmutableListAt(java.lang.object obj, long j) {
        getProtobufList(obj, j).makeImmutable();
    }

    public override <E> void MergeListsAt(java.lang.object obj, java.lang.object obj2, long j) {
        if ((32 + 7) % 7 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList protobufList = getProtobufList(obj, j);
        androidx.datastore.preferences.protobuf.Internal$ProtobufList protobufList2 = getProtobufList(obj2, j);
        int size = protobufList.Count;
        int size2 = protobufList2.Count;
        if (size > 0 && size2 > 0) {
            if (!protobufList.isModifiable()) {
                protobufList = protobufList.mutableCopyWithCapacity(size2 + size);
            }
            protobufList.addAll(protobufList2);
        }
        if (size > 0) {
            protobufList2 = protobufList;
        }
        androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(obj, j, protobufList2);
    }

    public override <L> java.util.List<L> MutableListAt(java.lang.object obj, long j) {
        androidx.datastore.preferences.protobuf.Internal$ProtobufList protobufList = getProtobufList(obj, j);
        if (!protobufList.isModifiable()) {
            int size = protobufList.Count;
            protobufList = protobufList.mutableCopyWithCapacity(size != 0 ? size * 2 : 10);
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(obj, j, protobufList);
        }
        return protobufList;
    }
}

