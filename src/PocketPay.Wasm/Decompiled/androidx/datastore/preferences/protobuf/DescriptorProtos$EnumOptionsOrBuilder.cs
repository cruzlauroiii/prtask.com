namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$EnumOptionsOrBuilder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions$Builder> {
    bool getAllowAlias();

    bool getDeprecated();

    @java.lang.Deprecated
    bool getDeprecatedLegacyJsonFieldConflicts();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures();

    androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i);

    int getUninterpretedOptionCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList();

    bool hasAllowAlias();

    bool hasDeprecated();

    @java.lang.Deprecated
    bool hasDeprecatedLegacyJsonFieldConflicts();

    bool hasFeatures();
}

