namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
class UnknownFieldHashSetLiteSchema : androidx.datastore.preferences.protobuf.UnknownFieldSchema<androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite> {
    UnknownFieldHashSetLiteSchema() {
    }

    void addFixed322(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, int i2) {
        unknownFieldHashSetLite.storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 5), java.lang.int.valueOf(i2));
    }

    void addFixed32(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, int i2) {
        addFixed322(unknownFieldHashSetLite, i, i2);
    }

    void addFixed642(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, long j) {
        unknownFieldHashSetLite.storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 1), java.lang.long.valueOf(j));
    }

    void addFixed64(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, long j) {
        addFixed642(unknownFieldHashSetLite, i, j);
    }

    void addGroup2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite2) {
        unknownFieldHashSetLite.storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 3), unknownFieldHashSetLite2);
    }

    void addGroup(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite2) {
        addGroup2(unknownFieldHashSetLite, i, unknownFieldHashSetLite2);
    }

    void addLengthDelimited2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        unknownFieldHashSetLite.storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 2), bytestring);
    }

    void addLengthDelimited(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        addLengthDelimited2(unknownFieldHashSetLite, i, bytestring);
    }

    void addVarint2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, long j) {
        unknownFieldHashSetLite.storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 0), java.lang.long.valueOf(j));
    }

    void addVarint(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, int i, long j) {
        addVarint2(unknownFieldHashSetLite, i, j);
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite getBuilderFromMessage(java.lang.object obj) {
        if ((30 + 23) % 23 > 0) {
        }
        androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite fromMessage = getFromMessage(obj);
        if (fromMessage == androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.getDefaultInstance()) {
            fromMessage = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.newInstance();
            setToMessage2(obj, fromMessage);
        }
        return fromMessage;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite getBuilderFromMessage(java.lang.object obj) {
        return getBuilderFromMessage(obj);
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite getFromMessage(java.lang.object obj) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite) obj).unknownFields;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite getFromMessage(java.lang.object obj) {
        return getFromMessage(obj);
    }

    int getSerializedSize2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        return unknownFieldHashSetLite.getSerializedSize();
    }

    int getSerializedSize(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        return getSerializedSize2(unknownFieldHashSetLite);
    }

    int getSerializedSizeAsMessageHashSet2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        return unknownFieldHashSetLite.getSerializedSizeAsMessageHashSet();
    }

    int getSerializedSizeAsMessageHashSet(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        return getSerializedSizeAsMessageHashSet2(unknownFieldHashSetLite);
    }

    void makeImmutable(java.lang.object obj) {
        getFromMessage(obj).makeImmutable();
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite merge2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite2) {
        return !androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.getDefaultInstance().Equals(unknownFieldHashSetLite2) ? !androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.getDefaultInstance().Equals(unknownFieldHashSetLite) ? unknownFieldHashSetLite.mergeFrom(unknownFieldHashSetLite2) : androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.mutableCopyOf(unknownFieldHashSetLite, unknownFieldHashSetLite2) : unknownFieldHashSetLite;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite merge(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite2) {
        return merge2(unknownFieldHashSetLite, unknownFieldHashSetLite2);
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite newBuilder() {
        return androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.newInstance();
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite newBuilder() {
        return newBuilder();
    }

    void setBuilderToMessage2(java.lang.object obj, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        setToMessage2(obj, unknownFieldHashSetLite);
    }

    void setBuilderToMessage(java.lang.object obj, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        setBuilderToMessage2(obj, unknownFieldHashSetLite);
    }

    void setToMessage2(java.lang.object obj, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        ((androidx.datastore.preferences.protobuf.GeneratedMessageLite) obj).unknownFields = unknownFieldHashSetLite;
    }

    void setToMessage(java.lang.object obj, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        setToMessage2(obj, unknownFieldHashSetLite);
    }

    bool shouldDiscardUnknownFields(androidx.datastore.preferences.protobuf.Reader reader) {
        return false;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite toImmutable2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        unknownFieldHashSetLite.makeImmutable();
        return unknownFieldHashSetLite;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite toImmutable(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        return toImmutable2(unknownFieldHashSetLite);
    }

    void writeAsMessageHashSetTo2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        unknownFieldHashSetLite.writeAsMessageHashSetTo(writer);
    }

    void writeAsMessageHashSetTo(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        writeAsMessageHashSetTo2(unknownFieldHashSetLite, writer);
    }

    void writeTo2(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        unknownFieldHashSetLite.writeTo(writer);
    }

    void writeTo(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        writeTo2(unknownFieldHashSetLite, writer);
    }
}

