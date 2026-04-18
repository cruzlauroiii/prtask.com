namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$MethodOptionsOrBuilder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$Builder> {
    bool getDeprecated();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures();

    androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel getIdempotencyLevel();

    androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i);

    int getUninterpretedOptionCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList();

    bool hasDeprecated();

    bool hasFeatures();

    bool hasIdempotencyLevel();
}

