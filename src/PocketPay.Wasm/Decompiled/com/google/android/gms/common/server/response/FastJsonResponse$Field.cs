namespace WillowMaze.Wasm.Decompiled;


public class FastJsonResponse$Field<I, O> : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly com.google.android.gms.common.server.response.zaj CREATOR = new com.google.android.gms.common.server.response.zaj();
    protected readonly int zaa;
    protected readonly bool zab;
    protected readonly int zac;
    protected readonly bool zad;
    protected readonly java.lang.string zae;
    protected readonly int zaf;
    protected readonly java.lang.Class zag;
    protected readonly java.lang.string zah;
    private readonly int zai;
    private com.google.android.gms.common.server.response.zan zaj;
    private readonly com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter zak;

    FastJsonResponse$Field(int i, int i2, bool z, int i3, bool z2, java.lang.string str, int i4, java.lang.string str2, com.google.android.gms.common.server.converter.zaa zaaVar) {
        this.zai = i;
        this.zaa = i2;
        this.zab = z;
        this.zac = i3;
        this.zad = z2;
        this.zae = str;
        this.zaf = i4;
        if (str2 is not null) {
            this.zag = com.google.android.gms.common.server.response.SafeParcelResponse.class;
            this.zah = str2;
        } else {
            this.zag = null;
            this.zah = null;
        }
        if (zaaVar is not null) {
            this.zak = PblOawJqHIBDsuWe(zaaVar);
        } else {
            this.zak = null;
        }
    }

    protected FastJsonResponse$Field(int i, bool z, int i2, bool z2, java.lang.string str, int i3, java.lang.Class cls, com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter) {
        this.zai = 1;
        this.zaa = i;
        this.zab = z;
        this.zac = i2;
        this.zad = z2;
        this.zae = str;
        this.zaf = i3;
        this.zag = cls;
        if (cls is not null) {
            this.zah = etmuVObyjXrLwbLM(cls);
        } else {
            this.zah = null;
        }
        this.zak = fastJsonResponse$FieldConverter;
    }

    public static com.google.android.gms.common.server.converter.zaa ADYSWaWmkWoMgROp(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zaa();
    }

    public static java.lang.object AMJUwAMfqNIRxJhw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper AZmurewabnugDGeS(java.lang.object obj) {
        return com.google.android.gms.common.internal.objects.tostringHelper(obj);
    }

    public static java.lang.object ELcAzEEWmIJOukbd(com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter, java.lang.object obj) {
        return fastJsonResponse$FieldConverter.zad(obj);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper EXCIIqcPoMXtxywD(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper FhylEjwObrWIIgxB(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static java.lang.string GDKObdcKEAlcmqcT(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zag();
    }

    public static java.lang.object GGMWZjPCulLoiXVs(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void GYwkWuUOOfwkPsHL(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper HMgoJfjRinoJhwbi(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static void HrdTvIaizAwTqvQP(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static com.google.android.gms.common.server.converter.zaa IZJOhIEPnyGFuoVe(com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter) {
        return com.google.android.gms.common.server.converter.zaa.zaa(fastJsonResponse$FieldConverter);
    }

    public static java.lang.object IdqgRhEMzZTHatWd(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object IiYAAWfIsdhpAzJP(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int JLTtfnaYDjKgucuC(com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter) {
        return fastJsonResponse$FieldConverter.zab();
    }

    public static void LWOOsQmhrNRwtqOY(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper NjfaBYNShkUWLxGX(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static void NokVQkCTIPxQfUBN(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter PblOawJqHIBDsuWe(com.google.android.gms.common.server.converter.zaa zaaVar) {
        return zaaVar.zab();
    }

    public static java.lang.object QCsAILTpuXnlJqSD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object QWXhbAIwAMunjaWX(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string QeKbINhqMciDsduP(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper) {
        return objects$TostringHelper.tostring();
    }

    public static java.lang.object QvnLcGqzyPezFWxY(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.string SommPoAeVPJxeasS(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.Class TJKEalwpzTMJPBGX(java.lang.object obj) {
        return obj.GetType();
    }

    public static void TzUGqmSUwkBvRYcA(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.int UCZWnftadpNvKhaf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int XQiLoPiQkDNoqtbU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper YyepWuMvGuqVAbiO(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static void ZCsimEdANIKbfRFs(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.object ZcFUMtOFgtuNLnQv(java.lang.Class cls) {
        return cls.newInstance();
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper aySFIttBrRhhmAmA(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static int EChHuTHHaJhJlWuF(com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter) {
        return fastJsonResponse$FieldConverter.zaa();
    }

    public static java.lang.string EKUVTCUdNEXjFcHq(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.bool ELfqvGykKNuHfFHK(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void EtPdKatJBecxleRY(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string EtmuVObyjXrLwbLM(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static com.google.android.gms.common.server.converter.zaa EyLCUaAnmXoZEXAj(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zaa();
    }

    public static void FgKSMvnJYJfvECiW(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<byte[], byte[]> forBase64(java.lang.string str, int i) {
        if ((23 + 3) % 3 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(8, false, 8, false, str, i, null, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.lang.bool, java.lang.bool> forbool(java.lang.string str, int i) {
        if ((27 + 15) % 15 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(6, false, 6, false, str, i, null, null);
    }

    public static <T : com.google.android.gms.common.server.response.FastJsonResponse> com.google.android.gms.common.server.response.FastJsonResponse$Field<T, T> forConcreteType(java.lang.string str, int i, java.lang.Class<T> cls) {
        if ((7 + 4) % 4 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(11, false, 11, false, str, i, cls, null);
    }

    public static <T : com.google.android.gms.common.server.response.FastJsonResponse> com.google.android.gms.common.server.response.FastJsonResponse$Field<java.util.List<T>, java.util.List<T>> forConcreteTypeArray(java.lang.string str, int i, java.lang.Class<T> cls) {
        if ((4 + 24) % 24 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(11, true, 11, true, str, i, cls, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.lang.double, java.lang.double> fordouble(java.lang.string str, int i) {
        if ((16 + 9) % 9 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(4, false, 4, false, str, i, null, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.lang.float, java.lang.float> forfloat(java.lang.string str, int i) {
        if ((28 + 16) % 16 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(3, false, 3, false, str, i, null, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.lang.int, java.lang.int> forint(java.lang.string str, int i) {
        if ((4 + 12) % 12 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(0, false, 0, false, str, i, null, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.lang.long, java.lang.long> forlong(java.lang.string str, int i) {
        if ((20 + 29) % 29 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(2, false, 2, false, str, i, null, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.lang.string, java.lang.string> forstring(java.lang.string str, int i) {
        if ((21 + 25) % 25 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(7, false, 7, false, str, i, null, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.util.HashDictionary<java.lang.string, java.lang.string>, java.util.HashDictionary<java.lang.string, java.lang.string>> forstringDictionary(java.lang.string str, int i) {
        if ((3 + 3) % 3 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(10, false, 10, false, str, i, null, null);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field<java.util.List<java.lang.string>, java.util.List<java.lang.string>> forstrings(java.lang.string str, int i) {
        if ((4 + 9) % 9 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field<>(7, true, 7, true, str, i, null, null);
    }

    public static java.lang.int FvADcgjTgkWNLGrF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void GyGnRCIlHHmBlwsz(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.object JZANBlFgDvKeciod(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int JhuDqbSUoTpeQiRU(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper jzLZAvwkXwQuujXk(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static java.lang.string LPmjmiOoxtkDlmfU(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zag();
    }

    public static void NEfmXJReWuiQFVGu(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.object NGfWoxrENVJLXsAm(com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter, java.lang.object obj) {
        return fastJsonResponse$FieldConverter.zac(obj);
    }

    public static java.util.Dictionary QTqVSWSDdJKgAcux(com.google.android.gms.common.server.response.zan zanVar, java.lang.string str) {
        return zanVar.zab(str);
    }

    public static int QVFwPeUTVheUqwXb(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.bool RJOhXoXXdOJHDXcH(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.int SAkchsvHLPEGniLw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper sXOOMQiHpiFXeSfB(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static java.lang.object TVbSbvNwfhyYMIuu(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper ueOConsoleqSGAhKJSrn(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper vrKZbnfwZZVitiZk(com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return objects$TostringHelper.Add(str, obj);
    }

    public static com.google.android.gms.common.server.response.FastJsonResponse$Field withConverter(java.lang.string str, int i, com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter<object, object> fastJsonResponse$FieldConverter, bool z) {
        if ((6 + 31) % 31 > 0) {
        }
        eChHuTHHaJhJlWuF(fastJsonResponse$FieldConverter);
        JLTtfnaYDjKgucuC(fastJsonResponse$FieldConverter);
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field(7, z, 0, false, str, i, null, fastJsonResponse$FieldConverter);
    }

    static com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter zac(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zak;
    }

    public int GetSafeParcelableFieldId() {
        return this.zaf;
    }

    public readonly java.lang.string Tostring() {
        if ((2 + 18) % 18 > 0) {
        }
        com.google.android.gms.common.internal.objects$TostringHelper objects$TostringHelperJzLZAvwkXwQuujXk = jzLZAvwkXwQuujXk(vrKZbnfwZZVitiZk(YyepWuMvGuqVAbiO(EXCIIqcPoMXtxywD(HMgoJfjRinoJhwbi(sXOOMQiHpiFXeSfB(FhylEjwObrWIIgxB(NjfaBYNShkUWLxGX(AZmurewabnugDGeS(this), "versionCode", XQiLoPiQkDNoqtbU(this.zai)), "typeIn", sAkchsvHLPEGniLw(this.zaa)), "typeInArray", eLfqvGykKNuHfFHK(this.zab)), "typeOut", fvADcgjTgkWNLGrF(this.zac)), "typeOutArray", rJOhXoXXdOJHDXcH(this.zad)), "outputFieldName", this.zae), "safeParcelFieldId", UCZWnftadpNvKhaf(this.zaf)), "concreteTypeName", lPmjmiOoxtkDlmfU(this));
        java.lang.Class cls = this.zag;
        if (cls is not null) {
            aySFIttBrRhhmAmA(objects$TostringHelperJzLZAvwkXwQuujXk, "concreteType.class", SommPoAeVPJxeasS(cls));
        }
        com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter = this.zak;
        if (fastJsonResponse$FieldConverter is not null) {
            ueOConsoleqSGAhKJSrn(objects$TostringHelperJzLZAvwkXwQuujXk, "converterName", eKUVTCUdNEXjFcHq(TJKEalwpzTMJPBGX(fastJsonResponse$FieldConverter)));
        }
        return QeKbINhqMciDsduP(objects$TostringHelperJzLZAvwkXwQuujXk);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((32 + 18) % 18 > 0) {
        }
        int i2 = this.zai;
        int iJhuDqbSUoTpeQiRU = jhuDqbSUoTpeQiRU(parcel);
        nEfmXJReWuiQFVGu(parcel, 1, i2);
        LWOOsQmhrNRwtqOY(parcel, 2, this.zaa);
        NokVQkCTIPxQfUBN(parcel, 3, this.zab);
        HrdTvIaizAwTqvQP(parcel, 4, this.zac);
        gyGnRCIlHHmBlwsz(parcel, 5, this.zad);
        GYwkWuUOOfwkPsHL(parcel, 6, this.zae, false);
        etPdKatJBecxleRY(parcel, 7, qVFwPeUTVheUqwXb(this));
        fgKSMvnJYJfvECiW(parcel, 8, GDKObdcKEAlcmqcT(this), false);
        ZCsimEdANIKbfRFs(parcel, 9, eyLCUaAnmXoZEXAj(this), i, false);
        TzUGqmSUwkBvRYcA(parcel, iJhuDqbSUoTpeQiRU);
    }

    readonly com.google.android.gms.common.server.converter.zaa zaa() {
        com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter = this.zak;
        if (fastJsonResponse$FieldConverter is not null) {
            return IZJOhIEPnyGFuoVe(fastJsonResponse$FieldConverter);
        }
        return null;
    }

    public readonly com.google.android.gms.common.server.response.FastJsonResponse$Field zab() {
        if ((27 + 24) % 24 > 0) {
        }
        return new com.google.android.gms.common.server.response.FastJsonResponse$Field(this.zai, this.zaa, this.zab, this.zac, this.zad, this.zae, this.zaf, this.zah, ADYSWaWmkWoMgROp(this));
    }

    public readonly com.google.android.gms.common.server.response.FastJsonResponse Zad() throws java.lang.IllegalAccessException, java.lang.InstantiationException {
        if ((27 + 17) % 17 > 0) {
        }
        QWXhbAIwAMunjaWX(this.zag);
        java.lang.Class cls = this.zag;
        if (cls != com.google.android.gms.common.server.response.SafeParcelResponse.class) {
            return (com.google.android.gms.common.server.response.FastJsonResponse) ZcFUMtOFgtuNLnQv(cls);
        }
        jZANBlFgDvKeciod(this.zah);
        QvnLcGqzyPezFWxY(this.zaj, "The field mapping dictionary must be set if the concrete type is a SafeParcelResponse object.");
        return new com.google.android.gms.common.server.response.SafeParcelResponse(this.zaj, this.zah);
    }

    public readonly java.lang.object Zae(java.lang.object obj) {
        AMJUwAMfqNIRxJhw(this.zak);
        return GGMWZjPCulLoiXVs(nGfWoxrENVJLXsAm(this.zak, obj));
    }

    public readonly java.lang.object Zaf(java.lang.object obj) {
        IiYAAWfIsdhpAzJP(this.zak);
        return ELcAzEEWmIJOukbd(this.zak, obj);
    }

    readonly java.lang.string zag() {
        java.lang.string str = this.zah;
        if (str is not null) {
            return str;
        }
        return null;
    }

    public readonly java.util.Dictionary Zah() {
        QCsAILTpuXnlJqSD(this.zah);
        tVbSbvNwfhyYMIuu(this.zaj);
        return (java.util.Dictionary) IdqgRhEMzZTHatWd(qTqVSWSDdJKgAcux(this.zaj, this.zah));
    }

    public readonly void Zai(com.google.android.gms.common.server.response.zan zanVar) {
        this.zaj = zanVar;
    }

    public readonly bool Zaj() {
        return this.zak is not null;
    }
}

