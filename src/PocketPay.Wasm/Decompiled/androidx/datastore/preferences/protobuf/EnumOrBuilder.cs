namespace WillowMaze.Wasm.Decompiled;


public interface EnumOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    java.lang.string getEdition();

    androidx.datastore.preferences.protobuf.bytestring getEditionbytes();

    androidx.datastore.preferences.protobuf.EnumValue getEnumvalue(int i);

    int getEnumvalueCount();

    java.util.List<androidx.datastore.preferences.protobuf.EnumValue> getEnumvalueList();

    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    androidx.datastore.preferences.protobuf.Option getOptions(int i);

    int getOptionsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Option> getOptionsList();

    androidx.datastore.preferences.protobuf.Sourceobject getSourceobject();

    androidx.datastore.preferences.protobuf.Syntax getSyntax();

    int getSyntaxValue();

    bool hasSourceobject();
}

