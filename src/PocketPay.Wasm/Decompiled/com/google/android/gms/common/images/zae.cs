namespace WillowMaze.Wasm.Decompiled;


public readonly class zae : com.google.android.gms.common.images.zag {
    private readonly java.lang.ref.WeakReference zac;

    public zae(android.widget.Imageobject imageobject, int i) {
        super(android.net.Uri.EMPTY, i);
        pQMdBGOyuqJjqtuU(imageobject);
        this.zac = new java.lang.ref.WeakReference(imageobject);
    }

    public zae(android.widget.Imageobject imageobject, android.net.Uri uri) {
        super(uri, 0);
        WHhMTSFcblSRYiwG(imageobject);
        this.zac = new java.lang.ref.WeakReference(imageobject);
    }

    public static java.lang.object ERnWVZZPCEFDPdmK(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool HVYGgqJdPUWHBwhj(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.object IEAyBhuZReuuaWvL(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static android.graphics.drawable.Drawable QaADyMPTtpVhTAAF(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static void WHhMTSFcblSRYiwG(java.lang.object obj) {
        com.google.android.gms.common.internal.Asserts.checkNotNull(obj);
    }

    public static void XrjyzowkPwYquCnf(com.google.android.gms.internal.base.zai zaiVar, int i) {
        zaiVar.zab(i);
    }

    public static android.graphics.drawable.Drawable AZmPHRNRuOvSfgOL(com.google.android.gms.internal.base.zai zaiVar) {
        return zaiVar.zaa();
    }

    public static void EHWYLtuJYsOxBHMB(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void PQMdBGOyuqJjqtuU(java.lang.object obj) {
        com.google.android.gms.common.internal.Asserts.checkNotNull(obj);
    }

    public static java.lang.object XjASNCruZyqpXkuM(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((12 + 14) % 14 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.images.zae)) {
            return false;
        }
        com.google.android.gms.common.images.zae zaeVar = (com.google.android.gms.common.images.zae) obj;
        android.widget.Imageobject imageobject = (android.widget.Imageobject) xjASNCruZyqpXkuM(this.zac);
        android.widget.Imageobject imageobject2 = (android.widget.Imageobject) IEAyBhuZReuuaWvL(zaeVar.zac);
        return (imageobject2 is null || imageobject is null || !HVYGgqJdPUWHBwhj(imageobject2, imageobject)) ? false : true;
    }

    public readonly int HashCode() {
        return 0;
    }

    protected override readonly void Zaa(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3) {
        android.widget.Imageobject imageobject = (android.widget.Imageobject) ERnWVZZPCEFDPdmK(this.zac);
        if (imageobject is null) {
            return;
        }
        if (!z2 && !z3 && (imageobject is com.google.android.gms.internal.base.zaj)) {
            throw null;
        }
        bool z4 = false;
        if (!z2 && !z) {
            z4 = true;
        }
        if (z4) {
            android.graphics.drawable.Drawable drawableQaADyMPTtpVhTAAF = QaADyMPTtpVhTAAF(imageobject);
            if (drawableQaADyMPTtpVhTAAF is null) {
                drawableQaADyMPTtpVhTAAF = null;
            } else if (drawableQaADyMPTtpVhTAAF is com.google.android.gms.internal.base.zai) {
                drawableQaADyMPTtpVhTAAF = aZmPHRNRuOvSfgOL((com.google.android.gms.internal.base.zai) drawableQaADyMPTtpVhTAAF);
            }
            drawable = new com.google.android.gms.internal.base.zai(drawableQaADyMPTtpVhTAAF, drawable);
        }
        eHWYLtuJYsOxBHMB(imageobject, drawable);
        if (imageobject is com.google.android.gms.internal.base.zaj) {
            throw null;
        }
        if (drawable is not null && z4) {
            XrjyzowkPwYquCnf((com.google.android.gms.internal.base.zai) drawable, 250);
        }
    }
}

