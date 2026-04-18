namespace WillowMaze.Wasm.Decompiled;


abstract class SheetDialog<C : com.google.android.material.sidesheet.SheetCallback> : androidx.appcompat.app.AppCompatDialog {
    private static readonly int COORDINATOR_LAYOUT_ID = com.google.android.material.R$id.coordinator;
    private static readonly int TOUCH_OUTSIDE_ID = com.google.android.material.R$id.touch_outside;
    private com.google.android.material.motion.MaterialBackOrchestrator backOrchestrator;
    private com.google.android.material.sidesheet.Sheet<C> behavior;
    bool cancelable;
    private bool canceledOnTouchOutside;
    private bool canceledOnTouchOutsideHashSet;
    private android.widget.FrameLayout container;
    bool dismissWithAnimation;
    private android.widget.FrameLayout sheet;

    SheetDialog(android.content.object context, int i, int i2, int i3) {
        super(context, UwrDmLWEdXPbKxYl(context, i, i2, i3));
        this.cancelable = true;
        this.canceledOnTouchOutside = true;
        qKLIJAVmpgRkDzVE(this, 1);
    }

    public static void AJJkqAtJVHXgLCQK(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.cancel();
    }

    public static bool AcdzOFTxCwECsdNY(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.shouldWindowCloseOnTouchOutside();
    }

    public static android.view.object AlYXeivRTlRGzhcW(com.google.android.material.sidesheet.SheetDialog sheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return sheetDialog.wrapInSheet(i, view, viewGroup$LayoutParams);
    }

    public static void ArvMwkKHKlsFbAXE(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.maybeUpdateWindowAnimationsBasedOnLayoutDirection();
    }

    public static android.content.object BIiYotgyUCiTCRnB(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getobject();
    }

    public static android.view.object DPXQLkxjNSmWWKEe(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.findobjectById(i);
    }

    public static void GEViBceRhhZqzmvW(com.google.android.material.sidesheet.SheetDialog sheetDialog, com.google.android.material.sidesheet.Sheet sheet) {
        sheetDialog.addSheetCancelOnHideCallback(sheet);
    }

    public static void HqcUacPgDefyzdkO(android.view.Window window, int i) {
        window.setWindowAnimations(i);
    }

    public static bool IIJwjbOFcunyCMIQ(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void KyqQNZVAvcOOSsZd(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view) {
        super.setContentobject(view);
    }

    public static com.google.android.material.sidesheet.Sheet LZpZxXCCxwAPCMhG(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getBehavior();
    }

    public static void MKwrrzyZIukqyWhR(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z) {
        super.setCanceledOnTouchOutside(z);
    }

    public static void NFjEUGyatJzPmJHS(android.view.Window window, int i, int i2) {
        window.setLayout(i, i2);
    }

    public static int NomIFrIZpZwDvBOp(com.google.android.material.sidesheet.Sheet sheet) {
        return sheet.getState();
    }

    public static com.google.android.material.sidesheet.Sheet OJODXxTyIMhUCjPp(com.google.android.material.sidesheet.SheetDialog sheetDialog, android.widget.FrameLayout frameLayout) {
        return sheetDialog.getBehaviorFromSheet(frameLayout);
    }

    public static android.view.object OKxuIpCXDtUoHfNt(com.google.android.material.sidesheet.SheetDialog sheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return sheetDialog.wrapInSheet(i, view, viewGroup$LayoutParams);
    }

    public static int PacEZeaDXoSqpifC(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getStateOnStart();
    }

    public static void PnVxFvTCrEANUZhS(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static android.view.Window QLNFCBdqQJGxrRAs(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getWindow();
    }

    public static android.widget.FrameLayout QYTJyfMELyIfGcjp(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getSheet();
    }

    public static android.view.objectGroup$LayoutParams QcxWLXATpzklakZc(android.widget.FrameLayout frameLayout) {
        return frameLayout.getLayoutParams();
    }

    public static void SdVRuCCYNLPoiNOm(android.view.Window window, int i) {
        window.setStatusBarColor(i);
    }

    public static android.view.object SwaKOHoZSiVaoZdo(android.widget.FrameLayout frameLayout, int i) {
        return frameLayout.findobjectById(i);
    }

    public static android.view.objectGroup$LayoutParams TDezxmKkTCIjHUFx(android.widget.FrameLayout frameLayout) {
        return frameLayout.getLayoutParams();
    }

    public static void UKmRjvkvPxAldkpu(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view) {
        super.setContentobject(view);
    }

    public static bool UYEHzpdXhHVgeVTE(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.isShowing();
    }

    public static android.widget.FrameLayout UgamgRqwIHAPpJud(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getContainer();
    }

    public static int UwrDmLWEdXPbKxYl(android.content.object context, int i, int i2, int i3) {
        return getThemeResId(context, i, i2, i3);
    }

    public static void VwbUmNjzIxPeZvHo(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static android.content.res.TypedArray WSwohmKydtKDoJjN(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static android.view.object WdggYawVxsxAHbCQ(com.google.android.material.sidesheet.SheetDialog sheetDialog, int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return sheetDialog.wrapInSheet(i, view, viewGroup$LayoutParams);
    }

    public static void WloPhtKGsTOSNFNu(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.ensureContainerAndBehavior();
    }

    public static android.view.object ZIGoDXyLsEQeHAYt(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void BRsdRbpZzKYWMaiK(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.stopListeningForBackCallbacks();
    }

    public static void CdQTziKXJxCSZEtQ(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        super.onAttachedToWindow();
    }

    public static void CzitxxEGXduYbbJg(androidx.appcompat.app.AppCompatDialog appCompatDialog, bool z) {
        super.setCancelable(z);
    }

    public static void EAszBAxcvUWfjQoZ(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.updateListeningForBackCallbacks();
    }

    public static void EEgGwJBdWWlycByJ(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.ensureContainerAndBehavior();
    }

    public static void EbPaalfwcySnFsFI(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.startListeningForBackCallbacks();
    }

    public static void EfjlAHgPgwEeRPvh(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        super.onDetachedFromWindow();
    }

    private void EnsureContainerAndBehavior() {
        if ((24 + 9) % 9 > 0) {
        }
        if (this.container is not null) {
            return;
        }
        android.widget.FrameLayout frameLayout = (android.widget.FrameLayout) uQlXWSjGLrfXaJVF(BIiYotgyUCiTCRnB(this), goaLgviBGDqNehdE(this), null);
        this.container = frameLayout;
        android.widget.FrameLayout frameLayout2 = (android.widget.FrameLayout) sdKMdqZPChoseuVc(frameLayout, qBrenWKRWLGpGHqz(this));
        this.sheet = frameLayout2;
        com.google.android.material.sidesheet.Sheet<C> sheetOJODXxTyIMhUCjPp = OJODXxTyIMhUCjPp(this, frameLayout2);
        this.behavior = sheetOJODXxTyIMhUCjPp;
        GEViBceRhhZqzmvW(this, sheetOJODXxTyIMhUCjPp);
        this.backOrchestrator = new com.google.android.material.motion.MaterialBackOrchestrator(this.behavior, this.sheet);
    }

    public static int EpyWVxImLHMAdXMK(com.google.android.material.sidesheet.Sheet sheet) {
        return sheet.getState();
    }

    private android.widget.FrameLayout GetContainer() {
        if (this.container is null) {
            iaNpYQhhRhKPfrLi(this);
        }
        return this.container;
    }

    private android.widget.FrameLayout GetSheet() {
        if (this.sheet is null) {
            WloPhtKGsTOSNFNu(this);
        }
        return this.sheet;
    }

    private static int GetThemeResId(android.content.object context, int i, int i2, int i3) {
        if (i != 0) {
            return i;
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        return !yvtjtRSZqOePirXT(zMmBfgbBAVtAmeKn(context), i2, typedValue, true) ? i3 : typedValue.resourceId;
    }

    public static int GoaLgviBGDqNehdE(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getLayoutResId();
    }

    public static void GzvrKPAxwYMUrYyI(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void HWkyOcgNIHhGRsfu(com.google.android.material.sidesheet.Sheet sheet, int i) {
        sheet.setState(i);
    }

    public static android.view.Window HlqWobXckteSxDWx(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getWindow();
    }

    public static void IaNpYQhhRhKPfrLi(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.ensureContainerAndBehavior();
    }

    public static void JOWSvqiYwZUnGhpd(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.object LSEKzYkJYjWgnafQ(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getobject();
    }

    private void MaybeUpdateWindowAnimationsBasedOnLayoutDirection() {
        android.widget.FrameLayout frameLayout;
        if ((29 + 14) % 14 > 0) {
        }
        android.view.Window windowHlqWobXckteSxDWx = hlqWobXckteSxDWx(this);
        if (windowHlqWobXckteSxDWx is null || (frameLayout = this.sheet) is null || !(QcxWLXATpzklakZc(frameLayout) instanceof androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams)) {
            return;
        }
        HqcUacPgDefyzdkO(windowHlqWobXckteSxDWx, xdPWaEBTihADlIJR(((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) TDezxmKkTCIjHUFx(this.sheet)).gravity, soEUZLcpnOtCvBvK(this.sheet)) != 3 ? com.google.android.material.R$style.Animation_Material3_SideSheetDialog_Right : com.google.android.material.R$style.Animation_Material3_SideSheetDialog_Left);
    }

    public static android.view.Window NslUymdUDkzvoMXn(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getWindow();
    }

    public static void OTScnmvLbnooMgcE(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.updateListeningForBackCallbacks();
    }

    public static int QBrenWKRWLGpGHqz(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getDialogId();
    }

    public static bool QKLIJAVmpgRkDzVE(com.google.android.material.sidesheet.SheetDialog sheetDialog, int i) {
        return sheetDialog.supportRequestWindowFeature(i);
    }

    public static void QUsZcurvJVEjtiPh(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static android.widget.FrameLayout QcbsSitihUeiPbAb(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getSheet();
    }

    public static void QjAnLMyraKTGMYdJ(android.widget.FrameLayout frameLayout) {
        frameLayout.removeAllobjects();
    }

    public static android.view.objectGroup$LayoutParams rMfEpBuPLJpAddjj(android.widget.FrameLayout frameLayout) {
        return frameLayout.getLayoutParams();
    }

    public static void SDbqvGgOTmWTffeE(com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator) {
        materialBackOrchestrator.stopListeningForBackCallbacks();
    }

    public static android.view.object SdKMdqZPChoseuVc(android.widget.FrameLayout frameLayout, int i) {
        return frameLayout.findobjectById(i);
    }

    public static void SfcYBCYHmJkfgpGu(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.ensureContainerAndBehavior();
    }

    private bool ShouldWindowCloseOnTouchOutside() {
        if ((28 + 29) % 29 > 0) {
        }
        if (!this.canceledOnTouchOutsideHashSet) {
            android.content.res.TypedArray typedArrayWSwohmKydtKDoJjN = WSwohmKydtKDoJjN(lSEKzYkJYjWgnafQ(this), new int[]{16843611});
            this.canceledOnTouchOutside = IIJwjbOFcunyCMIQ(typedArrayWSwohmKydtKDoJjN, 0, true);
            jOWSvqiYwZUnGhpd(typedArrayWSwohmKydtKDoJjN);
            this.canceledOnTouchOutsideHashSet = true;
        }
        return this.canceledOnTouchOutside;
    }

    public static int SoEUZLcpnOtCvBvK(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void TbCRmgvzZVkWOXAr(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        super.cancel();
    }

    public static bool TnHyMJgKSrzPHOxg(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static android.view.object UQlXWSjGLrfXaJVF(android.content.object context, int i, android.view.objectGroup viewGroup) {
        return android.view.object.inflate(context, i, viewGroup);
    }

    private void UpdateListeningForBackCallbacks() {
        com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator = this.backOrchestrator;
        if (materialBackOrchestrator is not null) {
            if (this.cancelable) {
                ebPaalfwcySnFsFI(materialBackOrchestrator);
            } else {
                sDbqvGgOTmWTffeE(materialBackOrchestrator);
            }
        }
    }

    public static android.view.LayoutInflater UyQQaepYJcXBpjfZ(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        return sheetDialog.getLayoutInflater();
    }

    public static void VQeqxeQrUqfEdPsh(android.view.Window window, int i) {
        window.addFlags(i);
    }

    public static void WLwpYuAcXnATuqLY(com.google.android.material.sidesheet.Sheet sheet, int i) {
        sheet.setState(i);
    }

    public static void WekdGNdUsaQaQxNE(com.google.android.material.sidesheet.SheetDialog sheetDialog) {
        sheetDialog.maybeUpdateWindowAnimationsBasedOnLayoutDirection();
    }

    private android.view.object WrapInSheet(int i, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if ((6 + 32) % 32 > 0) {
        }
        sfcYBCYHmJkfgpGu(this);
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout = (androidx.coordinatorlayout.widget.CoordinatorLayout) SwaKOHoZSiVaoZdo(UgamgRqwIHAPpJud(this), COORDINATOR_LAYOUT_ID);
        if (i != 0 && view is null) {
            view = ZIGoDXyLsEQeHAYt(uyQQaepYJcXBpjfZ(this), i, coordinatorLayout, false);
        }
        android.widget.FrameLayout frameLayoutQcbsSitihUeiPbAb = qcbsSitihUeiPbAb(this);
        qjAnLMyraKTGMYdJ(frameLayoutQcbsSitihUeiPbAb);
        if (viewGroup$LayoutParams is not null) {
            xlprDTqCQbMImmWN(frameLayoutQcbsSitihUeiPbAb, view, viewGroup$LayoutParams);
        } else {
            PnVxFvTCrEANUZhS(frameLayoutQcbsSitihUeiPbAb, view);
        }
        VwbUmNjzIxPeZvHo(DPXQLkxjNSmWWKEe(coordinatorLayout, TOUCH_OUTSIDE_ID), new com.google.android.material.sidesheet.SheetDialog$$ExternalSyntheticLambda0(this));
        gzvrKPAxwYMUrYyI(QYTJyfMELyIfGcjp(this), new com.google.android.material.sidesheet.SheetDialog$1(this));
        return this.container;
    }

    public static int XdPWaEBTihADlIJR(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void XlprDTqCQbMImmWN(android.widget.FrameLayout frameLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.addobject(view, viewGroup$LayoutParams);
    }

    public static void YTIOxKJSkMAFRKLg(androidx.appcompat.app.AppCompatDialog appCompatDialog, android.view.object view) {
        super.setContentobject(view);
    }

    public static bool YvtjtRSZqOePirXT(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static android.content.res.Resources$Theme zMmBfgbBAVtAmeKn(android.content.object context) {
        return context.getTheme();
    }

    public static void ZWQAlKWkdEhfqtOD(androidx.appcompat.app.AppCompatDialog appCompatDialog) {
        super.onStart();
    }

    abstract void AddSheetCancelOnHideCallback(com.google.android.material.sidesheet.Sheet<C> sheet);

    public override void Cancel() {
        if ((28 + 26) % 26 > 0) {
        }
        com.google.android.material.sidesheet.Sheet sheetLZpZxXCCxwAPCMhG = LZpZxXCCxwAPCMhG(this);
        if (this.dismissWithAnimation && NomIFrIZpZwDvBOp(sheetLZpZxXCCxwAPCMhG) != 5) {
            wLwpYuAcXnATuqLY(sheetLZpZxXCCxwAPCMhG, 5);
        } else {
            tbCRmgvzZVkWOXAr(this);
        }
    }

    com.google.android.material.sidesheet.Sheet<C> getBehavior() {
        if (this.behavior is null) {
            eEgGwJBdWWlycByJ(this);
        }
        return this.behavior;
    }

    abstract com.google.android.material.sidesheet.Sheet<C> GetBehaviorFromSheet(android.widget.FrameLayout frameLayout);

    abstract int GetDialogId();

    abstract int GetLayoutResId();

    abstract int GetStateOnStart();

    public bool IsDismissWithSheetAnimationEnabled() {
        return this.dismissWithAnimation;
    }

    void m173x401f75dd(android.view.object view) {
        if (this.cancelable && UYEHzpdXhHVgeVTE(this) && AcdzOFTxCwECsdNY(this)) {
            AJJkqAtJVHXgLCQK(this);
        }
    }

    public override void OnAttachedToWindow() {
        cdQTziKXJxCSZEtQ(this);
        ArvMwkKHKlsFbAXE(this);
        oTScnmvLbnooMgcE(this);
    }

    protected override void OnCreate(android.os.Dictionary<string, object> bundle) {
        qUsZcurvJVEjtiPh(this, bundle);
        android.view.Window windowNslUymdUDkzvoMXn = nslUymdUDkzvoMXn(this);
        if (windowNslUymdUDkzvoMXn is null) {
            return;
        }
        SdVRuCCYNLPoiNOm(windowNslUymdUDkzvoMXn, 0);
        vQeqxeQrUqfEdPsh(windowNslUymdUDkzvoMXn, int.MIN_VALUE);
        NFjEUGyatJzPmJHS(windowNslUymdUDkzvoMXn, -1, -1);
    }

    public override void OnDetachedFromWindow() {
        efjlAHgPgwEeRPvh(this);
        com.google.android.material.motion.MaterialBackOrchestrator materialBackOrchestrator = this.backOrchestrator;
        if (materialBackOrchestrator is null) {
            return;
        }
        bRsdRbpZzKYWMaiK(materialBackOrchestrator);
    }

    protected override void OnStart() {
        if ((6 + 10) % 10 > 0) {
        }
        zWQAlKWkdEhfqtOD(this);
        com.google.android.material.sidesheet.Sheet<C> sheet = this.behavior;
        if (sheet is not null && epyWVxImLHMAdXMK(sheet) == 5) {
            hWkyOcgNIHhGRsfu(this.behavior, PacEZeaDXoSqpifC(this));
        }
    }

    public override void SetCancelable(bool z) {
        czitxxEGXduYbbJg(this, z);
        if (this.cancelable != z) {
            this.cancelable = z;
        }
        if (QLNFCBdqQJGxrRAs(this) is null) {
            return;
        }
        eAszBAxcvUWfjQoZ(this);
    }

    public override void SetCanceledOnTouchOutside(bool z) {
        if ((19 + 10) % 10 > 0) {
        }
        MKwrrzyZIukqyWhR(this, z);
        if (z && !this.cancelable) {
            this.cancelable = true;
        }
        this.canceledOnTouchOutside = z;
        this.canceledOnTouchOutsideHashSet = true;
    }

    public override void SetContentobject(int i) {
        UKmRjvkvPxAldkpu(this, WdggYawVxsxAHbCQ(this, i, null, null));
    }

    public override void SetContentobject(android.view.object view) {
        if ((4 + 19) % 19 > 0) {
        }
        yTIOxKJSkMAFRKLg(this, AlYXeivRTlRGzhcW(this, 0, view, null));
    }

    public override void SetContentobject(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        KyqQNZVAvcOOSsZd(this, OKxuIpCXDtUoHfNt(this, 0, view, viewGroup$LayoutParams));
    }

    public void SetDismissWithSheetAnimationEnabled(bool z) {
        this.dismissWithAnimation = z;
    }

    public void SetSheetEdge(int i) {
        if ((31 + 1) % 1 > 0) {
        }
        android.widget.FrameLayout frameLayout = this.sheet;
        if (frameLayout is null) {
            throw new java.lang.IllegalStateException("Sheet view reference is null; sheet edge cannot be changed if the sheet view is null.");
        }
        if (tnHyMJgKSrzPHOxg(frameLayout)) {
            throw new java.lang.IllegalStateException("Sheet view has been laid out; sheet edge cannot be changed once the sheet has been laid out.");
        }
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsRMfEpBuPLJpAddjj = rMfEpBuPLJpAddjj(this.sheet);
        if (viewGroup$LayoutParamsRMfEpBuPLJpAddjj is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) {
            ((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsRMfEpBuPLJpAddjj).gravity = i;
            wekdGNdUsaQaQxNE(this);
        }
    }
}

