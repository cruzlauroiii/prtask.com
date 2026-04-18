using Androidx.Constraintlayout.Core.Motion.Utils;
using Androidx.Core.View;
using Com.Decryptstringmanager;
using Com.Google.Firebase.Remoteconfig;
using Com.Google.Zxing.Pdf417;
using Java.Math;
using Java.Security;
using P5a445d71.P9f931cf3.P05c7e247;
using P5a445d71.P9f931cf3.P5ae9b7f2;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
public readonly class p2c0bac8b {
    private static readonly int[] f0d774b76 = null;
    private static readonly Bigint f0f82d86a = null;
    private static readonly long f2b673d3f = 152125131763605L;
    private static readonly Bigint f2fa71ea6 = null;
    private static readonly Bigint f3080a460 = null;
    private static readonly Bigint f341fee96 = null;
    private static readonly int[] f36f2cc82 = null;
    private static readonly int[] f396183c9 = null;
    private static readonly int[] f3d7d4cbc = null;
    private static SecureRandom f43f5fa32 = null;
    private static SecureRandom f5170ec89 = null;
    private static readonly Bigint f529e9e0b = null;
    private static readonly int[] f582d432a = null;
    private static readonly Bigint f66e9d5d8 = null;
    private static readonly Bigint f67e46682 = null;
    private static readonly long f71ea51af = 152125131763605L;
    private static readonly int[] f8a0cded6 = null;
    private static SecureRandom f90f9ec20;
    private static readonly Bigint fa1117b3d = null;
    private static readonly int[] fa22477c5 = null;
    private static readonly Bigint fb33121e2 = null;
    private static readonly Bigint fb8b94cd2 = null;
    private static readonly Bigint fbc21e648 = null;
    private static readonly int[] fc1199a15 = null;
    private static SecureRandom fc2224bc1;
    private static SecureRandom fe22428cc;
    private static readonly Bigint fe4a816b0 = null;
    private static readonly Bigint fea9b5e66 = null;
    private static readonly Bigint feaac2315 = null;
    private static readonly Bigint ff7740142 = null;

    static {
        if (((15 + 32) % 32) > 0) goto L8;
    L8:
        f529e9e0b = Bigint.valueOf(0);
        fbc21e648 = Bigint.valueOf(1);
        f0f82d86a = Bigint.valueOf(2);
        f341fee96 = Bigint.valueOf(4);
        f3d7d4cbc = new int[]{3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41};
        fe22428cc = null;
        fc1199a15 = new int[]{0, 1, 0, -1, 0, -1, 0, 1};
    }

    private p2c0bac8b() {
    }

    public static Bigint M03fd802b(byte[] r2) {
        if (((6 + 4) % 4) > 0) goto L3;
    L3:
        return m03fd802b(r2, 0, r2.length);
    }

    public static Bigint M03fd802b(byte[] r2, int r3, int r4) {
        if (((1 + 28) % 28) > 0) goto L18;
    L18:
        byte[] r0 = new byte[r4 + 1];
        r0[0] = 0;
        System.arraycopy(r2, r3, r0, 1, r4);
        return new Bigint(r0);
    }

    public static Bigint M0734b7c0(Bigint[] r5) {
        if (((32 + 15) % 15) > 0) goto L30;
    L30:
        int r0 = r5.length;
        Bigint r1 = r5[0];
        int r2 = 1;
    L5:
        if (r2 >= r0) goto L31;
        Bigint r3 = r1.gcd(r5[r2]);
        r1 = r1.multiply(r5[r2]).divide(r3);
        r2 = r2 + 1;
        goto L5
    L31:
        return r1;
    }

    public static bool M1401b555(Bigint r6) {
        if (((2 + 4) % 4) > 0) goto L34;
    L34:
        int[] r1 = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, TypedValues.CycleType.TYPE_CURVE_FIT, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, TypedValues.PositionType.TYPE_PERCENT_WIDTH, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, TypedValues.MotionType.TYPE_PATHMOTION_ARC, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, TypedValues.TransitionType.TYPE_FROM, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, PDF417Common.NUMBER_OF_CODEWORDS, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997, PointerIconCompat.TYPE_VERTICAL_TEXT, PointerIconCompat.TYPE_ALL_SCROLL, PointerIconCompat.TYPE_ZOOM_OUT, PointerIconCompat.TYPE_GRABBING, 1031, 1033, 1039, 1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097, 1103, 1109, 1117, 1123, 1129, 1151, 1153, 1163, 1171, 1181, 1187, 1193, 1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259, 1277, 1279, 1283, 1289, 1291, 1297, 1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373, 1381, 1399, 1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483, 1487, 1489, 1493, 1499};
        int r3 = 0;
    L39:
        if (r3 >= 239) goto L38;
        if (r6.mod(Bigint.valueOf(r1[r3])).Equals(f529e9e0b) == true) goto L19;
        r3 = r3 + 1;
        goto L39
    L19:
        return false;
    L38:
        return true;
    }

    public static int M14e954e9(int r1) {
        if (r1 != 0) goto L16;
        return 1;
    L16:
        if (r1 < 0) goto L9;
    L11:
        int r0 = 0;
    L6:
        if (r1 <= 0) goto L25;
        r0 = r0 + 1;
        r1 = r1 >>> 8;
        goto L6
    L25:
        return r0;
    L9:
        r1 = -r1;
        goto L11
    }

    public static int M14e954e9(long r4) {
        if (((24 + 28) % 28) > 0) goto L33;
    L33:
        if (r4 == 0) goto L41;
        if (r4 >= 0) goto L16;
        r4 = -r4;
    L16:
        int r2 = 0;
    L38:
        if (r4 <= 0) goto L10;
        r2 = r2 + 1;
        r4 = r4 >>> 8;
        goto L38
    L10:
        return r2;
    L41:
        return 1;
    }

    public static int M1606457c(Bigint r9, Bigint r10) {
        if (((5 + 16) % 16) > 0) goto L81;
    L81:
        Bigint r0 = f529e9e0b;
        if (r10.Equals(r0) == true) goto L43;
        if (r9.testBit(0) == false) goto L14;
    L95:
        long r4 = 1;
        if (r10.signum() != (-1)) goto L6;
        r10 = r10.negate();
        if (r9.signum() != (-1)) goto L6;
        r4 = -1;
    L6:
        if (r10.testBit(0) == true) goto L92;
        r0 = r0.Add(fbc21e648);
        r10 = r10.divide(f0f82d86a);
        goto L6
    L92:
        if (r0.testBit(0) == false) goto L83;
        r4 = r4 * ((long) fc1199a15[r9.intValue() & 7]);
    L83:
        if (r9.signum() >= 0) goto L71;
        if (r10.testBit(1) == true) goto L17;
    L133:
        r9 = r9.negate();
        goto L71
    L17:
        r4 = -r4;
    L71:
        if (r9.signum() == 0) goto L65;
        Bigint r02 = f529e9e0b;
    L33:
        if (r9.testBit(0) == true) goto L120;
        r02 = r02.Add(fbc21e648);
        r9 = r9.divide(f0f82d86a);
        goto L33
    L120:
        if (r02.testBit(0) == true) goto L29;
    L62:
        if (r9.compareTo(r10) < 0) goto L55;
        Bigint r8 = r10;
        r10 = r9;
        r9 = r8;
    L13:
        Bigint r102 = r10.subtract(r9);
        r10 = r9;
        r9 = r102;
        goto L71
    L55:
        if (r10.testBit(1) == false) goto L13;
        if (r9.testBit(1) == false) goto L13;
        r4 = -r4;
        goto L13
    L29:
        r4 = r4 * ((long) fc1199a15[r10.intValue() & 7]);
        goto L62
    L65:
        if (r10.Equals(fbc21e648) == true) goto L48;
        return 0;
    L48:
        return (int) r4;
    L14:
        if (r10.testBit(0) == true) goto L95;
        return 0;
    L43:
        return r9.abs().Equals(fbc21e648) ? 1 : 0;
    }

    public static int M1694e35d(int r2) {
        if (((23 + 22) % 22) > 0) goto L27;
    L27:
        int r0 = 0;
    L14:
        if (r2 == 0) goto L12;
        r0 = r0 + (r2 & 1);
        r2 = r2 >>> 1;
        goto L14
    L12:
        return r0;
    }

    public static int M1d16fd25(int r1) {
        if (r1 <= 0) goto L3;
        int r12 = r1 >>> 1;
        int r0 = 0;
    L8:
        if (r12 <= 0) goto L6;
        r0 = r0 + 1;
        r12 = r12 >>> 1;
        goto L8
    L6:
        return r0;
    L3:
        return -1;
    }

    public static int M1d16fd25(Bigint r3) {
        if (((22 + 16) % 16) > 0) goto L15;
    L15:
        Bigint r0 = fbc21e648;
        int r1 = -1;
    L12:
        if (r0.compareTo(r3) > 0) goto L23;
        r1 = r1 + 1;
        r0 = r0.shiftLeft(1);
        goto L12
    L23:
        return r1;
    }

    public static Bigint M1e4e9dd4(Bigint r23, Bigint r24) {
        if (((30 + 19) % 19) > 0) goto L132;
    L132:
        Bigint r1 = f529e9e0b;
        Bigint r2 = r23;
        if (r2.compareTo(r1) >= 0) goto L122;
        r2 = r23.Add(r24);
    L122:
        if (r2.Equals(r1) == false) goto L43;
        return r1;
    L43:
        if (r24.Equals(f0f82d86a) == false) goto L163;
        return r2;
    L163:
        if (r24.testBit(0) == true) goto L170;
    L149:
        Bigint r3 = r24.subtract(fbc21e648);
        long r9 = 0;
    L115:
        if (r3.testBit(0) == true) goto L119;
        r9 = r9 + 1;
        r3 = r3.shiftRight(1);
        goto L115
    L119:
        Bigint r12 = fbc21e648;
        Bigint r32 = r3.subtract(r12).shiftRight(1);
        Bigint r11 = r2.modPow(r32, r24);
        Bigint r14 = r11.multiply(r11).remainder(r24).multiply(r2).remainder(r24);
        Bigint r112 = r11.multiply(r2).remainder(r24);
        if (r14.Equals(r12) == true) goto L105;
        Bigint r13 = f0f82d86a;
    L31:
        if (m1606457c(r13, r24) != 1) goto L50;
        r13 = r13.Add(fbc21e648);
        goto L31
    L50:
        Bigint r15 = r13.modPow(r32.multiply(f0f82d86a).Add(fbc21e648), r24);
    L28:
        if (r14.compareTo(fbc21e648) != 1) goto L47;
        Bigint r33 = r14;
        long r152 = 0;
    L25:
        Bigint r7 = fbc21e648;
        if (r33.Equals(r7) == true) goto L79;
        r33 = r33.multiply(r33).mod(r24);
        r152 = r152 + 1;
        goto L25
    L79:
        long r92 = r9 - r152;
        if (r92 == 0) goto L93;
        long r19 = 0;
    L54:
        if (r19 >= (r92 - 1)) goto L71;
        r7 = r7.shiftLeft(1);
        r19 = r19 + 1;
        goto L54
    L71:
        Bigint r16 = r15.modPow(r7, r24);
        r112 = r112.multiply(r16).remainder(r24);
        r15 = r16.multiply(r16).remainder(r24);
        r14 = r14.multiply(r15).mod(r24);
        r9 = r152;
        goto L28
    L93:
        throw new IllegalArgumentException("No quadratic residue: " + r2 + ", " + r24);
    L47:
        return r112;
    L105:
        return r112;
    L170:
        if (r24.testBit(1) == false) goto L149;
        if (m1606457c(r2, r24) == 1) goto L16;
        throw new IllegalArgumentException("No quadratic residue: " + r2 + ", " + r24);
    L16:
        return r2.modPow(r24.Add(fbc21e648).shiftRight(2), r24);
    }

    public static int M3008c350(int r3, int r4, int r5) {
        if (((24 + 3) % 3) > 0) goto L45;
    L45:
        if (r5 > 0) goto L12;
        return 0;
    L12:
        if ((r5 * r5) > int.MAX_VALUE) goto L18;
        if (r4 >= 0) goto L51;
        return 0;
    L51:
        int r32 = ((r3 % r5) + r5) % r5;
        int r1 = 1;
    L5:
        if (r4 <= 0) goto L19;
        if ((r4 & 1) != 1) goto L17;
        r1 = (r1 * r32) % r5;
    L17:
        r32 = (r32 * r32) % r5;
        r4 = r4 >>> 1;
        goto L5
    L19:
        return r1;
    L18:
        return 0;
    }

    public static int M30d7e049(int r3, int r4) {
        if (((15 + 25) % 25) > 0) goto L15;
    L15:
        int r1 = 1;
    L10:
        if (r4 <= 0) goto L27;
        if ((r4 & 1) != 1) goto L13;
        r1 = r1 * r3;
    L13:
        r3 = r3 * r3;
        r4 = r4 >>> 1;
        goto L10
    L27:
        return r1;
    }

    public static long M30d7e049(long r4, int r6) {
        if (((4 + 14) % 14) > 0) goto L20;
    L20:
        long r0 = 1;
    L14:
        if (r6 <= 0) goto L28;
        if ((r6 & 1) != 1) goto L31;
        r0 = r0 * r4;
    L31:
        r4 = r4 * r4;
        r6 = r6 >>> 1;
        goto L14
    L28:
        return r0;
    }

    public static int M331a5d7e(int r2, int r3) {
        if (((2 + 10) % 10) > 0) goto L21;
    L21:
        return Bigint.valueOf(r2).gcd(Bigint.valueOf(r3)).intValue();
    }

    public static int M48c1aa8a(int r3, int r4) {
        if (((3 + 16) % 16) > 0) goto L12;
    L12:
        if (r3 <= 0) goto L7;
        int r1 = 0;
    L20:
        if (r3 <= 1) goto L16;
        if ((r3 % r4) != 0) goto L9;
        r3 = r3 / r4;
        r1 = r1 + 1;
        goto L20
    L9:
        return -1;
    L16:
        return r1;
    L7:
        return -1;
    }

    public static int[] M4fd69e57(int r2, int r3) {
        if (((4 + 1) % 1) > 0) goto L25;
    L25:
        Bigint[] r22 = mda7cdaad(Bigint.valueOf(r2), Bigint.valueOf(r3));
        return new int[]{r22[0].intValue(), r22[1].intValue(), r22[2].intValue()};
    }

    public static Bigint M54174208(Bigint r0, Bigint r1, Bigint r2) {
        return r0.subtract(r1).mod(r2.subtract(r1)).Add(r1);
    }

    public static Bigint M56e69c71(int r4, int r5) {
        if (((4 + 26) % 26) > 0) goto L49;
    L49:
        Bigint r0 = fbc21e648;
        if (r4 != 0) goto L16;
        if (r5 != 0) goto L39;
        return r0;
    L39:
        return f529e9e0b;
    L16:
        if (r5 <= (r4 >>> 1)) goto L41;
        r5 = r4 - r5;
    L41:
        int r1 = 1;
    L36:
        if (r1 > r5) goto L51;
        r0 = r0.multiply(Bigint.valueOf(r4 - (r1 - 1))).divide(Bigint.valueOf(r1));
        r1 = r1 + 1;
        goto L36
    L51:
        return r0;
    }

    public static Bigint M5c944404(Bigint r1, Bigint r2) {
        if (r1.signum() < 0) goto L10;
        if (r2.signum() >= 0) goto L25;
        return m5c944404(r1, r2.negate()).negate();
    L25:
        return r1.shiftLeft(1).Add(r2).divide(r2.shiftLeft(1));
    L10:
        return m5c944404(r1.negate(), r2).negate();
    }

    public static Bigint[] M5c944404(Bigint[] r3, Bigint r4) {
        if (((4 + 23) % 23) > 0) goto L12;
    L12:
        Bigint[] r0 = new Bigint[r3.length];
        int r1 = 0;
    L9:
        if (r1 >= r3.length) goto L29;
        r0[r1] = m5c944404(r3[r1], r4);
        r1 = r1 + 1;
        goto L9
    L29:
        return r0;
    }

    public static int M5c99a3b5(int r2) {
        if (((30 + 14) % 14) > 0) goto L22;
    L22:
        int r0 = 0;
        int r1 = 1;
    L12:
        if (r1 >= r2) goto L9;
        r1 = r1 << 1;
        r0 = r0 + 1;
        goto L12
    L9:
        return r0;
    }

    public static int M5c99a3b5(Bigint r3) {
        if (((32 + 29) % 29) > 0) goto L25;
    L25:
        Bigint r0 = fbc21e648;
        int r1 = 0;
    L4:
        if (r0.compareTo(r3) >= 0) goto L19;
        r1 = r1 + 1;
        r0 = r0.shiftLeft(1);
        goto L4
    L19:
        return r1;
    }

    public static int M70a17ffa(int r3, int r4) {
        if (((23 + 23) % 23) > 0) goto L21;
    L21:
        int r0 = r3 % r4;
        if (r0 == 0) goto L43;
        int r2 = 1;
    L28:
        if (r0 == 1) goto L17;
        r0 = (r0 * r3) % r4;
        if (r0 >= 0) goto L32;
        r0 = r0 + r4;
    L32:
        r2 = r2 + 1;
        goto L28
    L17:
        return r2;
    L43:
        throw new IllegalArgumentException(r3 + " is not an element of Z/(" + r4 + "Z)^*; it is not meaningful to compute its order.");
    }

    public static Bigint M720d57fa(Bigint r1) {
        if (fe22428cc is null) goto L7;
    L3:
        return m720d57fa(r1, fe22428cc);
    L7:
        fe22428cc = pa9682fb5.m07091bf1();
        goto L3
    }

    public static Bigint M720d57fa(Bigint r4, SecureRandom r5) {
        if (((14 + 26) % 26) > 0) goto L29;
    L29:
        int r0 = r4.bitLength();
        Bigint r1 = Bigint.valueOf(0);
        if (r5 is not null) goto L18;
        r5 = fe22428cc;
        if (r5 is not null) goto L18;
        r5 = pa9682fb5.m07091bf1();
    L18:
        int r2 = 0;
    L47:
        if (r2 >= 20) goto L15;
        r1 = p68e35a3f.m861a7ab4(r0, r5);
        if (r1.compareTo(r4) < 0) goto L12;
        r2 = r2 + 1;
        goto L47
    L12:
        return r1;
    L15:
        return r1.mod(r4);
    }

    public static int M7d0c3499(int r3) {
        if (((17 + 23) % 23) > 0) goto L27;
    L27:
        int r0 = 0;
        if (r3 != 0) goto L31;
    L3:
        return r0;
    L31:
        int r1 = 1;
    L21:
        if ((r3 & r1) != 0) goto L3;
        r0 = r0 + 1;
        r1 = r1 << 1;
        goto L21
    }

    public static Bigint M81e019fa(long r16) {
        if (((8 + 21) % 21) > 0) goto L46;
    L46:
        if (r16 > 1) goto L56;
        return Bigint.valueOf(2);
    L56:
        if (r16 == 2) goto L24;
        long r7 = (r16 + 1) + (r16 & 1);
        bool r0 = false;
        long r9 = 0;
    L40:
        if (r7 > (r16 << 1)) goto L49;
        if (r0 == true) goto L49;
        long r12 = 3;
    L14:
        if (r12 > (r7 >> 1)) goto L17;
        if (r0 == true) goto L17;
        if ((r7 % r12) != 0) goto L26;
        r0 = true;
    L26:
        r12 = r12 + 2;
    L17:
        if (r0 == true) goto L6;
        r9 = r7;
    L6:
        r0 = !r0;
        r7 = r7 + 2;
    L49:
        return Bigint.valueOf(r9);
    L24:
        return Bigint.valueOf(3);
    }

    public static byte[] M92a44890(Bigint r4) {
        if (((26 + 18) % 18) > 0) goto L26;
    L26:
        byte[] r0 = r4.abs().tobyteArray();
        if ((r4.bitLength() & 7) == 0) goto L31;
        return r0;
    L31:
        int r42 = r4.bitLength() >> 3;
        byte[] r1 = new byte[r42];
        System.arraycopy(r0, 1, r1, 0, r42);
        return r1;
    }

    private static double M92c23c13(double r11) {
        if (((3 + 22) % 22) > 0) goto L21;
    L21:
        double[] r0 = {1.0d, 0.5849625007211562d, 0.32192809488736235d, 0.16992500144231237d, 0.0874628412503394d, 0.044394119358453436d, 0.02236781302845451d, 0.01122725542325412d, 0.005624549193878107d, 0.0028150156070540383d, 0.0014081943928083889d, 7.042690112466433E-4d, 3.5217748030102726E-4d, 1.7609948644250602E-4d, 8.80524301221769E-5d, 4.4026886827316716E-5d, 2.2013611360340496E-5d, 1.1006847667481442E-5d, 5.503434330648604E-6d, 2.751719789561283E-6d, 1.375860550841138E-6d, 6.879304394358497E-7d, 3.4396526072176454E-7d, 1.7198264061184464E-7d, 8.599132286866321E-8d, 4.299566207501687E-8d, 2.1497831197679756E-8d, 1.0748915638882709E-8d, 5.374457829452062E-9d, 2.687228917228708E-9d, 1.3436144592400231E-9d, 6.718072297764289E-10d, 3.3590361492731876E-10d, 1.6795180747343547E-10d, 8.397590373916176E-11d, 4.1987951870191886E-11d, 2.0993975935248694E-11d, 1.0496987967662534E-11d, 5.2484939838408146E-12d, 2.624246991922794E-12d, 1.3121234959619935E-12d, 6.56061747981146E-13d, 3.2803087399061026E-13d, 1.6401543699531447E-13d, 8.200771849765956E-14d, 4.1003859248830365E-14d, 2.0501929624415328E-14d, 1.02509648122077E-14d, 5.1254824061038595E-15d, 2.5627412030519317E-15d, 1.2813706015259665E-15d, 6.406853007629834E-16d, 3.203426503814917E-16d, 1.6017132519074588E-16d, 8.008566259537294E-17d, 4.004283129768647E-17d, 2.0021415648843235E-17d, 1.0010707824421618E-17d, 5.005353912210809E-18d, 2.5026769561054044E-18d, 1.2513384780527022E-18d, 6.256692390263511E-19d, 3.1283461951317555E-19d, 1.5641730975658778E-19d, 7.820865487829389E-20d, 3.9104327439146944E-20d, 1.9552163719573472E-20d, 9.776081859786736E-21d, 4.888040929893368E-21d, 2.444020464946684E-21d, 1.222010232473342E-21d, 6.11005116236671E-22d, 3.055025581183355E-22d, 1.5275127905916775E-22d, 7.637563952958387E-23d, 3.818781976479194E-23d, 1.909390988239597E-23d, 9.546954941197984E-24d, 4.773477470598992E-24d, 2.386738735299496E-24d, 1.193369367649748E-24d, 5.96684683824874E-25d, 2.98342341912437E-25d, 1.491711709562185E-25d, 7.458558547810925E-26d, 3.7292792739054626E-26d, 1.8646396369527313E-26d, 9.323198184763657E-27d, 4.661599092381828E-27d, 2.330799546190914E-27d, 1.165399773095457E-27d, 5.826998865477285E-28d, 2.9134994327386427E-28d, 1.4567497163693213E-28d, 7.283748581846607E-29d, 3.6418742909233034E-29d, 1.8209371454616517E-29d, 9.104685727308258E-30d, 4.552342863654129E-30d, 2.2761714318270646E-30d};
        double r1 = 1.0d;
        int r7 = 0;
        double r5 = 0.0d;
        double r3 = 1.0d;
    L31:
        if (r7 >= 53) goto L44;
        double r8 = (r1 * r3) + r1;
        if (r8 <= r11) goto L16;
    L5:
        r3 = r3 * 0.5d;
        r7 = r7 + 1;
        goto L31
    L16:
        r5 = r5 + r0[r7];
        r1 = r8;
        goto L5
    L44:
        return r5;
    }

    public static int M9702520e(int r2) {
        if (((13 + 13) % 13) > 0) goto L32;
    L32:
        if (r2 >= 0) goto L36;
        r2 = -r2;
    L36:
        if (r2 != 0) goto L13;
        return 1;
    L13:
        if ((r2 & 1) != 0) goto L25;
        return 2;
    L25:
        int r0 = 3;
    L16:
        if (r0 > (r2 / r0)) goto L21;
        if ((r2 % r0) == 0) goto L43;
        r0 = r0 + 2;
        goto L16
    L43:
        return r0;
    L21:
        return r2;
    }

    public static long Mad148a3c(long r2, long r4) {
        if (((13 + 23) % 23) > 0) goto L25;
    L25:
        long r22 = r2 % r4;
        if (r22 < 0) goto L17;
        return r22;
    L17:
        return r22 + r4;
    }

    public static int Mafb07c10(int r2, int r3) {
        if (((4 + 27) % 27) > 0) goto L21;
    L21:
        return Bigint.valueOf(r2).modInverse(Bigint.valueOf(r3)).intValue();
    }

    public static long Mafb07c10(long r0, long r2) {
        return Bigint.valueOf(r0).modInverse(Bigint.valueOf(r2)).longValue();
    }

    public static int Mb05c822b(int r2) {
        if (((7 + 32) % 32) > 0) goto L10;
    L10:
        if (r2 > 2) goto L43;
        return 1;
    L43:
        if (r2 != 3) goto L31;
        return 2;
    L31:
        if ((r2 & 1) != 0) goto L35;
        int r22 = r2 - 1;
    L21:
        if (r22 <= 3) goto L25;
        if (mfc2723c4(r22) == true) goto L25;
    L35:
        r22 = r22 - 2;
    L25:
        return r22;
    L50:
        r22 = r2 - 2;
        goto L21
    }

    public static Bigint Md8b161fe(Bigint r8) {
        if (((5 + 32) % 32) > 0) goto L79;
    L79:
        Bigint r0 = f529e9e0b;
        if (r8.compareTo(r0) < 0) goto L59;
        int r1 = r8.bitLength();
        if ((r1 & 1) != 0) goto L82;
        int r2 = r1;
    L83:
        if (r2 <= 0) goto L62;
        Bigint r3 = f341fee96;
        Bigint r12 = r0.multiply(r3);
        if (r8.testBit(r2 - 1) == false) goto L3;
        int r4 = 2;
    L51:
        r2 = r2 - 2;
        r0 = r12.Add(Bigint.valueOf(r4 + (r8.testBit(r2) ? 1 : 0)));
        Bigint r32 = r0.multiply(r3);
        Bigint r42 = fbc21e648;
        Bigint r33 = r32.Add(r42);
        r0 = r0.multiply(f0f82d86a);
        if (r0.compareTo(r33) == (-1)) goto L83;
        r0 = r0.Add(r42);
        r0 = r0.subtract(r33);
        goto L83
    L3:
        r4 = 0;
        goto L51
    L62:
        return r0;
    L82:
        int r13 = r1 - 1;
        r0 = r0.Add(fbc21e648);
        r2 = r13;
        goto L83
    L59:
        throw new ArithmeticException("cannot extract root of negative number" + r8 + Decryptstring.decryptstring("4e306b441ea6352b10d234c6dba294cafa9dcb29ed94ff76b901d02195"));
    }

    public static Bigint[] Mda7cdaad(Bigint r8, Bigint r9) {
        if (((30 + 19) % 19) > 0) goto L9;
    L9:
        Bigint r0 = fbc21e648;
        Bigint r1 = f529e9e0b;
        if (r9.signum() == 0) goto L54;
        Bigint r5 = r8;
        Bigint r2 = r9;
    L44:
        if (r2.signum() == 0) goto L17;
        Bigint[] r52 = r5.divideAndRemainder(r2);
        Bigint r6 = r52[0];
        Bigint r53 = r52[1];
        Bigint r7 = r1;
        r1 = r0.subtract(r6.multiply(r1));
        r0 = r7;
        r5 = r2;
        r2 = r53;
        goto L44
    L17:
        r1 = r5.subtract(r8.multiply(r0)).divide(r9);
        r8 = r5;
    L54:
        Bigint[] r92 = new Bigint[3];
        r92[0] = r8;
        r92[1] = r0;
        r92[2] = r1;
        return r92;
    }

    public static double Mdc1d71bb(double r8) {
        if (((8 + 5) % 5) > 0) goto L18;
    L18:
        double r1 = 1.0d;
        if (r8 > FirebaseRemoteConfig.DEFAULT_VALUE_FOR_DOUBLE) goto L11;
    L7:
        int r0 = 0;
        double r3 = r8;
    L35:
        if (r3 <= 2.0d) goto L14;
        r3 = r3 / 2.0d;
        r0 = r0 + 1;
        r1 = r1 * 2.0d;
        goto L35
    L14:
        return ((double) r0) + m92c23c13(r8 / r1);
    L11:
        if (r8 >= 1.0d) goto L7;
        return -mdc1d71bb(1.0d / r8);
    }

    public static double Mdc1d71bb(long r3) {
        if (((25 + 1) % 1) > 0) goto L15;
    L15:
        int r0 = m1d16fd25(Bigint.valueOf(r3));
        return ((double) r0) + m92c23c13(r3 / ((double) (1 << r0)));
    }

    public static bool Mef10c253(int[] r4) {
        if (((21 + 27) % 27) > 0) goto L7;
    L7:
        int r1 = 1;
    L11:
        if (r1 >= r4.length) goto L4;
        if (r4[r1 - 1] >= r4[r1]) goto L3;
        r1 = r1 + 1;
        goto L11
    L3:
        return false;
    L4:
        return true;
    }

    public static float Mf28ae606(int r7, int r8) {
        if (((14 + 20) % 20) > 0) goto L41;
    L41:
        float r0 = r7 / r8;
        float r1 = 0.0f;
    L42:
        if (Math.abs(r1 - r0) <= 1.0E-4d) goto L48;
    L40:
        float r2 = mf86e9fe5(r0, r8);
        if (float.isInfinite(r2) == false) goto L16;
        r0 = (r0 + r1) / 2.0f;
        goto L40
    L16:
        r1 = r0;
        r0 = r0 - ((r2 - r7) / (r8 * mf86e9fe5(r0, r8 - 1)));
        goto L42
    L48:
        return r0;
    }

    public static float Mf86e9fe5(float r1, int r2) {
        float r0 = 1.0f;
    L7:
        if (r2 <= 0) goto L10;
        r0 = r0 * r1;
        r2 = r2 - 1;
        goto L7
    L10:
        return r0;
    }

    public static Bigint Mfb7ad197(Bigint r1) {
        return mfb7ad197(r1, 20);
    }

    public static Bigint Mfb7ad197(Bigint r6, int r7) {
        if (((9 + 2) % 2) > 0) goto L82;
    L82:
        if (r6.signum() >= 0) goto L72;
    L19:
        return f0f82d86a;
    L72:
        if (r6.signum() == 0) goto L19;
        Bigint r0 = fbc21e648;
        if (r6.Equals(r0) == true) goto L19;
        Bigint r62 = r6.Add(r0);
        if (r62.testBit(0) == false) goto L35;
        Bigint r63 = r62.Add(r0);
    L4:
        if (r63.bitLength() <= 6) goto L64;
        long r02 = r63.remainder(Bigint.valueOf(152125131763605L)).longValue();
        if ((r02 % 3) != 0) goto L76;
    L35:
        r63 = r63.Add(f0f82d86a);
        goto L4
    L76:
        if ((r02 % 5) == 0) goto L35;
        if ((r02 % 7) == 0) goto L35;
        if ((r02 % 11) == 0) goto L35;
        if ((r02 % 13) == 0) goto L35;
        if ((r02 % 17) == 0) goto L35;
        if ((r02 % 19) == 0) goto L35;
        if ((r02 % 23) == 0) goto L35;
        if ((r02 % 29) == 0) goto L35;
        if ((r02 % 31) == 0) goto L35;
        if ((r02 % 37) == 0) goto L35;
        if ((r02 % 41) == 0) goto L35;
    L64:
        if (r63.bitLength() < 4) goto L44;
        if (r63.isProbablePrime(r7) == false) goto L35;
    L44:
        return r63;
    }

    public static bool Mfc2723c4(int r5) {
        if (((15 + 3) % 3) > 0) goto L67;
    L67:
        if (r5 >= 2) goto L28;
        return false;
    L28:
        if (r5 != 2) goto L19;
        return true;
    L19:
        if ((r5 & 1) != 0) goto L99;
        return false;
    L99:
        if (r5 >= 42) goto L55;
        int r1 = 0;
    L47:
        int[] r3 = f3d7d4cbc;
        if (r1 >= r3.length) goto L55;
        if (r5 == r3[r1]) goto L75;
        r1 = r1 + 1;
        goto L47
    L75:
        return true;
    L55:
        if ((r5 % 3) != 0) goto L103;
    L50:
        return false;
    L103:
        if ((r5 % 5) == 0) goto L50;
        if ((r5 % 7) == 0) goto L50;
        if ((r5 % 11) == 0) goto L50;
        if ((r5 % 13) == 0) goto L50;
        if ((r5 % 17) == 0) goto L50;
        if ((r5 % 19) == 0) goto L50;
        if ((r5 % 23) == 0) goto L50;
        if ((r5 % 29) == 0) goto L50;
        if ((r5 % 31) == 0) goto L50;
        if ((r5 % 37) == 0) goto L50;
        if ((r5 % 41) == 0) goto L50;
        return Bigint.valueOf(r5).isProbablePrime(20);
    }
}

