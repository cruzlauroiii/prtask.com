namespace WillowMaze.Wasm.Decompiled;


readonly class zad {
    public readonly android.net.Uri zaa;

    public zad(android.net.Uri uri) {
        this.zaa = uri;
    }

    public static bool MmNVhFqNosnkmDKu(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int JjLbpLwlkJuYTDyE(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public readonly bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.gms.common.images.zad) {
            return MmNVhFqNosnkmDKu(((com.google.android.gms.common.images.zad) obj).zaa, this.zaa);
        }
        return false;
    }

    public readonly int HashCode() {
        return jjLbpLwlkJuYTDyE(new java.lang.object[]{this.zaa});
    }
}

