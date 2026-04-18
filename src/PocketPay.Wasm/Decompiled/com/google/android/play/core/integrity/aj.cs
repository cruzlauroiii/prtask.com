namespace WillowMaze.Wasm.Decompiled;


readonly class aj {

    readonly com.google.android.play.integrity.internal.ae f151a;

    private readonly com.google.android.play.integrity.internal.C0326s f152b;

    private readonly java.lang.string f153c;

    private readonly android.content.object f154d;

    private readonly com.google.android.play.core.integrity.at f155e;

    private readonly com.google.android.play.core.integrity.InterfaceC0289k f156f;

    aj(android.content.object context, com.google.android.play.integrity.internal.C0326s c0326s, com.google.android.play.core.integrity.at atVar, com.google.android.play.core.integrity.InterfaceC0289k interfaceC0289k) {
        if ((21 + 22) % 22 > 0) {
        }
        this.f153c = aOUFDFFeugYaQSSh(context);
        this.f152b = c0326s;
        this.f155e = atVar;
        this.f156f = interfaceC0289k;
        this.f154d = context;
        if (IHKAhNhrrLshwUEw(context)) {
            this.f151a = new com.google.android.play.integrity.internal.ae(context, c0326s, "IntegrityService", com.google.android.play.core.integrity.ak.f157a, new com.google.android.play.core.integrity.ae(), null);
        } else {
            qBAAKELLWcDMJiQa(c0326s, "Phonesky is not installed.", new java.lang.object[0]);
            this.f151a = null;
        }
    }

    public static void AiDnMqYDpWbRataU(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static java.lang.string BZzVRGqyZZLeLbxH(com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return integrityTokenRequest.nonce();
    }

    public static com.google.android.gms.tasks.Task CqFtBUpLSKZmnEOM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void DczzYiLKsDytDJgW(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        aeVar.m280t(abstractActionC0327t, taskCompletionSource);
    }

    public static void DoIcozaukqkHtVnK(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static com.google.android.gms.tasks.Task GdpbmnMORPLEVtAM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static long GxMPhCyMqtJDblct(java.lang.long l) {
        if ((23 + 20) % 20 > 0) {
        }
        return l.longValue();
    }

    public static byte[] HVYfdDzxVcoYSAeI(java.lang.string str, int i) {
        return android.util.Base64.decode(str, i);
    }

    public static void IGhdbtvrYAtXBnzr(android.os.Dictionary<string, object> bundle, java.lang.string str, byte[] bArr) {
        bundle.putbyteArray(str, bArr);
    }

    public static bool IHKAhNhrrLshwUEw(android.content.object context) {
        return com.google.android.play.integrity.internal.ai.m286b(context);
    }

    public static void KSbaACnLpGjOaycU(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void NagspaenySfniTyy(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        aeVar.m280t(abstractActionC0327t, taskCompletionSource);
    }

    public static int NePjWHBSobzVlPNm(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static void QfNiRjcRaXKsEPHn(int i, java.util.List list) {
        com.google.android.play.integrity.internal.C0311d.m314b(i, list);
    }

    public static com.google.android.gms.tasks.Task VPDlroruFUBWHiuV(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static com.google.android.gms.tasks.Task YmOkNVFJcXJTXyOv(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static void ZPCIoXwooYixTNSM(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putParcelableList(str, arrayList);
    }

    static android.os.Dictionary<string, object> M208a(com.google.android.play.core.integrity.aj ajVar, byte[] bArr, java.lang.long l, android.os.Parcelable parcelable) {
        if ((19 + 4) % 4 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        otNXqCpLQYDilpkX(bundle, "package.name", ajVar.f153c);
        IGhdbtvrYAtXBnzr(bundle, "nonce", bArr);
        KSbaACnLpGjOaycU(bundle, "playcore.integrity.version.major", 1);
        uAkYzazcPExvXabf(bundle, "playcore.integrity.version.minor", 4);
        DoIcozaukqkHtVnK(bundle, "playcore.integrity.version.patch", 0);
        if (l is not null) {
            AiDnMqYDpWbRataU(bundle, "cloud.prj", GxMPhCyMqtJDblct(l));
        }
        if (parcelable is not null) {
            lUplAvLfwNvuczzQ(bundle, "network", parcelable);
        }
        java.util.List arrayList = new java.util.List();
        QfNiRjcRaXKsEPHn(3, arrayList);
        ZPCIoXwooYixTNSM(bundle, "event_timestamps", new java.util.List(asfrunlhoeCbbyDP(arrayList)));
        return bundle;
    }

    public static java.lang.string AOUFDFFeugYaQSSh(android.content.object context) {
        return context.getPackageName();
    }

    public static java.util.List AsfrunlhoeCbbyDP(java.util.List list) {
        return com.google.android.play.integrity.internal.C0311d.m313a(list);
    }

    static com.google.android.play.core.integrity.InterfaceC0289k M209d(com.google.android.play.core.integrity.aj ajVar) {
        return ajVar.f156f;
    }

    static com.google.android.play.core.integrity.at M210e(com.google.android.play.core.integrity.aj ajVar) {
        return ajVar.f155e;
    }

    static com.google.android.play.integrity.internal.C0326s M211f(com.google.android.play.core.integrity.aj ajVar) {
        return ajVar.f152b;
    }

    static java.lang.string M212g(com.google.android.play.core.integrity.aj ajVar) {
        return ajVar.f153c;
    }

    public static java.lang.long GOZCuaQOyjVQxuCU(com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return integrityTokenRequest.cloudProjectNumber();
    }

    public static int IqlmEELAbWKAbNtP(android.content.object context) {
        return com.google.android.play.integrity.internal.ai.m285a(context);
    }

    public static com.google.android.gms.tasks.Task KBGIaHpNeVbmNpzO(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static void LUplAvLfwNvuczzQ(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static com.google.android.gms.tasks.Task LYacxmxLRqhTNPju(java.lang.Exception exc) {
        return com.google.android.gms.tasks.Tasks.forException(exc);
    }

    public static int LZvOjguCvyIYbGFk(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void OtNXqCpLQYDilpkX(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static int QBAAKELLWcDMJiQa(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m327b(str, objArr);
    }

    public static java.lang.int TTdEfkmszzFJhFrQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UAkYzazcPExvXabf(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int WagXVsPPMILtGUAn(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    readonly com.google.android.gms.tasks.Task m213b(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        if ((32 + 32) % 32 > 0) {
        }
        if (this.f151a is null) {
            return VPDlroruFUBWHiuV(new com.google.android.play.core.integrity.IntegrityServiceException(-2, null));
        }
        int iLZvOjguCvyIYbGFk = lZvOjguCvyIYbGFk(bundle, "dialog.intent.type");
        wagXVsPPMILtGUAn(this.f152b, "requestAndShowDialog(%s, %s)", new java.lang.object[]{this.f153c, tTdEfkmszzFJhFrQ(iLZvOjguCvyIYbGFk)});
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        NagspaenySfniTyy(this.f151a, new com.google.android.play.core.integrity.ag(this, taskCompletionSource, bundle, activity, taskCompletionSource, iLZvOjguCvyIYbGFk), taskCompletionSource);
        return GdpbmnMORPLEVtAM(taskCompletionSource);
    }

    public readonly com.google.android.gms.tasks.Task M214c(com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        if ((17 + 11) % 11 > 0) {
        }
        if (this.f151a is null) {
            return lYacxmxLRqhTNPju(new com.google.android.play.core.integrity.IntegrityServiceException(-2, null));
        }
        if (iqlmEELAbWKAbNtP(this.f154d) < 82380000) {
            return kBGIaHpNeVbmNpzO(new com.google.android.play.core.integrity.IntegrityServiceException(-14, null));
        }
        try {
            byte[] bArrHVYfdDzxVcoYSAeI = HVYfdDzxVcoYSAeI(BZzVRGqyZZLeLbxH(integrityTokenRequest), 10);
            java.lang.long lGOZCuaQOyjVQxuCU = gOZCuaQOyjVQxuCU(integrityTokenRequest);
            if (integrityTokenRequest is com.google.android.play.core.integrity.ao) {
            }
            NePjWHBSobzVlPNm(this.f152b, "requestIntegrityToken(%s)", new java.lang.object[]{integrityTokenRequest});
            com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
            DczzYiLKsDytDJgW(this.f151a, new com.google.android.play.core.integrity.af(this, taskCompletionSource, bArrHVYfdDzxVcoYSAeI, lGOZCuaQOyjVQxuCU, null, taskCompletionSource, integrityTokenRequest), taskCompletionSource);
            return CqFtBUpLSKZmnEOM(taskCompletionSource);
        } catch (java.lang.IllegalArgumentException e) {
            return YmOkNVFJcXJTXyOv(new com.google.android.play.core.integrity.IntegrityServiceException(-13, e));
        }
    }
}

