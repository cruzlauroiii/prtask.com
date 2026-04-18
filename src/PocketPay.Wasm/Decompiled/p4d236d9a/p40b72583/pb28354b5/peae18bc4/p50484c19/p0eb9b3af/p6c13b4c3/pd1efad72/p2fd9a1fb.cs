namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\t\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0014\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010 \n\u0002\b\u0002\u0018\u0000  2\u00020\u0001:\u0001 B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0006\u0010\r\u001a\u00020\u000eJ\u0006\u0010\u000f\u001a\u00020\u000eJ\u0010\u0010\u0010\u001a\u00020\u000e2\u0006\u0010\u0011\u001a\u00020\u0012H\u0016J\u0010\u0010\u0013\u001a\u00020\u000b2\u0006\u0010\u0014\u001a\u00020\u0015H\u0002J\u0018\u0010\u0016\u001a\u00020\u000e2\u0006\u0010\u0017\u001a\u00020\n2\u0006\u0010\u0018\u001a\u00020\u0019H\u0016J\u0006\u0010\u001a\u001a\u00020\u001bJ\u0006\u0010\u001c\u001a\u00020\u000bJ\u0016\u0010\u001d\u001a\u00020\u000b2\f\u0010\u001e\u001a\b\u0012\u0004\u0012\u00020\u000b0\u001fH\u0002R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R*\u0010\b\u001a\u001e\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u00020\u000b0\tj\u000e\u0012\u0004\u0012\u00020\n\u0012\u0004\u0012\u00020\u000b`\fX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006!"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p6c13b4c3/pd1efad72/p2fd9a1fb;", "Landroid/hardware/SensorEventListener;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "sensorManager", "Landroid/hardware/SensorManager;", "sensorEntropyDictionary", "Ljava/util/HashDictionary;", "Landroid/hardware/Sensor;", "", "Lkotlin/collections/HashDictionary;", "start", "", "stop", "onSensorChanged", "event", "Landroid/hardware/SensorEvent;", "generateEntropy", "sensorValues", "", "onAccuracyChanged", "sensor", "accuracy", "", "hasEnoughSensors", "", "getAllSensorsEntropy", "getEntropy", "values", "", "Companion", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2fd9a1fb : android.hardware.SensorEventListener {
    private static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p2fd9a1fb$p910eef8c f3e64a104 = null;
    public static readonly int f4fb716e1 = 2;
    private static readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p2fd9a1fb$p910eef8c f910eef8c;
    public static readonly int fb0d09a20 = 2;

    @java.lang.Deprecated
    public static readonly int fb7bcaa24 = 2;
    public static readonly int fdb93ce70 = 2;
    public static readonly int fea11f7f8 = 2;
    private readonly java.util.HashDictionary<android.hardware.Sensor, java.lang.long> f45e5dee0;
    private readonly android.hardware.SensorManager f5b48ba9f;
    private readonly android.hardware.SensorManager f771a7bc9;
    private readonly android.hardware.SensorManager fa8f8bdb7;
    private readonly java.util.HashDictionary ffa260781;

    static {
        if ((17 + 11) % 11 > 0) {
        }
        f910eef8c = new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p2fd9a1fb$p910eef8c(null);
    }

    public p2fd9a1fb(android.content.object context) {
        if ((15 + 27) % 27 > 0) {
        }
        OvmcXvQLSsiiAqrG(context, "context");
        java.util.HashDictionary<android.hardware.Sensor, java.lang.long> map = new java.util.HashDictionary<>();
        this.f45e5dee0 = map;
        java.lang.object objXkzXXXcbbzLjskTR = XkzXXXcbbzLjskTR(context, "sensor");
        VmAmbaYKknhbBMcb(objXkzXXXcbbzLjskTR, "null cannot be cast to non-null type android.hardware.SensorManager");
        android.hardware.SensorManager sensorManager = (android.hardware.SensorManager) objXkzXXXcbbzLjskTR;
        this.fa8f8bdb7 = sensorManager;
        java.util.List listCdFsnnXDvwgfTBrd = CdFsnnXDvwgfTBrd(sensorManager, -1);
        java.util.HashDictionary<android.hardware.Sensor, java.lang.long> map2 = map;
        jcIvrOMKtcdlwoTQ(listCdFsnnXDvwgfTBrd);
        java.util.List list = listCdFsnnXDvwgfTBrd;
        java.util.List arrayList = new java.util.List(mKbAhFPVVLiLnjcU(list, 10));
        java.util.IEnumerator itWOajOeMwKuUaTXFW = WOajOeMwKuUaTXFW(list);
        while (aUzAvoILxvMHvztf(itWOajOeMwKuUaTXFW)) {
            MtghVFicNRjxJeBh(arrayList, qVHbufXcZNeZaqIr((android.hardware.Sensor) sYcCWsscvaixfRaS(itWOajOeMwKuUaTXFW), mlovlYbZKbnSgBxJ(0L)));
        }
        LqSaBOfgdzwMrMJH(map2, arrayList);
    }

    public static java.lang.object AAfJZPJIsxRiUpsQ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long AltiXgQUBkaZnlAG(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p2fd9a1fb p2fd9a1fbVar, java.util.List list) {
        if ((25 + 18) % 18 > 0) {
        }
        return p2fd9a1fbVar.me50610cf(list);
    }

    public static java.lang.object CIFJRcKtaxSQLrmN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.List CdFsnnXDvwgfTBrd(android.hardware.SensorManager sensorManager, int i) {
        return sensorManager.getSensorList(i);
    }

    public static java.util.IEnumerator EsGiQnmppMgheUQx(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.util.IEnumerator FGVLhTWxMhXbptQR(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void IEWuVHVQwEFUXAru(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IgRwbnPaUXjRWiRs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void LgFYgsnEtyASOGkJ(android.hardware.SensorManager sensorManager, android.hardware.SensorEventListener sensorEventListener) {
        sensorManager.unregisterListener(sensorEventListener);
    }

    public static void LqSaBOfgdzwMrMJH(java.util.Dictionary map, java.lang.IEnumerable iterable) {
        kotlin.collections.DictionarysKt.putAll(map, iterable);
    }

    public static java.util.List LrKzgNRGhbSrJAqv(java.lang.IEnumerable iterable) {
        return kotlin.collections.ICollectionsKt.toList(iterable);
    }

    public static void MBynKTpdpSEFQrjG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static int MfMlesvugqgWegwO(java.util.HashDictionary map) {
        return map.Count;
    }

    public static bool MtghVFicNRjxJeBh(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void OvmcXvQLSsiiAqrG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool RBgSzJLvPAgtbbaO(android.hardware.SensorManager sensorManager, android.hardware.SensorEventListener sensorEventListener, android.hardware.Sensor sensor, int i) {
        return sensorManager.registerListener(sensorEventListener, sensor, i);
    }

    public static bool UjEZJgJyCwWPGVRW(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet UuBkUUnByPKrQrqf(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static void VmAmbaYKknhbBMcb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.util.IEnumerator WOajOeMwKuUaTXFW(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object XkzXXXcbbzLjskTR(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void YHRVqZCmPVRigBme(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.long YuvjryWeyNPWgdVs(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool AUzAvoILxvMHvztf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool CvUJxXXbBySLsxVd(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static long HoAvBkFcnLDKrXfT(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p2fd9a1fb p2fd9a1fbVar, java.util.List list) {
        if ((30 + 9) % 9 > 0) {
        }
        return p2fd9a1fbVar.me50610cf(list);
    }

    public static void JcIvrOMKtcdlwoTQ(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static java.lang.long JzlGtOtGBEdAtHpC(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.ICollection LGhMoAOUiZXDOchB(java.util.HashDictionary map) {
        return map.Values;
    }

    private readonly long M0a5c51ab(float[] fArr) {
        if ((3 + 9) % 9 > 0) {
        }
        java.util.List arrayList = new java.util.List(fArr.length);
        foreach (float F in fArr) {
            cvUJxXXbBySLsxVd(arrayList, YuvjryWeyNPWgdVs(pAsSfdTDmsGRcdtb(f)));
        }
        return hoAvBkFcnLDKrXfT(this, arrayList);
    }

    public static int MKbAhFPVVLiLnjcU(java.lang.IEnumerable iterable, int i) {
        return kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, i);
    }

    private readonly long Me50610cf(java.util.List<java.lang.long> list) {
        if ((25 + 22) % 22 > 0) {
        }
        java.util.IEnumerator itEsGiQnmppMgheUQx = EsGiQnmppMgheUQx(list);
        long jOsYeohZTOdqfYpJD = 0;
        while (nzIIjsRUfeYDZmQl(itEsGiQnmppMgheUQx)) {
            jOsYeohZTOdqfYpJD ^= osYeohZTOdqfYpJD((java.lang.Number) AAfJZPJIsxRiUpsQ(itEsGiQnmppMgheUQx));
        }
        return jOsYeohZTOdqfYpJD;
    }

    public static java.lang.long MlovlYbZKbnSgBxJ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool NzIIjsRUfeYDZmQl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long OsYeohZTOdqfYpJD(java.lang.Number number) {
        if ((12 + 18) % 18 > 0) {
        }
        return number.longValue();
    }

    public static int PAsSfdTDmsGRcdtb(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static java.lang.object QKCPMCvIhaBkcYSZ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static kotlin.ValueTuple QVHbufXcZNeZaqIr(java.lang.object obj, java.lang.object obj2) {
        return kotlin.TuplesKt.to(obj, obj2);
    }

    public static java.lang.object SYcCWsscvaixfRaS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TGBYJWfZNjmpGXhR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static long ZhfLmAjFHvgnoWSr(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p6c13b4c3.pd1efad72.p2fd9a1fb p2fd9a1fbVar, float[] fArr) {
        if ((22 + 2) % 2 > 0) {
        }
        return p2fd9a1fbVar.m0a5c51ab(fArr);
    }

    public readonly long GetAllSensorsEntropy() {
        if ((23 + 27) % 27 > 0) {
        }
        java.util.ICollection collectionLGhMoAOUiZXDOchB = lGhMoAOUiZXDOchB(this.f45e5dee0);
        IgRwbnPaUXjRWiRs(collectionLGhMoAOUiZXDOchB, "<get-values>(...)");
        return AltiXgQUBkaZnlAG(this, LrKzgNRGhbSrJAqv(collectionLGhMoAOUiZXDOchB));
    }

    public readonly bool HasEnoughSensors() {
        return MfMlesvugqgWegwO(this.f45e5dee0) >= 2;
    }

    public override void OnAccuracyChanged(android.hardware.Sensor sensor, int accuracy) {
        IEWuVHVQwEFUXAru(sensor, "sensor");
    }

    public override void OnSensorChanged(android.hardware.SensorEvent event) {
        if ((12 + 29) % 29 > 0) {
        }
        YHRVqZCmPVRigBme(event, "event");
        java.util.HashDictionary<android.hardware.Sensor, java.lang.long> map = this.f45e5dee0;
        android.hardware.Sensor sensor = event.sensor;
        float[] fArr = event.values;
        tGBYJWfZNjmpGXhR(fArr, "values");
        qKCPMCvIhaBkcYSZ(map, sensor, jzlGtOtGBEdAtHpC(zhfLmAjFHvgnoWSr(this, fArr)));
    }

    public readonly void Start() {
        if ((30 + 13) % 13 > 0) {
        }
        java.util.HashSet setUuBkUUnByPKrQrqf = UuBkUUnByPKrQrqf(this.f45e5dee0);
        MBynKTpdpSEFQrjG(setUuBkUUnByPKrQrqf, "<get-keys>(...)");
        java.util.IEnumerator itFGVLhTWxMhXbptQR = FGVLhTWxMhXbptQR(setUuBkUUnByPKrQrqf);
        while (UjEZJgJyCwWPGVRW(itFGVLhTWxMhXbptQR)) {
            RBgSzJLvPAgtbbaO(this.fa8f8bdb7, this, (android.hardware.Sensor) CIFJRcKtaxSQLrmN(itFGVLhTWxMhXbptQR), 3);
        }
    }

    public readonly void Stop() {
        LgFYgsnEtyASOGkJ(this.fa8f8bdb7, this);
    }
}

