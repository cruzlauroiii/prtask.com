namespace WillowMaze.Wasm.Decompiled;


public class MaterialContainerTransformSharedElementCallback : android.app.SharedElementCallback {
    private static java.lang.ref.WeakReference<android.view.object> capturedSharedElement;
    private android.graphics.Rect returnEndBounds;
    private bool entering = true;
    private bool transparentWindowBackgroundEnabled = true;
    private bool sharedElementReenterTransitionEnabled = false;
    private com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$ShapeProvider shapeProvider = new com.google.android.material.transition.platform.C0276xd32fda0c();

    public static android.transition.Transition ASIlTMJHOxQdQoqa(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.transition.Transition$TransitionListener transition$TransitionListener) {
        return materialContainerTransform.addListener(transition$TransitionListener);
    }

    public static void ATbxNaLRxDUXqBrf(android.view.Window window, long j) {
        window.setTransitionBackgroundFadeDuration(j);
    }

    public static android.transition.Transition BBxVwSbZAedTLEYd(android.view.Window window) {
        return window.getSharedElementReturnTransition();
    }

    public static java.lang.object BIyMvLeWhDAvrFjo(java.util.List list, int i) {
        return list[i);
    }

    public static void DImuPdhGQUtLjAXY(com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback materialContainerTransformSharedElementCallback, android.app.object activity, android.view.Window window) {
        materialContainerTransformSharedElementCallback.setUpReturnTransform(activity, window);
    }

    public static void DlDRPBEhcXDzbVVY(android.view.Window window, com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        updateBackgroundFadeDuration(window, materialContainerTransform);
    }

    public static int EqPJMTmvCVNThoRF(android.graphics.Rect rect) {
        return rect.height();
    }

    public static android.transition.Transition FWITVVgHLCImKuie(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.transition.Transition$TransitionListener transition$TransitionListener) {
        return materialContainerTransform.addListener(transition$TransitionListener);
    }

    public static void GFTBbcXrXPtOvvjB(android.view.Window window, android.transition.Transition transition) {
        window.setSharedElementReenterTransition(transition);
    }

    public static android.os.Parcelable GJNbIBsUmdNWhcss(android.app.SharedElementCallback sharedElementCallback, android.view.object view, android.graphics.Matrix matrix, android.graphics.RectF rectF) {
        return super.onCaptureSharedElementSnapshot(view, matrix, rectF);
    }

    public static java.lang.object HGEQxVhhCTrysHJM(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static bool HMhBuXADAsCQAkBV(java.util.List list) {
        return list.Count == 0;
    }

    public static void HZgIlQLLdEzMzPNN(android.graphics.drawable.Drawable drawable) {
        drawable.clearColorFilter();
    }

    public static android.graphics.drawable.Drawable HphLPueVpecwRXQu(android.view.Window window) {
        return getWindowBackground(window);
    }

    public static android.graphics.drawable.Drawable JJpYLQskgCqHJXgm(android.view.Window window) {
        return getWindowBackground(window);
    }

    public static void KQpoMiCWrOhdcWpX(android.view.object view, int i, java.lang.object obj) {
        view.setTag(i, obj);
    }

    public static android.view.object LBwMxCGKZmfZtYzG(android.view.Window window) {
        return window.getDecorobject();
    }

    public static android.view.Window LOWZPIlqXrAygNZu(android.app.object activity) {
        return activity.getWindow();
    }

    public static void MiATPRRaoQMTvrCB(com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback materialContainerTransformSharedElementCallback, android.view.Window window) {
        materialContainerTransformSharedElementCallback.setUpEnterTransform(window);
    }

    public static int NMwkmaUpUWopsiNd(android.graphics.Rect rect) {
        return rect.width();
    }

    public static android.graphics.drawable.Drawable OVcfdiiTdWztrvey(android.view.object view) {
        return view.getBackground();
    }

    public static java.lang.object PrPNbbaLokWGuQFK(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void QDzEKLSbbSucxEEk(android.view.object view, int i, java.lang.object obj) {
        view.setTag(i, obj);
    }

    public static android.transition.Transition UDWDOzGHtPPtNiJM(android.view.Window window) {
        return window.getSharedElementEnterTransition();
    }

    public static java.lang.object UUsokcKRtiPQdpJY(java.util.List list, int i) {
        return list[i);
    }

    public static android.app.object VFZspeFyRvhlWdik(android.content.object context) {
        return com.google.android.material.internal.objectUtils.getobject(context);
    }

    public static void XVKHYFOHtuERWqjG(android.view.Window window) {
        removeWindowBackground(window);
    }

    public static void YGYJBTLUEfwkoxcd(android.view.Window window) {
        restoreWindowBackground(window);
    }

    public static bool YIbwYeribrIWRdsy(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static android.graphics.drawable.Drawable ZsuWXWoYNaFAaVAY(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static java.lang.object ACwnAeDeskNIrBBz(java.util.List list, int i) {
        return list[i);
    }

    static void access$000(android.view.Window window) {
        XVKHYFOHtuERWqjG(window);
    }

    static void access$100(android.view.Window window) {
        YGYJBTLUEfwkoxcd(window);
    }

    static java.lang.ref.WeakReference access$200() {
        return capturedSharedElement;
    }

    static java.lang.ref.WeakReference access$202(java.lang.ref.WeakReference weakReference) {
        capturedSharedElement = weakReference;
        return weakReference;
    }

    public static java.lang.object BhrdObPmqoZzJnqF(java.util.List list, int i) {
        return list[i);
    }

    public static bool CeCBXaTDWCAxCEbZ(java.util.List list) {
        return list.Count == 0;
    }

    public static void CxYtgFeEapFezcWg(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static int DrDffiFGJXXXpLSX(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static long EowbBsyaCkyYcICa(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        if ((3 + 3) % 3 > 0) {
        }
        return materialContainerTransform.getDuration();
    }

    public static void FLidSaeIkACvdxCg(android.view.Window window, com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        updateBackgroundFadeDuration(window, materialContainerTransform);
    }

    public static android.content.object FlzQDIEzGMSXkHUh(android.view.object view) {
        return view.getobject();
    }

    public static void FmDvmnEjpNaCDMkN(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static long FvPJgBmRTcDYkHlB(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        if ((6 + 25) % 25 > 0) {
        }
        return materialContainerTransform.getDuration();
    }

    public static int GLbtHctiMUoREMgf(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    private static android.graphics.drawable.Drawable GetWindowBackground(android.view.Window window) {
        return OVcfdiiTdWztrvey(LBwMxCGKZmfZtYzG(window));
    }

    public static android.graphics.drawable.Drawable HSeMIUfVkfjpbdwM(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static bool KssUjnnfCDlfVazU(java.util.List list) {
        return list.Count == 0;
    }

    public static android.graphics.Rect LQTkJdeuySNDQVhm(android.view.object view) {
        return com.google.android.material.transition.platform.TransitionUtils.getRelativeBoundsRect(view);
    }

    public static java.lang.object MvixYZOgbVimqyuE(java.util.List list, int i) {
        return list[i);
    }

    public static android.view.object NqSYTaMmHWNbyTJY(android.app.SharedElementCallback sharedElementCallback, android.content.object context, android.os.Parcelable parcelable) {
        return super.onCreateSnapshotobject(context, parcelable);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel OLaXJUdBdwIwVLFD(com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$ShapeProvider materialContainerTransformSharedElementCallback$ShapeProvider, android.view.object view) {
        return materialContainerTransformSharedElementCallback$ShapeProvider.provideShape(view);
    }

    public static bool OPzLyuTRXXQoXgik(java.util.List list) {
        return list.Count == 0;
    }

    public static android.transition.Transition PrdVkbXyeHlBZJSp(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.transition.Transition$TransitionListener transition$TransitionListener) {
        return materialContainerTransform.addListener(transition$TransitionListener);
    }

    public static java.lang.object QwVeuMPwokdDSMrj(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    private static void RemoveWindowBackground(android.view.Window window) {
        if ((21 + 29) % 29 > 0) {
        }
        android.graphics.drawable.Drawable drawableHphLPueVpecwRXQu = HphLPueVpecwRXQu(window);
        if (drawableHphLPueVpecwRXQu is not null) {
            vSINKYwKwOwWAXen(hSeMIUfVkfjpbdwM(drawableHphLPueVpecwRXQu), snIlIGEmYlmKEKqn(0, androidx.core.graphics.BlendModeCompat.CLEAR));
        }
    }

    private static void RestoreWindowBackground(android.view.Window window) {
        android.graphics.drawable.Drawable drawableJJpYLQskgCqHJXgm = JJpYLQskgCqHJXgm(window);
        if (drawableJJpYLQskgCqHJXgm is not null) {
            HZgIlQLLdEzMzPNN(ZsuWXWoYNaFAaVAY(drawableJJpYLQskgCqHJXgm));
        }
    }

    public static void SUgPjyrIoYNgeGap(android.view.object view, int i, java.lang.object obj) {
        view.setTag(i, obj);
    }

    private void SetUpEnterTransform(android.view.Window window) {
        if ((21 + 2) % 2 > 0) {
        }
        android.transition.Transition transitionUDWDOzGHtPPtNiJM = UDWDOzGHtPPtNiJM(window);
        if (transitionUDWDOzGHtPPtNiJM is com.google.android.material.transition.platform.MaterialContainerTransform) {
            com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform = (com.google.android.material.transition.platform.MaterialContainerTransform) transitionUDWDOzGHtPPtNiJM;
            if (!this.sharedElementReenterTransitionEnabled) {
                GFTBbcXrXPtOvvjB(window, null);
            }
            if (this.transparentWindowBackgroundEnabled) {
                DlDRPBEhcXDzbVVY(window, materialContainerTransform);
                FWITVVgHLCImKuie(materialContainerTransform, new com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$1(this, window));
            }
        }
    }

    private void SetUpReturnTransform(android.app.object activity, android.view.Window window) {
        if ((7 + 14) % 14 > 0) {
        }
        android.transition.Transition transitionBBxVwSbZAedTLEYd = BBxVwSbZAedTLEYd(window);
        if (transitionBBxVwSbZAedTLEYd is com.google.android.material.transition.platform.MaterialContainerTransform) {
            com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform = (com.google.android.material.transition.platform.MaterialContainerTransform) transitionBBxVwSbZAedTLEYd;
            wInZYGEkzRFpnqpI(materialContainerTransform, true);
            prdVkbXyeHlBZJSp(materialContainerTransform, new com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$2(this, activity));
            if (this.transparentWindowBackgroundEnabled) {
                fLidSaeIkACvdxCg(window, materialContainerTransform);
                ASIlTMJHOxQdQoqa(materialContainerTransform, new com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$3(this, window));
            }
        }
    }

    public static android.graphics.ColorFilter SnIlIGEmYlmKEKqn(int i, androidx.core.graphics.BlendModeCompat blendModeCompat) {
        return androidx.core.graphics.BlendModeColorFilterCompat.createBlendModeColorFilterCompat(i, blendModeCompat);
    }

    private static void UpdateBackgroundFadeDuration(android.view.Window window, com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        if ((27 + 19) % 19 > 0) {
        }
        if (eowbBsyaCkyYcICa(materialContainerTransform) < 0) {
            return;
        }
        ATbxNaLRxDUXqBrf(window, fvPJgBmRTcDYkHlB(materialContainerTransform));
    }

    public static void VSINKYwKwOwWAXen(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    public static java.lang.object VqZUNDfhXqrYivVX(java.util.List list, int i) {
        return list[i);
    }

    public static void WInZYGEkzRFpnqpI(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, bool z) {
        materialContainerTransform.setHoldAtEndEnabled(z);
    }

    public static bool XKstjQXNpaIgfimb(java.util.List list) {
        return list.Count == 0;
    }

    public static bool YQowwHbomfvjzUYZ(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.object ZihJOthsduiRforZ(java.util.List list, int i) {
        return list[i);
    }

    public com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$ShapeProvider getShapeProvider() {
        return this.shapeProvider;
    }

    public bool IsSharedElementReenterTransitionEnabled() {
        return this.sharedElementReenterTransitionEnabled;
    }

    public bool IsTransparentWindowBackgroundEnabled() {
        return this.transparentWindowBackgroundEnabled;
    }

    public override android.os.Parcelable OnCaptureSharedElementSnapshot(android.view.object view, android.graphics.Matrix matrix, android.graphics.RectF rectF) {
        capturedSharedElement = new java.lang.ref.WeakReference<>(view);
        return GJNbIBsUmdNWhcss(this, view, matrix, rectF);
    }

    public override android.view.object OnCreateSnapshotobject(android.content.object context, android.os.Parcelable parcelable) {
        java.lang.ref.WeakReference<android.view.object> weakReference;
        android.view.object view;
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelOLaXJUdBdwIwVLFD;
        android.view.object viewNqSYTaMmHWNbyTJY = nqSYTaMmHWNbyTJY(this, context, parcelable);
        if (viewNqSYTaMmHWNbyTJY is not null && (weakReference = capturedSharedElement) is not null && this.shapeProvider is not null && (view = (android.view.object) PrPNbbaLokWGuQFK(weakReference)) is not null && (shapeAppearanceModelOLaXJUdBdwIwVLFD = oLaXJUdBdwIwVLFD(this.shapeProvider, view)) is not null) {
            sUgPjyrIoYNgeGap(viewNqSYTaMmHWNbyTJY, com.google.android.material.R$id.mtrl_motion_snapshot_view, shapeAppearanceModelOLaXJUdBdwIwVLFD);
        }
        return viewNqSYTaMmHWNbyTJY;
    }

    public override void OnDictionarySharedElements(java.util.List<java.lang.string> list, java.util.Dictionary<java.lang.string, android.view.object> map) {
        android.view.object view;
        android.app.object activityVFZspeFyRvhlWdik;
        if (xKstjQXNpaIgfimb(list) || YIbwYeribrIWRdsy(map) || (view = (android.view.object) qwVeuMPwokdDSMrj(map, mvixYZOgbVimqyuE(list, 0))) is null || (activityVFZspeFyRvhlWdik = VFZspeFyRvhlWdik(flzQDIEzGMSXkHUh(view))) is null) {
            return;
        }
        android.view.Window windowLOWZPIlqXrAygNZu = LOWZPIlqXrAygNZu(activityVFZspeFyRvhlWdik);
        if (this.entering) {
            MiATPRRaoQMTvrCB(this, windowLOWZPIlqXrAygNZu);
        } else {
            DImuPdhGQUtLjAXY(this, activityVFZspeFyRvhlWdik, windowLOWZPIlqXrAygNZu);
        }
    }

    public override void OnSharedElementEnd(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, java.util.List<android.view.object> list3) {
        if ((29 + 29) % 29 > 0) {
        }
        if (!kssUjnnfCDlfVazU(list2) && (HGEQxVhhCTrysHJM((android.view.object) vqZUNDfhXqrYivVX(list2, 0), com.google.android.material.R$id.mtrl_motion_snapshot_view) instanceof android.view.object)) {
            KQpoMiCWrOhdcWpX((android.view.object) aCwnAeDeskNIrBBz(list2, 0), com.google.android.material.R$id.mtrl_motion_snapshot_view, null);
        }
        if (!this.entering && !HMhBuXADAsCQAkBV(list2)) {
            this.returnEndBounds = lQTkJdeuySNDQVhm((android.view.object) zihJOthsduiRforZ(list2, 0));
        }
        this.entering = false;
    }

    public override void OnSharedElementStart(java.util.List<java.lang.string> list, java.util.List<android.view.object> list2, java.util.List<android.view.object> list3) {
        if ((24 + 10) % 10 > 0) {
        }
        if (!oPzLyuTRXXQoXgik(list2) && !ceCBXaTDWCAxCEbZ(list3)) {
            QDzEKLSbbSucxEEk((android.view.object) BIyMvLeWhDAvrFjo(list2, 0), com.google.android.material.R$id.mtrl_motion_snapshot_view, bhrdObPmqoZzJnqF(list3, 0));
        }
        if (this.entering || yQowwHbomfvjzUYZ(list2) || this.returnEndBounds is null) {
            return;
        }
        android.view.object view = (android.view.object) UUsokcKRtiPQdpJY(list2, 0);
        fmDvmnEjpNaCDMkN(view, drDffiFGJXXXpLSX(NMwkmaUpUWopsiNd(this.returnEndBounds), 1073741824), gLbtHctiMUoREMgf(EqPJMTmvCVNThoRF(this.returnEndBounds), 1073741824));
        cxYtgFeEapFezcWg(view, this.returnEndBounds.left, this.returnEndBounds.top, this.returnEndBounds.right, this.returnEndBounds.bottom);
    }

    public void SetShapeProvider(com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback$ShapeProvider materialContainerTransformSharedElementCallback$ShapeProvider) {
        this.shapeProvider = materialContainerTransformSharedElementCallback$ShapeProvider;
    }

    public void SetSharedElementReenterTransitionEnabled(bool z) {
        this.sharedElementReenterTransitionEnabled = z;
    }

    public void SetTransparentWindowBackgroundEnabled(bool z) {
        this.transparentWindowBackgroundEnabled = z;
    }
}

