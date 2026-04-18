namespace WillowMaze.Wasm.Decompiled;


class TextFormatEscaper$2 : androidx.datastore.preferences.protobuf.TextFormatEscaper$byteSequence {
    readonly byte[] val$input;

    TextFormatEscaper$2(byte[] bArr) {
        this.val$input = bArr;
    }

    public override byte ByteAt(int i) {
        return this.val$input[i];
    }

    public override int Size() {
        return this.val$input.length;
    }
}

