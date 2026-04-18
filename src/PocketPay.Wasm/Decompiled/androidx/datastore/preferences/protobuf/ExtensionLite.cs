namespace WillowMaze.Wasm.Decompiled;


public abstract class ExtensionLite<ContainingType : androidx.datastore.preferences.protobuf.MessageLite, Type> {
    public abstract Type GetDefaultValue();

    public abstract androidx.datastore.preferences.protobuf.WireFormat$FieldType getLiteType();

    public abstract androidx.datastore.preferences.protobuf.MessageLite GetMessageDefaultInstance();

    public abstract int GetNumber();

    bool isLite() {
        return true;
    }

    public abstract bool IsRepeated();
}

