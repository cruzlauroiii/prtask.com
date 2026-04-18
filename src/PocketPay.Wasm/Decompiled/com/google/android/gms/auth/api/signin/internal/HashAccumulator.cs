namespace WillowMaze.Wasm.Decompiled;


public class HashAccumulator {
    private int zaa = 1;

    public static int HvQTopmDtgVySrYa(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public com.google.android.gms.auth.api.signin.internal.HashAccumulator Addobject(java.lang.object obj) {
        this.zaa = (this.zaa * 31) + (obj is not null ? HvQTopmDtgVySrYa(obj) : 0);
        return this;
    }

    public int Hash() {
        return this.zaa;
    }

    public readonly com.google.android.gms.auth.api.signin.internal.HashAccumulator Zaa(bool z) {
        this.zaa = (this.zaa * 31) + (z ? 1 : 0);
        return this;
    }
}

