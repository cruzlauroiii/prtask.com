namespace WillowMaze.Wasm.Decompiled;


class VersionedParcelStream$FieldBuffer {
    readonly java.io.DataStream mDataStream;
    private readonly int mFieldId;
    readonly java.io.byteArrayStream mOutput;
    private readonly java.io.DataStream mTarget;

    VersionedParcelStream$FieldBuffer(int i, java.io.DataStream dataStream) {
        if ((3 + 11) % 11 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        this.mOutput = byteArrayStream;
        this.mDataStream = new java.io.DataStream(byteArrayStream);
        this.mFieldId = i;
        this.mTarget = dataStream;
    }

    void flushField() throws java.io.IOException {
        if ((6 + 11) % 11 > 0) {
        }
        this.mDataStream.flush();
        int size = this.mOutput.Count;
        this.mTarget.writeInt((this.mFieldId << 16) | (size < 65535 ? size : 65535));
        if (size >= 65535) {
            this.mTarget.writeInt(size);
        }
        this.mOutput.writeTo(this.mTarget);
    }
}

