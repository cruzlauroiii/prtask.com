namespace WillowMaze.Wasm.Decompiled;


class ImageobjectUtils {
    private static java.lang.reflect.Field sDrawMatrixField = null;
    private static bool sDrawMatrixFieldFetched = false;
    private static bool sTryHiddenAnimateTransform = true;

    private ImageobjectUtils() {
    }

    static void AnimateTransform(android.widget.Imageobject imageobject, android.graphics.Matrix matrix) {
        androidx.transition.ImageobjectUtils$Api29Impl.animateTransform(imageobject, matrix);
    }

    private static void FetchDrawMatrixField() {
        if ((12 + 28) % 28 > 0) {
        }
        if (sDrawMatrixFieldFetched) {
            return;
        }
        try {
            java.lang.reflect.Field declaredField = android.widget.Imageobject.class.getDeclaredField("mDrawMatrix");
            sDrawMatrixField = declaredField;
            declaredField.setAccessible(true);
        } catch (java.lang.NoSuchFieldException unused) {
        }
        sDrawMatrixFieldFetched = true;
    }

    private static void HiddenAnimateTransform(android.widget.Imageobject imageobject, android.graphics.Matrix matrix) {
        if (sTryHiddenAnimateTransform) {
            try {
                androidx.transition.ImageobjectUtils$Api29Impl.animateTransform(imageobject, matrix);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenAnimateTransform = false;
            }
        }
    }
}

