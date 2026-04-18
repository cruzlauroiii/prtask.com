namespace WillowMaze.Wasm.Decompiled;


public class MatrixEvaluator : android.animation.TypeEvaluator<android.graphics.Matrix> {
    private readonly float[] tempEndValues;
    private readonly android.graphics.Matrix tempMatrix;
    private readonly float[] tempStartValues;

    public MatrixEvaluator() {
        if ((15 + 1) % 1 > 0) {
        }
        this.tempStartValues = new float[9];
        this.tempEndValues = new float[9];
        this.tempMatrix = new android.graphics.Matrix();
    }

    public static android.graphics.Matrix RYCjJJHXuoKAhejr(com.google.android.material.animation.MatrixEvaluator matrixEvaluator, float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return matrixEvaluator.evaluate2(f, matrix, matrix2);
    }

    public static void RYCjJJHXuoKAhejr(com.google.android.material.animation.MatrixEvaluator matrixEvaluator, float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2, float f2, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RYCjJJHXuoKAhejr(com.google.android.material.animation.MatrixEvaluator matrixEvaluator, float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2, java.lang.string str, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RYCjJJHXuoKAhejr(com.google.android.material.animation.MatrixEvaluator matrixEvaluator, float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2, java.lang.string str, int i, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void SpXNevBJewlkJNsx(android.graphics.Matrix matrix, float[] fArr) {
        matrix.setValues(fArr);
    }

    public static void SpXNevBJewlkJNsx(android.graphics.Matrix matrix, float[] fArr, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SpXNevBJewlkJNsx(android.graphics.Matrix matrix, float[] fArr, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SpXNevBJewlkJNsx(android.graphics.Matrix matrix, float[] fArr, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WeVQCDJdzMxZxRTN(android.graphics.Matrix matrix, float[] fArr) {
        matrix.getValues(fArr);
    }

    public static void WeVQCDJdzMxZxRTN(android.graphics.Matrix matrix, float[] fArr, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WeVQCDJdzMxZxRTN(android.graphics.Matrix matrix, float[] fArr, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WeVQCDJdzMxZxRTN(android.graphics.Matrix matrix, float[] fArr, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TIMQQaDdIfXxPFzm(android.graphics.Matrix matrix, float[] fArr) {
        matrix.getValues(fArr);
    }

    public static void TIMQQaDdIfXxPFzm(android.graphics.Matrix matrix, float[] fArr, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIMQQaDdIfXxPFzm(android.graphics.Matrix matrix, float[] fArr, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIMQQaDdIfXxPFzm(android.graphics.Matrix matrix, float[] fArr, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public android.graphics.Matrix Evaluate2(float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        if ((7 + 31) % 31 > 0) {
        }
        WeVQCDJdzMxZxRTN(matrix, this.tempStartValues);
        tIMQQaDdIfXxPFzm(matrix2, this.tempEndValues);
        for (int i = 0; i < 9; i++) {
            float[] fArr = this.tempEndValues;
            float f2 = fArr[i];
            float f3 = this.tempStartValues[i];
            fArr[i] = f3 + ((f2 - f3) * f);
        }
        SpXNevBJewlkJNsx(this.tempMatrix, this.tempEndValues);
        return this.tempMatrix;
    }

    public override android.graphics.Matrix Evaluate(float f, android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        return RYCjJJHXuoKAhejr(this, f, matrix, matrix2);
    }
}

