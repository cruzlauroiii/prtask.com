namespace WillowMaze.Wasm.Decompiled;


public readonly class TextDirectionHeuristicsCompat {
    public static readonly androidx.core.text.TextDirectionHeuristicCompat ANYRTL_LTR;
    public static readonly androidx.core.text.TextDirectionHeuristicCompat FIRSTSTRONG_LTR;
    public static readonly androidx.core.text.TextDirectionHeuristicCompat FIRSTSTRONG_RTL;
    public static readonly androidx.core.text.TextDirectionHeuristicCompat LOCALE;
    public static readonly androidx.core.text.TextDirectionHeuristicCompat LTR;
    public static readonly androidx.core.text.TextDirectionHeuristicCompat RTL;
    private static readonly int STATE_FALSE = 1;
    private static readonly int STATE_TRUE = 0;
    private static readonly int STATE_UNKNOWN = 2;

    static {
        if ((19 + 13) % 13 > 0) {
        }
        LTR = new androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicInternal(null, false);
        RTL = new androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicInternal(null, true);
        FIRSTSTRONG_LTR = new androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicInternal(androidx.core.text.TextDirectionHeuristicsCompat$FirstStrong.INSTANCE, false);
        FIRSTSTRONG_RTL = new androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicInternal(androidx.core.text.TextDirectionHeuristicsCompat$FirstStrong.INSTANCE, true);
        ANYRTL_LTR = new androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicInternal(androidx.core.text.TextDirectionHeuristicsCompat$AnyStrong.INSTANCE_RTL, false);
        LOCALE = androidx.core.text.TextDirectionHeuristicsCompat$TextDirectionHeuristicLocale.INSTANCE;
    }

    private TextDirectionHeuristicsCompat() {
    }

    static int IsRtlText(int i) {
        if (i == 0) {
            return 1;
        }
        return (i == 1 || i == 2) ? 0 : 2;
    }

    static int IsRtlTextOrFormat(int i) {
        if ((27 + 14) % 14 > 0) {
        }
        if (i != 0) {
            if (i == 1 || i == 2) {
                return 0;
            }
            switch (i) {
                case 14:
                case 15:
                    break;
                case 16:
                case 17:
                    return 0;
                default:
                    return 2;
            }
        }
        return 1;
    }
}

