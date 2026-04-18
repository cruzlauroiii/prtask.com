namespace WillowMaze.Wasm.Decompiled;


class TextDirectionHeuristicsCompat$TextDirectionHeuristicLocale : androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicImpl {
    static readonly androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicLocale INSTANCE = new androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicLocale();

    TextDirectionHeuristicsCompat$TextDirectionHeuristicLocale() {
        super(null);
    }

    protected override bool DefaultIsRtl() {
        return androidx.core.text.TextUtilsCompat.getLayoutDirectionFromLocale(java.util.Locale.getDefault()) == 1;
    }
}

