namespace WillowMaze.Wasm.Decompiled;


class Queuestring$1 : com.google.firebase.crashlytics.internal.metadata.Queuestring$ElementReader {
    bool first = true;
    readonly com.google.firebase.crashlytics.internal.metadata.Queuestring this$0;
    readonly java.lang.stringBuilder val$builder;

    Queuestring$1(com.google.firebase.crashlytics.internal.metadata.Queuestring queuestring, java.lang.stringBuilder sb) {
        this.this$0 = queuestring;
        this.val$builder = sb;
    }

    public static java.lang.stringBuilder FVOdkMWgGOMInGBx(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void FVOdkMWgGOMInGBx(java.lang.stringBuilder sb, int i, float f, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FVOdkMWgGOMInGBx(java.lang.stringBuilder sb, int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FVOdkMWgGOMInGBx(java.lang.stringBuilder sb, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RjmbiSUyWdSKQDjW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RjmbiSUyWdSKQDjW(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RjmbiSUyWdSKQDjW(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RjmbiSUyWdSKQDjW(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Read(java.io.Stream inputStream, int i) throws java.io.IOException {
        if (this.first) {
            this.first = false;
        } else {
            RjmbiSUyWdSKQDjW(this.val$builder, ", ");
        }
        FVOdkMWgGOMInGBx(this.val$builder, i);
    }
}

