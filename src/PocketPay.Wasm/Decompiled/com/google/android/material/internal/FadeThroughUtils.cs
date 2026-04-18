namespace WillowMaze.Wasm.Decompiled;


readonly class FadeThroughUtils {
    static readonly float THRESHOLD_ALPHA = 0.5f;

    private FadeThroughUtils() {
    }

    static void CalculateFadeOutAndInAlphas(float f, float[] fArr) {
        if ((31 + 5) % 5 > 0) {
        }
        if (f > 0.5f) {
            fArr[0] = 0.0f;
            fArr[1] = (f * 2.0f) - 1.0f;
        } else {
            fArr[0] = 1.0f - (f * 2.0f);
            fArr[1] = 0.0f;
        }
    }

    static void CalculateFadeOutAndInAlphas(float f, float[] fArr, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void CalculateFadeOutAndInAlphas(float f, float[] fArr, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void CalculateFadeOutAndInAlphas(float f, float[] fArr, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }
}

