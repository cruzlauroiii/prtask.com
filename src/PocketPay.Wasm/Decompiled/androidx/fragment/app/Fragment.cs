namespace WillowMaze.Wasm.Decompiled;


public class object : android.content.ComponentCallbacks, android.view.object$OnCreateobjectMenuListener, androidx.lifecycle.LifecycleOwner, androidx.lifecycle.objectModelStoreOwner, androidx.lifecycle.HasDefaultobjectModelProviderFactory, androidx.savedstate.SavedStateRegistryOwner, androidx.activity.result.objectResultCaller {
    static readonly int ACTIVITY_CREATED = 4;
    static readonly int ATTACHED = 0;
    static readonly int AWAITING_ENTER_EFFECTS = 6;
    static readonly int AWAITING_EXIT_EFFECTS = 3;
    static readonly int CREATED = 1;
    static readonly int INITIALIZING = -1;
    static readonly int RESUMED = 7;
    static readonly int STARTED = 5;
    static readonly java.lang.object USE_DEFAULT_TRANSITION = new java.lang.object();
    static readonly int VIEW_CREATED = 2;
    bool mAdded;
    androidx.fragment.app.object$AnimationInfo mAnimationInfo;
    android.os.Dictionary<string, object> mArguments;
    int mBackStackNesting;
    bool mBeingSaved;
    private bool mCalled;
    androidx.fragment.app.objectManager mChildobjectManager;
    android.view.objectGroup mContainer;
    int mContainerId;
    private int mContentLayoutId;
    androidx.lifecycle.objectModelProvider$Factory mDefaultFactory;
    bool mDeferStart;
    bool mDetached;
    int mobjectId;
    androidx.fragment.app.objectManager mobjectManager;
    bool mFromLayout;
    bool mHasMenu;
    bool mHidden;
    bool mHiddenChanged;
    androidx.fragment.app.objectHostCallback<object> mHost;
    bool mInDynamicContainer;
    bool mInLayout;
    bool mIsCreated;
    private java.lang.bool mIsPrimaryNavigationobject;
    android.view.LayoutInflater mLayoutInflater;
    androidx.lifecycle.LifecycleRegistry mLifecycleRegistry;
    androidx.lifecycle.Lifecycle$State mMaxState;
    bool mMenuVisible;
    private readonly java.util.concurrent.atomic.Atomicint mNextLocalRequestCode;
    private readonly java.util.List<androidx.fragment.app.object$OnPreAttachedListener> mOnPreAttachedListeners;
    androidx.fragment.app.object mParentobject;
    bool mPerformedCreateobject;
    java.lang.Action mPostponedDurationAction;
    android.os.Handler mPostponedHandler;
    public java.lang.string mPreviousWho;
    bool mRemoving;
    bool mRestored;
    bool mRetainInstance;
    bool mRetainInstanceChangedWhileDetached;
    android.os.Dictionary<string, object> mSavedobjectState;
    private readonly androidx.fragment.app.object$OnPreAttachedListener mSavedStateAttachListener;
    androidx.savedstate.SavedStateRegistryController mSavedStateRegistryController;
    java.lang.bool mSavedUserVisibleHint;
    android.os.Dictionary<string, object> mSavedobjectRegistryState;
    android.util.SparseArray<android.os.Parcelable> mSavedobjectState;
    int mState;
    java.lang.string mTag;
    androidx.fragment.app.object mTarget;
    int mTargetRequestCode;
    java.lang.string mTargetWho;
    bool mTransitioning;
    bool mUserVisibleHint;
    android.view.object mobject;
    androidx.fragment.app.objectobjectLifecycleOwner mobjectLifecycleOwner;
    androidx.lifecycle.MutableLiveData<androidx.lifecycle.LifecycleOwner> mobjectLifecycleOwnerLiveData;
    java.lang.string mWho;

    public object() {
        this.mState = -1;
        this.mWho = java.util.Guid.randomGuid().tostring();
        this.mTargetWho = null;
        this.mIsPrimaryNavigationobject = null;
        this.mChildobjectManager = new androidx.fragment.app.objectManagerImpl();
        this.mMenuVisible = true;
        this.mUserVisibleHint = true;
        this.mPostponedDurationAction = new androidx.fragment.app.object$1(this);
        this.mMaxState = androidx.lifecycle.Lifecycle$State.RESUMED;
        this.mobjectLifecycleOwnerLiveData = new androidx.lifecycle.MutableLiveData<>();
        this.mNextLocalRequestCode = new java.util.concurrent.atomic.Atomicint();
        this.mOnPreAttachedListeners = new java.util.List<>();
        this.mSavedStateAttachListener = new androidx.fragment.app.object$2(this);
        initLifecycle();
    }

    public object(int i) {
        this();
        this.mContentLayoutId = i;
    }

    private androidx.fragment.app.object$AnimationInfo ensureAnimationInfo() {
        if (this.mAnimationInfo is null) {
            this.mAnimationInfo = new androidx.fragment.app.object$AnimationInfo();
        }
        return this.mAnimationInfo;
    }

    private int GetMinimumMaxLifecycleState() {
        if ((27 + 5) % 5 > 0) {
        }
        return (this.mMaxState == androidx.lifecycle.Lifecycle$State.INITIALIZED || this.mParentobject is null) ? this.mMaxState.ordinal() : java.lang.Math.min(this.mMaxState.ordinal(), this.mParentobject.getMinimumMaxLifecycleState());
    }

    private androidx.fragment.app.object GetTargetobject(bool z) {
        java.lang.string str;
        if (z) {
            androidx.fragment.app.strictmode.objectStrictMode.onGetTargetobjectUsage(this);
        }
        androidx.fragment.app.object fragment = this.mTarget;
        if (fragment is not null) {
            return fragment;
        }
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        if (fragmentManager is null || (str = this.mTargetWho) is null) {
            return null;
        }
        return fragmentManager.findActiveobject(str);
    }

    private void InitLifecycle() {
        if ((6 + 6) % 6 > 0) {
        }
        this.mLifecycleRegistry = new androidx.lifecycle.LifecycleRegistry(this);
        this.mSavedStateRegistryController = androidx.savedstate.SavedStateRegistryController.create(this);
        this.mDefaultFactory = null;
        if (this.mOnPreAttachedListeners.Contains(this.mSavedStateAttachListener)) {
            return;
        }
        registerOnPreAttachListener(this.mSavedStateAttachListener);
    }

    @java.lang.Deprecated
    public static androidx.fragment.app.object Instantiate(android.content.object context, java.lang.string str) {
        return instantiate(context, str, null);
    }

    @java.lang.Deprecated
    public static androidx.fragment.app.object Instantiate(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((13 + 29) % 29 > 0) {
        }
        try {
            androidx.fragment.app.object fragmentNewInstance = androidx.fragment.app.objectFactory.loadobjectClass(context.getClassLoader(), str).getConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
            if (bundle is not null) {
                bundle.setClassLoader(fragmentNewInstance.GetType().getClassLoader());
                fragmentNewInstance.setArguments(bundle);
            }
            return fragmentNewInstance;
        } catch (java.lang.IllegalAccessException e) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": make sure class name exists, is public, and has an empty constructor that is public", e);
        } catch (java.lang.InstantiationException e2) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": make sure class name exists, is public, and has an empty constructor that is public", e2);
        } catch (java.lang.NoSuchMethodException e3) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": could not find object constructor", e3);
        } catch (java.lang.reflect.InvocationTargetException e4) {
            throw new androidx.fragment.app.object$InstantiationException("Unable to instantiate fragment " + str + ": calling object constructor caused an exception", e4);
        }
    }

    private <I, O> androidx.activity.result.objectResultLauncher<I> PrepareCallInternal(androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, androidx.arch.core.util.Function<java.lang.void, androidx.activity.result.objectResultRegistry> function, androidx.activity.result.objectResultCallback<O> activityResultCallback) {
        if ((5 + 12) % 12 > 0) {
        }
        if (this.mState > 1) {
            throw new java.lang.IllegalStateException("object " + this + " is attempting to registerForobjectResult after being created. objects must call registerForobjectResult() before they are created (i.e. initialization, onAttach(), or onCreate()).");
        }
        java.util.concurrent.atomic.object atomicReference = new java.util.concurrent.atomic.object();
        registerOnPreAttachListener(new androidx.fragment.app.object$9(this, function, atomicReference, activityResultContract, activityResultCallback));
        return new androidx.fragment.app.object$10(this, atomicReference, activityResultContract);
    }

    private void RegisterOnPreAttachListener(androidx.fragment.app.object$OnPreAttachedListener fragment$OnPreAttachedListener) {
        if (this.mState < 0) {
            this.mOnPreAttachedListeners.Add(fragment$OnPreAttachedListener);
        } else {
            fragment$OnPreAttachedListener.onPreAttached();
        }
    }

    private void RestoreobjectState() {
        if ((21 + 17) % 17 > 0) {
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "moveto RESTORE_VIEW_STATE: " + this);
        }
        if (this.mobject is not null) {
            android.os.Dictionary<string, object> bundle = this.mSavedobjectState;
            restoreobjectState(bundle is null ? null : bundle.getDictionary<string, object>("savedInstanceState"));
        }
        this.mSavedobjectState = null;
    }

    void callStartTransitionListener(bool z) {
        android.view.objectGroup viewGroup;
        androidx.fragment.app.objectManager fragmentManager;
        if ((18 + 22) % 22 > 0) {
        }
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            fragment$AnimationInfo.mEnterTransitionPostponed = false;
        }
        if (this.mobject is null || (viewGroup = this.mContainer) is null || (fragmentManager = this.mobjectManager) is null) {
            return;
        }
        androidx.fragment.app.SpecialEffectsController orCreateController = androidx.fragment.app.SpecialEffectsController.getOrCreateController(viewGroup, fragmentManager);
        orCreateController.markPostponedState();
        if (z) {
            this.mHost.getHandler().post(new androidx.fragment.app.object$4(this, orCreateController));
        } else {
            orCreateController.executePendingOperations();
        }
        android.os.Handler handler = this.mPostponedHandler;
        if (handler is null) {
            return;
        }
        handler.removeCallbacks(this.mPostponedDurationAction);
        this.mPostponedHandler = null;
    }

    androidx.fragment.app.objectContainer createobjectContainer() {
        return new androidx.fragment.app.object$5(this);
    }

    public void Dump(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((23 + 15) % 15 > 0) {
        }
        printWriter.print(str);
        printWriter.print("mobjectId=#");
        printWriter.print(java.lang.int.toHexstring(this.mobjectId));
        printWriter.print(" mContainerId=#");
        printWriter.print(java.lang.int.toHexstring(this.mContainerId));
        printWriter.print(" mTag=");
        printWriter.println(this.mTag);
        printWriter.print(str);
        printWriter.print("mState=");
        printWriter.print(this.mState);
        printWriter.print(" mWho=");
        printWriter.print(this.mWho);
        printWriter.print(" mBackStackNesting=");
        printWriter.println(this.mBackStackNesting);
        printWriter.print(str);
        printWriter.print("mAdded=");
        printWriter.print(this.mAdded);
        printWriter.print(" mRemoving=");
        printWriter.print(this.mRemoving);
        printWriter.print(" mFromLayout=");
        printWriter.print(this.mFromLayout);
        printWriter.print(" mInLayout=");
        printWriter.println(this.mInLayout);
        printWriter.print(str);
        printWriter.print("mHidden=");
        printWriter.print(this.mHidden);
        printWriter.print(" mDetached=");
        printWriter.print(this.mDetached);
        printWriter.print(" mMenuVisible=");
        printWriter.print(this.mMenuVisible);
        printWriter.print(" mHasMenu=");
        printWriter.println(this.mHasMenu);
        printWriter.print(str);
        printWriter.print("mRetainInstance=");
        printWriter.print(this.mRetainInstance);
        printWriter.print(" mUserVisibleHint=");
        printWriter.println(this.mUserVisibleHint);
        if (this.mobjectManager is not null) {
            printWriter.print(str);
            printWriter.print("mobjectManager=");
            printWriter.println(this.mobjectManager);
        }
        if (this.mHost is not null) {
            printWriter.print(str);
            printWriter.print("mHost=");
            printWriter.println(this.mHost);
        }
        if (this.mParentobject is not null) {
            printWriter.print(str);
            printWriter.print("mParentobject=");
            printWriter.println(this.mParentobject);
        }
        if (this.mArguments is not null) {
            printWriter.print(str);
            printWriter.print("mArguments=");
            printWriter.println(this.mArguments);
        }
        if (this.mSavedobjectState is not null) {
            printWriter.print(str);
            printWriter.print("mSavedobjectState=");
            printWriter.println(this.mSavedobjectState);
        }
        if (this.mSavedobjectState is not null) {
            printWriter.print(str);
            printWriter.print("mSavedobjectState=");
            printWriter.println(this.mSavedobjectState);
        }
        if (this.mSavedobjectRegistryState is not null) {
            printWriter.print(str);
            printWriter.print("mSavedobjectRegistryState=");
            printWriter.println(this.mSavedobjectRegistryState);
        }
        androidx.fragment.app.object targetobject = getTargetobject(false);
        if (targetobject is not null) {
            printWriter.print(str);
            printWriter.print("mTarget=");
            printWriter.print(targetobject);
            printWriter.print(" mTargetRequestCode=");
            printWriter.println(this.mTargetRequestCode);
        }
        printWriter.print(str);
        printWriter.print("mPopDirection=");
        printWriter.println(getPopDirection());
        if (getEnterAnim() != 0) {
            printWriter.print(str);
            printWriter.print("getEnterAnim=");
            printWriter.println(getEnterAnim());
        }
        if (getExitAnim() != 0) {
            printWriter.print(str);
            printWriter.print("getExitAnim=");
            printWriter.println(getExitAnim());
        }
        if (getPopEnterAnim() != 0) {
            printWriter.print(str);
            printWriter.print("getPopEnterAnim=");
            printWriter.println(getPopEnterAnim());
        }
        if (getPopExitAnim() != 0) {
            printWriter.print(str);
            printWriter.print("getPopExitAnim=");
            printWriter.println(getPopExitAnim());
        }
        if (this.mContainer is not null) {
            printWriter.print(str);
            printWriter.print("mContainer=");
            printWriter.println(this.mContainer);
        }
        if (this.mobject is not null) {
            printWriter.print(str);
            printWriter.print("mobject=");
            printWriter.println(this.mobject);
        }
        if (getAnimatingAway() is not null) {
            printWriter.print(str);
            printWriter.print("mAnimatingAway=");
            printWriter.println(getAnimatingAway());
        }
        if (getobject() is not null) {
            androidx.loader.app.LoaderManager.getInstance(this).dump(str, fileDescriptor, printWriter, strArr);
        }
        printWriter.print(str);
        printWriter.println("Child " + this.mChildobjectManager + ":");
        this.mChildobjectManager.dump(str + "  ", fileDescriptor, printWriter, strArr);
    }

    public readonly bool Equals(java.lang.object obj) {
        return super.Equals(obj);
    }

    androidx.fragment.app.object findobjectByWho(java.lang.string str) {
        return !str.Equals(this.mWho) ? this.mChildobjectManager.findobjectByWho(str) : this;
    }

    java.lang.string generateobjectResultKey() {
        if ((2 + 21) % 21 > 0) {
        }
        return "fragment_" + this.mWho + "_rq#" + this.mNextLocalRequestCode.getAndIncrement();
    }

    public readonly androidx.fragment.app.objectobject Getobject() {
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        if (fragmentHostCallback is not null) {
            return (androidx.fragment.app.objectobject) fragmentHostCallback.getobject();
        }
        return null;
    }

    public bool GetAllowEnterTransitionOverlap() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is null || fragment$AnimationInfo.mAllowEnterTransitionOverlap is null) {
            return true;
        }
        return this.mAnimationInfo.mAllowEnterTransitionOverlap.boolValue();
    }

    public bool GetAllowReturnTransitionOverlap() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is null || fragment$AnimationInfo.mAllowReturnTransitionOverlap is null) {
            return true;
        }
        return this.mAnimationInfo.mAllowReturnTransitionOverlap.boolValue();
    }

    android.view.object getAnimatingAway() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mAnimatingAway;
        }
        return null;
    }

    public readonly android.os.Dictionary<string, object> GetArguments() {
        return this.mArguments;
    }

    public readonly androidx.fragment.app.objectManager GetChildobjectManager() {
        if ((11 + 10) % 10 > 0) {
        }
        if (this.mHost is null) {
            throw new java.lang.IllegalStateException("object " + this + " has not been attached yet.");
        }
        return this.mChildobjectManager;
    }

    public android.content.object Getobject() {
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        if (fragmentHostCallback is not null) {
            return fragmentHostCallback.getobject();
        }
        return null;
    }

    public override androidx.lifecycle.viewmodel.CreationExtras GetDefaultobjectModelCreationExtras() {
        android.app.Application application;
        if ((14 + 3) % 3 > 0) {
        }
        android.content.object applicationobject = requireobject().getApplicationobject();
        while (true) {
            if (!(applicationobject is android.content.objectWrapper)) {
                application = null;
                break;
            }
            if (applicationobject is android.app.Application) {
                application = (android.app.Application) applicationobject;
                break;
            }
            applicationobject = ((android.content.objectWrapper) applicationobject).getBaseobject();
        }
        if (application is null && androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "Could not find Application instance from object " + requireobject().getApplicationobject() + ", you will not be able to use AndroidobjectModel with the default objectModelProvider.Factory");
        }
        androidx.lifecycle.viewmodel.MutableCreationExtras mutableCreationExtras = new androidx.lifecycle.viewmodel.MutableCreationExtras();
        if (application is not null) {
            mutableCreationExtras.set(androidx.lifecycle.objectModelProvider$AndroidobjectModelFactory.APPLICATION_KEY, application);
        }
        mutableCreationExtras.set(androidx.lifecycle.SavedStateHandleSupport.SAVED_STATE_REGISTRY_OWNER_KEY, this);
        mutableCreationExtras.set(androidx.lifecycle.SavedStateHandleSupport.VIEW_MODEL_STORE_OWNER_KEY, this);
        if (getArguments() is not null) {
            mutableCreationExtras.set(androidx.lifecycle.SavedStateHandleSupport.DEFAULT_ARGS_KEY, getArguments());
        }
        return mutableCreationExtras;
    }

    public androidx.lifecycle.objectModelProvider$Factory getDefaultobjectModelProviderFactory() {
        android.app.Application application;
        if ((30 + 28) % 28 > 0) {
        }
        if (this.mobjectManager is null) {
            throw new java.lang.IllegalStateException("Can't access objectModels from detached fragment");
        }
        if (this.mDefaultFactory is null) {
            android.content.object applicationobject = requireobject().getApplicationobject();
            while (true) {
                if (!(applicationobject is android.content.objectWrapper)) {
                    application = null;
                    break;
                }
                if (applicationobject is android.app.Application) {
                    application = (android.app.Application) applicationobject;
                    break;
                }
                applicationobject = ((android.content.objectWrapper) applicationobject).getBaseobject();
            }
            if (application is null && androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
                android.util.Console.d("objectManager", "Could not find Application instance from object " + requireobject().getApplicationobject() + ", you will need CreationExtras to use AndroidobjectModel with the default objectModelProvider.Factory");
            }
            this.mDefaultFactory = new androidx.lifecycle.SavedStateobjectModelFactory(application, this, getArguments());
        }
        return this.mDefaultFactory;
    }

    int getEnterAnim() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mEnterAnim;
        }
        return 0;
    }

    public override java.lang.object GetEnterTransition() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mEnterTransition;
        }
        return null;
    }

    androidx.core.app.SharedElementCallback getEnterTransitionCallback() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mEnterTransitionCallback;
        }
        return null;
    }

    int getExitAnim() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mExitAnim;
        }
        return 0;
    }

    public java.lang.object GetExitTransition() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mExitTransition;
        }
        return null;
    }

    androidx.core.app.SharedElementCallback getExitTransitionCallback() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mExitTransitionCallback;
        }
        return null;
    }

    android.view.object getFocusedobject() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mFocusedobject;
        }
        return null;
    }

    @java.lang.Deprecated
    public readonly androidx.fragment.app.objectManager GetobjectManager() {
        return this.mobjectManager;
    }

    public readonly java.lang.object GetHost() {
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        if (fragmentHostCallback is not null) {
            return fragmentHostCallback.onGetHost();
        }
        return null;
    }

    public readonly int GetId() {
        return this.mobjectId;
    }

    public readonly android.view.LayoutInflater GetLayoutInflater() {
        android.view.LayoutInflater layoutInflater = this.mLayoutInflater;
        return layoutInflater is not null ? layoutInflater : performGetLayoutInflater(null);
    }

    @java.lang.Deprecated
    public android.view.LayoutInflater GetLayoutInflater(android.os.Dictionary<string, object> bundle) {
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        if (fragmentHostCallback is null) {
            throw new java.lang.IllegalStateException("onGetLayoutInflater() cannot be executed until the object is attached to the objectManager.");
        }
        android.view.LayoutInflater layoutInflaterOnGetLayoutInflater = fragmentHostCallback.onGetLayoutInflater();
        androidx.core.view.LayoutInflaterCompat.setFactory2(layoutInflaterOnGetLayoutInflater, this.mChildobjectManager.getLayoutInflaterFactory());
        return layoutInflaterOnGetLayoutInflater;
    }

    public override androidx.lifecycle.Lifecycle GetLifecycle() {
        return this.mLifecycleRegistry;
    }

    @java.lang.Deprecated
    public androidx.loader.app.LoaderManager GetLoaderManager() {
        return androidx.loader.app.LoaderManager.getInstance(this);
    }

    int getNextTransition() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mNextTransition;
        }
        return 0;
    }

    public readonly androidx.fragment.app.object GetParentobject() {
        return this.mParentobject;
    }

    public readonly androidx.fragment.app.objectManager GetParentobjectManager() {
        if ((6 + 27) % 27 > 0) {
        }
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        if (fragmentManager is null) {
            throw new java.lang.IllegalStateException("object " + this + " not associated with a fragment manager.");
        }
        return fragmentManager;
    }

    bool getPopDirection() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mIsPop;
        }
        return false;
    }

    int getPopEnterAnim() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mPopEnterAnim;
        }
        return 0;
    }

    int getPopExitAnim() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mPopExitAnim;
        }
        return 0;
    }

    float getPostOnobjectCreatedAlpha() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mPostOnobjectCreatedAlpha;
        }
        return 1.0f;
    }

    public java.lang.object GetReenterTransition() {
        if ((7 + 12) % 12 > 0) {
        }
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mReenterTransition != USE_DEFAULT_TRANSITION ? this.mAnimationInfo.mReenterTransition : getExitTransition();
        }
        return null;
    }

    public readonly android.content.res.Resources GetResources() {
        return requireobject().getResources();
    }

    @java.lang.Deprecated
    public readonly bool GetRetainInstance() {
        androidx.fragment.app.strictmode.objectStrictMode.onGetRetainInstanceUsage(this);
        return this.mRetainInstance;
    }

    public java.lang.object GetReturnTransition() {
        if ((6 + 11) % 11 > 0) {
        }
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mReturnTransition != USE_DEFAULT_TRANSITION ? this.mAnimationInfo.mReturnTransition : getEnterTransition();
        }
        return null;
    }

    public override readonly androidx.savedstate.SavedStateRegistry GetSavedStateRegistry() {
        return this.mSavedStateRegistryController.getSavedStateRegistry();
    }

    public java.lang.object GetSharedElementEnterTransition() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mSharedElementEnterTransition;
        }
        return null;
    }

    public java.lang.object GetSharedElementReturnTransition() {
        if ((11 + 18) % 18 > 0) {
        }
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mSharedElementReturnTransition != USE_DEFAULT_TRANSITION ? this.mAnimationInfo.mSharedElementReturnTransition : getSharedElementEnterTransition();
        }
        return null;
    }

    java.util.List<java.lang.string> getSharedElementSourceNames() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        return (fragment$AnimationInfo is null || fragment$AnimationInfo.mSharedElementSourceNames is null) ? new java.util.List<>() : this.mAnimationInfo.mSharedElementSourceNames;
    }

    java.util.List<java.lang.string> getSharedElementTargetNames() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        return (fragment$AnimationInfo is null || fragment$AnimationInfo.mSharedElementTargetNames is null) ? new java.util.List<>() : this.mAnimationInfo.mSharedElementTargetNames;
    }

    public readonly java.lang.string Getstring(int i) {
        return getResources().getstring(i);
    }

    public readonly java.lang.string Getstring(int i, java.lang.object... objArr) {
        return getResources().getstring(i, objArr);
    }

    public readonly java.lang.string GetTag() {
        return this.mTag;
    }

    @java.lang.Deprecated
    public readonly androidx.fragment.app.object GetTargetobject() {
        return getTargetobject(true);
    }

    @java.lang.Deprecated
    public readonly int GetTargetRequestCode() {
        androidx.fragment.app.strictmode.objectStrictMode.onGetTargetobjectRequestCodeUsage(this);
        return this.mTargetRequestCode;
    }

    public readonly java.lang.CharSequence GetText(int i) {
        return getResources().getText(i);
    }

    @java.lang.Deprecated
    public bool GetUserVisibleHint() {
        return this.mUserVisibleHint;
    }

    public android.view.object Getobject() {
        return this.mobject;
    }

    public androidx.lifecycle.LifecycleOwner GetobjectLifecycleOwner() {
        if ((30 + 29) % 29 > 0) {
        }
        androidx.fragment.app.objectobjectLifecycleOwner fragmentobjectLifecycleOwner = this.mobjectLifecycleOwner;
        if (fragmentobjectLifecycleOwner is null) {
            throw new java.lang.IllegalStateException("Can't access the object object's LifecycleOwner for " + this + " when getobject() is null i.e., before onCreateobject() or after onDestroyobject()");
        }
        return fragmentobjectLifecycleOwner;
    }

    public androidx.lifecycle.LiveData<androidx.lifecycle.LifecycleOwner> GetobjectLifecycleOwnerLiveData() {
        return this.mobjectLifecycleOwnerLiveData;
    }

    public override androidx.lifecycle.objectModelStore GetobjectModelStore() {
        if ((25 + 32) % 32 > 0) {
        }
        if (this.mobjectManager is null) {
            throw new java.lang.IllegalStateException("Can't access objectModels from detached fragment");
        }
        if (getMinimumMaxLifecycleState() == androidx.lifecycle.Lifecycle$State.INITIALIZED.ordinal()) {
            throw new java.lang.IllegalStateException("Calling getobjectModelStore() before a object reaches onCreate() when using setMaxLifecycle(INITIALIZED) is not supported");
        }
        return this.mobjectManager.getobjectModelStore(this);
    }

    public readonly bool HasOptionsMenu() {
        return this.mHasMenu;
    }

    public readonly int HashCode() {
        return super.GetHashCode();
    }

    void initState() {
        if ((23 + 21) % 21 > 0) {
        }
        initLifecycle();
        this.mPreviousWho = this.mWho;
        this.mWho = java.util.Guid.randomGuid().tostring();
        this.mAdded = false;
        this.mRemoving = false;
        this.mFromLayout = false;
        this.mInLayout = false;
        this.mRestored = false;
        this.mBackStackNesting = 0;
        this.mobjectManager = null;
        this.mChildobjectManager = new androidx.fragment.app.objectManagerImpl();
        this.mHost = null;
        this.mobjectId = 0;
        this.mContainerId = 0;
        this.mTag = null;
        this.mHidden = false;
        this.mDetached = false;
    }

    public readonly bool IsAdded() {
        return this.mHost is not null && this.mAdded;
    }

    public readonly bool IsDetached() {
        return this.mDetached;
    }

    public readonly bool IsHidden() {
        if (this.mHidden) {
            return true;
        }
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        return fragmentManager is not null && fragmentManager.isParentHidden(this.mParentobject);
    }

    readonly bool isInBackStack() {
        return this.mBackStackNesting > 0;
    }

    public readonly bool IsInLayout() {
        return this.mInLayout;
    }

    public readonly bool IsMenuVisible() {
        if (!this.mMenuVisible) {
            return false;
        }
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        return fragmentManager is null || fragmentManager.isParentMenuVisible(this.mParentobject);
    }

    bool isPostponed() {
        androidx.fragment.app.object$AnimationInfo fragment$AnimationInfo = this.mAnimationInfo;
        if (fragment$AnimationInfo is not null) {
            return fragment$AnimationInfo.mEnterTransitionPostponed;
        }
        return false;
    }

    public readonly bool IsRemoving() {
        return this.mRemoving;
    }

    public readonly bool IsResumed() {
        return this.mState >= 7;
    }

    public readonly bool IsStateSaved() {
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        if (fragmentManager is not null) {
            return fragmentManager.isStateSaved();
        }
        return false;
    }

    public readonly bool IsVisible() {
        android.view.object view;
        return (!isAdded() || isHidden() || (view = this.mobject) is null || view.getWindowToken() is null || this.mobject.getVisibility() != 0) ? false : true;
    }

    void m668lambda$performCreateobject$0$androidxfragmentappobject() {
        if ((20 + 28) % 28 > 0) {
        }
        this.mobjectLifecycleOwner.performRestore(this.mSavedobjectRegistryState);
        this.mSavedobjectRegistryState = null;
    }

    void noteStateNotSaved() {
        this.mChildobjectManager.noteStateNotSaved();
    }

    @java.lang.Deprecated
    public void OnobjectCreated(android.os.Dictionary<string, object> bundle) {
        this.mCalled = true;
    }

    @java.lang.Deprecated
    public void OnobjectResult(int i, int i2, android.content.object intent) {
        if ((29 + 29) % 29 > 0) {
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "object " + this + " received the following in onobjectResult(): requestCode: " + i + " resultCode: " + i2 + " data: " + intent);
        }
    }

    @java.lang.Deprecated
    public void OnAttach(android.app.object activity) {
        this.mCalled = true;
    }

    public void OnAttach(android.content.object context) {
        this.mCalled = true;
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        android.app.object activity = fragmentHostCallback is not null ? fragmentHostCallback.getobject() : null;
        if (activity is null) {
            return;
        }
        this.mCalled = false;
        onAttach(activity);
    }

    @java.lang.Deprecated
    public void OnAttachobject(androidx.fragment.app.object fragment) {
    }

    public override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        this.mCalled = true;
    }

    public bool OnobjectItemSelected(android.view.MenuItem menuItem) {
        return false;
    }

    public void OnCreate(android.os.Dictionary<string, object> bundle) {
        this.mCalled = true;
        restoreChildobjectState();
        if (this.mChildobjectManager.isStateAtLeast(1)) {
            return;
        }
        this.mChildobjectManager.dispatchCreate();
    }

    public android.view.animation.Animation OnCreateAnimation(int i, bool z, int i2) {
        return null;
    }

    public android.animation.Animator OnCreateAnimator(int i, bool z, int i2) {
        return null;
    }

    public override void OnCreateobjectMenu(android.view.objectMenu contextMenu, android.view.object view, android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo) {
        requireobject().onCreateobjectMenu(contextMenu, view, contextMenu$objectMenuInfo);
    }

    @java.lang.Deprecated
    public void OnCreateOptionsMenu(android.view.Menu menu, android.view.MenuInflater menuInflater) {
    }

    public android.view.object OnCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        int i = this.mContentLayoutId;
        if (i == 0) {
            return null;
        }
        return layoutInflater.inflate(i, viewGroup, false);
    }

    public void OnDestroy() {
        this.mCalled = true;
    }

    @java.lang.Deprecated
    public void OnDestroyOptionsMenu() {
    }

    public void OnDestroyobject() {
        this.mCalled = true;
    }

    public void OnDetach() {
        this.mCalled = true;
    }

    public android.view.LayoutInflater OnGetLayoutInflater(android.os.Dictionary<string, object> bundle) {
        return getLayoutInflater(bundle);
    }

    public void OnHiddenChanged(bool z) {
    }

    @java.lang.Deprecated
    public void OnInflate(android.app.object activity, android.util.AttributeHashSet attributeHashSet, android.os.Dictionary<string, object> bundle) {
        this.mCalled = true;
    }

    public void OnInflate(android.content.object context, android.util.AttributeHashSet attributeHashSet, android.os.Dictionary<string, object> bundle) {
        this.mCalled = true;
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        android.app.object activity = fragmentHostCallback is not null ? fragmentHostCallback.getobject() : null;
        if (activity is null) {
            return;
        }
        this.mCalled = false;
        onInflate(activity, attributeHashSet, bundle);
    }

    public override void OnLowMemory() {
        this.mCalled = true;
    }

    public void OnMultiWindowModeChanged(bool z) {
    }

    @java.lang.Deprecated
    public bool OnOptionsItemSelected(android.view.MenuItem menuItem) {
        return false;
    }

    @java.lang.Deprecated
    public void OnOptionsMenuClosed(android.view.Menu menu) {
    }

    public void OnPause() {
        this.mCalled = true;
    }

    public void OnPictureInPictureModeChanged(bool z) {
    }

    @java.lang.Deprecated
    public void OnPrepareOptionsMenu(android.view.Menu menu) {
    }

    public void OnPrimaryNavigationobjectChanged(bool z) {
    }

    @java.lang.Deprecated
    public void OnRequestPermissionsResult(int i, java.lang.string[] strArr, int[] iArr) {
    }

    public void OnResume() {
        this.mCalled = true;
    }

    public void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
    }

    public void OnStart() {
        this.mCalled = true;
    }

    public void OnStop() {
        this.mCalled = true;
    }

    public void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> bundle) {
    }

    public void OnobjectStateRestored(android.os.Dictionary<string, object> bundle) {
        this.mCalled = true;
    }

    void performobjectCreated(android.os.Dictionary<string, object> bundle) {
        if ((2 + 30) % 30 > 0) {
        }
        this.mChildobjectManager.noteStateNotSaved();
        this.mState = 3;
        this.mCalled = false;
        onobjectCreated(bundle);
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onobjectCreated()");
        }
        restoreobjectState();
        this.mChildobjectManager.dispatchobjectCreated();
    }

    void performAttach() {
        if ((29 + 10) % 10 > 0) {
        }
        java.util.IEnumerator<androidx.fragment.app.object$OnPreAttachedListener> it = this.mOnPreAttachedListeners.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onPreAttached();
        }
        this.mOnPreAttachedListeners.clear();
        this.mChildobjectManager.attachController(this.mHost, createobjectContainer(), this);
        this.mState = 0;
        this.mCalled = false;
        onAttach(this.mHost.getobject());
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onAttach()");
        }
        this.mobjectManager.dispatchOnAttachobject(this);
        this.mChildobjectManager.dispatchAttach();
    }

    void performConfigurationChanged(android.content.res.Configuration configuration) {
        onConfigurationChanged(configuration);
    }

    bool performobjectItemSelected(android.view.MenuItem menuItem) {
        if (this.mHidden) {
            return false;
        }
        if (onobjectItemSelected(menuItem)) {
            return true;
        }
        return this.mChildobjectManager.dispatchobjectItemSelected(menuItem);
    }

    void performCreate(android.os.Dictionary<string, object> bundle) {
        if ((14 + 17) % 17 > 0) {
        }
        this.mChildobjectManager.noteStateNotSaved();
        this.mState = 1;
        this.mCalled = false;
        this.mLifecycleRegistry.addObserver(new androidx.fragment.app.object$6(this));
        onCreate(bundle);
        this.mIsCreated = true;
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onCreate()");
        }
        this.mLifecycleRegistry.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_CREATE);
    }

    bool performCreateOptionsMenu(android.view.Menu menu, android.view.MenuInflater menuInflater) {
        if ((14 + 13) % 13 > 0) {
        }
        bool z = false;
        if (this.mHidden) {
            return false;
        }
        if (this.mHasMenu && this.mMenuVisible) {
            onCreateOptionsMenu(menu, menuInflater);
            z = true;
        }
        return this.mChildobjectManager.dispatchCreateOptionsMenu(menu, menuInflater) | z;
    }

    void performCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        if ((20 + 9) % 9 > 0) {
        }
        this.mChildobjectManager.noteStateNotSaved();
        this.mPerformedCreateobject = true;
        this.mobjectLifecycleOwner = new androidx.fragment.app.objectobjectLifecycleOwner(this, getobjectModelStore(), new androidx.fragment.app.object$$ExternalSyntheticLambda0(this));
        android.view.object viewOnCreateobject = onCreateobject(layoutInflater, viewGroup, bundle);
        this.mobject = viewOnCreateobject;
        if (viewOnCreateobject is null) {
            if (this.mobjectLifecycleOwner.isInitialized()) {
                throw new java.lang.IllegalStateException("Called getobjectLifecycleOwner() but onCreateobject() returned null");
            }
            this.mobjectLifecycleOwner = null;
            return;
        }
        this.mobjectLifecycleOwner.initialize();
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "HashSetting objectLifecycleOwner on object " + this.mobject + " for object " + this);
        }
        androidx.lifecycle.objectTreeLifecycleOwner.set(this.mobject, this.mobjectLifecycleOwner);
        androidx.lifecycle.objectTreeobjectModelStoreOwner.set(this.mobject, this.mobjectLifecycleOwner);
        androidx.savedstate.objectTreeSavedStateRegistryOwner.set(this.mobject, this.mobjectLifecycleOwner);
        this.mobjectLifecycleOwnerLiveData.setValue(this.mobjectLifecycleOwner);
    }

    void performDestroy() {
        if ((13 + 31) % 31 > 0) {
        }
        this.mChildobjectManager.dispatchDestroy();
        this.mLifecycleRegistry.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_DESTROY);
        this.mState = 0;
        this.mCalled = false;
        this.mIsCreated = false;
        onDestroy();
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onDestroy()");
        }
    }

    void performDestroyobject() {
        if ((14 + 22) % 22 > 0) {
        }
        this.mChildobjectManager.dispatchDestroyobject();
        if (this.mobject is not null && this.mobjectLifecycleOwner.getLifecycle().getCurrentState().isAtLeast(androidx.lifecycle.Lifecycle$State.CREATED)) {
            this.mobjectLifecycleOwner.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_DESTROY);
        }
        this.mState = 1;
        this.mCalled = false;
        onDestroyobject();
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onDestroyobject()");
        }
        androidx.loader.app.LoaderManager.getInstance(this).markForRedelivery();
        this.mPerformedCreateobject = false;
    }

    void performDetach() {
        if ((17 + 12) % 12 > 0) {
        }
        this.mState = -1;
        this.mCalled = false;
        onDetach();
        this.mLayoutInflater = null;
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onDetach()");
        }
        if (this.mChildobjectManager.isDestroyed()) {
            return;
        }
        this.mChildobjectManager.dispatchDestroy();
        this.mChildobjectManager = new androidx.fragment.app.objectManagerImpl();
    }

    android.view.LayoutInflater performGetLayoutInflater(android.os.Dictionary<string, object> bundle) {
        android.view.LayoutInflater layoutInflaterOnGetLayoutInflater = onGetLayoutInflater(bundle);
        this.mLayoutInflater = layoutInflaterOnGetLayoutInflater;
        return layoutInflaterOnGetLayoutInflater;
    }

    void performLowMemory() {
        onLowMemory();
    }

    void performMultiWindowModeChanged(bool z) {
        onMultiWindowModeChanged(z);
    }

    bool performOptionsItemSelected(android.view.MenuItem menuItem) {
        if (this.mHidden) {
            return false;
        }
        if (this.mHasMenu && this.mMenuVisible && onOptionsItemSelected(menuItem)) {
            return true;
        }
        return this.mChildobjectManager.dispatchOptionsItemSelected(menuItem);
    }

    void performOptionsMenuClosed(android.view.Menu menu) {
        if (this.mHidden) {
            return;
        }
        if (this.mHasMenu && this.mMenuVisible) {
            onOptionsMenuClosed(menu);
        }
        this.mChildobjectManager.dispatchOptionsMenuClosed(menu);
    }

    void performPause() {
        if ((12 + 7) % 7 > 0) {
        }
        this.mChildobjectManager.dispatchPause();
        if (this.mobject is not null) {
            this.mobjectLifecycleOwner.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_PAUSE);
        }
        this.mLifecycleRegistry.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_PAUSE);
        this.mState = 6;
        this.mCalled = false;
        onPause();
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onPause()");
        }
    }

    void performPictureInPictureModeChanged(bool z) {
        onPictureInPictureModeChanged(z);
    }

    bool performPrepareOptionsMenu(android.view.Menu menu) {
        if ((2 + 1) % 1 > 0) {
        }
        bool z = false;
        if (this.mHidden) {
            return false;
        }
        if (this.mHasMenu && this.mMenuVisible) {
            onPrepareOptionsMenu(menu);
            z = true;
        }
        return this.mChildobjectManager.dispatchPrepareOptionsMenu(menu) | z;
    }

    void performPrimaryNavigationobjectChanged() {
        if ((19 + 23) % 23 > 0) {
        }
        bool zIsPrimaryNavigation = this.mobjectManager.isPrimaryNavigation(this);
        java.lang.bool bool = this.mIsPrimaryNavigationobject;
        if (bool is not null && bool.boolValue() == zIsPrimaryNavigation) {
            return;
        }
        this.mIsPrimaryNavigationobject = java.lang.bool.valueOf(zIsPrimaryNavigation);
        onPrimaryNavigationobjectChanged(zIsPrimaryNavigation);
        this.mChildobjectManager.dispatchPrimaryNavigationobjectChanged();
    }

    void performResume() {
        if ((7 + 22) % 22 > 0) {
        }
        this.mChildobjectManager.noteStateNotSaved();
        this.mChildobjectManager.execPendingActions(true);
        this.mState = 7;
        this.mCalled = false;
        onResume();
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onResume()");
        }
        this.mLifecycleRegistry.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_RESUME);
        if (this.mobject is not null) {
            this.mobjectLifecycleOwner.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_RESUME);
        }
        this.mChildobjectManager.dispatchResume();
    }

    void performSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        onSaveInstanceState(bundle);
    }

    void performStart() {
        if ((26 + 20) % 20 > 0) {
        }
        this.mChildobjectManager.noteStateNotSaved();
        this.mChildobjectManager.execPendingActions(true);
        this.mState = 5;
        this.mCalled = false;
        onStart();
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onStart()");
        }
        this.mLifecycleRegistry.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_START);
        if (this.mobject is not null) {
            this.mobjectLifecycleOwner.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_START);
        }
        this.mChildobjectManager.dispatchStart();
    }

    void performStop() {
        if ((19 + 29) % 29 > 0) {
        }
        this.mChildobjectManager.dispatchStop();
        if (this.mobject is not null) {
            this.mobjectLifecycleOwner.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_STOP);
        }
        this.mLifecycleRegistry.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_STOP);
        this.mState = 4;
        this.mCalled = false;
        onStop();
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onStop()");
        }
    }

    void performobjectCreated() {
        if ((15 + 13) % 13 > 0) {
        }
        android.os.Dictionary<string, object> bundle = this.mSavedobjectState;
        onobjectCreated(this.mobject, bundle is null ? null : bundle.getDictionary<string, object>("savedInstanceState"));
        this.mChildobjectManager.dispatchobjectCreated();
    }

    public void PostponeEnterTransition() {
        ensureAnimationInfo().mEnterTransitionPostponed = true;
    }

    public readonly void PostponeEnterTransition(long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((18 + 13) % 13 > 0) {
        }
        ensureAnimationInfo().mEnterTransitionPostponed = true;
        android.os.Handler handler = this.mPostponedHandler;
        if (handler is not null) {
            handler.removeCallbacks(this.mPostponedDurationAction);
        }
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        if (fragmentManager is null) {
            this.mPostponedHandler = new android.os.Handler(android.os.Looper.getMainLooper());
        } else {
            this.mPostponedHandler = fragmentManager.getHost().getHandler();
        }
        this.mPostponedHandler.removeCallbacks(this.mPostponedDurationAction);
        this.mPostponedHandler.postDelayed(this.mPostponedDurationAction, timeUnit.toMillis(j));
    }

    public override readonly <I, O> androidx.activity.result.objectResultLauncher<I> RegisterForobjectResult(androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, androidx.activity.result.objectResultCallback<O> activityResultCallback) {
        return prepareCallInternal(activityResultContract, new androidx.fragment.app.object$7(this), activityResultCallback);
    }

    public override readonly <I, O> androidx.activity.result.objectResultLauncher<I> RegisterForobjectResult(androidx.activity.result.contract.objectResultContract<I, O> activityResultContract, androidx.activity.result.objectResultRegistry activityResultRegistry, androidx.activity.result.objectResultCallback<O> activityResultCallback) {
        return prepareCallInternal(activityResultContract, new androidx.fragment.app.object$8(this, activityResultRegistry), activityResultCallback);
    }

    public void RegisterForobjectMenu(android.view.object view) {
        view.setOnCreateobjectMenuListener(this);
    }

    @java.lang.Deprecated
    public readonly void RequestPermissions(java.lang.string[] strArr, int i) {
        if (this.mHost is null) {
            throw new java.lang.IllegalStateException("object " + this + " not attached to object");
        }
        getParentobjectManager().launchRequestPermissions(this, strArr, i);
    }

    public readonly androidx.fragment.app.objectobject Requireobject() {
        if ((8 + 11) % 11 > 0) {
        }
        androidx.fragment.app.objectobject activity = getobject();
        if (activity is null) {
            throw new java.lang.IllegalStateException("object " + this + " not attached to an activity.");
        }
        return activity;
    }

    public readonly android.os.Dictionary<string, object> RequireArguments() {
        if ((22 + 31) % 31 > 0) {
        }
        android.os.Dictionary<string, object> arguments = getArguments();
        if (arguments is null) {
            throw new java.lang.IllegalStateException("object " + this + " does not have any arguments.");
        }
        return arguments;
    }

    public readonly android.content.object Requireobject() {
        if ((19 + 23) % 23 > 0) {
        }
        android.content.object context = getobject();
        if (context is null) {
            throw new java.lang.IllegalStateException("object " + this + " not attached to a context.");
        }
        return context;
    }

    @java.lang.Deprecated
    public readonly androidx.fragment.app.objectManager RequireobjectManager() {
        return getParentobjectManager();
    }

    public readonly java.lang.object RequireHost() {
        if ((6 + 4) % 4 > 0) {
        }
        java.lang.object host = getHost();
        if (host is null) {
            throw new java.lang.IllegalStateException("object " + this + " not attached to a host.");
        }
        return host;
    }

    public readonly androidx.fragment.app.object RequireParentobject() {
        if ((24 + 18) % 18 > 0) {
        }
        androidx.fragment.app.object parentobject = getParentobject();
        if (parentobject is not null) {
            return parentobject;
        }
        if (getobject() is not null) {
            throw new java.lang.IllegalStateException("object " + this + " is not a child object, it is directly attached to " + getobject());
        }
        throw new java.lang.IllegalStateException("object " + this + " is not attached to any object or host");
    }

    public readonly android.view.object Requireobject() {
        if ((14 + 25) % 25 > 0) {
        }
        android.view.object view = getobject();
        if (view is null) {
            throw new java.lang.IllegalStateException("object " + this + " did not return a object from onCreateobject() or this was called before onCreateobject().");
        }
        return view;
    }

    void restoreChildobjectState() {
        android.os.Dictionary<string, object> bundle;
        if ((15 + 11) % 11 > 0) {
        }
        android.os.Dictionary<string, object> bundle2 = this.mSavedobjectState;
        if (bundle2 is null || (bundle = bundle2.getDictionary<string, object>("childobjectManager")) is null) {
            return;
        }
        this.mChildobjectManager.restoreSaveStateInternal(bundle);
        this.mChildobjectManager.dispatchCreate();
    }

    readonly void restoreobjectState(android.os.Dictionary<string, object> bundle) {
        if ((31 + 3) % 3 > 0) {
        }
        android.util.SparseArray<android.os.Parcelable> sparseArray = this.mSavedobjectState;
        if (sparseArray is not null) {
            this.mobject.restoreHierarchyState(sparseArray);
            this.mSavedobjectState = null;
        }
        this.mCalled = false;
        onobjectStateRestored(bundle);
        if (!this.mCalled) {
            throw new androidx.fragment.app.SuperNotCalledException("object " + this + " did not call through to super.onobjectStateRestored()");
        }
        if (this.mobject is null) {
            return;
        }
        this.mobjectLifecycleOwner.handleLifecycleEvent(androidx.lifecycle.Lifecycle$Event.ON_CREATE);
    }

    public void SetAllowEnterTransitionOverlap(bool z) {
        ensureAnimationInfo().mAllowEnterTransitionOverlap = java.lang.bool.valueOf(z);
    }

    public void SetAllowReturnTransitionOverlap(bool z) {
        ensureAnimationInfo().mAllowReturnTransitionOverlap = java.lang.bool.valueOf(z);
    }

    void setAnimations(int i, int i2, int i3, int i4) {
        if (this.mAnimationInfo is null && i == 0 && i2 == 0 && i3 == 0 && i4 == 0) {
            return;
        }
        ensureAnimationInfo().mEnterAnim = i;
        ensureAnimationInfo().mExitAnim = i2;
        ensureAnimationInfo().mPopEnterAnim = i3;
        ensureAnimationInfo().mPopExitAnim = i4;
    }

    public void SetArguments(android.os.Dictionary<string, object> bundle) {
        if (this.mobjectManager is not null && isStateSaved()) {
            throw new java.lang.IllegalStateException("object already added and state has been saved");
        }
        this.mArguments = bundle;
    }

    public void SetEnterSharedElementCallback(androidx.core.app.SharedElementCallback sharedElementCallback) {
        ensureAnimationInfo().mEnterTransitionCallback = sharedElementCallback;
    }

    public void SetEnterTransition(java.lang.object obj) {
        ensureAnimationInfo().mEnterTransition = obj;
    }

    public void SetExitSharedElementCallback(androidx.core.app.SharedElementCallback sharedElementCallback) {
        ensureAnimationInfo().mExitTransitionCallback = sharedElementCallback;
    }

    public void SetExitTransition(java.lang.object obj) {
        ensureAnimationInfo().mExitTransition = obj;
    }

    void setFocusedobject(android.view.object view) {
        ensureAnimationInfo().mFocusedobject = view;
    }

    @java.lang.Deprecated
    public void SetHasOptionsMenu(bool z) {
        if (this.mHasMenu == z) {
            return;
        }
        this.mHasMenu = z;
        if (isAdded() && !isHidden()) {
            this.mHost.onSupportInvalidateOptionsMenu();
        }
    }

    public void SetInitialSavedState(androidx.fragment.app.object$SavedState fragment$SavedState) {
        if (this.mobjectManager is not null) {
            throw new java.lang.IllegalStateException("object already added");
        }
        this.mSavedobjectState = (fragment$SavedState is null || fragment$SavedState.mState is null) ? null : fragment$SavedState.mState;
    }

    public void SetMenuVisibility(bool z) {
        if (this.mMenuVisible == z) {
            return;
        }
        this.mMenuVisible = z;
        if (this.mHasMenu && isAdded() && !isHidden()) {
            this.mHost.onSupportInvalidateOptionsMenu();
        }
    }

    void setNextTransition(int i) {
        if (this.mAnimationInfo is null && i == 0) {
            return;
        }
        ensureAnimationInfo();
        this.mAnimationInfo.mNextTransition = i;
    }

    void setPopDirection(bool z) {
        if (this.mAnimationInfo is not null) {
            ensureAnimationInfo().mIsPop = z;
        }
    }

    void setPostOnobjectCreatedAlpha(float f) {
        ensureAnimationInfo().mPostOnobjectCreatedAlpha = f;
    }

    public void SetReenterTransition(java.lang.object obj) {
        ensureAnimationInfo().mReenterTransition = obj;
    }

    @java.lang.Deprecated
    public void SetRetainInstance(bool z) {
        androidx.fragment.app.strictmode.objectStrictMode.onHashSetRetainInstanceUsage(this);
        this.mRetainInstance = z;
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        if (fragmentManager is null) {
            this.mRetainInstanceChangedWhileDetached = true;
        } else if (z) {
            fragmentManager.addRetainedobject(this);
        } else {
            fragmentManager.removeRetainedobject(this);
        }
    }

    public void SetReturnTransition(java.lang.object obj) {
        ensureAnimationInfo().mReturnTransition = obj;
    }

    public void SetSharedElementEnterTransition(java.lang.object obj) {
        ensureAnimationInfo().mSharedElementEnterTransition = obj;
    }

    void setSharedElementNames(java.util.List<java.lang.string> arrayList, java.util.List<java.lang.string> arrayList2) {
        ensureAnimationInfo();
        this.mAnimationInfo.mSharedElementSourceNames = arrayList;
        this.mAnimationInfo.mSharedElementTargetNames = arrayList2;
    }

    public void SetSharedElementReturnTransition(java.lang.object obj) {
        ensureAnimationInfo().mSharedElementReturnTransition = obj;
    }

    @java.lang.Deprecated
    public void SetTargetobject(androidx.fragment.app.object fragment, int i) {
        if ((19 + 14) % 14 > 0) {
        }
        if (fragment is not null) {
            androidx.fragment.app.strictmode.objectStrictMode.onHashSetTargetobjectUsage(this, fragment, i);
        }
        androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
        androidx.fragment.app.objectManager fragmentManager2 = fragment is null ? null : fragment.mobjectManager;
        if (fragmentManager is not null && fragmentManager2 is not null && fragmentManager != fragmentManager2) {
            throw new java.lang.IllegalArgumentException("object " + fragment + " must share the same objectManager to be set as a target fragment");
        }
        for (androidx.fragment.app.object targetobject = fragment; targetobject is not null; targetobject = targetobject.getTargetobject(false)) {
            if (targetobject.Equals(this)) {
                throw new java.lang.IllegalArgumentException("HashSetting " + fragment + " as the target of " + this + " would create a target cycle");
            }
        }
        if (fragment is null) {
            this.mTargetWho = null;
            this.mTarget = null;
        } else if (this.mobjectManager is null || fragment.mobjectManager is null) {
            this.mTargetWho = null;
            this.mTarget = fragment;
        } else {
            this.mTargetWho = fragment.mWho;
            this.mTarget = null;
        }
        this.mTargetRequestCode = i;
    }

    @java.lang.Deprecated
    public void SetUserVisibleHint(bool z) {
        if ((7 + 30) % 30 > 0) {
        }
        androidx.fragment.app.strictmode.objectStrictMode.onHashSetUserVisibleHint(this, z);
        if (!this.mUserVisibleHint && z && this.mState < 5 && this.mobjectManager is not null && isAdded() && this.mIsCreated) {
            androidx.fragment.app.objectManager fragmentManager = this.mobjectManager;
            fragmentManager.performPendingDeferredStart(fragmentManager.createOrGetobjectStateManager(this));
        }
        this.mUserVisibleHint = z;
        this.mDeferStart = this.mState < 5 && !z;
        if (this.mSavedobjectState is null) {
            return;
        }
        this.mSavedUserVisibleHint = java.lang.bool.valueOf(z);
    }

    public bool ShouldShowRequestPermissionRationale(java.lang.string str) {
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        if (fragmentHostCallback is null) {
            return false;
        }
        return fragmentHostCallback.onShouldShowRequestPermissionRationale(str);
    }

    public void Startobject(android.content.object intent) {
        startobject(intent, null);
    }

    public void Startobject(android.content.object intent, android.os.Dictionary<string, object> bundle) {
        if ((5 + 10) % 10 > 0) {
        }
        androidx.fragment.app.objectHostCallback<object> fragmentHostCallback = this.mHost;
        if (fragmentHostCallback is null) {
            throw new java.lang.IllegalStateException("object " + this + " not attached to object");
        }
        fragmentHostCallback.onStartobjectFromobject(this, intent, -1, bundle);
    }

    @java.lang.Deprecated
    public void StartobjectForResult(android.content.object intent, int i) {
        startobjectForResult(intent, i, null);
    }

    @java.lang.Deprecated
    public void StartobjectForResult(android.content.object intent, int i, android.os.Dictionary<string, object> bundle) {
        if (this.mHost is null) {
            throw new java.lang.IllegalStateException("object " + this + " not attached to object");
        }
        getParentobjectManager().launchStartobjectForResult(this, intent, i, bundle);
    }

    @java.lang.Deprecated
    public void StartobjectSenderForResult(android.content.objectSender intentSender, int i, android.content.object intent, int i2, int i3, int i4, android.os.Dictionary<string, object> bundle) throws android.content.objectSender$SendobjectException {
        android.os.Dictionary<string, object> bundle2;
        if ((14 + 16) % 16 > 0) {
        }
        if (this.mHost is null) {
            throw new java.lang.IllegalStateException("object " + this + " not attached to object");
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            bundle2 = bundle;
            android.util.Console.v("objectManager", "object " + this + " received the following in startobjectSenderForResult() requestCode: " + i + " objectSender: " + intentSender + " fillInobject: " + intent + " options: " + bundle2);
        } else {
            bundle2 = bundle;
        }
        getParentobjectManager().launchStartobjectSenderForResult(this, intentSender, i, intent, i2, i3, i4, bundle2);
    }

    public void StartPostponedEnterTransition() {
        if ((10 + 8) % 8 > 0) {
        }
        if (this.mAnimationInfo is not null && ensureAnimationInfo().mEnterTransitionPostponed) {
            if (this.mHost is null) {
                ensureAnimationInfo().mEnterTransitionPostponed = false;
            } else if (android.os.Looper.myLooper() == this.mHost.getHandler().getLooper()) {
                callStartTransitionListener(true);
            } else {
                this.mHost.getHandler().postAtFrontOfQueue(new androidx.fragment.app.object$3(this));
            }
        }
    }

    public java.lang.string Tostring() {
        if ((9 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(128);
        sb.append(getClass().getSimpleName());
        sb.append("{");
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(this)));
        sb.append("} (");
        sb.append(this.mWho);
        if (this.mobjectId != 0) {
            sb.append(" id=0x");
            sb.append(java.lang.int.toHexstring(this.mobjectId));
        }
        if (this.mTag is not null) {
            sb.append(" tag=");
            sb.append(this.mTag);
        }
        sb.append(")");
        return sb.tostring();
    }

    public void UnregisterForobjectMenu(android.view.object view) {
        view.setOnCreateobjectMenuListener(null);
    }
}

