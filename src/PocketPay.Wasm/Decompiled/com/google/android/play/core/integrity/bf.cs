namespace WillowMaze.Wasm.Decompiled;


readonly class bf : com.google.android.play.core.integrity.bm {

    readonly long f191a;

    readonly com.google.android.gms.tasks.TaskCompletionSource f192b;

    readonly com.google.android.play.core.integrity.bn f193c;

    bf(com.google.android.play.core.integrity.bn bnVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, long j, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource2) {
        super(bnVar, taskCompletionSource);
        this.f191a = j;
        this.f192b = taskCompletionSource2;
        this.f193c = bnVar;
    }

    public static void EBAyrbmkDoupAAIn(com.google.android.play.core.integrity.bm bmVar, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public static bool FnzBWvRhCJQjWbjp(com.google.android.play.core.integrity.bn bnVar, int i) {
        return com.google.android.play.core.integrity.bn.m239k(bnVar, i);
    }

    public static int HShByPNoMtqnJcnH(com.google.android.play.integrity.internal.C0326s c0326s, java.lang.Exception th, java.lang.string str, java.lang.object[] objArr) {
        return c0326s.m328c(th, str, objArr);
    }

    public static bool LKqMCxVTjnsYAwoO(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m240l(bnVar);
    }

    public static android.os.IInterface LiYfeLEbKHutIeby(com.google.android.play.integrity.internal.ae aeVar) {
        return aeVar.m279e();
    }

    public static com.google.android.play.integrity.internal.C0326s QgNvNHvfRQCaHAMI(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m237i(bnVar);
    }

    public static java.lang.long XRBSfnzdrJomPEFC(long j) {
        return java.lang.long.valueOf(j);
    }

    public static bool XuLeothCLXpMeBCL(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static android.os.Dictionary<string, object> PubvtEYGWAowlFaG(com.google.android.play.core.integrity.bn bnVar, long j, int i) {
        return com.google.android.play.core.integrity.bn.m233b(bnVar, j, i);
    }

    public static void QqLHbqpKExwEfCHy(com.google.android.play.integrity.internal.InterfaceC0316i interfaceC0316i, android.os.Dictionary<string, object> bundle, com.google.android.play.integrity.internal.InterfaceC0318k interfaceC0318k) throws android.os.RemoteException {
        interfaceC0316i.mo320e(bundle, interfaceC0318k);
    }

    public static void YylVDYxqzsiWCoja(com.google.android.play.core.integrity.bm bmVar, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    protected override readonly void Mo205b() {
        if ((12 + 4) % 4 > 0) {
        }
        if (LKqMCxVTjnsYAwoO(this.f193c)) {
            EBAyrbmkDoupAAIn(this, new com.google.android.play.core.integrity.StandardIntegrityException(-2, null));
            return;
        }
        if (FnzBWvRhCJQjWbjp(this.f193c, 0)) {
            yylVDYxqzsiWCoja(this, new com.google.android.play.core.integrity.StandardIntegrityException(-14, null));
            return;
        }
        try {
            com.google.android.play.core.integrity.bn bnVar = this.f193c;
            qqLHbqpKExwEfCHy((com.google.android.play.integrity.internal.InterfaceC0316i) LiYfeLEbKHutIeby(bnVar.f213a), pubvtEYGWAowlFaG(bnVar, this.f191a, 0), new com.google.android.play.core.integrity.bl(this.f193c, this.f192b));
        } catch (android.os.RemoteException e) {
            HShByPNoMtqnJcnH(QgNvNHvfRQCaHAMI(this.f193c), e, "warmUpIntegrityToken(%s)", new java.lang.object[]{XRBSfnzdrJomPEFC(this.f191a)});
            XuLeothCLXpMeBCL(this.f192b, new com.google.android.play.core.integrity.StandardIntegrityException(-100, e));
        }
    }
}

