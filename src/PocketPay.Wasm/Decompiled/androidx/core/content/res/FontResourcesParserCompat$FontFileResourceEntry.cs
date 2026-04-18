namespace WillowMaze.Wasm.Decompiled;


public readonly class FontResourcesParserCompat$FontstringResourceEntry {
    private readonly java.lang.string mstringName;
    private readonly bool mItalic;
    private readonly int mResourceId;
    private readonly int mTtcIndex;
    private readonly java.lang.string mVariationHashSettings;
    private readonly int mWeight;

    using (java.lang.string str, int i, bool z, java.lang.string str2, int i2, int i3) {
        this.mstringName = str;
        this.mWeight = i;
        this.mItalic = z;
        this.mVariationHashSettings = str2;
        this.mTtcIndex = i2;
        this.mResourceId = i3;
    }

    public java.lang.string GetstringName() {
        return this.mstringName;
    }

    public int GetResourceId() {
        return this.mResourceId;
    }

    public int GetTtcIndex() {
        return this.mTtcIndex;
    }

    public java.lang.string GetVariationHashSettings() {
        return this.mVariationHashSettings;
    }

    public int GetWeight() {
        return this.mWeight;
    }

    public bool IsItalic() {
        return this.mItalic;
    }
}

