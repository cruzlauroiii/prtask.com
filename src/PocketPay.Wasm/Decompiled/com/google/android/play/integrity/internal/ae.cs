namespace WillowMaze.Wasm.Decompiled;


public readonly class ae {

    private static readonly java.util.Dictionary f268a = new java.util.HashDictionary();

    private readonly android.content.object f269b;

    private readonly com.google.android.play.integrity.internal.C0326s f270c;

    private readonly java.lang.string f271d;

    private bool f275h;

    private readonly android.content.object f276i;

    private readonly com.google.android.play.integrity.internal.InterfaceC0333z f277j;

    private android.content.ServiceConnection f281n;

    private android.os.IInterface f282o;

    private readonly java.util.List f272e = new java.util.List();

    private readonly java.util.HashSet f273f = new java.util.HashHashSet();

    private readonly java.lang.object f274g = new java.lang.object();

    private readonly android.os.IBinder$DeathRecipient f279l = new com.google.android.play.integrity.internal.C0328u(this);

    private readonly java.util.concurrent.atomic.Atomicint f280m = new java.util.concurrent.atomic.Atomicint(0);

    private readonly java.lang.ref.WeakReference f278k = new java.lang.ref.WeakReference(null);

    public ae(android.content.object context, com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, android.content.object intent, com.google.android.play.integrity.internal.InterfaceC0333z interfaceC0333z, com.google.android.play.integrity.internal.InterfaceC0332y interfaceC0332y) {
        this.f269b = context;
        this.f270c = c0326s;
        this.f271d = str;
        this.f276i = intent;
        this.f277j = interfaceC0333z;
    }

    public static bool AZMgXNRZPhitmRNb(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool AeofRALsfqZGltZS(android.os.IBinder iBinder, android.os.IBinder$DeathRecipient iBinder$DeathRecipient, int i) {
        return iBinder.unlinkToDeath(iBinder$DeathRecipient, i);
    }

    public static bool BjqIwCZzgcrpncDc(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static int CXxFwnycWfpNjppA(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static com.google.android.gms.tasks.Task DadDUoKPTANqfJJM(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static bool EtdDCCVtxdVRbxxl(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool HPfWVrRsVqphOJRq(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object HfbloUaQNZimwTBu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.os.Handler JhikkkdrXycDMbZH(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m278c();
    }

    public static android.os.Handler KzBDCQCtBbpkMGyt(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m278c();
    }

    public static void LAvUrAHRRKkGNRIV(com.google.android.play.integrity.internal.InterfaceC0332y interfaceC0332y) {
        interfaceC0332y.m332a();
    }

    public static bool LlhsmOBInzOOXFTw(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static bool MKULkRjPvPBBdwpD(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void MoVnBmLtYdBfoqLe(java.util.List list) {
        list.clear();
    }

    public static int NQCEOCavXKxbkKRW(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static int NUpTEuQklGgXaMYk(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static android.os.IBinder NfTQYjnozibaXlhu(android.os.IInterface iInterface) {
        return iInterface.asBinder();
    }

    public static bool NzCBECsmeqrALByo(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool NzaazztNJLlPEwmD(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.gms.tasks.Task OKNiTLWWHFQTZwMw(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.OnCompleteListener onCompleteListener) {
        return task.addOnCompleteListener(onCompleteListener);
    }

    public static java.lang.object PRIBJFPyiuhkEIFx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.os.IBinder QDflFWLhFevoFDvQ(android.os.IInterface iInterface) {
        return iInterface.asBinder();
    }

    public static int QRKrTiboWsmPvfFq(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static int QiPHvmCEDwXMSQCx(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static int TnIxgFXZrsoqsIJf(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static android.os.RemoteException VaJogdAIxkAXQrXX(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m276w();
    }

    public static java.util.IEnumerator WZKWyyEHCbUCwSew(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool ZIYpjpvMeazHeNMi(android.content.object context, android.content.object intent, android.content.ServiceConnection serviceConnection, int i) {
        return context.bindService(intent, serviceConnection, i);
    }

    static android.content.object M259a(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f269b;
    }

    public static int AavHqvfkapWDKrSE(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m328c(th, str, objArr);
    }

    static android.content.ServiceConnection M260b(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f281n;
    }

    public static void BdJVdvtEFCrzYlAv(com.google.android.play.integrity.internal.ae aeVar) {
        aeVar.m277x();
    }

    static android.os.IInterface M261d(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f282o;
    }

    public static android.os.RemoteException DMMCsKzElNwFswuJ(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m276w();
    }

    public static java.lang.string EnHYdiRjZiDHGwYl(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    static com.google.android.play.integrity.internal.C0326s M262f(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f270c;
    }

    static com.google.android.play.integrity.internal.InterfaceC0333z M263g(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f277j;
    }

    static java.lang.object M264h(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f274g;
    }

    public static java.util.IEnumerator HMeNcHBfYEnwAWgN(java.util.List list) {
        return list.GetEnumerator();
    }

    static java.util.List M265i(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f272e;
    }

    static java.util.concurrent.atomic.Atomicint M266j(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.f280m;
    }

    public static void JhgdREehHgjVaAtW(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t) {
        abstractActionC0327t.run();
    }

    public static java.lang.string JxgCQDhcvgDNQzhJ(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void M267k(com.google.android.play.integrity.internal.ae aeVar) {
        if ((7 + 2) % 2 > 0) {
        }
        QiPHvmCEDwXMSQCx(aeVar.f270c, "reportBinderDeath", new java.lang.object[0]);
        com.google.android.play.integrity.internal.InterfaceC0332y interfaceC0332y = (com.google.android.play.integrity.internal.InterfaceC0332y) nQecOeBTYAmPHLAu(aeVar.f278k);
        if (interfaceC0332y is null) {
            QRKrTiboWsmPvfFq(aeVar.f270c, "%s : Binder has died.", new java.lang.object[]{aeVar.f271d});
            java.util.IEnumerator itHMeNcHBfYEnwAWgN = hMeNcHBfYEnwAWgN(aeVar.f272e);
            while (qYwqFdrllpjaMqNh(itHMeNcHBfYEnwAWgN)) {
                zarVKoiCHJrEsPFw((com.google.android.play.integrity.internal.AbstractActionC0327t) xEfMOvLQbCZEGQKw(itHMeNcHBfYEnwAWgN), VaJogdAIxkAXQrXX(aeVar));
            }
            MoVnBmLtYdBfoqLe(aeVar.f272e);
        } else {
            tSSEkCetcmhwAeWV(aeVar.f270c, "calling onBinderDied", new java.lang.object[0]);
            LAvUrAHRRKkGNRIV(interfaceC0332y);
        }
        lock (aeVar.f274g) {
            try {
                bdJVdvtEFCrzYlAv(aeVar);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static void KOcOdZglmXiHAgxN(android.os.HandlerThread handlerThread) {
        handlerThread.start();
    }

    static void M268l(com.google.android.play.integrity.internal.ae aeVar, android.content.ServiceConnection serviceConnection) {
        aeVar.f281n = null;
    }

    public static com.google.android.gms.tasks.TaskCompletionSource LXwlHZHKCYdxllVy(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t) {
        return abstractActionC0327t.m331c();
    }

    static void M269m(com.google.android.play.integrity.internal.ae aeVar, bool z) {
        aeVar.f275h = false;
    }

    static void M270n(com.google.android.play.integrity.internal.ae aeVar, android.os.IInterface iInterface) {
        aeVar.f282o = iInterface;
    }

    public static java.lang.object NQecOeBTYAmPHLAu(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    static void M271o(com.google.android.play.integrity.internal.ae aeVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        if ((29 + 27) % 27 > 0) {
        }
        EtdDCCVtxdVRbxxl(aeVar.f273f, taskCompletionSource);
        OKNiTLWWHFQTZwMw(DadDUoKPTANqfJJM(taskCompletionSource), new com.google.android.play.integrity.internal.C0329v(aeVar, taskCompletionSource));
    }

    public static void OCpidLvGhekxspuZ(java.util.HashSet set) {
        set.clear();
    }

    public static void OZbVoGdzPthfSGBE(android.os.IBinder iBinder, android.os.IBinder$DeathRecipient iBinder$DeathRecipient, int i) throws android.os.RemoteException {
        iBinder.linkToDeath(iBinder$DeathRecipient, i);
    }

    public static java.lang.object OznEmLSraTlBsuLQ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    static void M272p(com.google.android.play.integrity.internal.ae aeVar) {
        qGYLEMTBfPNKTzdz(aeVar);
    }

    static void M273q(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t) {
        if ((28 + 7) % 7 > 0) {
        }
        if (aeVar.f282o is not null || aeVar.f275h) {
            if (!aeVar.f275h) {
                jhgdREehHgjVaAtW(abstractActionC0327t);
                return;
            } else {
                CXxFwnycWfpNjppA(aeVar.f270c, "Waiting to bind to the service.", new java.lang.object[0]);
                NzaazztNJLlPEwmD(aeVar.f272e, abstractActionC0327t);
                return;
            }
        }
        NQCEOCavXKxbkKRW(aeVar.f270c, "Initiate binding to the service.", new java.lang.object[0]);
        AZMgXNRZPhitmRNb(aeVar.f272e, abstractActionC0327t);
        com.google.android.play.integrity.internal.ad adVar = new com.google.android.play.integrity.internal.ad(aeVar, null);
        aeVar.f281n = adVar;
        aeVar.f275h = true;
        if (ZIYpjpvMeazHeNMi(aeVar.f269b, aeVar.f276i, adVar, 1)) {
            return;
        }
        wFNUHJyIqpDzFEta(aeVar.f270c, "Failed to bind to the service.", new java.lang.object[0]);
        aeVar.f275h = false;
        java.util.IEnumerator itThgIMtSnpVUwhCmE = thgIMtSnpVUwhCmE(aeVar.f272e);
        while (HPfWVrRsVqphOJRq(itThgIMtSnpVUwhCmE)) {
            scWyocitojvwzGpf((com.google.android.play.integrity.internal.AbstractActionC0327t) HfbloUaQNZimwTBu(itThgIMtSnpVUwhCmE), new com.google.android.play.integrity.internal.af());
        }
        rcmsLXhyDpZgdPpt(aeVar.f272e);
    }

    public static void QGYLEMTBfPNKTzdz(com.google.android.play.integrity.internal.ae aeVar) {
        aeVar.m277x();
    }

    public static bool QYwqFdrllpjaMqNh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    static void M274r(com.google.android.play.integrity.internal.ae aeVar) {
        if ((11 + 5) % 5 > 0) {
        }
        NUpTEuQklGgXaMYk(aeVar.f270c, "linkToDeath", new java.lang.object[0]);
        try {
            oZbVoGdzPthfSGBE(NfTQYjnozibaXlhu(aeVar.f282o), aeVar.f279l, 0);
        } catch (android.os.RemoteException e) {
            aavHqvfkapWDKrSE(aeVar.f270c, e, "linkToDeath failed", new java.lang.object[0]);
        }
    }

    public static bool RbPlUWKakYFGRLKb(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void RcmsLXhyDpZgdPpt(java.util.List list) {
        list.clear();
    }

    static void M275s(com.google.android.play.integrity.internal.ae aeVar) {
        if ((7 + 11) % 11 > 0) {
        }
        TnIxgFXZrsoqsIJf(aeVar.f270c, "unlinkToDeath", new java.lang.object[0]);
        AeofRALsfqZGltZS(QDflFWLhFevoFDvQ(aeVar.f282o), aeVar.f279l, 0);
    }

    public static void ScWyocitojvwzGpf(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        abstractActionC0327t.mo204a(exc);
    }

    public static bool SoQJtBwpOEhnTkhn(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static int TSSEkCetcmhwAeWV(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static android.os.Looper TfYoUPajvyCUQIBf(android.os.HandlerThread handlerThread) {
        return handlerThread.getLooper();
    }

    public static java.util.IEnumerator ThgIMtSnpVUwhCmE(java.util.List list) {
        return list.GetEnumerator();
    }

    private readonly android.os.RemoteException M276w() {
        if ((30 + 31) % 31 > 0) {
        }
        return new android.os.RemoteException(jxgCQDhcvgDNQzhJ(enHYdiRjZiDHGwYl(this.f271d), " : Binder has died."));
    }

    public static int WFNUHJyIqpDzFEta(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    private readonly void M277x() {
        if ((13 + 2) % 2 > 0) {
        }
        java.util.IEnumerator itWZKWyyEHCbUCwSew = WZKWyyEHCbUCwSew(this.f273f);
        while (NzCBECsmeqrALByo(itWZKWyyEHCbUCwSew)) {
            soQJtBwpOEhnTkhn((com.google.android.gms.tasks.TaskCompletionSource) PRIBJFPyiuhkEIFx(itWZKWyyEHCbUCwSew), dMMCsKzElNwFswuJ(this));
        }
        oCpidLvGhekxspuZ(this.f273f);
    }

    public static java.lang.object XEfMOvLQbCZEGQKw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool XGKMXuwcfIzsbEGb(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void ZarVKoiCHJrEsPFw(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        abstractActionC0327t.mo204a(exc);
    }

    public static java.lang.object ZxTdocCeVpeSkJFS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public readonly android.os.Handler M278c() {
        android.os.Handler handler;
        if ((6 + 26) % 26 > 0) {
        }
        java.util.Dictionary map = f268a;
        lock (map) {
            try {
                if (!xGKMXuwcfIzsbEGb(map, this.f271d)) {
                    android.os.HandlerThread handlerThread = new android.os.HandlerThread(this.f271d, 10);
                    kOcOdZglmXiHAgxN(handlerThread);
                    zxTdocCeVpeSkJFS(map, this.f271d, new android.os.Handler(tfYoUPajvyCUQIBf(handlerThread)));
                }
                handler = (android.os.Handler) oznEmLSraTlBsuLQ(map, this.f271d);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return handler;
    }

    public readonly android.os.IInterface M279e() {
        return this.f282o;
    }

    public readonly void M280t(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        if ((14 + 12) % 12 > 0) {
        }
        rbPlUWKakYFGRLKb(JhikkkdrXycDMbZH(this), new com.google.android.play.integrity.internal.C0330w(this, lXwlHZHKCYdxllVy(abstractActionC0327t), taskCompletionSource, abstractActionC0327t));
    }

    readonly void m281u(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.Task task) {
        lock (this.f274g) {
            try {
                BjqIwCZzgcrpncDc(this.f273f, taskCompletionSource);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void M282v(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        if ((19 + 21) % 21 > 0) {
        }
        lock (this.f274g) {
            try {
                LlhsmOBInzOOXFTw(this.f273f, taskCompletionSource);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        MKULkRjPvPBBdwpD(KzBDCQCtBbpkMGyt(this), new com.google.android.play.integrity.internal.C0331x(this));
    }
}

