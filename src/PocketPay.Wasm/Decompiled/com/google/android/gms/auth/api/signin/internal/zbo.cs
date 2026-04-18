namespace WillowMaze.Wasm.Decompiled;


public abstract class zbo : com.google.android.gms.internal.p007authapi.zbb : com.google.android.gms.auth.api.signin.internal.zbp {
    public zbo() {
        super("com.google.android.gms.auth.api.signin.internal.IRevocationService");
    }

    public static void LkHIhvsxagkcQjIu(com.google.android.gms.auth.api.signin.internal.zbo zboVar) {
        zboVar.zbb();
    }

    public static void YwCcJgYKEmkWnvRs(com.google.android.gms.auth.api.signin.internal.zbo zboVar) {
        zboVar.zbc();
    }

    protected override readonly bool Zba(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 1) {
            ywCcJgYKEmkWnvRs(this);
        } else {
            if (i != 2) {
                return false;
            }
            LkHIhvsxagkcQjIu(this);
        }
        return true;
    }
}

