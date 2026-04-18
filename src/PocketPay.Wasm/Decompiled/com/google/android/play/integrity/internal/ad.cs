namespace WillowMaze.Wasm.Decompiled;


readonly class ad : android.content.ServiceConnection {

    readonly com.google.android.play.integrity.internal.ae f267a;

    ad(com.google.android.play.integrity.internal.ae aeVar, com.google.android.play.integrity.internal.ac acVar) {
        this.f267a = aeVar;
    }

    public static int JrHLjptPvzPKfUfu(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static bool MDfQChQNSNZBnssr(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static android.os.Handler SGONikAAYmZaHSMS(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m278c();
    }

    public static com.google.android.play.integrity.internal.C0326s FwGlrpBAHHUIvVPF(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m262f(aeVar);
    }

    public static int JTZUjYeYjMFgVVJV(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m329d(str, objArr);
    }

    public static bool KXkSZYTNeauUAcAv(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static com.google.android.play.integrity.internal.C0326s XjbhEcdFbaQtwkMc(com.google.android.play.integrity.internal.ae aeVar) {
        return com.google.android.play.integrity.internal.ae.m262f(aeVar);
    }

    public static android.os.Handler ZHvhUBBVaXAAGrLJ(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m278c();
    }

    public override readonly void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        if ((10 + 24) % 24 > 0) {
        }
        jTZUjYeYjMFgVVJV(xjbhEcdFbaQtwkMc(this.f267a), "ServiceConnectionImpl.onServiceConnected(%s)", new java.lang.object[]{componentName});
        MDfQChQNSNZBnssr(SGONikAAYmZaHSMS(this.f267a), new com.google.android.play.integrity.internal.aa(this, iBinder));
    }

    public override readonly void OnServiceDisconnected(android.content.ComponentName componentName) {
        if ((2 + 13) % 13 > 0) {
        }
        JrHLjptPvzPKfUfu(fwGlrpBAHHUIvVPF(this.f267a), "ServiceConnectionImpl.onServiceDisconnected(%s)", new java.lang.object[]{componentName});
        kXkSZYTNeauUAcAv(zHvhUBBVaXAAGrLJ(this.f267a), new com.google.android.play.integrity.internal.ab(this));
    }
}

