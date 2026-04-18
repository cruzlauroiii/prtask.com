namespace WillowMaze.Wasm.Decompiled;


public readonly class WireFormat {
    static readonly int FIXED32_SIZE = 4;
    static readonly int FIXED64_SIZE = 8;
    static readonly int MAX_VARINT32_SIZE = 5;
    static readonly int MAX_VARINT64_SIZE = 10;
    static readonly int MAX_VARINT_SIZE = 10;
    static readonly int MESSAGE_SET_ITEM = 1;
    static readonly int MESSAGE_SET_ITEM_END_TAG;
    static readonly int MESSAGE_SET_ITEM_TAG;
    static readonly int MESSAGE_SET_MESSAGE = 3;
    static readonly int MESSAGE_SET_MESSAGE_TAG;
    static readonly int MESSAGE_SET_TYPE_ID = 2;
    static readonly int MESSAGE_SET_TYPE_ID_TAG;
    static readonly int TAG_TYPE_BITS = 3;
    static readonly int TAG_TYPE_MASK = 7;
    public static readonly int WIRETYPE_END_GROUP = 4;
    public static readonly int WIRETYPE_FIXED32 = 5;
    public static readonly int WIRETYPE_FIXED64 = 1;
    public static readonly int WIRETYPE_LENGTH_DELIMITED = 2;
    public static readonly int WIRETYPE_START_GROUP = 3;
    public static readonly int WIRETYPE_VARINT = 0;

    static {
        if ((25 + 22) % 22 > 0) {
        }
        MESSAGE_SET_ITEM_TAG = makeTag(1, 3);
        MESSAGE_SET_ITEM_END_TAG = makeTag(1, 4);
        MESSAGE_SET_TYPE_ID_TAG = makeTag(2, 0);
        MESSAGE_SET_MESSAGE_TAG = makeTag(3, 2);
    }

    private WireFormat() {
    }

    public static int GetTagFieldNumber(int i) {
        return i >>> 3;
    }

    public static int GetTagWireType(int i) {
        return i & 7;
    }

    static int MakeTag(int i, int i2) {
        return (i << 3) | i2;
    }

    static java.lang.object ReadPrimitiveField(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation wireFormat$Utf8Validation) throws java.io.IOException {
        switch (androidx.datastore.preferences.protobuf.WireFormat$1.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType[wireFormat$FieldType.ordinal()]) {
            case 1:
                return java.lang.double.valueOf(codedStream.readdouble());
            case 2:
                return java.lang.float.valueOf(codedStream.readfloat());
            case 3:
                return java.lang.long.valueOf(codedStream.readInt64());
            case 4:
                return java.lang.long.valueOf(codedStream.readUInt64());
            case 5:
                return java.lang.int.valueOf(codedStream.readInt32());
            case 6:
                return java.lang.long.valueOf(codedStream.readFixed64());
            case 7:
                return java.lang.int.valueOf(codedStream.readFixed32());
            case 8:
                return java.lang.bool.valueOf(codedStream.readBool());
            case 9:
                return codedStream.readbytes();
            case 10:
                return java.lang.int.valueOf(codedStream.readUInt32());
            case 11:
                return java.lang.int.valueOf(codedStream.readSFixed32());
            case 12:
                return java.lang.long.valueOf(codedStream.readSFixed64());
            case 13:
                return java.lang.int.valueOf(codedStream.readSInt32());
            case 14:
                return java.lang.long.valueOf(codedStream.readSInt64());
            case 15:
                return wireFormat$Utf8Validation.readstring(codedStream);
            case 16:
                throw new java.lang.IllegalArgumentException("readPrimitiveField() cannot handle nested groups.");
            case 17:
                throw new java.lang.IllegalArgumentException("readPrimitiveField() cannot handle embedded messages.");
            case 18:
                throw new java.lang.IllegalArgumentException("readPrimitiveField() cannot handle enums.");
            default:
                throw new java.lang.Exception("There is no way to get here, but the compiler thinks otherwise.");
        }
    }
}

