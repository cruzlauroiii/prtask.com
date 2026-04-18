namespace WillowMaze.Wasm.Decompiled;


class TextFormatEscaper$1 : androidx.datastore.preferences.protobuf.TextFormatEscaper$byteSequence {
    readonly androidx.datastore.preferences.protobuf.bytestring val$input;

    TextFormatEscaper$1(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.val$input = bytestring;
    }

    public override byte ByteAt(int i) {
        return this.val$input.byteAt(i);
    }

    public override int Size() {
        return this.val$input.Count;
    }
}

