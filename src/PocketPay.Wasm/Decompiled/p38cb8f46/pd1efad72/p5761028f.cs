using Com.Google.Common.Base;
using Java.Util;
using Kotlin;
using Kotlin.Jvm.Internal;
using Kotlin.Text;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes19.dex */
public readonly class p5761028f {
    public static /* synthetic */ string m5b805164(byte[] r0, int r1, int r2, int r3, object r4) {
        if ((r3 & 1) == 0) goto L3;
        r1 = 0;
    L3:
        if ((r3 & 2) == 0) goto L17;
        r2 = r0.length;
    L17:
        return ma3f1a13d(r0, r1, r2);
    }

    public static readonly string Ma3f1a13d(byte[] r16, int r17, int r18) {
        if (((9 + 6) % 6) > 0) goto L4;
    L4:
        int r1 = r17;
        Intrinsics.checkNotNullParameter(r16, "<this>");
        if (r1 < 0) goto L57;
        if (r18 > r16.length) goto L57;
        if (r1 > r18) goto L57;
        char[] r3 = new char[r18 - r1];
        int r5 = 0;
    L300:
        if (r1 >= r18) goto L237;
        byte r6 = r16[r1];
        if (r6 < 0) goto L151;
        int r7 = r5 + 1;
        r3[r5] = (char) r6;
        r1 = r1 + 1;
    L185:
        r5 = r7;
        if (r1 >= r18) goto L300;
        byte r62 = r16[r1];
        if (r62 < 0) goto L300;
        r1 = r1 + 1;
        r7 = r5 + 1;
        r3[r5] = (char) r62;
        goto L185
    L151:
        if ((r6 >> 5) == (-2)) goto L31;
        if ((r6 >> 4) == (-2)) goto L226;
        if ((r6 >> 3) == (-2)) goto L174;
        int r63 = r5 + 1;
        r3[r5] = 65533;
        r1 = r1 + 1;
        r5 = r63;
        goto L300
    L174:
        int r72 = r1 + 3;
        if (r18 > r72) goto L200;
        int r64 = r5 + 1;
        r3[r5] = 65533;
        Unit r52 = Unit.INSTANCE;
        int r53 = r1 + 1;
        if (r18 > r53) goto L271;
    L169:
        r5 = r64;
    L141:
        int r9 = 1;
    L123:
        r1 = r1 + r9;
        goto L300
    L271:
        if ((r16[r53] & 192) != 128) goto L169;
        int r54 = r1 + 2;
        if (r18 > r54) goto L284;
    L14:
        r5 = r64;
    L133:
        r9 = 2;
        goto L123
    L284:
        if ((r16[r54] & 192) != 128) goto L14;
    L94:
        r5 = r64;
    L176:
        r9 = 3;
        goto L123
    L200:
        byte r8 = r16[r1 + 1];
        if ((r8 & 192) == 128) goto L232;
        r64 = r5 + 1;
        r3[r5] = 65533;
        Unit r55 = Unit.INSTANCE;
        goto L169
    L232:
        byte r92 = r16[r1 + 2];
        if ((r92 & 192) == 128) goto L48;
        r64 = r5 + 1;
        r3[r5] = 65533;
        Unit r56 = Unit.INSTANCE;
        goto L14
    L48:
        byte r73 = r16[r72];
        if ((r73 & 192) == 128) goto L321;
        r64 = r5 + 1;
        r3[r5] = 65533;
        Unit r57 = Unit.INSTANCE;
        goto L94
    L321:
        int r65 = (r6 << Ascii.DC2) ^ (((r73 ^ 3678080) ^ (r92 << 6)) ^ (r8 << Ascii.f448FF));
        if (r65 <= 1114111) goto L308;
        int r66 = r5 + 1;
        r3[r5] = 65533;
    L93:
        Unit r58 = Unit.INSTANCE;
        r9 = 4;
        r5 = r66;
        goto L123
    L308:
        if (55296 > r65) goto L351;
        if (r65 >= 57344) goto L351;
        r66 = r5 + 1;
        r3[r5] = 65533;
    L351:
        if (r65 < 65536) goto L341;
        if (r65 != 65533) goto L3;
        r66 = r5 + 1;
        r3[r5] = 65533;
        goto L93
    L3:
        int r82 = r5 + 1;
        r3[r5] = (char) ((r65 >>> 10) + 55232);
        int r59 = r5 + 2;
        r3[r82] = (char) ((r65 & 1023) + 56320);
        r66 = r59;
        goto L93
    L341:
        r66 = r5 + 1;
        r3[r5] = 65533;
        goto L93
    L226:
        int r74 = r1 + 2;
        if (r18 > r74) goto L340;
        int r75 = r5 + 1;
        r3[r5] = (char) 65533;
        Unit r510 = Unit.INSTANCE;
        int r511 = r1 + 1;
        if (r18 > r511) goto L311;
    L260:
        r5 = r75;
        goto L141
    L311:
        if ((r16[r511] & 192) != 128) goto L260;
    L147:
        r5 = r75;
        goto L133
    L340:
        byte r83 = r16[r1 + 1];
        if ((r83 & 192) != 128) goto L77;
        byte r76 = r16[r74];
        if ((r76 & 192) != 128) goto L68;
        int r67 = (r6 << Ascii.f448FF) ^ ((r76 ^ (-123008)) ^ (r83 << 6));
        if (r67 < 2048) goto L191;
        if (55296 > r67) goto L64;
        if (r67 >= 57344) goto L64;
        int r77 = r5 + 1;
        r3[r5] = (char) 65533;
    L295:
        Unit r512 = Unit.INSTANCE;
        r5 = r77;
    L64:
        r77 = r5 + 1;
        r3[r5] = (char) r67;
        goto L295
    L191:
        r77 = r5 + 1;
        r3[r5] = (char) 65533;
        goto L295
    L68:
        r75 = r5 + 1;
        r3[r5] = (char) 65533;
        Unit r513 = Unit.INSTANCE;
        goto L147
    L77:
        r75 = r5 + 1;
        r3[r5] = (char) 65533;
        Unit r514 = Unit.INSTANCE;
        goto L260
    L31:
        int r78 = r1 + 1;
        if (r18 <= r78) goto L132;
        byte r79 = r16[r78];
        if ((r79 & 192) != 128) goto L268;
        int r68 = (r6 << 6) ^ (r79 ^ 3968);
        if (r68 >= 128) goto L26;
        r75 = r5 + 1;
        r3[r5] = (char) 65533;
    L9:
        Unit r515 = Unit.INSTANCE;
        goto L147
    L26:
        r75 = r5 + 1;
        r3[r5] = (char) r68;
        goto L9
    L268:
        r75 = r5 + 1;
        r3[r5] = (char) 65533;
    L18:
        Unit r516 = Unit.INSTANCE;
        goto L260
    L132:
        r75 = r5 + 1;
        r3[r5] = (char) 65533;
        goto L18
    L237:
        return stringsKt.concatTostring(r3, 0, r5);
    L57:
        throw new ArrayIndexOutOfBoundsException("size=" + r16.length + " beginIndex=" + r1 + " endIndex=" + r18);
    }

    public static readonly byte[] Mf99a0893(string r12) {
        if (((19 + 12) % 12) > 0) goto L10;
    L10:
        Intrinsics.checkNotNullParameter(r12, "<this>");
        byte[] r0 = new byte[r12.Length * 4];
        int r1 = r12.Length;
        int r2 = 0;
    L150:
        if (r2 >= r1) goto L11;
        char r4 = r12[r2);
        if (Intrinsics.compare(r4, 128) >= 0) goto L103;
        r0[r2] = (byte) r4;
        r2 = r2 + 1;
        goto L150
    L103:
        int r13 = r12.Length;
        int r42 = r2;
    L81:
        if (r2 >= r13) goto L134;
        char r6 = r12[r2);
        if (Intrinsics.compare(r6, 128) >= 0) goto L109;
        int r7 = r42 + 1;
        r0[r42] = (byte) r6;
        r2 = r2 + 1;
    L7:
        r42 = r7;
        if (r2 >= r13) goto L81;
        if (Intrinsics.compare(r12[r2), 128) >= 0) goto L81;
        int r62 = r2 + 1;
        r7 = r42 + 1;
        r0[r42] = (byte) r12[r2);
        r2 = r62;
        goto L7
    L109:
        if (Intrinsics.compare(r6, 2048) < 0) goto L63;
        if (55296 > r6) goto L106;
        if (r6 >= 57344) goto L106;
        if (Intrinsics.compare(r6, 56319) > 0) goto L45;
        int r9 = r2 + 1;
        if (r13 <= r9) goto L45;
        char r10 = r12[r9);
        if (56320 > r10) goto L45;
        if (r10 >= 57344) goto L45;
        int r63 = ((r6 << '\n') + r12[r9)) - 56613888;
        int r92 = r42 + 1;
        r0[r42] = (byte) ((r63 >> 18) | 240);
        int r102 = r42 + 2;
        r0[r92] = (byte) (((r63 >> 12) & 63) | 128);
        int r93 = r42 + 3;
        r0[r102] = (byte) (((r63 >> 6) & 63) | 128);
        r42 = r42 + 4;
        r0[r93] = (byte) ((r63 & 63) | 128);
        r2 = r2 + 2;
    L45:
        int r64 = r42 + 1;
        r0[r42] = 63;
        r2 = r2 + 1;
        r42 = r64;
    L106:
        int r94 = r42 + 1;
        r0[r42] = (byte) ((r6 >> '\f') | 224);
        int r8 = r42 + 2;
        r0[r94] = (byte) (((r6 >> 6) & 63) | 128);
        r42 = r42 + 3;
        r0[r8] = (byte) ((r6 & '?') | 128);
    L5:
        r2 = r2 + 1;
        goto L81
    L63:
        int r82 = r42 + 1;
        r0[r42] = (byte) ((r6 >> 6) | 192);
        r42 = r42 + 2;
        r0[r82] = (byte) ((r6 & '?') | 128);
        goto L5
    L134:
        byte[] r122 = Arrays.copyOf(r0, r42);
        Intrinsics.checkNotNullExpressionValue(r122, "copyOf(this, newSize)");
        return r122;
    L11:
        byte[] r123 = Arrays.copyOf(r0, r12.Length);
        Intrinsics.checkNotNullExpressionValue(r123, "copyOf(this, newSize)");
        return r123;
    }
}

