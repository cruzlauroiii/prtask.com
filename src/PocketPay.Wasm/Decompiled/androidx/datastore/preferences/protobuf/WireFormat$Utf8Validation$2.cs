namespace WillowMaze.Wasm.Decompiled;


readonly enum WireFormat$Utf8Validation$2 : androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation {
    WireFormat$Utf8Validation$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    java.lang.object readstring(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return codedStream.readstringRequireUtf8();
    }
}

