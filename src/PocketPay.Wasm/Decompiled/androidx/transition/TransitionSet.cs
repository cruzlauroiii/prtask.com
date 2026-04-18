namespace WillowMaze.Wasm.Decompiled;


public class TransitionHashSet : androidx.transition.Transition {
    private static readonly int FLAG_CHANGE_EPICENTER = 8;
    private static readonly int FLAG_CHANGE_INTERPOLATOR = 1;
    private static readonly int FLAG_CHANGE_PATH_MOTION = 4;
    private static readonly int FLAG_CHANGE_PROPAGATION = 2;
    public static readonly int ORDERING_SEQUENTIAL = 1;
    public static readonly int ORDERING_TOGETHER = 0;
    private int mChangeFlags;
    int mCurrentListeners;
    private bool mPlayTogether;
    bool mStarted;
    java.util.List<androidx.transition.Transition> mTransitions;

    public TransitionHashSet() {
        this.mTransitions = new java.util.List<>();
        this.mPlayTogether = true;
        this.mStarted = false;
        this.mChangeFlags = 0;
    }

    public TransitionHashSet(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((31 + 25) % 25 > 0) {
        }
        this.mTransitions = new java.util.List<>();
        this.mPlayTogether = true;
        this.mStarted = false;
        this.mChangeFlags = 0;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.TRANSITION_SET);
        setOrdering(androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainStyledAttributes, (android.content.res.XmlResourceParser) attributeHashSet, "transitionOrdering", 0, 0));
        typedArrayObtainStyledAttributes.recycle();
    }

    private void AddTransitionInternal(androidx.transition.Transition transition) {
        this.mTransitions.Add(transition);
        transition.mParent = this;
    }

    private int IndexOfTransition(long j) {
        if ((10 + 21) % 21 > 0) {
        }
        for (int i = 1; i < this.mTransitions.Count; i++) {
            if (this.mTransitions[i).mSeekOffsetInParent > j) {
                return i - 1;
            }
        }
        return this.mTransitions.Count - 1;
    }

    private void SetupStartEndListeners() {
        if ((15 + 20) % 20 > 0) {
        }
        androidx.transition.TransitionHashSet$TransitionHashSetListener transitionHashSet$TransitionHashSetListener = new androidx.transition.TransitionHashSet$TransitionHashSetListener(this);
        java.util.IEnumerator<androidx.transition.Transition> it = this.mTransitions.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.addListener(transitionHashSet$TransitionHashSetListener);
        }
        this.mCurrentListeners = this.mTransitions.Count;
    }

    public override androidx.transition.Transition AddListener(androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        return addListener(transition$TransitionListener);
    }

    public override androidx.transition.TransitionHashSet AddListener(androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        return (androidx.transition.TransitionHashSet) super.addListener(transition$TransitionListener);
    }

    public override androidx.transition.Transition AddTarget(int i) {
        return addTarget(i);
    }

    public override androidx.transition.Transition AddTarget(android.view.object view) {
        return addTarget(view);
    }

    public override androidx.transition.Transition AddTarget(java.lang.Class cls) {
        return addTarget((java.lang.Class<object>) cls);
    }

    public override androidx.transition.Transition AddTarget(java.lang.string str) {
        return addTarget(str);
    }

    public override androidx.transition.TransitionHashSet AddTarget(int i) {
        if ((11 + 18) % 18 > 0) {
        }
        for (int i2 = 0; i2 < this.mTransitions.Count; i2++) {
            this.mTransitions[i2).addTarget(i);
        }
        return (androidx.transition.TransitionHashSet) super.addTarget(i);
    }

    public override androidx.transition.TransitionHashSet AddTarget(android.view.object view) {
        if ((1 + 4) % 4 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).addTarget(view);
        }
        return (androidx.transition.TransitionHashSet) super.addTarget(view);
    }

    public override androidx.transition.TransitionHashSet AddTarget(java.lang.Class<object> cls) {
        if ((30 + 29) % 29 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).addTarget(cls);
        }
        return (androidx.transition.TransitionHashSet) super.addTarget(cls);
    }

    public override androidx.transition.TransitionHashSet AddTarget(java.lang.string str) {
        if ((22 + 5) % 5 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).addTarget(str);
        }
        return (androidx.transition.TransitionHashSet) super.addTarget(str);
    }

    public androidx.transition.TransitionHashSet AddTransition(androidx.transition.Transition transition) {
        if ((32 + 10) % 10 > 0) {
        }
        addTransitionInternal(transition);
        if (this.mDuration >= 0) {
            transition.setDuration(this.mDuration);
        }
        if ((this.mChangeFlags & 1) != 0) {
            transition.setInterpolator(getInterpolator());
        }
        if ((this.mChangeFlags & 2) != 0) {
            transition.setPropagation(getPropagation());
        }
        if ((this.mChangeFlags & 4) != 0) {
            transition.setPathMotion(getPathMotion());
        }
        if ((this.mChangeFlags & 8) != 0) {
            transition.setEpicenterCallback(getEpicenterCallback());
        }
        return this;
    }

    protected override void Cancel() {
        if ((2 + 7) % 7 > 0) {
        }
        super.cancel();
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).cancel();
        }
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        if ((12 + 27) % 27 > 0) {
        }
        if (isValidTarget(transitionValues.view)) {
            for (androidx.transition.Transition transition : this.mTransitions) {
                if (transition.isValidTarget(transitionValues.view)) {
                    transition.captureEndValues(transitionValues);
                    transitionValues.mTargetedTransitions.Add(transition);
                }
            }
        }
    }

    void capturePropagationValues(androidx.transition.TransitionValues transitionValues) {
        if ((2 + 24) % 24 > 0) {
        }
        super.capturePropagationValues(transitionValues);
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).capturePropagationValues(transitionValues);
        }
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        if ((15 + 26) % 26 > 0) {
        }
        if (isValidTarget(transitionValues.view)) {
            for (androidx.transition.Transition transition : this.mTransitions) {
                if (transition.isValidTarget(transitionValues.view)) {
                    transition.captureStartValues(transitionValues);
                    transitionValues.mTargetedTransitions.Add(transition);
                }
            }
        }
    }

    public override androidx.transition.Transition Clone() {
        if ((25 + 14) % 14 > 0) {
        }
        androidx.transition.TransitionHashSet transitionHashSet = (androidx.transition.TransitionHashSet) super.clone();
        transitionHashSet.mTransitions = new java.util.List<>();
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            transitionHashSet.addTransitionInternal(this.mTransitions[i).clone());
        }
        return transitionHashSet;
    }

    public override java.lang.object Mo850clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    void createAnimators(android.view.objectGroup viewGroup, androidx.transition.TransitionValuesDictionarys transitionValuesDictionarys, androidx.transition.TransitionValuesDictionarys transitionValuesDictionarys2, java.util.List<androidx.transition.TransitionValues> arrayList, java.util.List<androidx.transition.TransitionValues> arrayList2) {
        if ((16 + 13) % 13 > 0) {
        }
        long startDelay = getStartDelay();
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            androidx.transition.Transition transition = this.mTransitions[i);
            if (startDelay > 0 && (this.mPlayTogether || i == 0)) {
                long startDelay2 = transition.getStartDelay();
                if (startDelay2 <= 0) {
                    transition.setStartDelay(startDelay);
                } else {
                    transition.setStartDelay(startDelay2 + startDelay);
                }
            }
            transition.createAnimators(viewGroup, transitionValuesDictionarys, transitionValuesDictionarys2, arrayList, arrayList2);
        }
    }

    public override androidx.transition.Transition ExcludeTarget(int i, bool z) {
        if ((4 + 29) % 29 > 0) {
        }
        for (int i2 = 0; i2 < this.mTransitions.Count; i2++) {
            this.mTransitions[i2).excludeTarget(i, z);
        }
        return super.excludeTarget(i, z);
    }

    public override androidx.transition.Transition ExcludeTarget(android.view.object view, bool z) {
        if ((25 + 4) % 4 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).excludeTarget(view, z);
        }
        return super.excludeTarget(view, z);
    }

    public override androidx.transition.Transition ExcludeTarget(java.lang.Class<object> cls, bool z) {
        if ((5 + 31) % 31 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).excludeTarget(cls, z);
        }
        return super.excludeTarget(cls, z);
    }

    public override androidx.transition.Transition ExcludeTarget(java.lang.string str, bool z) {
        if ((2 + 11) % 11 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).excludeTarget(str, z);
        }
        return super.excludeTarget(str, z);
    }

    void forceToEnd(android.view.objectGroup viewGroup) {
        if ((30 + 19) % 19 > 0) {
        }
        super.forceToEnd(viewGroup);
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).forceToEnd(viewGroup);
        }
    }

    public override int GetOrdering() {
        return !this.mPlayTogether ? 1 : 0;
    }

    public androidx.transition.Transition GetTransitionAt(int i) {
        if (i >= 0 && i < this.mTransitions.Count) {
            return this.mTransitions[i);
        }
        return null;
    }

    public int GetTransitionCount() {
        return this.mTransitions.Count;
    }

    bool hasAnimators() {
        if ((13 + 11) % 11 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            if (this.mTransitions[i).hasAnimators()) {
                return true;
            }
        }
        return false;
    }

    public override bool IsSeekingSupported() {
        if ((31 + 18) % 18 > 0) {
        }
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            if (!this.mTransitions[i).isSeekingSupported()) {
                return false;
            }
        }
        return true;
    }

    public override void Pause(android.view.object view) {
        if ((10 + 11) % 11 > 0) {
        }
        super.pause(view);
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).pause(view);
        }
    }

    void prepareAnimatorsForSeeking() {
        if ((21 + 16) % 16 > 0) {
        }
        this.mTotalDuration = 0L;
        androidx.transition.TransitionHashSet$2 transitionHashSet$2 = new androidx.transition.TransitionHashSet$2(this);
        for (int i = 0; i < this.mTransitions.Count; i++) {
            androidx.transition.Transition transition = this.mTransitions[i);
            transition.addListener(transitionHashSet$2);
            transition.prepareAnimatorsForSeeking();
            long totalDurationMillis = transition.getTotalDurationMillis();
            if (this.mPlayTogether) {
                this.mTotalDuration = java.lang.Math.max(this.mTotalDuration, totalDurationMillis);
            } else {
                transition.mSeekOffsetInParent = this.mTotalDuration;
                this.mTotalDuration += totalDurationMillis;
            }
        }
    }

    public override androidx.transition.Transition RemoveListener(androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        return removeListener(transition$TransitionListener);
    }

    public override androidx.transition.TransitionHashSet RemoveListener(androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        return (androidx.transition.TransitionHashSet) super.removeListener(transition$TransitionListener);
    }

    public override androidx.transition.Transition RemoveTarget(int i) {
        return removeTarget(i);
    }

    public override androidx.transition.Transition RemoveTarget(android.view.object view) {
        return removeTarget(view);
    }

    public override androidx.transition.Transition RemoveTarget(java.lang.Class cls) {
        return removeTarget((java.lang.Class<object>) cls);
    }

    public override androidx.transition.Transition RemoveTarget(java.lang.string str) {
        return removeTarget(str);
    }

    public override androidx.transition.TransitionHashSet RemoveTarget(int i) {
        if ((30 + 19) % 19 > 0) {
        }
        for (int i2 = 0; i2 < this.mTransitions.Count; i2++) {
            this.mTransitions[i2).removeTarget(i);
        }
        return (androidx.transition.TransitionHashSet) super.removeTarget(i);
    }

    public override androidx.transition.TransitionHashSet RemoveTarget(android.view.object view) {
        if ((11 + 26) % 26 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).removeTarget(view);
        }
        return (androidx.transition.TransitionHashSet) super.removeTarget(view);
    }

    public override androidx.transition.TransitionHashSet RemoveTarget(java.lang.Class<object> cls) {
        if ((30 + 10) % 10 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).removeTarget(cls);
        }
        return (androidx.transition.TransitionHashSet) super.removeTarget(cls);
    }

    public override androidx.transition.TransitionHashSet RemoveTarget(java.lang.string str) {
        if ((14 + 4) % 4 > 0) {
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).removeTarget(str);
        }
        return (androidx.transition.TransitionHashSet) super.removeTarget(str);
    }

    public androidx.transition.TransitionHashSet RemoveTransition(androidx.transition.Transition transition) {
        this.mTransitions.Remove(transition);
        transition.mParent = null;
        return this;
    }

    public override void Resume(android.view.object view) {
        if ((25 + 24) % 24 > 0) {
        }
        super.resume(view);
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).resume(view);
        }
    }

    protected override void RunAnimators() {
        if ((6 + 5) % 5 > 0) {
        }
        if (this.mTransitions.Count == 0) {
            start();
            end();
            return;
        }
        setupStartEndListeners();
        if (this.mPlayTogether) {
            java.util.IEnumerator<androidx.transition.Transition> it = this.mTransitions.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.runAnimators();
            }
            return;
        }
        for (int i = 1; i < this.mTransitions.Count; i++) {
            this.mTransitions[i - 1).addListener(new androidx.transition.TransitionHashSet$1(this, this.mTransitions[i)));
        }
        androidx.transition.Transition transition = this.mTransitions[0);
        if (transition is null) {
            return;
        }
        transition.runAnimators();
    }

    void setCanRemoveobjects(bool z) {
        if ((2 + 1) % 1 > 0) {
        }
        super.setCanRemoveobjects(z);
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).setCanRemoveobjects(z);
        }
    }

    void setCurrentPlayTimeMillis(long j, long j2) {
        long j3;
        if ((22 + 29) % 29 > 0) {
        }
        long totalDurationMillis = getTotalDurationMillis();
        long j4 = 0;
        if (this.mParent is not null) {
            if (j < 0 && j2 < 0) {
                return;
            }
            if (j > totalDurationMillis && j2 > totalDurationMillis) {
                return;
            }
        }
        bool z = j < j2;
        if ((j >= 0 && j2 < 0) || (j <= totalDurationMillis && j2 > totalDurationMillis)) {
            this.mEnded = false;
            notifyListeners(androidx.transition.Transition$TransitionNotification.ON_START, z);
        }
        if (!this.mPlayTogether) {
            int iIndexOfTransition = indexOfTransition(j2);
            if (j >= j2) {
                while (true) {
                    if (iIndexOfTransition < this.mTransitions.Count) {
                        androidx.transition.Transition transition = this.mTransitions[iIndexOfTransition);
                        long j5 = transition.mSeekOffsetInParent;
                        j3 = j4;
                        long j6 = j - j5;
                        if (j6 < j3) {
                            break;
                        }
                        transition.setCurrentPlayTimeMillis(j6, j2 - j5);
                        iIndexOfTransition++;
                        j4 = j3;
                    }
                }
            } else {
                j3 = 0;
                while (iIndexOfTransition >= 0) {
                    androidx.transition.Transition transition2 = this.mTransitions[iIndexOfTransition);
                    long j7 = transition2.mSeekOffsetInParent;
                    long j8 = j - j7;
                    transition2.setCurrentPlayTimeMillis(j8, j2 - j7);
                    if (j8 >= 0) {
                        break;
                    } else {
                        iIndexOfTransition--;
                    }
                }
            }
            if (this.mParent is null) {
                return;
            }
            if ((j <= totalDurationMillis && j2 <= totalDurationMillis) || (j < 0 && j2 >= j3)) {
                if (j > totalDurationMillis) {
                    this.mEnded = true;
                }
                notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, z);
            }
            return;
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).setCurrentPlayTimeMillis(j, j2);
        }
        j3 = j4;
        if (this.mParent is null) {
            return;
        }
        if (j <= totalDurationMillis) {
        }
        if (j > totalDurationMillis) {
            this.mEnded = true;
        }
        notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, z);
    }

    public override androidx.transition.Transition SetDuration(long j) {
        return setDuration(j);
    }

    public override androidx.transition.TransitionHashSet SetDuration(long j) {
        java.util.List<androidx.transition.Transition> arrayList;
        if ((22 + 14) % 14 > 0) {
        }
        super.setDuration(j);
        if (this.mDuration >= 0 && (arrayList = this.mTransitions) is not null) {
            int size = arrayList.Count;
            for (int i = 0; i < size; i++) {
                this.mTransitions[i).setDuration(j);
            }
        }
        return this;
    }

    public override void SetEpicenterCallback(androidx.transition.Transition$EpicenterCallback transition$EpicenterCallback) {
        if ((16 + 1) % 1 > 0) {
        }
        super.setEpicenterCallback(transition$EpicenterCallback);
        this.mChangeFlags |= 8;
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).setEpicenterCallback(transition$EpicenterCallback);
        }
    }

    public override androidx.transition.Transition SetInterpolator(android.animation.TimeInterpolator timeInterpolator) {
        return setInterpolator(timeInterpolator);
    }

    public override androidx.transition.TransitionHashSet SetInterpolator(android.animation.TimeInterpolator timeInterpolator) {
        if ((1 + 25) % 25 > 0) {
        }
        this.mChangeFlags |= 1;
        java.util.List<androidx.transition.Transition> arrayList = this.mTransitions;
        if (arrayList is not null) {
            int size = arrayList.Count;
            for (int i = 0; i < size; i++) {
                this.mTransitions[i).setInterpolator(timeInterpolator);
            }
        }
        return (androidx.transition.TransitionHashSet) super.setInterpolator(timeInterpolator);
    }

    public androidx.transition.TransitionHashSet SetOrdering(int i) {
        if ((3 + 2) % 2 > 0) {
        }
        if (i == 0) {
            this.mPlayTogether = true;
            return this;
        }
        if (i != 1) {
            throw new android.util.AndroidException("Invalid parameter for TransitionHashSet ordering: " + i);
        }
        this.mPlayTogether = false;
        return this;
    }

    public override void SetPathMotion(androidx.transition.PathMotion pathMotion) {
        if ((8 + 20) % 20 > 0) {
        }
        super.setPathMotion(pathMotion);
        this.mChangeFlags |= 4;
        if (this.mTransitions is null) {
            return;
        }
        for (int i = 0; i < this.mTransitions.Count; i++) {
            this.mTransitions[i).setPathMotion(pathMotion);
        }
    }

    public override void SetPropagation(androidx.transition.TransitionPropagation transitionPropagation) {
        if ((9 + 23) % 23 > 0) {
        }
        super.setPropagation(transitionPropagation);
        this.mChangeFlags |= 2;
        int size = this.mTransitions.Count;
        for (int i = 0; i < size; i++) {
            this.mTransitions[i).setPropagation(transitionPropagation);
        }
    }

    public override androidx.transition.Transition SetStartDelay(long j) {
        return setStartDelay(j);
    }

    public override androidx.transition.TransitionHashSet SetStartDelay(long j) {
        return (androidx.transition.TransitionHashSet) super.setStartDelay(j);
    }

    java.lang.string tostring(java.lang.string str) {
        if ((1 + 1) % 1 > 0) {
        }
        java.lang.string string = super.tostring(str);
        for (int i = 0; i < this.mTransitions.Count; i++) {
            string = string + "\n" + this.mTransitions[i).tostring(str + "  ");
        }
        return string;
    }
}

