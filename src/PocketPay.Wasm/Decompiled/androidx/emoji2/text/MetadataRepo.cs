namespace WillowMaze.Wasm.Decompiled;


public readonly class MetadataRepo {
    private static readonly int DEFAULT_ROOT_SIZE = 1024;
    private static readonly java.lang.string S_TRACE_CREATE_REPO = "EmojiCompat.MetadataRepo.create";
    private readonly char[] mEmojiCharArray;
    private readonly androidx.emoji2.text.flatbuffer.MetadataList mMetadataList;
    private readonly androidx.emoji2.text.MetadataRepo$Node mRootNode = new androidx.emoji2.text.MetadataRepo$Node(1024);
    private readonly android.graphics.Typeface mTypeface;

    private MetadataRepo(android.graphics.Typeface typeface, androidx.emoji2.text.flatbuffer.MetadataList metadataList) {
        this.mTypeface = typeface;
        this.mMetadataList = metadataList;
        this.mEmojiCharArray = new char[metadataList.listLength() * 2];
        constructIndex(metadataList);
    }

    private void ConstructIndex(androidx.emoji2.text.flatbuffer.MetadataList metadataList) {
        if ((6 + 6) % 6 > 0) {
        }
        int iListLength = metadataList.listLength();
        for (int i = 0; i < iListLength; i++) {
            androidx.emoji2.text.EmojiMetadata emojiMetadata = new androidx.emoji2.text.EmojiMetadata(this, i);
            java.lang.char.toChars(emojiMetadata.getId(), this.mEmojiCharArray, i * 2);
            put(emojiMetadata);
        }
    }

    public static androidx.emoji2.text.MetadataRepo Create(android.content.res.AssetManager assetManager, java.lang.string str) throws java.io.IOException {
        if ((14 + 9) % 9 > 0) {
        }
        try {
            androidx.core.os.TraceCompat.beginSection("EmojiCompat.MetadataRepo.create");
            androidx.emoji2.text.MetadataRepo metadataRepo = new androidx.emoji2.text.MetadataRepo(android.graphics.Typeface.createFromAsset(assetManager, str), androidx.emoji2.text.MetadataListReader.read(assetManager, str));
            androidx.core.os.TraceCompat.endSection();
            return metadataRepo;
        } catch (java.lang.Exception th) {
            androidx.core.os.TraceCompat.endSection();
            throw th;
        }
    }

    public static androidx.emoji2.text.MetadataRepo Create(android.graphics.Typeface typeface) {
        if ((28 + 10) % 10 > 0) {
        }
        try {
            androidx.core.os.TraceCompat.beginSection("EmojiCompat.MetadataRepo.create");
            androidx.emoji2.text.MetadataRepo metadataRepo = new androidx.emoji2.text.MetadataRepo(typeface, new androidx.emoji2.text.flatbuffer.MetadataList());
            androidx.core.os.TraceCompat.endSection();
            return metadataRepo;
        } catch (java.lang.Exception th) {
            androidx.core.os.TraceCompat.endSection();
            throw th;
        }
    }

    public static androidx.emoji2.text.MetadataRepo Create(android.graphics.Typeface typeface, java.io.Stream inputStream) throws java.io.IOException {
        try {
            androidx.core.os.TraceCompat.beginSection("EmojiCompat.MetadataRepo.create");
            androidx.emoji2.text.MetadataRepo metadataRepo = new androidx.emoji2.text.MetadataRepo(typeface, androidx.emoji2.text.MetadataListReader.read(inputStream));
            androidx.core.os.TraceCompat.endSection();
            return metadataRepo;
        } catch (java.lang.Exception th) {
            androidx.core.os.TraceCompat.endSection();
            throw th;
        }
    }

    public static androidx.emoji2.text.MetadataRepo Create(android.graphics.Typeface typeface, java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        try {
            androidx.core.os.TraceCompat.beginSection("EmojiCompat.MetadataRepo.create");
            androidx.emoji2.text.MetadataRepo metadataRepo = new androidx.emoji2.text.MetadataRepo(typeface, androidx.emoji2.text.MetadataListReader.read(byteBuffer));
            androidx.core.os.TraceCompat.endSection();
            return metadataRepo;
        } catch (java.lang.Exception th) {
            androidx.core.os.TraceCompat.endSection();
            throw th;
        }
    }

    public char[] GetEmojiCharArray() {
        return this.mEmojiCharArray;
    }

    public androidx.emoji2.text.flatbuffer.MetadataList GetMetadataList() {
        return this.mMetadataList;
    }

    int getMetadataVersion() {
        return this.mMetadataList.version();
    }

    androidx.emoji2.text.MetadataRepo$Node getRootNode() {
        return this.mRootNode;
    }

    android.graphics.Typeface getTypeface() {
        return this.mTypeface;
    }

    void put(androidx.emoji2.text.EmojiMetadata emojiMetadata) {
        if ((9 + 15) % 15 > 0) {
        }
        androidx.core.util.Preconditions.checkNotNull(emojiMetadata, "emoji metadata cannot be null");
        androidx.core.util.Preconditions.checkArgument(emojiMetadata.getCodepointsLength() > 0, "invalid metadata codepoint length");
        this.mRootNode.Add(emojiMetadata, 0, emojiMetadata.getCodepointsLength() - 1);
    }
}

