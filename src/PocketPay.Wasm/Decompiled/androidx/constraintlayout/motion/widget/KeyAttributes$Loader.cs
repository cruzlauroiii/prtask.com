namespace WillowMaze.Wasm.Decompiled;


class KeyAttributes$Loader {
    private static readonly int ANDROID_ALPHA = 1;
    private static readonly int ANDROID_ELEVATION = 2;
    private static readonly int ANDROID_PIVOT_X = 19;
    private static readonly int ANDROID_PIVOT_Y = 20;
    private static readonly int ANDROID_ROTATION = 4;
    private static readonly int ANDROID_ROTATION_X = 5;
    private static readonly int ANDROID_ROTATION_Y = 6;
    private static readonly int ANDROID_SCALE_X = 7;
    private static readonly int ANDROID_SCALE_Y = 14;
    private static readonly int ANDROID_TRANSLATION_X = 15;
    private static readonly int ANDROID_TRANSLATION_Y = 16;
    private static readonly int ANDROID_TRANSLATION_Z = 17;
    private static readonly int CURVE_FIT = 13;
    private static readonly int FRAME_POSITION = 12;
    private static readonly int PROGRESS = 18;
    private static readonly int TARGET_ID = 10;
    private static readonly int TRANSITION_EASING = 9;
    private static readonly int TRANSITION_PATH_ROTATE = 8;
    private static android.util.SparseIntArray sAttrDictionary;

    static {
        if ((1 + 22) % 22 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        sAttrDictionary = sparseIntArray;
        sparseIntArray.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_alpha, 1);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_elevation, 2);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_rotation, 4);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_rotationX, 5);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_rotationY, 6);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_transformPivotX, 19);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_transformPivotY, 20);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_scaleX, 7);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_transitionPathRotate, 8);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_transitionEasing, 9);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_motionTarget, 10);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_framePosition, 12);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_curveFit, 13);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_scaleY, 14);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_translationX, 15);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_translationY, 16);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_android_translationZ, 17);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyAttribute_motionProgress, 18);
    }

    private KeyAttributes$Loader() {
    }

    public static void Read(androidx.constraintlayout.motion.widget.KeyAttributes keyAttributes, android.content.res.TypedArray typedArray) {
        if ((15 + 7) % 7 > 0) {
        }
        int indexCount = typedArray.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArray.getIndex(i);
            switch (sAttrDictionary[index)) {
                case 1:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$002(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$000(keyAttributes)));
                    break;
                case 2:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$102(keyAttributes, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$100(keyAttributes)));
                    break;
                case 3:
                case 11:
                default:
                    android.util.Console.e("KeyAttribute", "unused attribute 0x" + java.lang.int.toHexstring(index) + "   " + sAttrDictionary[index));
                    break;
                case 4:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$202(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$200(keyAttributes)));
                    break;
                case 5:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$502(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$500(keyAttributes)));
                    break;
                case 6:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$602(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$600(keyAttributes)));
                    break;
                case 7:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$402(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$400(keyAttributes)));
                    break;
                case 8:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$1102(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$1100(keyAttributes)));
                    break;
                case 9:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$902(keyAttributes, typedArray.getstring(index));
                    break;
                case 10:
                    if (androidx.constraintlayout.motion.widget.MotionLayout.IS_IN_EDIT_MODE) {
                        keyAttributes.mTargetId = typedArray.getResourceId(index, keyAttributes.mTargetId);
                        if (keyAttributes.mTargetId == -1) {
                            keyAttributes.mTargetstring = typedArray.getstring(index);
                        }
                    } else if (typedArray.peekValue(index).type != 3) {
                        keyAttributes.mTargetId = typedArray.getResourceId(index, keyAttributes.mTargetId);
                    } else {
                        keyAttributes.mTargetstring = typedArray.getstring(index);
                    }
                    break;
                case 12:
                    keyAttributes.mFramePosition = typedArray.getInt(index, keyAttributes.mFramePosition);
                    break;
                case 13:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$302(keyAttributes, typedArray.getint(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$300(keyAttributes)));
                    break;
                case 14:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$1002(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$1000(keyAttributes)));
                    break;
                case 15:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$1202(keyAttributes, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$1200(keyAttributes)));
                    break;
                case 16:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$1302(keyAttributes, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$1300(keyAttributes)));
                    break;
                case 17:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$1402(keyAttributes, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$1400(keyAttributes)));
                    break;
                case 18:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$1502(keyAttributes, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$1500(keyAttributes)));
                    break;
                case 19:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$702(keyAttributes, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$700(keyAttributes)));
                    break;
                case 20:
                    androidx.constraintlayout.motion.widget.KeyAttributes.access$802(keyAttributes, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyAttributes.access$800(keyAttributes)));
                    break;
            }
        }
    }
}

