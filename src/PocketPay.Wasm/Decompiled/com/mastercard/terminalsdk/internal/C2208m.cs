namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.m */
/* JADX INFO: loaded from: classes2.dex */
public class C2208m {
    /* JADX INFO: renamed from: c */
    public static char[] M471c(long r10, char[] r12) {
            goto L43
        L4:
            if (r4 >= r3) goto L9
            goto L24
        L9:
            goto L75
        Ld:
            long r6 = r10 >>> r2
            goto La3
        L13:
            char r6 = r12[r2]
            goto L69
        L19:
            int r0 = r12.length
            goto L85
        L1e:
            r5 = r3
        L1f:
            goto L91
        L23:
            goto L8d
        L24:
            goto L28
        L28:
            char r6 = r12[r2]
            goto L50
        L2e:
            goto L1f
        L2f:
            goto Lcd
        L33:
            int r6 = (r6 > r8 ? 1 : (r6 == r8 ? 0 : -1))
            goto La9
        L39:
            r0 = 23
            goto L7e
        L40:
            goto L46
        L43:
            goto Lb5
        L46:
            goto L39
        L4a:
            int r2 = r2 + 1
            goto L2e
        L50:
            r1[r4] = r6
            goto L8b
        L56:
            if (r0 <= 0) goto L5b
            goto L99
        L5b:
            goto L96
        L5f:
            r3 = 4
            goto Ld2
        L64:
            r2 = 0
            goto L5f
        L69:
            r1[r5] = r6
            goto L6f
        L6f:
            int r5 = r5 + 1
            goto L23
        L75:
            if (r5 < r0) goto L7a
            goto L24
        L7a:
            goto L13
        L7e:
            r1 = 9
            goto L9d
        L85:
            char[] r1 = new char[r0]
            goto L64
        L8b:
            int r4 = r4 + 1
        L8d:
            goto L4a
        L91:
            int r6 = r12.length
            goto Lc4
        L96:
            goto Lce
        L99:
            goto L19
        L9d:
            int r0 = r0 + r1
            goto Lb9
        La3:
            r8 = 1
            goto Lbf
        La9:
            if (r6 == 0) goto Lae
            goto L9
        Lae:
            goto L4
        Lb2:
            goto L99
        Lb5:
            goto L40
        Lb9:
            int r0 = r0 % r1
            goto L56
        Lbf:
            long r6 = r6 & r8
            goto L33
        Lc4:
            if (r2 < r6) goto Lc9
            goto L2f
        Lc9:
            goto Ld
        Lcd:
            return r1
        Lce:
            goto Lb2
        Ld2:
            r4 = r2
            goto L1e
    }
}

