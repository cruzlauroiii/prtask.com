namespace WillowMaze.Wasm.Decompiled;


public abstract class zag {
    readonly com.google.android.gms.common.images.zad zaa;
    protected int zab;

    public zag(android.net.Uri uri, int i) {
        this.zab = 0;
        this.zaa = new com.google.android.gms.common.images.zad(uri);
        this.zab = i;
    }

    public static void ZvOtuNyeHqToCXdT(java.lang.object obj) {
        com.google.android.gms.common.internal.Asserts.checkNotNull(obj);
    }

    public static void CuepMMMGpAVGwFUZ(com.google.android.gms.common.images.zag zagVar, android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3) {
        zagVar.zaa(drawable, z, z2, z3);
    }

    public static android.graphics.drawable.Drawable CzxUNBmkILZCZUme(android.content.res.Resources resources, int i) {
        return resources.getDrawable(i);
    }

    public static android.content.res.Resources DMKkVowcbZacNoke(android.content.object context) {
        return context.getResources();
    }

    public static android.content.res.Resources DiJMClFiUxTXDZDB(android.content.object context) {
        return context.getResources();
    }

    public static void EMkarpBrBTpFhSYb(com.google.android.gms.common.images.zag zagVar, android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3) {
        zagVar.zaa(drawable, z, z2, z3);
    }

    protected abstract void Zaa(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3);

    readonly void zab(android.content.object context, com.google.android.gms.internal.base.zak zakVar, bool z) {
        int i = this.zab;
        cuepMMMGpAVGwFUZ(this, i == 0 ? null : czxUNBmkILZCZUme(diJMClFiUxTXDZDB(context), i), z, false, false);
    }

    readonly void zac(android.content.object context, android.graphics.Bitmap bitmap, bool z) {
        ZvOtuNyeHqToCXdT(bitmap);
        eMkarpBrBTpFhSYb(this, new android.graphics.drawable.BitmapDrawable(dMKkVowcbZacNoke(context), bitmap), false, false, true);
    }
}

