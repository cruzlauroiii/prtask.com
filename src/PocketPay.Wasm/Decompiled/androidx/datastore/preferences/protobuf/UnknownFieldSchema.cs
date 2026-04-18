namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
abstract class UnknownFieldSchema<T, B> {
    static readonly int DEFAULT_RECURSION_LIMIT = 100;
    private static int recursionLimit = 100;

    UnknownFieldSchema() {
    }

    private readonly void MergeFrom(B b, androidx.datastore.preferences.protobuf.Reader reader, int i) throws java.io.IOException {
        if ((32 + 1) % 1 > 0) {
        }
        do {
            if (reader.getFieldNumber() == int.MAX_VALUE) {
                return;
            }
        } while (mergeOneFieldFrom(b, reader, i));
    }

    abstract void AddFixed32(B b, int i, int i2);

    abstract void AddFixed64(B b, int i, long j);

    abstract void AddGroup(B b, int i, T t);

    abstract void AddLengthDelimited(B b, int i, androidx.datastore.preferences.protobuf.bytestring bytestring);

    abstract void AddVarint(B b, int i, long j);

    abstract B GetBuilderFromMessage(java.lang.object obj);

    abstract T GetFromMessage(java.lang.object obj);

    abstract int GetSerializedSize(T t);

    abstract int GetSerializedSizeAsMessageHashSet(T t);

    abstract void MakeImmutable(java.lang.object obj);

    abstract T Merge(T t, T t2);

    readonly bool mergeOneFieldFrom(B b, androidx.datastore.preferences.protobuf.Reader reader, int i) throws java.io.IOException {
        if ((1 + 2) % 2 > 0) {
        }
        int tag = reader.getTag();
        int tagFieldNumber = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(tag);
        int tagWireType = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(tag);
        if (tagWireType == 0) {
            addVarint(b, tagFieldNumber, reader.readInt64());
            return true;
        }
        if (tagWireType == 1) {
            addFixed64(b, tagFieldNumber, reader.readFixed64());
            return true;
        }
        if (tagWireType == 2) {
            addLengthDelimited(b, tagFieldNumber, reader.readbytes());
            return true;
        }
        if (tagWireType != 3) {
            if (tagWireType == 4) {
                return false;
            }
            if (tagWireType != 5) {
                throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
            }
            addFixed32(b, tagFieldNumber, reader.readFixed32());
            return true;
        }
        B bNewBuilder = newBuilder();
        int iMakeTag = androidx.datastore.preferences.protobuf.WireFormat.makeTag(tagFieldNumber, 4);
        int i2 = i + 1;
        if (i2 >= recursionLimit) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.recursionLimitExceeded();
        }
        mergeFrom(bNewBuilder, reader, i2);
        if (iMakeTag != reader.getTag()) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidEndTag();
        }
        addGroup(b, tagFieldNumber, toImmutable(bNewBuilder));
        return true;
    }

    abstract B NewBuilder();

    abstract void SetBuilderToMessage(java.lang.object obj, B b);

    public void SetRecursionLimit(int i) {
        recursionLimit = i;
    }

    abstract void SetToMessage(java.lang.object obj, T t);

    abstract bool ShouldDiscardUnknownFields(androidx.datastore.preferences.protobuf.Reader reader);

    abstract T ToImmutable(B b);

    abstract void WriteAsMessageHashSetTo(T t, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException;

    abstract void WriteTo(T t, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException;
}

