namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$ServiceOptionsOrBuilder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessageOrBuilder<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions$Builder> {
    bool getDeprecated();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getFeatures();

    androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getUninterpretedOption(int i);

    int getUninterpretedOptionCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> getUninterpretedOptionList();

    bool hasDeprecated();

    bool hasFeatures();
}

