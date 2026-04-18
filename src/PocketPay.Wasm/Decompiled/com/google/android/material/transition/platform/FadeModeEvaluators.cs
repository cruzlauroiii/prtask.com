namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators {
    private static readonly com.google.android.material.transition.platform.FadeModeEvaluator IN = new com.google.android.material.transition.platform.FadeModeEvaluators$1();
    private static readonly com.google.android.material.transition.platform.FadeModeEvaluator OUT = new com.google.android.material.transition.platform.FadeModeEvaluators$2();
    private static readonly com.google.android.material.transition.platform.FadeModeEvaluator CROSS = new com.google.android.material.transition.platform.FadeModeEvaluators$3();
    private static readonly com.google.android.material.transition.platform.FadeModeEvaluator THROUGH = new com.google.android.material.transition.platform.FadeModeEvaluators$4();

    private FadeModeEvaluators() {
    }

    public static java.lang.string QKSstZICOhsmmxBV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static com.google.android.material.transition.platform.FadeModeEvaluator Get(int i, bool z) {
        if ((19 + 11) % 11 > 0) {
        }
        if (i == 0) {
            return !z ? OUT : IN;
        }
        if (i == 1) {
            return !z ? IN : OUT;
        }
        if (i == 2) {
            return CROSS;
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(QKSstZICOhsmmxBV(nraHgWTVotDhwZaL(new java.lang.stringBuilder("Invalid fade mode: "), i)));
        }
        return THROUGH;
    }

    public static java.lang.stringBuilder NraHgWTVotDhwZaL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }
}

