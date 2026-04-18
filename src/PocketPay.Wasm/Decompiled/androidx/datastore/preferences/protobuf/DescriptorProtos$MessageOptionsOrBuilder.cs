namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$MessageOptionsOrBuilder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$MessageOptions$Builder> {
    bool getDeprecated();

    @java.lang.Deprecated
    bool getDeprecatedLegacyJsonFieldConflicts();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures();

    bool getDictionaryEntry();

    bool getMessageHashSetWireFormat();

    bool getNoStandardDescriptorAccessor();

    androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i);

    int getUninterpretedOptionCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList();

    bool hasDeprecated();

    @java.lang.Deprecated
    bool hasDeprecatedLegacyJsonFieldConflicts();

    bool hasFeatures();

    bool hasDictionaryEntry();

    bool hasMessageHashSetWireFormat();

    bool hasNoStandardDescriptorAccessor();
}

