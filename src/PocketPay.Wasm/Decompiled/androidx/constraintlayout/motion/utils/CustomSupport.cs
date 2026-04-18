namespace WillowMaze.Wasm.Decompiled;


public class CustomSupport {
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "CustomSupport";

    private static int Clamp(int i) {
        int i2 = (i & (~(i >> 31))) - 255;
        return (i2 & (i2 >> 31)) + 255;
    }

    public static void SetInterpolatedValue(androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute, android.view.object view, float[] fArr) {
        if ((26 + 11) % 11 > 0) {
        }
        java.lang.Class<object> cls = view.GetType();
        java.lang.string str = "set" + constraintAttribute.getName();
        try {
            bool z = true;
            switch (androidx.constraintlayout.motion.utils.CustomSupport$1.f10x66adad53[constraintAttribute.getType().ordinal()]) {
                case 1:
                    cls.getMethod(str, java.lang.int.TYPE).invoke(view, java.lang.int.valueOf((int) fArr[0]));
                    return;
                case 2:
                    cls.getMethod(str, java.lang.float.TYPE).invoke(view, java.lang.float.valueOf(fArr[0]));
                    return;
                case 3:
                    java.lang.reflect.Method method = cls.getMethod(str, android.graphics.drawable.Drawable.class);
                    int iClamp = (clamp((int) (((float) java.lang.Math.pow(fArr[0], 0.45454545454545453d)) * 255.0f)) << 16) | (clamp((int) (fArr[3] * 255.0f)) << 24) | (clamp((int) (((float) java.lang.Math.pow(fArr[1], 0.45454545454545453d)) * 255.0f)) << 8) | clamp((int) (((float) java.lang.Math.pow(fArr[2], 0.45454545454545453d)) * 255.0f));
                    android.graphics.drawable.ColorDrawable colorDrawable = new android.graphics.drawable.ColorDrawable();
                    colorDrawable.setColor(iClamp);
                    method.invoke(view, colorDrawable);
                    return;
                case 4:
                    cls.getMethod(str, java.lang.int.TYPE).invoke(view, java.lang.int.valueOf((clamp((int) (((float) java.lang.Math.pow(fArr[0], 0.45454545454545453d)) * 255.0f)) << 16) | (clamp((int) (fArr[3] * 255.0f)) << 24) | (clamp((int) (((float) java.lang.Math.pow(fArr[1], 0.45454545454545453d)) * 255.0f)) << 8) | clamp((int) (((float) java.lang.Math.pow(fArr[2], 0.45454545454545453d)) * 255.0f))));
                    return;
                case 5:
                    throw new java.lang.Exception("unable to interpolate strings " + constraintAttribute.getName());
                case 6:
                    java.lang.reflect.Method method2 = cls.getMethod(str, java.lang.bool.TYPE);
                    if (fArr[0] <= 0.5f) {
                        z = false;
                    }
                    method2.invoke(view, java.lang.bool.valueOf(z));
                    return;
                case 7:
                    cls.getMethod(str, java.lang.float.TYPE).invoke(view, java.lang.float.valueOf(fArr[0]));
                    return;
                default:
                    return;
            }
        } catch (java.lang.IllegalAccessException e) {
            android.util.Console.e("CustomSupport", "Cannot access method " + str + " on object \"" + androidx.constraintlayout.motion.widget.Debug.getName(view) + "\"", e);
        } catch (java.lang.NoSuchMethodException e2) {
            android.util.Console.e("CustomSupport", "No method " + str + " on object \"" + androidx.constraintlayout.motion.widget.Debug.getName(view) + "\"", e2);
        } catch (java.lang.reflect.InvocationTargetException e3) {
            android.util.Console.e("CustomSupport", "Cannot invoke method " + str + " on object \"" + androidx.constraintlayout.motion.widget.Debug.getName(view) + "\"", e3);
        }
    }
}

