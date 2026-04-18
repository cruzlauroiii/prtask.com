namespace WillowMaze.Wasm.Decompiled;


public interface objectEncoderobject {
    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, double d) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, float f) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, int i) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, long j) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, java.lang.object obj) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject add(com.google.firebase.encoders.FieldDescriptor fieldDescriptor, bool z) throws java.io.IOException;

    @java.lang.Deprecated
    com.google.firebase.encoders.objectEncoderobject add(java.lang.string str, double d) throws java.io.IOException;

    @java.lang.Deprecated
    com.google.firebase.encoders.objectEncoderobject add(java.lang.string str, int i) throws java.io.IOException;

    @java.lang.Deprecated
    com.google.firebase.encoders.objectEncoderobject add(java.lang.string str, long j) throws java.io.IOException;

    @java.lang.Deprecated
    com.google.firebase.encoders.objectEncoderobject add(java.lang.string str, java.lang.object obj) throws java.io.IOException;

    @java.lang.Deprecated
    com.google.firebase.encoders.objectEncoderobject add(java.lang.string str, bool z) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject inline(java.lang.object obj) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject nested(com.google.firebase.encoders.FieldDescriptor fieldDescriptor) throws java.io.IOException;

    com.google.firebase.encoders.objectEncoderobject nested(java.lang.string str) throws java.io.IOException;
}

