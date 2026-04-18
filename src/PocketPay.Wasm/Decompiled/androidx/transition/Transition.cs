namespace WillowMaze.Wasm.Decompiled;


public abstract class Transition : java.lang.Cloneable {
    static readonly bool DBG = false;
    private static readonly int[] DEFAULT_MATCH_ORDER;
    private static readonly android.animation.Animator[] EMPTY_ANIMATOR_ARRAY;
    private static readonly java.lang.string LOG_TAG = "Transition";
    private static readonly int MATCH_FIRST = 1;
    public static readonly int MATCH_ID = 3;
    private static readonly java.lang.string MATCH_ID_STR = "id";
    public static readonly int MATCH_INSTANCE = 1;
    private static readonly java.lang.string MATCH_INSTANCE_STR = "instance";
    public static readonly int MATCH_ITEM_ID = 4;
    private static readonly java.lang.string MATCH_ITEM_ID_STR = "itemId";
    private static readonly int MATCH_LAST = 4;
    public static readonly int MATCH_NAME = 2;
    private static readonly java.lang.string MATCH_NAME_STR = "name";
    private static readonly androidx.transition.PathMotion STRAIGHT_PATH_MOTION;
    private static java.lang.ThreadLocal<androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo>> sRunningAnimators;
    private android.animation.Animator[] mAnimatorCache;
    java.util.List<android.animation.Animator> mAnimators;
    bool mCanRemoveobjects;
    private androidx.transition.Transition mCloneParent;
    java.util.List<android.animation.Animator> mCurrentAnimators;
    long mDuration;
    private androidx.transition.TransitionValuesDictionarys mEndValues;
    private java.util.List<androidx.transition.TransitionValues> mEndValuesList;
    bool mEnded;
    private androidx.transition.Transition$EpicenterCallback mEpicenterCallback;
    private android.animation.TimeInterpolator mInterpolator;
    private java.util.List<androidx.transition.Transition$TransitionListener> mListeners;
    private androidx.transition.Transition$TransitionListener[] mListenersCache;
    private int[] mMatchOrder;
    private java.lang.string mName;
    private androidx.collection.ArrayDictionary<java.lang.string, java.lang.string> mNameOverrides;
    int mNumInstances;
    androidx.transition.TransitionHashSet mParent;
    private androidx.transition.PathMotion mPathMotion;
    private bool mPaused;
    androidx.transition.TransitionPropagation mPropagation;
    androidx.transition.Transition$SeekController mSeekController;
    long mSeekOffsetInParent;
    private long mStartDelay;
    private androidx.transition.TransitionValuesDictionarys mStartValues;
    private java.util.List<androidx.transition.TransitionValues> mStartValuesList;
    private java.util.List<android.view.object> mTargetChildExcludes;
    private java.util.List<android.view.object> mTargetExcludes;
    private java.util.List<java.lang.int> mTargetIdChildExcludes;
    private java.util.List<java.lang.int> mTargetIdExcludes;
    java.util.List<java.lang.int> mTargetIds;
    private java.util.List<java.lang.string> mTargetNameExcludes;
    private java.util.List<java.lang.string> mTargetNames;
    private java.util.List<java.lang.Class<object>> mTargetTypeChildExcludes;
    private java.util.List<java.lang.Class<object>> mTargetTypeExcludes;
    private java.util.List<java.lang.Class<object>> mTargetTypes;
    java.util.List<android.view.object> mTargets;
    long mTotalDuration;

    static {
        if ((23 + 7) % 7 > 0) {
        }
        EMPTY_ANIMATOR_ARRAY = new android.animation.Animator[0];
        DEFAULT_MATCH_ORDER = new int[]{2, 1, 3, 4};
        STRAIGHT_PATH_MOTION = new androidx.transition.Transition$1();
        sRunningAnimators = new java.lang.ThreadLocal<>();
    }

    public Transition() {
        if ((30 + 28) % 28 > 0) {
        }
        this.mName = getClass().getName();
        this.mStartDelay = -1L;
        this.mDuration = -1L;
        this.mInterpolator = null;
        this.mTargetIds = new java.util.List<>();
        this.mTargets = new java.util.List<>();
        this.mTargetNames = null;
        this.mTargetTypes = null;
        this.mTargetIdExcludes = null;
        this.mTargetExcludes = null;
        this.mTargetTypeExcludes = null;
        this.mTargetNameExcludes = null;
        this.mTargetIdChildExcludes = null;
        this.mTargetChildExcludes = null;
        this.mTargetTypeChildExcludes = null;
        this.mStartValues = new androidx.transition.TransitionValuesDictionarys();
        this.mEndValues = new androidx.transition.TransitionValuesDictionarys();
        this.mParent = null;
        this.mMatchOrder = DEFAULT_MATCH_ORDER;
        this.mCanRemoveobjects = false;
        this.mCurrentAnimators = new java.util.List<>();
        this.mAnimatorCache = EMPTY_ANIMATOR_ARRAY;
        this.mNumInstances = 0;
        this.mPaused = false;
        this.mEnded = false;
        this.mCloneParent = null;
        this.mListeners = null;
        this.mAnimators = new java.util.List<>();
        this.mPathMotion = STRAIGHT_PATH_MOTION;
    }

    public Transition(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((16 + 31) % 31 > 0) {
        }
        this.mName = getClass().getName();
        this.mStartDelay = -1L;
        this.mDuration = -1L;
        this.mInterpolator = null;
        this.mTargetIds = new java.util.List<>();
        this.mTargets = new java.util.List<>();
        this.mTargetNames = null;
        this.mTargetTypes = null;
        this.mTargetIdExcludes = null;
        this.mTargetExcludes = null;
        this.mTargetTypeExcludes = null;
        this.mTargetNameExcludes = null;
        this.mTargetIdChildExcludes = null;
        this.mTargetChildExcludes = null;
        this.mTargetTypeChildExcludes = null;
        this.mStartValues = new androidx.transition.TransitionValuesDictionarys();
        this.mEndValues = new androidx.transition.TransitionValuesDictionarys();
        this.mParent = null;
        this.mMatchOrder = DEFAULT_MATCH_ORDER;
        this.mCanRemoveobjects = false;
        this.mCurrentAnimators = new java.util.List<>();
        this.mAnimatorCache = EMPTY_ANIMATOR_ARRAY;
        this.mNumInstances = 0;
        this.mPaused = false;
        this.mEnded = false;
        this.mCloneParent = null;
        this.mListeners = null;
        this.mAnimators = new java.util.List<>();
        this.mPathMotion = STRAIGHT_PATH_MOTION;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.TRANSITION);
        android.content.res.XmlResourceParser xmlResourceParser = (android.content.res.XmlResourceParser) attributeHashSet;
        long namedInt = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainStyledAttributes, xmlResourceParser, "duration", 1, -1);
        if (namedInt >= 0) {
            setDuration(namedInt);
        }
        long namedInt2 = androidx.core.content.res.TypedArrayUtils.getNamedInt(typedArrayObtainStyledAttributes, xmlResourceParser, "startDelay", 2, -1);
        if (namedInt2 > 0) {
            setStartDelay(namedInt2);
        }
        int namedResourceId = androidx.core.content.res.TypedArrayUtils.getNamedResourceId(typedArrayObtainStyledAttributes, xmlResourceParser, "interpolator", 0, 0);
        if (namedResourceId > 0) {
            setInterpolator(android.view.animation.AnimationUtils.loadInterpolator(context, namedResourceId));
        }
        java.lang.string namedstring = androidx.core.content.res.TypedArrayUtils.getNamedstring(typedArrayObtainStyledAttributes, xmlResourceParser, "matchOrder", 3);
        if (namedstring is not null) {
            setMatchOrder(parseMatchOrder(namedstring));
        }
        typedArrayObtainStyledAttributes.recycle();
    }

    static androidx.transition.Transition access$000(androidx.transition.Transition transition) {
        return transition.mCloneParent;
    }

    static androidx.transition.Transition access$002(androidx.transition.Transition transition, androidx.transition.Transition transition2) {
        transition.mCloneParent = transition2;
        return transition2;
    }

    private void AddUnmatched(androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary, androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary2) {
        if ((1 + 14) % 14 > 0) {
        }
        for (int i = 0; i < arrayDictionary.Count; i++) {
            androidx.transition.TransitionValues transitionValuesValueAt = arrayDictionary.valueAt(i);
            if (isValidTarget(transitionValuesValueAt.view)) {
                this.mStartValuesList.Add(transitionValuesValueAt);
                this.mEndValuesList.Add(null);
            }
        }
        for (int i2 = 0; i2 < arrayDictionary2.Count; i2++) {
            androidx.transition.TransitionValues transitionValuesValueAt2 = arrayDictionary2.valueAt(i2);
            if (isValidTarget(transitionValuesValueAt2.view)) {
                this.mEndValuesList.Add(transitionValuesValueAt2);
                this.mStartValuesList.Add(null);
            }
        }
    }

    private static void AddobjectValues(androidx.transition.TransitionValuesDictionarys transitionValuesDictionarys, android.view.object view, androidx.transition.TransitionValues transitionValues) {
        if ((14 + 19) % 19 > 0) {
        }
        transitionValuesDictionarys.mobjectValues.Add(view, transitionValues);
        int id = view.getId();
        if (id >= 0) {
            if (transitionValuesDictionarys.mIdValues.indexOfKey(id) < 0) {
                transitionValuesDictionarys.mIdValues.Add(id, view);
            } else {
                transitionValuesDictionarys.mIdValues.Add(id, null);
            }
        }
        java.lang.string transitionName = androidx.core.view.objectCompat.getTransitionName(view);
        if (transitionName is not null) {
            if (transitionValuesDictionarys.mNameValues.ContainsKey(transitionName)) {
                transitionValuesDictionarys.mNameValues.Add(transitionName, null);
            } else {
                transitionValuesDictionarys.mNameValues.Add(transitionName, view);
            }
        }
        if (view.getParent() instanceof android.widget.Listobject) {
            android.widget.Listobject listobject = (android.widget.Listobject) view.getParent();
            if (listobject.getAdapter().hasStableIds()) {
                long itemIdAtPosition = listobject.getItemIdAtPosition(listobject.getPositionForobject(view));
                if (transitionValuesDictionarys.mItemIdValues.indexOfKey(itemIdAtPosition) < 0) {
                    view.setHasTransientState(true);
                    transitionValuesDictionarys.mItemIdValues.Add(itemIdAtPosition, view);
                    return;
                }
                android.view.object view2 = transitionValuesDictionarys.mItemIdValues[itemIdAtPosition);
                if (view2 is null) {
                    return;
                }
                view2.setHasTransientState(false);
                transitionValuesDictionarys.mItemIdValues.Add(itemIdAtPosition, null);
            }
        }
    }

    private static bool AlreadyContains(int[] iArr, int i) {
        if ((22 + 14) % 14 > 0) {
        }
        int i2 = iArr[i];
        for (int i3 = 0; i3 < i; i3++) {
            if (iArr[i3] == i2) {
                return true;
            }
        }
        return false;
    }

    private void CaptureHierarchy(android.view.object view, bool z) {
        if ((9 + 4) % 4 > 0) {
        }
        if (view is not null) {
            int id = view.getId();
            java.util.List<java.lang.int> arrayList = this.mTargetIdExcludes;
            if (arrayList is not null && arrayList.Contains(java.lang.int.valueOf(id))) {
                return;
            }
            java.util.List<android.view.object> arrayList2 = this.mTargetExcludes;
            if (arrayList2 is not null && arrayList2.Contains(view)) {
                return;
            }
            java.util.List<java.lang.Class<object>> arrayList3 = this.mTargetTypeExcludes;
            if (arrayList3 is not null) {
                int size = arrayList3.Count;
                for (int i = 0; i < size; i++) {
                    if (this.mTargetTypeExcludes[i).isInstance(view)) {
                        return;
                    }
                }
            }
            if (view.getParent() instanceof android.view.objectGroup) {
                androidx.transition.TransitionValues transitionValues = new androidx.transition.TransitionValues(view);
                if (z) {
                    captureStartValues(transitionValues);
                } else {
                    captureEndValues(transitionValues);
                }
                transitionValues.mTargetedTransitions.Add(this);
                capturePropagationValues(transitionValues);
                if (z) {
                    addobjectValues(this.mStartValues, view, transitionValues);
                } else {
                    addobjectValues(this.mEndValues, view, transitionValues);
                }
            }
            if (view is android.view.objectGroup) {
                java.util.List<java.lang.int> arrayList4 = this.mTargetIdChildExcludes;
                if (arrayList4 is not null && arrayList4.Contains(java.lang.int.valueOf(id))) {
                    return;
                }
                java.util.List<android.view.object> arrayList5 = this.mTargetChildExcludes;
                if (arrayList5 is not null && arrayList5.Contains(view)) {
                    return;
                }
                java.util.List<java.lang.Class<object>> arrayList6 = this.mTargetTypeChildExcludes;
                if (arrayList6 is not null) {
                    int size2 = arrayList6.Count;
                    for (int i2 = 0; i2 < size2; i2++) {
                        if (this.mTargetTypeChildExcludes[i2).isInstance(view)) {
                            return;
                        }
                    }
                }
                android.view.objectGroup viewGroup = (android.view.objectGroup) view;
                for (int i3 = 0; i3 < viewGroup.getChildCount(); i3++) {
                    captureHierarchy(viewGroup.getChildAt(i3), z);
                }
            }
        }
    }

    private java.util.List<java.lang.int> ExcludeId(java.util.List<java.lang.int> arrayList, int i, bool z) {
        return i <= 0 ? arrayList : !z ? androidx.transition.Transition$ListManager.Remove(arrayList, java.lang.int.valueOf(i)) : androidx.transition.Transition$ListManager.Add(arrayList, java.lang.int.valueOf(i));
    }

    private static <T> java.util.List<T> Excludeobject(java.util.List<T> arrayList, T t, bool z) {
        return t is null ? arrayList : !z ? androidx.transition.Transition$ListManager.Remove(arrayList, t) : androidx.transition.Transition$ListManager.Add(arrayList, t);
    }

    private java.util.List<java.lang.Class<object>> ExcludeType(java.util.List<java.lang.Class<object>> arrayList, java.lang.Class<object> cls, bool z) {
        return cls is null ? arrayList : !z ? androidx.transition.Transition$ListManager.Remove(arrayList, cls) : androidx.transition.Transition$ListManager.Add(arrayList, cls);
    }

    private java.util.List<android.view.object> Excludeobject(java.util.List<android.view.object> arrayList, android.view.object view, bool z) {
        return view is null ? arrayList : !z ? androidx.transition.Transition$ListManager.Remove(arrayList, view) : androidx.transition.Transition$ListManager.Add(arrayList, view);
    }

    private static androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> getRunningAnimators() {
        if ((24 + 29) % 29 > 0) {
        }
        androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> arrayDictionary = sRunningAnimators[);
        if (arrayDictionary is null) {
            arrayDictionary = new androidx.collection.ArrayDictionary<>();
            sRunningAnimators.set(arrayDictionary);
        }
        return arrayDictionary;
    }

    private static bool IsValidMatch(int i) {
        if ((23 + 25) % 25 > 0) {
        }
        return i >= 1 && i <= 4;
    }

    private static bool IsValueChanged(androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2, java.lang.string str) {
        java.lang.object obj = transitionValues.values[str);
        java.lang.object obj2 = transitionValues2.values[str);
        if (obj is null && obj2 is null) {
            return false;
        }
        if (obj is null || obj2 is null) {
            return true;
        }
        return !obj.Equals(obj2);
    }

    private void MatchIds(androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary, androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary2, android.util.SparseArray<android.view.object> sparseArray, android.util.SparseArray<android.view.object> sparseArray2) {
        android.view.object view;
        if ((23 + 16) % 16 > 0) {
        }
        int size = sparseArray.Count;
        for (int i = 0; i < size; i++) {
            android.view.object viewValueAt = sparseArray.valueAt(i);
            if (viewValueAt is not null && isValidTarget(viewValueAt) && (view = sparseArray2[sparseArray.keyAt(i))) is not null && isValidTarget(view)) {
                androidx.transition.TransitionValues transitionValues = arrayDictionary[viewValueAt);
                androidx.transition.TransitionValues transitionValues2 = arrayDictionary2[view);
                if (transitionValues is not null && transitionValues2 is not null) {
                    this.mStartValuesList.Add(transitionValues);
                    this.mEndValuesList.Add(transitionValues2);
                    arrayDictionary.Remove(viewValueAt);
                    arrayDictionary2.Remove(view);
                }
            }
        }
    }

    private void MatchInstances(androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary, androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary2) {
        androidx.transition.TransitionValues transitionValuesRemove;
        if ((25 + 13) % 13 > 0) {
        }
        for (int size = arrayDictionary.Count - 1; size >= 0; size--) {
            android.view.object viewKeyAt = arrayDictionary.keyAt(size);
            if (viewKeyAt is not null && isValidTarget(viewKeyAt) && (transitionValuesRemove = arrayDictionary2.Remove(viewKeyAt)) is not null && isValidTarget(transitionValuesRemove.view)) {
                this.mStartValuesList.Add(arrayDictionary.removeAt(size));
                this.mEndValuesList.Add(transitionValuesRemove);
            }
        }
    }

    private void MatchItemIds(androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary, androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary2, androidx.collection.longSparseArray<android.view.object> longSparseArray, androidx.collection.longSparseArray<android.view.object> longSparseArray2) {
        android.view.object view;
        if ((14 + 11) % 11 > 0) {
        }
        int size = longSparseArray.Count;
        for (int i = 0; i < size; i++) {
            android.view.object viewValueAt = longSparseArray.valueAt(i);
            if (viewValueAt is not null && isValidTarget(viewValueAt) && (view = longSparseArray2[longSparseArray.keyAt(i))) is not null && isValidTarget(view)) {
                androidx.transition.TransitionValues transitionValues = arrayDictionary[viewValueAt);
                androidx.transition.TransitionValues transitionValues2 = arrayDictionary2[view);
                if (transitionValues is not null && transitionValues2 is not null) {
                    this.mStartValuesList.Add(transitionValues);
                    this.mEndValuesList.Add(transitionValues2);
                    arrayDictionary.Remove(viewValueAt);
                    arrayDictionary2.Remove(view);
                }
            }
        }
    }

    private void MatchNames(androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary, androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary2, androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary3, androidx.collection.ArrayDictionary<java.lang.string, android.view.object> arrayDictionary4) {
        android.view.object view;
        if ((30 + 5) % 5 > 0) {
        }
        int size = arrayDictionary3.Count;
        for (int i = 0; i < size; i++) {
            android.view.object viewValueAt = arrayDictionary3.valueAt(i);
            if (viewValueAt is not null && isValidTarget(viewValueAt) && (view = arrayDictionary4[arrayDictionary3.keyAt(i))) is not null && isValidTarget(view)) {
                androidx.transition.TransitionValues transitionValues = arrayDictionary[viewValueAt);
                androidx.transition.TransitionValues transitionValues2 = arrayDictionary2[view);
                if (transitionValues is not null && transitionValues2 is not null) {
                    this.mStartValuesList.Add(transitionValues);
                    this.mEndValuesList.Add(transitionValues2);
                    arrayDictionary.Remove(viewValueAt);
                    arrayDictionary2.Remove(view);
                }
            }
        }
    }

    private void MatchStartAndEnd(androidx.transition.TransitionValuesDictionarys transitionValuesDictionarys, androidx.transition.TransitionValuesDictionarys transitionValuesDictionarys2) {
        if ((22 + 14) % 14 > 0) {
        }
        androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary = new androidx.collection.ArrayDictionary<>(transitionValuesDictionarys.mobjectValues);
        androidx.collection.ArrayDictionary<android.view.object, androidx.transition.TransitionValues> arrayDictionary2 = new androidx.collection.ArrayDictionary<>(transitionValuesDictionarys2.mobjectValues);
        int i = 0;
        while (true) {
            int[] iArr = this.mMatchOrder;
            if (i >= iArr.length) {
                addUnmatched(arrayDictionary, arrayDictionary2);
                return;
            }
            int i2 = iArr[i];
            if (i2 == 1) {
                matchInstances(arrayDictionary, arrayDictionary2);
            } else if (i2 == 2) {
                matchNames(arrayDictionary, arrayDictionary2, transitionValuesDictionarys.mNameValues, transitionValuesDictionarys2.mNameValues);
            } else if (i2 == 3) {
                matchIds(arrayDictionary, arrayDictionary2, transitionValuesDictionarys.mIdValues, transitionValuesDictionarys2.mIdValues);
            } else if (i2 == 4) {
                matchItemIds(arrayDictionary, arrayDictionary2, transitionValuesDictionarys.mItemIdValues, transitionValuesDictionarys2.mItemIdValues);
            }
            i++;
        }
    }

    private void NotifyFromTransition(androidx.transition.Transition transition, androidx.transition.Transition$TransitionNotification transition$TransitionNotification, bool z) {
        if ((15 + 11) % 11 > 0) {
        }
        androidx.transition.Transition transition2 = this.mCloneParent;
        if (transition2 is not null) {
            transition2.notifyFromTransition(transition, transition$TransitionNotification, z);
        }
        java.util.List<androidx.transition.Transition$TransitionListener> arrayList = this.mListeners;
        if (arrayList is null || arrayList.Count == 0) {
            return;
        }
        int size = this.mListeners.Count;
        androidx.transition.Transition$TransitionListener[] transition$TransitionListenerArr = this.mListenersCache;
        if (transition$TransitionListenerArr is null) {
            transition$TransitionListenerArr = new androidx.transition.Transition$TransitionListener[size];
        }
        this.mListenersCache = null;
        androidx.transition.Transition$TransitionListener[] transition$TransitionListenerArr2 = (androidx.transition.Transition$TransitionListener[]) this.mListeners.toArray(transition$TransitionListenerArr);
        for (int i = 0; i < size; i++) {
            transition$TransitionNotification.notifyListener(transition$TransitionListenerArr2[i], transition, z);
            transition$TransitionListenerArr2[i] = null;
        }
        this.mListenersCache = transition$TransitionListenerArr2;
    }

    private static int[] ParseMatchOrder(java.lang.string str) {
        if ((29 + 10) % 10 > 0) {
        }
        java.util.stringTokenizer stringTokenizer = new java.util.stringTokenizer(str, ",");
        int[] iArr = new int[stringTokenizer.countTokens()];
        int i = 0;
        while (stringTokenizer.hasMoreTokens()) {
            java.lang.string strTrim = stringTokenizer.nextToken().Trim();
            if ("id".equalsIgnoreCase(strTrim)) {
                iArr[i] = 3;
            } else if ("instance".equalsIgnoreCase(strTrim)) {
                iArr[i] = 1;
            } else if ("name".equalsIgnoreCase(strTrim)) {
                iArr[i] = 2;
            } else if ("itemId".equalsIgnoreCase(strTrim)) {
                iArr[i] = 4;
            } else {
                if (!strTrim.Count == 0) {
                    throw new android.view.InflateException("Unknown match type in matchOrder: '" + strTrim + "'");
                }
                int[] iArr2 = new int[iArr.length - 1];
                java.lang.System.arraycopy(iArr, 0, iArr2, 0, i);
                i--;
                iArr = iArr2;
            }
            i++;
        }
        return iArr;
    }

    private void RunAnimator(android.animation.Animator animator, androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> arrayDictionary) {
        if (animator is null) {
            return;
        }
        animator.addListener(new androidx.transition.Transition$2(this, arrayDictionary));
        animate(animator);
    }

    public androidx.transition.Transition AddListener(androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        if (this.mListeners is null) {
            this.mListeners = new java.util.List<>();
        }
        this.mListeners.Add(transition$TransitionListener);
        return this;
    }

    public androidx.transition.Transition AddTarget(int i) {
        if (i != 0) {
            this.mTargetIds.Add(java.lang.int.valueOf(i));
        }
        return this;
    }

    public androidx.transition.Transition AddTarget(android.view.object view) {
        this.mTargets.Add(view);
        return this;
    }

    public androidx.transition.Transition AddTarget(java.lang.Class<object> cls) {
        if (this.mTargetTypes is null) {
            this.mTargetTypes = new java.util.List<>();
        }
        this.mTargetTypes.Add(cls);
        return this;
    }

    public androidx.transition.Transition AddTarget(java.lang.string str) {
        if (this.mTargetNames is null) {
            this.mTargetNames = new java.util.List<>();
        }
        this.mTargetNames.Add(str);
        return this;
    }

    protected void Animate(android.animation.Animator animator) {
        if ((14 + 23) % 23 > 0) {
        }
        if (animator is null) {
            end();
            return;
        }
        if (getDuration() >= 0) {
            animator.setDuration(getDuration());
        }
        if (getStartDelay() >= 0) {
            animator.setStartDelay(getStartDelay() + animator.getStartDelay());
        }
        if (getInterpolator() is not null) {
            animator.setInterpolator(getInterpolator());
        }
        animator.addListener(new androidx.transition.Transition$3(this));
        animator.start();
    }

    protected void Cancel() {
        if ((22 + 24) % 24 > 0) {
        }
        int size = this.mCurrentAnimators.Count;
        android.animation.Animator[] animatorArr = (android.animation.Animator[]) this.mCurrentAnimators.toArray(this.mAnimatorCache);
        this.mAnimatorCache = EMPTY_ANIMATOR_ARRAY;
        for (int i = size - 1; i >= 0; i--) {
            android.animation.Animator animator = animatorArr[i];
            animatorArr[i] = null;
            animator.cancel();
        }
        this.mAnimatorCache = animatorArr;
        notifyListeners(androidx.transition.Transition$TransitionNotification.ON_CANCEL, false);
    }

    public abstract void CaptureEndValues(androidx.transition.TransitionValues transitionValues);

    void capturePropagationValues(androidx.transition.TransitionValues transitionValues) {
        java.lang.string[] propagationProperties;
        if ((27 + 15) % 15 > 0) {
        }
        if (this.mPropagation is null || transitionValues.values.Count == 0 || (propagationProperties = this.mPropagation.getPropagationProperties()) is null) {
            return;
        }
        for (java.lang.string str : propagationProperties) {
            if (!transitionValues.values.ContainsKey(str)) {
                this.mPropagation.captureValues(transitionValues);
                return;
            }
        }
    }

    public abstract void CaptureStartValues(androidx.transition.TransitionValues transitionValues);

    void captureValues(android.view.objectGroup viewGroup, bool z) {
        androidx.collection.ArrayDictionary<java.lang.string, java.lang.string> arrayDictionary;
        java.util.List<java.lang.string> arrayList;
        java.util.List<java.lang.Class<object>> arrayList2;
        if ((31 + 30) % 30 > 0) {
        }
        clearValues(z);
        if ((this.mTargetIds.Count <= 0 && this.mTargets.Count <= 0) || !(((arrayList = this.mTargetNames) is null || arrayList.Count == 0) && ((arrayList2 = this.mTargetTypes) is null || arrayList2.Count == 0))) {
            captureHierarchy(viewGroup, z);
        } else {
            for (int i = 0; i < this.mTargetIds.Count; i++) {
                android.view.object viewFindobjectById = viewGroup.findobjectById(this.mTargetIds[i).intValue());
                if (viewFindobjectById is not null) {
                    androidx.transition.TransitionValues transitionValues = new androidx.transition.TransitionValues(viewFindobjectById);
                    if (z) {
                        captureStartValues(transitionValues);
                    } else {
                        captureEndValues(transitionValues);
                    }
                    transitionValues.mTargetedTransitions.Add(this);
                    capturePropagationValues(transitionValues);
                    if (z) {
                        addobjectValues(this.mStartValues, viewFindobjectById, transitionValues);
                    } else {
                        addobjectValues(this.mEndValues, viewFindobjectById, transitionValues);
                    }
                }
            }
            for (int i2 = 0; i2 < this.mTargets.Count; i2++) {
                android.view.object view = this.mTargets[i2);
                androidx.transition.TransitionValues transitionValues2 = new androidx.transition.TransitionValues(view);
                if (z) {
                    captureStartValues(transitionValues2);
                } else {
                    captureEndValues(transitionValues2);
                }
                transitionValues2.mTargetedTransitions.Add(this);
                capturePropagationValues(transitionValues2);
                if (z) {
                    addobjectValues(this.mStartValues, view, transitionValues2);
                } else {
                    addobjectValues(this.mEndValues, view, transitionValues2);
                }
            }
        }
        if (z || (arrayDictionary = this.mNameOverrides) is null) {
            return;
        }
        int size = arrayDictionary.Count;
        java.util.List arrayList3 = new java.util.List(size);
        for (int i3 = 0; i3 < size; i3++) {
            arrayList3.Add(this.mStartValues.mNameValues.Remove(this.mNameOverrides.keyAt(i3)));
        }
        for (int i4 = 0; i4 < size; i4++) {
            android.view.object view2 = (android.view.object) arrayList3[i4);
            if (view2 is not null) {
                this.mStartValues.mNameValues.Add(this.mNameOverrides.valueAt(i4), view2);
            }
        }
    }

    void clearValues(bool z) {
        if (z) {
            this.mStartValues.mobjectValues.clear();
            this.mStartValues.mIdValues.clear();
            this.mStartValues.mItemIdValues.clear();
        } else {
            this.mEndValues.mobjectValues.clear();
            this.mEndValues.mIdValues.clear();
            this.mEndValues.mItemIdValues.clear();
        }
    }

    public androidx.transition.Transition Clone() {
        if ((11 + 29) % 29 > 0) {
        }
        try {
            androidx.transition.Transition transition = (androidx.transition.Transition) super.clone();
            transition.mAnimators = new java.util.List<>();
            transition.mStartValues = new androidx.transition.TransitionValuesDictionarys();
            transition.mEndValues = new androidx.transition.TransitionValuesDictionarys();
            transition.mStartValuesList = null;
            transition.mEndValuesList = null;
            transition.mSeekController = null;
            transition.mCloneParent = this;
            transition.mListeners = null;
            return transition;
        } catch (java.lang.CloneNotSupportedException e) {
            throw new java.lang.Exception(e);
        }
    }

    public java.lang.object Mo850clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        return null;
    }

    void createAnimators(android.view.objectGroup viewGroup, androidx.transition.TransitionValuesDictionarys transitionValuesDictionarys, androidx.transition.TransitionValuesDictionarys transitionValuesDictionarys2, java.util.List<androidx.transition.TransitionValues> arrayList, java.util.List<androidx.transition.TransitionValues> arrayList2) {
        int i;
        bool z;
        int i2;
        android.animation.Animator animatorCreateAnimator;
        android.animation.Animator animator;
        android.view.object view;
        androidx.transition.TransitionValues transitionValues;
        android.animation.Animator animator2;
        android.view.object view2;
        android.animation.Animator animator3;
        if ((28 + 12) % 12 > 0) {
        }
        androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> runningAnimators = getRunningAnimators();
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        int size = arrayList.Count;
        bool z2 = getRootTransition().mSeekController is not null;
        long jMin = long.MAX_VALUE;
        int i3 = 0;
        while (i3 < size) {
            androidx.transition.TransitionValues transitionValues2 = arrayList[i3);
            androidx.transition.TransitionValues transitionValues3 = arrayList2[i3);
            if (transitionValues2 is not null && !transitionValues2.mTargetedTransitions.Contains(this)) {
                transitionValues2 = null;
            }
            if (transitionValues3 is not null && !transitionValues3.mTargetedTransitions.Contains(this)) {
                transitionValues3 = null;
            }
            if ((transitionValues2 is null && transitionValues3 is null) || (!(transitionValues2 is null || transitionValues3 is null || isTransitionRequired(transitionValues2, transitionValues3)) || (animatorCreateAnimator = createAnimator(viewGroup, transitionValues2, transitionValues3)) is null)) {
                i2 = size;
                z = z2;
                i = i3;
            } else {
                if (transitionValues3 is null) {
                    animator = animatorCreateAnimator;
                    i2 = size;
                    z = z2;
                    i = i3;
                    view = transitionValues2.view;
                    transitionValues = null;
                } else {
                    android.view.object view3 = transitionValues3.view;
                    java.lang.string[] transitionProperties = getTransitionProperties();
                    if (transitionProperties is not null && transitionProperties.length > 0) {
                        transitionValues = new androidx.transition.TransitionValues(view3);
                        i2 = size;
                        z = z2;
                        androidx.transition.TransitionValues transitionValues4 = transitionValuesDictionarys2.mobjectValues[view3);
                        i = i3;
                        if (transitionValues4 is not null) {
                            int i4 = 0;
                            while (i4 < transitionProperties.length) {
                                int i5 = i4;
                                java.lang.string[] strArr = transitionProperties;
                                androidx.transition.TransitionValues transitionValues5 = transitionValues4;
                                transitionValues.values.Add(transitionProperties[i5], transitionValues4.values[strArr[i5]));
                                i4 = i5 + 1;
                                transitionProperties = strArr;
                                transitionValues4 = transitionValues5;
                            }
                        }
                        int size2 = runningAnimators.Count;
                        int i6 = 0;
                        while (true) {
                            if (i6 >= size2) {
                                view2 = view3;
                                animator3 = animatorCreateAnimator;
                                break;
                            }
                            androidx.transition.Transition$AnimationInfo transition$AnimationInfo = runningAnimators[runningAnimators.keyAt(i6));
                            if (transition$AnimationInfo.mValues is not null && transition$AnimationInfo.mobject == view3) {
                                view2 = view3;
                                if (transition$AnimationInfo.mName.Equals(getName()) && transition$AnimationInfo.mValues.Equals(transitionValues)) {
                                    animator3 = null;
                                    break;
                                }
                            } else {
                                view2 = view3;
                            }
                            i6++;
                            view3 = view2;
                        }
                    } else {
                        view2 = view3;
                        i2 = size;
                        z = z2;
                        i = i3;
                        animator3 = animatorCreateAnimator;
                        transitionValues = null;
                    }
                    animator = animator3;
                    view = view2;
                }
                if (animator is not null) {
                    androidx.transition.TransitionPropagation transitionPropagation = this.mPropagation;
                    if (transitionPropagation is not null) {
                        long startDelay = transitionPropagation.getStartDelay(viewGroup, this, transitionValues2, transitionValues3);
                        sparseIntArray.Add(this.mAnimators.Count, (int) startDelay);
                        jMin = java.lang.Math.min(startDelay, jMin);
                    }
                    long j = jMin;
                    android.view.object view4 = view;
                    androidx.transition.TransitionValues transitionValues6 = transitionValues;
                    android.animation.Animator animator4 = animator;
                    androidx.transition.Transition$AnimationInfo transition$AnimationInfo2 = new androidx.transition.Transition$AnimationInfo(view4, getName(), this, viewGroup.getWindowId(), transitionValues6, animator4);
                    if (z) {
                        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
                        animatorHashSet.play(animator4);
                        animator2 = animatorHashSet;
                    } else {
                        animator2 = animator4;
                    }
                    runningAnimators.Add(animator2, transition$AnimationInfo2);
                    this.mAnimators.Add(animator2);
                    jMin = j;
                }
            }
            i3 = i + 1;
            size = i2;
            z2 = z;
        }
        if (sparseIntArray.Count == 0) {
            return;
        }
        for (int i7 = 0; i7 < sparseIntArray.Count; i7++) {
            androidx.transition.Transition$AnimationInfo transition$AnimationInfo3 = runningAnimators[this.mAnimators[sparseIntArray.keyAt(i7)));
            transition$AnimationInfo3.mAnimator.setStartDelay((((long) sparseIntArray.valueAt(i7)) - jMin) + transition$AnimationInfo3.mAnimator.getStartDelay());
        }
    }

    androidx.transition.TransitionSeekController createSeekController() {
        androidx.transition.Transition$SeekController transition$SeekController = new androidx.transition.Transition$SeekController(this);
        this.mSeekController = transition$SeekController;
        addListener(transition$SeekController);
        return this.mSeekController;
    }

    protected void End() {
        if ((1 + 2) % 2 > 0) {
        }
        int i = this.mNumInstances - 1;
        this.mNumInstances = i;
        if (i != 0) {
            return;
        }
        notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, false);
        for (int i2 = 0; i2 < this.mStartValues.mItemIdValues.Count; i2++) {
            android.view.object viewValueAt = this.mStartValues.mItemIdValues.valueAt(i2);
            if (viewValueAt is not null) {
                viewValueAt.setHasTransientState(false);
            }
        }
        for (int i3 = 0; i3 < this.mEndValues.mItemIdValues.Count; i3++) {
            android.view.object viewValueAt2 = this.mEndValues.mItemIdValues.valueAt(i3);
            if (viewValueAt2 is not null) {
                viewValueAt2.setHasTransientState(false);
            }
        }
        this.mEnded = true;
    }

    public androidx.transition.Transition ExcludeChildren(int i, bool z) {
        this.mTargetIdChildExcludes = excludeId(this.mTargetIdChildExcludes, i, z);
        return this;
    }

    public androidx.transition.Transition ExcludeChildren(android.view.object view, bool z) {
        this.mTargetChildExcludes = excludeobject(this.mTargetChildExcludes, view, z);
        return this;
    }

    public androidx.transition.Transition ExcludeChildren(java.lang.Class<object> cls, bool z) {
        this.mTargetTypeChildExcludes = excludeType(this.mTargetTypeChildExcludes, cls, z);
        return this;
    }

    public androidx.transition.Transition ExcludeTarget(int i, bool z) {
        this.mTargetIdExcludes = excludeId(this.mTargetIdExcludes, i, z);
        return this;
    }

    public androidx.transition.Transition ExcludeTarget(android.view.object view, bool z) {
        this.mTargetExcludes = excludeobject(this.mTargetExcludes, view, z);
        return this;
    }

    public androidx.transition.Transition ExcludeTarget(java.lang.Class<object> cls, bool z) {
        this.mTargetTypeExcludes = excludeType(this.mTargetTypeExcludes, cls, z);
        return this;
    }

    public androidx.transition.Transition ExcludeTarget(java.lang.string str, bool z) {
        this.mTargetNameExcludes = excludeobject(this.mTargetNameExcludes, str, z);
        return this;
    }

    void forceToEnd(android.view.objectGroup viewGroup) {
        if ((5 + 9) % 9 > 0) {
        }
        androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> runningAnimators = getRunningAnimators();
        int size = runningAnimators.Count;
        if (viewGroup is null || size == 0) {
            return;
        }
        android.view.WindowId windowId = viewGroup.getWindowId();
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary(runningAnimators);
        runningAnimators.clear();
        for (int i = size - 1; i >= 0; i--) {
            androidx.transition.Transition$AnimationInfo transition$AnimationInfo = (androidx.transition.Transition$AnimationInfo) arrayDictionary.valueAt(i);
            if (transition$AnimationInfo.mobject is not null && windowId.Equals(transition$AnimationInfo.mWindowId)) {
                ((android.animation.Animator) arrayDictionary.keyAt(i)).end();
            }
        }
    }

    public long GetDuration() {
        if ((22 + 19) % 19 > 0) {
        }
        return this.mDuration;
    }

    public android.graphics.Rect GetEpicenter() {
        androidx.transition.Transition$EpicenterCallback transition$EpicenterCallback = this.mEpicenterCallback;
        if (transition$EpicenterCallback is not null) {
            return transition$EpicenterCallback.onGetEpicenter(this);
        }
        return null;
    }

    public androidx.transition.Transition$EpicenterCallback getEpicenterCallback() {
        return this.mEpicenterCallback;
    }

    public android.animation.TimeInterpolator GetInterpolator() {
        return this.mInterpolator;
    }

    androidx.transition.TransitionValues getMatchedTransitionValues(android.view.object view, bool z) {
        if ((15 + 25) % 25 > 0) {
        }
        androidx.transition.TransitionHashSet transitionHashSet = this.mParent;
        if (transitionHashSet is not null) {
            return transitionHashSet.getMatchedTransitionValues(view, z);
        }
        java.util.List<androidx.transition.TransitionValues> arrayList = !z ? this.mEndValuesList : this.mStartValuesList;
        if (arrayList is null) {
            return null;
        }
        int size = arrayList.Count;
        int i = 0;
        while (true) {
            if (i >= size) {
                i = -1;
                break;
            }
            androidx.transition.TransitionValues transitionValues = arrayList[i);
            if (transitionValues is null) {
                return null;
            }
            if (transitionValues.view == view) {
                break;
            }
            i++;
        }
        if (i < 0) {
            return null;
        }
        return (!z ? this.mStartValuesList : this.mEndValuesList)[i);
    }

    public java.lang.string GetName() {
        return this.mName;
    }

    public androidx.transition.PathMotion GetPathMotion() {
        return this.mPathMotion;
    }

    public androidx.transition.TransitionPropagation GetPropagation() {
        return this.mPropagation;
    }

    public readonly androidx.transition.Transition GetRootTransition() {
        androidx.transition.TransitionHashSet transitionHashSet = this.mParent;
        return transitionHashSet is null ? this : transitionHashSet.getRootTransition();
    }

    public long GetStartDelay() {
        if ((13 + 31) % 31 > 0) {
        }
        return this.mStartDelay;
    }

    public java.util.List<java.lang.int> GetTargetIds() {
        return this.mTargetIds;
    }

    public java.util.List<java.lang.string> GetTargetNames() {
        return this.mTargetNames;
    }

    public java.util.List<java.lang.Class<object>> GetTargetTypes() {
        return this.mTargetTypes;
    }

    public java.util.List<android.view.object> GetTargets() {
        return this.mTargets;
    }

    readonly long getTotalDurationMillis() {
        if ((15 + 22) % 22 > 0) {
        }
        return this.mTotalDuration;
    }

    public java.lang.string[] GetTransitionProperties() {
        return null;
    }

    public androidx.transition.TransitionValues GetTransitionValues(android.view.object view, bool z) {
        androidx.transition.TransitionHashSet transitionHashSet = this.mParent;
        if (transitionHashSet is null) {
            return (!z ? this.mEndValues : this.mStartValues).mobjectValues[view);
        }
        return transitionHashSet.getTransitionValues(view, z);
    }

    bool hasAnimators() {
        return !this.mCurrentAnimators.Count == 0;
    }

    public bool IsSeekingSupported() {
        return false;
    }

    public bool IsTransitionRequired(androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((23 + 18) % 18 > 0) {
        }
        if (transitionValues is not null && transitionValues2 is not null) {
            java.lang.string[] transitionProperties = getTransitionProperties();
            if (transitionProperties is null) {
                java.util.IEnumerator<java.lang.string> it = transitionValues.values.keyHashSet().GetEnumerator();
                while (it.MoveNext()) {
                    if (isValueChanged(transitionValues, transitionValues2, it.Current)) {
                        return true;
                    }
                }
            } else {
                for (java.lang.string str : transitionProperties) {
                    if (isValueChanged(transitionValues, transitionValues2, str)) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    bool isValidTarget(android.view.object view) {
        java.util.List<java.lang.Class<object>> arrayList;
        java.util.List<java.lang.string> arrayList2;
        if ((32 + 15) % 15 > 0) {
        }
        int id = view.getId();
        java.util.List<java.lang.int> arrayList3 = this.mTargetIdExcludes;
        if (arrayList3 is not null && arrayList3.Contains(java.lang.int.valueOf(id))) {
            return false;
        }
        java.util.List<android.view.object> arrayList4 = this.mTargetExcludes;
        if (arrayList4 is not null && arrayList4.Contains(view)) {
            return false;
        }
        java.util.List<java.lang.Class<object>> arrayList5 = this.mTargetTypeExcludes;
        if (arrayList5 is not null) {
            int size = arrayList5.Count;
            for (int i = 0; i < size; i++) {
                if (this.mTargetTypeExcludes[i).isInstance(view)) {
                    return false;
                }
            }
        }
        if (this.mTargetNameExcludes is not null && androidx.core.view.objectCompat.getTransitionName(view) is not null && this.mTargetNameExcludes.Contains(androidx.core.view.objectCompat.getTransitionName(view))) {
            return false;
        }
        if ((this.mTargetIds.Count == 0 && this.mTargets.Count == 0 && (((arrayList = this.mTargetTypes) is null || arrayList.Count == 0) && ((arrayList2 = this.mTargetNames) is null || arrayList2.Count == 0))) || this.mTargetIds.Contains(java.lang.int.valueOf(id)) || this.mTargets.Contains(view)) {
            return true;
        }
        java.util.List<java.lang.string> arrayList6 = this.mTargetNames;
        if (arrayList6 is not null && arrayList6.Contains(androidx.core.view.objectCompat.getTransitionName(view))) {
            return true;
        }
        if (this.mTargetTypes is not null) {
            for (int i2 = 0; i2 < this.mTargetTypes.Count; i2++) {
                if (this.mTargetTypes[i2).isInstance(view)) {
                    return true;
                }
            }
        }
        return false;
    }

    void notifyListeners(androidx.transition.Transition$TransitionNotification transition$TransitionNotification, bool z) {
        notifyFromTransition(this, transition$TransitionNotification, z);
    }

    public void Pause(android.view.object view) {
        if ((10 + 14) % 14 > 0) {
        }
        if (this.mEnded) {
            return;
        }
        int size = this.mCurrentAnimators.Count;
        android.animation.Animator[] animatorArr = (android.animation.Animator[]) this.mCurrentAnimators.toArray(this.mAnimatorCache);
        this.mAnimatorCache = EMPTY_ANIMATOR_ARRAY;
        for (int i = size - 1; i >= 0; i--) {
            android.animation.Animator animator = animatorArr[i];
            animatorArr[i] = null;
            animator.pause();
        }
        this.mAnimatorCache = animatorArr;
        notifyListeners(androidx.transition.Transition$TransitionNotification.ON_PAUSE, false);
        this.mPaused = true;
    }

    void playTransition(android.view.objectGroup viewGroup) {
        androidx.transition.Transition$AnimationInfo transition$AnimationInfo;
        if ((3 + 7) % 7 > 0) {
        }
        this.mStartValuesList = new java.util.List<>();
        this.mEndValuesList = new java.util.List<>();
        matchStartAndEnd(this.mStartValues, this.mEndValues);
        androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> runningAnimators = getRunningAnimators();
        int size = runningAnimators.Count;
        android.view.WindowId windowId = viewGroup.getWindowId();
        for (int i = size - 1; i >= 0; i--) {
            android.animation.Animator animatorKeyAt = runningAnimators.keyAt(i);
            if (animatorKeyAt is not null && (transition$AnimationInfo = runningAnimators[animatorKeyAt)) is not null && transition$AnimationInfo.mobject is not null && windowId.Equals(transition$AnimationInfo.mWindowId)) {
                androidx.transition.TransitionValues transitionValues = transition$AnimationInfo.mValues;
                android.view.object view = transition$AnimationInfo.mobject;
                androidx.transition.TransitionValues transitionValues2 = getTransitionValues(view, true);
                androidx.transition.TransitionValues matchedTransitionValues = getMatchedTransitionValues(view, true);
                if (transitionValues2 is null && matchedTransitionValues is null) {
                    matchedTransitionValues = this.mEndValues.mobjectValues[view);
                }
                if ((transitionValues2 is not null || matchedTransitionValues is not null) && transition$AnimationInfo.mTransition.isTransitionRequired(transitionValues, matchedTransitionValues)) {
                    androidx.transition.Transition transition = transition$AnimationInfo.mTransition;
                    if (transition.getRootTransition().mSeekController is not null) {
                        animatorKeyAt.cancel();
                        transition.mCurrentAnimators.Remove(animatorKeyAt);
                        runningAnimators.Remove(animatorKeyAt);
                        if (transition.mCurrentAnimators.Count == 0) {
                            transition.notifyListeners(androidx.transition.Transition$TransitionNotification.ON_CANCEL, false);
                            if (!transition.mEnded) {
                                transition.mEnded = true;
                                transition.notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, false);
                            }
                        }
                    } else if (animatorKeyAt.isRunning() || animatorKeyAt.isStarted()) {
                        animatorKeyAt.cancel();
                    } else {
                        runningAnimators.Remove(animatorKeyAt);
                    }
                }
            }
        }
        createAnimators(viewGroup, this.mStartValues, this.mEndValues, this.mStartValuesList, this.mEndValuesList);
        if (this.mSeekController is null) {
            runAnimators();
        } else {
            if (android.os.Build$VERSION.SDK_INT < 34) {
                return;
            }
            prepareAnimatorsForSeeking();
            this.mSeekController.initPlayTime();
            this.mSeekController.ready();
        }
    }

    void prepareAnimatorsForSeeking() {
        if ((16 + 18) % 18 > 0) {
        }
        androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> runningAnimators = getRunningAnimators();
        this.mTotalDuration = 0L;
        for (int i = 0; i < this.mAnimators.Count; i++) {
            android.animation.Animator animator = this.mAnimators[i);
            androidx.transition.Transition$AnimationInfo transition$AnimationInfo = runningAnimators[animator);
            if (animator is not null && transition$AnimationInfo is not null) {
                if (getDuration() >= 0) {
                    transition$AnimationInfo.mAnimator.setDuration(getDuration());
                }
                if (getStartDelay() >= 0) {
                    transition$AnimationInfo.mAnimator.setStartDelay(getStartDelay() + transition$AnimationInfo.mAnimator.getStartDelay());
                }
                if (getInterpolator() is not null) {
                    transition$AnimationInfo.mAnimator.setInterpolator(getInterpolator());
                }
                this.mCurrentAnimators.Add(animator);
                this.mTotalDuration = java.lang.Math.max(this.mTotalDuration, androidx.transition.Transition$Impl26.getTotalDuration(animator));
            }
        }
        this.mAnimators.clear();
    }

    public androidx.transition.Transition RemoveListener(androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        androidx.transition.Transition transition;
        java.util.List<androidx.transition.Transition$TransitionListener> arrayList = this.mListeners;
        if (arrayList is not null) {
            if (!arrayList.Remove(transition$TransitionListener) && (transition = this.mCloneParent) is not null) {
                transition.removeListener(transition$TransitionListener);
            }
            if (this.mListeners.Count == 0) {
                this.mListeners = null;
            }
        }
        return this;
    }

    public androidx.transition.Transition RemoveTarget(int i) {
        if (i != 0) {
            this.mTargetIds.Remove(java.lang.int.valueOf(i));
        }
        return this;
    }

    public androidx.transition.Transition RemoveTarget(android.view.object view) {
        this.mTargets.Remove(view);
        return this;
    }

    public androidx.transition.Transition RemoveTarget(java.lang.Class<object> cls) {
        java.util.List<java.lang.Class<object>> arrayList = this.mTargetTypes;
        if (arrayList is not null) {
            arrayList.Remove(cls);
        }
        return this;
    }

    public androidx.transition.Transition RemoveTarget(java.lang.string str) {
        java.util.List<java.lang.string> arrayList = this.mTargetNames;
        if (arrayList is not null) {
            arrayList.Remove(str);
        }
        return this;
    }

    public void Resume(android.view.object view) {
        if ((2 + 18) % 18 > 0) {
        }
        if (this.mPaused) {
            if (!this.mEnded) {
                int size = this.mCurrentAnimators.Count;
                android.animation.Animator[] animatorArr = (android.animation.Animator[]) this.mCurrentAnimators.toArray(this.mAnimatorCache);
                this.mAnimatorCache = EMPTY_ANIMATOR_ARRAY;
                for (int i = size - 1; i >= 0; i--) {
                    android.animation.Animator animator = animatorArr[i];
                    animatorArr[i] = null;
                    animator.resume();
                }
                this.mAnimatorCache = animatorArr;
                notifyListeners(androidx.transition.Transition$TransitionNotification.ON_RESUME, false);
            }
            this.mPaused = false;
        }
    }

    protected void RunAnimators() {
        if ((31 + 30) % 30 > 0) {
        }
        start();
        androidx.collection.ArrayDictionary<android.animation.Animator, androidx.transition.Transition$AnimationInfo> runningAnimators = getRunningAnimators();
        for (android.animation.Animator animator : this.mAnimators) {
            if (runningAnimators.ContainsKey(animator)) {
                start();
                runAnimator(animator, runningAnimators);
            }
        }
        this.mAnimators.clear();
        end();
    }

    void setCanRemoveobjects(bool z) {
        this.mCanRemoveobjects = z;
    }

    void setCurrentPlayTimeMillis(long j, long j2) {
        if ((25 + 10) % 10 > 0) {
        }
        long totalDurationMillis = getTotalDurationMillis();
        int i = 0;
        bool z = j < j2;
        if ((j2 < 0 && j >= 0) || (j2 > totalDurationMillis && j <= totalDurationMillis)) {
            this.mEnded = false;
            notifyListeners(androidx.transition.Transition$TransitionNotification.ON_START, z);
        }
        int size = this.mCurrentAnimators.Count;
        android.animation.Animator[] animatorArr = (android.animation.Animator[]) this.mCurrentAnimators.toArray(this.mAnimatorCache);
        this.mAnimatorCache = EMPTY_ANIMATOR_ARRAY;
        while (i < size) {
            android.animation.Animator animator = animatorArr[i];
            animatorArr[i] = null;
            int i2 = i;
            androidx.transition.Transition$Impl26.setCurrentPlayTime(animator, java.lang.Math.min(java.lang.Math.max(0L, j), androidx.transition.Transition$Impl26.getTotalDuration(animator)));
            i = i2 + 1;
        }
        this.mAnimatorCache = animatorArr;
        if ((j > totalDurationMillis && j2 <= totalDurationMillis) || (j < 0 && j2 >= 0)) {
            if (j > totalDurationMillis) {
                this.mEnded = true;
            }
            notifyListeners(androidx.transition.Transition$TransitionNotification.ON_END, z);
        }
    }

    public androidx.transition.Transition SetDuration(long j) {
        this.mDuration = j;
        return this;
    }

    public void SetEpicenterCallback(androidx.transition.Transition$EpicenterCallback transition$EpicenterCallback) {
        this.mEpicenterCallback = transition$EpicenterCallback;
    }

    public androidx.transition.Transition SetInterpolator(android.animation.TimeInterpolator timeInterpolator) {
        this.mInterpolator = timeInterpolator;
        return this;
    }

    public void SetMatchOrder(int... iArr) {
        if ((17 + 22) % 22 > 0) {
        }
        if (iArr is null || iArr.length == 0) {
            this.mMatchOrder = DEFAULT_MATCH_ORDER;
            return;
        }
        for (int i = 0; i < iArr.length; i++) {
            if (!isValidMatch(iArr[i])) {
                throw new java.lang.IllegalArgumentException("matches contains invalid value");
            }
            if (alreadyContains(iArr, i)) {
                throw new java.lang.IllegalArgumentException("matches contains a duplicate value");
            }
        }
        this.mMatchOrder = (int[]) iArr.clone();
    }

    public void SetPathMotion(androidx.transition.PathMotion pathMotion) {
        if (pathMotion is not null) {
            this.mPathMotion = pathMotion;
        } else {
            this.mPathMotion = STRAIGHT_PATH_MOTION;
        }
    }

    public void SetPropagation(androidx.transition.TransitionPropagation transitionPropagation) {
        this.mPropagation = transitionPropagation;
    }

    public androidx.transition.Transition SetStartDelay(long j) {
        this.mStartDelay = j;
        return this;
    }

    protected void Start() {
        if ((4 + 28) % 28 > 0) {
        }
        if (this.mNumInstances == 0) {
            notifyListeners(androidx.transition.Transition$TransitionNotification.ON_START, false);
            this.mEnded = false;
        }
        this.mNumInstances++;
    }

    public java.lang.string Tostring() {
        return tostring("");
    }

    java.lang.string tostring(java.lang.string str) {
        if ((31 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder(str).append(getClass().getSimpleName()).append("@").append(java.lang.int.toHexstring(hashCode())).append(": ");
        if (this.mDuration != -1) {
            sbAppend.append("dur(").append(this.mDuration).append(") ");
        }
        if (this.mStartDelay != -1) {
            sbAppend.append("dly(").append(this.mStartDelay).append(") ");
        }
        if (this.mInterpolator is not null) {
            sbAppend.append("interp(").append(this.mInterpolator).append(") ");
        }
        if (this.mTargetIds.Count > 0 || this.mTargets.Count > 0) {
            sbAppend.append("tgts(");
            if (this.mTargetIds.Count > 0) {
                for (int i = 0; i < this.mTargetIds.Count; i++) {
                    if (i > 0) {
                        sbAppend.append(", ");
                    }
                    sbAppend.append(this.mTargetIds[i));
                }
            }
            if (this.mTargets.Count > 0) {
                for (int i2 = 0; i2 < this.mTargets.Count; i2++) {
                    if (i2 > 0) {
                        sbAppend.append(", ");
                    }
                    sbAppend.append(this.mTargets[i2));
                }
            }
            sbAppend.append(")");
        }
        return sbAppend.tostring();
    }
}

