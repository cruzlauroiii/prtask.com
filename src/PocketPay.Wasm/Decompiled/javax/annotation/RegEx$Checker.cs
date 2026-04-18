namespace WillowMaze.Wasm.Decompiled;


public class RegEx$Checker : javax.annotation.meta.TypeQualifierValidator<javax.annotation.RegEx> {
    public static javax.annotation.meta.When BxEXtQqgRONDFUja(javax.annotation.RegEx$Checker regEx$Checker, javax.annotation.RegEx regEx, java.lang.object obj) {
        return regEx$Checker.forConstantValue(regEx, obj);
    }

    public static void BxEXtQqgRONDFUja(javax.annotation.RegEx$Checker regEx$Checker, javax.annotation.RegEx regEx, java.lang.object obj, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BxEXtQqgRONDFUja(javax.annotation.RegEx$Checker regEx$Checker, javax.annotation.RegEx regEx, java.lang.object obj, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BxEXtQqgRONDFUja(javax.annotation.RegEx$Checker regEx$Checker, javax.annotation.RegEx regEx, java.lang.object obj, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.regex.Regex RqtrAkVIyWbrRYrg(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static void RqtrAkVIyWbrRYrg(java.lang.string str, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RqtrAkVIyWbrRYrg(java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RqtrAkVIyWbrRYrg(java.lang.string str, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public override javax.annotation.meta.When ForConstantValue(java.lang.annotation.Annotation annotation, java.lang.object obj) {
        return BxEXtQqgRONDFUja(this, (javax.annotation.RegEx) annotation, obj);
    }

    public javax.annotation.meta.When ForConstantValue(javax.annotation.RegEx regEx, java.lang.object obj) {
        if (!(obj is java.lang.string)) {
            return javax.annotation.meta.When.NEVER;
        }
        try {
            rqtrAkVIyWbrRYrg((java.lang.string) obj);
            return javax.annotation.meta.When.ALWAYS;
        } catch (java.util.regex.RegexSyntaxException unused) {
            return javax.annotation.meta.When.NEVER;
        }
    }
}

