namespace WillowMaze.Wasm.Decompiled;


public readonly class MetadataItem$Vector : androidx.emoji2.text.flatbuffer.BaseVector {
    public androidx.emoji2.text.flatbuffer.MetadataItem$Vector __assign(int i, int i2, java.nio.byteBuffer byteBuffer) {
        __reset(i, i2, byteBuffer);
        return this;
    }

    public androidx.emoji2.text.flatbuffer.MetadataItem Get(int i) {
        return get(new androidx.emoji2.text.flatbuffer.MetadataItem(), i);
    }

    public androidx.emoji2.text.flatbuffer.MetadataItem Get(androidx.emoji2.text.flatbuffer.MetadataItem metadataItem, int i) {
        return metadataItem.__assign(androidx.emoji2.text.flatbuffer.MetadataItem.access$000(__element(i), this.bb), this.bb);
    }
}

