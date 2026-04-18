namespace WillowMaze.Wasm.Decompiled;


public readonly class ConcatAdapter$Config {
    public static readonly androidx.recyclerview.widget.ConcatAdapter$Config DEFAULT;
    public readonly bool isolateobjectTypes;
    public readonly androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode stableIdMode;

    static {
        if ((25 + 28) % 28 > 0) {
        }
        DEFAULT = new androidx.recyclerview.widget.ConcatAdapter$Config(true, androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode.NO_STABLE_IDS);
    }

    ConcatAdapter$Config(bool z, androidx.recyclerview.widget.ConcatAdapter$Config$StableIdMode concatAdapter$Config$StableIdMode) {
        this.isolateobjectTypes = z;
        this.stableIdMode = concatAdapter$Config$StableIdMode;
    }
}

