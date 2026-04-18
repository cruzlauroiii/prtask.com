namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
public interface MessageLite : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    androidx.datastore.preferences.protobuf.Parser<? : androidx.datastore.preferences.protobuf.MessageLite> getParserForType();

    int getSerializedSize();

    androidx.datastore.preferences.protobuf.MessageLite$Builder newBuilderForType();

    androidx.datastore.preferences.protobuf.MessageLite$Builder toBuilder();

    byte[] tobyteArray();

    androidx.datastore.preferences.protobuf.bytestring tobytestring();

    void writeDelimitedTo(java.io.Stream outputStream) throws java.io.IOException;

    void writeTo(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException;

    void writeTo(java.io.Stream outputStream) throws java.io.IOException;
}

