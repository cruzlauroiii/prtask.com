namespace WillowMaze.Wasm.Decompiled;


public interface DescriptorProtos$SourceCodeInfo$LocationOrBuilder : androidx.datastore.preferences.protobuf.MessageLiteOrBuilder {
    java.lang.string getLeadingComments();

    androidx.datastore.preferences.protobuf.bytestring getLeadingCommentsbytes();

    java.lang.string getLeadingDetachedComments(int i);

    androidx.datastore.preferences.protobuf.bytestring getLeadingDetachedCommentsbytes(int i);

    int getLeadingDetachedCommentsCount();

    java.util.List<java.lang.string> getLeadingDetachedCommentsList();

    int getPath(int i);

    int getPathCount();

    java.util.List<java.lang.int> getPathList();

    int getSpan(int i);

    int getSpanCount();

    java.util.List<java.lang.int> getSpanList();

    java.lang.string getTrailingComments();

    androidx.datastore.preferences.protobuf.bytestring getTrailingCommentsbytes();

    bool hasLeadingComments();

    bool hasTrailingComments();
}

