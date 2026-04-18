namespace WillowMaze.Wasm.Decompiled;


readonly enum WireFormat$Utf8Validation$3 : androidx.datastore.preferences.protobuf.WireFormat$Utf8Validation {
    WireFormat$Utf8Validation$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    java.lang.object readstring(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return codedStream.readbytes();
    }
}

