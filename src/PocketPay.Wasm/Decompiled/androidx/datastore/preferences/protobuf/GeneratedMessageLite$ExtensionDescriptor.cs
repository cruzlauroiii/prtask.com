namespace WillowMaze.Wasm.Decompiled;


readonly class GeneratedMessageLite$ExtensionDescriptor : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> {
    readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<object> enumTypeDictionary;
    readonly bool isPacked;
    readonly bool isRepeated;
    readonly int number;
    readonly androidx.datastore.preferences.protobuf.WireFormat$FieldType type;

    GeneratedMessageLite$ExtensionDescriptor(androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<object> internal$EnumLiteDictionary, int i, androidx.datastore.preferences.protobuf.WireFormat$FieldType wireFormat$FieldType, bool z, bool z2) {
        this.enumTypeDictionary = internal$EnumLiteDictionary;
        this.number = i;
        this.type = wireFormat$FieldType;
        this.isRepeated = z;
        this.isPacked = z2;
    }

    public int CompareTo(androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor generatedMessageLite$ExtensionDescriptor) {
        return this.number - generatedMessageLite$ExtensionDescriptor.number;
    }

    public override int CompareTo(java.lang.object obj) {
        return compareTo((androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor) obj);
    }

    public androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<object> getEnumType() {
        return this.enumTypeDictionary;
    }

    public androidx.datastore.preferences.protobuf.WireFormat$JavaType getLiteJavaType() {
        return this.type.getJavaType();
    }

    public androidx.datastore.preferences.protobuf.WireFormat$FieldType getLiteType() {
        return this.type;
    }

    public override int GetNumber() {
        return this.number;
    }

    public androidx.datastore.preferences.protobuf.MessageLite$Builder internalMergeFrom(androidx.datastore.preferences.protobuf.MessageLite$Builder messageLite$Builder, androidx.datastore.preferences.protobuf.MessageLite messageLite) {
        return ((androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder) messageLite$Builder).mergeFrom((androidx.datastore.preferences.protobuf.GeneratedMessageLite) messageLite);
    }

    public override bool IsPacked() {
        return this.isPacked;
    }

    public override bool IsRepeated() {
        return this.isRepeated;
    }
}

