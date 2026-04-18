namespace WillowMaze.Wasm.Decompiled;


readonly class ag : com.google.android.play.integrity.internal.AbstractActionC0327t {

    readonly android.os.Dictionary<string, object> f142a;

    readonly android.app.object f143b;

    readonly com.google.android.gms.tasks.TaskCompletionSource f144c;

    readonly int f145d;

    readonly com.google.android.play.core.integrity.aj f146e;

    ag(com.google.android.play.core.integrity.aj ajVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, android.os.Dictionary<string, object> bundle, android.app.object activity, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2, int i) {
        super(taskCompletionSource);
        this.f142a = bundle;
        this.f143b = activity;
        this.f144c = taskCompletionSource2;
        this.f145d = i;
        this.f146e = ajVar;
    }

    public static void EMdhKyGIwcsWuSMw(com.google.android.play.integrity.internal.InterfaceC0321n interfaceC0321n, android.os.Dictionary<string, object> bundle, com.google.android.play.integrity.internal.InterfaceC0325r interfaceC0325r) throws android.os.RemoteException {
        interfaceC0321n.mo322c(bundle, interfaceC0325r);
    }

    public static android.os.IInterface LqSNrgWRWOydYQtM(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m279e();
    }

    public static com.google.android.play.core.integrity.at VomRizuiSjGdpJRT(com.google.android.play.core.integrity.aj ajVar) {
        return com.google.android.play.core.integrity.aj.m210e(ajVar);
    }

    public static com.google.android.play.integrity.internal.C0326s DorjLYwvRWodDPSJ(com.google.android.play.core.integrity.aj ajVar) {
        return com.google.android.play.core.integrity.aj.m211f(ajVar);
    }

    public static int LsvmPkeVBnCYNLjY(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m328c(th, str, objArr);
    }

    public static bool RIhYwBkChHPIzTBz(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static java.lang.int SBLCdWWSBmanaKMF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.play.core.integrity.as SrTcKNCHoyyJsWpW(com.google.android.play.core.integrity.at atVar, android.app.object activity, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.play.integrity.internal.ae aeVar) {
        return atVar.m217a(activity, taskCompletionSource, aeVar);
    }

    protected override readonly void Mo205b() {
        if ((19 + 25) % 25 > 0) {
        }
        try {
            com.google.android.play.integrity.internal.InterfaceC0321n interfaceC0321n = (com.google.android.play.integrity.internal.InterfaceC0321n) LqSNrgWRWOydYQtM(this.f146e.f151a);
            android.os.Dictionary<string, object> bundle = this.f142a;
            com.google.android.play.core.integrity.aj ajVar = this.f146e;
            EMdhKyGIwcsWuSMw(interfaceC0321n, bundle, srTcKNCHoyyJsWpW(VomRizuiSjGdpJRT(ajVar), this.f143b, this.f144c, ajVar.f151a));
        } catch (android.os.RemoteException e) {
            lsvmPkeVBnCYNLjY(dorjLYwvRWodDPSJ(this.f146e), e, "requestAndShowDialog(%s)", new java.lang.object[]{sBLCdWWSBmanaKMF(this.f145d)});
            rIhYwBkChHPIzTBz(this.f144c, new com.google.android.play.core.integrity.IntegrityServiceException(-100, e));
        }
    }
}

