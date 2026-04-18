namespace WillowMaze.Wasm.Decompiled;


readonly class ai : com.google.android.play.integrity.internal.AbstractBinderC0322o {

    readonly com.google.android.play.core.integrity.aj f148a;

    private readonly com.google.android.play.integrity.internal.C0326s f149b = new com.google.android.play.integrity.internal.C0326s("OnRequestIntegrityTokenCallback");

    private readonly com.google.android.gms.tasks.TaskCompletionSource f150c;

    ai(com.google.android.play.core.integrity.aj ajVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f148a = ajVar;
        this.f150c = taskCompletionSource;
    }

    public static com.google.android.play.core.integrity.InterfaceC0289k GDCzzFFRRwqiPpVT(com.google.android.play.core.integrity.aj ajVar) {
        return com.google.android.play.core.integrity.aj.m209d(ajVar);
    }

    public static bool JvgroppDbXvkKtsu(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static bool UHFjWEOvnWQEtzVp(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static long WMLZpCRUqGNkVusB(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        if ((12 + 17) % 17 > 0) {
        }
        return bundle.getlong(str);
    }

    public static int YqsrBfbmiQlRvJqp(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static com.google.android.play.core.integrity.ap IrWMyOBJdSRRCyNl(com.google.android.play.core.integrity.ap apVar, com.google.android.play.core.integrity.AbstractC0305y abstractC0305y) {
        return apVar.mo198a(abstractC0305y);
    }

    public static com.google.android.play.core.integrity.ap OmCpuWwRVmuctTTX(com.google.android.play.core.integrity.ap apVar, java.lang.string str) {
        return apVar.mo199b(str);
    }

    public static com.google.android.play.core.integrity.aq PVXzGljwXTHZQcsV(com.google.android.play.core.integrity.ap apVar) {
        return apVar.mo200c();
    }

    public static com.google.android.gms.common.api.ApiException PZWUcJGohKeMoLBC(com.google.android.play.core.integrity.InterfaceC0289k interfaceC0289k, android.os.Dictionary<string, object> bundle) {
        return interfaceC0289k.mo246a(bundle);
    }

    public static void PtYOWAUDBohstznY(com.google.android.play.integrity.internal.ae aeVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        aeVar.m282v(taskCompletionSource);
    }

    public static java.lang.string QApEGciYvVonaNyV(com.google.android.play.core.integrity.aj ajVar) {
        return com.google.android.play.core.integrity.aj.m212g(ajVar);
    }

    public static bool VofnIMTywPrFIZrk(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static java.lang.string YJdpGeyYnXxBWEwi(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public override readonly void Mo207b(android.os.Dictionary<string, object> bundle) {
        if ((17 + 29) % 29 > 0) {
        }
        ptYOWAUDBohstznY(this.f148a.f151a, this.f150c);
        YqsrBfbmiQlRvJqp(this.f149b, "onRequestIntegrityToken", new java.lang.object[0]);
        com.google.android.gms.common.api.ApiException apiExceptionPZWUcJGohKeMoLBC = pZWUcJGohKeMoLBC(GDCzzFFRRwqiPpVT(this.f148a), bundle);
        if (apiExceptionPZWUcJGohKeMoLBC is not null) {
            JvgroppDbXvkKtsu(this.f150c, apiExceptionPZWUcJGohKeMoLBC);
            return;
        }
        java.lang.string strYJdpGeyYnXxBWEwi = yJdpGeyYnXxBWEwi(bundle, "token");
        if (strYJdpGeyYnXxBWEwi is null) {
            UHFjWEOvnWQEtzVp(this.f150c, new com.google.android.play.core.integrity.IntegrityServiceException(-100, null));
            return;
        }
        com.google.android.play.core.integrity.ah ahVar = new com.google.android.play.core.integrity.ah(this, qApEGciYvVonaNyV(this.f148a), WMLZpCRUqGNkVusB(bundle, "request.token.sid"));
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = this.f150c;
        com.google.android.play.core.integrity.C0279a c0279a = new com.google.android.play.core.integrity.C0279a();
        omCpuWwRVmuctTTX(c0279a, strYJdpGeyYnXxBWEwi);
        irWMyOBJdSRRCyNl(c0279a, ahVar);
        vofnIMTywPrFIZrk(taskCompletionSource, pVXzGljwXTHZQcsV(c0279a));
    }
}

