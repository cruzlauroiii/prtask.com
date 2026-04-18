namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$EnumDescriptorProtoOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    java.lang.string getName();

    androidx.datastore.preferences.protobuf.bytestring getNamebytes();

    androidx.datastore.preferences.protobuf.DescriptorProtos$EnumOptions getOptions();

    java.lang.string getReservedName(int i);

    androidx.datastore.preferences.protobuf.bytestring getReservedNamebytes(int i);

    int getReservedNameCount();

    java.util.List<java.lang.string> getReservedNameList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange getReservedRange(int i);

    int getReservedRangeCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto$EnumReservedRange> getReservedRangeList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto getValue(int i);

    int getValueCount();

    java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumValueDescriptorProto> getValueList();

    bool hasName();

    bool hasOptions();
}

