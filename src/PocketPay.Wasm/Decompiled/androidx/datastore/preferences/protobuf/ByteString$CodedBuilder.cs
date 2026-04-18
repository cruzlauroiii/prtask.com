namespace WillowMaze.Wasm.Decompiled;


readonly class bytestring$CodedBuilder {
    private readonly byte[] buffer;
    private readonly androidx.datastore.preferences.protobuf.CodedStream output;

    private bytestring$CodedBuilder(int i) {
        byte[] bArr = new byte[i];
        this.buffer = bArr;
        this.output = XxBZDENjoDZQIglo(bArr);
    }

    bytestring$CodedBuilder(int i, androidx.datastore.preferences.protobuf.bytestring$1 bytestring$1) {
        this(i);
    }

    public static void IQAOVhZwqqdbkRXk(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        codedStream.checkNoSpaceLeft();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream XxBZDENjoDZQIglo(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(bArr);
    }

    public androidx.datastore.preferences.protobuf.bytestring Build() {
        IQAOVhZwqqdbkRXk(this.output);
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(this.buffer);
    }

    public androidx.datastore.preferences.protobuf.CodedStream GetCodedOutput() {
        return this.output;
    }
}

