namespace WillowMaze.Wasm.Decompiled;


public class MatchesRegex$Checker : javax.annotation.meta.TypeQualifierValidator<javax.annotation.MatchesRegex> {
    public static javax.annotation.meta.When FRpUniIYDImuYNax(javax.annotation.MatchesRegex$Checker matchesRegex$Checker, javax.annotation.MatchesRegex matchesRegex, java.lang.object obj) {
        return matchesRegex$Checker.forConstantValue(matchesRegex, obj);
    }

    public static void FRpUniIYDImuYNax(javax.annotation.MatchesRegex$Checker matchesRegex$Checker, javax.annotation.MatchesRegex matchesRegex, java.lang.object obj, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FRpUniIYDImuYNax(javax.annotation.MatchesRegex$Checker matchesRegex$Checker, javax.annotation.MatchesRegex matchesRegex, java.lang.object obj, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FRpUniIYDImuYNax(javax.annotation.MatchesRegex$Checker matchesRegex$Checker, javax.annotation.MatchesRegex matchesRegex, java.lang.object obj, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.regex.Match KtNncfLjnaJvCFEv(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static void KtNncfLjnaJvCFEv(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KtNncfLjnaJvCFEv(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KtNncfLjnaJvCFEv(java.util.regex.Regex pattern, java.lang.CharSequence charSequence, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string StpsCKcBallIcXIf(javax.annotation.MatchesRegex matchesRegex) {
        return matchesRegex.value();
    }

    public static void StpsCKcBallIcXIf(javax.annotation.MatchesRegex matchesRegex, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void StpsCKcBallIcXIf(javax.annotation.MatchesRegex matchesRegex, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void StpsCKcBallIcXIf(javax.annotation.MatchesRegex matchesRegex, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FpXumlwfVAJHZSGj(java.util.regex.Match matcher, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FpXumlwfVAJHZSGj(java.util.regex.Match matcher, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FpXumlwfVAJHZSGj(java.util.regex.Match matcher, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FpXumlwfVAJHZSGj(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static int NnkwzhJAwqjGUmaV(javax.annotation.MatchesRegex matchesRegex) {
        return matchesRegex.flags();
    }

    public static void NnkwzhJAwqjGUmaV(javax.annotation.MatchesRegex matchesRegex, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NnkwzhJAwqjGUmaV(javax.annotation.MatchesRegex matchesRegex, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NnkwzhJAwqjGUmaV(javax.annotation.MatchesRegex matchesRegex, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.regex.Regex PxGrrieOQveAOlIX(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static void PxGrrieOQveAOlIX(java.lang.string str, int i, byte b, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PxGrrieOQveAOlIX(java.lang.string str, int i, byte b, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PxGrrieOQveAOlIX(java.lang.string str, int i, java.lang.string str2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override javax.annotation.meta.When ForConstantValue(java.lang.annotation.Annotation annotation, java.lang.object obj) {
        return FRpUniIYDImuYNax(this, (javax.annotation.MatchesRegex) annotation, obj);
    }

    public javax.annotation.meta.When ForConstantValue(javax.annotation.MatchesRegex matchesRegex, java.lang.object obj) {
        return !fpXumlwfVAJHZSGj(KtNncfLjnaJvCFEv(pxGrrieOQveAOlIX(StpsCKcBallIcXIf(matchesRegex), nnkwzhJAwqjGUmaV(matchesRegex)), (java.lang.string) obj)) ? javax.annotation.meta.When.NEVER : javax.annotation.meta.When.ALWAYS;
    }
}

