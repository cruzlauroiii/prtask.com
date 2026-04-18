namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class RegexKt$fromInt$1$1<T> : kotlin.jvm.functions.Function1<T, java.lang.bool> {
    readonly int $value;

    public RegexKt$fromInt$1$1(int i) {
        this.$value = i;
    }

    public static java.lang.bool BXVVesNXvWDXyYQW(kotlin.text.RegexKt$fromInt$1$1 regexKt$fromInt$1$1, java.lang.Enum r2) {
        return regexKt$fromInt$1$1.invoke(r2);
    }

    public static void BXVVesNXvWDXyYQW(kotlin.text.RegexKt$fromInt$1$1 regexKt$fromInt$1$1, java.lang.Enum r1, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BXVVesNXvWDXyYQW(kotlin.text.RegexKt$fromInt$1$1 regexKt$fromInt$1$1, java.lang.Enum r1, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BXVVesNXvWDXyYQW(kotlin.text.RegexKt$fromInt$1$1 regexKt$fromInt$1$1, java.lang.Enum r1, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XpbvxfRlnPZSKUva(kotlin.text.FlagEnum flagEnum) {
        return flagEnum.getValue();
    }

    public static void XpbvxfRlnPZSKUva(kotlin.text.FlagEnum flagEnum, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XpbvxfRlnPZSKUva(kotlin.text.FlagEnum flagEnum, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XpbvxfRlnPZSKUva(kotlin.text.FlagEnum flagEnum, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ACewUhoCSzoMDYdY(kotlin.text.FlagEnum flagEnum) {
        return flagEnum.getMask();
    }

    public static void ACewUhoCSzoMDYdY(kotlin.text.FlagEnum flagEnum, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACewUhoCSzoMDYdY(kotlin.text.FlagEnum flagEnum, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ACewUhoCSzoMDYdY(kotlin.text.FlagEnum flagEnum, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool EaFKKlTfLHNecPds(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void EaFKKlTfLHNecPds(bool z, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EaFKKlTfLHNecPds(bool z, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EaFKKlTfLHNecPds(bool z, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public readonly java.lang.bool Invoke(java.lang.Enum r2) {
        kotlin.text.FlagEnum flagEnum = (kotlin.text.FlagEnum) r2;
        return eaFKKlTfLHNecPds((this.$value & aCewUhoCSzoMDYdY(flagEnum)) == XpbvxfRlnPZSKUva(flagEnum));
    }

    public override java.lang.bool Invoke(java.lang.object obj) {
        return BXVVesNXvWDXyYQW(this, (java.lang.Enum) obj);
    }
}

