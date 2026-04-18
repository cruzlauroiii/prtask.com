namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class GoogleSignInResult : com.google.android.gms.common.api.Result {
    private readonly com.google.android.gms.common.api.Status zba;
    private readonly com.google.android.gms.auth.api.signin.GoogleSignInAccount zbb;

    public GoogleSignInResult(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount, com.google.android.gms.common.api.Status status) {
        this.zbb = googleSignInAccount;
        this.zba = status;
    }

    public static bool KPBvoNgymFfTtAyj(com.google.android.gms.common.api.Status status) {
        return status.isSuccess();
    }

    public com.google.android.gms.auth.api.signin.GoogleSignInAccount GetSignInAccount() {
        return this.zbb;
    }

    public override com.google.android.gms.common.api.Status GetStatus() {
        return this.zba;
    }

    public bool IsSuccess() {
        return KPBvoNgymFfTtAyj(this.zba);
    }
}

