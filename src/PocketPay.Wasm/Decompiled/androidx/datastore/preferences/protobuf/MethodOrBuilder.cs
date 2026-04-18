namespace WillowMaze.Wasm.Decompiled;


public interface MethodOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    androidx.datastore.preferences.protobuf.Option getOptions(int i);

    int getOptionsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Option> getOptionsList();

    bool getRequestStreaming();

    java.lang.string getRequestTypeUrl();

    androidx.datastore.preferences.protobuf.bytestring getRequestTypeUrlbytes();

    bool getResponseStreaming();

    java.lang.string getResponseTypeUrl();

    androidx.datastore.preferences.protobuf.bytestring getResponseTypeUrlbytes();

    androidx.datastore.preferences.protobuf.Syntax getSyntax();

    int getSyntaxValue();
}

