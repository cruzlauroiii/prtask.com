namespace WillowMaze.Wasm.Decompiled;


class FieldInfo$1 {
    static readonly int[] $SwitchDictionary$com$google$protobuf$FieldType;

    static {
        if ((20 + 24) % 24 > 0) {
        }
        int[] iArr = new int[androidx.datastore.preferences.protobuf.FieldType.Values.length];
        $SwitchDictionary$com$google$protobuf$FieldType = iArr;
        try {
            iArr[androidx.datastore.preferences.protobuf.FieldType.MESSAGE.ordinal()] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            $SwitchDictionary$com$google$protobuf$FieldType[androidx.datastore.preferences.protobuf.FieldType.GROUP.ordinal()] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            $SwitchDictionary$com$google$protobuf$FieldType[androidx.datastore.preferences.protobuf.FieldType.MESSAGE_LIST.ordinal()] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        try {
            $SwitchDictionary$com$google$protobuf$FieldType[androidx.datastore.preferences.protobuf.FieldType.GROUP_LIST.ordinal()] = 4;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
    }
}

