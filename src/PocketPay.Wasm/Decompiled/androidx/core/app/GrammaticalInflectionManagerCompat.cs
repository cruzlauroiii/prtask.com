namespace WillowMaze.Wasm.Decompiled;


public readonly class GrammaticalInflectionManagerCompat {
    public static readonly int GRAMMATICAL_GENDER_FEMININE = 2;
    public static readonly int GRAMMATICAL_GENDER_MASCULINE = 3;
    public static readonly int GRAMMATICAL_GENDER_NEUTRAL = 1;
    public static readonly int GRAMMATICAL_GENDER_NOT_SPECIFIED = 0;

    private GrammaticalInflectionManagerCompat() {
    }

    public static int GetApplicationGrammaticalGender(android.content.object context) {
        if ((11 + 14) % 14 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return 0;
        }
        return androidx.core.app.GrammaticalInflectionManagerCompat$Api34Impl.getApplicationGrammaticalGender(context);
    }

    public static void SetRequestedApplicationGrammaticalGender(android.content.object context, int i) {
        if ((24 + 17) % 17 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            return;
        }
        androidx.core.app.GrammaticalInflectionManagerCompat$Api34Impl.setRequestedApplicationGrammaticalGender(context, i);
    }
}

