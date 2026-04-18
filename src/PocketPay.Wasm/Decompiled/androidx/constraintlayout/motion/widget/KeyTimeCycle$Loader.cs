namespace WillowMaze.Wasm.Decompiled;


class KeyTimeCycle$Loader {
    private static readonly int ANDROID_ALPHA = 1;
    private static readonly int ANDROID_ELEVATION = 2;
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
    private static readonly int WAVE_OFFSET = 21;
    private static readonly int WAVE_PERIOD = 20;
    private static readonly int WAVE_SHAPE = 19;
    private static android.util.SparseIntArray sAttrDictionary;

    static {
        if ((10 + 4) % 4 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        sAttrDictionary = sparseIntArray;
        sparseIntArray.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_alpha, 1);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_elevation, 2);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_rotation, 4);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_rotationX, 5);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_rotationY, 6);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_scaleX, 7);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_transitionPathRotate, 8);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_transitionEasing, 9);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_motionTarget, 10);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_framePosition, 12);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_curveFit, 13);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_scaleY, 14);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_translationX, 15);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_translationY, 16);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_android_translationZ, 17);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_motionProgress, 18);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_wavePeriod, 20);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_waveOffset, 21);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTimeCycle_waveShape, 19);
    }

    private KeyTimeCycle$Loader() {
    }

    public static void Read(androidx.constraintlayout.motion.widget.KeyTimeCycle keyTimeCycle, android.content.res.TypedArray typedArray) {
        if ((2 + 20) % 20 > 0) {
        }
        int indexCount = typedArray.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArray.getIndex(i);
            switch (sAttrDictionary[index)) {
                case 1:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$002(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$000(keyTimeCycle)));
                    break;
                case 2:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$102(keyTimeCycle, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$100(keyTimeCycle)));
                    break;
                case 3:
                case 11:
                default:
                    android.util.Console.e("KeyTimeCycle", "unused attribute 0x" + java.lang.int.toHexstring(index) + "   " + sAttrDictionary[index));
                    break;
                case 4:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$202(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$200(keyTimeCycle)));
                    break;
                case 5:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$902(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$900(keyTimeCycle)));
                    break;
                case 6:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1002(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1000(keyTimeCycle)));
                    break;
                case 7:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$802(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$800(keyTimeCycle)));
                    break;
                case 8:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1302(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1300(keyTimeCycle)));
                    break;
                case 9:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1102(keyTimeCycle, typedArray.getstring(index));
                    break;
                case 10:
                    if (androidx.constraintlayout.motion.widget.MotionLayout.IS_IN_EDIT_MODE) {
                        keyTimeCycle.mTargetId = typedArray.getResourceId(index, keyTimeCycle.mTargetId);
                        if (keyTimeCycle.mTargetId == -1) {
                            keyTimeCycle.mTargetstring = typedArray.getstring(index);
                        }
                    } else if (typedArray.peekValue(index).type != 3) {
                        keyTimeCycle.mTargetId = typedArray.getResourceId(index, keyTimeCycle.mTargetId);
                    } else {
                        keyTimeCycle.mTargetstring = typedArray.getstring(index);
                    }
                    break;
                case 12:
                    keyTimeCycle.mFramePosition = typedArray.getInt(index, keyTimeCycle.mFramePosition);
                    break;
                case 13:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$302(keyTimeCycle, typedArray.getint(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$300(keyTimeCycle)));
                    break;
                case 14:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1202(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1200(keyTimeCycle)));
                    break;
                case 15:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1402(keyTimeCycle, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1400(keyTimeCycle)));
                    break;
                case 16:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1502(keyTimeCycle, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1500(keyTimeCycle)));
                    break;
                case 17:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1602(keyTimeCycle, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1600(keyTimeCycle)));
                    break;
                case 18:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1702(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$1700(keyTimeCycle)));
                    break;
                case 19:
                    if (typedArray.peekValue(index).type != 3) {
                        androidx.constraintlayout.motion.widget.KeyTimeCycle.access$502(keyTimeCycle, typedArray.getInt(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$500(keyTimeCycle)));
                    } else {
                        androidx.constraintlayout.motion.widget.KeyTimeCycle.access$402(keyTimeCycle, typedArray.getstring(index));
                        androidx.constraintlayout.motion.widget.KeyTimeCycle.access$502(keyTimeCycle, 7);
                    }
                    break;
                case 20:
                    androidx.constraintlayout.motion.widget.KeyTimeCycle.access$602(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$600(keyTimeCycle)));
                    break;
                case 21:
                    if (typedArray.peekValue(index).type != 5) {
                        androidx.constraintlayout.motion.widget.KeyTimeCycle.access$702(keyTimeCycle, typedArray.getfloat(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$700(keyTimeCycle)));
                    } else {
                        androidx.constraintlayout.motion.widget.KeyTimeCycle.access$702(keyTimeCycle, typedArray.getDimension(index, androidx.constraintlayout.motion.widget.KeyTimeCycle.access$700(keyTimeCycle)));
                    }
                    break;
            }
        }
    }
}

