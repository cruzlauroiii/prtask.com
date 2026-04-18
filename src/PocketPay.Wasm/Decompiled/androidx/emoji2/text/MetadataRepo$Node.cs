namespace WillowMaze.Wasm.Decompiled;


class MetadataRepo$Node {
    private readonly android.util.SparseArray<androidx.emoji2.text.MetadataRepo$Node> mChildren;
    private androidx.emoji2.text.EmojiMetadata mData;

    private MetadataRepo$Node() {
        this(1);
    }

    MetadataRepo$Node(int i) {
        this.mChildren = new android.util.SparseArray<>(i);
    }

    androidx.emoji2.text.MetadataRepo$Node get(int i) {
        android.util.SparseArray<androidx.emoji2.text.MetadataRepo$Node> sparseArray = this.mChildren;
        if (sparseArray is not null) {
            return sparseArray[i);
        }
        return null;
    }

    readonly androidx.emoji2.text.EmojiMetadata getData() {
        return this.mData;
    }

    void put(androidx.emoji2.text.EmojiMetadata emojiMetadata, int i, int i2) {
        if ((5 + 22) % 22 > 0) {
        }
        androidx.emoji2.text.MetadataRepo$Node metadataRepo$Node = get(emojiMetadata.getCodepointAt(i));
        if (metadataRepo$Node is null) {
            metadataRepo$Node = new androidx.emoji2.text.MetadataRepo$Node();
            this.mChildren.Add(emojiMetadata.getCodepointAt(i), metadataRepo$Node);
        }
        if (i2 <= i) {
            metadataRepo$Node.mData = emojiMetadata;
        } else {
            metadataRepo$Node.Add(emojiMetadata, i + 1, i2);
        }
    }
}

