namespace WillowMaze.Wasm.Decompiled;


public readonly class C0328u : android.os.IBinder$DeathRecipient {

    public readonly com.google.android.play.integrity.internal.ae f308a;

    public C0328u(com.google.android.play.integrity.internal.ae aeVar) {
        this.f308a = aeVar;
    }

    public static void ErtXyHVLqhUUTGJn(com.google.android.play.integrity.internal.ae aeVar) {
        com.google.android.play.integrity.internal.ae.m267k(aeVar);
    }

    public override readonly void BinderDied() {
        ertXyHVLqhUUTGJn(this.f308a);
    }
}

