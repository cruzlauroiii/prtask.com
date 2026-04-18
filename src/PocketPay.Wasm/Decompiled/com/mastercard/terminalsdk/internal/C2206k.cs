namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.k */
/* JADX INFO: loaded from: classes2.dex */
public class C2206k {
    /* JADX INFO: renamed from: c */
    public static void M466c(char[] r4, char[] r5, int r6) {
            goto L24
        L4:
            goto L1a
        L7:
            goto L4c
        Lb:
            char r0 = r4[r0]
            goto La6
        L11:
            int r0 = r0 + r1
            goto L72
        L17:
            goto L83
        L1a:
            goto L32
        L1e:
            r5[r6] = r1
            goto L56
        L24:
            goto L7
        L27:
            goto L99
        L2b:
            r1 = 22
            goto L11
        L32:
            int r0 = r6 % 4
            goto Lb
        L38:
            int r3 = r3 * 32718
            goto L3e
        L3e:
            int r3 = r3 + r1
            goto L7d
        L43:
            if (r0 <= 0) goto L48
            goto L1a
        L48:
            goto L17
        L4c:
            goto L27
        L4f:
            r2 = 65535(0xffff, float:9.1834E-41)
            goto L78
        L56:
            r4[r6] = r0
            goto L82
        L5c:
            char r1 = (char) r3
            goto L1e
        L61:
            int r0 = r0 + r1
            goto L4f
        L66:
            int r6 = r6 + 3
            goto L87
        L6c:
            int r1 = r1 % 4
            goto L93
        L72:
            int r0 = r0 % r1
            goto L43
        L78:
            int r0 = r0 % r2
            goto Lac
        L7d:
            int r3 = r3 / r2
            goto L5c
        L82:
            return
        L83:
            goto L4
        L87:
            int r6 = r6 % 4
            goto L8d
        L8d:
            char r3 = r4[r6]
            goto L38
        L93:
            char r1 = r5[r1]
            goto L61
        L99:
            r0 = 21
            goto L2b
        La0:
            int r1 = r6 + 2
            goto L6c
        La6:
            int r0 = r0 * 32718
            goto La0
        Lac:
            char r0 = (char) r0
            goto L66
    }
}

