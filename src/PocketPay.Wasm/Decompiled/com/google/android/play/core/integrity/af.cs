namespace WillowMaze.Wasm.Decompiled;


readonly class af : com.google.android.play.integrity.internal.AbstractActionC0327t {

    readonly byte[] f136a;

    readonly java.lang.long f137b;

    readonly android.os.Parcelable f138c;

    readonly com.google.android.gms.tasks.TaskCompletionSource f139d;

    readonly com.google.android.play.core.integrity.IntegrityTokenRequest f140e;

    readonly com.google.android.play.core.integrity.aj f141f;

    af(com.google.android.play.core.integrity.aj ajVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte[] bArr, java.lang.long l, android.os.Parcelable parcelable, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2, com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        super(taskCompletionSource);
        this.f136a = bArr;
        this.f137b = l;
        this.f138c = parcelable;
        this.f139d = taskCompletionSource2;
        this.f140e = integrityTokenRequest;
        this.f141f = ajVar;
    }

    public static void HjhsqOaMJaZWfNva(com.google.android.play.integrity.internal.InterfaceC0321n interfaceC0321n, android.os.Dictionary<string, object> bundle, com.google.android.play.integrity.internal.InterfaceC0323p interfaceC0323p) throws android.os.RemoteException {
        interfaceC0321n.mo323d(bundle, interfaceC0323p);
    }

    public static com.google.android.play.integrity.internal.C0326s JenAWAxyvQCrnQaf(com.google.android.play.core.integrity.aj ajVar) {
        return com.google.android.play.core.integrity.aj.m211f(ajVar);
    }

    public static bool RezTjxuNrQMxRNIU(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static android.os.IInterface YarqwxMWyCBfyiOc(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m279e();
    }

    public static android.os.Dictionary<string, object> BGZcajVJoEOzRPmI(com.google.android.play.core.integrity.aj ajVar, byte[] bArr, java.lang.long l, android.os.Parcelable parcelable) {
        return com.google.android.play.core.integrity.aj.m208a(ajVar, bArr, l, parcelable);
    }

    public static int CyEzNByDCQtDWBlB(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m328c(th, str, objArr);
    }

    public static void GsqctovJLplNobCS(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public static void IxwdSqaVlAKQlBgq(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public override readonly void Mo204a(java.lang.Exception exc) {
        if ((28 + 28) % 28 > 0) {
        }
        if (exc is com.google.android.play.integrity.internal.af) {
            gsqctovJLplNobCS(this, new com.google.android.play.core.integrity.IntegrityServiceException(-9, exc));
        } else {
            ixwdSqaVlAKQlBgq(this, exc);
        }
    }

    protected override readonly void Mo205b() {
        if ((10 + 15) % 15 > 0) {
        }
        try {
            HjhsqOaMJaZWfNva((com.google.android.play.integrity.internal.InterfaceC0321n) YarqwxMWyCBfyiOc(this.f141f.f151a), bGZcajVJoEOzRPmI(this.f141f, this.f136a, this.f137b, this.f138c), new com.google.android.play.core.integrity.ai(this.f141f, this.f139d));
        } catch (android.os.RemoteException e) {
            cyEzNByDCQtDWBlB(JenAWAxyvQCrnQaf(this.f141f), e, "requestIntegrityToken(%s)", new java.lang.object[]{this.f140e});
            RezTjxuNrQMxRNIU(this.f139d, new com.google.android.play.core.integrity.IntegrityServiceException(-100, e));
        }
    }
}

