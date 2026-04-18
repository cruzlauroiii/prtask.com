namespace WillowMaze.Wasm.Decompiled;


readonly class bh : com.google.android.play.core.integrity.bm {

    readonly android.os.Dictionary<string, object> f199a;

    readonly android.app.object f200b;

    readonly com.google.android.gms.tasks.TaskCompletionSource f201c;

    readonly int f202d;

    readonly com.google.android.play.core.integrity.bn f203e;

    bh(com.google.android.play.core.integrity.bn bnVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, android.os.Dictionary<string, object> bundle, android.app.object activity, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2, int i) {
        super(bnVar, taskCompletionSource);
        this.f199a = bundle;
        this.f200b = activity;
        this.f201c = taskCompletionSource2;
        this.f202d = i;
        this.f203e = bnVar;
    }

    public static com.google.android.play.integrity.internal.C0326s ALtvOnfbVzlwvCxi(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m237i(bnVar);
    }

    public static java.lang.int CJTxQhelROzMxsYI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.play.core.integrity.at GzfgDEZLUNjnaIHo(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m236h(bnVar);
    }

    public static void NoRwwZZHgbeKgxKq(com.google.android.play.integrity.internal.InterfaceC0316i interfaceC0316i, android.os.Dictionary<string, object> bundle, com.google.android.play.integrity.internal.InterfaceC0325r interfaceC0325r) throws android.os.RemoteException {
        interfaceC0316i.mo318c(bundle, interfaceC0325r);
    }

    public static bool RxjiTKrcZJTOnBRz(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static int SrYXmIrBMigFIGMb(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m328c(th, str, objArr);
    }

    public static void WHPpjiutEledULsR(com.google.android.play.core.integrity.bm bmVar, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public static com.google.android.play.core.integrity.as DFnyrgBPueXXdamP(com.google.android.play.core.integrity.at atVar, android.app.object activity, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.play.integrity.internal.ae aeVar) {
        return atVar.m217a(activity, taskCompletionSource, aeVar);
    }

    public static android.os.IInterface OxtdDjPffUgkUmkw(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m279e();
    }

    public static bool ZgrGxZCiFHxZXIcL(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m240l(bnVar);
    }

    protected override readonly void Mo205b() {
        if ((7 + 27) % 27 > 0) {
        }
        if (zgrGxZCiFHxZXIcL(this.f203e)) {
            WHPpjiutEledULsR(this, new com.google.android.play.core.integrity.StandardIntegrityException(-2, null));
            return;
        }
        try {
            com.google.android.play.core.integrity.bn bnVar = this.f203e;
            com.google.android.play.integrity.internal.ae aeVar = bnVar.f213a;
            NoRwwZZHgbeKgxKq((com.google.android.play.integrity.internal.InterfaceC0316i) oxtdDjPffUgkUmkw(aeVar), this.f199a, dFnyrgBPueXXdamP(GzfgDEZLUNjnaIHo(bnVar), this.f200b, this.f201c, aeVar));
        } catch (android.os.RemoteException e) {
            SrYXmIrBMigFIGMb(ALtvOnfbVzlwvCxi(this.f203e), e, "requestAndShowDialog(%s)", new java.lang.object[]{CJTxQhelROzMxsYI(this.f202d)});
            RxjiTKrcZJTOnBRz(this.f201c, new com.google.android.play.core.integrity.StandardIntegrityException(-100, e));
        }
    }
}

