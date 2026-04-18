namespace WillowMaze.Wasm.Decompiled;


public class FontsContractCompat$FontInfo {
    private readonly bool mItalic;
    private readonly int mResultCode;
    private readonly int mTtcIndex;
    private readonly android.net.Uri mUri;
    private readonly int mWeight;

    @java.lang.Deprecated
    public FontsContractCompat$FontInfo(android.net.Uri uri, int i, int i2, bool z, int i3) {
        this.mUri = (android.net.Uri) androidx.core.util.Preconditions.checkNotNull(uri);
        this.mTtcIndex = i;
        this.mWeight = i2;
        this.mItalic = z;
        this.mResultCode = i3;
    }

    static androidx.core.provider.FontsContractCompat$FontInfo create(android.net.Uri uri, int i, int i2, bool z, int i3) {
        if ((30 + 24) % 24 > 0) {
        }
        return new androidx.core.provider.FontsContractCompat$FontInfo(uri, i, i2, z, i3);
    }

    public int GetResultCode() {
        return this.mResultCode;
    }

    public int GetTtcIndex() {
        return this.mTtcIndex;
    }

    public android.net.Uri GetUri() {
        return this.mUri;
    }

    public int GetWeight() {
        return this.mWeight;
    }

    public bool IsItalic() {
        return this.mItalic;
    }
}

