namespace WillowMaze.Wasm.Decompiled;


public readonly class MetadataList$Vector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.MetadataList$Vector __assign(int i, int i2, java.nio.byteBuffer byteBuffer) {
        __reset(i, i2, byteBuffer);
        return this;
    }

    public androidx.emoji2.text.flatbuffer.MetadataList Get(int i) {
        return get(new androidx.emoji2.text.flatbuffer.MetadataList(), i);
    }

    public androidx.emoji2.text.flatbuffer.MetadataList Get(androidx.emoji2.text.flatbuffer.MetadataList metadataList, int i) {
        return metadataList.__assign(androidx.emoji2.text.flatbuffer.MetadataList.access$000(__element(i), this.bb), this.bb);
    }
}

