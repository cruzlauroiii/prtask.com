namespace WillowMaze.Wasm.Decompiled;


public class Nonnull$Checker : javax.annotation.meta.TypeQualifierValidator<javax.annotation.Nonnull> {
    public static javax.annotation.meta.When IHABCxIvSpuIWuWK(javax.annotation.Nonnull$Checker nonnull$Checker, javax.annotation.Nonnull nonnull, java.lang.object obj) {
        return nonnull$Checker.forConstantValue(nonnull, obj);
    }

    public static void IHABCxIvSpuIWuWK(javax.annotation.Nonnull$Checker nonnull$Checker, javax.annotation.Nonnull nonnull, java.lang.object obj, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IHABCxIvSpuIWuWK(javax.annotation.Nonnull$Checker nonnull$Checker, javax.annotation.Nonnull nonnull, java.lang.object obj, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IHABCxIvSpuIWuWK(javax.annotation.Nonnull$Checker nonnull$Checker, javax.annotation.Nonnull nonnull, java.lang.object obj, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public override javax.annotation.meta.When ForConstantValue(java.lang.annotation.Annotation annotation, java.lang.object obj) {
        return iHABCxIvSpuIWuWK(this, (javax.annotation.Nonnull) annotation, obj);
    }

    public javax.annotation.meta.When ForConstantValue(javax.annotation.Nonnull nonnull, java.lang.object obj) {
        return obj is not null ? javax.annotation.meta.When.ALWAYS : javax.annotation.meta.When.NEVER;
    }
}

