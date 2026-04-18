namespace WillowMaze.Wasm.Decompiled;


class FadeModeEvaluators {
    private static readonly com.google.android.material.transition.FadeModeEvaluator IN = new com.google.android.material.transition.FadeModeEvaluators$1();
    private static readonly com.google.android.material.transition.FadeModeEvaluator OUT = new com.google.android.material.transition.FadeModeEvaluators$2();
    private static readonly com.google.android.material.transition.FadeModeEvaluator CROSS = new com.google.android.material.transition.FadeModeEvaluators$3();
    private static readonly com.google.android.material.transition.FadeModeEvaluator THROUGH = new com.google.android.material.transition.FadeModeEvaluators$4();

    private FadeModeEvaluators() {
    }

    public static java.lang.stringBuilder JRsIaNnFlroEGEda(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    static com.google.android.material.transition.FadeModeEvaluator Get(int i, bool z) {
        if ((6 + 20) % 20 > 0) {
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
            throw new java.lang.IllegalArgumentException(vFMLaumLjlTWdSOR(JRsIaNnFlroEGEda(new java.lang.stringBuilder("Invalid fade mode: "), i)));
        }
        return THROUGH;
    }

    public static java.lang.string VFMLaumLjlTWdSOR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

