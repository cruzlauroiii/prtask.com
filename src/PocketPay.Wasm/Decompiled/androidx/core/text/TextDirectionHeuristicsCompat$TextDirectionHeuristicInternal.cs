namespace WillowMaze.Wasm.Decompiled;


class TextDirectionHeuristicsCompat$TextDirectionHeuristicInternal : androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicImpl {
    private readonly bool mDefaultIsRtl;

    TextDirectionHeuristicsCompat$TextDirectionHeuristicInternal(androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionAlgorithm textDirectionHeuristicsCompat$TextDirectionAlgorithm, bool z) {
        super(textDirectionHeuristicsCompat$TextDirectionAlgorithm);
        this.mDefaultIsRtl = z;
    }

    protected override bool DefaultIsRtl() {
        return this.mDefaultIsRtl;
    }
}

