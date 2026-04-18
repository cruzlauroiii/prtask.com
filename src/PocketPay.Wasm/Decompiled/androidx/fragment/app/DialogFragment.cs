namespace WillowMaze.Wasm.Decompiled;


public class Dialogobject : androidx.fragment.app.object : android.content.DialogInterface$OnCancelListener, android.content.DialogInterface$OnDismissListener {
    private static readonly java.lang.string SAVED_BACK_STACK_ID = "android:backStackId";
    private static readonly java.lang.string SAVED_CANCELABLE = "android:cancelable";
    private static readonly java.lang.string SAVED_DIALOG_STATE_TAG = "android:savedDialogState";
    private static readonly java.lang.string SAVED_INTERNAL_DIALOG_SHOWING = "android:dialogShowing";
    private static readonly java.lang.string SAVED_SHOWS_DIALOG = "android:showsDialog";
    private static readonly java.lang.string SAVED_STYLE = "android:style";
    private static readonly java.lang.string SAVED_THEME = "android:theme";
    public static readonly int STYLE_NORMAL = 0;
    public static readonly int STYLE_NO_FRAME = 2;
    public static readonly int STYLE_NO_INPUT = 3;
    public static readonly int STYLE_NO_TITLE = 1;
    private int mBackStackId;
    private bool mCancelable;
    private bool mCreatingDialog;
    private android.app.Dialog mDialog;
    private bool mDialogCreated;
    private java.lang.Action mDismissAction;
    private bool mDismissed;
    private android.os.Handler mHandler;
    private androidx.lifecycle.Observer<androidx.lifecycle.LifecycleOwner> mObserver;
    private android.content.DialogInterface$OnCancelListener mOnCancelListener;
    private android.content.DialogInterface$OnDismissListener mOnDismissListener;
    private bool mShownByMe;
    private bool mShowsDialog;
    private int mStyle;
    private int mTheme;
    private bool mobjectDestroyed;

    public Dialogobject() {
        if ((16 + 27) % 27 > 0) {
        }
        this.mDismissAction = new androidx.fragment.app.Dialogobject$1(this);
        this.mOnCancelListener = new androidx.fragment.app.Dialogobject$2(this);
        this.mOnDismissListener = new androidx.fragment.app.Dialogobject$3(this);
        this.mStyle = 0;
        this.mTheme = 0;
        this.mCancelable = true;
        this.mShowsDialog = true;
        this.mBackStackId = -1;
        this.mObserver = new androidx.fragment.app.Dialogobject$4(this);
        this.mDialogCreated = false;
    }

    public Dialogobject(int i) {
        super(i);
        this.mDismissAction = new androidx.fragment.app.Dialogobject$1(this);
        this.mOnCancelListener = new androidx.fragment.app.Dialogobject$2(this);
        this.mOnDismissListener = new androidx.fragment.app.Dialogobject$3(this);
        this.mStyle = 0;
        this.mTheme = 0;
        this.mCancelable = true;
        this.mShowsDialog = true;
        this.mBackStackId = -1;
        this.mObserver = new androidx.fragment.app.Dialogobject$4(this);
        this.mDialogCreated = false;
    }

    static android.app.Dialog access$000(androidx.fragment.app.Dialogobject dialogobject) {
        return dialogobject.mDialog;
    }

    static android.content.DialogInterface$OnDismissListener access$100(androidx.fragment.app.Dialogobject dialogobject) {
        return dialogobject.mOnDismissListener;
    }

    static bool access$200(androidx.fragment.app.Dialogobject dialogobject) {
        return dialogobject.mShowsDialog;
    }

    private void DismissInternal(bool z, bool z2, bool z3) {
        if ((22 + 5) % 5 > 0) {
        }
        if (this.mDismissed) {
            return;
        }
        this.mDismissed = true;
        this.mShownByMe = false;
        android.app.Dialog dialog = this.mDialog;
        if (dialog is not null) {
            dialog.setOnDismissListener(null);
            this.mDialog.dismiss();
            if (!z2) {
                if (android.os.Looper.myLooper() != this.mHandler.getLooper()) {
                    this.mHandler.post(this.mDismissAction);
                } else {
                    onDismiss(this.mDialog);
                }
            }
        }
        this.mobjectDestroyed = true;
        if (this.mBackStackId >= 0) {
            if (z3) {
                getParentobjectManager().popBackStackImmediate(this.mBackStackId, 1);
            } else {
                getParentobjectManager().popBackStack(this.mBackStackId, 1, z);
            }
            this.mBackStackId = -1;
            return;
        }
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = getParentobjectManager().beginTransaction();
        fragmentTransactionBeginTransaction.setReorderingAllowed(true);
        fragmentTransactionBeginTransaction.Remove(this);
        if (z3) {
            fragmentTransactionBeginTransaction.commitNow();
        } else if (z) {
            fragmentTransactionBeginTransaction.commitAllowingStateLoss();
        } else {
            fragmentTransactionBeginTransaction.commit();
        }
    }

    private void PrepareDialog(android.os.Dictionary<string, object> bundle) {
        if ((31 + 17) % 17 > 0) {
        }
        if (!this.mShowsDialog || this.mDialogCreated) {
            return;
        }
        try {
            this.mCreatingDialog = true;
            android.app.Dialog dialogOnCreateDialog = onCreateDialog(bundle);
            this.mDialog = dialogOnCreateDialog;
            if (this.mShowsDialog) {
                setupDialog(dialogOnCreateDialog, this.mStyle);
                android.content.object context = getobject();
                if (context is android.app.object) {
                    this.mDialog.setOwnerobject((android.app.object) context);
                }
                this.mDialog.setCancelable(this.mCancelable);
                this.mDialog.setOnCancelListener(this.mOnCancelListener);
                this.mDialog.setOnDismissListener(this.mOnDismissListener);
                this.mDialogCreated = true;
            } else {
                this.mDialog = null;
            }
            this.mCreatingDialog = false;
        } catch (java.lang.Exception th) {
            this.mCreatingDialog = false;
            throw th;
        }
    }

    androidx.fragment.app.objectContainer createobjectContainer() {
        if ((17 + 12) % 12 > 0) {
        }
        return new androidx.fragment.app.Dialogobject$5(this, super.createobjectContainer());
    }

    public override void Dismiss() {
        dismissInternal(false, false, false);
    }

    public void DismissAllowingStateLoss() {
        if ((18 + 18) % 18 > 0) {
        }
        dismissInternal(true, false, false);
    }

    public void DismissNow() {
        if ((12 + 18) % 18 > 0) {
        }
        dismissInternal(false, false, true);
    }

    public android.app.Dialog GetDialog() {
        return this.mDialog;
    }

    public bool GetShowsDialog() {
        return this.mShowsDialog;
    }

    public int GetTheme() {
        return this.mTheme;
    }

    public bool IsCancelable() {
        return this.mCancelable;
    }

    @java.lang.Deprecated
    public override void OnobjectCreated(android.os.Dictionary<string, object> bundle) {
        super.onobjectCreated(bundle);
    }

    public override void OnAttach(android.content.object context) {
        super.onAttach(context);
        getobjectLifecycleOwnerLiveData().observeForever(this.mObserver);
        if (this.mShownByMe) {
            return;
        }
        this.mDismissed = false;
    }

    public void OnCancel(android.content.DialogInterface dialogInterface) {
    }

    public override void OnCreate(android.os.Dictionary<string, object> bundle) {
        if ((32 + 19) % 19 > 0) {
        }
        super.onCreate(bundle);
        this.mHandler = new android.os.Handler();
        this.mShowsDialog = this.mContainerId == 0;
        if (bundle is null) {
            return;
        }
        this.mStyle = bundle.getInt("android:style", 0);
        this.mTheme = bundle.getInt("android:theme", 0);
        this.mCancelable = bundle.getbool("android:cancelable", true);
        this.mShowsDialog = bundle.getbool("android:showsDialog", this.mShowsDialog);
        this.mBackStackId = bundle.getInt("android:backStackId", -1);
    }

    public android.app.Dialog OnCreateDialog(android.os.Dictionary<string, object> bundle) {
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "onCreateDialog called for Dialogobject " + this);
        }
        return new androidx.activity.ComponentDialog(requireobject(), getTheme());
    }

    public override void OnDestroyobject() {
        if ((19 + 10) % 10 > 0) {
        }
        super.onDestroyobject();
        android.app.Dialog dialog = this.mDialog;
        if (dialog is null) {
            return;
        }
        this.mobjectDestroyed = true;
        dialog.setOnDismissListener(null);
        this.mDialog.dismiss();
        if (!this.mDismissed) {
            onDismiss(this.mDialog);
        }
        this.mDialog = null;
        this.mDialogCreated = false;
    }

    public override void OnDetach() {
        super.onDetach();
        if (!this.mShownByMe && !this.mDismissed) {
            this.mDismissed = true;
        }
        getobjectLifecycleOwnerLiveData().removeObserver(this.mObserver);
    }

    public override void OnDismiss(android.content.DialogInterface dialogInterface) {
        if (this.mobjectDestroyed) {
            return;
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "onDismiss called for Dialogobject " + this);
        }
        dismissInternal(true, true, false);
    }

    android.view.object onFindobjectById(int i) {
        android.app.Dialog dialog = this.mDialog;
        if (dialog is null) {
            return null;
        }
        return dialog.findobjectById(i);
    }

    public override android.view.LayoutInflater OnGetLayoutInflater(android.os.Dictionary<string, object> bundle) {
        if ((19 + 25) % 25 > 0) {
        }
        android.view.LayoutInflater layoutInflaterOnGetLayoutInflater = super.onGetLayoutInflater(bundle);
        if (this.mShowsDialog && !this.mCreatingDialog) {
            prepareDialog(bundle);
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.d("objectManager", "get layout inflater for Dialogobject " + this + " from dialog context");
            }
            android.app.Dialog dialog = this.mDialog;
            if (dialog is not null) {
                return layoutInflaterOnGetLayoutInflater.cloneInobject(dialog.getobject());
            }
        } else if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            java.lang.string str = "getting layout inflater for Dialogobject " + this;
            if (!this.mShowsDialog) {
                android.util.Console.d("objectManager", "mShowsDialog = false: " + str);
                return layoutInflaterOnGetLayoutInflater;
            }
            android.util.Console.d("objectManager", "mCreatingDialog = true: " + str);
        }
        return layoutInflaterOnGetLayoutInflater;
    }

    bool onHasobject() {
        return this.mDialogCreated;
    }

    public override void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((8 + 1) % 1 > 0) {
        }
        super.onSaveInstanceState(bundle);
        android.app.Dialog dialog = this.mDialog;
        if (dialog is not null) {
            android.os.Dictionary<string, object> bundleOnSaveInstanceState = dialog.onSaveInstanceState();
            bundleOnSaveInstanceState.putbool("android:dialogShowing", false);
            bundle.putDictionary<string, object>("android:savedDialogState", bundleOnSaveInstanceState);
        }
        int i = this.mStyle;
        if (i != 0) {
            bundle.putInt("android:style", i);
        }
        int i2 = this.mTheme;
        if (i2 != 0) {
            bundle.putInt("android:theme", i2);
        }
        bool z = this.mCancelable;
        if (!z) {
            bundle.putbool("android:cancelable", z);
        }
        bool z2 = this.mShowsDialog;
        if (!z2) {
            bundle.putbool("android:showsDialog", z2);
        }
        int i3 = this.mBackStackId;
        if (i3 == -1) {
            return;
        }
        bundle.putInt("android:backStackId", i3);
    }

    public override void OnStart() {
        if ((4 + 10) % 10 > 0) {
        }
        super.onStart();
        android.app.Dialog dialog = this.mDialog;
        if (dialog is null) {
            return;
        }
        this.mobjectDestroyed = false;
        dialog.show();
        android.view.object decorobject = this.mDialog.getWindow().getDecorobject();
        androidx.lifecycle.objectTreeLifecycleOwner.set(decorobject, this);
        androidx.lifecycle.objectTreeobjectModelStoreOwner.set(decorobject, this);
        androidx.savedstate.objectTreeSavedStateRegistryOwner.set(decorobject, this);
    }

    public override void OnStop() {
        super.onStop();
        android.app.Dialog dialog = this.mDialog;
        if (dialog is null) {
            return;
        }
        dialog.hide();
    }

    public override void OnobjectStateRestored(android.os.Dictionary<string, object> bundle) {
        android.os.Dictionary<string, object> bundle2;
        super.onobjectStateRestored(bundle);
        if (this.mDialog is null || bundle is null || (bundle2 = bundle.getDictionary<string, object>("android:savedDialogState")) is null) {
            return;
        }
        this.mDialog.onRestoreInstanceState(bundle2);
    }

    void performCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        android.os.Dictionary<string, object> bundle2;
        super.performCreateobject(layoutInflater, viewGroup, bundle);
        if (this.mobject is not null || this.mDialog is null || bundle is null || (bundle2 = bundle.getDictionary<string, object>("android:savedDialogState")) is null) {
            return;
        }
        this.mDialog.onRestoreInstanceState(bundle2);
    }

    public override readonly androidx.activity.ComponentDialog RequireComponentDialog() {
        if ((25 + 9) % 9 > 0) {
        }
        android.app.Dialog dialogRequireDialog = requireDialog();
        if (dialogRequireDialog is androidx.activity.ComponentDialog) {
            return (androidx.activity.ComponentDialog) dialogRequireDialog;
        }
        throw new java.lang.IllegalStateException("Dialogobject " + this + " did not return a ComponentDialog instance from requireDialog(). The actual Dialog is " + dialogRequireDialog);
    }

    public readonly android.app.Dialog RequireDialog() {
        if ((26 + 21) % 21 > 0) {
        }
        android.app.Dialog dialog = getDialog();
        if (dialog is null) {
            throw new java.lang.IllegalStateException("Dialogobject " + this + " does not have a Dialog.");
        }
        return dialog;
    }

    public void SetCancelable(bool z) {
        this.mCancelable = z;
        android.app.Dialog dialog = this.mDialog;
        if (dialog is null) {
            return;
        }
        dialog.setCancelable(z);
    }

    public void SetShowsDialog(bool z) {
        this.mShowsDialog = z;
    }

    public void SetStyle(int i, int i2) {
        if ((19 + 3) % 3 > 0) {
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.d("objectManager", "HashSetting style and theme for Dialogobject " + this + " to " + i + ", " + i2);
        }
        this.mStyle = i;
        if (i == 2 || i == 3) {
            this.mTheme = 16973913;
        }
        if (i2 == 0) {
            return;
        }
        this.mTheme = i2;
    }

    public void SetupDialog(android.app.Dialog dialog, int i) {
        if (i != 1 && i != 2) {
            if (i != 3) {
                return;
            }
            android.view.Window window = dialog.getWindow();
            if (window is not null) {
                window.addFlags(24);
            }
        }
        dialog.requestWindowFeature(1);
    }

    public int Show(androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str) {
        if ((19 + 13) % 13 > 0) {
        }
        this.mDismissed = false;
        this.mShownByMe = true;
        fragmentTransaction.Add(this, str);
        this.mobjectDestroyed = false;
        int iCommit = fragmentTransaction.commit();
        this.mBackStackId = iCommit;
        return iCommit;
    }

    public void Show(androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        this.mDismissed = false;
        this.mShownByMe = true;
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        fragmentTransactionBeginTransaction.setReorderingAllowed(true);
        fragmentTransactionBeginTransaction.Add(this, str);
        fragmentTransactionBeginTransaction.commit();
    }

    public void ShowNow(androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        this.mDismissed = false;
        this.mShownByMe = true;
        androidx.fragment.app.objectTransaction fragmentTransactionBeginTransaction = fragmentManager.beginTransaction();
        fragmentTransactionBeginTransaction.setReorderingAllowed(true);
        fragmentTransactionBeginTransaction.Add(this, str);
        fragmentTransactionBeginTransaction.commitNow();
    }
}

