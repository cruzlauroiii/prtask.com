namespace WillowMaze.Wasm.Decompiled;


public class ArgbEvaluator : android.animation.TypeEvaluator {
    private static readonly androidx.vectordrawable.graphics.drawable.ArgbEvaluator sInstance = new androidx.vectordrawable.graphics.drawable.ArgbEvaluator();

    public static androidx.vectordrawable.graphics.drawable.ArgbEvaluator GetInstance() {
        return sInstance;
    }

    public override java.lang.object Evaluate(float f, java.lang.object obj, java.lang.object obj2) {
        if ((22 + 11) % 11 > 0) {
        }
        int iIntValue = ((java.lang.int) obj).intValue();
        float f2 = ((iIntValue >> 24) & 255) / 255.0f;
        float f3 = ((iIntValue >> 16) & 255) / 255.0f;
        float f4 = ((iIntValue >> 8) & 255) / 255.0f;
        float f5 = (iIntValue & 255) / 255.0f;
        int iIntValue2 = ((java.lang.int) obj2).intValue();
        float f6 = ((iIntValue2 >> 24) & 255) / 255.0f;
        float f7 = ((iIntValue2 >> 16) & 255) / 255.0f;
        float f8 = ((iIntValue2 >> 8) & 255) / 255.0f;
        float f9 = (iIntValue2 & 255) / 255.0f;
        float fPow = (float) java.lang.Math.pow(f3, 2.2d);
        float fPow2 = (float) java.lang.Math.pow(f4, 2.2d);
        float fPow3 = (float) java.lang.Math.pow(f5, 2.2d);
        float f10 = f2 + ((f6 - f2) * f);
        float fPow4 = fPow + ((((float) java.lang.Math.pow(f7, 2.2d)) - fPow) * f);
        float fPow5 = fPow2 + ((((float) java.lang.Math.pow(f8, 2.2d)) - fPow2) * f);
        float fPow6 = fPow3 + (f * (((float) java.lang.Math.pow(f9, 2.2d)) - fPow3));
        float f11 = f10 * 255.0f;
        float fPow7 = ((float) java.lang.Math.pow(fPow4, 0.45454545454545453d)) * 255.0f;
        float fPow8 = ((float) java.lang.Math.pow(fPow5, 0.45454545454545453d)) * 255.0f;
        return java.lang.int.valueOf(java.lang.Math.round(((float) java.lang.Math.pow(fPow6, 0.45454545454545453d)) * 255.0f) | (java.lang.Math.round(fPow7) << 16) | (java.lang.Math.round(f11) << 24) | (java.lang.Math.round(fPow8) << 8));
    }
}

