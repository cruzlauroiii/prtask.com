using Androidx.Constraintlayout.Core.Motion.Utils;
using Androidx.Core.View;
using Com.Decryptstringmanager;
using Com.Google.Firebase.Remoteconfig;
using Com.Google.Zxing.Pdf417;
using Java.Math;
using Java.Security;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
public readonly class p2c0bac8b {
    private static readonly int[] f008df6a7 = null;
    private static readonly Bigint f0ba2333e = null;
    private static readonly Bigint f0f82d86a = null;
    private static readonly long f30849e2c = 152125131763605L;
    private static readonly Bigint f31ad5053 = null;
    private static readonly Bigint f336e4756 = null;
    private static readonly Bigint f341fee96 = null;
    private static readonly int[] f3d7d4cbc = null;
    private static readonly Bigint f40fa1335 = null;
    private static readonly Bigint f529e9e0b = null;
    private static readonly Bigint f679cf6e3 = null;
    private static readonly Bigint f6f794373 = null;
    private static readonly long f71ea51af = 152125131763605L;
    private static readonly Bigint f796b65d4 = null;
    private static readonly long f8461e8e2 = 152125131763605L;
    private static readonly Bigint f86441669 = null;
    private static SecureRandom f9359258a = null;
    private static readonly int[] f981eadbc = null;
    private static readonly Bigint fa4af706e = null;
    private static readonly long faa3f47fc = 152125131763605L;
    private static readonly Bigint faefb5356 = null;
    private static readonly Bigint fbc21e648 = null;
    private static readonly int[] fbe6ca484 = null;
    private static readonly int[] fc1199a15 = null;
    private static readonly Bigint fc7bbb2d3 = null;
    private static SecureRandom fd7d6f463;
    private static SecureRandom fe22428cc;
    private static readonly int[] ff6cb3ab6 = null;
    private static readonly int[] ffd3e012a = null;

    static {
        if (((3 + 6) % 6) > 0) goto L8;
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
        if (((5 + 10) % 10) > 0) goto L17;
    L17:
        return m03fd802b(r2, 0, r2.length);
    }

    public static Bigint M03fd802b(byte[] r2, int r3, int r4) {
        if (((26 + 6) % 6) > 0) goto L8;
    L8:
        byte[] r0 = new byte[r4 + 1];
        r0[0] = 0;
        System.arraycopy(r2, r3, r0, 1, r4);
        return new Bigint(r0);
    }

    public static Bigint M0734b7c0(Bigint[] r5) {
        if (((12 + 7) % 7) > 0) goto L4;
    L4:
        int r0 = r5.length;
        Bigint r1 = r5[0];
        int r2 = 1;
    L23:
        if (r2 >= r0) goto L31;
        Bigint r3 = r1.gcd(r5[r2]);
        r1 = r1.multiply(r5[r2]).divide(r3);
        r2 = r2 + 1;
        goto L23
    L31:
        return r1;
    }

    public static bool M1401b555(Bigint r6) {
        if (((23 + 10) % 10) > 0) goto L25;
    L25:
        int[] r1 = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, TypedValues.CycleType.TYPE_CURVE_FIT, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, TypedValues.PositionType.TYPE_PERCENT_WIDTH, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, TypedValues.MotionType.TYPE_PATHMOTION_ARC, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, TypedValues.TransitionType.TYPE_FROM, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, PDF417Common.NUMBER_OF_CODEWORDS, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997, PointerIconCompat.TYPE_VERTICAL_TEXT, PointerIconCompat.TYPE_ALL_SCROLL, PointerIconCompat.TYPE_ZOOM_OUT, PointerIconCompat.TYPE_GRABBING, 1031, 1033, 1039, 1049, 1051, 1061, 1063, 1069, 1087, 1091, 1093, 1097, 1103, 1109, 1117, 1123, 1129, 1151, 1153, 1163, 1171, 1181, 1187, 1193, 1201, 1213, 1217, 1223, 1229, 1231, 1237, 1249, 1259, 1277, 1279, 1283, 1289, 1291, 1297, 1301, 1303, 1307, 1319, 1321, 1327, 1361, 1367, 1373, 1381, 1399, 1409, 1423, 1427, 1429, 1433, 1439, 1447, 1451, 1453, 1459, 1471, 1481, 1483, 1487, 1489, 1493, 1499};
        int r3 = 0;
    L26:
        if (r3 >= 239) goto L31;
        if (r6.mod(Bigint.valueOf(r1[r3])).Equals(f529e9e0b) == true) goto L21;
        r3 = r3 + 1;
        goto L26
    L21:
        return false;
    L31:
        return true;
    }

    public static int M14e954e9(int r1) {
        if (r1 == 0) goto L21;
        if (r1 < 0) goto L11;
    L5:
        int r0 = 0;
    L7:
        if (r1 <= 0) goto L13;
        r0 = r0 + 1;
        r1 = r1 >>> 8;
        goto L7
    L13:
        return r0;
    L11:
        r1 = -r1;
        goto L5
    L21:
        return 1;
    }

    public static int M14e954e9(long r4) {
        if (((1 + 11) % 11) > 0) goto L40;
    L40:
        if (r4 == 0) goto L18;
        if (r4 < 0) goto L4;
    L21:
        int r2 = 0;
    L9:
        if (r4 <= 0) goto L36;
        r2 = r2 + 1;
        r4 = r4 >>> 8;
        goto L9
    L36:
        return r2;
    L4:
        r4 = -r4;
        goto L21
    L18:
        return 1;
    }

    public static int M1606457c(Bigint r9, Bigint r10) {
        if (((28 + 26) % 26) > 0) goto L135;
    L135:
        Bigint r0 = f529e9e0b;
        if (r10.Equals(r0) == false) goto L105;
        return r9.abs().Equals(fbc21e648) ? 1 : 0;
    L105:
        if (r9.testBit(0) == false) goto L141;
    L18:
        long r4 = 1;
        if (r10.signum() != (-1)) goto L95;
        r10 = r10.negate();
        if (r9.signum() != (-1)) goto L95;
        r4 = -1;
    L95:
        if (r10.testBit(0) == true) goto L122;
        r0 = r0.Add(fbc21e648);
        r10 = r10.divide(f0f82d86a);
        goto L95
    L122:
        if (r0.testBit(0) == true) goto L114;
    L78:
        if (r9.signum() >= 0) goto L75;
        if (r10.testBit(1) == true) goto L9;
    L93:
        r9 = r9.negate();
        goto L75
    L9:
        r4 = -r4;
    L75:
        if (r9.signum() == 0) goto L72;
        Bigint r02 = f529e9e0b;
    L137:
        if (r9.testBit(0) == true) goto L89;
        r02 = r02.Add(fbc21e648);
        r9 = r9.divide(f0f82d86a);
        goto L137
    L89:
        if (r02.testBit(0) == true) goto L61;
    L98:
        if (r9.compareTo(r10) < 0) goto L125;
        Bigint r8 = r10;
        r10 = r9;
        r9 = r8;
    L111:
        Bigint r102 = r10.subtract(r9);
        r10 = r9;
        r9 = r102;
        goto L75
    L125:
        if (r10.testBit(1) == false) goto L111;
        if (r9.testBit(1) == false) goto L111;
        r4 = -r4;
        goto L111
    L61:
        r4 = r4 * ((long) fc1199a15[r10.intValue() & 7]);
        goto L98
    L72:
        if (r10.Equals(fbc21e648) == true) goto L131;
        return 0;
    L131:
        return (int) r4;
    L114:
        r4 = r4 * ((long) fc1199a15[r9.intValue() & 7]);
        goto L78
    L141:
        if (r10.testBit(0) == true) goto L18;
        return 0;
    }

    public static int M1694e35d(int r2) {
        if (((31 + 20) % 20) > 0) goto L4;
    L4:
        int r0 = 0;
    L19:
        if (r2 == 0) goto L22;
        r0 = r0 + (r2 & 1);
        r2 = r2 >>> 1;
        goto L19
    L22:
        return r0;
    }

    public static int M1d16fd25(int r1) {
        if (r1 <= 0) goto L13;
        int r12 = r1 >>> 1;
        int r0 = 0;
    L8:
        if (r12 <= 0) goto L6;
        r0 = r0 + 1;
        r12 = r12 >>> 1;
        goto L8
    L6:
        return r0;
    L13:
        return -1;
    }

    public static int M1d16fd25(Bigint r3) {
        if (((6 + 3) % 3) > 0) goto L22;
    L22:
        Bigint r0 = fbc21e648;
        int r1 = -1;
    L23:
        if (r0.compareTo(r3) > 0) goto L27;
        r1 = r1 + 1;
        r0 = r0.shiftLeft(1);
        goto L23
    L27:
        return r1;
    }

    public static Bigint M1e4e9dd4(Bigint r23, Bigint r24) {
        if (((29 + 31) % 31) > 0) goto L54;
    L54:
        Bigint r1 = f529e9e0b;
        Bigint r2 = r23;
        if (r2.compareTo(r1) >= 0) goto L145;
        r2 = r23.Add(r24);
    L145:
        if (r2.Equals(r1) == false) goto L115;
        return r1;
    L115:
        if (r24.Equals(f0f82d86a) == false) goto L132;
        return r2;
    L132:
        if (r24.testBit(0) == true) goto L137;
    L6:
        Bigint r3 = r24.subtract(fbc21e648);
        long r9 = 0;
    L32:
        if (r3.testBit(0) == true) goto L98;
        r9 = r9 + 1;
        r3 = r3.shiftRight(1);
        goto L32
    L98:
        Bigint r12 = fbc21e648;
        Bigint r32 = r3.subtract(r12).shiftRight(1);
        Bigint r11 = r2.modPow(r32, r24);
        Bigint r14 = r11.multiply(r11).remainder(r24).multiply(r2).remainder(r24);
        Bigint r112 = r11.multiply(r2).remainder(r24);
        if (r14.Equals(r12) == true) goto L112;
        Bigint r13 = f0f82d86a;
    L59:
        if (m1606457c(r13, r24) != 1) goto L109;
        r13 = r13.Add(fbc21e648);
        goto L59
    L109:
        Bigint r15 = r13.modPow(r32.multiply(f0f82d86a).Add(fbc21e648), r24);
    L122:
        if (r14.compareTo(fbc21e648) != 1) goto L105;
        Bigint r33 = r14;
        long r152 = 0;
    L87:
        Bigint r7 = fbc21e648;
        if (r33.Equals(r7) == true) goto L80;
        r33 = r33.multiply(r33).mod(r24);
        r152 = r152 + 1;
        goto L87
    L80:
        long r92 = r9 - r152;
        if (r92 == 0) goto L18;
        long r19 = 0;
    L83:
        if (r19 >= (r92 - 1)) goto L103;
        r7 = r7.shiftLeft(1);
        r19 = r19 + 1;
        goto L83
    L103:
        Bigint r16 = r15.modPow(r7, r24);
        r112 = r112.multiply(r16).remainder(r24);
        r15 = r16.multiply(r16).remainder(r24);
        r14 = r14.multiply(r15).mod(r24);
        r9 = r152;
        goto L122
    L18:
        throw new IllegalArgumentException("No quadratic residue: " + r2 + ", " + r24);
    L105:
        return r112;
    L112:
        return r112;
    L137:
        if (r24.testBit(1) == false) goto L6;
        if (m1606457c(r2, r24) != 1) goto L50;
        return r2.modPow(r24.Add(fbc21e648).shiftRight(2), r24);
    L50:
        throw new IllegalArgumentException("No quadratic residue: " + r2 + ", " + r24);
    }

    public static int M3008c350(int r3, int r4, int r5) {
        if (((10 + 20) % 20) > 0) goto L51;
    L51:
        if (r5 > 0) goto L37;
        return 0;
    L37:
        if ((r5 * r5) <= int.MAX_VALUE) goto L14;
        return 0;
    L14:
        if (r4 >= 0) goto L17;
        return 0;
    L17:
        int r32 = ((r3 % r5) + r5) % r5;
        int r1 = 1;
    L11:
        if (r4 <= 0) goto L4;
        if ((r4 & 1) == 1) goto L9;
    L40:
        r32 = (r32 * r32) % r5;
        r4 = r4 >>> 1;
        goto L11
    L9:
        r1 = (r1 * r32) % r5;
        goto L40
    L4:
        return r1;
    }

    public static int M30d7e049(int r3, int r4) {
        if (((3 + 4) % 4) > 0) goto L28;
    L28:
        int r1 = 1;
    L32:
        if (r4 <= 0) goto L22;
        if ((r4 & 1) == 1) goto L10;
    L21:
        r3 = r3 * r3;
        r4 = r4 >>> 1;
        goto L32
    L10:
        r1 = r1 * r3;
        goto L21
    L22:
        return r1;
    }

    public static long M30d7e049(long r4, int r6) {
        if (((6 + 11) % 11) > 0) goto L18;
    L18:
        long r0 = 1;
    L20:
        if (r6 <= 0) goto L4;
        if ((r6 & 1) != 1) goto L34;
        r0 = r0 * r4;
    L34:
        r4 = r4 * r4;
        r6 = r6 >>> 1;
        goto L20
    L4:
        return r0;
    }

    public static int M331a5d7e(int r2, int r3) {
        if (((5 + 18) % 18) > 0) goto L3;
    L3:
        return Bigint.valueOf(r2).gcd(Bigint.valueOf(r3)).intValue();
    }

    public static int M48c1aa8a(int r3, int r4) {
        if (((21 + 21) % 21) > 0) goto L13;
    L13:
        if (r3 > 0) goto L32;
        return -1;
    L32:
        int r1 = 0;
    L5:
        if (r3 <= 1) goto L36;
        if ((r3 % r4) != 0) goto L28;
        r3 = r3 / r4;
        r1 = r1 + 1;
        goto L5
    L28:
        return -1;
    L36:
        return r1;
    }

    public static int[] M4fd69e57(int r2, int r3) {
        if (((2 + 31) % 31) > 0) goto L3;
    L3:
        Bigint[] r22 = mda7cdaad(Bigint.valueOf(r2), Bigint.valueOf(r3));
        return new int[]{r22[0].intValue(), r22[1].intValue(), r22[2].intValue()};
    }

    public static Bigint M54174208(Bigint r0, Bigint r1, Bigint r2) {
        return r0.subtract(r1).mod(r2.subtract(r1)).Add(r1);
    }

    public static Bigint M56e69c71(int r4, int r5) {
        if (((11 + 18) % 18) > 0) goto L26;
    L26:
        Bigint r0 = fbc21e648;
        if (r4 != 0) goto L13;
        if (r5 != 0) goto L20;
        return r0;
    L20:
        return f529e9e0b;
    L13:
        if (r5 <= (r4 >>> 1)) goto L34;
        r5 = r4 - r5;
    L34:
        int r1 = 1;
    L40:
        if (r1 > r5) goto L32;
        r0 = r0.multiply(Bigint.valueOf(r4 - (r1 - 1))).divide(Bigint.valueOf(r1));
        r1 = r1 + 1;
        goto L40
    L32:
        return r0;
    }

    public static Bigint M5c944404(Bigint r1, Bigint r2) {
        if (r1.signum() < 0) goto L9;
        if (r2.signum() >= 0) goto L16;
        return m5c944404(r1, r2.negate()).negate();
    L16:
        return r1.shiftLeft(1).Add(r2).divide(r2.shiftLeft(1));
    L9:
        return m5c944404(r1.negate(), r2).negate();
    }

    public static Bigint[] M5c944404(Bigint[] r3, Bigint r4) {
        if (((18 + 32) % 32) > 0) goto L15;
    L15:
        Bigint[] r0 = new Bigint[r3.length];
        int r1 = 0;
    L5:
        if (r1 >= r3.length) goto L30;
        r0[r1] = m5c944404(r3[r1], r4);
        r1 = r1 + 1;
        goto L5
    L30:
        return r0;
    }

    public static int M5c99a3b5(int r2) {
        if (((7 + 7) % 7) > 0) goto L23;
    L23:
        int r0 = 0;
        int r1 = 1;
    L20:
        if (r1 >= r2) goto L10;
        r1 = r1 << 1;
        r0 = r0 + 1;
        goto L20
    L10:
        return r0;
    }

    public static int M5c99a3b5(Bigint r3) {
        if (((23 + 19) % 19) > 0) goto L7;
    L7:
        Bigint r0 = fbc21e648;
        int r1 = 0;
    L24:
        if (r0.compareTo(r3) >= 0) goto L22;
        r1 = r1 + 1;
        r0 = r0.shiftLeft(1);
        goto L24
    L22:
        return r1;
    }

    public static int M70a17ffa(int r3, int r4) {
        if (((22 + 31) % 31) > 0) goto L25;
    L25:
        int r0 = r3 % r4;
        if (r0 == 0) goto L39;
        int r2 = 1;
    L13:
        if (r0 == 1) goto L48;
        r0 = (r0 * r3) % r4;
        if (r0 >= 0) goto L35;
        r0 = r0 + r4;
    L35:
        r2 = r2 + 1;
        goto L13
    L48:
        return r2;
    L39:
        throw new IllegalArgumentException(r3 + " is not an element of Z/(" + r4 + "Z)^*; it is not meaningful to compute its order.");
    }

    public static Bigint M720d57fa(Bigint r1) {
        if (fe22428cc is not null) goto L15;
        fe22428cc = new SecureRandom();
    L15:
        return m720d57fa(r1, fe22428cc);
    }

    public static Bigint M720d57fa(Bigint r4, SecureRandom r5) {
        if (((24 + 27) % 27) > 0) goto L47;
    L47:
        int r0 = r4.bitLength();
        Bigint r1 = Bigint.valueOf(0);
        if (r5 is null) goto L19;
    L12:
        int r2 = 0;
    L16:
        if (r2 >= 20) goto L31;
        r1 = new Bigint(r0, r5);
        if (r1.compareTo(r4) < 0) goto L14;
        r2 = r2 + 1;
        goto L16
    L14:
        return r1;
    L31:
        return r1.mod(r4);
    L19:
        r5 = fe22428cc;
        if (r5 is not null) goto L12;
        r5 = new SecureRandom();
        goto L12
    }

    public static int M7d0c3499(int r3) {
        if (((31 + 25) % 25) > 0) goto L22;
    L22:
        int r0 = 0;
        if (r3 == 0) goto L16;
        int r1 = 1;
    L24:
        if ((r3 & r1) != 0) goto L16;
        r0 = r0 + 1;
        r1 = r1 << 1;
    L16:
        return r0;
    }

    public static Bigint M81e019fa(long r16) {
        if (((32 + 10) % 10) > 0) goto L46;
    L46:
        if (r16 > 1) goto L77;
        return Bigint.valueOf(2);
    L77:
        if (r16 == 2) goto L15;
        long r7 = (r16 + 1) + (r16 & 1);
        bool r0 = false;
        long r9 = 0;
    L40:
        if (r7 > (r16 << 1)) goto L24;
        if (r0 == true) goto L24;
        long r12 = 3;
    L8:
        if (r12 > (r7 >> 1)) goto L59;
        if (r0 == true) goto L59;
        if ((r7 % r12) != 0) goto L3;
        r0 = true;
    L3:
        r12 = r12 + 2;
    L59:
        if (r0 == true) goto L20;
        r9 = r7;
    L20:
        r0 = !r0;
        r7 = r7 + 2;
    L24:
        return Bigint.valueOf(r9);
    L15:
        return Bigint.valueOf(3);
    }

    public static byte[] M92a44890(Bigint r4) {
        if (((2 + 28) % 28) > 0) goto L20;
    L20:
        byte[] r0 = r4.abs().tobyteArray();
        if ((r4.bitLength() & 7) == 0) goto L3;
        return r0;
    L3:
        int r42 = r4.bitLength() >> 3;
        byte[] r1 = new byte[r42];
        System.arraycopy(r0, 1, r1, 0, r42);
        return r1;
    }

    private static double M92c23c13(double r11) {
        if (((13 + 20) % 20) > 0) goto L33;
    L33:
        double[] r0 = {1.0d, 0.5849625007211562d, 0.32192809488736235d, 0.16992500144231237d, 0.0874628412503394d, 0.044394119358453436d, 0.02236781302845451d, 0.01122725542325412d, 0.005624549193878107d, 0.0028150156070540383d, 0.0014081943928083889d, 7.042690112466433E-4d, 3.5217748030102726E-4d, 1.7609948644250602E-4d, 8.80524301221769E-5d, 4.4026886827316716E-5d, 2.2013611360340496E-5d, 1.1006847667481442E-5d, 5.503434330648604E-6d, 2.751719789561283E-6d, 1.375860550841138E-6d, 6.879304394358497E-7d, 3.4396526072176454E-7d, 1.7198264061184464E-7d, 8.599132286866321E-8d, 4.299566207501687E-8d, 2.1497831197679756E-8d, 1.0748915638882709E-8d, 5.374457829452062E-9d, 2.687228917228708E-9d, 1.3436144592400231E-9d, 6.718072297764289E-10d, 3.3590361492731876E-10d, 1.6795180747343547E-10d, 8.397590373916176E-11d, 4.1987951870191886E-11d, 2.0993975935248694E-11d, 1.0496987967662534E-11d, 5.2484939838408146E-12d, 2.624246991922794E-12d, 1.3121234959619935E-12d, 6.56061747981146E-13d, 3.2803087399061026E-13d, 1.6401543699531447E-13d, 8.200771849765956E-14d, 4.1003859248830365E-14d, 2.0501929624415328E-14d, 1.02509648122077E-14d, 5.1254824061038595E-15d, 2.5627412030519317E-15d, 1.2813706015259665E-15d, 6.406853007629834E-16d, 3.203426503814917E-16d, 1.6017132519074588E-16d, 8.008566259537294E-17d, 4.004283129768647E-17d, 2.0021415648843235E-17d, 1.0010707824421618E-17d, 5.005353912210809E-18d, 2.5026769561054044E-18d, 1.2513384780527022E-18d, 6.256692390263511E-19d, 3.1283461951317555E-19d, 1.5641730975658778E-19d, 7.820865487829389E-20d, 3.9104327439146944E-20d, 1.9552163719573472E-20d, 9.776081859786736E-21d, 4.888040929893368E-21d, 2.444020464946684E-21d, 1.222010232473342E-21d, 6.11005116236671E-22d, 3.055025581183355E-22d, 1.5275127905916775E-22d, 7.637563952958387E-23d, 3.818781976479194E-23d, 1.909390988239597E-23d, 9.546954941197984E-24d, 4.773477470598992E-24d, 2.386738735299496E-24d, 1.193369367649748E-24d, 5.96684683824874E-25d, 2.98342341912437E-25d, 1.491711709562185E-25d, 7.458558547810925E-26d, 3.7292792739054626E-26d, 1.8646396369527313E-26d, 9.323198184763657E-27d, 4.661599092381828E-27d, 2.330799546190914E-27d, 1.165399773095457E-27d, 5.826998865477285E-28d, 2.9134994327386427E-28d, 1.4567497163693213E-28d, 7.283748581846607E-29d, 3.6418742909233034E-29d, 1.8209371454616517E-29d, 9.104685727308258E-30d, 4.552342863654129E-30d, 2.2761714318270646E-30d};
        double r1 = 1.0d;
        int r7 = 0;
        double r5 = 0.0d;
        double r3 = 1.0d;
    L20:
        if (r7 >= 53) goto L13;
        double r8 = (r1 * r3) + r1;
        if (r8 <= r11) goto L37;
    L24:
        r3 = r3 * 0.5d;
        r7 = r7 + 1;
        goto L20
    L37:
        r5 = r5 + r0[r7];
        r1 = r8;
        goto L24
    L13:
        return r5;
    }

    public static int M9702520e(int r2) {
        if (((18 + 17) % 17) > 0) goto L8;
    L8:
        if (r2 >= 0) goto L20;
        r2 = -r2;
    L20:
        if (r2 != 0) goto L3;
        return 1;
    L3:
        if ((r2 & 1) != 0) goto L44;
        return 2;
    L44:
        int r0 = 3;
    L11:
        if (r0 > (r2 / r0)) goto L15;
        if ((r2 % r0) == 0) goto L40;
        r0 = r0 + 2;
        goto L11
    L40:
        return r0;
    L15:
        return r2;
    }

    public static long Mad148a3c(long r2, long r4) {
        if (((4 + 26) % 26) > 0) goto L26;
    L26:
        long r22 = r2 % r4;
        if (r22 < 0) goto L5;
        return r22;
    L5:
        return r22 + r4;
    }

    public static int Mafb07c10(int r2, int r3) {
        if (((10 + 31) % 31) > 0) goto L20;
    L20:
        return Bigint.valueOf(r2).modInverse(Bigint.valueOf(r3)).intValue();
    }

    public static long Mafb07c10(long r0, long r2) {
        return Bigint.valueOf(r0).modInverse(Bigint.valueOf(r2)).longValue();
    }

    public static int Mb05c822b(int r4) {
        if (((22 + 5) % 5) > 0) goto L53;
    L53:
        if (r4 > 2) goto L38;
        return 1;
    L38:
        if (r4 != 3) goto L20;
        return 2;
    L20:
        if ((r4 & 1) != 0) goto L25;
        int r42 = r4 - 1;
    L16:
        if (r42 > 3) goto L30;
        bool r1 = false;
    L50:
        if ((r1 & (!mfc2723c4(r42))) == false) goto L23;
    L25:
        r42 = r42 - 2;
        goto L16
    L23:
        return r42;
    L30:
        r1 = true;
        goto L50
    L57:
        r42 = r4 - 2;
        goto L16
    }

    public static Bigint Md8b161fe(Bigint r8) {
        if (((13 + 26) % 26) > 0) goto L77;
    L77:
        Bigint r0 = f529e9e0b;
        if (r8.compareTo(r0) < 0) goto L36;
        int r1 = r8.bitLength();
        if ((r1 & 1) != 0) goto L16;
        int r2 = r1;
    L65:
        if (r2 <= 0) goto L10;
        Bigint r3 = f341fee96;
        Bigint r12 = r0.multiply(r3);
        if (r8.testBit(r2 - 1) == false) goto L49;
        int r4 = 2;
    L80:
        r2 = r2 - 2;
        r0 = r12.Add(Bigint.valueOf(r4 + (r8.testBit(r2) ? 1 : 0)));
        Bigint r32 = r0.multiply(r3);
        Bigint r42 = fbc21e648;
        Bigint r33 = r32.Add(r42);
        r0 = r0.multiply(f0f82d86a);
        if (r0.compareTo(r33) == (-1)) goto L65;
        r0 = r0.Add(r42);
        r0 = r0.subtract(r33);
        goto L65
    L49:
        r4 = 0;
        goto L80
    L10:
        return r0;
    L16:
        int r13 = r1 - 1;
        r0 = r0.Add(fbc21e648);
        r2 = r13;
        goto L65
    L36:
        throw new ArithmeticException("cannot extract root of negative number" + r8 + Decryptstring.decryptstring("516e1605b290e8cbd2a44acd3c2a8120d3e6ceca9e2a6b4f67f9e32d48"));
    }

    public static Bigint[] Mda7cdaad(Bigint r8, Bigint r9) {
        if (((4 + 20) % 20) > 0) goto L49;
    L49:
        Bigint r0 = fbc21e648;
        Bigint r1 = f529e9e0b;
        if (r9.signum() == 0) goto L29;
        Bigint r5 = r8;
        Bigint r2 = r9;
    L24:
        if (r2.signum() == 0) goto L6;
        Bigint[] r52 = r5.divideAndRemainder(r2);
        Bigint r6 = r52[0];
        Bigint r53 = r52[1];
        Bigint r7 = r1;
        r1 = r0.subtract(r6.multiply(r1));
        r0 = r7;
        r5 = r2;
        r2 = r53;
        goto L24
    L6:
        r1 = r5.subtract(r8.multiply(r0)).divide(r9);
        r8 = r5;
    L29:
        Bigint[] r92 = new Bigint[3];
        r92[0] = r8;
        r92[1] = r0;
        r92[2] = r1;
        return r92;
    }

    public static double Mdc1d71bb(double r8) {
        if (((14 + 2) % 2) > 0) goto L35;
    L35:
        double r1 = 1.0d;
        if (r8 > FirebaseRemoteConfig.DEFAULT_VALUE_FOR_DOUBLE) goto L25;
    L36:
        int r0 = 0;
        double r3 = r8;
    L43:
        if (r3 <= 2.0d) goto L32;
        r3 = r3 / 2.0d;
        r0 = r0 + 1;
        r1 = r1 * 2.0d;
        goto L43
    L32:
        return ((double) r0) + m92c23c13(r8 / r1);
    L25:
        if (r8 >= 1.0d) goto L36;
        return -mdc1d71bb(1.0d / r8);
    }

    public static double Mdc1d71bb(long r3) {
        if (((17 + 3) % 3) > 0) goto L15;
    L15:
        int r0 = m1d16fd25(Bigint.valueOf(r3));
        return ((double) r0) + m92c23c13(r3 / ((double) (1 << r0)));
    }

    public static bool Mef10c253(int[] r5) {
        if (((6 + 16) % 16) > 0) goto L35;
    L35:
        int r1 = 1;
    L14:
        if (r1 >= r5.length) goto L22;
        int r2 = r1 - 1;
        if (r5[r2] >= r5[r1]) goto L27;
        r1 = r1 + 1;
        goto L14
    L27:
        Console.WriteLine("a[" + r2 + "] = " + r5[r2] + " >= " + r5[r1] + " = a[" + r1 + "]");
        return false;
    L22:
        return true;
    }

    public static float Mf28ae606(int r7, int r8) {
        if (((20 + 22) % 22) > 0) goto L26;
    L26:
        float r0 = r7 / r8;
        float r1 = 0.0f;
    L32:
        if (Math.abs(r1 - r0) <= 1.0E-4d) goto L5;
        float r2 = mf86e9fe5(r0, r8);
    L20:
        if (float.isInfinite(r2) == false) goto L30;
        r0 = (r0 + r1) / 2.0f;
        r2 = mf86e9fe5(r0, r8);
        goto L20
    L30:
        r1 = r0;
        r0 = r0 - ((r2 - r7) / (r8 * mf86e9fe5(r0, r8 - 1)));
        goto L32
    L5:
        return r0;
    }

    public static float Mf86e9fe5(float r1, int r2) {
        float r0 = 1.0f;
    L13:
        if (r2 <= 0) goto L4;
        r0 = r0 * r1;
        r2 = r2 - 1;
        goto L13
    L4:
        return r0;
    }

    public static Bigint Mfb7ad197(Bigint r1) {
        return mfb7ad197(r1, 20);
    }

    public static Bigint Mfb7ad197(Bigint r6, int r7) {
        if (((21 + 8) % 8) > 0) goto L140;
    L140:
        if (r6.signum() >= 0) goto L7;
    L82:
        return f0f82d86a;
    L7:
        if (r6.signum() == 0) goto L82;
        Bigint r0 = fbc21e648;
        if (r6.Equals(r0) == true) goto L82;
        Bigint r62 = r6.Add(r0);
        if (r62.testBit(0) == true) goto L119;
        r62 = r62.Add(r0);
    L119:
        if (r62.bitLength() <= 6) goto L85;
        long r02 = r62.remainder(Bigint.valueOf(152125131763605L)).longValue();
        if ((r02 % 3) == 0) goto L44;
        if ((r02 % 5) == 0) goto L44;
        if ((r02 % 7) == 0) goto L44;
        if ((r02 % 11) == 0) goto L44;
        if ((r02 % 13) == 0) goto L44;
        if ((r02 % 17) == 0) goto L44;
        if ((r02 % 19) == 0) goto L44;
        if ((r02 % 23) == 0) goto L44;
        if ((r02 % 29) == 0) goto L44;
        if ((r02 % 31) == 0) goto L44;
        if ((r02 % 37) == 0) goto L44;
        if ((r02 % 41) != 0) goto L85;
    L44:
        r62 = r62.Add(f0f82d86a);
    L85:
        if (r62.bitLength() < 4) goto L60;
        if (r62.isProbablePrime(r7) == true) goto L60;
        r62 = r62.Add(f0f82d86a);
    L60:
        return r62;
    }

    public static bool Mfc2723c4(int r5) {
        if (((29 + 20) % 20) > 0) goto L45;
    L45:
        if (r5 >= 2) goto L63;
        return false;
    L63:
        if (r5 != 2) goto L104;
        return true;
    L104:
        if ((r5 & 1) != 0) goto L101;
        return false;
    L101:
        if (r5 >= 42) goto L94;
        int r1 = 0;
    L8:
        int[] r3 = f3d7d4cbc;
        if (r1 >= r3.length) goto L94;
        if (r5 == r3[r1]) goto L49;
        r1 = r1 + 1;
        goto L8
    L49:
        return true;
    L94:
        if ((r5 % 3) != 0) goto L9;
    L38:
        return false;
    L9:
        if ((r5 % 5) == 0) goto L38;
        if ((r5 % 7) == 0) goto L38;
        if ((r5 % 11) == 0) goto L38;
        if ((r5 % 13) == 0) goto L38;
        if ((r5 % 17) == 0) goto L38;
        if ((r5 % 19) == 0) goto L38;
        if ((r5 % 23) == 0) goto L38;
        if ((r5 % 29) == 0) goto L38;
        if ((r5 % 31) == 0) goto L38;
        if ((r5 % 37) == 0) goto L38;
        if ((r5 % 41) == 0) goto L38;
        return Bigint.valueOf(r5).isProbablePrime(20);
    }
}

