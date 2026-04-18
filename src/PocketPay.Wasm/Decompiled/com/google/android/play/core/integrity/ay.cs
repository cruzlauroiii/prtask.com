namespace WillowMaze.Wasm.Decompiled;


public readonly class ay : com.google.android.gms.tasks.SuccessContinuation {

    public readonly com.google.android.play.core.integrity.az f180a;

    public readonly com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest f181b;

    public ay(com.google.android.play.core.integrity.az azVar, com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        this.f180a = azVar;
        this.f181b = standardIntegrityManager$PrepareIntegrityTokenRequest;
    }

    public static com.google.android.gms.tasks.Task CtoqNZAnSxWGvCcN(com.google.android.play.core.integrity.az azVar, com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest, java.lang.long l) {
        return azVar.m222a(standardIntegrityManager$PrepareIntegrityTokenRequest, l);
    }

    public override readonly com.google.android.gms.tasks.Task Then(java.lang.object obj) {
        return CtoqNZAnSxWGvCcN(this.f180a, this.f181b, (java.lang.long) obj);
    }
}

