namespace WillowMaze.Wasm.Decompiled;


public interface ValueOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    bool getBoolValue();

    androidx.datastore.preferences.protobuf.Value$KindCase getKindCase();

    androidx.datastore.preferences.protobuf.ListValue getListValue();

    androidx.datastore.preferences.protobuf.NullValue getNullValue();

    int getNullValueValue();

    double getNumberValue();

    java.lang.string getstringValue();

    androidx.datastore.preferences.protobuf.bytestring getstringValuebytes();

    androidx.datastore.preferences.protobuf.Struct getStructValue();

    bool hasBoolValue();

    bool hasListValue();

    bool hasNullValue();

    bool hasNumberValue();

    bool hasstringValue();

    bool hasStructValue();
}

