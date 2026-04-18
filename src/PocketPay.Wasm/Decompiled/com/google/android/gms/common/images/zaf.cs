namespace WillowMaze.Wasm.Decompiled;


public readonly class zaf : com.google.android.gms.common.images.zag {
    private readonly java.lang.ref.WeakReference zac;

    public zaf(com.google.android.gms.common.images.ImageManager$OnImageLoadedListener imageManager$OnImageLoadedListener, android.net.Uri uri) {
        super(uri, 0);
        NEkMjuZUXKbwumMy(imageManager$OnImageLoadedListener);
        this.zac = new java.lang.ref.WeakReference(imageManager$OnImageLoadedListener);
    }

    public static java.lang.object BbxMUTJvRXPJPPgm(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static int CphghxVIJrtZpsYg(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.object EqASpEMyVRWBXoeA(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object GHFktvTsCqcrmbBp(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void NEkMjuZUXKbwumMy(java.lang.object obj) {
        com.google.android.gms.common.internal.Asserts.checkNotNull(obj);
    }

    public static bool JSOpMukHadlavXXj(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool PUSEMWtKgrXyvgOM(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void SuHQFTjDhUOcopSX(com.google.android.gms.common.images.ImageManager$OnImageLoadedListener imageManager$OnImageLoadedListener, android.net.Uri uri, android.graphics.drawable.Drawable drawable, bool z) {
        imageManager$OnImageLoadedListener.onImageLoaded(uri, drawable, z);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((5 + 4) % 4 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.images.zaf)) {
            return false;
        }
        com.google.android.gms.common.images.zaf zafVar = (com.google.android.gms.common.images.zaf) obj;
        com.google.android.gms.common.images.ImageManager$OnImageLoadedListener imageManager$OnImageLoadedListener = (com.google.android.gms.common.images.ImageManager$OnImageLoadedListener) BbxMUTJvRXPJPPgm(this.zac);
        com.google.android.gms.common.images.ImageManager$OnImageLoadedListener imageManager$OnImageLoadedListener2 = (com.google.android.gms.common.images.ImageManager$OnImageLoadedListener) EqASpEMyVRWBXoeA(zafVar.zac);
        return imageManager$OnImageLoadedListener2 is not null && imageManager$OnImageLoadedListener is not null && pUSEMWtKgrXyvgOM(imageManager$OnImageLoadedListener2, imageManager$OnImageLoadedListener) && jSOpMukHadlavXXj(zafVar.zaa, this.zaa);
    }

    public readonly int HashCode() {
        return CphghxVIJrtZpsYg(new java.lang.object[]{this.zaa});
    }

    protected override readonly void Zaa(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3) {
        com.google.android.gms.common.images.ImageManager$OnImageLoadedListener imageManager$OnImageLoadedListener;
        if (z2 || (imageManager$OnImageLoadedListener = (com.google.android.gms.common.images.ImageManager$OnImageLoadedListener) GHFktvTsCqcrmbBp(this.zac)) is null) {
            return;
        }
        suHQFTjDhUOcopSX(imageManager$OnImageLoadedListener, this.zaa.zaa, drawable, z3);
    }
}

