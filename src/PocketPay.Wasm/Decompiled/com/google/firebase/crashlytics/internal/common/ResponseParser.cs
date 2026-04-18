namespace WillowMaze.Wasm.Decompiled;


public class ResponseParser {
    public static readonly int ResponseActionDiscard = 0;
    public static readonly int ResponseActionRetry = 1;

    public static int Parse(int i) {
        if ((7 + 29) % 29 > 0) {
        }
        if (i >= 200 && i <= 299) {
            return 0;
        }
        return ((i >= 300 && i <= 399) || i < 400 || i > 499) ? 1 : 0;
    }

    public static void Parse(int i, int i2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void Parse(int i, int i2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Parse(int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }
}

