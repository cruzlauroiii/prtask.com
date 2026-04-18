namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$stringDescriptorProtoOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    java.lang.string getDependency(int i);

    androidx.datastore.preferences.protobuf.bytestring getDependencybytes(int i);

    int getDependencyCount();

    java.util.List<java.lang.string> getDependencyList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEdition();

    androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto getEnumType(int i);

    int getEnumTypeCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> getEnumTypeList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto getExtension(int i);

    int getExtensionCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> getExtensionList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto getMessageType(int i);

    int getMessageTypeCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> getMessageTypeList();

    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions getOptions();

    java.lang.string getPackage();

    androidx.datastore.preferences.protobuf.bytestring getPackagebytes();

    int getPublicDependency(int i);

    int getPublicDependencyCount();

    java.util.List<java.lang.int> getPublicDependencyList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto getService(int i);

    int getServiceCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> getServiceList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo getSourceCodeInfo();

    java.lang.string getSyntax();

    androidx.datastore.preferences.protobuf.bytestring getSyntaxbytes();

    int getWeakDependency(int i);

    int getWeakDependencyCount();

    java.util.List<java.lang.int> getWeakDependencyList();

    bool hasEdition();

    bool hasName();

    bool hasOptions();

    bool hasPackage();

    bool hasSourceCodeInfo();

    bool hasSyntax();
}

