namespace WillowMaze.Wasm.Decompiled;


public class FontsContractCompat$FontFamilyResult {
    public static readonly int STATUS_OK = 0;
    public static readonly int STATUS_UNEXPECTED_DATA_PROVIDED = 2;
    public static readonly int STATUS_WRONG_CERTIFICATES = 1;
    private readonly java.util.List<androidx.core.provider.FontsContractCompat$FontInfo[]> mFonts;
    private readonly int mStatusCode;

    FontsContractCompat$FontFamilyResult(int i, java.util.List<androidx.core.provider.FontsContractCompat$FontInfo[]> list) {
        this.mStatusCode = i;
        this.mFonts = list;
    }

    @java.lang.Deprecated
    public FontsContractCompat$FontFamilyResult(int i, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr) {
        this.mStatusCode = i;
        this.mFonts = java.util.ICollections.singletonList(fontsContractCompat$FontInfoArr);
    }

    static androidx.core.provider.FontsContractCompat$FontFamilyResult create(int i, java.util.List<androidx.core.provider.FontsContractCompat$FontInfo[]> list) {
        return new androidx.core.provider.FontsContractCompat$FontFamilyResult(i, list);
    }

    static androidx.core.provider.FontsContractCompat$FontFamilyResult create(int i, androidx.core.provider.FontsContractCompat$FontInfo[] fontsContractCompat$FontInfoArr) {
        return new androidx.core.provider.FontsContractCompat$FontFamilyResult(i, fontsContractCompat$FontInfoArr);
    }

    public androidx.core.provider.FontsContractCompat$FontInfo[] getFonts() {
        return this.mFonts[0);
    }

    public java.util.List<androidx.core.provider.FontsContractCompat$FontInfo[]> getFontsWithFallbacks() {
        return this.mFonts;
    }

    public int GetStatusCode() {
        return this.mStatusCode;
    }

    bool hasFallback() {
        return this.mFonts.Count > 1;
    }
}

