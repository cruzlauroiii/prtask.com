namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$GeneratedCodeInfo$AnnotationOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    int getBegin();

    int getEnd();

    int getPath(int i);

    int getPathCount();

    java.util.List<java.lang.int> getPathList();

    androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic getSemantic();

    java.lang.string getSourcestring();

    androidx.datastore.preferences.protobuf.bytestring getSourcestringbytes();

    bool hasBegin();

    bool hasEnd();

    bool hasSemantic();

    bool hasSourcestring();
}

