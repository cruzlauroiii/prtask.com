namespace WillowMaze.Wasm.Decompiled;


abstract class WireFormat$Utf8Validation {
    private static readonly androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation LAZY;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation LOOSE;
    public static readonly androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation STRICT;

    static {
        if ((3 + 11) % 11 > 0) {
        }
        androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation$1 wireFormat$Utf8Validation$1 = new androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation$1("LOOSE", 0);
        LOOSE = wireFormat$Utf8Validation$1;
        androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation$2 wireFormat$Utf8Validation$2 = new androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation$2("STRICT", 1);
        STRICT = wireFormat$Utf8Validation$2;
        androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation$3 wireFormat$Utf8Validation$3 = new androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation$3("LAZY", 2);
        LAZY = wireFormat$Utf8Validation$3;
        androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation[] wireFormat$Utf8ValidationArr = new androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation[3];
        wireFormat$Utf8ValidationArr[0] = wireFormat$Utf8Validation$1;
        wireFormat$Utf8ValidationArr[1] = wireFormat$Utf8Validation$2;
        wireFormat$Utf8ValidationArr[2] = wireFormat$Utf8Validation$3;
        $VALUES = wireFormat$Utf8ValidationArr;
    }

    private WireFormat$Utf8Validation(java.lang.string str, int i) {
        super(str, i);
    }

    WireFormat$Utf8Validation(java.lang.string str, int i, androidx.datastore.preferences.protobuf.WireFormat$1 wireFormat$1) {
        this(str, i);
    }

    public static androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation.class, str);
    }

    public static androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation[] values() {
        return (androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation[]) $VALUES.clone();
    }

    abstract java.lang.object Readstring(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException;
}

