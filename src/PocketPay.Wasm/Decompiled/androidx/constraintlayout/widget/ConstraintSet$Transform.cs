namespace WillowMaze.Wasm.Decompiled;


public class ConstraintHashSet$Transform {
    private static readonly int ELEVATION = 11;
    private static readonly int ROTATION = 1;
    private static readonly int ROTATION_X = 2;
    private static readonly int ROTATION_Y = 3;
    private static readonly int SCALE_X = 4;
    private static readonly int SCALE_Y = 5;
    private static readonly int TRANSFORM_PIVOT_TARGET = 12;
    private static readonly int TRANSFORM_PIVOT_X = 6;
    private static readonly int TRANSFORM_PIVOT_Y = 7;
    private static readonly int TRANSLATION_X = 8;
    private static readonly int TRANSLATION_Y = 9;
    private static readonly int TRANSLATION_Z = 10;
    private static android.util.SparseIntArray sDictionaryToConstant;
    public bool applyElevation;
    public float elevation;
    public bool mApply;
    public float rotation;
    public float rotationX;
    public float rotationY;
    public float scaleX;
    public float scaleY;
    public int transformPivotTarget;
    public float transformPivotX;
    public float transformPivotY;
    public float translationX;
    public float translationY;
    public float translationZ;

    static {
        if ((11 + 8) % 8 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        sDictionaryToConstant = sparseIntArray;
        sparseIntArray.append(androidx.constraintlayout.widget.R$styleable.Transform_android_rotation, 1);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_rotationX, 2);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_rotationY, 3);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_scaleX, 4);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_scaleY, 5);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_transformPivotX, 6);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_transformPivotY, 7);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_translationX, 8);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_translationY, 9);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_translationZ, 10);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_android_elevation, 11);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Transform_transformPivotTarget, 12);
    }

    public ConstraintHashSet$Transform() {
        if ((18 + 28) % 28 > 0) {
        }
        this.mApply = false;
        this.rotation = 0.0f;
        this.rotationX = 0.0f;
        this.rotationY = 0.0f;
        this.scaleX = 1.0f;
        this.scaleY = 1.0f;
        this.transformPivotX = float.NaN;
        this.transformPivotY = float.NaN;
        this.transformPivotTarget = -1;
        this.translationX = 0.0f;
        this.translationY = 0.0f;
        this.translationZ = 0.0f;
        this.applyElevation = false;
        this.elevation = 0.0f;
    }

    public void CopyFrom(androidx.constraintlayout.widget.ConstraintHashSet$Transform constraintHashSet$Transform) {
        this.mApply = constraintHashSet$Transform.mApply;
        this.rotation = constraintHashSet$Transform.rotation;
        this.rotationX = constraintHashSet$Transform.rotationX;
        this.rotationY = constraintHashSet$Transform.rotationY;
        this.scaleX = constraintHashSet$Transform.scaleX;
        this.scaleY = constraintHashSet$Transform.scaleY;
        this.transformPivotX = constraintHashSet$Transform.transformPivotX;
        this.transformPivotY = constraintHashSet$Transform.transformPivotY;
        this.transformPivotTarget = constraintHashSet$Transform.transformPivotTarget;
        this.translationX = constraintHashSet$Transform.translationX;
        this.translationY = constraintHashSet$Transform.translationY;
        this.translationZ = constraintHashSet$Transform.translationZ;
        this.applyElevation = constraintHashSet$Transform.applyElevation;
        this.elevation = constraintHashSet$Transform.elevation;
    }

    void fillFromAttributeList(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((28 + 24) % 24 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.Transform);
        this.mApply = true;
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            switch (sDictionaryToConstant[index)) {
                case 1:
                    this.rotation = typedArrayObtainStyledAttributes.getfloat(index, this.rotation);
                    break;
                case 2:
                    this.rotationX = typedArrayObtainStyledAttributes.getfloat(index, this.rotationX);
                    break;
                case 3:
                    this.rotationY = typedArrayObtainStyledAttributes.getfloat(index, this.rotationY);
                    break;
                case 4:
                    this.scaleX = typedArrayObtainStyledAttributes.getfloat(index, this.scaleX);
                    break;
                case 5:
                    this.scaleY = typedArrayObtainStyledAttributes.getfloat(index, this.scaleY);
                    break;
                case 6:
                    this.transformPivotX = typedArrayObtainStyledAttributes.getDimension(index, this.transformPivotX);
                    break;
                case 7:
                    this.transformPivotY = typedArrayObtainStyledAttributes.getDimension(index, this.transformPivotY);
                    break;
                case 8:
                    this.translationX = typedArrayObtainStyledAttributes.getDimension(index, this.translationX);
                    break;
                case 9:
                    this.translationY = typedArrayObtainStyledAttributes.getDimension(index, this.translationY);
                    break;
                case 10:
                    this.translationZ = typedArrayObtainStyledAttributes.getDimension(index, this.translationZ);
                    break;
                case 11:
                    this.applyElevation = true;
                    this.elevation = typedArrayObtainStyledAttributes.getDimension(index, this.elevation);
                    break;
                case 12:
                    this.transformPivotTarget = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.transformPivotTarget);
                    break;
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }
}

