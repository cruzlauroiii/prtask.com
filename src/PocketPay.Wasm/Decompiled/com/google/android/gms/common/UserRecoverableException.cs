namespace WillowMaze.Wasm.Decompiled;


public class UserRecoverableException : java.lang.Exception {
    private readonly android.content.object zza;

    public UserRecoverableException(java.lang.string str, android.content.object intent) {
        super(str);
        this.zza = intent;
    }

    public android.content.object Getobject() {
        return new android.content.object(this.zza);
    }
}

