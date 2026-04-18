namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.n */
/* JADX INFO: loaded from: classes2.dex */
public class C2209n {
    /* JADX INFO: renamed from: b */
    public static void M472b(char[] r8, char r9, char r10, char r11, char r12) {
            goto L58
        L4:
            goto Le3
        L7:
            goto L39
        Lb:
            int r7 = r5 >>> 5
            goto Laa
        L11:
            int r0 = r0 % r1
            goto Laf
        L17:
            int r6 = r4 << 4
            goto Lf8
        L1d:
            r1 = 25
            goto L4b
        L24:
            r8[r3] = r4
            goto L65
        L2a:
            char r0 = (char) r0
            goto L6b
        L2f:
            int r5 = r5 - r3
            goto L46
        L34:
            int r0 = r0 - r3
            goto L2a
        L39:
            goto L5b
        L3c:
            goto L7c
        L3d:
            goto Lc9
        L41:
            r6 = r6 ^ r7
            goto L96
        L46:
            char r3 = (char) r5
            goto Lc3
        L4b:
            int r0 = r0 + r1
            goto L11
        L51:
            r0 = 4
            goto L1d
        L58:
            goto L7
        L5b:
            goto L51
        L5f:
            char r5 = r8[r1]
            goto Lb8
        L65:
            int r3 = r4 + r0
            goto L17
        L6b:
            int r2 = r2 + 1
            goto L3c
        L71:
            r3 = 1
            goto Ld4
        L76:
            r6 = r6 ^ r7
            goto Lb
        L7b:
            r2 = r1
        L7c:
            goto L87
        L80:
            r0 = 58224(0xe370, float:8.1589E-41)
            goto La5
        L87:
            r3 = 16
            goto L8d
        L8d:
            if (r2 < r3) goto L92
            goto L3d
        L92:
            goto L71
        L96:
            int r4 = r4 - r6
            goto L9b
        L9b:
            char r4 = (char) r4
            goto L24
        La0:
            r3 = r3 ^ r6
            goto Lce
        La5:
            r1 = 0
            goto L7b
        Laa:
            int r7 = r7 + r12
            goto L41
        Laf:
            if (r0 <= 0) goto Lb4
            goto Le3
        Lb4:
            goto Le0
        Lb8:
            int r6 = r5 + r0
            goto Lda
        Lbe:
            int r7 = r7 + r11
            goto L76
        Lc3:
            r8[r1] = r3
            goto Le7
        Lc9:
            return
        Lca:
            goto L4
        Lce:
            int r4 = r4 >>> 5
            goto Lf3
        Ld4:
            char r4 = r8[r3]
            goto L5f
        Lda:
            int r7 = r5 << 4
            goto Lbe
        Le0:
            goto Lca
        Le3:
            goto L80
        Le7:
            r3 = 40503(0x9e37, float:5.6757E-41)
            goto L34
        Lee:
            r3 = r3 ^ r4
            goto L2f
        Lf3:
            int r4 = r4 + r10
            goto Lee
        Lf8:
            int r6 = r6 + r9
            goto La0
    }
}

