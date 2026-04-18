namespace WillowMaze.Wasm.Decompiled;


public interface ApiOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    androidx.datastore.preferences.protobuf.Method getMethods(int i);

    int getMethodsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Method> getMethodsList();

    androidx.datastore.preferences.protobuf.Mixin getMixins(int i);

    int getMixinsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Mixin> getMixinsList();

    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    androidx.datastore.preferences.protobuf.Option getOptions(int i);

    int getOptionsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Option> getOptionsList();

    androidx.datastore.preferences.protobuf.Sourceobject getSourceobject();

    androidx.datastore.preferences.protobuf.Syntax getSyntax();

    int getSyntaxValue();

    java.lang.string getVersion();

    androidx.datastore.preferences.protobuf.bytestring getVersionbytes();

    bool hasSourceobject();
}

