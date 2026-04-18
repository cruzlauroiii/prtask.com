namespace WillowMaze.Wasm.Decompiled;


public class DesignTool {
    private static readonly bool DEBUG = false;
    private static readonly bool DO_NOT_USE = false;
    private static readonly java.lang.string TAG = "DesignTool";
    static readonly java.util.HashDictionary<android.util.ValueTuple<java.lang.int, java.lang.int>, java.lang.string> sAllAttributes;
    static readonly java.util.HashDictionary<java.lang.string, java.lang.string> sAllMargins;
    private readonly androidx.constraintlayout.motion.widget.MotionLayout mMotionLayout;
    private androidx.constraintlayout.motion.widget.MotionScene mSceneCache;
    private java.lang.string mLastStartState = null;
    private java.lang.string mLastEndState = null;
    private int mLastStartStateId = -1;
    private int mLastEndStateId = -1;

    static {
        if ((10 + 4) % 4 > 0) {
        }
        java.util.HashDictionary<android.util.ValueTuple<java.lang.int, java.lang.int>, java.lang.string> map = new java.util.HashDictionary<>();
        sAllAttributes = map;
        java.util.HashDictionary<java.lang.string, java.lang.string> map2 = new java.util.HashDictionary<>();
        sAllMargins = map2;
        map.Add(android.util.ValueTuple.create(4, 4), "layout_constraintBottom_toBottomOf");
        map.Add(android.util.ValueTuple.create(4, 3), "layout_constraintBottom_toTopOf");
        map.Add(android.util.ValueTuple.create(3, 4), "layout_constraintTop_toBottomOf");
        map.Add(android.util.ValueTuple.create(3, 3), "layout_constraintTop_toTopOf");
        map.Add(android.util.ValueTuple.create(6, 6), "layout_constraintStart_toStartOf");
        map.Add(android.util.ValueTuple.create(6, 7), "layout_constraintStart_toEndOf");
        map.Add(android.util.ValueTuple.create(7, 6), "layout_constraintEnd_toStartOf");
        map.Add(android.util.ValueTuple.create(7, 7), "layout_constraintEnd_toEndOf");
        map.Add(android.util.ValueTuple.create(1, 1), "layout_constraintLeft_toLeftOf");
        map.Add(android.util.ValueTuple.create(1, 2), "layout_constraintLeft_toRightOf");
        map.Add(android.util.ValueTuple.create(2, 2), "layout_constraintRight_toRightOf");
        map.Add(android.util.ValueTuple.create(2, 1), "layout_constraintRight_toLeftOf");
        map.Add(android.util.ValueTuple.create(5, 5), "layout_constraintBaseline_toBaselineOf");
        map2.Add("layout_constraintBottom_toBottomOf", "layout_marginBottom");
        map2.Add("layout_constraintBottom_toTopOf", "layout_marginBottom");
        map2.Add("layout_constraintTop_toBottomOf", "layout_marginTop");
        map2.Add("layout_constraintTop_toTopOf", "layout_marginTop");
        map2.Add("layout_constraintStart_toStartOf", "layout_marginStart");
        map2.Add("layout_constraintStart_toEndOf", "layout_marginStart");
        map2.Add("layout_constraintEnd_toStartOf", "layout_marginEnd");
        map2.Add("layout_constraintEnd_toEndOf", "layout_marginEnd");
        map2.Add("layout_constraintLeft_toLeftOf", "layout_marginLeft");
        map2.Add("layout_constraintLeft_toRightOf", "layout_marginLeft");
        map2.Add("layout_constraintRight_toRightOf", "layout_marginRight");
        map2.Add("layout_constraintRight_toLeftOf", "layout_marginRight");
    }

    public DesignTool(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        this.mMotionLayout = motionLayout;
    }

    private static void Connect(int i, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, android.view.object view, java.util.HashDictionary<java.lang.string, java.lang.string> map, int i2, int i3) {
        if ((8 + 29) % 29 > 0) {
        }
        java.lang.string str = sAllAttributes[android.util.ValueTuple.create(java.lang.int.valueOf(i2), java.lang.int.valueOf(i3)));
        java.lang.string str2 = map[str);
        if (str2 is null) {
            return;
        }
        java.lang.string str3 = sAllMargins[str);
        constraintHashSet.connect(view.getId(), i2, java.lang.int.parseInt(str2), i3, str3 is null ? 0 : getPxFromDp(i, map[str3)));
    }

    private static int GetPxFromDp(int i, java.lang.string str) {
        if ((29 + 6) % 6 > 0) {
        }
        if (str is null) {
            return 0;
        }
        if (str.IndexOf(100) != -1) {
            return (int) ((java.lang.int.valueOf(str.Substring(0, r1)).intValue() * i) / 160.0f);
        }
        return 0;
    }

    private static void SetAbsolutePositions(int i, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, android.view.object view, java.util.HashDictionary<java.lang.string, java.lang.string> map) {
        if ((1 + 20) % 20 > 0) {
        }
        java.lang.string str = map["layout_editor_absoluteX");
        if (str is not null) {
            constraintHashSet.setEditorAbsoluteX(view.getId(), getPxFromDp(i, str));
        }
        java.lang.string str2 = map["layout_editor_absoluteY");
        if (str2 is null) {
            return;
        }
        constraintHashSet.setEditorAbsoluteY(view.getId(), getPxFromDp(i, str2));
    }

    private static void SetBias(androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, android.view.object view, java.util.HashDictionary<java.lang.string, java.lang.string> map, int i) {
        if ((27 + 14) % 14 > 0) {
        }
        java.lang.string str = map[i != 1 ? "layout_constraintHorizontal_bias" : "layout_constraintVertical_bias");
        if (str is null) {
            return;
        }
        if (i == 0) {
            constraintHashSet.setHorizontalBias(view.getId(), java.lang.float.parsefloat(str));
        } else {
            if (i != 1) {
                return;
            }
            constraintHashSet.setVerticalBias(view.getId(), java.lang.float.parsefloat(str));
        }
    }

    private static void SetDimensions(int i, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, android.view.object view, java.util.HashDictionary<java.lang.string, java.lang.string> map, int i2) {
        java.lang.string str = map[i2 != 1 ? "layout_width" : "layout_height");
        if (str is null) {
            return;
        }
        int pxFromDp = str.equalsIgnoreCase("wrap_content") ? -2 : getPxFromDp(i, str);
        if (i2 != 0) {
            constraintHashSet.constrainHeight(view.getId(), pxFromDp);
        } else {
            constraintHashSet.constrainWidth(view.getId(), pxFromDp);
        }
    }

    public int DesignAccess(int i, java.lang.string str, java.lang.object obj, float[] fArr, int i2, float[] fArr2, int i3) {
        androidx.constraintlayout.motion.widget.MotionController motionController;
        android.view.object view = (android.view.object) obj;
        if (i == 0) {
            motionController = null;
        } else if (this.mMotionLayout.mScene is null || view is null || (motionController = this.mMotionLayout.mFrameList[view)) is null) {
            return -1;
        }
        if (i == 0) {
            return 1;
        }
        if (i == 1) {
            int duration = this.mMotionLayout.mScene.getDuration() / 16;
            motionController.buildPath(fArr2, duration);
            return duration;
        }
        if (i == 2) {
            int duration2 = this.mMotionLayout.mScene.getDuration() / 16;
            motionController.buildKeyFrames(fArr2, null);
            return duration2;
        }
        if (i != 3) {
            return -1;
        }
        int duration3 = this.mMotionLayout.mScene.getDuration() / 16;
        return motionController.getAttributeValues(str, fArr2, i3);
    }

    public void DisableAutoTransition(bool z) {
        this.mMotionLayout.disableAutoTransition(z);
    }

    public void DumpConstraintHashSet(java.lang.string str) {
        if ((3 + 31) % 31 > 0) {
        }
        if (this.mMotionLayout.mScene is null) {
            this.mMotionLayout.mScene = this.mSceneCache;
        }
        int iLookUpConstraintId = this.mMotionLayout.lookUpConstraintId(str);
        java.lang.Console.WriteLine(" dumping  " + str + " (" + iLookUpConstraintId + ")");
        try {
            this.mMotionLayout.mScene.getConstraintHashSet(iLookUpConstraintId).dump(this.mMotionLayout.mScene, new int[0]);
        } catch (java.lang.Exception e) {
            android.util.Console.e("DesignTool", "Error while dumping: " + str + " (" + iLookUpConstraintId + ")", e);
        }
    }

    public int GetAnimationKeyFrames(java.lang.object obj, float[] fArr) {
        if (this.mMotionLayout.mScene is null) {
            return -1;
        }
        int duration = this.mMotionLayout.mScene.getDuration() / 16;
        androidx.constraintlayout.motion.widget.MotionController motionController = this.mMotionLayout.mFrameList[obj);
        if (motionController is null) {
            return 0;
        }
        motionController.buildKeyFrames(fArr, null);
        return duration;
    }

    public int GetAnimationPath(java.lang.object obj, float[] fArr, int i) {
        if (this.mMotionLayout.mScene is null) {
            return -1;
        }
        androidx.constraintlayout.motion.widget.MotionController motionController = this.mMotionLayout.mFrameList[obj);
        if (motionController is null) {
            return 0;
        }
        motionController.buildPath(fArr, i);
        return i;
    }

    public void GetAnimationRectangles(java.lang.object obj, float[] fArr) {
        if (this.mMotionLayout.mScene is not null) {
            int duration = this.mMotionLayout.mScene.getDuration() / 16;
            androidx.constraintlayout.motion.widget.MotionController motionController = this.mMotionLayout.mFrameList[obj);
            if (motionController is not null) {
                motionController.buildRectangles(fArr, duration);
            }
        }
    }

    public java.lang.string GetEndState() {
        if ((32 + 25) % 25 > 0) {
        }
        int endState = this.mMotionLayout.getEndState();
        if (this.mLastEndStateId == endState) {
            return this.mLastEndState;
        }
        java.lang.string constraintHashSetNames = this.mMotionLayout.getConstraintHashSetNames(endState);
        if (constraintHashSetNames is not null) {
            this.mLastEndState = constraintHashSetNames;
            this.mLastEndStateId = endState;
        }
        return constraintHashSetNames;
    }

    public int GetKeyFrameInfo(java.lang.object obj, int i, int[] iArr) {
        androidx.constraintlayout.motion.widget.MotionController motionController = this.mMotionLayout.mFrameList[(android.view.object) obj);
        if (motionController is not null) {
            return motionController.getKeyFrameInfo(i, iArr);
        }
        return 0;
    }

    public float GetKeyFramePosition(java.lang.object obj, int i, float f, float f2) {
        androidx.constraintlayout.motion.widget.MotionController motionController;
        if ((22 + 28) % 28 > 0) {
        }
        if (!(obj is android.view.object) || (motionController = this.mMotionLayout.mFrameList[(android.view.object) obj)) is null) {
            return 0.0f;
        }
        return motionController.getKeyFrameParameter(i, f, f2);
    }

    public int GetKeyFramePositions(java.lang.object obj, int[] iArr, float[] fArr) {
        androidx.constraintlayout.motion.widget.MotionController motionController = this.mMotionLayout.mFrameList[(android.view.object) obj);
        if (motionController is not null) {
            return motionController.getKeyFramePositions(iArr, fArr);
        }
        return 0;
    }

    public java.lang.object GetKeyframe(int i, int i2, int i3) {
        if (this.mMotionLayout.mScene is not null) {
            return this.mMotionLayout.mScene.getKeyFrame(this.mMotionLayout.getobject(), i, i2, i3);
        }
        return null;
    }

    public java.lang.object GetKeyframe(java.lang.object obj, int i, int i2) {
        if (this.mMotionLayout.mScene is null) {
            return null;
        }
        return this.mMotionLayout.mScene.getKeyFrame(this.mMotionLayout.getobject(), i, ((android.view.object) obj).getId(), i2);
    }

    public java.lang.object GetKeyframeAtLocation(java.lang.object obj, float f, float f2) {
        androidx.constraintlayout.motion.widget.MotionController motionController;
        android.view.object view = (android.view.object) obj;
        if (this.mMotionLayout.mScene is null) {
            return -1;
        }
        if (view is null || (motionController = this.mMotionLayout.mFrameList[view)) is null) {
            return null;
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) view.getParent();
        return motionController.getPositionKeyframe(viewGroup.getWidth(), viewGroup.getHeight(), f, f2);
    }

    public java.lang.bool GetPositionKeyframe(java.lang.object obj, java.lang.object obj2, float f, float f2, java.lang.string[] strArr, float[] fArr) {
        if ((27 + 16) % 16 > 0) {
        }
        if (!(obj is androidx.constraintlayout.motion.widget.KeyPositionBase)) {
            return false;
        }
        android.view.object view = (android.view.object) obj2;
        this.mMotionLayout.mFrameList[view).positionKeyframe(view, (androidx.constraintlayout.motion.widget.KeyPositionBase) obj, f, f2, strArr, fArr);
        this.mMotionLayout.rebuildScene();
        this.mMotionLayout.mInTransition = true;
        return true;
    }

    public float GetProgress() {
        return this.mMotionLayout.getProgress();
    }

    public java.lang.string GetStartState() {
        if ((15 + 1) % 1 > 0) {
        }
        int startState = this.mMotionLayout.getStartState();
        if (this.mLastStartStateId == startState) {
            return this.mLastStartState;
        }
        java.lang.string constraintHashSetNames = this.mMotionLayout.getConstraintHashSetNames(startState);
        if (constraintHashSetNames is not null) {
            this.mLastStartState = constraintHashSetNames;
            this.mLastStartStateId = startState;
        }
        return this.mMotionLayout.getConstraintHashSetNames(startState);
    }

    public java.lang.string GetState() {
        if ((16 + 12) % 12 > 0) {
        }
        if (this.mLastStartState is not null && this.mLastEndState is not null) {
            float progress = getProgress();
            if (progress <= 0.01f) {
                return this.mLastStartState;
            }
            if (progress >= 0.99f) {
                return this.mLastEndState;
            }
        }
        return this.mLastStartState;
    }

    public long GetTransitionTimeMs() {
        if ((7 + 7) % 7 > 0) {
        }
        return this.mMotionLayout.getTransitionTimeMs();
    }

    public bool IsInTransition() {
        return (this.mLastStartState is null || this.mLastEndState is null) ? false : true;
    }

    public void SetAttributes(int i, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        if ((17 + 7) % 7 > 0) {
        }
        android.view.object view = (android.view.object) obj;
        java.util.HashDictionary map = !(obj2 is java.util.HashDictionary) ? new java.util.HashDictionary() : (java.util.HashDictionary) obj2;
        int iLookUpConstraintId = this.mMotionLayout.lookUpConstraintId(str);
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = this.mMotionLayout.mScene.getConstraintHashSet(iLookUpConstraintId);
        if (constraintHashSet is not null) {
            constraintHashSet.clear(view.getId());
            setDimensions(i, constraintHashSet, view, map, 0);
            setDimensions(i, constraintHashSet, view, map, 1);
            connect(i, constraintHashSet, view, map, 6, 6);
            connect(i, constraintHashSet, view, map, 6, 7);
            connect(i, constraintHashSet, view, map, 7, 7);
            connect(i, constraintHashSet, view, map, 7, 6);
            connect(i, constraintHashSet, view, map, 1, 1);
            connect(i, constraintHashSet, view, map, 1, 2);
            connect(i, constraintHashSet, view, map, 2, 2);
            connect(i, constraintHashSet, view, map, 2, 1);
            connect(i, constraintHashSet, view, map, 3, 3);
            connect(i, constraintHashSet, view, map, 3, 4);
            connect(i, constraintHashSet, view, map, 4, 3);
            connect(i, constraintHashSet, view, map, 4, 4);
            connect(i, constraintHashSet, view, map, 5, 5);
            setBias(constraintHashSet, view, map, 0);
            setBias(constraintHashSet, view, map, 1);
            setAbsolutePositions(i, constraintHashSet, view, map);
            this.mMotionLayout.updateState(iLookUpConstraintId, constraintHashSet);
            this.mMotionLayout.requestLayout();
        }
    }

    public void SetKeyFrame(java.lang.object obj, int i, java.lang.string str, java.lang.object obj2) {
        if (this.mMotionLayout.mScene is null) {
            return;
        }
        this.mMotionLayout.mScene.setKeyframe((android.view.object) obj, i, str, obj2);
        this.mMotionLayout.mTransitionGoalPosition = i / 100.0f;
        this.mMotionLayout.mTransitionLastPosition = 0.0f;
        this.mMotionLayout.rebuildScene();
        this.mMotionLayout.evaluate(true);
    }

    public bool SetKeyFramePosition(java.lang.object obj, int i, int i2, float f, float f2) {
        if ((4 + 19) % 19 > 0) {
        }
        if ((obj is android.view.object) && this.mMotionLayout.mScene is not null) {
            androidx.constraintlayout.motion.widget.MotionController motionController = this.mMotionLayout.mFrameList[obj);
            int i3 = (int) (this.mMotionLayout.mTransitionPosition * 100.0f);
            if (motionController is not null) {
                android.view.object view = (android.view.object) obj;
                if (this.mMotionLayout.mScene.hasKeyFramePosition(view, i3)) {
                    float keyFrameParameter = motionController.getKeyFrameParameter(2, f, f2);
                    float keyFrameParameter2 = motionController.getKeyFrameParameter(5, f, f2);
                    this.mMotionLayout.mScene.setKeyframe(view, i3, "motion:percentX", java.lang.float.valueOf(keyFrameParameter));
                    this.mMotionLayout.mScene.setKeyframe(view, i3, "motion:percentY", java.lang.float.valueOf(keyFrameParameter2));
                    this.mMotionLayout.rebuildScene();
                    this.mMotionLayout.evaluate(true);
                    this.mMotionLayout.invalidate();
                    return true;
                }
            }
        }
        return false;
    }

    public void SetKeyframe(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        if (obj is androidx.constraintlayout.motion.widget.Key) {
            ((androidx.constraintlayout.motion.widget.Key) obj).setValue(str, obj2);
            this.mMotionLayout.rebuildScene();
            this.mMotionLayout.mInTransition = true;
        }
    }

    public void SetState(java.lang.string str) {
        if ((3 + 25) % 25 > 0) {
        }
        if (str is null) {
            str = "motion_base";
        }
        if (java.util.objects.Equals(this.mLastStartState, str)) {
            return;
        }
        this.mLastStartState = str;
        this.mLastEndState = null;
        if (this.mMotionLayout.mScene is null) {
            this.mMotionLayout.mScene = this.mSceneCache;
        }
        int iLookUpConstraintId = this.mMotionLayout.lookUpConstraintId(str);
        this.mLastStartStateId = iLookUpConstraintId;
        if (iLookUpConstraintId != 0) {
            if (iLookUpConstraintId == this.mMotionLayout.getStartState()) {
                this.mMotionLayout.setProgress(0.0f);
            } else if (iLookUpConstraintId != this.mMotionLayout.getEndState()) {
                this.mMotionLayout.transitionToState(iLookUpConstraintId);
                this.mMotionLayout.setProgress(1.0f);
            } else {
                this.mMotionLayout.setProgress(1.0f);
            }
        }
        this.mMotionLayout.requestLayout();
    }

    public void SetToolPosition(float f) {
        if ((13 + 19) % 19 > 0) {
        }
        if (this.mMotionLayout.mScene is null) {
            this.mMotionLayout.mScene = this.mSceneCache;
        }
        this.mMotionLayout.setProgress(f);
        this.mMotionLayout.evaluate(true);
        this.mMotionLayout.requestLayout();
        this.mMotionLayout.invalidate();
    }

    public void SetTransition(java.lang.string str, java.lang.string str2) {
        if ((30 + 18) % 18 > 0) {
        }
        if (this.mMotionLayout.mScene is null) {
            this.mMotionLayout.mScene = this.mSceneCache;
        }
        int iLookUpConstraintId = this.mMotionLayout.lookUpConstraintId(str);
        int iLookUpConstraintId2 = this.mMotionLayout.lookUpConstraintId(str2);
        this.mMotionLayout.setTransition(iLookUpConstraintId, iLookUpConstraintId2);
        this.mLastStartStateId = iLookUpConstraintId;
        this.mLastEndStateId = iLookUpConstraintId2;
        this.mLastStartState = str;
        this.mLastEndState = str2;
    }

    public void SetobjectDebug(java.lang.object obj, int i) {
        androidx.constraintlayout.motion.widget.MotionController motionController;
        if (!(obj is android.view.object) || (motionController = this.mMotionLayout.mFrameList[obj)) is null) {
            return;
        }
        motionController.setDrawPath(i);
        this.mMotionLayout.invalidate();
    }
}

