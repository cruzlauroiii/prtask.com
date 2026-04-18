using Com.Decryptstringmanager;
using Com.Google.Common.Base;
using Com.Mastercard.Terminalsdk.Emv;
using Com.Mastercard.Terminalsdk.Exception;
using Com.Mastercard.Terminalsdk.Internal;
using Com.Mastercard.Terminalsdk.Iso8825;
using Com.Mastercard.Terminalsdk.Objects;
using Java.Util;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes2.dex */
public abstract class TLVUtility {

    /* JADX INFO: renamed from: a */
    private static string f930a = null;

    /* JADX INFO: renamed from: b */
    private static long f931b = 0;

    /* JADX INFO: renamed from: c */
    private static int f932c = 0;

    /* JADX INFO: renamed from: d */
    private static stringBuilder f933d = null;

    /* JADX INFO: renamed from: e */
    private static bool f934e = false;

    /* JADX INFO: renamed from: g */
    private static int f935g = 0;

    /* JADX INFO: renamed from: h */
    private static int f936h = 1;

    static {
        if (((14 + 5) % 5) > 0) goto L18;
    L18:
        m794e();
        f932c = -1;
        f930a = m786a(Decryptstring.decryptstring("86fd624d8ad62da5e84b5b5b4ff39f83737b2fd2d22863c7d8de17fbee321ec701affac26f1c0b39f0126330d06c")).intern();
        f934e = false;
        f933d = new stringBuilder();
        int r0 = f935g + 91;
        f936h = r0 % 128;
        if ((r0 % 2) == 0) goto L31;
        return;
    L31:
        object r02 = null;
        super.GetHashCode();
        throw null;
    }

    public TLVUtility() {
    }

    /* JADX INFO: renamed from: a */
    private static BerTlv M785a(List<BerTlv> r4, byte[] r5) {
        if (((29 + 18) % 18) > 0) goto L35;
    L35:
        int r1 = 2 % 2;
        IEnumerator<BerTlv> r42 = r4.GetEnumerator();
    L17:
        if (r42.MoveNext() == false) goto L44;
        int r12 = f935g + 109;
        f936h = r12 % 128;
        int r13 = r12 % 2;
        BerTlv r14 = r42.Current;
        if (r14.getTagobject().getNTag() == byteUtility.byteArrayToInt(r5)) goto L16;
        if (r14.isConstructed() == false) goto L17;
        int r43 = f935g + 103;
        f936h = r43 % 128;
        int r44 = r43 % 2;
        return m785a((List) r14.getValue(), r5);
    L16:
        int r45 = f935g + 3;
        f936h = r45 % 128;
        if ((r45 % 2) == 0) goto L33;
    L68:
        return r14;
    L33:
        int r46 = 15 / 0;
        goto L68
    L44:
        throw new LibraryCheckedException(ExceptionCode.X0111);
    }

    /* JADX INFO: renamed from: a */
    private static string M786a(string r11) {
        if (((29 + 28) % 28) > 0) goto L32;
    L32:
        int r1 = 2 % 2;
        object r112 = r11;
        if (r11 is null) goto L65;
        r112 = r11.ToCharArray();
    L65:
        char[] r113 = C2371m.m752c(f931b, (char[]) r112);
        int r2 = 4;
    L70:
        if (r2 >= r113.length) goto L49;
        int r3 = f936h + 71;
        int r4 = r3 % 128;
        f935g = r4;
        int r32 = r3 % 2;
        int r33 = r2 - 4;
        r113[r2] = (char) (((long) (r113[r2] ^ r113[r2 % 4])) ^ (((long) r33) * f931b));
        r2 = r2 + 1;
        int r42 = r4 + 31;
        f936h = r42 % 128;
        int r43 = r42 % 2;
        goto L70
    L49:
        string r22 = new string(r113, 4, r113.length - 4);
        int r114 = f936h + 35;
        f935g = r114 % 128;
        if ((r114 % 2) == 0) goto L21;
        object r115 = null;
        super.GetHashCode();
        throw null;
    L21:
        return r22;
    }

    /* JADX INFO: renamed from: b */
    private static void M787b(byte[] r0, Tag r1, ContentType r2) {
        int r12 = 2 % 2;
        int r13 = f935g + 109;
        f936h = r13 % 128;
        if ((r13 % 2) == 0) goto L15;
        return;
    L15:
        throw null;
    }

    /* JADX INFO: renamed from: b */
    private static byte[] M788b(List<BerTlv> r5, byte[] r6, byte[] r7) {
        if (((21 + 2) % 2) > 0) goto L8;
    L8:
        int r1 = 2 % 2;
        int r12 = f936h + 7;
        f935g = r12 % 128;
        if ((r12 % 2) != 0) goto L42;
        if (r5.Count <= 0) goto L70;
    L82:
        IEnumerator<BerTlv> r13 = r5.GetEnumerator();
    L45:
        if (r13.MoveNext() == false) goto L30;
        BerTlv r2 = r13.Current;
        if (r2.getTagobject().getNTag() != byteUtility.byteArrayToInt(r6)) goto L37;
        r2.setRawbytes(new byteArrayWrapper(r7));
        int r22 = f936h + 3;
        f935g = r22 % 128;
        int r23 = r22 % 2;
        goto L45
    L37:
        if (r2.isConstructed() == false) goto L45;
        r2.setRawbytes(new byteArrayWrapper(m788b((List) r2.getValue(), r6, r7)));
        goto L45
    L30:
        byte[] r52 = formbyteArrayFromTlvList(r5, ContentType.TLV);
        int r62 = f936h + 83;
        f935g = r62 % 128;
        int r63 = r62 % 2;
        return r52;
    L70:
        throw new LibraryUncheckedException(ExceptionCode.X6F43);
    L42:
        int r24 = 33 / 0;
        if (r5.Count > 0) goto L82;
        goto L82
    }

    /* JADX INFO: renamed from: c */
    private static bool M789c(List<byte[]> r3, byte[] r4) {
        if (((9 + 12) % 12) > 0) goto L47;
    L47:
        int r1 = 2 % 2;
        int r12 = f935g + 73;
        f936h = r12 % 128;
        if ((r12 % 2) == 0) goto L25;
        IEnumerator<byte[]> r32 = r3.GetEnumerator();
    L34:
        if (r32.MoveNext() == false) goto L16;
        if (Arrays.Equals(r32.Current, r4) == false) goto L34;
        int r33 = f935g + 9;
        f936h = r33 % 128;
        int r34 = r33 % 2;
        return true;
    L16:
        return false;
    L25:
        r3.GetEnumerator();
        throw null;
    }

    /* JADX INFO: renamed from: c */
    private static byte[] M790c(byte[] r7) {
        if (((14 + 4) % 4) > 0) goto L32;
    L32:
        int r1 = 2 % 2;
        if (r7 is not null) goto L72;
    L67:
        throw new LibraryUncheckedException(ExceptionCode.X6F41);
    L72:
        if (r7.length <= 0) goto L67;
        int r12 = f935g + 103;
        f936h = r12 % 128;
        int r13 = r12 % 2;
        if ((r7[0] & Ascii.f458US) != 31) goto L12;
        int r2 = 0;
        int r3 = 1;
    L5:
        r2 = r2 + 1;
        if ((r7.length - r2) < 1) goto L16;
        r3 = r3 + 1;
        if ((r7[r2] & 128) == 128) goto L5;
        int r22 = f936h + 111;
        f935g = r22 % 128;
        int r23 = r22 % 2;
        byte[] r72 = byteUtility.getSubbyteArray(r7, 0, r3);
        if (r23 != 0) goto L65;
    L25:
        return r72;
    L65:
        int r0 = 65 / 0;
        goto L25
    L16:
        throw new LibraryUncheckedException(ExceptionCode.X6F43);
    L12:
        return byteUtility.getSubbyteArray(r7, 0, 1);
    }

    public static List<BerTlv> ConditionalTlvParsing(byte[] r17, ContentType r18, string r19, bool r20) {
        if (((11 + 27) % 27) > 0) goto L44;
    L44:
        int r10 = 2;
        int r2 = 2 % 2;
        int r22 = f936h + 63;
        f935g = r22 % 128;
        int r23 = r22 % 2;
        f932c++;
        if (r17 is null) goto L19;
        if (r18 is null) goto L19;
        if (r19 is null) goto L19;
        List<BerTlv> r13 = new List();
        int r14 = r17.length;
        int r24 = 0;
    L115:
        if (r24 >= r14) goto L24;
        int r3 = f936h + 49;
        f935g = r3 % 128;
        if ((r3 % r10) != 0) goto L186;
        int r25 = m791d(r17, r24);     // Catch: LibraryUncheckedException -> L53 Exception -> L158
        if (r25 >= r14) goto L121;
    L73:
        byte[] r32 = getCurrentTag(r17, r25);     // Catch: LibraryUncheckedException -> L53 Exception -> L158
        Tag r5 = getReferenceTagDetails(r32);     // Catch: LibraryUncheckedException -> L53 Exception -> L158
        int r26 = r25 + r32.length;     // Catch: LibraryUncheckedException -> L53 Exception -> L158
        if (r18 != ContentType.DOL) goto L136;
    L187:
        int r16 = r10;
        if (m795e(r17, r26) == false) goto L40;
        if (r18 != ContentType.DOL) goto L89;
        TLVLengthInfo r33 = new TLVLengthInfo(byteUtility.getSubbyteArray(r17, r26, 1));     // Catch: LibraryUncheckedException -> L41 Exception -> L158
    L88:
        byte[] r4 = r33.getLengthbytes();     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        int r7 = r33.getExpectedNumberOfbytes();     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        int r102 = r26 + r33.getLengthbytes().length;     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        if (r18 == ContentType.DOL) goto L35;
        if (r7 == 0) goto L35;
        byte[] r42 = m797e(r17, r102, r18, r7);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        if (r42 is not null) goto L96;
    L98:
        r102 = r102 + r7;     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        if (isConstructed(r32) == true) goto L165;
    L33:
        BerTlv r27 = m792e(r32, r4, r42, r5, r19, new byteArrayWrapper(r42), false);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
    L80:
        r13.Add(r27);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
    L82:
        r24 = r102;
        r10 = r16;
        goto L115
    L165:
        int r72 = f935g + 33;
        f936h = r72 % 128;
        if ((r72 % 2) != 0) goto L31;
        int r8 = 11 / 0;     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        if (r18 == ContentType.TDO) goto L33;
    L32:
        int r73 = f932c;     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        List<BerTlv> r74 = conditionalTlvParsing(r42, r18, r19, r20);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        f932c = r73;     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        r27 = m792e(r32, r4, r42, r5, r19, r74, true);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        goto L80
    L31:
        if (r18 == ContentType.TDO) goto L33;
    L96:
        if (f934e == false) goto L98;
        m787b(r42, r5, r18);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
    L35:
        if (isConstructed(r32) == false) goto L37;
        r27 = m792e(r32, r4, new byte[0], r5, r19, new List(), true);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        goto L80
    L37:
        r27 = m792e(r32, r4, new byte[0], r5, r19, new byteArrayWrapper(new byte[0]), false);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        goto L80
    L89:
        r33 = getTLVLengthInfo(r17, r26);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
        goto L88
    L40:
        throw new LibraryUncheckedException(ExceptionCode.X6F43);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
    L41:
        e = e;
    L169:
        if (r20 == true) goto L66;
        throw e;     // Catch: Exception -> L158
    L66:
        f932c = -1;
        int r0 = f935g + 71;
        f936h = r0 % 128;
        if ((r0 % 2) == 0) goto L118;
    L177:
        return r13;
    L118:
        int r02 = 95 / 0;
        goto L177
    L136:
        int r43 = f935g + 29;
        f936h = r43 % 128;
        int r44 = r43 % r10;
        if (r18 == ContentType.TLV) goto L187;
        if (r18 == ContentType.TDO) goto L187;
        if (r18 == ContentType.f765T) goto L70;
        r16 = r10;
        r102 = r26;
        goto L82
    L70:
        r16 = r10;
        r102 = r26;
        r27 = m792e(r32, new byte[0], new byte[0], r5, r19, null, false);     // Catch: LibraryUncheckedException -> L41 Exception -> L158
    L121:
        int r03 = f936h + 61;
        f935g = r03 % 128;
        int r04 = r03 % r10;
        goto L24
    L186:
        r25 = m791d(r17, r24);     // Catch: LibraryUncheckedException -> L53 Exception -> L158
        if (r25 < r14) goto L73;
    L158:
        th = move-exception;
        f932c = -1;
        throw th;
    L53:
        e = e;
    L24:
        f932c = -1;
        int r05 = f936h + 55;
        f935g = r05 % 128;
        int r06 = r05 % 2;
        return r13;
    L19:
        f932c = -1;
        throw new LibraryUncheckedException(ExceptionCode.X6F42);
    }

    /* JADX INFO: renamed from: d */
    private static int M791d(byte[] r4, int r5) {
        if (((26 + 6) % 6) > 0) goto L32;
    L32:
        int r1 = 2 % 2;
        int r12 = f935g + 15;
        f936h = r12 % 128;
        int r13 = r12 % 2;
        int r14 = r4[r5] & 255;
    L29:
        if (r14 != 0) goto L5;
        int r15 = f935g + 19;
        int r2 = r15 % 128;
        f936h = r2;
        int r16 = r15 % 2;
        r5 = r5 + 1;
        if (r5 >= r4.length) goto L5;
        r14 = r4[r5] & 255;
        int r22 = r2 + 91;
        f935g = r22 % 128;
        int r23 = r22 % 2;
    L5:
        return r5;
    }

    /* JADX INFO: renamed from: e */
    private static BerTlv M792e(byte[] r12, byte[] r13, byte[] r14, Tag r15, string r16, object r17, bool r18) {
        if (((27 + 14) % 14) > 0) goto L67;
    L67:
        int r1 = 2 % 2;
        int r19 = f936h + 75;
        f935g = r19 % 128;
        int r110 = r19 % 2;
        string[] r8 = new string[1];
        r8[0] = r16;
        Tag.SourceSignal[] r111 = r15.getUpdateSources();
        Tag.Format r4 = r15.getFormat();
        int r5 = r15.getMinLen();
        int r6 = r15.getMaxLen();
        string r7 = r15.getName();
        Tag.Rule r9 = r15.getRuleToApply();
        if (r111 is not null) goto L43;
        Tag r2 = new Tag(r12, r4, r5, r6, r7, r8, r9, r15.getError());
        int r122 = f936h + 67;
        f935g = r122 % 128;
        int r123 = r122 % 2;
    L10:
        BerTlv r3 = new BerTlv(r2, new byteArrayWrapper(r14), r13, r17, r18);
        int r124 = f935g + 11;
        f936h = r124 % 128;
        int r125 = r124 % 2;
        return r3;
    L43:
        r2 = new Tag(r12, r4, r5, r6, r7, r8, r9, r15.getUpdateSources(), r15.getError());
        goto L10
    }

    /* JADX INFO: renamed from: e */
    private static List<BerTlv> M793e(List<BerTlv> r6, List<byte[]> r7, ContentType r8) {
        if (((32 + 19) % 19) > 0) goto L18;
    L18:
        int r1 = 2 % 2;
        int r12 = f936h + 41;
        f935g = r12 % 128;
        if ((r12 % 2) == 0) goto L31;
        r6.GetEnumerator();
        object r62 = null;
        super.GetHashCode();
        throw null;
    L31:
        IEnumerator<BerTlv> r13 = r6.GetEnumerator();
    L35:
        if (r13.MoveNext() == false) goto L41;
        int r2 = f935g + 123;
        f936h = r2 % 128;
        int r22 = r2 % 2;
        BerTlv r23 = r13.Current;
        if (m789c(r7, r23.getTag()) == true) goto L75;
        int r24 = f935g + 101;
        f936h = r24 % 128;
        int r25 = r24 % 2;
        r13.Remove();
        if (r25 != 0) goto L35;
        int r26 = 51 / 0;
        goto L35
    L75:
        if (r23.isConstructed() == false) goto L35;
        List<BerTlv> r3 = m793e((List) r23.getValue(), r7, r8);
        if (r3.Count > 0) goto L33;
        r23.setRawbytes(new byteArrayWrapper(new byte[0]));
        goto L35
    L33:
        r23.setRawbytes(new byteArrayWrapper(formbyteArrayFromTlvList(r3, r8)));
        goto L35
    L41:
        return r6;
    }

    /* JADX INFO: renamed from: e */
    static void M794e() {
        if (((3 + 3) % 3) > 0) goto L15;
    L15:
        f931b = 1459017721602382471L;
    }

    /* JADX INFO: renamed from: e */
    private static bool M795e(byte[] r3, int r4) {
        if (((19 + 25) % 25) > 0) goto L24;
    L24:
        int r1 = 2 % 2;
        int r12 = f936h + 109;
        f935g = r12 % 128;
        int r13 = r12 % 2;
        if (byteUtility.getSubbyteArray(r3, r4).length <= 0) goto L26;
        return true;
    L26:
        int r32 = f935g + 89;
        f936h = r32 % 128;
        int r33 = r32 % 2;
        return false;
    }

    /* JADX INFO: renamed from: e */
    private static bool M796e(byte[] r2, int r3, int r4) {
        if (((30 + 29) % 29) > 0) goto L25;
    L25:
        int r1 = 2 % 2;
        if (byteUtility.getSubbyteArray(r2, r3).length >= r4) goto L36;
        int r22 = f935g + 31;
        f936h = r22 % 128;
        int r23 = r22 % 2;
        return false;
    L36:
        int r24 = f936h + 53;
        f935g = r24 % 128;
        int r25 = r24 % 2;
        return true;
    }

    /* JADX INFO: renamed from: e */
    private static byte[] M797e(byte[] r3, int r4, ContentType r5, int r6) {
        if (((25 + 9) % 9) > 0) goto L7;
    L7:
        int r1 = 2 % 2;
        int r12 = f935g + 71;
        f936h = r12 % 128;
        int r13 = r12 % 2;
        if (r5 != ContentType.TLV) goto L36;
    L4:
        if (r6 <= 0) goto L25;
        int r52 = f936h + 65;
        f935g = r52 % 128;
        int r53 = r52 % 2;
        if (m796e(r3, r4, r6) == true) goto L13;
        throw new LibraryUncheckedException(ExceptionCode.X6F43);
    L13:
        return byteUtility.getSubbyteArray(r3, r4, r6);
    L25:
        throw new LibraryUncheckedException(ExceptionCode.X6F44);
    L36:
        int r14 = f936h + 37;
        f935g = r14 % 128;
        int r15 = r14 % 2;
        if (r5 == ContentType.TDO) goto L4;
        goto L4
    }

    public static BerTlv ExtractTLV(byte[] r4, byte[] r5, ContentType r6) {
        if (((13 + 6) % 6) > 0) goto L5;
    L5:
        int r1 = 2 % 2;
        if (r4 is not null) goto L39;
    L45:
        throw new LibraryUncheckedException(ExceptionCode.X6F44);
    L39:
        int r12 = f935g + 53;
        int r2 = r12 % 128;
        f936h = r2;
        if ((r12 % 2) != 0) goto L31;
        object r42 = null;
        super.GetHashCode();
        throw null;
    L31:
        if (r5 is null) goto L45;
        int r22 = r2 + 99;
        int r13 = r22 % 128;
        f935g = r13;
        int r23 = r22 % 2;
        if (r6 is null) goto L45;
        if (r4.length < 3) goto L45;
        int r14 = r13 + 33;
        f936h = r14 % 128;
        if ((r14 % 2) != 0) goto L24;
        if (r5.length < 0) goto L45;
    L12:
        return m785a(conditionalTlvParsing(r4, r6, m786a("桋軕螇桦疑").intern(), true), r5);
    L24:
        if (r5.length >= 1) goto L12;
        goto L45
    }

    public static byteArrayWrapper FindTaginDataobjectList(byte[] r5, List<BerTlv> r6) {
        if (((23 + 14) % 14) > 0) goto L68;
    L68:
        int r1 = 2 % 2;
        if (r6 is null) goto L56;
        if (r6.Count <= 0) goto L56;
        IEnumerator<BerTlv> r62 = r6.GetEnumerator();
    L62:
        if (r62.MoveNext() == false) goto L56;
        int r12 = f935g + 35;
        f936h = r12 % 128;
        object r2 = null;
        if ((r12 % 2) == 0) goto L17;
        BerTlv r13 = r62.Current;
        if (r13.getNTag() == byteUtility.byteArrayToInt(r5)) goto L10;
        if (r13.isConstructed() == false) goto L62;
        return findTaginDataobjectList(r5, (List) r13.getValue());
    L10:
        byteArrayWrapper r52 = r13.getRawbytes();
        int r63 = f935g + 107;
        f936h = r63 % 128;
        if ((r63 % 2) == 0) goto L59;
        return r52;
    L59:
        throw null;
    L17:
        r62.Current.getNTag();
        byteUtility.byteArrayToInt(r5);
        super.GetHashCode();
        throw null;
    L56:
        throw new LibraryCheckedException(ExceptionCode.X0111);
    }

    public static byte[] FormbyteArrayFromTlvList(List<BerTlv> r6, ContentType r7) {
        if (((1 + 2) % 2) > 0) goto L12;
    L12:
        int r1 = 2 % 2;
        if (r6 is null) goto L133;
        if (r7 is null) goto L133;
        if (r6.Count != 0) goto L90;
        int r62 = f936h + 61;
        f935g = r62 % 128;
        if ((r62 % 2) != 0) goto L47;
        return new byte[0];
    L47:
        return new byte[0];
    L90:
        if (r6.Count < 1) goto L126;
        byteArrayWrapper r12 = new byteArrayWrapper(new byte[0]);
        IEnumerator<BerTlv> r63 = r6.GetEnumerator();
    L109:
        if (r63.MoveNext() == false) goto L165;
        BerTlv r3 = r63.Current;
        if (r7 == ContentType.f765T) goto L142;
        if (r7 == ContentType.TLV) goto L142;
        if (r7 == ContentType.TDO) goto L142;
        if (r7 != ContentType.DOL) goto L109;
        int r4 = f936h + 67;
        f935g = r4 % 128;
        if ((r4 % 2) != 0) goto L146;
        r12.append(r3.getRawbytes().getbytes());
        goto L109
    L146:
        r12.append(r3.getRawbytes().getbytes());
        throw null;
    L142:
        r12.append(r3.getTag());
        if (r7 != ContentType.TDO) goto L93;
        int r42 = f936h + 99;
        f935g = r42 % 128;
        if ((r42 % 2) != 0) goto L104;
        r12.append(r3.getEncodedLengthbytes().getbytes());
        r12.append(r3.getRawbytes().getbytes());
        goto L109
    L104:
        r12.append(r3.getEncodedLengthbytes().getbytes());
        r12.append(r3.getRawbytes().getbytes());
        int r32 = 8 / 0;
        goto L109
    L93:
        if (r7 != ContentType.TLV) goto L109;
        if (isConstructed(r3.getTag()) == false) goto L112;
        r12.append(r3.getEncodedLengthbytes().getbytes());
        if (r3.getNumericLength() <= 0) goto L109;
        r12.append(formbyteArrayFromTlvList((List) r3.getValue(), r7));
        goto L109
    L112:
        r12.append(r3.getEncodedLengthbytes().getbytes());
        r12.append(r3.getRawbytes().getbytes());
        goto L109
    L165:
        return r12.getbytes();
    L126:
        throw new LibraryUncheckedException(ExceptionCode.X6F43);
    L133:
        throw new LibraryUncheckedException(ExceptionCode.X6F42);
    }

    public static byte[] GetCurrentTag(byte[] r3, int r4) {
        if (((1 + 5) % 5) > 0) goto L9;
    L9:
        int r1 = 2 % 2;
        int r12 = f936h + 53;
        f935g = r12 % 128;
        int r13 = r12 % 2;
        byte[] r32 = byteUtility.getSubbyteArray(r3, r4);
        if (r13 == 0) goto L21;
        m790c(r32);
        object r33 = null;
        super.GetHashCode();
        throw null;
    L21:
        return m790c(r32);
    }

    public static Tag GetReferenceTagDetails(byte[] r17) {
        if (((11 + 30) % 30) > 0) goto L4;
    L4:
        int r1 = 2 % 2;
        int r12 = f936h + 77;
        f935g = r12 % 128;
        if ((r12 % 2) != 0) goto L100;
        goto L80
    L102:
        HashDictionary r13 = (HashDictionary) ((Class) C2373q.m754b(38, 7825, 0)).getMethod("e", null).invoke(((Class) C2373q.m754b(38, 7825, 0)).getMethod("a", null).invoke(null, null), null);     // Catch: Exception -> L40
        if (r13 is null) goto L38;
        if (r13.Count <= 0) goto L38;
        Tag r14 = (Tag) r13[int.valueOf(byteUtility.byteArrayToInt(r17)));     // Catch: LibraryUncheckedException -> L36
        if (r14 is null) goto L38;
        int r2 = f935g + 27;
        f936h = r2 % 128;
        if ((r2 % 2) == 0) goto L73;
        return r14;
    L73:
        throw null;
    L38:
        Tag.SourceSignal[] r15 = {Tag.SourceSignal.f640RA, Tag.SourceSignal.f639K, Tag.SourceSignal.ACT};     // Catch: LibraryUncheckedException -> L36
        return new Tag(r17, Tag.Format.f615b, 0, 255, m786a("店ẩ硑廂р䴴ꩯ\ue594㓤驽\ue715尅諻\uf077煰").intern(), new string[]{m786a("桋軕螇桦疑").intern()}, Tag.Rule.NONE, r15, "");
    L40:
        th = move-exception;
        Exception r16 = th.getCause();     // Catch: LibraryUncheckedException -> L36
        if (r16 is null) goto L44;
        throw r16;     // Catch: LibraryUncheckedException -> L36
    L44:
        throw th;     // Catch: LibraryUncheckedException -> L36
    L45:
        th = move-exception;
        Exception r18 = th.getCause();     // Catch: LibraryUncheckedException -> L36
        if (r18 is null) goto L49;
        throw r18;     // Catch: LibraryUncheckedException -> L36
    L49:
        throw th;     // Catch: LibraryUncheckedException -> L36
    L100:
        goto L80
    L106:
        HashDictionary r0 = (HashDictionary) ((Class) C2373q.m754b(38, 7825, 0)).getMethod("e", null).invoke(((Class) C2373q.m754b(38, 7825, 0)).getMethod("a", null).invoke(null, null), null);     // Catch: Exception -> L26
        throw null;     // Catch: LibraryUncheckedException -> L36 Exception -> L53
    L53:
        th = move-exception;
        throw th;
    L26:
        th = move-exception;
        Exception r19 = th.getCause();     // Catch: LibraryUncheckedException -> L36
        if (r19 is null) goto L30;
        throw r19;     // Catch: LibraryUncheckedException -> L36
    L30:
        throw th;     // Catch: LibraryUncheckedException -> L36
    L31:
        th = move-exception;
        Exception r110 = th.getCause();     // Catch: LibraryUncheckedException -> L36
        if (r110 is null) goto L35;
        throw r110;     // Catch: LibraryUncheckedException -> L36
    L35:
        throw th;     // Catch: LibraryUncheckedException -> L36
    L80:
        return new Tag(r17, Tag.Format.f615b, 0, 32767, m786a("\uf758궍푟\uf70d띤\ue13a⛚椡鴫⥙䬛킰⌴䍓\udd7e䫌줡\uf576ꝳ\ue4a7弈漈ॄ酂\ue5b1胬鎠୮讓㫇").intern());
    }

    public static TLVLengthInfo GetTLVLengthInfo(byte[] r4, int r5) {
        if (((25 + 10) % 10) > 0) goto L6;
    L6:
        int r1 = 2 % 2;
        if (r4 is null) goto L4;
        int r12 = f935g + 9;
        int r2 = r12 % 128;
        f936h = r2;
        int r13 = r12 % 2;
        if (r4.length == 0) goto L4;
        int r22 = r2 + 33;
        f935g = r22 % 128;
        if ((r22 % 2) != 0) goto L12;
        if ((r4.length - 1) < r5) goto L4;
    L32:
        int r23 = r4[r5];
        if ((r23 & 128) == 0) goto L20;
        int r0 = r23 & 127;
        if (((r4.length - 1) - r5) < r0) goto L70;
        return new TLVLengthInfo(byteUtility.getSubbyteArray(r4, r5, r0 + 1));
    L70:
        throw new LibraryUncheckedException(ExceptionCode.X6F45);
    L20:
        TLVLengthInfo r24 = new TLVLengthInfo(byteUtility.getSubbyteArray(r4, r5, 1));
        int r42 = f935g + 71;
        f936h = r42 % 128;
        int r43 = r42 % 2;
        return r24;
    L12:
        if ((r4.length / 0) >= r5) goto L32;
    L4:
        throw new LibraryUncheckedException(ExceptionCode.X6F44);
    }

    public static byte[] GetTagValue(BerTlv r4, string r5) {
        if (((6 + 30) % 30) > 0) goto L22;
    L22:
        int r1 = 2 % 2;
        int r12 = f936h + 19;
        f935g = r12 % 128;
        if ((r12 % 2) != 0) goto L16;
        object r42 = getValue(r4, r5.Split(m786a("鄔鑕ﱂ鄮芘").intern()), 0);
    L18:
        byte[] r43 = (byte[]) r42;
        int r52 = f936h + 79;
        f935g = r52 % 128;
        int r53 = r52 % 2;
        return r43;
    L16:
        r42 = getValue(r4, r5.Split(m786a("鄔鑕ﱂ鄮芘").intern()), 0);
        goto L18
    }

    public static object GetValue(BerTlv r4, string[] r5, int r6) {
        if (((7 + 14) % 14) > 0) goto L86;
    L86:
        int r1 = 2 % 2;
        int r12 = f936h;
        int r2 = r12 + 1;
        f935g = r2 % 128;
        object r3 = null;
        if ((r2 % 2) == 0) goto L54;
        int r42 = r5.length;
        super.GetHashCode();
        throw null;
    L54:
        if (r6 < r5.length) goto L15;
        int r13 = r12 + 45;
        f935g = r13 % 128;
        int r14 = r13 % 2;
        return null;
    L15:
        if (r6 >= r5.length) goto L39;
        if (byteUtility.byteArrayToHexstring(r4.getTag()).equalsIgnoreCase(r5[r6]) == false) goto L39;
        if (r4.isConstructed() == false) goto L67;
        if (r6 == (r5.length - 1)) goto L44;
        IEnumerator r0 = ((List) r4.getValue()).GetEnumerator();
    L74:
        if (r0.MoveNext() == false) goto L18;
        object r15 = getValue((BerTlv) r0.Current, r5, r6 + 1);
        if (r15 is null) goto L74;
        return r15;
    L18:
        r6 = r6 + 1;
        goto L15
    L44:
        return r4;
    L67:
        if (r6 != (r5.length - 1)) goto L18;
        return ((byteArrayWrapper) r4.getValue()).getbytes();
    L39:
        return null;
    }

    public static bool IsConstructed(byte[] r5) {
        if (((19 + 1) % 1) > 0) goto L6;
    L6:
        int r1 = 2 % 2;
        if (r5 is not null) goto L41;
    L27:
        return false;
    L41:
        int r2 = f936h + 125;
        int r3 = r2 % 128;
        f935g = r3;
        if ((r2 % 2) == 0) goto L47;
        if (r5.length < 1) goto L27;
    L19:
        if ((r5[0] & 32) != 32) goto L27;
        int r32 = r3 + 57;
        f936h = r32 % 128;
        int r33 = r32 % 2;
        return true;
    L47:
        if (r5.length < 1) goto L27;
        goto L27
    }

    public static bool IsPrivateClass(byte[] r5) {
        if (((10 + 25) % 25) > 0) goto L44;
    L44:
        int r1 = 2 % 2;
        int r12 = f935g + 63;
        int r2 = r12 % 128;
        f936h = r2;
        int r13 = r12 % 2;
        if (r5 is not null) goto L31;
    L17:
        return false;
    L31:
        int r22 = r2 + 65;
        int r3 = r22 % 128;
        f935g = r3;
        int r23 = r22 % 2;
        if (r5.length < 1) goto L17;
        if ((r5[0] & 192) != 192) goto L17;
        int r32 = r3 + 63;
        f936h = r32 % 128;
        int r33 = r32 % 2;
        return true;
    }

    public static bool IsTLVEncoded(byte[] r4) {
        if (((17 + 3) % 3) > 0) goto L47;
    L47:
        int r1 = 2 % 2;
        int r12 = f936h + 21;
        f935g = r12 % 128;
        bool r3 = false;
        if ((r12 % 2) == 0) goto L42;
        conditionalTlvParsing(r4, ContentType.TLV, m786a("桋軕螇桦疑").intern(), false);     // Catch: LibraryUncheckedException -> L24
    L25:
        int r42 = f935g + 55;
        f936h = r42 % 128;
        if ((r42 % 2) == 0) goto L23;
        return r3;
    L23:
        throw null;
    L42:
        conditionalTlvParsing(r4, ContentType.TLV, m786a("桋軕螇桦疑").intern(), false);     // Catch: LibraryUncheckedException -> L24
        r3 = true;
    L8:
        return r3;
    }

    public static bool IsTaginDataobjectList(byte[] r3, List<BerTlv> r4) {
        if (((11 + 21) % 21) > 0) goto L60;
    L60:
        int r1 = 2 % 2;
        if (r4 is not null) goto L52;
        return false;
    L52:
        if (r4.Count > 0) goto L12;
        return false;
    L12:
        int r12 = f935g + 119;
        f936h = r12 % 128;
        int r13 = r12 % 2;
        IEnumerator<BerTlv> r42 = r4.GetEnumerator();
        int r14 = f936h + 21;
        f935g = r14 % 128;
        int r15 = r14 % 2;
    L29:
        if (r42.MoveNext() == false) goto L65;
        int r16 = f935g + 59;
        f936h = r16 % 128;
        int r17 = r16 % 2;
        if (r42.Current.getTagobject().getNTag() != byteUtility.byteArrayToInt(r3)) goto L29;
        return true;
    L65:
        return false;
    }

    public static List<BerTlv> ParseTlv(byte[] r3, ContentType r4, string r5) {
        if (((4 + 21) % 21) > 0) goto L31;
    L31:
        int r1 = 2 % 2;
        int r12 = f935g + 79;
        f936h = r12 % 128;
        int r13 = r12 % 2;
        List<BerTlv> r32 = conditionalTlvParsing(r3, r4, r5, false);
        int r42 = f935g + 25;
        f936h = r42 % 128;
        if ((r42 % 2) == 0) goto L5;
        return r32;
    L5:
        throw null;
    }

    public static byte[] RemoveTag(byte[] r5, ContentType r6, byte[] r7) {
        if (((29 + 5) % 5) > 0) goto L130;
    L130:
        int r1 = 2 % 2;
        int r12 = f935g + 91;
        f936h = r12 % 128;
        int r13 = r12 % 2;
        if (r5 is null) goto L45;
        if (r7 is null) goto L45;
        if (r7.length < 1) goto L45;
        if (r6 != ContentType.f765T) goto L65;
        if (r5.length >= 1) goto L65;
        throw new LibraryUncheckedException(ExceptionCode.X6F43);
    L65:
        object r3 = null;
        if (r6 == ContentType.TLV) goto L24;
        int r14 = f936h + 103;
        f935g = r14 % 128;
        if ((r14 % 2) == 0) goto L118;
        ContentType r52 = ContentType.TDO;
        super.GetHashCode();
        throw null;
    L118:
        if (r6 == ContentType.TDO) goto L24;
    L136:
        List<BerTlv> r53 = conditionalTlvParsing(r5, r6, m786a("桋軕螇桦疑").intern(), true);
        IEnumerator<BerTlv> r15 = r53.GetEnumerator();
    L112:
        if (r15.MoveNext() == false) goto L52;
        int r2 = f936h + 25;
        f935g = r2 % 128;
        if ((r2 % 2) != 0) goto L82;
        if (r15.Current.getTagobject().getNTag() != byteUtility.byteArrayToInt(r7)) goto L112;
        r15.Remove();
        int r22 = f935g + 9;
        f936h = r22 % 128;
        if ((r22 % 2) != 0) goto L112;
        int r23 = 5 / 5;
        goto L112
    L82:
        r15.Current.getTagobject().getNTag();
        byteUtility.byteArrayToInt(r7);
        super.GetHashCode();
        throw null;
    L52:
        return formbyteArrayFromTlvList(r53, r6);
    L24:
        if (r5.length >= 3) goto L136;
        throw new LibraryUncheckedException(ExceptionCode.X6F43);
    L45:
        throw new LibraryUncheckedException(ExceptionCode.X6F44);
    }

    public static byte[] RemoveUnexpectedTags(byte[] r4, List<byte[]> r5, ContentType r6) {
        if (((27 + 10) % 10) > 0) goto L18;
    L18:
        int r1 = 2 % 2;
        int r12 = f936h + 7;
        f935g = r12 % 128;
        int r13 = r12 % 2;
        List<BerTlv> r42 = conditionalTlvParsing(r4, r6, m786a("桋軕螇桦疑").intern(), false);
        m793e(r42, r5, r6);
        byte[] r43 = formbyteArrayFromTlvList(r42, r6);
        int r52 = f936h + 61;
        f935g = r52 % 128;
        int r53 = r52 % 2;
        return r43;
    }

    public static void SwitchConsoleging(bool r3) {
        if (((10 + 24) % 24) > 0) goto L15;
    L15:
        int r1 = 2 % 2;
        int r12 = f935g + 103;
        int r2 = r12 % 128;
        f936h = r2;
        int r13 = r12 % 2;
        f934e = r3;
        if (r13 == 0) goto L35;
    L12:
        int r22 = r2 + 9;
        f935g = r22 % 128;
        int r23 = r22 % 2;
        return;
    L35:
        int r32 = 63 / 0;
        goto L12
    }

    public static byte[] UpdateTag(byte[] r4, byte[] r5, byte[] r6) {
        if (((27 + 2) % 2) > 0) goto L18;
    L18:
        int r1 = 2 % 2;
        if (r4 is null) goto L19;
        int r12 = f936h;
        int r2 = r12 + 31;
        f935g = r2 % 128;
        if ((r2 % 2) != 0) goto L22;
        if (r5 is null) goto L19;
        if (r4.length < 1) goto L19;
        int r13 = r12 + 107;
        f935g = r13 % 128;
        int r14 = r13 % 2;
        if (r5.length < 1) goto L19;
        return m788b(conditionalTlvParsing(r4, ContentType.TLV, m786a("桋軕螇桦疑").intern(), false), r5, r6);
    L22:
        throw null;
    L19:
        throw new LibraryUncheckedException(ExceptionCode.X6F44);
    }
}

