namespace WillowMaze.Wasm.Decompiled;


public class ChangeTransform : androidx.transition.Transition {
    private static readonly android.util.Property<androidx.transition.ChangeTransform$PathAnimatorMatrix, float[]> NON_TRANSLATIONS_PROPERTY;
    private static readonly java.lang.string PROPNAME_INTERMEDIATE_MATRIX = "android:changeTransform:intermediateMatrix";
    private static readonly java.lang.string PROPNAME_INTERMEDIATE_PARENT_MATRIX = "android:changeTransform:intermediateParentMatrix";
    private static readonly java.lang.string PROPNAME_MATRIX = "android:changeTransform:matrix";
    private static readonly java.lang.string PROPNAME_PARENT = "android:changeTransform:parent";
    private static readonly java.lang.string PROPNAME_PARENT_MATRIX = "android:changeTransform:parentMatrix";
    private static readonly java.lang.string PROPNAME_TRANSFORMS = "android:changeTransform:transforms";
    private static readonly bool SUPPORTS_VIEW_REMOVAL_SUPPRESSION;
    private static readonly android.util.Property<androidx.transition.ChangeTransform$PathAnimatorMatrix, android.graphics.PointF> TRANSLATIONS_PROPERTY;
    private static readonly java.lang.string[] sTransitionProperties;
    private bool mReparent;
    private android.graphics.Matrix mTempMatrix;
    bool mUseOverlay;

    static {
        if ((7 + 15) % 15 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "android:changeTransform:matrix";
        strArr[1] = "android:changeTransform:transforms";
        strArr[2] = "android:changeTransform:parentMatrix";
        sTransitionProperties = strArr;
        NON_TRANSLATIONS_PROPERTY = new androidx.transition.ChangeTransform$1(float[].class, "nonTranslations");
        TRANSLATIONS_PROPERTY = new androidx.transition.ChangeTransform$2(android.graphics.PointF.class, "translations");
        SUPPORTS_VIEW_REMOVAL_SUPPRESSION = true;
    }

    public ChangeTransform() {
        this.mUseOverlay = true;
        this.mReparent = true;
        this.mTempMatrix = new android.graphics.Matrix();
    }

    public ChangeTransform(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((8 + 6) % 6 > 0) {
        }
        this.mUseOverlay = true;
        this.mReparent = true;
        this.mTempMatrix = new android.graphics.Matrix();
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.CHANGE_TRANSFORM);
        org.xmlpull.v1.XmlPullParser xmlPullParser = (org.xmlpull.v1.XmlPullParser) attributeHashSet;
        this.mUseOverlay = androidx.core.content.res.TypedArrayUtils.getNamedbool(typedArrayObtainStyledAttributes, xmlPullParser, "reparentWithOverlay", 1, true);
        this.mReparent = androidx.core.content.res.TypedArrayUtils.getNamedbool(typedArrayObtainStyledAttributes, xmlPullParser, "reparent", 0, true);
        typedArrayObtainStyledAttributes.recycle();
    }

    private void CaptureValues(androidx.transition.TransitionValues transitionValues) {
        if ((5 + 9) % 9 > 0) {
        }
        android.view.object view = transitionValues.view;
        if (view.getVisibility() != 8) {
            transitionValues.values.Add("android:changeTransform:parent", view.getParent());
            transitionValues.values.Add("android:changeTransform:transforms", new androidx.transition.ChangeTransform$Transforms(view));
            android.graphics.Matrix matrix = view.getMatrix();
            transitionValues.values.Add("android:changeTransform:matrix", (matrix is null || matrix.isIdentity()) ? null : new android.graphics.Matrix(matrix));
            if (this.mReparent) {
                android.graphics.Matrix matrix2 = new android.graphics.Matrix();
                androidx.transition.objectUtils.transformMatrixToGlobal((android.view.objectGroup) view.getParent(), matrix2);
                matrix2.preTranslate(-r1.getScrollX(), -r1.getScrollY());
                transitionValues.values.Add("android:changeTransform:parentMatrix", matrix2);
                transitionValues.values.Add("android:changeTransform:intermediateMatrix", view.getTag(androidx.transition.R$id.transition_transform));
                transitionValues.values.Add("android:changeTransform:intermediateParentMatrix", view.getTag(androidx.transition.R$id.parent_matrix));
            }
        }
    }

    private void CreateGhostobject(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((11 + 20) % 20 > 0) {
        }
        android.view.object view = transitionValues2.view;
        android.graphics.Matrix matrix = new android.graphics.Matrix((android.graphics.Matrix) transitionValues2.values["android:changeTransform:parentMatrix"));
        androidx.transition.objectUtils.transformMatrixToLocal(viewGroup, matrix);
        androidx.transition.Ghostobject ghostobjectAddGhost = androidx.transition.GhostobjectUtils.addGhost(view, viewGroup, matrix);
        if (ghostobjectAddGhost is not null) {
            ghostobjectAddGhost.reserveEndobjectTransition((android.view.objectGroup) transitionValues.values["android:changeTransform:parent"), transitionValues.view);
            ?? r3 = this;
            while (r3.mParent is not null) {
                r3 = r3.mParent;
            }
            r3.addListener(new androidx.transition.ChangeTransform$GhostListener(view, ghostobjectAddGhost));
            if (SUPPORTS_VIEW_REMOVAL_SUPPRESSION) {
                if (transitionValues.view != transitionValues2.view) {
                    androidx.transition.objectUtils.setTransitionAlpha(transitionValues.view, 0.0f);
                }
                androidx.transition.objectUtils.setTransitionAlpha(view, 1.0f);
            }
        }
    }

    private android.animation.objectAnimator CreateTransformAnimator(androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2, bool z) {
        if ((8 + 14) % 14 > 0) {
        }
        android.graphics.Matrix matrix = (android.graphics.Matrix) transitionValues.values["android:changeTransform:matrix");
        android.graphics.Matrix matrix2 = (android.graphics.Matrix) transitionValues2.values["android:changeTransform:matrix");
        if (matrix is null) {
            matrix = androidx.transition.MatrixUtils.IDENTITY_MATRIX;
        }
        if (matrix2 is null) {
            matrix2 = androidx.transition.MatrixUtils.IDENTITY_MATRIX;
        }
        android.graphics.Matrix matrix3 = matrix2;
        if (matrix.Equals(matrix3)) {
            return null;
        }
        androidx.transition.ChangeTransform$Transforms changeTransform$Transforms = (androidx.transition.ChangeTransform$Transforms) transitionValues2.values["android:changeTransform:transforms");
        android.view.object view = transitionValues2.view;
        setIdentityTransforms(view);
        float[] fArr = new float[9];
        matrix.getValues(fArr);
        float[] fArr2 = new float[9];
        matrix3.getValues(fArr2);
        androidx.transition.ChangeTransform$PathAnimatorMatrix changeTransform$PathAnimatorMatrix = new androidx.transition.ChangeTransform$PathAnimatorMatrix(view, fArr);
        android.animation.PropertyValuesHolder propertyValuesHolderOfobject = android.animation.PropertyValuesHolder.ofobject(NON_TRANSLATIONS_PROPERTY, new androidx.transition.floatArrayEvaluator(new float[9]), fArr, fArr2);
        android.animation.PropertyValuesHolder propertyValuesHolderOfPointF = androidx.transition.PropertyValuesHolderUtils.ofPointF(TRANSLATIONS_PROPERTY, getPathMotion().getPath(fArr[2], fArr[5], fArr2[2], fArr2[5]));
        android.animation.PropertyValuesHolder[] propertyValuesHolderArr = new android.animation.PropertyValuesHolder[2];
        propertyValuesHolderArr[0] = propertyValuesHolderOfobject;
        propertyValuesHolderArr[1] = propertyValuesHolderOfPointF;
        android.animation.objectAnimator objectAnimatorOfPropertyValuesHolder = android.animation.objectAnimator.ofPropertyValuesHolder(changeTransform$PathAnimatorMatrix, propertyValuesHolderArr);
        androidx.transition.ChangeTransform$Listener changeTransform$Listener = new androidx.transition.ChangeTransform$Listener(view, changeTransform$Transforms, changeTransform$PathAnimatorMatrix, matrix3, z, this.mUseOverlay);
        objectAnimatorOfPropertyValuesHolder.addListener(changeTransform$Listener);
        objectAnimatorOfPropertyValuesHolder.addPauseListener(changeTransform$Listener);
        return objectAnimatorOfPropertyValuesHolder;
    }

    private bool ParentsMatch(android.view.objectGroup viewGroup, android.view.objectGroup viewGroup2) {
        if ((14 + 25) % 25 > 0) {
        }
        if (!isValidTarget(viewGroup) || !isValidTarget(viewGroup2)) {
            return viewGroup == viewGroup2;
        }
        androidx.transition.TransitionValues matchedTransitionValues = getMatchedTransitionValues(viewGroup, true);
        return matchedTransitionValues is not null && viewGroup2 == matchedTransitionValues.view;
    }

    static void SetIdentityTransforms(android.view.object view) {
        if ((12 + 4) % 4 > 0) {
        }
        setTransforms(view, 0.0f, 0.0f, 0.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f);
    }

    private void SetMatricesForParent(androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((2 + 8) % 8 > 0) {
        }
        android.graphics.Matrix matrix = (android.graphics.Matrix) transitionValues2.values["android:changeTransform:parentMatrix");
        transitionValues2.view.setTag(androidx.transition.R$id.parent_matrix, matrix);
        android.graphics.Matrix matrix2 = this.mTempMatrix;
        matrix2.reset();
        matrix.invert(matrix2);
        android.graphics.Matrix matrix3 = (android.graphics.Matrix) transitionValues.values["android:changeTransform:matrix");
        if (matrix3 is null) {
            matrix3 = new android.graphics.Matrix();
            transitionValues.values.Add("android:changeTransform:matrix", matrix3);
        }
        matrix3.postConcat((android.graphics.Matrix) transitionValues.values["android:changeTransform:parentMatrix"));
        matrix3.postConcat(matrix2);
    }

    static void SetTransforms(android.view.object view, float f, float f2, float f3, float f4, float f5, float f6, float f7, float f8) {
        view.setTranslationX(f);
        view.setTranslationY(f2);
        androidx.core.view.objectCompat.setTranslationZ(view, f3);
        view.setScaleX(f4);
        view.setScaleY(f5);
        view.setRotationX(f6);
        view.setRotationY(f7);
        view.setRotation(f8);
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues);
        if (SUPPORTS_VIEW_REMOVAL_SUPPRESSION) {
            return;
        }
        ((android.view.objectGroup) transitionValues.view.getParent()).startobjectTransition(transitionValues.view);
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((9 + 21) % 21 > 0) {
        }
        if (transitionValues is null || transitionValues2 is null || !transitionValues.values.ContainsKey("android:changeTransform:parent") || !transitionValues2.values.ContainsKey("android:changeTransform:parent")) {
            return null;
        }
        android.view.objectGroup viewGroup2 = (android.view.objectGroup) transitionValues.values["android:changeTransform:parent");
        bool z = this.mReparent && !parentsMatch(viewGroup2, (android.view.objectGroup) transitionValues2.values["android:changeTransform:parent"));
        android.graphics.Matrix matrix = (android.graphics.Matrix) transitionValues.values["android:changeTransform:intermediateMatrix");
        if (matrix is not null) {
            transitionValues.values.Add("android:changeTransform:matrix", matrix);
        }
        android.graphics.Matrix matrix2 = (android.graphics.Matrix) transitionValues.values["android:changeTransform:intermediateParentMatrix");
        if (matrix2 is not null) {
            transitionValues.values.Add("android:changeTransform:parentMatrix", matrix2);
        }
        if (z) {
            setMatricesForParent(transitionValues, transitionValues2);
        }
        android.animation.objectAnimator objectAnimatorCreateTransformAnimator = createTransformAnimator(transitionValues, transitionValues2, z);
        if (z && objectAnimatorCreateTransformAnimator is not null && this.mUseOverlay) {
            createGhostobject(viewGroup, transitionValues, transitionValues2);
            return objectAnimatorCreateTransformAnimator;
        }
        if (!SUPPORTS_VIEW_REMOVAL_SUPPRESSION) {
            viewGroup2.endobjectTransition(transitionValues.view);
        }
        return objectAnimatorCreateTransformAnimator;
    }

    public bool GetReparent() {
        return this.mReparent;
    }

    public bool GetReparentWithOverlay() {
        return this.mUseOverlay;
    }

    public override java.lang.string[] GetTransitionProperties() {
        return sTransitionProperties;
    }

    public void SetReparent(bool z) {
        this.mReparent = z;
    }

    public void SetReparentWithOverlay(bool z) {
        this.mUseOverlay = z;
    }
}

