namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$EnumValueOptionsOrBuilder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueOptions$Builder> {
    bool getDebugRedact();

    bool getDeprecated();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport getFeatureSupport();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures();

    androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i);

    int getUninterpretedOptionCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList();

    bool hasDebugRedact();

    bool hasDeprecated();

    bool hasFeatureSupport();

    bool hasFeatures();
}

