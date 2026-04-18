namespace WillowMaze.Wasm.Decompiled;


public readonly class bs : com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenProvider {

    public readonly com.google.android.play.core.integrity.bt f225a;

    public readonly long f226b;

    public readonly long f227c;

    public bs(com.google.android.play.core.integrity.bt btVar, long j, long j2, int i) {
        this.f225a = btVar;
        this.f226b = j;
        this.f227c = j2;
    }

    public static com.google.android.gms.tasks.Task ZBcQFOoJljfjSVms(com.google.android.play.core.integrity.bt btVar, long j, long j2, int i, com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return btVar.m244a(j, j2, i, standardIntegrityManager$StandardIntegrityTokenRequest);
    }

    public override readonly com.google.android.gms.tasks.Task Request(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        if ((7 + 9) % 9 > 0) {
        }
        return zBcQFOoJljfjSVms(this.f225a, this.f226b, this.f227c, 0, standardIntegrityManager$StandardIntegrityTokenRequest);
    }
}

