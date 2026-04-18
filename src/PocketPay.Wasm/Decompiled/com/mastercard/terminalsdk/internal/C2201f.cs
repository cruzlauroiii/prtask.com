namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.f */
/* JADX INFO: loaded from: classes2.dex */
public class C2201f {
    /* JADX INFO: renamed from: a */
    public static void M447a(byte[] r5, byte r6, long r7) {
            goto L81
        L4:
            long r1 = r1 & r7
            goto L91
        L9:
            r1 = r5[r0]
            goto L59
        Lf:
            goto L71
        L12:
            goto L54
        L16:
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            goto L75
        L1c:
            int r0 = r0 + 1
            goto L28
        L22:
            int r0 = r0 % r1
            goto L4b
        L28:
            goto L55
        L29:
            goto L70
        L2d:
            r1 = 31
            goto L97
        L34:
            r1 = 1
            goto L3a
        L3a:
            long r1 = r1 << r0
            goto L4
        L3f:
            r0 = 10
            goto L2d
        L46:
            int r1 = r5.length
            goto L88
        L4b:
            if (r0 <= 0) goto L50
            goto L12
        L50:
            goto Lf
        L54:
            r0 = 0
        L55:
            goto L46
        L59:
            r1 = r1 ^ r6
            goto L65
        L5e:
            goto L12
        L61:
            goto L7e
        L65:
            byte r1 = (byte) r1
            goto L6a
        L6a:
            r5[r0] = r1
        L6c:
            goto L1c
        L70:
            return
        L71:
            goto L5e
        L75:
            if (r1 != 0) goto L7a
            goto L6c
        L7a:
            goto L9
        L7e:
            goto L84
        L81:
            goto L61
        L84:
            goto L3f
        L88:
            if (r0 < r1) goto L8d
            goto L29
        L8d:
            goto L34
        L91:
            r3 = 0
            goto L16
        L97:
            int r0 = r0 + r1
            goto L22
    }
}

