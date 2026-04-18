namespace WillowMaze.Wasm.Decompiled;


public interface TypeOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    java.lang.string getEdition();

    androidx.datastore.preferences.protobuf.bytestring getEditionbytes();

    androidx.datastore.preferences.protobuf.Field getFields(int i);

    int getFieldsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Field> getFieldsList();

    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    java.lang.string getOneofs(int i);

    androidx.datastore.preferences.protobuf.bytestring getOneofsbytes(int i);

    int getOneofsCount();

    java.util.List<java.lang.string> getOneofsList();

    androidx.datastore.preferences.protobuf.Option getOptions(int i);

    int getOptionsCount();

    java.util.List<androidx.datastore.preferences.protobuf.Option> getOptionsList();

    androidx.datastore.preferences.protobuf.Sourceobject getSourceobject();

    androidx.datastore.preferences.protobuf.Syntax getSyntax();

    int getSyntaxValue();

    bool hasSourceobject();
}

