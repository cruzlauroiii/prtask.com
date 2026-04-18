namespace WillowMaze.Wasm.Decompiled;


public abstract class DeferredLifecycleHelper<T : com.google.android.gms.dynamic.LifecycleDelegate> {
    private com.google.android.gms.dynamic.LifecycleDelegate zaa;
    private android.os.Dictionary<string, object> zab;
    private java.util.List zac;
    private readonly com.google.android.gms.dynamic.OnDelegateCreatedListener zad = new com.google.android.gms.dynamic.zaa(this);

    public static void BBjEpuNNunCkjVpx(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.os.Dictionary<string, object> bundle, com.google.android.gms.dynamic.zah zahVar) {
        deferredLifecycleHelper.zaf(bundle, zahVar);
    }

    public static bool CkZVqEpEOqmNrNhw(java.util.List linkedList) {
        return linkedList.Count == 0;
    }

    public static android.content.object DTznzKUsUdZXafLU(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context, int i, java.lang.string str) {
        return googleApiAvailability.getErrorResolutionobject(context, i, str);
    }

    public static void DwHDTEGvoVDNlWsJ(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.os.Dictionary<string, object> bundle, com.google.android.gms.dynamic.zah zahVar) {
        deferredLifecycleHelper.zaf(bundle, zahVar);
    }

    public static void FWShSGAOINyYYRjS(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, int i) {
        deferredLifecycleHelper.zae(i);
    }

    public static com.google.android.gms.common.GoogleApiAvailability HebjMGgaIOuBnRIJ() {
        return com.google.android.gms.common.GoogleApiAvailability.getInstance();
    }

    public static void LbFqUicgZxwDHKsH(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void LeJMEqjjNNKeiXJw(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, int i) {
        deferredLifecycleHelper.zae(i);
    }

    public static java.lang.object MIuVelsYTUpTrvdJ(java.util.List linkedList) {
        return linkedList.getLast();
    }

    public static void MhuHwzPNtrGCEHxe(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.os.Dictionary<string, object> bundle, com.google.android.gms.dynamic.zah zahVar) {
        deferredLifecycleHelper.zaf(bundle, zahVar);
    }

    public static void OKXizNpuRlgdIldE(android.widget.FrameLayout frameLayout) {
        showGooglePlayUnavailableMessage(frameLayout);
    }

    public static bool OZDeGHpTzKbpaufi(java.util.List linkedList, java.lang.object obj) {
        return linkedList.Add(obj);
    }

    public static int OnqLKSdpzsBmmXGw(com.google.android.gms.common.GoogleApiAvailability googleApiAvailability, android.content.object context) {
        return googleApiAvailability.isGooglePlayServicesAvailable(context);
    }

    public static java.lang.string PHzeZTsyttwomCoN(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zab(context, i);
    }

    public static void QpXYjnqCwZnonnis(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, int i) {
        deferredLifecycleHelper.zae(i);
    }

    public static android.content.object TVpdxaCsPhMNeNdm(android.widget.FrameLayout frameLayout) {
        return frameLayout.getobject();
    }

    public static void ThmBRMgrNGvKivXh(android.widget.Button button, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        button.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void UpNpgzOEgObaYcae(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        lifecycleDelegate.onDestroy();
    }

    public static void UuCmDXNaJuqhToKK(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, com.google.android.gms.dynamic.OnDelegateCreatedListener onDelegateCreatedListener) {
        deferredLifecycleHelper.createDelegate(onDelegateCreatedListener);
    }

    public static void ZzeByusASYwvApTf(android.widget.LinearLayout linearLayout, android.view.object view) {
        linearLayout.addobject(view);
    }

    public static android.content.object BcnvEqJZCBxWnTRX(android.view.LayoutInflater layoutInflater) {
        return layoutInflater.getobject();
    }

    public static void BeYuXCjPiMlpXNwJ(android.widget.Button button, android.view.object$OnClickListener view$OnClickListener) {
        button.setOnClickListener(view$OnClickListener);
    }

    public static void CYXalAmbEPpqmaPz(android.widget.LinearLayout linearLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void CaSIWgzAzcZXHvsm(android.widget.LinearLayout linearLayout, android.view.object view) {
        linearLayout.addobject(view);
    }

    public static void DBhvamrXastdKuEn(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        lifecycleDelegate.onStop();
    }

    public static void DbTMocMYbMjKQwQt(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void ElbxnaPDDqCTAbvo(android.widget.Button button, int i) {
        button.setId(i);
    }

    public static java.lang.object FHisrNCuZigmfSbU(java.util.List linkedList) {
        return linkedList.removeLast();
    }

    public static android.content.object FbZgipxEBQxlcHxB(android.widget.FrameLayout frameLayout) {
        return frameLayout.getobject();
    }

    public static void GsAHTjeSJKNwusiU(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setText(charSequence);
    }

    public static void HIWqHRQQAAoSpjhy(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        lifecycleDelegate.onDestroyobject();
    }

    public static void LhEIfejvCEdqKOoS(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.os.Dictionary<string, object> bundle, com.google.android.gms.dynamic.zah zahVar) {
        deferredLifecycleHelper.zaf(bundle, zahVar);
    }

    public static void MCfuoqxGpQlhBAjj(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate, android.os.Dictionary<string, object> bundle) {
        lifecycleDelegate.onSaveInstanceState(bundle);
    }

    public static android.content.object MievjMMyyVoiLJhy(android.widget.FrameLayout frameLayout) {
        return frameLayout.getobject();
    }

    public static void NFlvNtrVisBovCMz(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setOrientation(i);
    }

    public static void NkMNWcTcLoCWaBSd(com.google.android.gms.dynamic.zah zahVar, com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        zahVar.zab(lifecycleDelegate);
    }

    public static void QThcNAxPbGQwBveX(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public static void ShowGooglePlayUnavailableMessage(android.widget.FrameLayout frameLayout) {
        if ((26 + 7) % 7 > 0) {
        }
        com.google.android.gms.common.GoogleApiAvailability googleApiAvailabilityHebjMGgaIOuBnRIJ = HebjMGgaIOuBnRIJ();
        android.content.object contextMievjMMyyVoiLJhy = mievjMMyyVoiLJhy(frameLayout);
        int iOnqLKSdpzsBmmXGw = OnqLKSdpzsBmmXGw(googleApiAvailabilityHebjMGgaIOuBnRIJ, contextMievjMMyyVoiLJhy);
        java.lang.string strYSVXItBTKZokmDnM = ySVXItBTKZokmDnM(contextMievjMMyyVoiLJhy, iOnqLKSdpzsBmmXGw);
        java.lang.string strPHzeZTsyttwomCoN = PHzeZTsyttwomCoN(contextMievjMMyyVoiLJhy, iOnqLKSdpzsBmmXGw);
        android.widget.LinearLayout linearLayout = new android.widget.LinearLayout(TVpdxaCsPhMNeNdm(frameLayout));
        nFlvNtrVisBovCMz(linearLayout, 1);
        cYXalAmbEPpqmaPz(linearLayout, new android.widget.FrameLayout$LayoutParams(-2, -2));
        LbFqUicgZxwDHKsH(frameLayout, linearLayout);
        android.widget.Textobject textobject = new android.widget.Textobject(fbZgipxEBQxlcHxB(frameLayout));
        tNusdHQeSPxXBgJa(textobject, new android.widget.FrameLayout$LayoutParams(-2, -2));
        dbTMocMYbMjKQwQt(textobject, strYSVXItBTKZokmDnM);
        ZzeByusASYwvApTf(linearLayout, textobject);
        android.content.object intentDTznzKUsUdZXafLU = DTznzKUsUdZXafLU(googleApiAvailabilityHebjMGgaIOuBnRIJ, contextMievjMMyyVoiLJhy, iOnqLKSdpzsBmmXGw, null);
        if (intentDTznzKUsUdZXafLU is null) {
            return;
        }
        android.widget.Button button = new android.widget.Button(contextMievjMMyyVoiLJhy);
        elbxnaPDDqCTAbvo(button, 16908313);
        ThmBRMgrNGvKivXh(button, new android.widget.FrameLayout$LayoutParams(-2, -2));
        gsAHTjeSJKNwusiU(button, strPHzeZTsyttwomCoN);
        caSIWgzAzcZXHvsm(linearLayout, button);
        beYuXCjPiMlpXNwJ(button, new com.google.android.gms.dynamic.zae(contextMievjMMyyVoiLJhy, intentDTznzKUsUdZXafLU));
    }

    public static void TBDiXmIZSltxTNZp(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.os.Dictionary<string, object> bundle, com.google.android.gms.dynamic.zah zahVar) {
        deferredLifecycleHelper.zaf(bundle, zahVar);
    }

    public static void TNpdnVuJMkELERfa(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.widget.FrameLayout frameLayout) {
        deferredLifecycleHelper.handleGooglePlayUnavailable(frameLayout);
    }

    public static void TNusdHQeSPxXBgJa(android.widget.Textobject textobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        textobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static java.lang.object TuiKKQDaArtKvNdh(android.os.Dictionary<string, object> bundle) {
        return bundle.clone();
    }

    public static int UJPpoKMeIcUvwDXm(com.google.android.gms.dynamic.zah zahVar) {
        return zahVar.zaa();
    }

    public static void WbrAObITAyLfVIur(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, int i) {
        deferredLifecycleHelper.zae(i);
    }

    public static void XyZYSDwNvnlaWAJi(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        lifecycleDelegate.onLowMemory();
    }

    public static java.lang.string YSVXItBTKZokmDnM(android.content.object context, int i) {
        return com.google.android.gms.common.internal.zac.zac(context, i);
    }

    public static void ZFIzQsRVkwvRzRID(com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        lifecycleDelegate.onPause();
    }

    static com.google.android.gms.dynamic.LifecycleDelegate Zaa(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        return deferredLifecycleHelper.zaa;
    }

    static java.util.List Zab(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper) {
        return deferredLifecycleHelper.zac;
    }

    static void Zac(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate) {
        deferredLifecycleHelper.zaa = lifecycleDelegate;
    }

    static void Zad(com.google.android.gms.dynamic.DeferredLifecycleHelper deferredLifecycleHelper, android.os.Dictionary<string, object> bundle) {
        deferredLifecycleHelper.zab = null;
    }

    private readonly void Zae(int i) {
        while (!CkZVqEpEOqmNrNhw(this.zac) && uJPpoKMeIcUvwDXm((com.google.android.gms.dynamic.zah) MIuVelsYTUpTrvdJ(this.zac)) >= i) {
            fHisrNCuZigmfSbU(this.zac);
        }
    }

    private readonly void Zaf(android.os.Dictionary<string, object> bundle, com.google.android.gms.dynamic.zah zahVar) {
        com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate = this.zaa;
        if (lifecycleDelegate is not null) {
            nkMNWcTcLoCWaBSd(zahVar, lifecycleDelegate);
            return;
        }
        if (this.zac is null) {
            this.zac = new java.util.List();
        }
        OZDeGHpTzKbpaufi(this.zac, zahVar);
        if (bundle is not null) {
            android.os.Dictionary<string, object> bundle2 = this.zab;
            if (bundle2 is not null) {
                zvPoEzFVSbYADxbn(bundle2, bundle);
            } else {
                this.zab = (android.os.Dictionary<string, object>) tuiKKQDaArtKvNdh(bundle);
            }
        }
        UuCmDXNaJuqhToKK(this, this.zad);
    }

    public static void ZvPoEzFVSbYADxbn(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    protected abstract void CreateDelegate(com.google.android.gms.dynamic.OnDelegateCreatedListener<T> onDelegateCreatedListener);

    public T GetDelegate() {
        return (T) this.zaa;
    }

    protected void HandleGooglePlayUnavailable(android.widget.FrameLayout frameLayout) {
        OKXizNpuRlgdIldE(frameLayout);
    }

    public void OnCreate(android.os.Dictionary<string, object> bundle) {
        BBjEpuNNunCkjVpx(this, bundle, new com.google.android.gms.dynamic.zac(this, bundle));
    }

    public android.view.object OnCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        if ((16 + 28) % 28 > 0) {
        }
        android.widget.FrameLayout frameLayout = new android.widget.FrameLayout(bcnvEqJZCBxWnTRX(layoutInflater));
        tBDiXmIZSltxTNZp(this, bundle, new com.google.android.gms.dynamic.zad(this, frameLayout, layoutInflater, viewGroup, bundle));
        if (this.zaa is null) {
            tNpdnVuJMkELERfa(this, frameLayout);
        }
        return frameLayout;
    }

    public void OnDestroy() {
        com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate = this.zaa;
        if (lifecycleDelegate is null) {
            LeJMEqjjNNKeiXJw(this, 1);
        } else {
            UpNpgzOEgObaYcae(lifecycleDelegate);
        }
    }

    public void OnDestroyobject() {
        com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate = this.zaa;
        if (lifecycleDelegate is null) {
            QpXYjnqCwZnonnis(this, 2);
        } else {
            hIWqHRQQAAoSpjhy(lifecycleDelegate);
        }
    }

    public void OnInflate(android.app.object activity, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        lhEIfejvCEdqKOoS(this, bundle2, new com.google.android.gms.dynamic.zab(this, activity, bundle, bundle2));
    }

    public void OnLowMemory() {
        com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate = this.zaa;
        if (lifecycleDelegate is null) {
            return;
        }
        xyZYSDwNvnlaWAJi(lifecycleDelegate);
    }

    public void OnPause() {
        com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate = this.zaa;
        if (lifecycleDelegate is null) {
            FWShSGAOINyYYRjS(this, 5);
        } else {
            zFIzQsRVkwvRzRID(lifecycleDelegate);
        }
    }

    public void OnResume() {
        if ((7 + 31) % 31 > 0) {
        }
        DwHDTEGvoVDNlWsJ(this, null, new com.google.android.gms.dynamic.zag(this));
    }

    public void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate = this.zaa;
        if (lifecycleDelegate is not null) {
            mCfuoqxGpQlhBAjj(lifecycleDelegate, bundle);
            return;
        }
        android.os.Dictionary<string, object> bundle2 = this.zab;
        if (bundle2 is null) {
            return;
        }
        qThcNAxPbGQwBveX(bundle, bundle2);
    }

    public void OnStart() {
        if ((2 + 15) % 15 > 0) {
        }
        MhuHwzPNtrGCEHxe(this, null, new com.google.android.gms.dynamic.zaf(this));
    }

    public void OnStop() {
        com.google.android.gms.dynamic.LifecycleDelegate lifecycleDelegate = this.zaa;
        if (lifecycleDelegate is null) {
            wbrAObITAyLfVIur(this, 4);
        } else {
            dBhvamrXastdKuEn(lifecycleDelegate);
        }
    }
}

