namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$FieldOptionsOrBuilder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder> {
    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType getCtype();

    bool getDebugRedact();

    bool getDeprecated();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault getEditionDefaults(int i);

    int getEditionDefaultsCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$EditionDefault> getEditionDefaultsList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$FeatureSupport getFeatureSupport();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType getJstype();

    bool getLazy();

    bool getPacked();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention getRetention();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType getTargets(int i);

    int getTargetsCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionTargetType> getTargetsList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i);

    int getUninterpretedOptionCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList();

    bool getUnverifiedLazy();

    bool getWeak();

    bool hasCtype();

    bool hasDebugRedact();

    bool hasDeprecated();

    bool hasFeatureSupport();

    bool hasFeatures();

    bool hasJstype();

    bool hasLazy();

    bool hasPacked();

    bool hasRetention();

    bool hasUnverifiedLazy();

    bool hasWeak();
}

