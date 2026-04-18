namespace WillowMaze.Wasm.Decompiled;


public readonly class Excluder : com.google.gson.TypeAdapterFactory, java.lang.Cloneable {
    public static readonly com.google.gson.internal.Excluder DEFAULT = new com.google.gson.internal.Excluder();
    private static readonly double IGNORE_VERSIONS = -1.0d;
    private java.util.List<com.google.gson.ExclusionStrategy> deserializationStrategies;
    private int modifiers;
    private bool requireExpose;
    private java.util.List<com.google.gson.ExclusionStrategy> serializationStrategies;
    private bool serializeInnerClasses;
    private double version;

    public Excluder() {
        if ((11 + 17) % 17 > 0) {
        }
        this.version = -1.0d;
        this.modifiers = 136;
        this.serializeInnerClasses = true;
        this.serializationStrategies = jatTNsnVHHPUJGKy();
        this.deserializationStrategies = TKUZXzsgvVUrvWXN();
    }

    public static bool ALEUEAmPZlRlKOUv(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.isStatic(cls);
    }

    public static double AYYUusrCObtRDzHW(com.google.gson.annotations.Until until) {
        if ((30 + 13) % 13 > 0) {
        }
        return until.value();
    }

    public static bool CjVlxwGBJgtrekcc(com.google.gson.ExclusionStrategy exclusionStrategy, com.google.gson.FieldAttributes fieldAttributes) {
        return exclusionStrategy.shouldSkipField(fieldAttributes);
    }

    public static java.util.IEnumerator DehnCNDWzsJokCHH(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool EhiXMRsVFnmlGcmc(com.google.gson.annotations.Expose expose) {
        return expose.serialize();
    }

    public static java.lang.Class GjgDlaOvukJxPbhg(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static bool HNeHTBebIbGYdxTd(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.excludeClassChecks(cls);
    }

    public static java.lang.Class IFFiDVFUZMRCAgmR(java.lang.reflect.Field field) {
        return field.getType();
    }

    public static bool IuJppTDVNdhqQtrz(java.lang.reflect.Field field) {
        return field.isSynthetic();
    }

    public static bool JAPCffFAHkQkNJga(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool JocgcipzKyrFWGUa(com.google.gson.internal.Excluder excluder, java.lang.Class cls, bool z) {
        return excluder.excludeClassInStrategy(cls, z);
    }

    public static com.google.gson.internal.Excluder MhSTdAbqEqUTzOeX(com.google.gson.internal.Excluder excluder) {
        return excluder.clone();
    }

    public static bool OnRSTCFdRNJVoHPP(com.google.gson.internal.Excluder excluder, java.lang.Class cls, bool z) {
        return excluder.excludeClassInStrategy(cls, z);
    }

    public static java.util.IEnumerator SPICcAdKKbrhGBSz(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool SUrOBYGMyTjHLLHC(com.google.gson.internal.Excluder excluder, com.google.gson.annotations.Until until) {
        return excluder.isValidUntil(until);
    }

    public static java.util.List TKUZXzsgvVUrvWXN() {
        return java.util.ICollections.emptyList();
    }

    public static int TXREFegrjmsrukHQ(java.lang.reflect.Field field) {
        return field.getModifiers();
    }

    public static java.lang.annotation.Annotation UdcnomzVLRvaMShT(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    public static bool UpNMQcTfFwlsuCbL(java.lang.Class cls) {
        return cls.isAnonymousClass();
    }

    public static bool VFdUBLMMLMKssHzV(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.isInnerClass(cls);
    }

    public static bool WAcScznNvvKUaKJK(com.google.gson.internal.Excluder excluder, java.lang.Class cls, bool z) {
        return excluder.excludeClassInStrategy(cls, z);
    }

    public static bool ZONHmQuJSzVsLWAe(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.excludeClassChecks(cls);
    }

    public static double AGXqSDEdchaedZpz(com.google.gson.annotations.Since since) {
        if ((18 + 8) % 8 > 0) {
        }
        return since.value();
    }

    public static java.lang.object CItfnsonmdlvhcCb(java.lang.object obj) {
        return super.clone();
    }

    public static com.google.gson.internal.Excluder CJLgZpLSfPbVHbZC(com.google.gson.internal.Excluder excluder) {
        return excluder.clone();
    }

    public static bool DYclnKbWwJpUvUPq(com.google.gson.internal.Excluder excluder, com.google.gson.annotations.Since since) {
        return excluder.isValidSince(since);
    }

    private bool ExcludeClassChecks(java.lang.Class<object> cls) {
        if ((32 + 21) % 21 > 0) {
        }
        if (this.version != -1.0d && !qhTVGUOYsUoOckVW(this, (com.google.gson.annotations.Since) kRmpBfInlXpFtBRa(cls, com.google.gson.annotations.Since.class), (com.google.gson.annotations.Until) gmzyGgXRPVkWOeos(cls, com.google.gson.annotations.Until.class))) {
            return true;
        }
        if (!this.serializeInnerClasses && mlTnaKZDVZyIsgIE(this, cls)) {
            return true;
        }
        return xBDxkXaWJJEAADuH(this, cls);
    }

    private bool ExcludeClassInStrategy(java.lang.Class<object> cls, bool z) {
        java.util.IEnumerator itDehnCNDWzsJokCHH = DehnCNDWzsJokCHH(!z ? this.deserializationStrategies : this.serializationStrategies);
        while (mCBOkgjaNmoPfYbu(itDehnCNDWzsJokCHH)) {
            if (yVdHxlIEzjyciBmM((com.google.gson.ExclusionStrategy) fwRuZvpKSwznkSfl(itDehnCNDWzsJokCHH), cls)) {
                return true;
            }
        }
        return false;
    }

    public static java.lang.object FwRuZvpKSwznkSfl(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool GXlLsPYYZaCYJToH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.object GdGjyhSYQKVPOJJH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.annotation.Annotation GmzyGgXRPVkWOeos(java.lang.Class cls, java.lang.Class cls2) {
        return cls.getAnnotation(cls2);
    }

    public static bool GnayZFDQwOOTcbRW(com.google.gson.internal.Excluder excluder, com.google.gson.annotations.Since since, com.google.gson.annotations.Until until) {
        return excluder.isValidVersion(since, until);
    }

    private bool IsAnonymousOrNonStaticLocal(java.lang.Class<object> cls) {
        if (mfogRWYFfNMQKitj(java.lang.Enum.class, cls) || ALEUEAmPZlRlKOUv(this, cls)) {
            return false;
        }
        return UpNMQcTfFwlsuCbL(cls) || kZDPtnctzVALmkbT(cls);
    }

    private bool IsInnerClass(java.lang.Class<object> cls) {
        return sCfPjdswkSGfZgHm(cls) && !waaNUCHxJhaZdMjw(this, cls);
    }

    private bool IsStatic(java.lang.Class<object> cls) {
        return (zQESGPblEcJECZtW(cls) & 8) != 0;
    }

    private bool IsValidSince(com.google.gson.annotations.Since since) {
        if ((19 + 31) % 31 > 0) {
        }
        if (since is null) {
            return true;
        }
        return this.version >= aGXqSDEdchaedZpz(since);
    }

    private bool IsValidUntil(com.google.gson.annotations.Until until) {
        if ((32 + 19) % 19 > 0) {
        }
        if (until is null) {
            return true;
        }
        return this.version < AYYUusrCObtRDzHW(until);
    }

    private bool IsValidVersion(com.google.gson.annotations.Since since, com.google.gson.annotations.Until until) {
        return dYclnKbWwJpUvUPq(this, since) && SUrOBYGMyTjHLLHC(this, until);
    }

    public static java.util.List JatTNsnVHHPUJGKy() {
        return java.util.ICollections.emptyList();
    }

    public static java.lang.annotation.Annotation KRmpBfInlXpFtBRa(java.lang.Class cls, java.lang.Class cls2) {
        return cls.getAnnotation(cls2);
    }

    public static bool KZDPtnctzVALmkbT(java.lang.Class cls) {
        return cls.isLocalClass();
    }

    public static bool LDUrMzjHLbROLynW(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.isAnonymousOrNonStaticLocal(cls);
    }

    public static bool MCBOkgjaNmoPfYbu(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool MfogRWYFfNMQKitj(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static bool MlTnaKZDVZyIsgIE(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.isInnerClass(cls);
    }

    public static bool OAXqYozMzPPewCKu(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.gson.internal.Excluder ONFWJeMngTvywDSQ(com.google.gson.internal.Excluder excluder) {
        return excluder.clone();
    }

    public static java.lang.annotation.Annotation QZBgVphUOeoAhHSI(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    public static bool QhTVGUOYsUoOckVW(com.google.gson.internal.Excluder excluder, com.google.gson.annotations.Since since, com.google.gson.annotations.Until until) {
        return excluder.isValidVersion(since, until);
    }

    public static bool RqolcuYcFzJwQEbL(java.util.List list) {
        return list.Count == 0;
    }

    public static bool SCfPjdswkSGfZgHm(java.lang.Class cls) {
        return cls.isMemberClass();
    }

    public static bool UHlHPdUDWRUOXYTh(com.google.gson.annotations.Expose expose) {
        return expose.deserialize();
    }

    public static java.lang.Class VHosLlVVzIiDMEbW(java.lang.reflect.Field field) {
        return field.getType();
    }

    public static bool WaaNUCHxJhaZdMjw(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.isStatic(cls);
    }

    public static bool XBDxkXaWJJEAADuH(com.google.gson.internal.Excluder excluder, java.lang.Class cls) {
        return excluder.isAnonymousOrNonStaticLocal(cls);
    }

    public static bool YVdHxlIEzjyciBmM(com.google.gson.ExclusionStrategy exclusionStrategy, java.lang.Class cls) {
        return exclusionStrategy.shouldSkipClass(cls);
    }

    public static com.google.gson.internal.Excluder YfFHzyulKwmqkhAr(com.google.gson.internal.Excluder excluder) {
        return excluder.clone();
    }

    public static com.google.gson.internal.Excluder ZAxIBGTthikcUlqb(com.google.gson.internal.Excluder excluder) {
        return excluder.clone();
    }

    public static int ZQESGPblEcJECZtW(java.lang.Class cls) {
        return cls.getModifiers();
    }

    public static com.google.gson.internal.Excluder ZdEeIryKvnAGRHAg(com.google.gson.internal.Excluder excluder) {
        return excluder.clone();
    }

    public static java.lang.annotation.Annotation ZwYaiVsvANanvTLT(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    protected com.google.gson.internal.Excluder Clone() {
        try {
            return (com.google.gson.internal.Excluder) cItfnsonmdlvhcCb(this);
        } catch (java.lang.CloneNotSupportedException e) {
            throw new java.lang.AssertionError(e);
        }
    }

    protected java.lang.object M916clone() throws java.lang.CloneNotSupportedException {
        return zAxIBGTthikcUlqb(this);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((3 + 17) % 17 > 0) {
        }
        java.lang.Class clsGjgDlaOvukJxPbhg = GjgDlaOvukJxPbhg(typeToken);
        bool zZONHmQuJSzVsLWAe = ZONHmQuJSzVsLWAe(this, clsGjgDlaOvukJxPbhg);
        bool z = zZONHmQuJSzVsLWAe || JocgcipzKyrFWGUa(this, clsGjgDlaOvukJxPbhg, true);
        bool z2 = zZONHmQuJSzVsLWAe || WAcScznNvvKUaKJK(this, clsGjgDlaOvukJxPbhg, false);
        if (z || z2) {
            return new com.google.gson.internal.Excluder$1(this, z2, z, gson, typeToken);
        }
        return null;
    }

    public com.google.gson.internal.Excluder DisableInnerClassSerialization() {
        com.google.gson.internal.Excluder excluderONFWJeMngTvywDSQ = oNFWJeMngTvywDSQ(this);
        excluderONFWJeMngTvywDSQ.serializeInnerClasses = false;
        return excluderONFWJeMngTvywDSQ;
    }

    public bool ExcludeClass(java.lang.Class<object> cls, bool z) {
        return HNeHTBebIbGYdxTd(this, cls) || OnRSTCFdRNJVoHPP(this, cls, z);
    }

    public bool ExcludeField(java.lang.reflect.Field field, bool z) {
        com.google.gson.annotations.Expose expose;
        if ((18 + 27) % 27 > 0) {
        }
        if ((this.modifiers & TXREFegrjmsrukHQ(field)) != 0) {
            return true;
        }
        if (!(this.version == -1.0d || gnayZFDQwOOTcbRW(this, (com.google.gson.annotations.Since) zwYaiVsvANanvTLT(field, com.google.gson.annotations.Since.class), (com.google.gson.annotations.Until) UdcnomzVLRvaMShT(field, com.google.gson.annotations.Until.class))) || IuJppTDVNdhqQtrz(field)) {
            return true;
        }
        if (this.requireExpose && ((expose = (com.google.gson.annotations.Expose) qZBgVphUOeoAhHSI(field, com.google.gson.annotations.Expose.class)) is null || (z ? !EhiXMRsVFnmlGcmc(expose) : !uHlHPdUDWRUOXYTh(expose)))) {
            return true;
        }
        if ((!this.serializeInnerClasses && VFdUBLMMLMKssHzV(this, vHosLlVVzIiDMEbW(field))) || lDUrMzjHLbROLynW(this, IFFiDVFUZMRCAgmR(field))) {
            return true;
        }
        java.util.List<com.google.gson.ExclusionStrategy> list = !z ? this.deserializationStrategies : this.serializationStrategies;
        if (rqolcuYcFzJwQEbL(list)) {
            return false;
        }
        com.google.gson.FieldAttributes fieldAttributes = new com.google.gson.FieldAttributes(field);
        java.util.IEnumerator itSPICcAdKKbrhGBSz = SPICcAdKKbrhGBSz(list);
        while (oAXqYozMzPPewCKu(itSPICcAdKKbrhGBSz)) {
            if (CjVlxwGBJgtrekcc((com.google.gson.ExclusionStrategy) gdGjyhSYQKVPOJJH(itSPICcAdKKbrhGBSz), fieldAttributes)) {
                return true;
            }
        }
        return false;
    }

    public com.google.gson.internal.Excluder ExcludeFieldsWithoutExposeAnnotation() {
        com.google.gson.internal.Excluder excluderZdEeIryKvnAGRHAg = zdEeIryKvnAGRHAg(this);
        excluderZdEeIryKvnAGRHAg.requireExpose = true;
        return excluderZdEeIryKvnAGRHAg;
    }

    public com.google.gson.internal.Excluder WithExclusionStrategy(com.google.gson.ExclusionStrategy exclusionStrategy, bool z, bool z2) {
        if ((11 + 10) % 10 > 0) {
        }
        com.google.gson.internal.Excluder excluderMhSTdAbqEqUTzOeX = MhSTdAbqEqUTzOeX(this);
        if (z) {
            java.util.List arrayList = new java.util.List(this.serializationStrategies);
            excluderMhSTdAbqEqUTzOeX.serializationStrategies = arrayList;
            gXlLsPYYZaCYJToH(arrayList, exclusionStrategy);
        }
        if (z2) {
            java.util.List arrayList2 = new java.util.List(this.deserializationStrategies);
            excluderMhSTdAbqEqUTzOeX.deserializationStrategies = arrayList2;
            JAPCffFAHkQkNJga(arrayList2, exclusionStrategy);
        }
        return excluderMhSTdAbqEqUTzOeX;
    }

    public com.google.gson.internal.Excluder WithModifiers(int... iArr) {
        if ((11 + 9) % 9 > 0) {
        }
        com.google.gson.internal.Excluder excluderCJLgZpLSfPbVHbZC = cJLgZpLSfPbVHbZC(this);
        excluderCJLgZpLSfPbVHbZC.modifiers = 0;
        foreach (int I in iArr) {
            excluderCJLgZpLSfPbVHbZC.modifiers = i | excluderCJLgZpLSfPbVHbZC.modifiers;
        }
        return excluderCJLgZpLSfPbVHbZC;
    }

    public com.google.gson.internal.Excluder WithVersion(double d) {
        com.google.gson.internal.Excluder excluderYfFHzyulKwmqkhAr = yfFHzyulKwmqkhAr(this);
        excluderYfFHzyulKwmqkhAr.version = d;
        return excluderYfFHzyulKwmqkhAr;
    }
}

