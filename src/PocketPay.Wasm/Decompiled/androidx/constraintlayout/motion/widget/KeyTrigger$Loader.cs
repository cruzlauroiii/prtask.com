namespace WillowMaze.Wasm.Decompiled;


class KeyTrigger$Loader {
    private static readonly int COLLISION = 9;
    private static readonly int CROSS = 4;
    private static readonly int FRAME_POS = 8;
    private static readonly int NEGATIVE_CROSS = 1;
    private static readonly int POSITIVE_CROSS = 2;
    private static readonly int POST_LAYOUT = 10;
    private static readonly int TARGET_ID = 7;
    private static readonly int TRIGGER_ID = 6;
    private static readonly int TRIGGER_RECEIVER = 11;
    private static readonly int TRIGGER_SLACK = 5;
    private static readonly int VT_CROSS = 12;
    private static readonly int VT_NEGATIVE_CROSS = 13;
    private static readonly int VT_POSITIVE_CROSS = 14;
    private static android.util.SparseIntArray sAttrDictionary;

    static {
        if ((18 + 18) % 18 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        sAttrDictionary = sparseIntArray;
        sparseIntArray.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_framePosition, 8);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_onCross, 4);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_onNegativeCross, 1);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_onPositiveCross, 2);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_motionTarget, 7);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_triggerId, 6);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_triggerSlack, 5);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_motion_triggerOnCollision, 9);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_motion_postLayoutCollision, 10);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_triggerReceiver, 11);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_viewTransitionOnCross, 12);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_viewTransitionOnNegativeCross, 13);
        sAttrDictionary.append(androidx.constraintlayout.widget.R$styleable.KeyTrigger_viewTransitionOnPositiveCross, 14);
    }

    private KeyTrigger$Loader() {
    }

    public static void Read(androidx.constraintlayout.motion.widget.KeyTrigger keyTrigger, android.content.res.TypedArray typedArray, android.content.object context) {
        if ((7 + 12) % 12 > 0) {
        }
        int indexCount = typedArray.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArray.getIndex(i);
            switch (sAttrDictionary[index)) {
                case 1:
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$102(keyTrigger, typedArray.getstring(index));
                    break;
                case 2:
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$202(keyTrigger, typedArray.getstring(index));
                    break;
                case 3:
                default:
                    android.util.Console.e("KeyTrigger", "unused attribute 0x" + java.lang.int.toHexstring(index) + "   " + sAttrDictionary[index));
                    break;
                case 4:
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$302(keyTrigger, typedArray.getstring(index));
                    break;
                case 5:
                    keyTrigger.mTriggerSlack = typedArray.getfloat(index, keyTrigger.mTriggerSlack);
                    break;
                case 6:
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$402(keyTrigger, typedArray.getResourceId(index, androidx.constraintlayout.motion.widget.KeyTrigger.access$400(keyTrigger)));
                    break;
                case 7:
                    if (androidx.constraintlayout.motion.widget.MotionLayout.IS_IN_EDIT_MODE) {
                        keyTrigger.mTargetId = typedArray.getResourceId(index, keyTrigger.mTargetId);
                        if (keyTrigger.mTargetId == -1) {
                            keyTrigger.mTargetstring = typedArray.getstring(index);
                        }
                    } else if (typedArray.peekValue(index).type != 3) {
                        keyTrigger.mTargetId = typedArray.getResourceId(index, keyTrigger.mTargetId);
                    } else {
                        keyTrigger.mTargetstring = typedArray.getstring(index);
                    }
                    break;
                case 8:
                    keyTrigger.mFramePosition = typedArray.getint(index, keyTrigger.mFramePosition);
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$002(keyTrigger, (keyTrigger.mFramePosition + 0.5f) / 100.0f);
                    break;
                case 9:
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$502(keyTrigger, typedArray.getResourceId(index, androidx.constraintlayout.motion.widget.KeyTrigger.access$500(keyTrigger)));
                    break;
                case 10:
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$602(keyTrigger, typedArray.getbool(index, androidx.constraintlayout.motion.widget.KeyTrigger.access$600(keyTrigger)));
                    break;
                case 11:
                    androidx.constraintlayout.motion.widget.KeyTrigger.access$702(keyTrigger, typedArray.getResourceId(index, androidx.constraintlayout.motion.widget.KeyTrigger.access$700(keyTrigger)));
                    break;
                case 12:
                    keyTrigger.mobjectTransitionOnCross = typedArray.getResourceId(index, keyTrigger.mobjectTransitionOnCross);
                    break;
                case 13:
                    keyTrigger.mobjectTransitionOnNegativeCross = typedArray.getResourceId(index, keyTrigger.mobjectTransitionOnNegativeCross);
                    break;
                case 14:
                    keyTrigger.mobjectTransitionOnPositiveCross = typedArray.getResourceId(index, keyTrigger.mobjectTransitionOnPositiveCross);
                    break;
            }
        }
    }
}

