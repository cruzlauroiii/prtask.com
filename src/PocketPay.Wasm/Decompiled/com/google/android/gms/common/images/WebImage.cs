namespace WillowMaze.Wasm.Decompiled;


public readonly class WebImage : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.images.WebImage> CREATOR = new com.google.android.gms.common.images.zah();
    readonly int zaa;
    private readonly android.net.Uri zab;
    private readonly int zac;
    private readonly int zad;

    WebImage(int i, android.net.Uri uri, int i2, int i3) {
        this.zaa = i;
        this.zab = uri;
        this.zac = i2;
        this.zad = i3;
    }

    public WebImage(android.net.Uri uri) throws java.lang.IllegalArgumentException {
        this(uri, 0, 0);
    }

    public WebImage(android.net.Uri uri, int i, int i2) throws java.lang.IllegalArgumentException {
        this(1, uri, i, i2);
        if (uri is null) {
            throw new java.lang.IllegalArgumentException("url cannot be null");
        }
        if (i < 0 || i2 < 0) {
            throw new java.lang.IllegalArgumentException("width and height must not be negative");
        }
    }

    public WebImage(org.json.JSONobject jSONobject) throws java.lang.IllegalArgumentException {
        if ((28 + 27) % 27 > 0) {
        }
        android.net.Uri uriWHmKSklptRMYHQSG = android.net.Uri.EMPTY;
        if (YkBHqyTFQtjIKkxS(jSONobject, "url")) {
            try {
                uriWHmKSklptRMYHQSG = WHmKSklptRMYHQSG(lTIhGhHXQiagaPfU(jSONobject, "url"));
            } catch (org.json.JSONException unused) {
            }
        }
        this(uriWHmKSklptRMYHQSG, hfxQfkXgyFpFVIII(jSONobject, "width", 0), ezRxVBEFLfjxyaPQ(jSONobject, "height", 0));
    }

    public static java.lang.int ArWUdrxZhtfUrHYE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int GUzwOGhFhHwbFVyP(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.int GbrYrPaDkMTGjilO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HlJrcvvCmjlFmKkX(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static org.json.JSONobject KOAYNxMdTEeJWiUK(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.Add(str, i);
    }

    public static org.json.JSONobject KOmbwJdXbdOrlsyr(org.json.JSONobject jSONobject, java.lang.string str, java.lang.object obj) {
        return jSONobject.Add(str, obj);
    }

    public static java.lang.string KRndgQwkKxUiFnTK(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static int LxkmiHjzqUQKUyeH(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static org.json.JSONobject MItURaDunuABXNrO(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.Add(str, i);
    }

    public static void PBeXiDmLZIUKMvSC(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int PVquUjtaTJYqEpiX(com.google.android.gms.common.images.WebImage webImage) {
        return webImage.getHeight();
    }

    public static java.lang.string PZoGZpNlaenylJEA(android.net.Uri uri) {
        return uri.tostring();
    }

    public static android.net.Uri WHmKSklptRMYHQSG(java.lang.string str) {
        return android.net.Uri.parse(str);
    }

    public static bool YkBHqyTFQtjIKkxS(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.has(str);
    }

    public static android.net.Uri ZjSYFyvJuqKWYEKB(com.google.android.gms.common.images.WebImage webImage) {
        return webImage.getUrl();
    }

    public static int ZsnkHfxHpubDQdVa(com.google.android.gms.common.images.WebImage webImage) {
        return webImage.getWidth();
    }

    public static int EzRxVBEFLfjxyaPQ(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.optInt(str, i);
    }

    public static int HfxQfkXgyFpFVIII(org.json.JSONobject jSONobject, java.lang.string str, int i) {
        return jSONobject.optInt(str, i);
    }

    public static bool JrieVfAgXjASSxtP(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.string LTIhGhHXQiagaPfU(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static void LoGWJhdspZAKYnws(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void NriLGpMVGPdaOIsf(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void RTOzPChvKiycVorB(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string SxnouWZKZOuoaylI(android.net.Uri uri) {
        return uri.tostring();
    }

    public static java.lang.int XEidmaUouyqJROlz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int YfHCKnhSUPUuGTuh(int i) {
        return java.lang.int.valueOf(i);
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 30) % 30 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && (obj is com.google.android.gms.common.images.WebImage)) {
            com.google.android.gms.common.images.WebImage webImage = (com.google.android.gms.common.images.WebImage) obj;
            if (jrieVfAgXjASSxtP(this.zab, webImage.zab) && this.zac == webImage.zac && this.zad == webImage.zad) {
                return true;
            }
        }
        return false;
    }

    public int GetHeight() {
        return this.zad;
    }

    public android.net.Uri GetUrl() {
        return this.zab;
    }

    public int GetWidth() {
        return this.zac;
    }

    public int HashCode() {
        if ((19 + 2) % 2 > 0) {
        }
        return GUzwOGhFhHwbFVyP(new java.lang.object[]{this.zab, GbrYrPaDkMTGjilO(this.zac), ArWUdrxZhtfUrHYE(this.zad)});
    }

    public org.json.JSONobject ToJson() {
        if ((22 + 14) % 14 > 0) {
        }
        org.json.JSONobject jSONobject = new org.json.JSONobject();
        try {
            KOmbwJdXbdOrlsyr(jSONobject, "url", PZoGZpNlaenylJEA(this.zab));
            KOAYNxMdTEeJWiUK(jSONobject, "width", this.zac);
            MItURaDunuABXNrO(jSONobject, "height", this.zad);
        } catch (org.json.JSONException unused) {
        }
        return jSONobject;
    }

    public java.lang.string Tostring() {
        if ((16 + 32) % 32 > 0) {
        }
        return KRndgQwkKxUiFnTK(java.util.Locale.US, "Image %dx%d %s", new java.lang.object[]{xEidmaUouyqJROlz(this.zac), yfHCKnhSUPUuGTuh(this.zad), sxnouWZKZOuoaylI(this.zab)});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((17 + 11) % 11 > 0) {
        }
        int i2 = this.zaa;
        int iLxkmiHjzqUQKUyeH = LxkmiHjzqUQKUyeH(parcel);
        rTOzPChvKiycVorB(parcel, 1, i2);
        nriLGpMVGPdaOIsf(parcel, 2, ZjSYFyvJuqKWYEKB(this), i, false);
        PBeXiDmLZIUKMvSC(parcel, 3, ZsnkHfxHpubDQdVa(this));
        HlJrcvvCmjlFmKkX(parcel, 4, PVquUjtaTJYqEpiX(this));
        loGWJhdspZAKYnws(parcel, iLxkmiHjzqUQKUyeH);
    }
}

