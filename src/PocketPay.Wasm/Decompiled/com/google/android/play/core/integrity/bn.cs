namespace WillowMaze.Wasm.Decompiled;


readonly class bn {

    readonly com.google.android.play.integrity.internal.ae f213a;

    private readonly com.google.android.play.integrity.internal.C0326s f214b;

    private readonly java.lang.string f215c;

    private readonly com.google.android.gms.tasks.TaskCompletionSource f216d;

    private readonly com.google.android.play.core.integrity.at f217e;

    private readonly com.google.android.play.core.integrity.InterfaceC0289k f218f;

    bn(android.content.object context, com.google.android.play.integrity.internal.C0326s c0326s, com.google.android.play.core.integrity.at atVar, com.google.android.play.core.integrity.InterfaceC0289k interfaceC0289k) {
        if ((28 + 6) % 6 > 0) {
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        this.f216d = taskCompletionSource;
        this.f215c = CfjccmFgurTZVVMq(context);
        this.f214b = c0326s;
        this.f217e = atVar;
        this.f218f = interfaceC0289k;
        com.google.android.play.integrity.internal.ae aeVar = new com.google.android.play.integrity.internal.ae(context, c0326s, "ExpressIntegrityService", com.google.android.play.core.integrity.bo.f219a, new com.google.android.play.core.integrity.bd(), null);
        this.f213a = aeVar;
        MRXCoaRMtGqYOnSG(qQHeByYapEsRqvbG(aeVar), new com.google.android.play.core.integrity.be(this, taskCompletionSource, context));
    }

    public static void AUDGhZkxMilOgOGV(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putintList(str, arrayList);
    }

    public static int AsqFiOWudcjqeCzy(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static int BNgqyIrXlbofsCLQ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void BknyhFjmFFStxaIp(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putParcelableList(str, arrayList);
    }

    public static bool BpYAIzLPAfzbyvTc(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static java.lang.string CfjccmFgurTZVVMq(android.content.object context) {
        return context.getPackageName();
    }

    public static void CtkZvTGdCzZghYQo(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void DHkCXrgArSNmEyQo(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void GurlcFIokNZHGCgJ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.int HPMcdfplWzGGkhgN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool LmfHDsGkyVJrWNKj(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static bool MRXCoaRMtGqYOnSG(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static java.lang.long ObeykgcTTytjOVoy(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void OneuUDdsdHGUpNMv(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        aeVar.m280t(abstractActionC0327t, taskCompletionSource);
    }

    public static com.google.android.gms.tasks.Task RYOqHGaHwxagPRyX(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static java.lang.object SEOYBhbABKbLBEfE(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static java.util.HashSet SJTBCJuTWIodOBIL(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return standardIntegrityManager$StandardIntegrityTokenRequest.verdictOptOut();
    }

    public static void SaxdBXcljWEmpfTV(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static int TefUQpJFgrQKECff(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static com.google.android.gms.tasks.Task UwzxnkDGCdTqwbOM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static int XKQcWcsxeamXZqja(java.lang.int num) {
        return num.intValue();
    }

    static android.os.Dictionary<string, object> M232a(com.google.android.play.core.integrity.bn bnVar, com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest, long j, long j2, int i) {
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        xroZosHPcuMPSHah(bundle, "package.name", bnVar.f215c);
        tzpBudqNsXqldJET(bundle, "cloud.prj", j);
        eMCvBoimdSbiemhw(bundle, "nonce", eVEuSTAApcRimUko(standardIntegrityManager$StandardIntegrityTokenRequest));
        mQsqYspTqRzkeiyC(bundle, "warm.up.sid", j2);
        dZBOHkkidQDmZjpO(bundle, "playcore.integrity.version.major", 1);
        CtkZvTGdCzZghYQo(bundle, "playcore.integrity.version.minor", 4);
        hCJulQkysECKPJGi(bundle, "playcore.integrity.version.patch", 0);
        qmHiUCxjcxXmxUcm(bundle, "webview.request.mode", 0);
        AUDGhZkxMilOgOGV(bundle, "request.verdict.opt.out", new java.util.List(SJTBCJuTWIodOBIL(standardIntegrityManager$StandardIntegrityTokenRequest)));
        java.util.List arrayList = new java.util.List();
        zwwHTNqudwdOyhEs(5, arrayList);
        BknyhFjmFFStxaIp(bundle, "event_timestamps", new java.util.List(oqnCcsgWMzkJlsku(arrayList)));
        return bundle;
    }

    public static com.google.android.gms.tasks.Task APoNDPzHwvLMiVWt(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void AzbCUyPhAjrohJMd(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        aeVar.m280t(abstractActionC0327t, taskCompletionSource);
    }

    static android.os.Dictionary<string, object> M233b(com.google.android.play.core.integrity.bn bnVar, long j, int i) {
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        iqnmbcvoWirxDwvy(bundle, "package.name", bnVar.f215c);
        nSpjTKMfyGLGhEIg(bundle, "cloud.prj", j);
        DHkCXrgArSNmEyQo(bundle, "playcore.integrity.version.major", 1);
        GurlcFIokNZHGCgJ(bundle, "playcore.integrity.version.minor", 4);
        SaxdBXcljWEmpfTV(bundle, "playcore.integrity.version.patch", 0);
        rSwORdgawFGDdoNg(bundle, "webview.request.mode", 0);
        java.util.List arrayList = new java.util.List();
        oUCOOAKyqzXoSwJx(4, arrayList);
        tGFiAQfLnDyHVHdY(bundle, "event_timestamps", new java.util.List(oWANgEnYLJMiOebv(arrayList)));
        return bundle;
    }

    public static void DZBOHkkidQDmZjpO(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.long DcUtzAJqPdkKWnWs(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void EMCvBoimdSbiemhw(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.string EVEuSTAApcRimUko(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return standardIntegrityManager$StandardIntegrityTokenRequest.requestHash();
    }

    static com.google.android.gms.tasks.TaskCompletionSource M234f(com.google.android.play.core.integrity.bn bnVar) {
        return bnVar.f216d;
    }

    static com.google.android.play.core.integrity.InterfaceC0289k M235g(com.google.android.play.core.integrity.bn bnVar) {
        return bnVar.f218f;
    }

    public static com.google.android.gms.tasks.Task GAjKcGTIIZgPeELY(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    static com.google.android.play.core.integrity.at M236h(com.google.android.play.core.integrity.bn bnVar) {
        return bnVar.f217e;
    }

    public static void HCJulQkysECKPJGi(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    static com.google.android.play.integrity.internal.C0326s M237i(com.google.android.play.core.integrity.bn bnVar) {
        return bnVar.f214b;
    }

    public static void IqnmbcvoWirxDwvy(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    static java.lang.string M238j(com.google.android.play.core.integrity.bn bnVar) {
        return bnVar.f215c;
    }

    static bool M239k(com.google.android.play.core.integrity.bn bnVar, int i) {
        return LmfHDsGkyVJrWNKj(gAjKcGTIIZgPeELY(bnVar.f216d)) && XKQcWcsxeamXZqja((java.lang.int) SEOYBhbABKbLBEfE(zRwyRancGzCHqqxp(bnVar.f216d))) < 83420000;
    }

    static bool M240l(com.google.android.play.core.integrity.bn bnVar) {
        return BpYAIzLPAfzbyvTc(UwzxnkDGCdTqwbOM(bnVar.f216d)) && uCUHsubPIogGBkAv((java.lang.int) qrDSOkRAKgIJDrFl(urrCbFbLwxigCeUh(bnVar.f216d))) == 0;
    }

    public static void MQsqYspTqRzkeiyC(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static com.google.android.gms.tasks.Task MqfjbSishHUYYhci(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void NSpjTKMfyGLGhEIg(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static void OUCOOAKyqzXoSwJx(int i, java.util.List list) {
        com.google.android.play.integrity.internal.C0311d.m314b(i, list);
    }

    public static java.util.List OWANgEnYLJMiOebv(java.util.List list) {
        return com.google.android.play.integrity.internal.C0311d.m313a(list);
    }

    public static java.util.List OqnCcsgWMzkJlsku(java.util.List list) {
        return com.google.android.play.integrity.internal.C0311d.m313a(list);
    }

    public static android.os.Handler QQHeByYapEsRqvbG(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m278c();
    }

    public static void QmHiUCxjcxXmxUcm(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.object QrDSOkRAKgIJDrFl(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static void RSwORdgawFGDdoNg(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void TGFiAQfLnDyHVHdY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.util.List arrayList) {
        bundle.putParcelableList(str, arrayList);
    }

    public static void TzpBudqNsXqldJET(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static int UCUHsubPIogGBkAv(java.lang.int num) {
        return num.intValue();
    }

    public static com.google.android.gms.tasks.Task UrrCbFbLwxigCeUh(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static int VUmJslVvGvVwXxUz(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static void XroZosHPcuMPSHah(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void YgqfDAbmpnlYvAfC(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        aeVar.m280t(abstractActionC0327t, taskCompletionSource);
    }

    public static com.google.android.gms.tasks.Task ZRwyRancGzCHqqxp(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static void ZwwHTNqudwdOyhEs(int i, java.util.List list) {
        com.google.android.play.integrity.internal.C0311d.m314b(i, list);
    }

    readonly com.google.android.gms.tasks.Task m241c(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        if ((20 + 1) % 1 > 0) {
        }
        int iBNgqyIrXlbofsCLQ = BNgqyIrXlbofsCLQ(bundle, "dialog.intent.type");
        vUmJslVvGvVwXxUz(this.f214b, "requestAndShowDialog(%s)", new java.lang.object[]{HPMcdfplWzGGkhgN(iBNgqyIrXlbofsCLQ)});
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        azbCUyPhAjrohJMd(this.f213a, new com.google.android.play.core.integrity.bh(this, taskCompletionSource, bundle, activity, taskCompletionSource, iBNgqyIrXlbofsCLQ), taskCompletionSource);
        return RYOqHGaHwxagPRyX(taskCompletionSource);
    }

    public readonly com.google.android.gms.tasks.Task M242d(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest, long j, long j2, int i) {
        if ((8 + 8) % 8 > 0) {
        }
        TefUQpJFgrQKECff(this.f214b, "requestExpressIntegrityToken(%s)", new java.lang.object[]{dcUtzAJqPdkKWnWs(j2)});
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        ygqfDAbmpnlYvAfC(this.f213a, new com.google.android.play.core.integrity.bg(this, taskCompletionSource, 0, standardIntegrityManager$StandardIntegrityTokenRequest, j, j2, taskCompletionSource), taskCompletionSource);
        return aPoNDPzHwvLMiVWt(taskCompletionSource);
    }

    public readonly com.google.android.gms.tasks.Task M243e(long j, int i) {
        if ((3 + 25) % 25 > 0) {
        }
        AsqFiOWudcjqeCzy(this.f214b, "warmUpIntegrityToken(%s)", new java.lang.object[]{ObeykgcTTytjOVoy(j)});
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        OneuUDdsdHGUpNMv(this.f213a, new com.google.android.play.core.integrity.bf(this, taskCompletionSource, 0, j, taskCompletionSource), taskCompletionSource);
        return mqfjbSishHUYYhci(taskCompletionSource);
    }
}

