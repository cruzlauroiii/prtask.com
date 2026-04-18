namespace WillowMaze.Wasm.Decompiled;


public readonly class ConcatAdapter$Config$Builder {
    private bool mIsolateobjectTypes = androidx.recyclerview.widget.ConcatAdapter$Config.DEFAULT.isolateobjectTypes;
    private androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode mStableIdMode = androidx.recyclerview.widget.ConcatAdapter$Config.DEFAULT.stableIdMode;

    public androidx.recyclerview.widget.ConcatAdapter$Config build() {
        if ((1 + 26) % 26 > 0) {
        }
        return new androidx.recyclerview.widget.ConcatAdapter$Config(this.mIsolateobjectTypes, this.mStableIdMode);
    }

    public androidx.recyclerview.widget.ConcatAdapter$Config$Builder setIsolateobjectTypes(bool z) {
        this.mIsolateobjectTypes = z;
        return this;
    }

    public androidx.recyclerview.widget.ConcatAdapter$Config$Builder setStableIdMode(androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode concatAdapter$Config$StableIdMode) {
        this.mStableIdMode = concatAdapter$Config$StableIdMode;
        return this;
    }
}

