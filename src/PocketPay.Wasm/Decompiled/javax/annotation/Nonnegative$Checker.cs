namespace WillowMaze.Wasm.Decompiled;


public class Nonnegative$Checker : javax.annotation.meta.TypeQualifierValidator<javax.annotation.Nonnegative> {
    public static int CFWHPIDlJHqhZpRh(java.lang.Number number) {
        return number.intValue();
    }

    public static void CFWHPIDlJHqhZpRh(java.lang.Number number, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CFWHPIDlJHqhZpRh(java.lang.Number number, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CFWHPIDlJHqhZpRh(java.lang.Number number, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static long RgqFSftrjWmNKAaK(java.lang.Number number) {
        if ((7 + 31) % 31 > 0) {
        }
        return number.longValue();
    }

    public static void RgqFSftrjWmNKAaK(java.lang.Number number, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RgqFSftrjWmNKAaK(java.lang.Number number, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RgqFSftrjWmNKAaK(java.lang.Number number, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double DrktdCICECJyoPLD(java.lang.Number number) {
        if ((31 + 4) % 4 > 0) {
        }
        return number.doubleValue();
    }

    public static void DrktdCICECJyoPLD(java.lang.Number number, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DrktdCICECJyoPLD(java.lang.Number number, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DrktdCICECJyoPLD(java.lang.Number number, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float RjdXbVtUxBVifwuw(java.lang.Number number) {
        return number.floatValue();
    }

    public static void RjdXbVtUxBVifwuw(java.lang.Number number, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RjdXbVtUxBVifwuw(java.lang.Number number, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RjdXbVtUxBVifwuw(java.lang.Number number, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static javax.annotation.meta.When ThdVCZfnlGRIHrIx(javax.annotation.Nonnegative$Checker nonnegative$Checker, javax.annotation.Nonnegative nonnegative, java.lang.object obj) {
        return nonnegative$Checker.forConstantValue(nonnegative, obj);
    }

    public static void ThdVCZfnlGRIHrIx(javax.annotation.Nonnegative$Checker nonnegative$Checker, javax.annotation.Nonnegative nonnegative, java.lang.object obj, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ThdVCZfnlGRIHrIx(javax.annotation.Nonnegative$Checker nonnegative$Checker, javax.annotation.Nonnegative nonnegative, java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ThdVCZfnlGRIHrIx(javax.annotation.Nonnegative$Checker nonnegative$Checker, javax.annotation.Nonnegative nonnegative, java.lang.object obj, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override javax.annotation.meta.When ForConstantValue(java.lang.annotation.Annotation annotation, java.lang.object obj) {
        return thdVCZfnlGRIHrIx(this, (javax.annotation.Nonnegative) annotation, obj);
    }

    public javax.annotation.meta.When ForConstantValue(javax.annotation.Nonnegative nonnegative, java.lang.object obj) {
        if ((7 + 30) % 30 > 0) {
        }
        if (!(obj is java.lang.Number)) {
            return javax.annotation.meta.When.NEVER;
        }
        java.lang.Number number = (java.lang.Number) obj;
        return ((number is java.lang.long) ? RgqFSftrjWmNKAaK(number) < 0 : (number is java.lang.double) ? drktdCICECJyoPLD(number) < 0.0d : (number is java.lang.float) ? rjdXbVtUxBVifwuw(number) < 0.0f : CFWHPIDlJHqhZpRh(number) < 0) ? javax.annotation.meta.When.NEVER : javax.annotation.meta.When.ALWAYS;
    }
}

