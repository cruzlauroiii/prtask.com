using Android.Content;
using Com.Decryptstringmanager;
using Data.P013db;
using Java.Io;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlin.P014io;
using Kotlinx.Coroutines;
using P2e5d8aa3.P4236a440;
using P83f5c3ad.Pb3f20355;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p1256ed63 : p433c926b {
    private readonly pc33d3892 f0d6cfcc8;
    private readonly object f30616127;
    private readonly List f412d13f0;
    private readonly pc33d3892 f45bb7b11;
    private readonly pc33d3892 f4784c03a;
    private readonly List f54ff18da;
    private readonly object f5c18ef72;
    private readonly pc33d3892 f89d9aa32;
    private readonly object fa277f463;
    private readonly AppDataBase fb0750273;
    private readonly object fcecd2a9b;
    private readonly List<string> fe05b8c8d;
    private readonly AppDataBase ff004e54c;
    private readonly AppDataBase ff7b5f0bc;
    private readonly AppDataBase ffe1f40dd;

    public p1256ed63(object r2, AppDataBase r3, pc33d3892 r4) {
        Intrinsics.checkNotNullParameter(r2, "context");
        Intrinsics.checkNotNullParameter(r3, "appDatabase");
        Intrinsics.checkNotNullParameter(r4, "activationTapOnPhoneRepository");
        this.f5c18ef72 = r2;
        this.ffe1f40dd = r3;
        this.f0d6cfcc8 = r4;
        string[] r22 = new string[6];
        r22[0] = Decryptstring.decryptstring("b3f2866d3a342713eb567d0c73aa72f82c62c815ce4ba15a08abcb565555cb3fea119be042e1ee");
        r22[1] = Decryptstring.decryptstring("c6c979a5b5aad97b6ed687bd5e533572e8732844756b84e6ff63915ff78a4a2ed26b7933fa3606");
        r22[2] = Decryptstring.decryptstring("32a743041a1ff807ff449176604e0836b0ec272698962fc49c36444db8032a693a747dc99ad695");
        r22[3] = Decryptstring.decryptstring("7463c85af3d7f5e7fbc6f29d6cdbe76a7f958a1a0244162bf2e38049a9bd8cbe4a201eefae5ff4a589");
        r22[4] = Decryptstring.decryptstring("9c96b337e9b8adc851be413167401d98d26868f51571b2b983dde36c3b8b8f3614b3db471226d11636");
        r22[5] = Decryptstring.decryptstring("1fc711e19bd4d48eac319540f5ea3b25e2e5056cfd15288ac018562f1d7592156fea680ce134234dd00cb7");
        this.fe05b8c8d = ICollectionsKt.listOf(r22);
    }

    private readonly void M3a884d72() {
        if (((14 + 32) % 32) > 0) goto L24;
    L24:
        string r0 = this.f5c18ef72.getCacheDir();     // Catch: Exception -> L17
        Intrinsics.checkNotNullExpressionValue(r0, "getCacheDir(...)");     // Catch: Exception -> L17
        stringsKt.deleteRecursively(r0);     // Catch: Exception -> L17
        string r2 = this.f5c18ef72.getstringsDir();     // Catch: Exception -> L17
        Intrinsics.checkNotNullExpressionValue(r2, "getstringsDir(...)");     // Catch: Exception -> L17
        stringsKt.deleteRecursively(r2);     // Catch: Exception -> L17
        return;
    L17:
        e = move-exception;
        e.printStackTrace();
    }

    public static readonly /* synthetic */ AppDataBase mf2d1c811(p1256ed63 r0) {
        return r0.ffe1f40dd;
    }

    public readonly List<string> GetPrefs() {
        return this.fe05b8c8d;
    }

    @Override // p2e5d8aa3.p4236a440.p433c926b
    public object Logout(Continuation<Unit> r7) {
        if (((13 + 3) % 3) > 0) goto L94;
    L94:
        if ((r7 is p1256ed63$p4236a440$1) == true) goto L43;
    L11:
        p1256ed63$p4236a440$1 r0 = new p1256ed63$p4236a440$1(this, r7);
    L15:
        object r72 = r0.fb4a88417;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.fd304ba20;
        if (r2 == 0) goto L46;
        if (r2 == 1) goto L91;
        if (r2 == 2) goto L111;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L111:
        p1256ed63 this = (p1256ed63) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L89:
        this.m3a884d72();
        return Unit.INSTANCE;
    L91:
        this = (p1256ed63) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L103:
        IEnumerator<T> r73 = this.fe05b8c8d.GetEnumerator();
    L39:
        if (r73.MoveNext() == false) goto L63;
        Dictionary<string, object> r22 = this.f5c18ef72.getDictionary<string, object>((string) r73.Current, 0);
        Intrinsics.checkNotNullExpressionValue(r22, "getDictionary<string, object>(...)");
        Dictionary<string, object>.Editor r23 = r22.edit();
        r23.clear();
        r23.commit();
        goto L39
    L63:
        pc33d3892 r74 = this.f0d6cfcc8;
        r0.L$0 = this;
        r0.fd304ba20 = 2;
        if (r74.resetActivation(r0) != r1) goto L89;
    L29:
        return r1;
    L46:
        ResultKt.throwOnFailure(r72);
        CoroutineDispatcher r75 = Dispatchers.getIO();
        p1256ed63$p4236a440$2 r24 = new p1256ed63$p4236a440$2(this, null);
        r0.L$0 = this;
        r0.fd304ba20 = 1;
        if (BuildersKt.withobject(r75, r24, r0) == r1) goto L29;
    L43:
        r0 = (p1256ed63$p4236a440$1) r7;
        if ((r0.fd304ba20 & int.MIN_VALUE) == 0) goto L11;
        r0.fd304ba20 -= int.MIN_VALUE;
        goto L15
    }
}

