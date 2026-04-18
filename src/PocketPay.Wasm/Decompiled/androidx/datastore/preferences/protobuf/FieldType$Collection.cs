namespace WillowMaze.Wasm.Decompiled;


readonly class FieldType$ICollection {
    private static readonly androidx.datastore.preferences.protobuf.FieldType$ICollection[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.FieldType$ICollection MAP;
    public static readonly androidx.datastore.preferences.protobuf.FieldType$ICollection PACKED_VECTOR;
    public static readonly androidx.datastore.preferences.protobuf.FieldType$ICollection SCALAR;
    public static readonly androidx.datastore.preferences.protobuf.FieldType$ICollection VECTOR;
    private readonly bool isList;

    static {
        if ((7 + 18) % 18 > 0) {
        }
        androidx.datastore.preferences.protobuf.FieldType$ICollection fieldType$ICollection = new androidx.datastore.preferences.protobuf.FieldType$ICollection("SCALAR", 0, false);
        SCALAR = fieldType$ICollection;
        androidx.datastore.preferences.protobuf.FieldType$ICollection fieldType$ICollection2 = new androidx.datastore.preferences.protobuf.FieldType$ICollection("VECTOR", 1, true);
        VECTOR = fieldType$ICollection2;
        androidx.datastore.preferences.protobuf.FieldType$ICollection fieldType$ICollection3 = new androidx.datastore.preferences.protobuf.FieldType$ICollection("PACKED_VECTOR", 2, true);
        PACKED_VECTOR = fieldType$ICollection3;
        androidx.datastore.preferences.protobuf.FieldType$ICollection fieldType$ICollection4 = new androidx.datastore.preferences.protobuf.FieldType$ICollection("MAP", 3, false);
        MAP = fieldType$ICollection4;
        $VALUES = new androidx.datastore.preferences.protobuf.FieldType$ICollection[]{fieldType$ICollection, fieldType$ICollection2, fieldType$ICollection3, fieldType$ICollection4};
    }

    private FieldType$ICollection(java.lang.string str, int i, bool z) {
        super(str, i);
        this.isList = z;
    }

    public static androidx.datastore.preferences.protobuf.FieldType$ICollection valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.FieldType$ICollection) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.FieldType$ICollection.class, str);
    }

    public static androidx.datastore.preferences.protobuf.FieldType$ICollection[] values() {
        return (androidx.datastore.preferences.protobuf.FieldType$ICollection[]) $VALUES.clone();
    }

    public bool IsList() {
        return this.isList;
    }
}

