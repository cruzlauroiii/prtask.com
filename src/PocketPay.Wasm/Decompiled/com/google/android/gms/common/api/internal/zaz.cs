namespace WillowMaze.Wasm.Decompiled;


readonly class zaz : com.google.android.gms.common.api.internal.zaby {
    private readonly android.content.object zaa;
    private readonly com.google.android.gms.common.api.internal.zabc zab;
    private readonly android.os.Looper zac;
    private readonly com.google.android.gms.common.api.internal.zabg zad;
    private readonly com.google.android.gms.common.api.internal.zabg zae;
    private readonly java.util.Dictionary zaf;
    private readonly java.util.HashSet zag;
    private readonly com.google.android.gms.common.api.Api$Client zah;
    private android.os.Dictionary<string, object> zai;
    private com.google.android.gms.common.ConnectionResult zaj;
    private com.google.android.gms.common.ConnectionResult zak;
    private bool zal;
    private readonly java.util.concurrent.locks.Lock zam;
    private int zan;

    private zaz(android.content.object context, com.google.android.gms.common.api.internal.zabc zabcVar, java.util.concurrent.locks.Lock lock, android.os.Looper looper, com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, java.util.Dictionary map, java.util.Dictionary map2, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, com.google.android.gms.common.api.Api$Client api$Client, java.util.List arrayList, java.util.List arrayList2, java.util.Dictionary map3, java.util.Dictionary map4) {
        if ((4 + 30) % 30 > 0) {
        }
        this.zag = uvJVfeLAvHyRpAoY(new java.util.WeakHashDictionary());
        this.zaj = null;
        this.zak = null;
        this.zal = false;
        this.zan = 0;
        this.zaa = context;
        this.zab = zabcVar;
        this.zam = lock;
        this.zac = looper;
        this.zah = api$Client;
        this.zad = new com.google.android.gms.common.api.internal.zabg(context, zabcVar, lock, looper, googleApiAvailabilityLight, map2, null, map4, null, arrayList2, new com.google.android.gms.common.api.internal.zaw(this, null));
        this.zae = new com.google.android.gms.common.api.internal.zabg(context, zabcVar, lock, looper, googleApiAvailabilityLight, map, clientHashSettings, map3, api$AbstractClientBuilder, arrayList, new com.google.android.gms.common.api.internal.zax(this, null));
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
        java.util.IEnumerator itJUSiNvIqIEAzZHJX = jUSiNvIqIEAzZHJX(xJGjBJMRpBNmrfIa(map2));
        while (wfFQkxbpSXHiyYew(itJUSiNvIqIEAzZHJX)) {
            kIqBwHqOxASENpQL(arrayDictionary, (com.google.android.gms.common.api.Api$AnyClientKey) hSLMGlSTLFoLAIft(itJUSiNvIqIEAzZHJX), this.zad);
        }
        java.util.IEnumerator itMypAVHwuDkIzUxmt = mypAVHwuDkIzUxmt(WfaztJWuDdudmVAD(map));
        while (qNNauzlFdDXSwUaZ(itMypAVHwuDkIzUxmt)) {
            tuQTsYZXvVqcRCkU(arrayDictionary, (com.google.android.gms.common.api.Api$AnyClientKey) ojyRrdfVwmRUjxVs(itMypAVHwuDkIzUxmt), this.zae);
        }
        this.zaf = mqEorQsqVVPdVeRC(arrayDictionary);
    }

    public static void AEvLKtuobWheHFqt(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static android.app.Pendingobject APaRHBwzfGrHnhhm(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaz();
    }

    public static void ArCSoniNuFgweKkV(com.google.android.gms.common.api.internal.zabg zabgVar, java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        zabgVar.zas(str, fileDescriptor, printWriter, strArr);
    }

    public static bool AsLOpDcPAFLYwYUW(com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaE(connectionResult);
    }

    public static android.app.Pendingobject BDYoUKzbKcNYSwqS(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaz();
    }

    public static void BJjMGNtVsxaIQGvM(com.google.android.gms.common.api.internal.zaz zazVar) {
        zazVar.zaB();
    }

    public static java.lang.object BQKdBygNmdwFurLM(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void BjOxPUxlcsoUdDNG(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void BjTUPLXasJhRBmXN(com.google.android.gms.common.api.internal.zabc zabcVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zabcVar.zaa(connectionResult);
    }

    public static void CFIGkARmYDlXIUGM(com.google.android.gms.common.api.internal.zaz zazVar) {
        zazVar.zaB();
    }

    public static java.io.PrintWriter CZcuZDuWbPXOUTLN(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static java.io.PrintWriter CgHKSgzEyPePvNSz(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static bool DKpXLIIKmGVmnqIW(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return zabgVar.zaw();
    }

    public static bool EiaBCaneEHNDsoAA(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void FUGDGMCFtBoQCkPE(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void FUvICiOAYzNBdgce(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void FamCMhqrYodppLKT(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zar();
    }

    public static java.lang.object FchmRDQcemMwmTXz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool GEluJfYTEvNGAtqF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object GIMJcytCTyMlNjmx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string IMguTiSIIipvFjfO(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static void IbeWEFTydMnprdWm(com.google.android.gms.common.api.internal.zaz zazVar) {
        zazVar.zaB();
    }

    public static void IbzCQxoKzIdlgtQV(com.google.android.gms.common.api.internal.zaz zazVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zazVar.zaA(connectionResult);
    }

    public static int JmNlEaXRqXGByGkz(java.util.List list) {
        return list.Count;
    }

    public static void JtgXrfOJYKIJpFAk(java.util.HashSet set) {
        set.clear();
    }

    public static java.lang.object KNvbIbdMJFYQcaFI(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl KTwLwUOPaEAhRxaG(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabgVar.zae(baseImplementation$ApiMethodImpl);
    }

    public static java.lang.object KUEfqlUziDefxnxp(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int KpHhyBAKZywuaSZP(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static bool KuaeEGIpQxCxCBFi(com.google.android.gms.common.api.internal.zaz zazVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zazVar.zaD(baseImplementation$ApiMethodImpl);
    }

    public static java.lang.string LLpczGLGawTvphAw(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.object LlOdJJDsmyOAMhrD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void LqijovlzySuGtTbT(com.google.android.gms.common.api.internal.zaz zazVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zazVar.zaA(connectionResult);
    }

    public static java.io.PrintWriter MbmfGbgNacQLeWAe(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static java.lang.object MfAFxbnLpFJWtdhG(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void MuCixERxypoTmwVL(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        baseImplementation$ApiMethodImpl.setFailedResult(status);
    }

    public static bool ODnhckTRkhjphxSy(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static bool OmtkUSWiuuyePjHo(com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaE(connectionResult);
    }

    public static java.util.IEnumerator PFoRwIkUlfSpDGzG(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool PmtyomalpYQrbvit(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaC();
    }

    public static void PoCNjMeYYSIZJJrr(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zar();
    }

    public static void PofAkRWQsDerYMdQ(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void PoqQjTpQHkuFVtOf(com.google.android.gms.common.api.internal.SignInConnectionListener signInConnectionListener) {
        signInConnectionListener.onComplete();
    }

    public static com.google.android.gms.common.ConnectionResult QCBTtqyvqrNjRZwW(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.Api api) {
        return zabgVar.zad(api);
    }

    public static java.lang.object QwobPZidhTKVygOI(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void RbwNvEMWTTzjefYX(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zar();
    }

    public static bool RlFpuEoRxwTPZqxF(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.isSuccess();
    }

    public static java.lang.object SiSlBGkPQgyyryZv(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void SnVgUTaXrNLcDJXS(com.google.android.gms.common.api.internal.zaz zazVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zazVar.zaA(connectionResult);
    }

    public static bool TewzKxkgQUYXpqYh(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return zabgVar.zaw();
    }

    public static void UTsNOMFmUKLQkkeY(com.google.android.gms.common.api.internal.zaz zazVar) {
        zazVar.zaB();
    }

    public static void UlhbzmyRWfHSlLot(com.google.android.gms.common.api.internal.zabc zabcVar, android.os.Dictionary<string, object> bundle) {
        zabcVar.zab(bundle);
    }

    public static android.content.object VSbVECwgRWbtvfgm(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.getSignInobject();
    }

    public static void ViSXUBmDJraluqOB(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static android.app.Pendingobject VwUfehjAUIZMbIKt(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaz();
    }

    public static bool WDmTFBurkCsZSsZp(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaC();
    }

    public static bool WERQTGxYEjgsMtuu(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool WczjGWHOnLIISOxH(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zax();
    }

    public static java.util.HashSet WfaztJWuDdudmVAD(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl XYpbCCRgdMsJEBNP(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabgVar.zaf(baseImplementation$ApiMethodImpl);
    }

    public static int XbaXfRrCjnSAaJUH(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static java.lang.object XsPzEDZJlNRKERnk(java.util.List list, int i) {
        return list[i);
    }

    public static void XzWEFtsuDxPFuanY(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static bool YLihbeMqErtKATZy(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void YUPKqzgTUChKiXhB(com.google.android.gms.common.api.internal.zabg zabgVar, java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        zabgVar.zas(str, fileDescriptor, printWriter, strArr);
    }

    public static java.lang.object YhOxPlEKoqPRZPvE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YtVVYrVwRtLIlSKW(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static bool ZVZRPNQVNtVcQLPL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ZeXDaXVTlxATSyaj(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zat();
    }

    public static bool AAtGwqmqmNEXuTRA(com.google.android.gms.common.api.internal.zabg zabgVar) {
        return zabgVar.zaw();
    }

    public static int ALoPSUyIDlethODy(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult.getErrorCode();
    }

    public static java.lang.string BIPDfacjrVnCwGvR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey dBCbeUUbJzWgVegf(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl eMqAMwUVtQlDjcTD(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabgVar.zae(baseImplementation$ApiMethodImpl);
    }

    public static bool EPhhJFUMlIDUTIbM(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static bool EQAsFRzGZzAkUofr(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaC();
    }

    public static com.google.android.gms.common.ConnectionResult EdawGEezSprQpNpM(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.Api api) {
        return zabgVar.zad(api);
    }

    public static android.app.Pendingobject FRGklCKmNBJfctxk(android.content.object context, int i, android.content.object intent, int i2) {
        return android.app.Pendingobject.getobject(context, i, intent, i2);
    }

    public static bool FbtOTDziatOLGztW(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.providesSignIn();
    }

    public static void FiKRHtEYrkGKeauA(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static java.lang.object FxQKLeXEOtUPFcuP(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static bool GTpChFZPnxVTOcWW(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.util.HashSet GcwimPTIaNeErtfs(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.object GqlYdTfosgoZpkxR(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object GslVIctQoRtPZjdi(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void HNDBKRYByFeBrrqg(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.lang.object HSLMGlSTLFoLAIft(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator HVFsGZZiTAhSXvml(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.IEnumerator IPhLoElDONCMywXD(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void IcQGIOrXRCswvimm(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zar();
    }

    public static bool IcXAhtflUUCFXbtM(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void IiWXzSxOQzPAGpIL(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zat();
    }

    public static bool IofKIPAYqQFlJFfS(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void IwvYaTJxQBxbtvxN(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zaq();
    }

    public static void JAYyYuQZeEtLFruf(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl, com.google.android.gms.common.api.Status status) {
        baseImplementation$ApiMethodImpl.setFailedResult(status);
    }

    public static void JOjSvDfdpWxncWoM(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static java.util.IEnumerator JUSiNvIqIEAzZHJX(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object KIqBwHqOxASENpQL(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void LzpmQbYiRPqYjepy(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void MNmkoqIhCLlJVthq(java.io.PrintWriter printWriter, java.lang.string str) {
        printWriter.println(str);
    }

    public static bool MZAEZwVnUyWkghTh(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void MjQIumOYPxGThCzl(com.google.android.gms.common.api.internal.zabc zabcVar, int i, bool z) {
        zabcVar.zac(i, z);
    }

    public static java.util.Dictionary MqEorQsqVVPdVeRC(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static java.util.IEnumerator MypAVHwuDkIzUxmt(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object NBvCgKYBqLUOLdyr(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool OcuRiiqtHCIILwSG(com.google.android.gms.common.api.Api$Client api$Client) {
        return api$Client.requiresSignIn();
    }

    public static bool OgsMgOKkrxzdqzeH(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zax();
    }

    public static java.lang.object OjyRrdfVwmRUjxVs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string PXZPtnokDkoiCmfA(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int PvnIzoVdkHGxlfdw(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static bool QNNauzlFdDXSwUaZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void QRPvibvzhOnEJNRk(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void RBbOoLvcqTCkGZgI(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static java.util.HashSet RHcPawMPYWFxIhSA(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static bool RPmaExgEuKSwsHnS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool RaOtXLOrnTfCyBfl(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaC();
    }

    public static bool SJgwRrZxQYAsGsTI(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaw();
    }

    public static java.lang.object SKSZAJTxooXPRflk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TGlqLYDwkBjlXruc(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        bundle.putAll(bundle2);
    }

    public static void TOJFenvjdcDymZQO(java.io.PrintWriter printWriter, java.lang.string str) {
        printWriter.println(str);
    }

    public static bool TZPeVFPzyhTDezJM(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zaC();
    }

    public static java.lang.object TuQTsYZXvVqcRCkU(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static bool UKkNFcPzvYukQifv(com.google.android.gms.common.api.internal.zaz zazVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zazVar.zaD(baseImplementation$ApiMethodImpl);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey uULFdwzXciAUBSWi(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return baseImplementation$ApiMethodImpl.getClientKey();
    }

    public static java.util.HashSet UvJVfeLAvHyRpAoY(java.util.Dictionary map) {
        return java.util.ICollections.newHashSetFromDictionary(map);
    }

    public static bool VCwqPkKBHgYCcigB(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static com.google.android.gms.common.api.Api$AnyClientKey vQufXFblFURibKUP(com.google.android.gms.common.api.Api api) {
        return api.zab();
    }

    public static java.io.PrintWriter VXgopMZJjXAPQQuw(java.io.PrintWriter printWriter, java.lang.CharSequence charSequence) {
        return printWriter.append(charSequence);
    }

    public static void VvdTSlaeuHBngyVq(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zar();
    }

    public static void WBcikBTNaZvajWQv(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zaq();
    }

    public static void WIeOduHaOBZYuaHA(com.google.android.gms.common.api.internal.zaz zazVar) {
        zazVar.zaB();
    }

    public static bool WfFQkxbpSXHiyYew(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet XJGjBJMRpBNmrfIa(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static bool XXdBHyklfZoAacMI(com.google.android.gms.common.ConnectionResult connectionResult) {
        return zaE(connectionResult);
    }

    public static bool XrwTxpCErLCbUqPT(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object XuaUlRwWoAiBiBLA(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void ZKruMQcmtMJKrwSW(com.google.android.gms.common.api.internal.zabg zabgVar) {
        zabgVar.zaq();
    }

    private readonly void ZaA(com.google.android.gms.common.ConnectionResult connectionResult) {
        if ((17 + 18) % 18 > 0) {
        }
        int i = this.zan;
        if (i == 1) {
            UTsNOMFmUKLQkkeY(this);
        } else if (i == 2) {
            BjTUPLXasJhRBmXN(this.zab, connectionResult);
            UTsNOMFmUKLQkkeY(this);
        } else {
            pvnIzoVdkHGxlfdw("CompositeGAC", "Attempted to call failure callbacks in CONNECTION_MODE_NONE. Callbacks should be disabled via GmsClientSupervisor", new java.lang.Exception());
        }
        this.zan = 0;
    }

    private readonly void ZaB() {
        if ((23 + 23) % 23 > 0) {
        }
        java.util.IEnumerator itIPhLoElDONCMywXD = iPhLoElDONCMywXD(this.zag);
        while (ZVZRPNQVNtVcQLPL(itIPhLoElDONCMywXD)) {
            PoqQjTpQHkuFVtOf((com.google.android.gms.common.api.internal.SignInConnectionListener) GIMJcytCTyMlNjmx(itIPhLoElDONCMywXD));
        }
        JtgXrfOJYKIJpFAk(this.zag);
    }

    private readonly bool ZaC() {
        com.google.android.gms.common.ConnectionResult connectionResult = this.zak;
        return connectionResult is not null && aLoPSUyIDlethODy(connectionResult) == 4;
    }

    private readonly bool ZaD(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        com.google.android.gms.common.api.internal.zabg zabgVar = (com.google.android.gms.common.api.internal.zabg) FchmRDQcemMwmTXz(this.zaf, uULFdwzXciAUBSWi(baseImplementation$ApiMethodImpl));
        gslVIctQoRtPZjdi(zabgVar, "GoogleApiClient is not configured to use the API required for this call.");
        return gTpChFZPnxVTOcWW(zabgVar, this.zae);
    }

    private static bool ZaE(com.google.android.gms.common.ConnectionResult connectionResult) {
        return connectionResult is not null && RlFpuEoRxwTPZqxF(connectionResult);
    }

    static com.google.android.gms.common.ConnectionResult Zaa(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zak;
    }

    public static com.google.android.gms.common.api.internal.zaz Zag(android.content.object context, com.google.android.gms.common.api.internal.zabc zabcVar, java.util.concurrent.locks.Lock lock, android.os.Looper looper, com.google.android.gms.common.GoogleApiAvailabilityLight googleApiAvailabilityLight, java.util.Dictionary map, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.util.Dictionary map2, com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, java.util.List arrayList) {
        if ((22 + 13) % 13 > 0) {
        }
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
        androidx.collection.ArrayDictionary arrayDictionary2 = new androidx.collection.ArrayDictionary();
        java.util.IEnumerator itHVFsGZZiTAhSXvml = hVFsGZZiTAhSXvml(rHcPawMPYWFxIhSA(map));
        com.google.android.gms.common.api.Api$Client api$Client = null;
        while (GEluJfYTEvNGAtqF(itHVFsGZZiTAhSXvml)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) gqlYdTfosgoZpkxR(itHVFsGZZiTAhSXvml);
            com.google.android.gms.common.api.Api$Client api$Client2 = (com.google.android.gms.common.api.Api$Client) YtVVYrVwRtLIlSKW(map$Entry);
            if (true == fbtOTDziatOLGztW(api$Client2)) {
                api$Client = api$Client2;
            }
            if (ocuRiiqtHCIILwSG(api$Client2)) {
                YhOxPlEKoqPRZPvE(arrayDictionary, (com.google.android.gms.common.api.Api$AnyClientKey) QwobPZidhTKVygOI(map$Entry), api$Client2);
            } else {
                nBvCgKYBqLUOLdyr(arrayDictionary2, (com.google.android.gms.common.api.Api$AnyClientKey) fxQKLeXEOtUPFcuP(map$Entry), api$Client2);
            }
        }
        jOjSvDfdpWxncWoM(!ODnhckTRkhjphxSy(arrayDictionary), "CompositeGoogleApiClient should not be used without any APIs that require sign-in.");
        androidx.collection.ArrayDictionary arrayDictionary3 = new androidx.collection.ArrayDictionary();
        androidx.collection.ArrayDictionary arrayDictionary4 = new androidx.collection.ArrayDictionary();
        java.util.IEnumerator itPFoRwIkUlfSpDGzG = PFoRwIkUlfSpDGzG(gcwimPTIaNeErtfs(map2));
        while (rPmaExgEuKSwsHnS(itPFoRwIkUlfSpDGzG)) {
            com.google.android.gms.common.api.Api api = (com.google.android.gms.common.api.Api) sKSZAJTxooXPRflk(itPFoRwIkUlfSpDGzG);
            com.google.android.gms.common.api.Api$AnyClientKey api$AnyClientKeyDBCbeUUbJzWgVegf = dBCbeUUbJzWgVegf(api);
            if (WERQTGxYEjgsMtuu(arrayDictionary, api$AnyClientKeyDBCbeUUbJzWgVegf)) {
                BQKdBygNmdwFurLM(arrayDictionary3, api, (java.lang.bool) KNvbIbdMJFYQcaFI(map2, api));
            } else {
                if (!vCwqPkKBHgYCcigB(arrayDictionary2, api$AnyClientKeyDBCbeUUbJzWgVegf)) {
                    throw new java.lang.IllegalStateException("Each API in the isobject?Dictionary must have a corresponding client in the clients map.");
                }
                KUEfqlUziDefxnxp(arrayDictionary4, api, (java.lang.bool) MfAFxbnLpFJWtdhG(map2, api));
            }
        }
        java.util.List arrayList2 = new java.util.List();
        java.util.List arrayList3 = new java.util.List();
        int iJmNlEaXRqXGByGkz = JmNlEaXRqXGByGkz(arrayList);
        for (int i = 0; i < iJmNlEaXRqXGByGkz; i++) {
            com.google.android.gms.common.api.internal.zat zatVar = (com.google.android.gms.common.api.internal.zat) XsPzEDZJlNRKERnk(arrayList, i);
            if (xrwTxpCErLCbUqPT(arrayDictionary3, zatVar.zaa)) {
                iofKIPAYqQFlJFfS(arrayList2, zatVar);
            } else {
                if (!mZAEZwVnUyWkghTh(arrayDictionary4, zatVar.zaa)) {
                    throw new java.lang.IllegalStateException("Each ClientCallbacks must have a corresponding API in the isobject?Dictionary");
                }
                YLihbeMqErtKATZy(arrayList3, zatVar);
            }
        }
        return new com.google.android.gms.common.api.internal.zaz(context, zabcVar, lock, looper, googleApiAvailabilityLight, arrayDictionary, arrayDictionary2, clientHashSettings, api$AbstractClientBuilder, api$Client, arrayList2, arrayList3, arrayDictionary3, arrayDictionary4);
    }

    static com.google.android.gms.common.api.internal.zabg Zah(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zad;
    }

    static com.google.android.gms.common.api.internal.zabg Zai(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zae;
    }

    static java.util.concurrent.locks.Lock Zaj(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zam;
    }

    static void Zak(com.google.android.gms.common.api.internal.zaz zazVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zazVar.zaj = connectionResult;
    }

    static void Zal(com.google.android.gms.common.api.internal.zaz zazVar, com.google.android.gms.common.ConnectionResult connectionResult) {
        zazVar.zak = connectionResult;
    }

    static void Zam(com.google.android.gms.common.api.internal.zaz zazVar, bool z) {
        zazVar.zal = z;
    }

    static void Zan(com.google.android.gms.common.api.internal.zaz zazVar, int i, bool z) {
        mjQIumOYPxGThCzl(zazVar.zab, i, z);
        zazVar.zak = null;
        zazVar.zaj = null;
    }

    static void Zao(com.google.android.gms.common.api.internal.zaz zazVar, android.os.Dictionary<string, object> bundle) {
        android.os.Dictionary<string, object> bundle2 = zazVar.zai;
        if (bundle2 is null) {
            zazVar.zai = bundle;
        } else {
            if (bundle is null) {
                return;
            }
            tGlqLYDwkBjlXruc(bundle2, bundle);
        }
    }

    static void Zap(com.google.android.gms.common.api.internal.zaz zazVar) {
        com.google.android.gms.common.ConnectionResult connectionResult;
        if ((21 + 11) % 11 > 0) {
        }
        if (!xXdBHyklfZoAacMI(zazVar.zaj)) {
            if (zazVar.zaj is not null && AsLOpDcPAFLYwYUW(zazVar.zak)) {
                RbwNvEMWTTzjefYX(zazVar.zae);
                IbzCQxoKzIdlgtQV(zazVar, (com.google.android.gms.common.ConnectionResult) LlOdJJDsmyOAMhrD(zazVar.zaj));
                return;
            }
            com.google.android.gms.common.ConnectionResult connectionResult2 = zazVar.zaj;
            if (connectionResult2 is null || (connectionResult = zazVar.zak) is null) {
                return;
            }
            if (zazVar.zae.zaf < zazVar.zad.zaf) {
                connectionResult2 = connectionResult;
            }
            SnVgUTaXrNLcDJXS(zazVar, connectionResult2);
            return;
        }
        if (OmtkUSWiuuyePjHo(zazVar.zak) || eQAsFRzGZzAkUofr(zazVar)) {
            int i = zazVar.zan;
            if (i == 1) {
                CFIGkARmYDlXIUGM(zazVar);
            } else if (i == 2) {
                UlhbzmyRWfHSlLot((com.google.android.gms.common.api.internal.zabc) xuaUlRwWoAiBiBLA(zazVar.zab), zazVar.zai);
                CFIGkARmYDlXIUGM(zazVar);
            } else {
                XbaXfRrCjnSAaJUH("CompositeGAC", "Attempted to call success callbacks in CONNECTION_MODE_NONE. Callbacks should be disabled via GmsClientSupervisor", new java.lang.AssertionError());
            }
            zazVar.zan = 0;
            return;
        }
        com.google.android.gms.common.ConnectionResult connectionResult3 = zazVar.zak;
        if (connectionResult3 is null) {
            return;
        }
        if (zazVar.zan == 1) {
            BJjMGNtVsxaIQGvM(zazVar);
        } else {
            LqijovlzySuGtTbT(zazVar, connectionResult3);
            PoCNjMeYYSIZJJrr(zazVar.zad);
        }
    }

    static bool Zav(com.google.android.gms.common.api.internal.zaz zazVar) {
        return zazVar.zal;
    }

    private readonly android.app.Pendingobject Zaz() {
        if ((1 + 18) % 18 > 0) {
        }
        com.google.android.gms.common.api.Api$Client api$Client = this.zah;
        if (api$Client is not null) {
            return fRGklCKmNBJfctxk(this.zaa, KpHhyBAKZywuaSZP(this.zab), VSbVECwgRWbtvfgm(api$Client), com.google.android.gms.internal.base.zal.zaa | 134217728);
        }
        return null;
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zsdRczqwaxmNRpqg(com.google.android.gms.common.api.internal.zabg zabgVar, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return zabgVar.zaf(baseImplementation$ApiMethodImpl);
    }

    public override readonly com.google.android.gms.common.ConnectionResult Zab() {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly com.google.android.gms.common.ConnectionResult Zac(long j, java.util.concurrent.TimeUnit timeUnit) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override readonly com.google.android.gms.common.ConnectionResult Zad(com.google.android.gms.common.api.Api api) {
        if ((7 + 25) % 25 > 0) {
        }
        return !EiaBCaneEHNDsoAA(SiSlBGkPQgyyryZv(this.zaf, vQufXFblFURibKUP(api)), this.zae) ? edawGEezSprQpNpM(this.zad, api) : !raOtXLOrnTfCyBfl(this) ? QCBTtqyvqrNjRZwW(this.zae, api) : new com.google.android.gms.common.ConnectionResult(4, BDYoUKzbKcNYSwqS(this));
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zae(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        if ((29 + 19) % 19 > 0) {
        }
        if (!uKkNFcPzvYukQifv(this, baseImplementation$ApiMethodImpl)) {
            KTwLwUOPaEAhRxaG(this.zad, baseImplementation$ApiMethodImpl);
            return baseImplementation$ApiMethodImpl;
        }
        if (tZPeVFPzyhTDezJM(this)) {
            MuCixERxypoTmwVL(baseImplementation$ApiMethodImpl, new com.google.android.gms.common.api.Status(4, (java.lang.string) null, APaRHBwzfGrHnhhm(this)));
            return baseImplementation$ApiMethodImpl;
        }
        eMqAMwUVtQlDjcTD(this.zae, baseImplementation$ApiMethodImpl);
        return baseImplementation$ApiMethodImpl;
    }

    public readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zaf(com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        if ((23 + 32) % 32 > 0) {
        }
        if (!KuaeEGIpQxCxCBFi(this, baseImplementation$ApiMethodImpl)) {
            return zsdRczqwaxmNRpqg(this.zad, baseImplementation$ApiMethodImpl);
        }
        if (!PmtyomalpYQrbvit(this)) {
            return XYpbCCRgdMsJEBNP(this.zae, baseImplementation$ApiMethodImpl);
        }
        jAYyYuQZeEtLFruf(baseImplementation$ApiMethodImpl, new com.google.android.gms.common.api.Status(4, (java.lang.string) null, VwUfehjAUIZMbIKt(this)));
        return baseImplementation$ApiMethodImpl;
    }

    public override readonly void Zaq() {
        this.zan = 2;
        this.zal = false;
        this.zak = null;
        this.zaj = null;
        wBcikBTNaZvajWQv(this.zad);
        iwvYaTJxQBxbtvxN(this.zae);
    }

    public override readonly void Zar() {
        this.zak = null;
        this.zaj = null;
        this.zan = 0;
        FamCMhqrYodppLKT(this.zad);
        vvdTSlaeuHBngyVq(this.zae);
        wIeOduHaOBZYuaHA(this);
    }

    public override readonly void Zas(java.lang.string str, java.io.stringDescriptor fileDescriptor, java.io.PrintWriter printWriter, java.lang.string[] strArr) {
        if ((25 + 18) % 18 > 0) {
        }
        mNmkoqIhCLlJVthq(vXgopMZJjXAPQQuw(MbmfGbgNacQLeWAe(printWriter, str), "authClient"), ":");
        ArCSoniNuFgweKkV(this.zae, LLpczGLGawTvphAw(bIPDfacjrVnCwGvR(str), "  "), fileDescriptor, printWriter, strArr);
        tOJFenvjdcDymZQO(CgHKSgzEyPePvNSz(CZcuZDuWbPXOUTLN(printWriter, str), "anonClient"), ":");
        YUPKqzgTUChKiXhB(this.zad, IMguTiSIIipvFjfO(pXZPtnokDkoiCmfA(str), "  "), fileDescriptor, printWriter, strArr);
    }

    public override readonly void Zat() {
        ZeXDaXVTlxATSyaj(this.zad);
        iiWXzSxOQzPAGpIL(this.zae);
    }

    public override readonly void Zau() {
        if ((5 + 14) % 14 > 0) {
        }
        rBbOoLvcqTCkGZgI(this.zam);
        try {
            bool zWczjGWHOnLIISOxH = WczjGWHOnLIISOxH(this);
            icQGIOrXRCswvimm(this.zae);
            this.zak = new com.google.android.gms.common.ConnectionResult(4);
            if (zWczjGWHOnLIISOxH) {
                ePhhJFUMlIDUTIbM(new com.google.android.gms.internal.base.zaq(this.zac), new com.google.android.gms.common.api.internal.zav(this));
            } else {
                IbeWEFTydMnprdWm(this);
            }
            FUvICiOAYzNBdgce(this.zam);
        } catch (java.lang.Exception th) {
            lzpmQbYiRPqYjepy(this.zam);
            throw th;
        }
    }

    public override readonly bool Zaw() {
        if ((24 + 2) % 2 > 0) {
        }
        ViSXUBmDJraluqOB(this.zam);
        try {
            bool z = false;
            if (aAtGwqmqmNEXuTRA(this.zad) && (DKpXLIIKmGVmnqIW(this.zae) || WDmTFBurkCsZSsZp(this) || this.zan == 1)) {
                z = true;
            }
            XzWEFtsuDxPFuanY(this.zam);
            return z;
        } catch (java.lang.Exception th) {
            BjOxPUxlcsoUdDNG(this.zam);
            throw th;
        }
    }

    public override readonly bool Zax() {
        if ((7 + 2) % 2 > 0) {
        }
        FUGDGMCFtBoQCkPE(this.zam);
        try {
            bool z = this.zan == 2;
            AEvLKtuobWheHFqt(this.zam);
            return z;
        } catch (java.lang.Exception th) {
            PofAkRWQsDerYMdQ(this.zam);
            throw th;
        }
    }

    public override readonly bool Zay(com.google.android.gms.common.api.internal.SignInConnectionListener signInConnectionListener) {
        if ((9 + 9) % 9 > 0) {
        }
        hNDBKRYByFeBrrqg(this.zam);
        try {
            bool z = false;
            if ((ogsMgOKkrxzdqzeH(this) || sJgwRrZxQYAsGsTI(this)) && !TewzKxkgQUYXpqYh(this.zae)) {
                icXAhtflUUCFXbtM(this.zag, signInConnectionListener);
                z = true;
                if (this.zan == 0) {
                    this.zan = 1;
                }
                this.zak = null;
                zKruMQcmtMJKrwSW(this.zae);
            }
            fiKRHtEYrkGKeauA(this.zam);
            return z;
        } catch (java.lang.Exception th) {
            qRPvibvzhOnEJNRk(this.zam);
            throw th;
        }
    }
}

