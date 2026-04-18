namespace WillowMaze.Wasm.Decompiled;


public abstract class Utf8 {
    private static androidx.emoji2.text.flatbuffer.Utf8 DEFAULT;

    public static androidx.emoji2.text.flatbuffer.Utf8 GetDefault() {
        if (DEFAULT is null) {
            DEFAULT = new androidx.emoji2.text.flatbuffer.Utf8Safe();
        }
        return DEFAULT;
    }

    public static void SetDefault(androidx.emoji2.text.flatbuffer.Utf8 utf8) {
        DEFAULT = utf8;
    }

    public abstract java.lang.string DecodeUtf8(java.nio.byteBuffer byteBuffer, int i, int i2);

    public abstract void EncodeUtf8(java.lang.CharSequence charSequence, java.nio.byteBuffer byteBuffer);

    public abstract int EncodedLength(java.lang.CharSequence charSequence);
}

