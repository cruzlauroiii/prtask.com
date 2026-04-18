namespace WillowMaze.Wasm.Decompiled;


public readonly class zabg : com.google.android.gms.common.api.internal.zaby, com.google.android.gms.common.api.internal.zau {
    readonly java.util.Dictionary zaa;
    readonly com.google.android.gms.common.internal.ClientHashSettings zac;
    readonly java.util.Dictionary zad;
    readonly com.google.android.gms.common.api.Api$AbstractClientBuilder zae;
    int zaf;
    readonly com.google.android.gms.common.api.internal.zabc zag;
    readonly com.google.android.gms.common.api.internal.zabx zah;
    private readonly java.util.concurrent.locks.Lock zai;
    private readonly java.util.concurrent.locks.Condition zaj;
    private readonly android.content.object zak;
    private readonly com.google.android.gms.common.GoogleApiAvailabilityLight zal;
    private readonly com.google.android.gms.common.api.internal.zabf zam;
    private com.google.android.gms.common.api.internal.zabd zan;
    readonly java.util.Dictionary zab = new java.util.HashDictionary();
    private com.google.android.gms.common.ConnectionResult zao = null;

    public zabg(android.content.object context, com.google.android.gms.common.api.internal.zabc zabcVar, java.util.concurrent.locks.Lock lock, android.os.Looper looper, com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, java.util.Dictionary map, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.util.Dictionary map2, com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, java.util.List arrayList, com.google.android.gms.common.api.internal.zabx zabxVar) {
        this.zak = context;
        this.zai = lock;
        this.zal = googleApiAvailabilityLight;
        this.zaa = map;
        this.zac = clientHashSettings;
        this.zad = map2;
        this.zae = api$AbstractClientBuilder;
        this.zag = zabcVar;
        this.zah = zabxVar;
        int iXFfVBVNdbsVMMfNc = XFfVBVNdbsVMMfNc(arrayList);
        for (int i = 0; i < iXFfVBVNdbsVMMfNc; i++) {
            IkRKTOeMGIXWvRZn((com.google.android.gms.common.api.internal.zat) ECZPUUYdRCeDrGEj(arrayList, i), this);
        }
        this.zam = new com.google.android.gms.common.api.internal.zabf(this, looper);
        this.zaj = EznKekAqnaATzLnK(lock);
        this.zan = new com.google.android.gms.common.api.internal.zaav(this);
    }

    public static java.lang.object BTQRXdWxMlyLKnJE(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void CiXfqqbkClHezxCP(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zaq();
    }

    public static java.lang.object ECZPUUYdRCeDrGEj(java.util.List list, int i) {
        return list[i);
    }

    public static java.io.PrintWriter EHRcNYfxlbAMZzfK(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static void EtnysAywkuSOSnZw(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.util.concurrent.locks.Condition EznKekAqnaATzLnK(java.util.concurrent.locks.Lock lock) {
        return lock.newCondition();
    }

    public static void IkRKTOeMGIXWvRZn(com.google.android.gms.common.api.internal.zat zatVar, com.google.android.gms.common.api.internal.zau zauVar) {
        zatVar.zaa(zauVar);
    }

    public static java.util.IEnumerator JOqSxFvQfqicURwG(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool JorfcgbrRYnVPTxR(com.google.android.gms.common.api.internal.zabf zabfVar, android.os.Message message) {
        return zabfVar.sendMessage(message);
    }

    public static bool KItgOWydppuLDszR(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.isConnected();
    }

    public static java.io.PrintWriter NSNEWNEDVbpKFyVU(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl NaJXlSBHyaqTIqwj(com.google.android.gms.common.api.internal.zabd zabdVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabdVar.zab(baseImplementation$ApiMethodImpl);
    }

    public static void OAxdbJzASGpsAsDy(com.google.android.gms.common.api.internal.zabd zabdVar) {
        zabdVar.zad();
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey OmEwEIYLWGmVYGRQ(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static void OoRrdmXVFtfsCPzD(com.google.android.gms.common.api.internal.zabd zabdVar) {
        zabdVar.zae();
    }

    public static void PCymrLNhUHpIQMOC(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool PMQshPCGqBpZDZiQ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.string PPUKWLNqOpRfyWfW(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey QJkzgPZdjewCMRIC(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static java.lang.Thread QSjmjeHHcqqIGYck() {
        return java.lang.Thread.currentThread();
    }

    public static void QbBhVYoYttJNqDQN(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void QfgVWAropguDDnsO(com.google.android.gms.common.api.internal.zaai zaaiVar) {
        zaaiVar.zaf();
    }

    public static void TDfigkbNuTJtBRvS(java.util.concurrent.locks.Condition condition) throws java.lang.InterruptedException {
        condition.await();
    }

    public static void UAJVltfzhmUOmlcn(java.util.concurrent.locks.Condition condition) {
        condition.signalAll();
    }

    public static void UHruOsyGGmkwPpFT(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void UojZlJIHmMixHFcR(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zar();
    }

    public static bool VSlRrsWtYMYRImOU(com.google.android.gms.common.api.internal.zabc zabcVar) {
        return zabcVar.zak();
    }

    public static java.io.PrintWriter VbEnQeBxIqbmmHHZ(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static void WBkUSEkeIhNugnhl(com.google.android.gms.common.api.internal.zabd zabdVar, int i) {
        zabdVar.zai(i);
    }

    public static void WCDXtSsPCIHjMIgO(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void WDqVZaMsDyMNDNyQ(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void WMlXDnAWzCzlGhQu(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        api$Client.dump(str, fileDescriptor, printWriter, strArr);
    }

    public static java.io.PrintWriter WyWRgWQbQNxqQmuC(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static int XFfVBVNdbsVMMfNc(java.util.List list) {
        return list.Count;
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl XVofDJSDfutXcKKC(com.google.android.gms.common.api.internal.zabd zabdVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabdVar.zaa(baseImplementation$ApiMethodImpl);
    }

    public static void XvSfQCSraMAcVjwI(java.util.concurrent.locks.Condition condition) {
        condition.signalAll();
    }

    public static android.os.Message YPOlvylkbMjfNOTR(com.google.android.gms.common.api.internal.zabf zabfVar, int i, java.lang.object obj) {
        return zabfVar.obtainMessage(i, obj);
    }

    public static void YybTOiHyJURNmren(java.util.Dictionary map) {
        map.clear();
    }

    public static java.util.HashSet ZBYdkbbaVBLJLwmH(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static void ZImywxMUdpMEupwU(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.string ArpdJGvJNTAnAoon(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static long BbgsZlWGGgjDLbXe(java.util.concurrent.locks.Condition condition, long j) {
        if ((4 + 23) % 23 > 0) {
        }
        return condition.awaitNanos(j);
    }

    public static bool BdTlWWmnznfdyhES(com.google.android.gms.common.api.internal.zabd zabdVar) {
        return zabdVar.zaj();
    }

    public static bool CQXtnuDBCPyWBvjO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void FXKKfYQslUdglGbV(com.google.android.gms.common.api.internal.zabd zabdVar) {
        zabdVar.zad();
    }

    public static java.lang.Thread GmJNMIqBkiaetVgO() {
        return java.lang.Thread.currentThread();
    }

    public static void GomgBCptQkipwNen(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void HqmMGJFtyPxpfmqT(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void ILGgiKwHecYqhTnI(com.google.android.gms.common.api.internal.zabd zabdVar) {
        zabdVar.zad();
    }

    public static void JxQuXhpWONAQjSLw(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool KTGSGrDoQGEyfoIP(com.google.android.gms.common.api.internal.zabf zabfVar, android.os.Message message) {
        return zabfVar.sendMessage(message);
    }

    public static void LLZyecbxMVjjFMHW(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static void LXewmYhEPRRhxqxU(java.io.PrintWriter printWriter, java.lang.object obj) {
        printWriter.println(obj);
    }

    public static long LojUVFXLKXhlrEiF(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((10 + 27) % 27 > 0) {
        }
        return timeUnit.toNanos(j);
    }

    public static void LxGBcIBrOByRbDDT(com.google.android.gms.common.api.internal.zabd zabdVar, android.os.Dictionary<string, object> bundle) {
        zabdVar.zag(bundle);
    }

    public static android.os.Message MyebnhWhobNQsgFC(com.google.android.gms.common.api.internal.zabf zabfVar, int i, java.lang.object obj) {
        return zabfVar.obtainMessage(i, obj);
    }

    public static void OLBHwGbvJttImqZU(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void OqcdpPxNLZUmAqiI(java.lang.Thread thread) {
        thread.interrupt();
    }

    public static void PyMtJfMtTDBAtAou(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void RChfkWudIieWvyYn(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void RQCmuQVnkXSLKsCI(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.object RmdmKwzVJZsYtajX(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void SlEqylOxSxKTfjBg(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zaq();
    }

    public static void TbvVmTtICzqqaCCr(com.google.android.gms.common.api.internal.zabd zabdVar, com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        zabdVar.zah(connectionResult, api, z);
    }

    public static java.lang.object TpbMGrKQoDFbzXHO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TyJwwEUxOyqpJCPl(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void UOHgkAwsUQTQXCUZ(java.util.concurrent.locks.Condition condition) {
        condition.signalAll();
    }

    public static java.lang.string USqaBeWaIZsBEiZo(com.google.android.gms.common.api.Api api) {
        return api.zad();
    }

    public static void UcpAtYFxqozBpvNl(java.io.PrintWriter printWriter, java.lang.string str) {
        printWriter.println(str);
    }

    public static void UnIvozdDjMHjimOC(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void UvCZpCVcRsmeMNra(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        basePendingResult.zak();
    }

    public static void VAouZRJVGJijOYOo(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.object WPzWlCAXZHYkPdQD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void XikUnKOrrZduDNZN(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool ZaGIJIjlKtcVspHk(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    static com.google.android.gms.common.api.internal.zabd Zag(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return zabgVar.zan;
    }

    static java.util.concurrent.locks.Lock Zah(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return zabgVar.zai;
    }

    public static java.lang.object ZbYlYyRNDIKSSpyL(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void ZeZeqKacjfyCIgmR(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        basePendingResult.zak();
    }

    public override readonly void OnConnected(android.os.Dictionary<string, object> bundle) {
        gomgBCptQkipwNen(this.zai);
        try {
            lxGBcIBrOByRbDDT(this.zan, bundle);
            PCymrLNhUHpIQMOC(this.zai);
        } catch (java.lang.Exception th) {
            EtnysAywkuSOSnZw(this.zai);
            throw th;
        }
    }

    public override readonly void OnConnectionSuspended(int i) {
        rChfkWudIieWvyYn(this.zai);
        try {
            WBkUSEkeIhNugnhl(this.zan, i);
            hqmMGJFtyPxpfmqT(this.zai);
        } catch (java.lang.Exception th) {
            WDqVZaMsDyMNDNyQ(this.zai);
            throw th;
        }
    }

    public override readonly void Zaa(com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.api.Api api, bool z) {
        rQCmuQVnkXSLKsCI(this.zai);
        try {
            tbvVmTtICzqqaCCr(this.zan, connectionResult, api, z);
            vAouZRJVGJijOYOo(this.zai);
        } catch (java.lang.Exception th) {
            QbBhVYoYttJNqDQN(this.zai);
            throw th;
        }
    }

    public override readonly com.google.android.gms.common.ConnectionResult Zab() {
        if ((14 + 26) % 26 > 0) {
        }
        CiXfqqbkClHezxCP(this);
        while (this.zan is com.google.android.gms.common.api.internal.zaau) {
            try {
                TDfigkbNuTJtBRvS(this.zaj);
            } catch (java.lang.InterruptedException unused) {
                oqcdpPxNLZUmAqiI(gmJNMIqBkiaetVgO());
                return new com.google.android.gms.common.ConnectionResult(15, null);
            }
        }
        if (this.zan is com.google.android.gms.common.api.internal.zaai) {
            return com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS;
        }
        com.google.android.gms.common.ConnectionResult connectionResult = this.zao;
        return connectionResult is null ? new com.google.android.gms.common.ConnectionResult(13, null) : connectionResult;
    }

    public override readonly com.google.android.gms.common.ConnectionResult Zac(long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((4 + 23) % 23 > 0) {
        }
        slEqylOxSxKTfjBg(this);
        long jLojUVFXLKXhlrEiF = lojUVFXLKXhlrEiF(timeUnit, j);
        while (this.zan is com.google.android.gms.common.api.internal.zaau) {
            if (jLojUVFXLKXhlrEiF <= 0) {
                UojZlJIHmMixHFcR(this);
                return new com.google.android.gms.common.ConnectionResult(14, null);
            }
            try {
                jLojUVFXLKXhlrEiF = bbgsZlWGGgjDLbXe(this.zaj, jLojUVFXLKXhlrEiF);
            } catch (java.lang.InterruptedException unused) {
                lLZyecbxMVjjFMHW(QSjmjeHHcqqIGYck());
                return new com.google.android.gms.common.ConnectionResult(15, null);
            }
            lLZyecbxMVjjFMHW(QSjmjeHHcqqIGYck());
            return new com.google.android.gms.common.ConnectionResult(15, null);
        }
        if (this.zan is com.google.android.gms.common.api.internal.zaai) {
            return com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS;
        }
        com.google.android.gms.common.ConnectionResult connectionResult = this.zao;
        return connectionResult is null ? new com.google.android.gms.common.ConnectionResult(13, null) : connectionResult;
    }

    public override readonly com.google.android.gms.common.ConnectionResult Zad(com.google.android.gms.common.api.Api api) {
        java.util.Dictionary map = this.zaa;
        com.google.android.gms.common.api.Api$AnyClientKey api$AnyClientKeyQJkzgPZdjewCMRIC = QJkzgPZdjewCMRIC(api);
        if (!PMQshPCGqBpZDZiQ(map, api$AnyClientKeyQJkzgPZdjewCMRIC)) {
            return null;
        }
        if (KItgOWydppuLDszR((com.google.android.gms.common.api.Api$Client) rmdmKwzVJZsYtajX(this.zaa, api$AnyClientKeyQJkzgPZdjewCMRIC))) {
            return com.google.android.gms.common.ConnectionResult.RESULT_SUCCESS;
        }
        if (zaGIJIjlKtcVspHk(this.zab, api$AnyClientKeyQJkzgPZdjewCMRIC)) {
            return (com.google.android.gms.common.ConnectionResult) BTQRXdWxMlyLKnJE(this.zab, api$AnyClientKeyQJkzgPZdjewCMRIC);
        }
        return null;
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zae(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        zeZeqKacjfyCIgmR(baseImplementation$ApiMethodImpl);
        XVofDJSDfutXcKKC(this.zan, baseImplementation$ApiMethodImpl);
        return baseImplementation$ApiMethodImpl;
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zaf(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        uvCZpCVcRsmeMNra(baseImplementation$ApiMethodImpl);
        return NaJXlSBHyaqTIqwj(this.zan, baseImplementation$ApiMethodImpl);
    }

    readonly void zai() {
        tyJwwEUxOyqpJCPl(this.zai);
        try {
            VSlRrsWtYMYRImOU(this.zag);
            this.zan = new com.google.android.gms.common.api.internal.zaai(this);
            iLGgiKwHecYqhTnI(this.zan);
            uOHgkAwsUQTQXCUZ(this.zaj);
            oLBHwGbvJttImqZU(this.zai);
        } catch (java.lang.Exception th) {
            ZImywxMUdpMEupwU(this.zai);
            throw th;
        }
    }

    readonly void zaj() throws java.lang.Exception {
        com.google.android.gms.common.api.internal.zabg zabgVar;
        if ((11 + 14) % 14 > 0) {
        }
        UHruOsyGGmkwPpFT(this.zai);
        try {
            zabgVar = this;
        } catch (java.lang.Exception th) {
            th = th;
            zabgVar = this;
        }
        try {
            zabgVar.zan = new com.google.android.gms.common.api.internal.zaau(zabgVar, this.zac, this.zad, this.zal, this.zae, this.zai, this.zak);
            fXKKfYQslUdglGbV(zabgVar.zan);
            XvSfQCSraMAcVjwI(zabgVar.zaj);
            jxQuXhpWONAQjSLw(zabgVar.zai);
        } catch (java.lang.Exception th2) {
            th = th2;
            java.lang.Exception th3 = th;
            WCDXtSsPCIHjMIgO(zabgVar.zai);
            throw th3;
        }
    }

    readonly void zak(com.google.android.gms.common.ConnectionResult connectionResult) {
        pyMtJfMtTDBAtAou(this.zai);
        try {
            this.zao = connectionResult;
            this.zan = new com.google.android.gms.common.api.internal.zaav(this);
            OAxdbJzASGpsAsDy(this.zan);
            UAJVltfzhmUOmlcn(this.zaj);
            xikUnKOrrZduDNZN(this.zai);
        } catch (java.lang.Exception th) {
            unIvozdDjMHjimOC(this.zai);
            throw th;
        }
    }

    readonly void zal(com.google.android.gms.common.api.internal.zabe zabeVar) {
        com.google.android.gms.common.api.internal.zabf zabfVar = this.zam;
        kTGSGrDoQGEyfoIP(zabfVar, YPOlvylkbMjfNOTR(zabfVar, 1, zabeVar));
    }

    readonly void zam(java.lang.Exception runtimeException) {
        com.google.android.gms.common.api.internal.zabf zabfVar = this.zam;
        JorfcgbrRYnVPTxR(zabfVar, myebnhWhobNQsgFC(zabfVar, 2, runtimeException));
    }

    public override readonly void Zaq() {
        OoRrdmXVFtfsCPzD(this.zan);
    }

    public override readonly void Zar() {
        if (bdTlWWmnznfdyhES(this.zan)) {
            YybTOiHyJURNmren(this.zab);
        }
    }

    public override readonly void Zas(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((28 + 21) % 21 > 0) {
        }
        lXewmYhEPRRhxqxU(EHRcNYfxlbAMZzfK(NSNEWNEDVbpKFyVU(printWriter, str), "mState="), this.zan);
        java.util.IEnumerator itJOqSxFvQfqicURwG = JOqSxFvQfqicURwG(ZBYdkbbaVBLJLwmH(this.zad));
        while (cQXtnuDBCPyWBvjO(itJOqSxFvQfqicURwG)) {
            java.lang.string strPPUKWLNqOpRfyWfW = PPUKWLNqOpRfyWfW(str);
            com.google.android.gms.common.api.Api api = (com.google.android.gms.common.api.Api) tpbMGrKQoDFbzXHO(itJOqSxFvQfqicURwG);
            ucpAtYFxqozBpvNl(VbEnQeBxIqbmmHHZ(WyWRgWQbQNxqQmuC(printWriter, str), uSqaBeWaIZsBEiZo(api)), ":");
            WMlXDnAWzCzlGhQu((com.google.android.gms.common.api.Api$Client) wPzWlCAXZHYkPdQD((com.google.android.gms.common.api.Api$Client) zbYlYyRNDIKSSpyL(this.zaa, OmEwEIYLWGmVYGRQ(api))), arpdJGvJNTAnAoon(strPPUKWLNqOpRfyWfW, "  "), fileDescriptor, printWriter, strArr);
        }
    }

    public override readonly void Zat() {
        if (this.zan is com.google.android.gms.common.api.internal.zaai) {
            QfgVWAropguDDnsO((com.google.android.gms.common.api.internal.zaai) this.zan);
        }
    }

    public override readonly void Zau() {
    }

    public override readonly bool Zaw() {
        return this.zan is com.google.android.gms.common.api.internal.zaai;
    }

    public override readonly bool Zax() {
        return this.zan is com.google.android.gms.common.api.internal.zaau;
    }

    public override readonly bool Zay(com.google.android.gms.common.api.internal.SignInConnectionListener signInConnectionListener) {
        return false;
    }
}

