namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$ServiceDescriptorProtoOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto getMethod(int i);

    int getMethodCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodDescriptorProto> getMethodList();

    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceOptions getOptions();

    bool hasName();

    bool hasOptions();
}

