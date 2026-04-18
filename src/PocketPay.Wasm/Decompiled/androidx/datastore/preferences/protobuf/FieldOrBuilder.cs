namespace WillowMaze.Wasm.Decompiled;


public interface FieldOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    androidx.datastore.preferences.protobuf.Field$Cardinality getCardinality();

    int getCardinalityValue();

    java.lang.string getDefaultValue();

    androidx.datastore.preferences.protobuf.bytestring getDefaultValuebytes();

    java.lang.string getJsonName();

    androidx.datastore.preferences.protobuf.bytestring getJsonNamebytes();

    androidx.datastore.preferences.protobuf.Field$Kind getKind();

    int getKindValue();

    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    int getNumber();

    int getOneofIndex();

    androidx.datastore.preferences.protobuf.Option getOptions(int i);

    int getOptionsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Option> getOptionsList();

    bool getPacked();

    java.lang.string getTypeUrl();

    androidx.datastore.preferences.protobuf.bytestring getTypeUrlbytes();
}

