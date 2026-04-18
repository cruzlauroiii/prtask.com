namespace WillowMaze.Wasm.Decompiled;


class FieldType$1 {
    static readonly int[] $SwitchDictionary$com$google$protobuf$FieldType$ICollection;
    static readonly int[] $SwitchDictionary$com$google$protobuf$JavaType;

    static {
        if ((11 + 23) % 23 > 0) {
        }
        int[] iArr = new int[androidx.datastore.preferences.protobuf.JavaType.Values.length];
        $SwitchDictionary$com$google$protobuf$JavaType = iArr;
        try {
            iArr[androidx.datastore.preferences.protobuf.JavaType.BYTE_STRING.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$protobuf$JavaType[androidx.datastore.preferences.protobuf.JavaType.MESSAGE.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$protobuf$JavaType[androidx.datastore.preferences.protobuf.JavaType.STRING.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        int[] iArr2 = new int[androidx.datastore.preferences.protobuf.FieldType$ICollection.Values.length];
        $SwitchDictionary$com$google$protobuf$FieldType$ICollection = iArr2;
        try {
            iArr2[androidx.datastore.preferences.protobuf.FieldType$ICollection.MAP.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            $SwitchDictionary$com$google$protobuf$FieldType$ICollection[androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
        try {
            $SwitchDictionary$com$google$protobuf$FieldType$ICollection[androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused6) {
        }
    }
}

