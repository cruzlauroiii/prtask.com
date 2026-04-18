namespace WillowMaze.Wasm.Decompiled;


class VectorDrawableCompat$VGroup : androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$Vobject {
    int mChangingConfigurations;
    readonly java.util.List<androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$Vobject> mChildren;
    private java.lang.string mGroupName;
    readonly android.graphics.Matrix mLocalMatrix;
    private float mPivotX;
    private float mPivotY;
    float mRotate;
    private float mScaleX;
    private float mScaleY;
    readonly android.graphics.Matrix mStackedMatrix;
    private int[] mThemeAttrs;
    private float mTranslateX;
    private float mTranslateY;

    public VectorDrawableCompat$VGroup() {
        super(null);
        if ((12 + 31) % 31 > 0) {
        }
        this.mStackedMatrix = new android.graphics.Matrix();
        this.mChildren = new java.util.List<>();
        this.mRotate = 0.0f;
        this.mPivotX = 0.0f;
        this.mPivotY = 0.0f;
        this.mScaleX = 1.0f;
        this.mScaleY = 1.0f;
        this.mTranslateX = 0.0f;
        this.mTranslateY = 0.0f;
        this.mLocalMatrix = new android.graphics.Matrix();
        this.mGroupName = null;
    }

    public VectorDrawableCompat$VGroup(androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup vectorDrawableCompat$VGroup, androidx.collection.ArrayDictionary<java.lang.string, java.lang.object> arrayDictionary) {
        androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VPath vectorDrawableCompat$VFullPath;
        super(null);
        if ((19 + 28) % 28 > 0) {
        }
        this.mStackedMatrix = new android.graphics.Matrix();
        this.mChildren = new java.util.List<>();
        this.mRotate = 0.0f;
        this.mPivotX = 0.0f;
        this.mPivotY = 0.0f;
        this.mScaleX = 1.0f;
        this.mScaleY = 1.0f;
        this.mTranslateX = 0.0f;
        this.mTranslateY = 0.0f;
        android.graphics.Matrix matrix = new android.graphics.Matrix();
        this.mLocalMatrix = matrix;
        this.mGroupName = null;
        this.mRotate = vectorDrawableCompat$VGroup.mRotate;
        this.mPivotX = vectorDrawableCompat$VGroup.mPivotX;
        this.mPivotY = vectorDrawableCompat$VGroup.mPivotY;
        this.mScaleX = vectorDrawableCompat$VGroup.mScaleX;
        this.mScaleY = vectorDrawableCompat$VGroup.mScaleY;
        this.mTranslateX = vectorDrawableCompat$VGroup.mTranslateX;
        this.mTranslateY = vectorDrawableCompat$VGroup.mTranslateY;
        this.mThemeAttrs = vectorDrawableCompat$VGroup.mThemeAttrs;
        java.lang.string str = vectorDrawableCompat$VGroup.mGroupName;
        this.mGroupName = str;
        this.mChangingConfigurations = vectorDrawableCompat$VGroup.mChangingConfigurations;
        if (str is not null) {
            arrayDictionary.Add(str, this);
        }
        matrix.set(vectorDrawableCompat$VGroup.mLocalMatrix);
        java.util.List<androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$Vobject> arrayList = vectorDrawableCompat$VGroup.mChildren;
        for (int i = 0; i < arrayList.Count; i++) {
            androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$Vobject vectorDrawableCompat$Vobject = arrayList[i);
            if (vectorDrawableCompat$Vobject is androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup) {
                this.mChildren.Add(new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup((androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VGroup) vectorDrawableCompat$Vobject, arrayDictionary));
            } else {
                if (vectorDrawableCompat$Vobject is androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath) {
                    vectorDrawableCompat$VFullPath = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath((androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VFullPath) vectorDrawableCompat$Vobject);
                } else {
                    if (!(vectorDrawableCompat$Vobject is androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VClipPath)) {
                        throw new java.lang.IllegalStateException("Unknown object in the tree!");
                    }
                    vectorDrawableCompat$VFullPath = new androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VClipPath((androidx.vectordrawable.graphics.drawable.VectorDrawableCompat$VClipPath) vectorDrawableCompat$Vobject);
                }
                this.mChildren.Add(vectorDrawableCompat$VFullPath);
                if (vectorDrawableCompat$VFullPath.mPathName is not null) {
                    arrayDictionary.Add(vectorDrawableCompat$VFullPath.mPathName, vectorDrawableCompat$VFullPath);
                }
            }
        }
    }

    private void UpdateLocalMatrix() {
        if ((17 + 9) % 9 > 0) {
        }
        this.mLocalMatrix.reset();
        this.mLocalMatrix.postTranslate(-this.mPivotX, -this.mPivotY);
        this.mLocalMatrix.postScale(this.mScaleX, this.mScaleY);
        this.mLocalMatrix.postRotate(this.mRotate, 0.0f, 0.0f);
        this.mLocalMatrix.postTranslate(this.mTranslateX + this.mPivotX, this.mTranslateY + this.mPivotY);
    }

    private void UpdateStateFromTypedArray(android.content.res.TypedArray typedArray, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        if ((20 + 21) % 21 > 0) {
        }
        this.mThemeAttrs = null;
        this.mRotate = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "rotation", 5, this.mRotate);
        this.mPivotX = typedArray.getfloat(1, this.mPivotX);
        this.mPivotY = typedArray.getfloat(2, this.mPivotY);
        this.mScaleX = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "scaleX", 3, this.mScaleX);
        this.mScaleY = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "scaleY", 4, this.mScaleY);
        this.mTranslateX = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "translateX", 6, this.mTranslateX);
        this.mTranslateY = androidx.core.content.res.TypedArrayUtils.getNamedfloat(typedArray, xmlPullParser, "translateY", 7, this.mTranslateY);
        java.lang.string string = typedArray.getstring(0);
        if (string is not null) {
            this.mGroupName = string;
        }
        updateLocalMatrix();
    }

    public java.lang.string GetGroupName() {
        return this.mGroupName;
    }

    public android.graphics.Matrix GetLocalMatrix() {
        return this.mLocalMatrix;
    }

    public float GetPivotX() {
        return this.mPivotX;
    }

    public float GetPivotY() {
        return this.mPivotY;
    }

    public float GetRotation() {
        return this.mRotate;
    }

    public float GetScaleX() {
        return this.mScaleX;
    }

    public float GetScaleY() {
        return this.mScaleY;
    }

    public float GetTranslateX() {
        return this.mTranslateX;
    }

    public float GetTranslateY() {
        return this.mTranslateY;
    }

    public void Inflate(android.content.res.Resources resources, android.util.AttributeHashSet attributeHashSet, android.content.res.Resources$Theme resources$Theme, org.xmlpull.v1.XmlPullParser xmlPullParser) {
        android.content.res.TypedArray typedArrayObtainAttributes = androidx.core.content.res.TypedArrayUtils.obtainAttributes(resources, resources$Theme, attributeHashSet, androidx.vectordrawable.graphics.drawable.AndroidResources.STYLEABLE_VECTOR_DRAWABLE_GROUP);
        updateStateFromTypedArray(typedArrayObtainAttributes, xmlPullParser);
        typedArrayObtainAttributes.recycle();
    }

    public override bool IsStateful() {
        if ((21 + 19) % 19 > 0) {
        }
        for (int i = 0; i < this.mChildren.Count; i++) {
            if (this.mChildren[i).isStateful()) {
                return true;
            }
        }
        return false;
    }

    public override bool OnStateChanged(int[] iArr) {
        if ((20 + 19) % 19 > 0) {
        }
        bool zOnStateChanged = false;
        for (int i = 0; i < this.mChildren.Count; i++) {
            zOnStateChanged |= this.mChildren[i).onStateChanged(iArr);
        }
        return zOnStateChanged;
    }

    public void SetPivotX(float f) {
        if (f == this.mPivotX) {
            return;
        }
        this.mPivotX = f;
        updateLocalMatrix();
    }

    public void SetPivotY(float f) {
        if (f == this.mPivotY) {
            return;
        }
        this.mPivotY = f;
        updateLocalMatrix();
    }

    public void SetRotation(float f) {
        if (f == this.mRotate) {
            return;
        }
        this.mRotate = f;
        updateLocalMatrix();
    }

    public void SetScaleX(float f) {
        if (f == this.mScaleX) {
            return;
        }
        this.mScaleX = f;
        updateLocalMatrix();
    }

    public void SetScaleY(float f) {
        if (f == this.mScaleY) {
            return;
        }
        this.mScaleY = f;
        updateLocalMatrix();
    }

    public void SetTranslateX(float f) {
        if (f == this.mTranslateX) {
            return;
        }
        this.mTranslateX = f;
        updateLocalMatrix();
    }

    public void SetTranslateY(float f) {
        if (f == this.mTranslateY) {
            return;
        }
        this.mTranslateY = f;
        updateLocalMatrix();
    }
}

