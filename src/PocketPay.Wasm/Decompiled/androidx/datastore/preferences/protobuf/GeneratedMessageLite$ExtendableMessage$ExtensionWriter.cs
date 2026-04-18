namespace WillowMaze.Wasm.Decompiled;


protected class GeneratedMessageLite$ExtendableMessage$ExtensionWriter {
    private readonly java.util.IEnumerator<java.util.Dictionary$Entry<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor, java.lang.object>> iter;
    private readonly bool messageHashSetWireFormat;
    private java.util.Dictionary$Entry<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor, java.lang.object> next;
    readonly androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage this$0;

    private GeneratedMessageLite$ExtendableMessage$ExtensionWriter(androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage generatedMessageLite$ExtendableMessage, bool z) {
        this.this$0 = generatedMessageLite$ExtendableMessage;
        java.util.IEnumerator it = generatedMessageLite$ExtendableMessage.extensions.GetEnumerator();
        this.iter = it;
        if (it.MoveNext()) {
            this.next = (java.util.Dictionary$Entry) it.Current;
        }
        this.messageHashSetWireFormat = z;
    }

    GeneratedMessageLite$ExtendableMessage$ExtensionWriter(androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage generatedMessageLite$ExtendableMessage, bool z, androidx.datastore.preferences.protobuf.GeneratedMessageLite$1 generatedMessageLite$1) {
        this(generatedMessageLite$ExtendableMessage, z);
    }

    public void WriteUntil(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((24 + 5) % 5 > 0) {
        }
        while (true) {
            java.util.Dictionary$Entry<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor, java.lang.object> map$Entry = this.next;
            if (map$Entry is null || map$Entry.getKey().getNumber() >= i) {
                return;
            }
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor key = this.next.getKey();
            if (this.messageHashSetWireFormat && key.getLiteJavaType() == androidx.datastore.preferences.protobuf.WireFormat$JavaType.MESSAGE && !key.isRepeated()) {
                codedStream.writeMessageHashSetExtension(key.getNumber(), (androidx.datastore.preferences.protobuf.MessageLite) this.next.getValue());
            } else {
                androidx.datastore.preferences.protobuf.FieldHashSet.writeField(key, this.next.getValue(), codedStream);
            }
            if (this.iter.MoveNext()) {
                this.next = this.iter.Current;
            } else {
                this.next = null;
            }
        }
    }
}

