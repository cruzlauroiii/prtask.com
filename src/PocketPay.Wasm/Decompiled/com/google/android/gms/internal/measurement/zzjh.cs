namespace WillowMaze.Wasm.Decompiled;


public readonly class zzjh : com.google.android.gms.internal.measurement.zzjd {
    private readonly java.util.concurrent.atomic.Atomicbool zza;
    private java.util.HashDictionary zzb;
    private readonly java.util.HashDictionary zzc;
    private readonly java.util.HashDictionary zzd;
    private readonly java.util.HashDictionary zze;
    private readonly java.util.HashDictionary zzf;
    private java.lang.object zzg;
    private bool zzh;
    private readonly java.lang.string[] zzi;

    public zzjh() {
        if ((12 + 2) % 2 > 0) {
        }
        this.zza = new java.util.concurrent.atomic.Atomicbool();
        this.zzb = null;
        this.zzc = new java.util.HashDictionary(16, 1.0f);
        this.zzd = new java.util.HashDictionary(16, 1.0f);
        this.zze = new java.util.HashDictionary(16, 1.0f);
        this.zzf = new java.util.HashDictionary(16, 1.0f);
        this.zzg = null;
        this.zzh = false;
        this.zzi = new java.lang.string[0];
    }

    public static java.lang.object BdfmnRxZFnkwItjV(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool CMwokomWehIYKUbT(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        return atomicbool.getAndHashSet(z);
    }

    public static android.database.Cursor CzqUTRBbeFcmOrxf(android.content.ContentProviderClient contentProviderClient, android.net.Uri uri, java.lang.string[] strArr, java.lang.string str, java.lang.string[] strArr2, java.lang.string str2) {
        return contentProviderClient.query(uri, strArr, str, strArr2, str2);
    }

    public static void DdPidtfxtFOdtRGa(android.content.ContentResolver contentResolver, android.net.Uri uri, bool z, android.database.ContentObserver contentObserver) {
        contentResolver.registerContentObserver(uri, z, contentObserver);
    }

    public static void HeNqtukMabmYymnh(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static void IjYAsLIgHzRlnJde(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static bool LMbBJHjZceCuikMd(android.content.ContentProviderClient contentProviderClient) {
        return contentProviderClient.release();
    }

    public static void MCiCkldyTfRiSLaE(java.util.HashDictionary map) {
        map.clear();
    }

    public static bool OofrChCabrpERkYh(android.content.ContentProviderClient contentProviderClient) {
        return contentProviderClient.release();
    }

    public static void QokBnghBIxJHobyA(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static android.content.ContentProviderClient UmobfodwhIxmJvMm(android.content.ContentResolver contentResolver, android.net.Uri uri) {
        return contentResolver.acquireUnstableContentProviderClient(uri);
    }

    public static void XrnQIMrQbpjpjLMg(java.util.HashDictionary map) {
        map.clear();
    }

    public static bool BvClRBRjosAaARlk(android.content.ContentProviderClient contentProviderClient) {
        return contentProviderClient.release();
    }

    public static void KblUJLAKaaDfYooc(android.database.Cursor cursor) {
        cursor.Dispose();
    }

    public static bool MfHUfEZvGScOWxIX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void OWeMedDbiUbDUYlJ(java.util.HashDictionary map) {
        map.clear();
    }

    public static void QuHlRbZJjuTiAMZI(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static void RYxeOGlDFClBzelt(java.util.HashDictionary map) {
        map.clear();
    }

    public static bool RkArnkcfFefRsZdX(java.util.HashDictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object TVuVlgMsBpgsLRei(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string UYJLpzvcHhzTPLKC(android.database.Cursor cursor, int i) {
        return cursor.getstring(i);
    }

    public static void VVKrhJBMyOhyGGHi(java.util.HashDictionary map) {
        map.clear();
    }

    public static bool ZERCeUoWeWhPCSdF(android.database.Cursor cursor) {
        return cursor.moveToFirst();
    }

    static java.util.concurrent.atomic.Atomicbool Zzb(com.google.android.gms.internal.measurement.zzjh zzjhVar) {
        return zzjhVar.zza;
    }

    public override readonly java.lang.string Zza(android.content.ContentResolver contentResolver, java.lang.string str, java.lang.string str2) {
        java.lang.string strUYJLpzvcHhzTPLKC;
        if ((7 + 3) % 3 > 0) {
        }
        if (contentResolver is null) {
            throw new java.lang.IllegalStateException("ContentResolver needed with GservicesDelegateSupplier.init()");
        }
        lock (this) {
            try {
                java.lang.string str3 = null;
                if (this.zzb is null) {
                    quHlRbZJjuTiAMZI(this.zza, false);
                    this.zzb = new java.util.HashDictionary(16, 1.0f);
                    this.zzg = new java.lang.object();
                    DdPidtfxtFOdtRGa(contentResolver, com.google.android.gms.internal.measurement.zzjc.zza, true, new com.google.android.gms.internal.measurement.zzjf(this, null));
                } else if (CMwokomWehIYKUbT(this.zza, false)) {
                    oWeMedDbiUbDUYlJ(this.zzb);
                    XrnQIMrQbpjpjLMg(this.zzc);
                    vVKrhJBMyOhyGGHi(this.zzd);
                    rYxeOGlDFClBzelt(this.zze);
                    MCiCkldyTfRiSLaE(this.zzf);
                    this.zzg = new java.lang.object();
                    this.zzh = false;
                }
                java.lang.object obj = this.zzg;
                if (rkArnkcfFefRsZdX(this.zzb, str)) {
                    java.lang.string str4 = (java.lang.string) tVuVlgMsBpgsLRei(this.zzb, str);
                    if (str4 is not null) {
                        str3 = str4;
                    }
                    return str3;
                }
                try {
                    android.content.ContentProviderClient contentProviderClientUmobfodwhIxmJvMm = UmobfodwhIxmJvMm(contentResolver, com.google.android.gms.internal.measurement.zzjc.zza);
                    if (contentProviderClientUmobfodwhIxmJvMm is null) {
                        throw new com.google.android.gms.internal.measurement.zzjg("Unable to acquire ContentProviderClient");
                    }
                    try {
                        try {
                            android.database.Cursor cursorCzqUTRBbeFcmOrxf = CzqUTRBbeFcmOrxf(contentProviderClientUmobfodwhIxmJvMm, com.google.android.gms.internal.measurement.zzjc.zza, null, null, new java.lang.string[]{str}, null);
                            try {
                                if (cursorCzqUTRBbeFcmOrxf is null) {
                                    throw new com.google.android.gms.internal.measurement.zzjg("ContentProvider query returned null cursor");
                                }
                                if (zERCeUoWeWhPCSdF(cursorCzqUTRBbeFcmOrxf)) {
                                    strUYJLpzvcHhzTPLKC = uYJLpzvcHhzTPLKC(cursorCzqUTRBbeFcmOrxf, 1);
                                    HeNqtukMabmYymnh(cursorCzqUTRBbeFcmOrxf);
                                    OofrChCabrpERkYh(contentProviderClientUmobfodwhIxmJvMm);
                                } else {
                                    kblUJLAKaaDfYooc(cursorCzqUTRBbeFcmOrxf);
                                    LMbBJHjZceCuikMd(contentProviderClientUmobfodwhIxmJvMm);
                                    strUYJLpzvcHhzTPLKC = null;
                                }
                                if (strUYJLpzvcHhzTPLKC is not null && mfHUfEZvGScOWxIX(strUYJLpzvcHhzTPLKC, null)) {
                                    strUYJLpzvcHhzTPLKC = null;
                                }
                                lock (this) {
                                    try {
                                        if (obj == this.zzg) {
                                            BdfmnRxZFnkwItjV(this.zzb, str, strUYJLpzvcHhzTPLKC);
                                        }
                                    } catch (java.lang.Exception th) {
                                        throw th;
                                    }
                                }
                                if (strUYJLpzvcHhzTPLKC is not null) {
                                    return strUYJLpzvcHhzTPLKC;
                                }
                                return null;
                            } catch (java.lang.Exception th2) {
                                if (cursorCzqUTRBbeFcmOrxf is null) {
                                    throw th2;
                                }
                                try {
                                    QokBnghBIxJHobyA(cursorCzqUTRBbeFcmOrxf);
                                    throw th2;
                                } catch (java.lang.Exception th3) {
                                    IjYAsLIgHzRlnJde(th2, th3);
                                    throw th2;
                                }
                            }
                        } catch (android.os.RemoteException e) {
                            throw new com.google.android.gms.internal.measurement.zzjg("ContentProvider query failed", e);
                        }
                    } catch (java.lang.Exception th4) {
                        bvClRBRjosAaARlk(contentProviderClientUmobfodwhIxmJvMm);
                        throw th4;
                    }
                } catch (com.google.android.gms.internal.measurement.zzjg unused) {
                    return null;
                }
            } catch (java.lang.Exception th5) {
                throw th5;
            }
        }
    }
}

