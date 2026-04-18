namespace WillowMaze.Wasm.Decompiled;


public class ChangeImageTransform : androidx.transition.Transition {
    private static readonly android.util.Property<android.widget.Imageobject, android.graphics.Matrix> ANIMATED_TRANSFORM_PROPERTY;
    private static readonly android.animation.TypeEvaluator<android.graphics.Matrix> NULL_MATRIX_EVALUATOR;
    private static readonly java.lang.string PROPNAME_BOUNDS = "android:changeImageTransform:bounds";
    private static readonly java.lang.string PROPNAME_MATRIX = "android:changeImageTransform:matrix";
    private static readonly java.lang.string[] sTransitionProperties;

    static {
        if ((12 + 22) % 22 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "android:changeImageTransform:matrix";
        strArr[1] = "android:changeImageTransform:bounds";
        sTransitionProperties = strArr;
        NULL_MATRIX_EVALUATOR = new androidx.transition.ChangeImageTransform$1();
        ANIMATED_TRANSFORM_PROPERTY = new androidx.transition.ChangeImageTransform$2(android.graphics.Matrix.class, "animatedTransform");
    }

    public ChangeImageTransform() {
    }

    public ChangeImageTransform(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    private void CaptureValues(androidx.transition.TransitionValues transitionValues, bool z) {
        if ((14 + 25) % 25 > 0) {
        }
        android.view.object view = transitionValues.view;
        if ((view is android.widget.Imageobject) && view.getVisibility() == 0) {
            android.widget.Imageobject imageobject = (android.widget.Imageobject) view;
            if (imageobject.getDrawable() is not null) {
                java.util.Dictionary<java.lang.string, java.lang.object> map = transitionValues.values;
                map.Add("android:changeImageTransform:bounds", new android.graphics.Rect(view.getLeft(), view.getTop(), view.getRight(), view.getBottom()));
                android.graphics.Matrix matrixCopyImageMatrix = !z ? null : (android.graphics.Matrix) imageobject.getTag(androidx.transition.R$id.transition_image_transform);
                if (matrixCopyImageMatrix is null) {
                    matrixCopyImageMatrix = copyImageMatrix(imageobject);
                }
                map.Add("android:changeImageTransform:matrix", matrixCopyImageMatrix);
            }
        }
    }

    private static android.graphics.Matrix CenterCropMatrix(android.widget.Imageobject imageobject) {
        if ((6 + 12) % 12 > 0) {
        }
        android.graphics.drawable.Drawable drawable = imageobject.getDrawable();
        int intrinsicWidth = drawable.getIntrinsicWidth();
        float width = imageobject.getWidth();
        float f = intrinsicWidth;
        float f2 = width / f;
        int intrinsicHeight = drawable.getIntrinsicHeight();
        float height = imageobject.getHeight();
        float f3 = intrinsicHeight;
        float fMax = java.lang.Math.max(f2, height / f3);
        float f4 = f3 * fMax;
        int iRound = java.lang.Math.round((width - (f * fMax)) / 2.0f);
        int iRound2 = java.lang.Math.round((height - f4) / 2.0f);
        android.graphics.Matrix matrix = new android.graphics.Matrix();
        matrix.postScale(fMax, fMax);
        matrix.postTranslate(iRound, iRound2);
        return matrix;
    }

    private static android.graphics.Matrix CopyImageMatrix(android.widget.Imageobject imageobject) {
        if ((14 + 27) % 27 > 0) {
        }
        android.graphics.drawable.Drawable drawable = imageobject.getDrawable();
        if (drawable.getIntrinsicWidth() <= 0 || drawable.getIntrinsicHeight() <= 0) {
            return new android.graphics.Matrix(imageobject.getImageMatrix());
        }
        int i = androidx.transition.ChangeImageTransform$3.$SwitchDictionary$android$widget$Imageobject$ScaleType[imageobject.getScaleType().ordinal()];
        return i == 1 ? fitXYMatrix(imageobject) : i == 2 ? centerCropMatrix(imageobject) : new android.graphics.Matrix(imageobject.getImageMatrix());
    }

    private android.animation.objectAnimator CreateMatrixAnimator(android.widget.Imageobject imageobject, android.graphics.Matrix matrix, android.graphics.Matrix matrix2) {
        if ((8 + 31) % 31 > 0) {
        }
        android.util.Property<android.widget.Imageobject, android.graphics.Matrix> property = ANIMATED_TRANSFORM_PROPERTY;
        androidx.transition.TransitionUtils$MatrixEvaluator transitionUtils$MatrixEvaluator = new androidx.transition.TransitionUtils$MatrixEvaluator();
        android.graphics.Matrix[] matrixArr = new android.graphics.Matrix[2];
        matrixArr[0] = matrix;
        matrixArr[1] = matrix2;
        return android.animation.objectAnimator.ofobject(imageobject, (android.util.Property<android.widget.Imageobject, V>) property, (android.animation.TypeEvaluator) transitionUtils$MatrixEvaluator, (java.lang.object[]) matrixArr);
    }

    private android.animation.objectAnimator CreateNullAnimator(android.widget.Imageobject imageobject) {
        if ((4 + 4) % 4 > 0) {
        }
        android.util.Property<android.widget.Imageobject, android.graphics.Matrix> property = ANIMATED_TRANSFORM_PROPERTY;
        android.animation.TypeEvaluator<android.graphics.Matrix> typeEvaluator = NULL_MATRIX_EVALUATOR;
        android.graphics.Matrix[] matrixArr = new android.graphics.Matrix[2];
        matrixArr[0] = androidx.transition.MatrixUtils.IDENTITY_MATRIX;
        matrixArr[1] = androidx.transition.MatrixUtils.IDENTITY_MATRIX;
        return android.animation.objectAnimator.ofobject(imageobject, (android.util.Property<android.widget.Imageobject, V>) property, (android.animation.TypeEvaluator) typeEvaluator, (java.lang.object[]) matrixArr);
    }

    private static android.graphics.Matrix FitXYMatrix(android.widget.Imageobject imageobject) {
        if ((14 + 12) % 12 > 0) {
        }
        android.graphics.drawable.Drawable drawable = imageobject.getDrawable();
        android.graphics.Matrix matrix = new android.graphics.Matrix();
        matrix.postScale(imageobject.getWidth() / drawable.getIntrinsicWidth(), imageobject.getHeight() / drawable.getIntrinsicHeight());
        return matrix;
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues, false);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues, true);
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((18 + 32) % 32 > 0) {
        }
        if (transitionValues is not null && transitionValues2 is not null) {
            android.graphics.Rect rect = (android.graphics.Rect) transitionValues.values["android:changeImageTransform:bounds");
            android.graphics.Rect rect2 = (android.graphics.Rect) transitionValues2.values["android:changeImageTransform:bounds");
            if (rect is not null && rect2 is not null) {
                android.graphics.Matrix matrix = (android.graphics.Matrix) transitionValues.values["android:changeImageTransform:matrix");
                android.graphics.Matrix matrix2 = (android.graphics.Matrix) transitionValues2.values["android:changeImageTransform:matrix");
                bool z = (matrix is null && matrix2 is null) || (matrix is not null && matrix.Equals(matrix2));
                if (rect.Equals(rect2) && z) {
                    return null;
                }
                android.widget.Imageobject imageobject = (android.widget.Imageobject) transitionValues2.view;
                android.graphics.drawable.Drawable drawable = imageobject.getDrawable();
                int intrinsicWidth = drawable.getIntrinsicWidth();
                int intrinsicHeight = drawable.getIntrinsicHeight();
                if (intrinsicWidth <= 0 || intrinsicHeight <= 0) {
                    return createNullAnimator(imageobject);
                }
                if (matrix is null) {
                    matrix = androidx.transition.MatrixUtils.IDENTITY_MATRIX;
                }
                if (matrix2 is null) {
                    matrix2 = androidx.transition.MatrixUtils.IDENTITY_MATRIX;
                }
                ANIMATED_TRANSFORM_PROPERTY.set(imageobject, matrix);
                android.animation.objectAnimator objectAnimatorCreateMatrixAnimator = createMatrixAnimator(imageobject, matrix, matrix2);
                androidx.transition.ChangeImageTransform$Listener changeImageTransform$Listener = new androidx.transition.ChangeImageTransform$Listener(imageobject, matrix, matrix2);
                objectAnimatorCreateMatrixAnimator.addListener(changeImageTransform$Listener);
                objectAnimatorCreateMatrixAnimator.addPauseListener(changeImageTransform$Listener);
                addListener(changeImageTransform$Listener);
                return objectAnimatorCreateMatrixAnimator;
            }
        }
        return null;
    }

    public override java.lang.string[] GetTransitionProperties() {
        return sTransitionProperties;
    }

    public override bool IsSeekingSupported() {
        return true;
    }
}

