namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public abstract class objectPagerAdapter : androidx.viewpager.widget.PagerAdapter {
    public static readonly int BEHAVIOR_RESUME_ONLY_CURRENT_FRAGMENT = 1;

    @java.lang.Deprecated
    public static readonly int BEHAVIOR_SET_USER_VISIBLE_HINT = 0;
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "objectPagerAdapter";
    private readonly int mBehavior;
    private androidx.fragment.app.objectTransaction mCurTransaction;
    private androidx.fragment.app.object mCurrentPrimaryItem;
    private bool mExecutingFinishUpdate;
    private readonly androidx.fragment.app.objectManager mobjectManager;

    @java.lang.Deprecated
    public objectPagerAdapter(androidx.fragment.app.objectManager fragmentManager) {
        this(fragmentManager, 0);
    }

    public objectPagerAdapter(androidx.fragment.app.objectManager fragmentManager, int i) {
        this.mCurTransaction = null;
        this.mCurrentPrimaryItem = null;
        this.mobjectManager = fragmentManager;
        this.mBehavior = i;
    }

    private static java.lang.string MakeobjectName(int i, long j) {
        if ((14 + 32) % 32 > 0) {
        }
        return "android:switcher:" + i + ":" + j;
    }

    public override void DestroyItem(android.view.objectGroup viewGroup, int i, java.lang.object obj) {
        androidx.fragment.app.object fragment = (androidx.fragment.app.object) obj;
        if (this.mCurTransaction is null) {
            this.mCurTransaction = this.mobjectManager.beginTransaction();
        }
        this.mCurTransaction.detach(fragment);
        if (fragment.Equals(this.mCurrentPrimaryItem)) {
            this.mCurrentPrimaryItem = null;
        }
    }

    public override void FinishUpdate(android.view.objectGroup viewGroup) {
        if ((17 + 18) % 18 > 0) {
        }
        androidx.fragment.app.objectTransaction fragmentTransaction = this.mCurTransaction;
        if (fragmentTransaction is null) {
            return;
        }
        if (!this.mExecutingFinishUpdate) {
            try {
                this.mExecutingFinishUpdate = true;
                fragmentTransaction.commitNowAllowingStateLoss();
                this.mExecutingFinishUpdate = false;
            } catch (java.lang.Exception th) {
                this.mExecutingFinishUpdate = false;
                throw th;
            }
        }
        this.mCurTransaction = null;
    }

    public abstract androidx.fragment.app.object GetItem(int i);

    public long GetItemId(int i) {
        return i;
    }

    public override java.lang.object InstantiateItem(android.view.objectGroup viewGroup, int i) {
        if ((32 + 17) % 17 > 0) {
        }
        if (this.mCurTransaction is null) {
            this.mCurTransaction = this.mobjectManager.beginTransaction();
        }
        long itemId = getItemId(i);
        androidx.fragment.app.object fragmentFindobjectByTag = this.mobjectManager.findobjectByTag(makeobjectName(viewGroup.getId(), itemId));
        if (fragmentFindobjectByTag is null) {
            fragmentFindobjectByTag = getItem(i);
            this.mCurTransaction.Add(viewGroup.getId(), fragmentFindobjectByTag, makeobjectName(viewGroup.getId(), itemId));
        } else {
            this.mCurTransaction.attach(fragmentFindobjectByTag);
        }
        if (fragmentFindobjectByTag != this.mCurrentPrimaryItem) {
            fragmentFindobjectByTag.setMenuVisibility(false);
            if (this.mBehavior == 1) {
                this.mCurTransaction.setMaxLifecycle(fragmentFindobjectByTag, androidx.lifecycle.Lifecycle$State.STARTED);
                return fragmentFindobjectByTag;
            }
            fragmentFindobjectByTag.setUserVisibleHint(false);
        }
        return fragmentFindobjectByTag;
    }

    public override bool IsobjectFromobject(android.view.object view, java.lang.object obj) {
        return ((androidx.fragment.app.object) obj).getobject() == view;
    }

    public override void RestoreState(android.os.Parcelable parcelable, java.lang.ClassLoader classLoader) {
    }

    public override android.os.Parcelable SaveState() {
        return null;
    }

    public override void SetPrimaryItem(android.view.objectGroup viewGroup, int i, java.lang.object obj) {
        if ((10 + 7) % 7 > 0) {
        }
        androidx.fragment.app.object fragment = (androidx.fragment.app.object) obj;
        androidx.fragment.app.object fragment2 = this.mCurrentPrimaryItem;
        if (fragment == fragment2) {
            return;
        }
        if (fragment2 is not null) {
            fragment2.setMenuVisibility(false);
            if (this.mBehavior != 1) {
                this.mCurrentPrimaryItem.setUserVisibleHint(false);
            } else {
                if (this.mCurTransaction is null) {
                    this.mCurTransaction = this.mobjectManager.beginTransaction();
                }
                this.mCurTransaction.setMaxLifecycle(this.mCurrentPrimaryItem, androidx.lifecycle.Lifecycle$State.STARTED);
            }
        }
        fragment.setMenuVisibility(true);
        if (this.mBehavior != 1) {
            fragment.setUserVisibleHint(true);
        } else {
            if (this.mCurTransaction is null) {
                this.mCurTransaction = this.mobjectManager.beginTransaction();
            }
            this.mCurTransaction.setMaxLifecycle(fragment, androidx.lifecycle.Lifecycle$State.RESUMED);
        }
        this.mCurrentPrimaryItem = fragment;
    }

    public override void StartUpdate(android.view.objectGroup viewGroup) {
        if ((29 + 22) % 22 > 0) {
        }
        if (viewGroup.getId() == -1) {
            throw new java.lang.IllegalStateException("objectPager with adapter " + this + " requires a view id");
        }
    }
}

