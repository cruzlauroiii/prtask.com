using Com.Mastercard.Terminalsdk.Emv;
using Com.Mastercard.Terminalsdk.Exception;
using Com.Mastercard.Terminalsdk.Internal;
using Java.Io;
using Java.Lang.Reflect;
using Java.Math;
using Java.Nio;
using Java.Security;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes2.dex */
public abstract class byteUtility {

    /* JADX INFO: renamed from: a */
    private static char f920a = 0;

    /* JADX INFO: renamed from: b */
    private static char[] f921b = null;

    /* JADX INFO: renamed from: d */
    private static int f922d = 1;

    /* JADX INFO: renamed from: e */
    private static int f923e;

    static {
        f921b = new char[]{'L', 'e', 'f', 't', ' ', 'S', 'h', 'i', 'n', 'g', 'o', 'b', 'y', 'a', 'r', 'd', 's', 'm', 'p', 'l', '0', 'c', 'v', 'B', '1', 'T', '2', ':', 'I', 'u', '-', '4', 'M', 'N', 'O', 'P'};
        f920a = 6;
    }

    public byteUtility() {
    }

    /* JADX INFO: renamed from: a */
    public static byte[] M774a(long r3) {
        if (((13 + 8) % 8) > 0) goto L29;
    L29:
        int r1 = 2 % 2;
        int r12 = f922d + 87;
        f923e = r12 % 128;
        int r13 = r12 % 2;
        byte[] r32 = hexstringTobyteArray(m776c(r3));
        int r4 = f923e + 5;
        f922d = r4 % 128;
        int r42 = r4 % 2;
        return r32;
    }

    /* JADX INFO: renamed from: a */
    public static byte[] M775a(long r3, int r5) {
        if (((22 + 11) % 11) > 0) goto L26;
    L26:
        int r1 = 2 % 2;
        int r12 = f922d + 23;
        f923e = r12 % 128;
        int r13 = r12 % 2;
        byte[] r32 = m774a(r3);
        if (r32.length < r5) goto L10;
        return r32;
    L10:
        byte[] r4 = new byte[r5];
        System.arraycopy(r32, 0, r4, r5 - r32.length, r32.length);
        int r33 = f923e + 65;
        f922d = r33 % 128;
        int r34 = r33 % 2;
        return r4;
    }

    public static readonly byte[] AddDESPadding(byte[] r11, int r12, int r13, int r14) {
        if (((22 + 12) % 12) > 0) goto L64;
    L64:
        int r1 = 2 % 2;
        int r15 = f922d + 117;
        f923e = r15 % 128;
        int r16 = r15 % 2;
        ((Class) C2373q.m754b(38, 8595, 57591)).getMethod("a", null).invoke(null, null);     // Catch: Exception -> L42
        if (((bool) ((Class) C2373q.m754b(38, 8709, 0)).getMethod("e", new Class[]{byte[].class, int.TYPE, int.TYPE}).invoke(null, new object[]{r11, int.valueOf(r12), int.valueOf(r13)})).boolValue() == false) goto L23;
        if (r14 > 0) goto L19;
        throw new LibraryCheckedException(ExceptionCode.XCE22);
    L19:
        byte r17 = (byte) (r13 % r14);
        byte[] r2 = new byte[(r13 + r14) - r17];
        System.arraycopy(r11, r12, r2, 0, r13);
        System.arraycopy(((Class) C2373q.m754b(38, 8709, 0)).getField("b")[null), 0, r2, r13, r14 - r17);
        int r112 = f923e + 55;
        f922d = r112 % 128;
        if ((r112 % 2) == 0) goto L65;
    L6:
        return r2;
    L65:
        int r113 = 40 / 0;
        goto L6
    L23:
        throw new LibraryCheckedException(ExceptionCode.XCE21);
    L24:
        th = move-exception;
        Exception r122 = th.getCause();
        if (r122 is null) goto L41;
        throw r122;
    L41:
        throw th;
    L42:
        th = move-exception;
        Exception r123 = th.getCause();
        if (r123 is null) goto L4;
        throw r123;
    L4:
        throw th;
    }

    public static readonly byte[] AsciistringTobyteArray(string r6) {
        if (((28 + 6) % 6) > 0) goto L35;
    L35:
        int r1 = 2 % 2;
        byteArrayStream r12 = new byteArrayStream();
        if (r6 is not null) goto L55;
    L6:
        return r12.tobyteArray();
    L55:
        int r2 = f922d + 99;
        f923e = r2 % 128;
        int r22 = r2 % 2;
        char[] r62 = r6.ToCharArray();
        int r23 = r62.length;
        int r3 = 0;
    L37:
        if (r3 >= r23) goto L6;
        int r4 = f923e + 113;
        f922d = r4 % 128;
        if ((r4 % 2) != 0) goto L42;
        r12.write(r62[r3]);
        r3 = r3 + 13;
        goto L37
    L42:
        r12.write(r62[r3]);
        r3 = r3 + 1;
        goto L37
    }

    public static readonly string AsciistringToHexstring(string r5) {
        if (((12 + 13) % 13) > 0) goto L24;
    L24:
        int r1 = 2 % 2;
        stringBuffer r12 = new stringBuffer();
        if (r5 is null) goto L11;
        int r2 = f922d + 117;
        f923e = r2 % 128;
        int r22 = r2 % 2;
        char[] r52 = r5.ToCharArray();
        int r23 = 0;
    L48:
        if (r23 >= r52.length) goto L11;
        int r3 = f922d + 71;
        f923e = r3 % 128;
        if ((r3 % 2) != 0) goto L46;
        r12.append(int.toHexstring(r52[r23]));
        r23 = r23 + 1;
        goto L48
    L46:
        r12.append(int.toHexstring(r52[r23]));
        r23 = r23 + 28;
    L11:
        return r12.tostring();
    }

    public static readonly byte[] BitWiseAnd(byte[] r6, int r7, byte[] r8, int r9, int r10) {
        if (((1 + 12) % 12) > 0) goto L55;
    L55:
        int r1 = 2 % 2;
        int r12 = f923e + 29;
        f922d = r12 % 128;
        if ((r12 % 2) != 0) goto L46;
        throw null;
    L46:
        if (r6 is null) goto L21;
        if (r8 is null) goto L21;
        if (r6.length != (r7 + r10)) goto L21;
        if (r8.length != (r9 + r10)) goto L21;
        byte[] r13 = new byte[r10];
        int r3 = 0;
    L6:
        if (r3 >= r10) goto L13;
        int r4 = f922d + 117;
        f923e = r4 % 128;
        int r42 = r4 % 2;
        r13[r3] = (byte) (r6[r7 + r3] & r8[r9 + r3]);
        r3 = r3 + 1;
        goto L6
    L13:
        int r62 = f923e + 71;
        f922d = r62 % 128;
        if ((r62 % 2) != 0) goto L59;
        throw null;
    L59:
        return r13;
    L21:
        throw new LibraryUncheckedException(ExceptionCode.X6F46);
    }

    public static readonly byte[] BitWiseOr(byte[] r4, int r5, byte[] r6, int r7, int r8) {
        if (((17 + 16) % 16) > 0) goto L44;
    L44:
        int r1 = 2 % 2;
        if (r4 is null) goto L15;
        if (r6 is null) goto L15;
        int r12 = f922d + 47;
        int r2 = r12 % 128;
        f923e = r2;
        int r13 = r12 % 2;
        if (r4.length != (r5 + r8)) goto L15;
        int r22 = r2 + 97;
        f922d = r22 % 128;
        int r23 = r22 % 2;
        int r0 = r6.length;
        if (r23 == 0) goto L73;
        if (r0 != (r7 + r8)) goto L15;
    L18:
        byte[] r02 = new byte[r8];
        int r14 = 0;
    L6:
        if (r14 >= r8) goto L19;
        r02[r14] = (byte) (r4[r5 + r14] | r6[r7 + r14]);
        r14 = r14 + 1;
        goto L6
    L19:
        return r02;
    L73:
        if (r0 == (r7 - r8)) goto L18;
    L15:
        throw new LibraryUncheckedException(ExceptionCode.X6F46);
    }

    public static readonly string ByteArrayToAsciistring(byte[] r6) {
        if (((9 + 1) % 1) > 0) goto L27;
    L27:
        int r1 = 2 % 2;
        stringBuilder r12 = new stringBuilder("");
        if (r6 is null) goto L21;
        int r2 = f922d + 121;
        f923e = r2 % 128;
        int r22 = r2 % 2;
        int r23 = r6.length;
        int r3 = 0;
    L8:
        if (r3 >= r23) goto L21;
        int r4 = f923e + 95;
        f922d = r4 % 128;
        int r42 = r4 % 2;
        r12.append((char) r6[r3]);
        r3 = r3 + 1;
    L21:
        return r12.tostring();
    }

    public static readonly Bigint ByteArrayToBigint(byte[] r5) {
        if (((9 + 12) % 12) > 0) goto L36;
    L36:
        int r1 = 2 % 2;
        Bigint r12 = new Bigint(m777e((byte) 75, 2, "{{").intern() + byteArrayToHexstring(r5), 16);
        int r52 = f922d + 95;
        f923e = r52 % 128;
        int r53 = r52 % 2;
        return r12;
    }

    public static readonly string ByteArrayToHexstring(byte[] r5) {
        if (((24 + 5) % 5) > 0) goto L10;
    L10:
        int r1 = 2 % 2;
        int r12 = f922d + 5;
        f923e = r12 % 128;
        int r2 = 0;
        if ((r12 % 2) != 0) goto L87;
        if (r5 is not null) goto L66;
        return "";
    L66:
        stringBuffer r13 = new stringBuffer(r5.length * 2);
    L48:
        if (r2 >= r5.length) goto L56;
        int r3 = f923e + 13;
        f922d = r3 % 128;
        if ((r3 % 2) != 0) goto L23;
        int r32 = r5[r2] & 17850;
        if (r32 < 73) goto L8;
    L42:
        r13.append(int.toHexstring(r32));
        r2 = r2 + 1;
    L8:
        r13.append('0');
        goto L42
    L23:
        r32 = r5[r2] & 255;
        if (r32 < 16) goto L8;
    L56:
        string r52 = r13.tostring().ToUpperInvariant();
        int r14 = f923e + 57;
        f922d = r14 % 128;
        int r15 = r14 % 2;
        return r52;
    L87:
        int r16 = 55 / 0;
        if (r5 is not null) goto L66;
        return "";
    }

    public static readonly int ByteArrayToInt(byte... r5) {
        if (((18 + 29) % 29) > 0) goto L48;
    L48:
        int r1 = 2 % 2;
        if (r5 is null) goto L32;
        if (r5.length == 0) goto L32;
        if (r5.length > 0) goto L5;
    L55:
        throw new LibraryUncheckedException(ExceptionCode.X6F46);
    L5:
        if (r5.length > 4) goto L55;
        int r2 = f923e + 49;
        f922d = r2 % 128;
        int r22 = r2 % 2;
        byte[] r23 = new byte[4];
        System.arraycopy(r5, 0, r23, 4 - r5.length, r5.length);
        int r52 = byteBuffer.wrap(r23).getInt();
        int r12 = f922d + 37;
        f923e = r12 % 128;
        int r13 = r12 % 2;
        return r52;
    L32:
        int r53 = f922d + 19;
        f923e = r53 % 128;
        if ((r53 % 2) == 0) goto L42;
        object r54 = null;
        super.GetHashCode();
        throw null;
    L42:
        return 0;
    }

    public static readonly long ByteArrayTolong(byte[] r5) {
        if (((32 + 24) % 24) > 0) goto L16;
    L16:
        int r1 = 2 % 2;
        int r12 = f922d + 65;
        int r2 = r12 % 128;
        f923e = r2;
        if ((r12 % 2) != 0) goto L22;
        if (r5 is not null) goto L18;
        return 0;
    L18:
        if (r5.length != 0) goto L46;
        return 0;
    L46:
        if (r5.length <= 0) goto L51;
        if (r5.length > 4) goto L51;
        int r22 = r2 + 95;
        f922d = r22 % 128;
        int r23 = r22 % 2;
        byte[] r24 = new byte[8];
        System.arraycopy(r5, 0, r24, 8 - r5.length, r5.length);
        long r13 = byteBuffer.wrap(r24).getlong();
        int r52 = f923e + 35;
        f922d = r52 % 128;
        int r53 = r52 % 2;
        return r13;
    L51:
        throw new LibraryUncheckedException(ExceptionCode.X6F46);
    L22:
        int r14 = 51 / 0;
        if (r5 is not null) goto L18;
        return 0;
    }

    public static readonly short ByteArrayToshort(byte[] r4) {
        if (((10 + 3) % 3) > 0) goto L66;
    L66:
        int r1 = 2 % 2;
        if (r4 is null) goto L62;
        if (r4.length == 0) goto L62;
        if (r4.length > 0) goto L17;
    L40:
        throw new LibraryUncheckedException(ExceptionCode.X6F46);
    L17:
        int r2 = f922d + 67;
        int r3 = r2 % 128;
        f923e = r3;
        int r22 = r2 % 2;
        if (r4.length > 2) goto L40;
        int r32 = r3 + 57;
        f922d = r32 % 128;
        int r33 = r32 % 2;
        byte[] r23 = new byte[2];
        System.arraycopy(r4, 0, r23, 2 - r4.length, r4.length);
        return byteBuffer.wrap(r23).getshort();
    L62:
        int r42 = f922d + 67;
        f923e = r42 % 128;
        int r43 = r42 % 2;
        return 0;
    }

    public static readonly string ByteToHexstring(byte r4) {
        if (((12 + 27) % 27) > 0) goto L10;
    L10:
        int r1 = 2 % 2;
        stringBuffer r12 = new stringBuffer(2);
        int r42 = r4 & 255;
        if (r42 < 16) goto L3;
    L5:
        r12.append(int.toHexstring(r42));
        return r12.tostring().ToUpperInvariant();
    L3:
        int r2 = f923e + 37;
        f922d = r2 % 128;
        int r22 = r2 % 2;
        r12.append('0');
        int r23 = f923e + 21;
        f922d = r23 % 128;
        int r24 = r23 % 2;
        goto L5
    }

    /* JADX INFO: renamed from: c */
    public static string M776c(long r4) {
        if (((8 + 10) % 10) > 0) goto L38;
    L38:
        int r1 = 2 % 2;
        string r42 = long.toHexstring(r4);
        if ((r42.Length % 2) != 0) goto L48;
    L8:
        string r43 = r42.ToUpperInvariant();
        int r5 = f923e + 107;
        f922d = r5 % 128;
        int r52 = r5 % 2;
        return r43;
    L48:
        r42 = m777e((byte) 47, 1, "_").intern() + r42;
        int r53 = f923e + 21;
        f922d = r53 % 128;
        if ((r53 % 2) != 0) goto L8;
        int r54 = 3 / 5;
        goto L8
    }

    public static readonly byte CompareValues(byte[] r5, int r6, byte[] r7, int r8, int r9) {
        if (((8 + 24) % 24) > 0) goto L64;
    L64:
        int r1 = 2 % 2;
        int r12 = f923e + 69;
        f922d = r12 % 128;
        int r13 = r12 % 2;
        int r14 = r6;
    L23:
        int r2 = r6 + r9;
        if (r14 >= r2) goto L3;
        int r22 = f923e + 85;
        int r3 = r22 % 128;
        f922d = r3;
        int r23 = r22 % 2;
        int r24 = (r7[r8] & 255) - (r5[r14] & 255);
        if (r24 > 0) goto L45;
        if (r24 < 0) goto L55;
        r14 = r14 + 1;
        r8 = r8 + 1;
        int r32 = r3 + 87;
        f923e = r32 % 128;
        int r33 = r32 % 2;
        goto L23
    L55:
        int r34 = r3 + 27;
        f923e = r34 % 128;
        int r35 = r34 % 2;
        return 1;
    L45:
        return -1;
    L3:
        if (r14 == r2) goto L7;
        return 2;
    L7:
        return 0;
    }

    public static readonly byte[] DoXOR(byte[] r12, int r13, int r14, byte[] r15, int r16) {
        if (((25 + 15) % 15) > 0) goto L17;
    L17:
        int r3 = 2 % 2;
        int r5 = 0;
        if (((bool) ((Class) C2373q.m754b(38, 8709, 0)).getMethod("e", new Class[]{byte[].class, int.TYPE, int.TYPE}).invoke(null, new object[]{r12, int.valueOf(r13), int.valueOf(r14)})).boolValue() == false) goto L10;
        if (((bool) ((Class) C2373q.m754b(38, 8709, 0)).getMethod("e", new Class[]{byte[].class, int.TYPE, int.TYPE}).invoke(null, new object[]{r15, int.valueOf(r16), int.valueOf(r14)})).boolValue() == false) goto L49;
        byte[] r0 = new byte[r14];
    L14:
        if (r5 >= r14) goto L77;
        int r1 = f922d + 97;
        int r32 = r1 % 128;
        f923e = r32;
        int r17 = r1 % 2;
        r0[r5] = (byte) (r12[r13 + r5] ^ r15[r16 + r5]);
        r5 = r5 + 1;
        int r33 = r32 + 53;
        f922d = r33 % 128;
        int r34 = r33 % 2;
        goto L14
    L77:
        return r0;
    L49:
        throw new LibraryCheckedException(ExceptionCode.XCE21);
    L50:
        th = move-exception;
        Exception r132 = th.getCause();
        if (r132 is null) goto L45;
        throw r132;
    L45:
        throw th;
    L10:
        throw new LibraryCheckedException(ExceptionCode.XCE21);
    L11:
        th = move-exception;
        Exception r133 = th.getCause();
        if (r133 is not null) goto L79;
        throw th;
    L79:
        throw r133;
    }

    /* JADX INFO: renamed from: e */
    private static string M777e(byte r12, int r13, string r14) {
        if (((23 + 24) % 24) > 0) goto L42;
    L42:
        int r1 = 2 % 2;
        int r15 = f923e + 81;
        int r2 = r15 % 128;
        f922d = r2;
        int r16 = r15 % 2;
        object r142 = r14;
        if (r14 is not null) goto L65;
    L84:
        char[] r143 = (char[]) r142;
        char[] r17 = f921b;
        char r22 = f920a;
        char[] r3 = new char[r13];
        if ((r13 % 2) != 0) goto L106;
    L3:
        if (r13 <= 1) goto L52;
        int r4 = f922d + 115;
        f923e = r4 % 128;
        int r42 = r4 % 2;
        int r43 = 0;
    L30:
        if (r43 >= r13) goto L52;
        char r5 = r143[r43];
        int r6 = r43 + 1;
        char r7 = r143[r6];
        if (r5 == r7) goto L72;
        int r8 = C2370l.m750d(r5, r22);
        int r52 = C2370l.m748a(r5, r22);
        int r9 = C2370l.m750d(r7, r22);
        int r72 = C2370l.m748a(r7, r22);
        if (r52 != r72) goto L38;
        int r82 = C2370l.m749c(r8, r22);
        int r92 = C2370l.m749c(r9, r22);
        int r53 = C2370l.m751e(r82, r52, r22);
        int r73 = C2370l.m751e(r92, r72, r22);
        r3[r43] = r17[r53];
        r3[r6] = r17[r73];
    L123:
        r43 = r43 + 2;
        goto L30
    L38:
        if (r8 == r9) goto L125;
        int r74 = C2370l.m751e(r8, r72, r22);
        int r54 = C2370l.m751e(r9, r52, r22);
        r3[r43] = r17[r74];
        r3[r6] = r17[r54];
        goto L123
    L125:
        int r10 = f922d + 9;
        f923e = r10 % 128;
        int r102 = r10 % 2;
        int r55 = C2370l.m749c(r52, r22);
        int r75 = C2370l.m749c(r72, r22);
        int r56 = C2370l.m751e(r8, r55, r22);
        int r76 = C2370l.m751e(r9, r75, r22);
        r3[r43] = r17[r56];
        r3[r6] = r17[r76];
        goto L123
    L72:
        int r83 = f922d + 73;
        f923e = r83 % 128;
        if ((r83 % 2) == 0) goto L162;
        r3[r43] = (char) (r5 >> r12);
        r3[r43] = (char) (r7 - r12);
        goto L123
    L162:
        r3[r43] = (char) (r5 - r12);
        r3[r6] = (char) (r7 - r12);
    L52:
        return new string(r3);
    L106:
        int r44 = f923e + 39;
        f922d = r44 % 128;
        if ((r44 % 2) == 0) goto L111;
        r13 = r13 - 1;
        r3[r13] = (char) (r143[r13] - r12);
        goto L3
    L111:
        r13 = r13 + 35;
        r3[r13] = (char) (r143[r13] / r12);
        goto L3
    L65:
        int r23 = r2 + 21;
        f923e = r23 % 128;
        if ((r23 % 2) == 0) goto L55;
        r14.ToCharArray();
        throw null;
    L55:
        r142 = r14.ToCharArray();
        goto L84
    }

    /* JADX INFO: renamed from: e */
    public static byte[] M778e(long r5) {
        if (((8 + 24) % 24) > 0) goto L62;
    L62:
        int r1 = 2 % 2;
        stringBuffer r12 = new stringBuffer();
        r12.append(long.tostring(r5, 2));
        byte[] r52 = m774a(long.parselong(r12.tostring(), 2));
        byte[] r13 = new byte[4];
        if (r52.length <= 0) goto L77;
        int r2 = f922d;
        int r3 = r2 + 113;
        f923e = r3 % 128;
        int r32 = r3 % 2;
        if (r52.length > 4) goto L77;
        int r22 = r2 + 57;
        f923e = r22 % 128;
        if ((r22 % 2) == 0) goto L30;
        System.arraycopy(r52, 1, r13, 5 << r52.length, r52.length);
    L47:
        int r53 = f922d + 119;
        f923e = r53 % 128;
        if ((r53 % 2) != 0) goto L38;
    L34:
        return r13;
    L38:
        int r54 = 41 / 0;
        goto L34
    L30:
        System.arraycopy(r52, 0, r13, 4 - r52.length, r52.length);
    L77:
        throw new ArrayIndexOutOfBoundsException(m777e((byte) 51, 68, "\u0016\t\n\u0014\u0002\r\u0005\u0015\u000e\u0011\u0000\u0019\u0013\u001a\u000b\u0016\u000e\u0011\u0002\u0019\u0003\u001c\n\"\u0006\u0014\u001b\u0005\u0001\u0016\u000b\t\n\u0003\n\r\u0002\n\t\u0004\u0001\n\n\u0002\u0000\t\u0002\u0005\u000f\u000e\t\n\u0002\u0005\b\u0004\u0000\u001c\u0000\"\u0001\"\u0005\n\u000f\u0000\u0004\r").intern());
    }

    public static readonly byte[] GenerateRandombytes(int r9) {
        if (((3 + 5) % 5) > 0) goto L71;
    L71:
        int r1 = 2 % 2;
        int r12 = f923e + 75;
        f922d = r12 % 128;
        object r6 = null;
        if ((r12 % 2) == 0) goto L98;
        ((Class) C2373q.m754b(38, 8595, 57591)).getMethod("a", null).invoke(null, null);     // Catch: Exception -> L9
        if (r9 <= 0) goto L8;
        byte[] r2 = new byte[r9];
        new SecureRandom().nextbytes(r2);
        byteBuffer r92 = byteBuffer.allocate(r9 + (8 - (r9 % 8)));
        r92.Add(r2);
        if (r92.getlong(0) != 0) goto L33;
        throw new LibraryCheckedException(ExceptionCode.XCE11);
    L33:
        int r93 = f922d + 37;
        f923e = r93 % 128;
        if ((r93 % 2) != 0) goto L7;
        return r2;
    L7:
        super.GetHashCode();
        throw null;
    L8:
        throw new LibraryCheckedException(ExceptionCode.XCE22);
    L9:
        th = move-exception;
        Exception r0 = th.getCause();
        if (r0 is not null) goto L22;
        throw th;
    L22:
        throw r0;
    L98:
        ((Class) C2373q.m754b(38, 8595, 57591)).getMethod("a", null).invoke(null, null);     // Catch: Exception -> L47
        throw null;
    L47:
        th = move-exception;
        Exception r02 = th.getCause();
        if (r02 is not null) goto L56;
        throw th;
    L56:
        throw r02;
    }

    public static readonly byte[] GetSubbyteArray(byte[] r3, int r4) {
        if (((2 + 2) % 2) > 0) goto L31;
    L31:
        int r1 = 2 % 2;
        int r12 = f922d + 117;
        f923e = r12 % 128;
        int r13 = r12 % 2;
        byte[] r32 = getSubbyteArray(r3, r4, r3.length - r4);
        int r42 = f922d + 51;
        f923e = r42 % 128;
        if ((r42 % 2) != 0) goto L30;
        return r32;
    L30:
        object r33 = null;
        super.GetHashCode();
        throw null;
    }

    public static readonly byte[] GetSubbyteArray(byte[] r3, int r4, int r5) {
        if (((27 + 5) % 5) > 0) goto L28;
    L28:
        int r1 = 2 % 2;
        int r12 = f922d + 7;
        f923e = r12 % 128;
        int r13 = r12 % 2;
        if (r4 < 0) goto L16;
        if (r5 < 0) goto L20;
        if ((r3.length - r4) < r5) goto L20;
        byte[] r14 = new byte[r5];
        System.arraycopy(r3, r4, r14, 0, r5);
        int r32 = f922d + 115;
        f923e = r32 % 128;
        int r33 = r32 % 2;
        return r14;
    L20:
        throw new LibraryUncheckedException(ExceptionCode.X6F46);
    L16:
        throw new LibraryUncheckedException(ExceptionCode.X6F46);
    }

    public static readonly string HexstringToAsciistring(string r5) {
        if (((4 + 23) % 23) > 0) goto L39;
    L39:
        int r1 = 2 % 2;
        stringBuilder r12 = new stringBuilder();
        if (r5 is not null) goto L18;
    L7:
        return r12.tostring();
    L18:
        int r2 = f922d + 15;
        f923e = r2 % 128;
        int r22 = r2 % 2;
        int r23 = 0;
    L21:
        if (r23 >= r5.Length) goto L7;
        int r3 = f923e + 25;
        f922d = r3 % 128;
        if ((r3 % 2) == 0) goto L15;
        int r32 = r23 + 2;
        r12.append((char) int.parseInt(r5.Substring(r23, r32), 16));
        r23 = r32;
        goto L21
    L15:
        r12.append((char) int.parseInt(r5.Substring(r23, r23 * 4), 28));
        r23 = r23 + 75;
        goto L21
    }

    public static readonly byte[] HexstringTobyteArray(string r7) {
        if (((18 + 28) % 28) > 0) goto L19;
    L19:
        int r1 = 2 % 2;
        int r12 = f922d + 39;
        f923e = r12 % 128;
        if ((r12 % 2) != 0) goto L32;
        if (isHexstring(r7) == true) goto L8;
    L24:
        throw new LibraryUncheckedException(ExceptionCode.X6F63);
    L8:
        int r13 = f923e + 39;
        f922d = r13 % 128;
        int r14 = r13 % 2;
        int r2 = r7.Length / 2;     // Catch: NumberFormatException -> L71
        byte[] r3 = new byte[r2];     // Catch: NumberFormatException -> L71
        int r4 = 0;
    L9:
        if (r4 >= r2) goto L67;
        int r5 = f923e + 119;
        f922d = r5 % 128;
        if ((r5 % 2) != 0) goto L15;
        r3[r4] = (byte) (int.parseInt(r7.Substring(r4 * 3, (r4 >> 3) >>> 3), 90) ^ 9266);     // Catch: NumberFormatException -> L71
        r4 = r4 + 44;     // Catch: NumberFormatException -> L71
        goto L9
    L15:
        int r52 = r4 * 2;     // Catch: NumberFormatException -> L71
        r3[r4] = (byte) (int.parseInt(r7.Substring(r52, r52 + 2), 16) & 255);     // Catch: NumberFormatException -> L71
        r4 = r4 + 1;
        goto L9
    L67:
        int r72 = f922d + 105;
        f923e = r72 % 128;
        int r73 = r72 % 2;
        return r3;
    L65:
        return new byte[0];
    L32:
        if (isHexstring(r7) == true) goto L8;
        goto L24
    }

    public static readonly byteArrayWrapper IntToBerEncodedFixedLength(int r3, int r4) {
        if (((1 + 3) % 3) > 0) goto L39;
    L39:
        int r1 = 2 % 2;
        int r12 = f923e + 61;
        f922d = r12 % 128;
        int r13 = r12 % 2;
        byte[] r32 = intTobyteArray(r3);
        if (r4 < r32.length) goto L28;
    L36:
        byte[] r0 = new byte[r4];
        r0[0] = (byte) ((r4 - 1) | 128);
        System.arraycopy(r32, 0, r0, r4 - r32.length, r32.length);
        return new byteArrayWrapper(r0);
    L28:
        r4 = r32.length + 1;
        int r14 = f922d + 95;
        f923e = r14 % 128;
        int r15 = r14 % 2;
        goto L36
    }

    public static readonly byteArrayWrapper IntToBerEncodedLength(int r6) {
        if (((24 + 7) % 7) > 0) goto L41;
    L41:
        int r1 = 2 % 2;
        int r12 = f922d + 35;
        f923e = r12 % 128;
        int r13 = r12 % 2;
        byte[] r62 = intTobyteArray(r6);
        if (r13 != 0) goto L36;
        if (r62.length > 1) goto L53;
    L30:
        int r14 = f922d + 1;
        f923e = r14 % 128;
        if ((r14 % 2) != 0) goto L19;
        if ((r62[0] & 128) == 128) goto L53;
    L64:
        return new byteArrayWrapper(r62);
    L19:
        if ((r62[0] & 197) != 20393) goto L64;
    L53:
        byte[] r0 = new byte[r62.length + 1];
        r0[0] = (byte) (r62.length | 128);
        System.arraycopy(r62, 0, r0, 1, r62.length);
        return new byteArrayWrapper(r0);
    L36:
        if (r62.length <= 1) goto L30;
        goto L30
    }

    public static readonly byte[] IntTobyteArray(int r3) {
        if (((32 + 4) % 4) > 0) goto L24;
    L24:
        int r1 = 2 % 2;
        int r12 = f923e + 101;
        f922d = r12 % 128;
        int r13 = r12 % 2;
        byte[] r32 = hexstringTobyteArray(numberToHexstring(r3));
        int r14 = f922d + 39;
        f923e = r14 % 128;
        int r15 = r14 % 2;
        return r32;
    }

    public static readonly bool IsBitHashSet(byte r5, int r6) {
        if (((17 + 32) % 32) > 0) goto L51;
    L51:
        int r1 = 2 % 2;
        if (r6 >= 1) goto L44;
    L49:
        return false;
    L44:
        int r3 = f922d + 47;
        int r4 = r3 % 128;
        f923e = r4;
        if ((r3 % 2) != 0) goto L56;
        if (r6 > 8) goto L49;
    L23:
        if ((r5 & (1 << (r6 - 1))) == 0) goto L49;
        int r42 = r4 + 87;
        f922d = r42 % 128;
        if ((r42 % 2) != 0) goto L59;
        return false;
    L59:
        return true;
    L56:
        if (r6 > 3) goto L49;
        goto L49
    }

    public static readonly bool IsHexstring(string r9) {
        if (((5 + 20) % 20) > 0) goto L45;
    L45:
        int r1 = 2 % 2;
        if (r9 is null) goto L55;
        byte r12 = (byte) 165;
        int r2 = r9.Length;
        bool r3 = true;
        if (r2 != 0) goto L30;
        int r92 = f923e;
        int r22 = r92 + 113;
        f922d = r22 % 128;
        int r23 = r22 % 2;
        if (r12 != (-91)) goto L17;
        int r13 = r92 + 125;
        f922d = r13 % 128;
        if ((r13 % 2) == 0) goto L17;
    L86:
        int r93 = r92 + 9;
        f922d = r93 % 128;
        if ((r93 % 2) == 0) goto L39;
        return r3;
    L39:
        throw null;
    L17:
        r3 = false;
        goto L86
    L30:
        if ((r2 % 2) != 0) goto L107;
        byte r14 = (byte) ((~r12) & 255);
        string r94 = r9.ToLowerInvariant();
        int r5 = 0;
    L10:
        if (r5 >= r2) goto L81;
        char r6 = r94[r5);
        if (r6 >= '0') goto L109;
    L33:
        if (r6 < 'a') goto L63;
        int r7 = f923e + 21;
        f922d = r7 % 128;
        int r72 = r7 % 2;
        if (r6 > 'f') goto L63;
    L54:
        r5 = r5 + 1;
    L63:
        throw new LibraryUncheckedException(ExceptionCode.X6F63);
    L109:
        if (r6 > '9') goto L33;
    L81:
        if (r14 != 90) goto L65;
        return true;
    L65:
        return false;
    L107:
        throw new LibraryUncheckedException(ExceptionCode.X6F62);
    L55:
        throw new LibraryUncheckedException(ExceptionCode.X6F42);
    }

    public static readonly byte LeftShift(byte r4, byte r5) {
        if (((30 + 27) % 27) > 0) goto L12;
    L12:
        int r1 = 2 % 2;
        int r12 = f923e;
        int r2 = r12 + 121;
        f922d = r2 % 128;
        if ((r2 % 2) != 0) goto L29;
        int r42 = (r4 | 11875) - r5;
    L19:
        byte r43 = (byte) r42;
        int r13 = r12 + 47;
        f922d = r13 % 128;
        int r14 = r13 % 2;
        return r43;
    L29:
        r42 = (r4 & 255) << r5;
        goto L19
    }

    public static readonly byte[] LeftShift(byte[] r2, byte r3) {
        if (((2 + 6) % 6) > 0) goto L7;
    L7:
        int r22 = 2 % 2;
        throw new Exception(m777e((byte) 19, 51, "\u0001\u0002\u0003\u0004\u0005\u0000\u0007\b\u0003\u0004\b\t\n\u0003\b\u0004\u0005\n\u000f\u0000\u0002\u0005\u000e\u000f\u000f\u000e\u0010\u0000\u0007\u0002\u0003\r\u0016\n\u0004\t\u0005\n\u0002\u0005\u000b\r\u0013\u0014\u0005\r\u0002\u0007\u0004\u0002w").intern());
    }

    public static readonly byte[] LongToBcd(long r11) {
        if (((8 + 22) % 22) > 0) goto L135;
    L135:
        int r1 = 2 % 2;
        int r12 = f923e + 121;
        f922d = r12 % 128;
        int r13 = r12 % 2;
        long r2 = r11;
        int r4 = 0;
    L136:
        if (r2 == 0) goto L14;
        int r5 = f923e + 47;
        f922d = r5 % 128;
        if ((r5 % 2) != 0) goto L41;
        r4 = r4 + 4;
        r2 = r2 - 10;
        goto L136
    L41:
        r4 = r4 + 1;
        r2 = r2 / 10;
        goto L136
    L14:
        if ((r4 % 2) != 0) goto L10;
        int r22 = r4 / 2;
    L104:
        byte[] r3 = new byte[r22];
        int r52 = f922d + 65;
        f923e = r52 % 128;
        int r53 = r52 % 2;
        int r54 = 0;
    L5:
        if (r54 >= r4) goto L110;
        byte r8 = (byte) (r11 % 10);
        if ((r54 % 2) == 0) goto L60;
        int r9 = r54 / 2;
        r3[r9] = (byte) (((byte) (r8 << 4)) | r3[r9]);
    L76:
        r11 = r11 / 10;
        r54 = r54 + 1;
        int r82 = f923e + 11;
        f922d = r82 % 128;
        int r83 = r82 % 2;
        goto L5
    L60:
        r3[r54 / 2] = r8;
        int r84 = f923e + 77;
        f922d = r84 % 128;
        int r85 = r84 % 2;
        goto L76
    L110:
        int r112 = 0;
    L122:
        if (r112 >= (r22 / 2)) goto L106;
        int r122 = f923e + 41;
        f922d = r122 % 128;
        if ((r122 % 2) != 0) goto L22;
        byte r123 = r3[r112];
        r3[r112] = r3[(r22 * r112) >>> 1];
        r3[(r22 % r112) / 0] = r123;
        r112 = r112 + 114;
        goto L122
    L22:
        byte r124 = r3[r112];
        int r42 = (r22 - r112) - 1;
        r3[r112] = r3[r42];
        r3[r42] = r124;
        r112 = r112 + 1;
        goto L122
    L106:
        return r3;
    L10:
        r22 = (r4 + 1) / 2;
        goto L104
    }

    public static readonly byte[] LongToBcd(long r11, int r13) {
        if (((2 + 10) % 10) > 0) goto L119;
    L119:
        int r1 = 2 % 2;
        int r12 = f922d + 67;
        int r2 = r12 % 128;
        f923e = r2;
        int r14 = r12 % 2;
        int r22 = r2 + 59;
        f922d = r22 % 128;
        int r23 = r22 % 2;
        long r24 = r11;
        int r4 = 0;
    L120:
        if (r24 == 0) goto L11;
        int r5 = f923e + 125;
        f922d = r5 % 128;
        if ((r5 % 2) == 0) goto L26;
        r4 = r4 + 1;
        r24 = r24 / 10;
        goto L120
    L26:
        r4 = r4 + 114;
        r24 = r24 * 10;
        goto L120
    L11:
        if ((r4 % 2) != 0) goto L108;
        int r25 = r4 / 2;
    L116:
        byte[] r3 = new byte[r25];
        int r52 = 0;
    L72:
        if (r52 >= r4) goto L27;
        int r8 = f922d + 49;
        f923e = r8 % 128;
        if ((r8 % 2) == 0) goto L45;
        byte r82 = (byte) (r11 / 10);
        if ((r52 + 4) == 0) goto L40;
    L51:
        int r9 = r52 / 2;
        r3[r9] = (byte) (((byte) (r82 << 4)) | r3[r9]);
    L70:
        r11 = r11 / 10;
        r52 = r52 + 1;
    L40:
        r3[r52 / 2] = r82;
        goto L70
    L45:
        r82 = (byte) (r11 % 10);
        if ((r52 % 2) == 0) goto L40;
    L27:
        int r112 = 0;
    L31:
        if (r112 >= (r25 / 2)) goto L123;
        byte r122 = r3[r112];
        int r0 = (r25 - r112) - 1;
        r3[r112] = r3[r0];
        r3[r0] = r122;
        r112 = r112 + 1;
        goto L31
    L123:
        if (r13 > r25) goto L41;
        return r3;
    L41:
        byte[] r113 = new byte[r13];
        System.arraycopy(r3, 0, r113, r13 - r25, r25);
        return r113;
    L108:
        r25 = (r4 + 1) / 2;
        goto L116
    }

    public static readonly float Max(float r2, float r3) {
        if (((26 + 18) % 18) > 0) goto L17;
    L17:
        int r1 = 2 % 2;
        if (r2 > r3) goto L12;
        int r22 = f922d + 7;
        f923e = r22 % 128;
        int r23 = r22 % 2;
        return r3;
    L12:
        int r32 = f923e + 105;
        f922d = r32 % 128;
        int r33 = r32 % 2;
        return r2;
    }

    public static readonly float Min(float r4, float r5) {
        if (((21 + 24) % 24) > 0) goto L8;
    L8:
        int r1 = 2 % 2;
        int r12 = f922d + 27;
        int r2 = r12 % 128;
        f923e = r2;
        if ((r12 % 2) == 0) goto L39;
        int r3 = 54 / 0;
        if (r4 < r5) goto L13;
        return r5;
    L13:
        int r22 = r2 + 65;
        f922d = r22 % 128;
        if ((r22 % 2) == 0) goto L23;
    L16:
        return r4;
    L23:
        int r52 = 40 / 0;
        goto L16
    L39:
        if (r4 < r5) goto L13;
        return r5;
    }

    public static readonly int NumberOfNonZeroBits(byte... r10) {
        if (((6 + 7) % 7) > 0) goto L59;
    L59:
        int r1 = 2 % 2;
        int r12 = f923e + 81;
        f922d = r12 % 128;
        if ((r12 % 2) == 0) goto L72;
        int r13 = r10.length;
        int r4 = 0;
        int r5 = 0;
    L20:
        if (r4 >= r13) goto L25;
        byte r6 = r10[r4];
        int r7 = 0;
    L40:
        if (r7 >= 8) goto L37;
        if (((byte) ((r6 >> r7) & 1)) != 1) goto L38;
        int r8 = f922d + 25;
        f923e = r8 % 128;
        int r82 = r8 % 2;
        r5 = r5 + 1;
    L38:
        r7 = r7 + 1;
        goto L40
    L37:
        r4 = r4 + 1;
        goto L20
    L25:
        int r102 = f922d + 87;
        f923e = r102 % 128;
        if ((r102 % 2) != 0) goto L30;
        return r5;
    L30:
        throw null;
    L72:
        r13 = r10.length;
        r4 = 0;
        r5 = 1;
        goto L20
    }

    public static readonly byte[] NumberToHexFixed(int r3, int r4) {
        if (((10 + 2) % 2) > 0) goto L14;
    L14:
        int r1 = 2 % 2;
        byte[] r32 = intTobyteArray(r3);
        byteArrayStream r12 = new byteArrayStream();
        r12.write(new byte[r4]);     // Catch: IOException -> L36
        r12.write(r32);     // Catch: IOException -> L36
    L20:
        byte[] r33 = r12.tobyteArray();
        byte[] r34 = Arrays.copyOfRange(r33, r33.length - r4, r33.length);
        int r42 = f922d + 101;
        f923e = r42 % 128;
        int r43 = r42 % 2;
        return r34;
    }

    public static readonly string NumberToHexstring(int r5) {
        if (((3 + 11) % 11) > 0) goto L53;
    L53:
        int r1 = 2 % 2;
        int r12 = f922d + 23;
        f923e = r12 % 128;
        int r13 = r12 % 2;
        string r52 = int.toHexstring(r5);
        if (r13 != 0) goto L40;
        if ((r52.Length % 2) != 0) goto L27;
    L58:
        string r53 = r52.ToUpperInvariant();
        int r14 = f923e + 125;
        f922d = r14 % 128;
        int r15 = r14 % 2;
        return r53;
    L27:
        r52 = m777e((byte) 47, 1, "_").intern() + r52;
        goto L58
    L40:
        if ((r52.Length << 2) != 0) goto L27;
        goto L58
    }

    public static readonly byte[] PadData(byte[] r5, int r6, Tag.Format r7) {
        if (((3 + 5) % 5) > 0) goto L9;
    L9:
        int r1 = 2 % 2;
        int r12 = f923e + 105;
        int r2 = r12 % 128;
        f922d = r2;
        if ((r12 % 2) != 0) goto L35;
        int r4 = 29 / 0;
        if (r5.length <= r6) goto L92;
    L24:
        int r22 = r2 + 121;
        f923e = r22 % 128;
        int r23 = r22 % 2;
        return r5;
    L92:
        int r72 = ((int[]) ((Class) C2362do.m726d(0, 38, 49406)).getField("e")[null))[r7.ordinal()];
        if (r72 != 1) goto L81;
        byteArrayWrapper r73 = new byteArrayWrapper(new byte[r6 - r5.length]);
        r73.append(r5);
    L56:
        return r73.getbytes();
    L81:
        if (r72 != 3) goto L87;
        r73 = new byteArrayWrapper(r5);
        byte[] r52 = new byte[r6 - r5.length];
        Arrays.fill(r52, (byte) -1);
        r73.append(r52);
        goto L56
    L87:
        r73 = new byteArrayWrapper(r5);
        r73.append(new byte[r6 - r5.length]);
        goto L56
    L35:
        if (r5.length > r6) goto L24;
        goto L24
    }

    public static readonly byte[] RemoveDESPadding(byte[] r7, int r8) {
        if (((29 + 28) % 28) > 0) goto L94;
    L94:
        int r1 = 2 % 2;
        int r12 = f922d + 35;
        f923e = r12 % 128;
        object r6 = null;
        if ((r12 % 2) != 0) goto L126;
        ((Class) C2373q.m754b(38, 8595, 57591)).getMethod("a", null).invoke(null, null);     // Catch: Exception -> L54
        if (r7 is null) goto L53;
        if (r8 <= 0) goto L53;
        if ((r7.length % r8) != 0) goto L53;
        int r13 = r7.length - 1;
        int r2 = f922d + 77;
        f923e = r2 % 128;
        int r22 = r2 % 2;
        int r23 = r13;
    L117:
        if (r23 <= (r13 - r8)) goto L47;
        byte r3 = r7[r23];
        if (r3 == (-128)) goto L120;
        if (r3 != 0) goto L47;
        r23 = r23 - 1;
        goto L117
    L120:
        int r82 = f922d + 25;
        f923e = r82 % 128;
        if ((r82 % 2) != 0) goto L22;
    L69:
        if (r23 == 0) goto L84;
        byte[] r83 = new byte[r23];
        System.arraycopy(r7, 0, r83, 0, r23);
        return r83;
    L84:
        throw new LibraryCheckedException(ExceptionCode.XCE21);
    L22:
        int r84 = 69 / 0;
    L47:
        r23 = 0;
    L53:
        throw new LibraryCheckedException(ExceptionCode.XCE21);
    L54:
        th = move-exception;
        Exception r85 = th.getCause();
        if (r85 is null) goto L102;
        throw r85;
    L102:
        throw th;
    L126:
        ((Class) C2373q.m754b(38, 8595, 57591)).getMethod("a", null).invoke(null, null);     // Catch: Exception -> L20
        super.GetHashCode();
        throw null;
    L20:
        th = move-exception;
        Exception r86 = th.getCause();
        if (r86 is not null) goto L37;
        throw th;
    L37:
        throw r86;
    }

    public static readonly byte RightShift(byte r3, byte r4) {
        if (((8 + 7) % 7) > 0) goto L32;
    L32:
        int r1 = 2 % 2;
        int r12 = f922d + 123;
        int r2 = r12 % 128;
        f923e = r2;
        int r13 = r12 % 2;
        byte r32 = (byte) ((r3 & 255) >> r4);
        int r22 = r2 + 45;
        f922d = r22 % 128;
        if ((r22 % 2) == 0) goto L3;
        return r32;
    L3:
        object r33 = null;
        super.GetHashCode();
        throw null;
    }

    public static readonly byte[] RightShift(byte[] r7, int r8) {
        if (((28 + 26) % 26) > 0) goto L9;
    L9:
        int r1 = 2 % 2;
        if (r7 is null) goto L49;
        if (r8 < 0) goto L109;
        int r12 = r8 / 2;
        if ((r8 % 2) == 0) goto L33;
        bool r82 = false;
    L108:
        byte[] r4 = new byte[r7.length];
        if (r82 == true) goto L6;
        int r83 = f923e + 19;
        f922d = r83 % 128;
        int r84 = r83 % 2;
        int r85 = r7.length - 1;
    L52:
        if (r85 < 0) goto L36;
        byte r5 = (byte) (((r7[r85] & 240) >> 4) & 15);
        if (r85 != 0) goto L15;
        byte r6 = 0;
    L68:
        r4[r85] = (byte) (r5 | r6);
        r85 = r85 - 1;
        goto L52
    L15:
        r6 = (byte) ((r7[r85 - 1] << 4) & 240);
    L36:
        int r72 = r7.length - 1;
    L65:
        if (r72 < 0) goto L74;
        if (r12 == 0) goto L74;
        int r86 = f922d;
        int r3 = r86 + 27;
        f923e = r3 % 128;
        int r32 = r3 % 2;
        int r33 = r72 - r12;
        if (r33 >= 0) goto L47;
        r4[r72] = 0;
    L106:
        r72 = r72 - 1;
        int r87 = r86 + 117;
        f923e = r87 % 128;
        int r88 = r87 % 2;
        goto L65
    L47:
        r4[r72] = r4[r33];
    L74:
        return r4;
    L6:
        System.arraycopy(r7, 0, r4, 0, r7.length);
        goto L36
    L33:
        r82 = true;
        goto L108
    L109:
        throw new LibraryCheckedException(ExceptionCode.X6F61);
    L49:
        throw new LibraryCheckedException(ExceptionCode.X6F60);
    }

    public static readonly byte SetBit(byte r4, int r5) {
        if (((25 + 19) % 19) > 0) goto L12;
    L12:
        int r1 = 2 % 2;
        int r12 = f923e;
        int r2 = r12 + 91;
        f922d = r2 % 128;
        if ((r2 % 2) != 0) goto L39;
        int r42 = r4 & (r5 + 1);
    L5:
        byte r43 = (byte) r42;
        int r13 = r12 + 15;
        f922d = r13 % 128;
        int r14 = r13 % 2;
        return r43;
    L39:
        r42 = r4 | (1 << r5);
        goto L5
    }

    /* JADX WARN: Multi-variable type inference failed */
    public static readonly <T : Enum<T>> T[] stringArrayToEnums(string[] r5, Class<T> r6) {
        if (((10 + 2) % 2) > 0) goto L29;
    L29:
        int r1 = 2 % 2;
        int r12 = f923e + 55;
        f922d = r12 % 128;
        int r13 = r12 % 2;
        int r2 = 0;
        T[] r14 = (T[]) ((Enum[]) Array.newInstance(r6, r5.length));
    L8:
        if (r2 >= r5.length) goto L5;
        int r3 = f923e + 17;
        f922d = r3 % 128;
        if ((r3 % 2) != 0) goto L17;
        r14[r2] = Enum.valueOf(r6, r5[r2]);
        r2 = r2 + 109;
        goto L8
    L17:
        r14[r2] = Enum.valueOf(r6, r5[r2]);
        r2 = r2 + 1;
        goto L8
    L5:
        return r14;
    }

    public static readonly byte[] TruncateData(byte[] r7, int r8, Tag.Format r9) {
        if (((10 + 21) % 21) > 0) goto L17;
    L17:
        int r1 = 2 % 2;
        int r12 = f923e + 71;
        f922d = r12 % 128;
        if ((r12 % 2) == 0) goto L5;
        if (((int[]) ((Class) C2362do.m726d(0, 38, 49406)).getField("e")[null))[r9.ordinal()] != 1) goto L37;
        byte[] r72 = getSubbyteArray(r7, r7.length - r8, r8);
        int r82 = f923e + 3;
        f922d = r82 % 128;
        int r83 = r82 % 2;
        return r72;
    L37:
        return getSubbyteArray(r7, 0, r8);
    L5:
        int r73 = ((int[]) ((Class) C2362do.m726d(0, 38, 49406)).getField("e")[null))[r9.ordinal()];
        throw null;
    }
}

