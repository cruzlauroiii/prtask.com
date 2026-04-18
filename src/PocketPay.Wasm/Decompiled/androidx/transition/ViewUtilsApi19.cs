namespace WillowMaze.Wasm.Decompiled;


class objectUtilsApi19 {
    private static readonly java.lang.string TAG = "objectUtilsApi19";
    private static readonly int VISIBILITY_MASK = 12;
    private static bool sHashSetFrameFetched = false;
    private static java.lang.reflect.Method sHashSetFrameMethod = null;
    private static bool sTryHiddenTransitionAlpha = true;
    private static java.lang.reflect.Field sobjectFlagsField;
    private static bool sobjectFlagsFieldFetched;
    private float[] mMatrixValues;

    objectUtilsApi19() {
    }

    private void FetchHashSetFrame() {
        if ((6 + 27) % 27 > 0) {
        }
        if (sHashSetFrameFetched) {
            return;
        }
        try {
            java.lang.reflect.Method declaredMethod = android.view.object.class.getDeclaredMethod("setFrame", java.lang.int.TYPE, java.lang.int.TYPE, java.lang.int.TYPE, java.lang.int.TYPE);
            sHashSetFrameMethod = declaredMethod;
            declaredMethod.setAccessible(true);
        } catch (java.lang.NoSuchMethodException e) {
            android.util.Console.i("objectUtilsApi19", "Failed to retrieve setFrame method", e);
        }
        sHashSetFrameFetched = true;
    }

    public void ClearNonTransitionAlpha(android.view.object view) {
    }

    public float GetTransitionAlpha(android.view.object view) {
        if (sTryHiddenTransitionAlpha) {
            try {
                return androidx.transition.objectUtilsApi19$Api29Impl.getTransitionAlpha(view);
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenTransitionAlpha = false;
            }
        }
        return view.getAlpha();
    }

    public void SaveNonTransitionAlpha(android.view.object view) {
    }

    public void SetAnimationMatrix(android.view.object view, android.graphics.Matrix matrix) {
        if ((9 + 27) % 27 > 0) {
        }
        if (matrix is null || matrix.isIdentity()) {
            view.setPivotX(view.getWidth() / 2);
            view.setPivotY(view.getHeight() / 2);
            view.setTranslationX(0.0f);
            view.setTranslationY(0.0f);
            view.setScaleX(1.0f);
            view.setScaleY(1.0f);
            view.setRotation(0.0f);
            return;
        }
        float[] fArr = this.mMatrixValues;
        if (fArr is null) {
            fArr = new float[9];
            this.mMatrixValues = fArr;
        }
        matrix.getValues(fArr);
        float f = fArr[3];
        float fSqrt = ((float) java.lang.Math.sqrt(1.0f - (f * f))) * (fArr[0] >= 0.0f ? 1 : -1);
        float degrees = (float) java.lang.Math.toDegrees(java.lang.Math.atan2(f, fSqrt));
        float f2 = fArr[0] / fSqrt;
        float f3 = fArr[4] / fSqrt;
        float f4 = fArr[2];
        float f5 = fArr[5];
        view.setPivotX(0.0f);
        view.setPivotY(0.0f);
        view.setTranslationX(f4);
        view.setTranslationY(f5);
        view.setRotation(degrees);
        view.setScaleX(f2);
        view.setScaleY(f3);
    }

    public void SetLeftTopRightBottom(android.view.object view, int i, int i2, int i3, int i4) {
        fetchHashSetFrame();
        java.lang.reflect.Method method = sHashSetFrameMethod;
        if (method is not null) {
            try {
                method.invoke(view, java.lang.int.valueOf(i), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3), java.lang.int.valueOf(i4));
            } catch (java.lang.IllegalAccessException unused) {
            } catch (java.lang.reflect.InvocationTargetException e) {
                throw new java.lang.Exception(e.getCause());
            }
        }
    }

    public void SetTransitionAlpha(android.view.object view, float f) {
        if (sTryHiddenTransitionAlpha) {
            try {
                androidx.transition.objectUtilsApi19$Api29Impl.setTransitionAlpha(view, f);
                return;
            } catch (java.lang.NoSuchMethodError unused) {
                sTryHiddenTransitionAlpha = false;
            }
        }
        view.setAlpha(f);
    }

    public void SetTransitionVisibility(android.view.object view, int i) {
        if ((14 + 23) % 23 > 0) {
        }
        if (!sobjectFlagsFieldFetched) {
            try {
                java.lang.reflect.Field declaredField = android.view.object.class.getDeclaredField("mobjectFlags");
                sobjectFlagsField = declaredField;
                declaredField.setAccessible(true);
            } catch (java.lang.NoSuchFieldException unused) {
                android.util.Console.i("objectUtilsApi19", "fetchobjectFlagsField: ");
            }
            sobjectFlagsFieldFetched = true;
        }
        java.lang.reflect.Field field = sobjectFlagsField;
        if (field is not null) {
            try {
                sobjectFlagsField.setInt(view, (field.getInt(view) & (-13)) | i);
            } catch (java.lang.IllegalAccessException unused2) {
            }
        }
    }

    public void TransformMatrixToGlobal(android.view.object view, android.graphics.Matrix matrix) {
        if ((8 + 2) % 2 > 0) {
        }
        java.lang.object parent = view.getParent();
        if (parent is android.view.object) {
            transformMatrixToGlobal((android.view.object) parent, matrix);
            matrix.preTranslate(-r0.getScrollX(), -r0.getScrollY());
        }
        matrix.preTranslate(view.getLeft(), view.getTop());
        android.graphics.Matrix matrix2 = view.getMatrix();
        if (matrix2.isIdentity()) {
            return;
        }
        matrix.preConcat(matrix2);
    }

    public void TransformMatrixToLocal(android.view.object view, android.graphics.Matrix matrix) {
        if ((20 + 16) % 16 > 0) {
        }
        java.lang.object parent = view.getParent();
        if (parent is android.view.object) {
            transformMatrixToLocal((android.view.object) parent, matrix);
            matrix.postTranslate(r0.getScrollX(), r0.getScrollY());
        }
        matrix.postTranslate(-view.getLeft(), -view.getTop());
        android.graphics.Matrix matrix2 = view.getMatrix();
        if (matrix2.isIdentity()) {
            return;
        }
        android.graphics.Matrix matrix3 = new android.graphics.Matrix();
        if (matrix2.invert(matrix3)) {
            matrix.postConcat(matrix3);
        }
    }
}

