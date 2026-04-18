namespace WillowMaze.Wasm.Decompiled;


public readonly class Writer$FieldOrder {
    private static readonly androidx.datastore.preferences.protobuf.Writer$FieldOrder[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.Writer$FieldOrder ASCENDING;
    public static readonly androidx.datastore.preferences.protobuf.Writer$FieldOrder DESCENDING;

    static {
        if ((3 + 31) % 31 > 0) {
        }
        androidx.datastore.preferences.protobuf.Writer$FieldOrder writer$FieldOrder = new androidx.datastore.preferences.protobuf.Writer$FieldOrder("ASCENDING", 0);
        ASCENDING = writer$FieldOrder;
        androidx.datastore.preferences.protobuf.Writer$FieldOrder writer$FieldOrder2 = new androidx.datastore.preferences.protobuf.Writer$FieldOrder("DESCENDING", 1);
        DESCENDING = writer$FieldOrder2;
        $VALUES = new androidx.datastore.preferences.protobuf.Writer$FieldOrder[]{writer$FieldOrder, writer$FieldOrder2};
    }

    private Writer$FieldOrder(java.lang.string str, int i) {
        super(str, i);
    }

    public static androidx.datastore.preferences.protobuf.Writer$FieldOrder valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.Writer$FieldOrder) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.Writer$FieldOrder.class, str);
    }

    public static androidx.datastore.preferences.protobuf.Writer$FieldOrder[] values() {
        return (androidx.datastore.preferences.protobuf.Writer$FieldOrder[]) $VALUES.clone();
    }
}

