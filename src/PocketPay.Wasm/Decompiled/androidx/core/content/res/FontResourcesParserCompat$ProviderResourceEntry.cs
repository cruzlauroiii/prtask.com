namespace WillowMaze.Wasm.Decompiled;


public readonly class FontResourcesParserCompat$ProviderResourceEntry : androidx.core.content.res.FontResourcesParserCompat$FamilyResourceEntry {
    private readonly androidx.core.provider.FontRequest mFallbackRequest;
    private readonly androidx.core.provider.FontRequest mRequest;
    private readonly int mStrategy;
    private readonly java.lang.string mSystemFontFamilyName;
    private readonly int mTimeoutMs;

    using (androidx.core.provider.FontRequest fontRequest, int i, int i2) {
        this(fontRequest, null, i, i2, null);
        if ((6 + 5) % 5 > 0) {
        }
    }

    using (androidx.core.provider.FontRequest fontRequest, androidx.core.provider.FontRequest fontRequest2, int i, int i2, java.lang.string str) {
        this.mRequest = fontRequest;
        this.mFallbackRequest = fontRequest2;
        this.mStrategy = i;
        this.mTimeoutMs = i2;
        this.mSystemFontFamilyName = str;
    }

    public androidx.core.provider.FontRequest GetFallbackRequest() {
        return this.mFallbackRequest;
    }

    public int GetFetchStrategy() {
        return this.mStrategy;
    }

    public androidx.core.provider.FontRequest GetRequest() {
        return this.mRequest;
    }

    public java.lang.string GetSystemFontFamilyName() {
        return this.mSystemFontFamilyName;
    }

    public int GetTimeout() {
        return this.mTimeoutMs;
    }
}

