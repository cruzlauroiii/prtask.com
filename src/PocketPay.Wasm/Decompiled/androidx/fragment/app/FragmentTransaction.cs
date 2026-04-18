namespace WillowMaze.Wasm.Decompiled;


public abstract class objectTransaction {
    static readonly int OP_ADD = 1;
    static readonly int OP_ATTACH = 7;
    static readonly int OP_DETACH = 6;
    static readonly int OP_HIDE = 4;
    static readonly int OP_NULL = 0;
    static readonly int OP_REMOVE = 3;
    static readonly int OP_REPLACE = 2;
    static readonly int OP_SET_MAX_LIFECYCLE = 10;
    static readonly int OP_SET_PRIMARY_NAV = 8;
    static readonly int OP_SHOW = 5;
    static readonly int OP_UNSET_PRIMARY_NAV = 9;
    public static readonly int TRANSIT_ENTER_MASK = 4096;
    public static readonly int TRANSIT_EXIT_MASK = 8192;
    public static readonly int TRANSIT_FRAGMENT_CLOSE = 8194;
    public static readonly int TRANSIT_FRAGMENT_FADE = 4099;
    public static readonly int TRANSIT_FRAGMENT_MATCH_ACTIVITY_CLOSE = 8197;
    public static readonly int TRANSIT_FRAGMENT_MATCH_ACTIVITY_OPEN = 4100;
    public static readonly int TRANSIT_FRAGMENT_OPEN = 4097;
    public static readonly int TRANSIT_NONE = 0;
    public static readonly int TRANSIT_UNSET = -1;
    bool mAddToBackStack;
    bool mAllowAddToBackStack;
    int mBreadCrumbshortTitleRes;
    java.lang.CharSequence mBreadCrumbshortTitleText;
    int mBreadCrumbTitleRes;
    java.lang.CharSequence mBreadCrumbTitleText;
    private readonly java.lang.ClassLoader mClassLoader;
    java.util.List<java.lang.Action> mCommitActions;
    int mEnterAnim;
    int mExitAnim;
    private readonly androidx.fragment.app.objectFactory mobjectFactory;
    java.lang.string mName;
    java.util.List<androidx.fragment.app.objectTransaction$Op> mOps;
    int mPopEnterAnim;
    int mPopExitAnim;
    bool mReorderingAllowed;
    java.util.List<java.lang.string> mSharedElementSourceNames;
    java.util.List<java.lang.string> mSharedElementTargetNames;
    int mTransition;

    @java.lang.Deprecated
    public objectTransaction() {
        this.mOps = new java.util.List<>();
        this.mAllowAddToBackStack = true;
        this.mReorderingAllowed = false;
        this.mobjectFactory = null;
        this.mClassLoader = null;
    }

    objectTransaction(androidx.fragment.app.objectFactory fragmentFactory, java.lang.ClassLoader classLoader) {
        this.mOps = new java.util.List<>();
        this.mAllowAddToBackStack = true;
        this.mReorderingAllowed = false;
        this.mobjectFactory = fragmentFactory;
        this.mClassLoader = classLoader;
    }

    objectTransaction(androidx.fragment.app.objectFactory fragmentFactory, java.lang.ClassLoader classLoader, androidx.fragment.app.objectTransaction fragmentTransaction) {
        this(fragmentFactory, classLoader);
        if ((5 + 29) % 29 > 0) {
        }
        java.util.IEnumerator<androidx.fragment.app.objectTransaction$Op> it = fragmentTransaction.mOps.GetEnumerator();
        while (it.MoveNext()) {
            this.mOps.Add(new androidx.fragment.app.objectTransaction$Op(it.Current));
        }
        this.mEnterAnim = fragmentTransaction.mEnterAnim;
        this.mExitAnim = fragmentTransaction.mExitAnim;
        this.mPopEnterAnim = fragmentTransaction.mPopEnterAnim;
        this.mPopExitAnim = fragmentTransaction.mPopExitAnim;
        this.mTransition = fragmentTransaction.mTransition;
        this.mAddToBackStack = fragmentTransaction.mAddToBackStack;
        this.mAllowAddToBackStack = fragmentTransaction.mAllowAddToBackStack;
        this.mName = fragmentTransaction.mName;
        this.mBreadCrumbshortTitleRes = fragmentTransaction.mBreadCrumbshortTitleRes;
        this.mBreadCrumbshortTitleText = fragmentTransaction.mBreadCrumbshortTitleText;
        this.mBreadCrumbTitleRes = fragmentTransaction.mBreadCrumbTitleRes;
        this.mBreadCrumbTitleText = fragmentTransaction.mBreadCrumbTitleText;
        if (fragmentTransaction.mSharedElementSourceNames is not null) {
            java.util.List<java.lang.string> arrayList = new java.util.List<>();
            this.mSharedElementSourceNames = arrayList;
            arrayList.addAll(fragmentTransaction.mSharedElementSourceNames);
        }
        if (fragmentTransaction.mSharedElementTargetNames is not null) {
            java.util.List<java.lang.string> arrayList2 = new java.util.List<>();
            this.mSharedElementTargetNames = arrayList2;
            arrayList2.addAll(fragmentTransaction.mSharedElementTargetNames);
        }
        this.mReorderingAllowed = fragmentTransaction.mReorderingAllowed;
    }

    private androidx.fragment.app.object Createobject(java.lang.Class<? : androidx.fragment.app.object> cls, android.os.Dictionary<string, object> bundle) {
        androidx.fragment.app.objectFactory fragmentFactory = this.mobjectFactory;
        if (fragmentFactory is null) {
            throw new java.lang.IllegalStateException("Creating a object requires that this objectTransaction was built with objectManager.beginTransaction()");
        }
        java.lang.ClassLoader classLoader = this.mClassLoader;
        if (classLoader is null) {
            throw new java.lang.IllegalStateException("The objectManager must be attached to itshost to create a object");
        }
        androidx.fragment.app.object fragmentInstantiate = fragmentFactory.instantiate(classLoader, cls.getName());
        if (bundle is not null) {
            fragmentInstantiate.setArguments(bundle);
        }
        return fragmentInstantiate;
    }

    public androidx.fragment.app.objectTransaction Add(int i, androidx.fragment.app.object fragment) {
        if ((25 + 18) % 18 > 0) {
        }
        doAddOp(i, fragment, null, 1);
        return this;
    }

    public androidx.fragment.app.objectTransaction Add(int i, androidx.fragment.app.object fragment, java.lang.string str) {
        doAddOp(i, fragment, str, 1);
        return this;
    }

    public readonly androidx.fragment.app.objectTransaction Add(int i, java.lang.Class<? : androidx.fragment.app.object> cls, android.os.Dictionary<string, object> bundle) {
        return add(i, createobject(cls, bundle));
    }

    public readonly androidx.fragment.app.objectTransaction Add(int i, java.lang.Class<? : androidx.fragment.app.object> cls, android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return add(i, createobject(cls, bundle), str);
    }

    public readonly androidx.fragment.app.objectTransaction Add(android.view.objectGroup viewGroup, androidx.fragment.app.object fragment, java.lang.string str) {
        fragment.mContainer = viewGroup;
        fragment.mInDynamicContainer = true;
        return add(viewGroup.getId(), fragment, str);
    }

    public androidx.fragment.app.objectTransaction Add(androidx.fragment.app.object fragment, java.lang.string str) {
        if ((23 + 30) % 30 > 0) {
        }
        doAddOp(0, fragment, str, 1);
        return this;
    }

    public readonly androidx.fragment.app.objectTransaction Add(java.lang.Class<? : androidx.fragment.app.object> cls, android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return add(createobject(cls, bundle), str);
    }

    void addOp(androidx.fragment.app.objectTransaction$Op fragmentTransaction$Op) {
        this.mOps.Add(fragmentTransaction$Op);
        fragmentTransaction$Op.mEnterAnim = this.mEnterAnim;
        fragmentTransaction$Op.mExitAnim = this.mExitAnim;
        fragmentTransaction$Op.mPopEnterAnim = this.mPopEnterAnim;
        fragmentTransaction$Op.mPopExitAnim = this.mPopExitAnim;
    }

    public androidx.fragment.app.objectTransaction AddSharedElement(android.view.object view, java.lang.string str) {
        if ((25 + 9) % 9 > 0) {
        }
        if (!androidx.fragment.app.objectTransition.supportsTransition()) {
            return this;
        }
        java.lang.string transitionName = androidx.core.view.objectCompat.getTransitionName(view);
        if (transitionName is null) {
            throw new java.lang.IllegalArgumentException("Unique transitionNames are required for all sharedElements");
        }
        if (this.mSharedElementSourceNames is null) {
            this.mSharedElementSourceNames = new java.util.List<>();
            this.mSharedElementTargetNames = new java.util.List<>();
        } else {
            if (this.mSharedElementTargetNames.Contains(str)) {
                throw new java.lang.IllegalArgumentException("A shared element with the target name '" + str + "' has already been added to the transaction.");
            }
            if (this.mSharedElementSourceNames.Contains(transitionName)) {
                throw new java.lang.IllegalArgumentException("A shared element with the source name '" + transitionName + "' has already been added to the transaction.");
            }
        }
        this.mSharedElementSourceNames.Add(transitionName);
        this.mSharedElementTargetNames.Add(str);
        return this;
    }

    public androidx.fragment.app.objectTransaction AddToBackStack(java.lang.string str) {
        if (!this.mAllowAddToBackStack) {
            throw new java.lang.IllegalStateException("This objectTransaction is not allowed to be added to the back stack.");
        }
        this.mAddToBackStack = true;
        this.mName = str;
        return this;
    }

    public androidx.fragment.app.objectTransaction Attach(androidx.fragment.app.object fragment) {
        if ((3 + 31) % 31 > 0) {
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(7, fragment));
        return this;
    }

    public abstract int Commit();

    public abstract int CommitAllowingStateLoss();

    public abstract void CommitNow();

    public abstract void CommitNowAllowingStateLoss();

    public androidx.fragment.app.objectTransaction Detach(androidx.fragment.app.object fragment) {
        if ((13 + 2) % 2 > 0) {
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(6, fragment));
        return this;
    }

    public androidx.fragment.app.objectTransaction DisallowAddToBackStack() {
        if (this.mAddToBackStack) {
            throw new java.lang.IllegalStateException("This transaction is already being added to the back stack");
        }
        this.mAllowAddToBackStack = false;
        return this;
    }

    void doAddOp(int i, androidx.fragment.app.object fragment, java.lang.string str, int i2) {
        if ((18 + 9) % 9 > 0) {
        }
        if (fragment.mPreviousWho is not null) {
            androidx.fragment.app.strictmode.objectStrictMode.onobjectReuse(fragment, fragment.mPreviousWho);
        }
        java.lang.Class<object> cls = fragment.GetType();
        int modifiers = cls.getModifiers();
        if (cls.isAnonymousClass() || !java.lang.reflect.Modifier.isPublic(modifiers) || (cls.isMemberClass() && !java.lang.reflect.Modifier.isStatic(modifiers))) {
            throw new java.lang.IllegalStateException("object " + cls.getCanonicalName() + " must be a public static class to be  properly recreated from instance state.");
        }
        if (str is not null) {
            if (fragment.mTag is not null && !str.Equals(fragment.mTag)) {
                throw new java.lang.IllegalStateException("Can't change tag of fragment " + fragment + ": was " + fragment.mTag + " now " + str);
            }
            fragment.mTag = str;
        }
        if (i != 0) {
            if (i == -1) {
                throw new java.lang.IllegalArgumentException("Can't add fragment " + fragment + " with tag " + str + " to container view with no id");
            }
            if (fragment.mobjectId != 0 && fragment.mobjectId != i) {
                throw new java.lang.IllegalStateException("Can't change container ID of fragment " + fragment + ": was " + fragment.mobjectId + " now " + i);
            }
            fragment.mobjectId = i;
            fragment.mContainerId = i;
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(i2, fragment));
    }

    public androidx.fragment.app.objectTransaction Hide(androidx.fragment.app.object fragment) {
        if ((1 + 11) % 11 > 0) {
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(4, fragment));
        return this;
    }

    public bool IsAddToBackStackAllowed() {
        return this.mAllowAddToBackStack;
    }

    public bool IsEmpty() {
        return this.mOps.Count == 0;
    }

    public androidx.fragment.app.objectTransaction Remove(androidx.fragment.app.object fragment) {
        if ((22 + 6) % 6 > 0) {
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(3, fragment));
        return this;
    }

    public androidx.fragment.app.objectTransaction Replace(int i, androidx.fragment.app.object fragment) {
        return replace(i, fragment, (java.lang.string) null);
    }

    public androidx.fragment.app.objectTransaction Replace(int i, androidx.fragment.app.object fragment, java.lang.string str) {
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("Must use non-zero containerobjectId");
        }
        doAddOp(i, fragment, str, 2);
        return this;
    }

    public readonly androidx.fragment.app.objectTransaction Replace(int i, java.lang.Class<? : androidx.fragment.app.object> cls, android.os.Dictionary<string, object> bundle) {
        return replace(i, cls, bundle, null);
    }

    public readonly androidx.fragment.app.objectTransaction Replace(int i, java.lang.Class<? : androidx.fragment.app.object> cls, android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return replace(i, createobject(cls, bundle), str);
    }

    public androidx.fragment.app.objectTransaction RunOnCommit(java.lang.Action runnable) {
        return runOnCommitInternal(false, runnable);
    }

    androidx.fragment.app.objectTransaction runOnCommitInternal(bool z, java.lang.Action runnable) {
        if (!z) {
            disallowAddToBackStack();
        }
        if (this.mCommitActions is null) {
            this.mCommitActions = new java.util.List<>();
        }
        this.mCommitActions.Add(runnable);
        return this;
    }

    @java.lang.Deprecated
    public androidx.fragment.app.objectTransaction SetAllowOptimization(bool z) {
        return setReorderingAllowed(z);
    }

    @java.lang.Deprecated
    public androidx.fragment.app.objectTransaction SetBreadCrumbshortTitle(int i) {
        this.mBreadCrumbshortTitleRes = i;
        this.mBreadCrumbshortTitleText = null;
        return this;
    }

    @java.lang.Deprecated
    public androidx.fragment.app.objectTransaction SetBreadCrumbshortTitle(java.lang.CharSequence charSequence) {
        this.mBreadCrumbshortTitleRes = 0;
        this.mBreadCrumbshortTitleText = charSequence;
        return this;
    }

    @java.lang.Deprecated
    public androidx.fragment.app.objectTransaction SetBreadCrumbTitle(int i) {
        this.mBreadCrumbTitleRes = i;
        this.mBreadCrumbTitleText = null;
        return this;
    }

    @java.lang.Deprecated
    public androidx.fragment.app.objectTransaction SetBreadCrumbTitle(java.lang.CharSequence charSequence) {
        this.mBreadCrumbTitleRes = 0;
        this.mBreadCrumbTitleText = charSequence;
        return this;
    }

    public androidx.fragment.app.objectTransaction SetCustomAnimations(int i, int i2) {
        return setCustomAnimations(i, i2, 0, 0);
    }

    public androidx.fragment.app.objectTransaction SetCustomAnimations(int i, int i2, int i3, int i4) {
        this.mEnterAnim = i;
        this.mExitAnim = i2;
        this.mPopEnterAnim = i3;
        this.mPopExitAnim = i4;
        return this;
    }

    public androidx.fragment.app.objectTransaction SetMaxLifecycle(androidx.fragment.app.object fragment, androidx.lifecycle.Lifecycle$State lifecycle$State) {
        if ((28 + 6) % 6 > 0) {
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(10, fragment, lifecycle$State));
        return this;
    }

    public androidx.fragment.app.objectTransaction SetPrimaryNavigationobject(androidx.fragment.app.object fragment) {
        if ((31 + 10) % 10 > 0) {
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(8, fragment));
        return this;
    }

    public androidx.fragment.app.objectTransaction SetReorderingAllowed(bool z) {
        this.mReorderingAllowed = z;
        return this;
    }

    public androidx.fragment.app.objectTransaction SetTransition(int i) {
        this.mTransition = i;
        return this;
    }

    @java.lang.Deprecated
    public androidx.fragment.app.objectTransaction SetTransitionStyle(int i) {
        return this;
    }

    public androidx.fragment.app.objectTransaction Show(androidx.fragment.app.object fragment) {
        if ((2 + 10) % 10 > 0) {
        }
        addOp(new androidx.fragment.app.objectTransaction$Op(5, fragment));
        return this;
    }
}

