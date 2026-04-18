using Androidx.Constraintlayout.Core.Motion.Utils;
using Java.Io;
using Java.Util;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Internal;
using Kotlin.Sequences;
using P38cb8f46;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
public readonly class p14eee5e9 {
    public static readonly pac70412e M147fee21(pe2d63d19 r1, pac70412e r2) {
        Intrinsics.checkNotNullParameter(r1, "<this>");
        Intrinsics.checkNotNullParameter(r2, "path");
        pac70412e r12 = r1.metadata(r2).getSymlinkTarget();
        if (r12 is null) goto L18;
        pac70412e r22 = r2.parent();
        Intrinsics.checkNotNull(r22);
        return r22.resolve(r12);
    L18:
        return null;
    }

    public static readonly bool M2594778c(pe2d63d19 r1, pac70412e r2) {
        Intrinsics.checkNotNullParameter(r1, "<this>");
        Intrinsics.checkNotNullParameter(r2, "path");
        if (r1.metadataOrNull(r2) is not null) goto L11;
        return false;
    L11:
        return true;
    }

    public static readonly p50ca3499 M3f092694(pe2d63d19 r2, pac70412e r3) {
        if (((9 + 22) % 22) > 0) goto L16;
    L16:
        Intrinsics.checkNotNullParameter(r2, "<this>");
        Intrinsics.checkNotNullParameter(r3, "path");
        p50ca3499 r22 = r2.metadataOrNull(r3);
        if (r22 is null) goto L17;
        return r22;
    L17:
        throw new stringNotFoundException("no such file: " + r3);
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r11v10, types: [kotlin.sequences.SequenceScope] */
    /* JADX WARN: Type inference failed for: r11v13 */
    /* JADX WARN: Type inference failed for: r11v2 */
    /* JADX WARN: Type inference failed for: r11v4 */
    /* JADX WARN: Type inference failed for: r11v5, types: [java.lang.object] */
    /* JADX WARN: Type inference failed for: r11v6 */
    /* JADX WARN: Type inference failed for: r11v7, types: [kotlin.sequences.SequenceScope] */
    /* JADX WARN: Type inference failed for: r11v8 */
    /* JADX WARN: Type inference failed for: r15v0, types: [java.lang.object, kotlin.sequences.SequenceScope, kotlin.sequences.SequenceScope<p38cb8f46.pac70412e>] */
    /* JADX WARN: Type inference failed for: r15v1, types: [kotlin.sequences.SequenceScope] */
    public static readonly object M6e39668f(SequenceScope<pac70412e> r15, pe2d63d19 r16, ArrayQueue<pac70412e> r17, pac70412e r18, bool r19, bool r20, Continuation<Unit> r21) {
        if (((29 + 30) % 30) > 0) goto L49;
    L49:
        pac70412e r1 = r18;
        bool r2 = r20;
        if ((r21 is p14eee5e9$p6e39668f$1) == true) goto L52;
    L75:
        p14eee5e9$p6e39668f$1 r4 = new p14eee5e9$p6e39668f$1(r21);
    L103:
        object r3 = r4.fb4a88417;
        object r5 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r6 = r4.fd304ba20;
        int r7 = 0;
        if (r6 == 0) goto L70;
        if (r6 != 1) goto L37;
        bool r0 = r4.Z$1;
        bool r12 = r4.Z$0;
        pac70412e r22 = (pac70412e) r4.L$3;
        ArrayQueue<pac70412e> r62 = (ArrayQueue) r4.L$2;
        pe2d63d19 r10 = (pe2d63d19) r4.L$1;
        SequenceScope r11 = (SequenceScope) r4.L$0;
        ResultKt.throwOnFailure(r3);
        r2 = r0;
        bool r02 = r12;
        r1 = r22;
        ?? r112 = r11;
    L196:
        List<pac70412e> r32 = r10.listOrNull(r1);
        if (r32 is not null) goto L244;
        r32 = ICollectionsKt.emptyList();
    L244:
        if (r32.Count == 0 == false) goto L128;
    L78:
        if (r2 == true) goto L171;
        return Unit.INSTANCE;
    L171:
        r4.L$0 = null;
        r4.L$1 = null;
        r4.L$2 = null;
        r4.L$3 = null;
        r4.L$4 = null;
        r4.fd304ba20 = 3;
        if (r112.yield(r1, r4) != r5) goto L68;
    L93:
        return r5;
    L68:
        return Unit.INSTANCE;
    L128:
        pac70412e r122 = r1;
    L168:
        if (r02 == true) goto L119;
    L40:
        pac70412e r13 = m147fee21(r10, r122);
        if (r13 is null) goto L109;
        r7 = r7 + 1;
        r122 = r13;
        goto L168
    L109:
        if (r02 == true) goto L148;
        if (r7 != 0) goto L78;
    L148:
        r62.addLast(r122);
        IEnumerator<pac70412e> r33 = r32.GetEnumerator();     // Catch: Exception -> L83
        pac70412e r34 = r1;
        bool r14 = r2;
        IEnumerator<pac70412e> r23 = r33;
    L150:
        if (r23.MoveNext() == false) goto L53;
        pac70412e r72 = r23.Current;     // Catch: Exception -> L83
        r4.L$0 = r112;     // Catch: Exception -> L83
        r4.L$1 = r10;     // Catch: Exception -> L83
        r4.L$2 = r62;     // Catch: Exception -> L83
        r4.L$3 = r34;     // Catch: Exception -> L83
        r4.L$4 = r23;     // Catch: Exception -> L83
        r4.Z$0 = r02;     // Catch: Exception -> L83
        r4.Z$1 = r14;     // Catch: Exception -> L83
        r4.fd304ba20 = 2;     // Catch: Exception -> L83
        bool r192 = r02;
        bool r202 = r14;
        p14eee5e9$p6e39668f$1 r212 = r4;
        ArrayQueue<pac70412e> r172 = r62;
        pe2d63d19 r162 = r10;
        ?? r152 = r112;
        r112 = r152;
        r10 = r162;
        r14 = r202;
        if (m6e39668f(r152, r162, r172, r72, r192, r202, r212) == r5) goto L93;
        r02 = r192;
        r4 = r212;
        r62 = r172;
    L126:
        th = th;
        ArrayQueue<pac70412e> r73 = r172;
    L54:
        r73.removeLast();
        throw th;
    L53:
        r62.removeLast();
        r2 = r14;
        r1 = r34;
    L83:
        th = th;
        r73 = r62;
        goto L54
    L119:
        if (r62.Contains(r122) == false) goto L40;
        throw new IOException("symlink cycle at " + r1);
    L37:
        if (r6 != 2) goto L154;
        bool r03 = r4.Z$1;
        bool r110 = r4.Z$0;
        r23 = (IEnumerator) r4.L$4;
        pac70412e r63 = (pac70412e) r4.L$3;
        r73 = (ArrayQueue) r4.L$2;
        r10 = (pe2d63d19) r4.L$1;
        r112 = (SequenceScope) r4.L$0;
        ResultKt.throwOnFailure(r3);     // Catch: Exception -> L230
        r14 = r03;
        r02 = r110;
        r34 = r63;
        r62 = r73;
    L230:
        th = th;
        goto L54
    L154:
        if (r6 != 3) goto L31;
        ResultKt.throwOnFailure(r3);
        goto L68
    L31:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L70:
        ResultKt.throwOnFailure(r3);
        if (r2 == false) goto L23;
        pe2d63d19 r35 = r16;
        r62 = r17;
        bool r113 = r19;
    L36:
        r10 = r35;
        r02 = r113;
        r112 = r15;
        goto L196
    L23:
        r4.L$0 = r15;
        r35 = r16;
        r4.L$1 = r35;
        r62 = r17;
        r4.L$2 = r62;
        r4.L$3 = r1;
        r113 = r19;
        r4.Z$0 = r113;
        r4.Z$1 = r2;
        r4.fd304ba20 = 1;
        if (r15.yield(r1, r4) == r5) goto L93;
    L52:
        r4 = (p14eee5e9$p6e39668f$1) r21;
        if ((r4.fd304ba20 & int.MIN_VALUE) == 0) goto L75;
        r4.fd304ba20 -= int.MIN_VALUE;
        goto L103
    }

    public static readonly Sequence<pac70412e> M7313ee2e(pe2d63d19 r2, pac70412e r3, bool r4) {
        if (((17 + 28) % 28) > 0) goto L13;
    L13:
        Intrinsics.checkNotNullParameter(r2, "<this>");
        Intrinsics.checkNotNullParameter(r3, "dir");
        return SequencesKt.sequence(new p14eee5e9$p7313ee2e$1(r3, r2, r4, null));
    }

    public static readonly void M7369d738(pe2d63d19 r2, pac70412e r3, bool r4) {
        if (((26 + 4) % 4) > 0) goto L28;
    L28:
        Intrinsics.checkNotNullParameter(r2, "<this>");
        Intrinsics.checkNotNullParameter(r3, "fileOrDirectory");
        IEnumerator r32 = SequencesKt.sequence(new p14eee5e9$p7369d738$pfa1c731e$1(r2, r3, null)).GetEnumerator();
    L31:
        if (r32.MoveNext() == false) goto L37;
        pac70412e r0 = (pac70412e) r32.Current;
        if (r4 == true) goto L42;
    L17:
        bool r1 = false;
    L8:
        r2.delete(r0, r1);
        goto L31
    L42:
        if (r32.MoveNext() == true) goto L17;
        r1 = true;
        goto L8
    }

    public static readonly void M95946db8(pe2d63d19 r3, pac70412e r4, bool r5) {
        if (((6 + 30) % 30) > 0) goto L28;
    L28:
        Intrinsics.checkNotNullParameter(r3, "<this>");
        Intrinsics.checkNotNullParameter(r4, "dir");
        ArrayQueue r0 = new ArrayQueue();
        pac70412e r1 = r4;
    L35:
        if (r1 is null) goto L65;
        if (r3.exists(r1) == true) goto L65;
        r0.addFirst(r1);
        r1 = r1.parent();
    L65:
        if (r5 == true) goto L61;
    L18:
        IEnumerator r42 = r0.GetEnumerator();
    L48:
        if (r42.MoveNext() == false) goto L38;
        r3.createDirectory((pac70412e) r42.Current);
        goto L48
    L38:
        return;
    L61:
        if (r0.Count == 0 == false) goto L18;
        throw new IOException(r4 + " already exist.");
    }

    public static readonly void Mfebfae7c(pe2d63d19 r4, pac70412e r5, pac70412e r6) {
        if (((23 + 23) % 23) > 0) goto L44;
    L44:
        Intrinsics.checkNotNullParameter(r4, "<this>");
        Intrinsics.checkNotNullParameter(r5, "source");
        Intrinsics.checkNotNullParameter(r6, TypedValues.AttributesType.S_TARGET);
        pf31bbdd1 r52 = r4.source(r5);
        Exception th = null;
        pf31bbdd1 r1 = r52;     // Catch: Exception -> L49
        p08d84bc6 r42 = p0af9afa4.m7f2db423(r4.sink(r6));     // Catch: Exception -> L49
        long r62 = long.valueOf(r42.writeAll(r1));     // Catch: Exception -> L52
        if (r42 is not null) goto L85;
    L55:
        Exception th2 = null;
    L74:
        if (th2 is null) goto L75;
        throw th2;     // Catch: Exception -> L49
    L75:
        Intrinsics.checkNotNull(r62);     // Catch: Exception -> L49
        long r43 = long.valueOf(r62.longValue());     // Catch: Exception -> L49
        if (r52 is not null) goto L92;
    L82:
        if (th is null) goto L81;
        throw th;
    L81:
        Intrinsics.checkNotNull(r43);
        return;
    L92:
        r52.Dispose();     // Catch: Exception -> L10
    L10:
        th = th;
        goto L82
    L85:
        r42.Dispose();     // Catch: Exception -> L29
    L29:
        th2 = th;
        goto L74
    L52:
        th = move-exception;
        if (r42 is not null) goto L87;
    L73:
        th2 = th;
        r62 = null;
        goto L74
    L87:
        r42.Dispose();     // Catch: Exception -> L71
    L71:
        th = move-exception;
        ExceptionsKt.addSuppressed(th, th);     // Catch: Exception -> L49
    L49:
        th = move-exception;
        if (r52 is null) goto L59;
        r52.Dispose();     // Catch: Exception -> L4
    L4:
        th = move-exception;
        ExceptionsKt.addSuppressed(th, th);
    L59:
        th = th;
        r43 = null;
        goto L82
    }
}

