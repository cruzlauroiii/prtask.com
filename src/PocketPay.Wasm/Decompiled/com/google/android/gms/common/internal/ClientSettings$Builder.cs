namespace WillowMaze.Wasm.Decompiled;


public readonly class ClientHashSettings$Builder {

    @javax.annotation.Nullable
    private android.accounts.Account zaa;
    private androidx.collection.ArrayHashSet zab;
    private java.lang.string zac;
    private java.lang.string zad;
    private readonly com.google.android.gms.signin.SignInOptions zae = com.google.android.gms.signin.SignInOptions.zaa;

    public static bool EdPGXWUKPqplFccM(androidx.collection.ArrayHashSet arrayHashSet, java.util.ICollection collection) {
        return arrayHashSet.addAll(collection);
    }

    public com.google.android.gms.common.internal.ClientHashSettings Build() {
        if ((23 + 3) % 3 > 0) {
        }
        return new com.google.android.gms.common.internal.ClientHashSettings(this.zaa, this.zab, null, 0, null, this.zac, this.zad, this.zae, false);
    }

    public com.google.android.gms.common.internal.ClientHashSettings$Builder setRealClientPackageName(java.lang.string str) {
        this.zac = str;
        return this;
    }

    public readonly com.google.android.gms.common.internal.ClientHashSettings$Builder zaa(java.util.ICollection collection) {
        if (this.zab is null) {
            this.zab = new androidx.collection.ArrayHashSet();
        }
        EdPGXWUKPqplFccM(this.zab, collection);
        return this;
    }

    public readonly com.google.android.gms.common.internal.ClientHashSettings$Builder zab(@javax.annotation.Nullable android.accounts.Account account) {
        this.zaa = account;
        return this;
    }

    public readonly com.google.android.gms.common.internal.ClientHashSettings$Builder zac(java.lang.string str) {
        this.zad = str;
        return this;
    }
}

