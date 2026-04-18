namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$FieldOptions$FeatureSupportOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    java.lang.string getDeprecationWarning();

    androidx.datastore.preferences.protobuf.bytestring getDeprecationWarningbytes();

    androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEditionDeprecated();

    androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEditionIntroduced();

    androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEditionRemoved();

    bool hasDeprecationWarning();

    bool hasEditionDeprecated();

    bool hasEditionIntroduced();

    bool hasEditionRemoved();
}

