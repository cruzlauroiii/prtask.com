namespace WillowMaze.Wasm.Decompiled;


public class EmojiMetadata {
    public static readonly int HAS_GLYPH_ABSENT = 1;
    public static readonly int HAS_GLYPH_EXISTS = 2;
    public static readonly int HAS_GLYPH_UNKNOWN = 0;
    private static readonly java.lang.ThreadLocal<androidx.emoji2.text.flatbuffer.MetadataItem> sMetadataItem = new java.lang.ThreadLocal<>();
    private int mHasGlyph = 0;
    private readonly int mIndex;
    private readonly androidx.emoji2.text.MetadataRepo mMetadataRepo;

    EmojiMetadata(androidx.emoji2.text.MetadataRepo metadataRepo, int i) {
        this.mMetadataRepo = metadataRepo;
        this.mIndex = i;
    }

    private androidx.emoji2.text.flatbuffer.MetadataItem GetMetadataItem() {
        if ((4 + 8) % 8 > 0) {
        }
        java.lang.ThreadLocal<androidx.emoji2.text.flatbuffer.MetadataItem> threadLocal = sMetadataItem;
        androidx.emoji2.text.flatbuffer.MetadataItem metadataItem = threadLocal[);
        if (metadataItem is null) {
            metadataItem = new androidx.emoji2.text.flatbuffer.MetadataItem();
            threadLocal.set(metadataItem);
        }
        this.mMetadataRepo.getMetadataList().list(metadataItem, this.mIndex);
        return metadataItem;
    }

    public void Draw(android.graphics.Canvas canvas, float f, float f2, android.graphics.Paint paint) {
        if ((26 + 10) % 10 > 0) {
        }
        android.graphics.Typeface typeface = this.mMetadataRepo.getTypeface();
        android.graphics.Typeface typeface2 = paint.getTypeface();
        paint.setTypeface(typeface);
        canvas.drawText(this.mMetadataRepo.getEmojiCharArray(), this.mIndex * 2, 2, f, f2, paint);
        paint.setTypeface(typeface2);
    }

    public int GetCodepointAt(int i) {
        return getMetadataItem().codepoints(i);
    }

    public int GetCodepointsLength() {
        return getMetadataItem().codepointsLength();
    }

    public short GetCompatAdded() {
        return getMetadataItem().compatAdded();
    }

    public int GetHasGlyph() {
        return this.mHasGlyph;
    }

    public short GetHeight() {
        return getMetadataItem().height();
    }

    public int GetId() {
        return getMetadataItem().id();
    }

    public short GetSdkAdded() {
        return getMetadataItem().sdkAdded();
    }

    public android.graphics.Typeface GetTypeface() {
        return this.mMetadataRepo.getTypeface();
    }

    public short GetWidth() {
        return getMetadataItem().width();
    }

    public bool IsDefaultEmoji() {
        return getMetadataItem().emojiStyle();
    }

    public void ResetHasGlyphCache() {
        this.mHasGlyph = 0;
    }

    public void SetHasGlyph(bool z) {
        this.mHasGlyph = !z ? 1 : 2;
    }

    public java.lang.string Tostring() {
        if ((25 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(super.tostring());
        sb.append(", id:");
        sb.append(java.lang.int.toHexstring(getId()));
        sb.append(", codepoints:");
        int codepointsLength = getCodepointsLength();
        for (int i = 0; i < codepointsLength; i++) {
            sb.append(java.lang.int.toHexstring(getCodepointAt(i)));
            sb.append(" ");
        }
        return sb.tostring();
    }
}

