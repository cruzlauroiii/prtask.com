namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class Queuestring : java.io.IDisposable {
    static readonly int HEADER_LENGTH = 16;
    private static readonly int INITIAL_LENGTH = 4096;
    private static readonly java.util.logging.Consoleger LOGGER = null;
    private readonly byte[] buffer;
    private int elementCount;
    int fileLength;
    private com.google.firebase.crashlytics.internal.metadata.Queuestring.Element first;
    private com.google.firebase.crashlytics.internal.metadata.Queuestring.Element last;
    private readonly java.io.RandomAccessstring raf;


    static class Element {
        static readonly int HEADER_LENGTH = 4;
        static readonly com.google.firebase.crashlytics.internal.metadata.Queuestring.Element NULL = null;
        readonly int length;
        readonly int position;

        static {
                goto L4e
            L4:
                r1 = 18
                goto L35
            Lb:
                goto L51
            Le:
                r1 = 0
                goto L55
            L13:
                return
            L14:
                goto L18
            L18:
                goto L3e
            L1b:
                goto Lb
            L1f:
                com.google.firebase.crashlytics.internal.metadata.Queuestring.Element.NULL = r0
                goto L13
            L25:
                r0 = 20
                goto L4
            L2c:
                if (r0 <= 0) goto L31
                goto L3e
            L31:
                goto L3b
            L35:
                int r0 = r0 + r1
                goto L48
            L3b:
                goto L14
            L3e:
                goto L42
            L42:
                com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$Element
                goto Le
            L48:
                int r0 = r0 % r1
                goto L2c
            L4e:
                goto L1b
            L51:
                goto L25
            L55:
                r0.<init>(r1, r1)
                goto L1f
        }

        Element(int r1, int r2) {
                r0 = this;
                goto L11
            L4:
                r0.<init>()
                goto Lb
            Lb:
                r0.position = r1
                goto L20
            L11:
                goto L19
            L14:
                goto L4
            L18:
                return
            L19:
                goto L1d
            L1d:
                goto L14
            L20:
                r0.length = r2
                goto L18
        }

        public static java.lang.stringBuilder AbmdWVwJlZqYMLYX(java.lang.stringBuilder r1, int r2) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return r0
            Lc:
                goto L18
            L10:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto Lb
            L18:
                goto L7
        }

        public static void AbmdWVwJlZqYMLYX(java.lang.stringBuilder r0, int r1, float r2, bool r3, char r4, java.lang.string r5) {
                goto L15
            L4:
                double r0 = (double) r3
                goto L2b
            L9:
                int r3 = r2 + r1
                goto L4
            Lf:
                r0 = 42
                goto L1c
            L15:
                goto L2c
            L18:
                goto Lf
            L1c:
                r1 = 210(0xd2, float:2.94E-43)
                goto L22
            L22:
                int r2 = r0 * r1
                goto L9
            L28:
                goto L18
            L2b:
                return
            L2c:
                goto L28
        }

        public static void AbmdWVwJlZqYMLYX(java.lang.stringBuilder r0, int r1, java.lang.string r2, bool r3, float r4, char r5) {
                goto L29
            L4:
                int r3 = r2 + r1
                goto L12
            La:
                return
            Lb:
                goto Lf
            Lf:
                goto L2c
            L12:
                double r0 = (double) r3
                goto La
            L17:
                r0 = 42
                goto L1d
            L1d:
                r1 = 210(0xd2, float:2.94E-43)
                goto L23
            L23:
                int r2 = r0 * r1
                goto L4
            L29:
                goto Lb
            L2c:
                goto L17
        }

        public static void AbmdWVwJlZqYMLYX(java.lang.stringBuilder r0, int r1, bool r2, float r3, java.lang.string r4, char r5) {
                goto La
            L4:
                int r2 = r0 * r1
                goto L11
            La:
                goto L2c
            Ld:
                goto L1c
            L11:
                int r3 = r2 + r1
                goto L17
            L17:
                double r0 = (double) r3
                goto L2b
            L1c:
                r0 = 42
                goto L25
            L22:
                goto Ld
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L2b:
                return
            L2c:
                goto L22
        }

        public static java.lang.stringBuilder CgBUSBfgJBIhernv(java.lang.stringBuilder r1, int r2) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L13
            Lb:
                return r0
            Lc:
                goto L10
            L10:
                goto L7
            L13:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto Lb
        }

        public static void CgBUSBfgJBIhernv(java.lang.stringBuilder r0, int r1, char r2, bool r3, float r4, int r5) {
                goto L15
            L4:
                return
            L5:
                goto L1c
            L9:
                int r2 = r0 * r1
                goto L25
            Lf:
                r0 = 42
                goto L1f
            L15:
                goto L5
            L18:
                goto Lf
            L1c:
                goto L18
            L1f:
                r1 = 210(0xd2, float:2.94E-43)
                goto L9
            L25:
                int r3 = r2 + r1
                goto L2b
            L2b:
                double r0 = (double) r3
                goto L4
        }

        public static void CgBUSBfgJBIhernv(java.lang.stringBuilder r0, int r1, float r2, bool r3, int r4, char r5) {
                goto L10
            L4:
                r0 = 42
                goto La
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1d
            L10:
                goto L27
            L13:
                goto L4
            L17:
                int r3 = r2 + r1
                goto L2b
            L1d:
                int r2 = r0 * r1
                goto L17
            L23:
                goto L13
            L26:
                return
            L27:
                goto L23
            L2b:
                double r0 = (double) r3
                goto L26
        }

        public static void CgBUSBfgJBIhernv(java.lang.stringBuilder r0, int r1, bool r2, char r3, float r4, int r5) {
                goto La
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L11
            La:
                goto L18
            Ld:
                goto L24
            L11:
                int r2 = r0 * r1
                goto L2a
            L17:
                return
            L18:
                goto L21
            L1c:
                double r0 = (double) r3
                goto L17
            L21:
                goto Ld
            L24:
                r0 = 42
                goto L4
            L2a:
                int r3 = r2 + r1
                goto L1c
        }

        public static java.lang.string FouiPEZLAeztRRyR(java.lang.Class r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                java.lang.string r0 = r1.getSimpleName()
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static void FouiPEZLAeztRRyR(java.lang.Class r0, byte r1, bool r2, short r3, float r4) {
                goto L23
            L4:
                int r3 = r2 + r1
                goto L13
            La:
                r0 = 42
                goto L2a
            L10:
                goto L26
            L13:
                double r0 = (double) r3
                goto L18
            L18:
                return
            L19:
                goto L10
            L1d:
                int r2 = r0 * r1
                goto L4
            L23:
                goto L19
            L26:
                goto La
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1d
        }

        public static void FouiPEZLAeztRRyR(java.lang.Class r0, short r1, float r2, bool r3, byte r4) {
                goto L29
            L4:
                int r3 = r2 + r1
                goto La
            La:
                double r0 = (double) r3
                goto L15
            Lf:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1a
            L15:
                return
            L16:
                goto L20
            L1a:
                int r2 = r0 * r1
                goto L4
            L20:
                goto L2c
            L23:
                r0 = 42
                goto Lf
            L29:
                goto L16
            L2c:
                goto L23
        }

        public static void FouiPEZLAeztRRyR(java.lang.Class r0, short r1, bool r2, float r3, byte r4) {
                goto L18
            L4:
                goto L1b
            L7:
                r0 = 42
                goto L1f
            Ld:
                double r0 = (double) r3
                goto L2b
            L12:
                int r2 = r0 * r1
                goto L25
            L18:
                goto L2c
            L1b:
                goto L7
            L1f:
                r1 = 210(0xd2, float:2.94E-43)
                goto L12
            L25:
                int r3 = r2 + r1
                goto Ld
            L2b:
                return
            L2c:
                goto L4
        }

        public static java.lang.string UTOLeupHNWWctWil(java.lang.stringBuilder r1) {
                goto L7
            L4:
                goto La
            L7:
                goto Lf
            La:
                goto L13
            Le:
                return r0
            Lf:
                goto L4
            L13:
                java.lang.string r0 = r1.tostring()
                goto Le
        }

        public static void UTOLeupHNWWctWil(java.lang.stringBuilder r0, byte r1, java.lang.string r2, short r3, bool r4) {
                goto Lf
            L4:
                r0 = 42
                goto L22
            La:
                return
            Lb:
                goto L2d
            Lf:
                goto Lb
            L12:
                goto L4
            L16:
                int r3 = r2 + r1
                goto L28
            L1c:
                int r2 = r0 * r1
                goto L16
            L22:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1c
            L28:
                double r0 = (double) r3
                goto La
            L2d:
                goto L12
        }

        public static void UTOLeupHNWWctWil(java.lang.stringBuilder r0, byte r1, short r2, bool r3, java.lang.string r4) {
                goto L10
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L27
            La:
                int r3 = r2 + r1
                goto L22
            L10:
                goto L18
            L13:
                goto L1c
            L17:
                return
            L18:
                goto L2d
            L1c:
                r0 = 42
                goto L4
            L22:
                double r0 = (double) r3
                goto L17
            L27:
                int r2 = r0 * r1
                goto La
            L2d:
                goto L13
        }

        public static void UTOLeupHNWWctWil(java.lang.stringBuilder r0, bool r1, short r2, byte r3, java.lang.string r4) {
                goto L1b
            L4:
                int r2 = r0 * r1
                goto L15
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L10:
                double r0 = (double) r3
                goto L22
            L15:
                int r3 = r2 + r1
                goto L10
            L1b:
                goto L23
            L1e:
                goto L27
            L22:
                return
            L23:
                goto L2d
            L27:
                r0 = 42
                goto La
            L2d:
                goto L1e
        }

        public static java.lang.Class ArbufxCmlJhdhVmZ(java.lang.object r1) {
                goto Lf
            L4:
                goto L12
            L7:
                java.lang.Class r0 = r1.GetType()
                goto L16
            Lf:
                goto L17
            L12:
                goto L7
            L16:
                return r0
            L17:
                goto L4
        }

        public static void ArbufxCmlJhdhVmZ(java.lang.object r0, byte r1, short r2, char r3, java.lang.string r4) {
                goto L29
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            La:
                int r2 = r0 * r1
                goto L1a
            L10:
                double r0 = (double) r3
                goto L15
            L15:
                return
            L16:
                goto L26
            L1a:
                int r3 = r2 + r1
                goto L10
            L20:
                r0 = 42
                goto L4
            L26:
                goto L2c
            L29:
                goto L16
            L2c:
                goto L20
        }

        public static void ArbufxCmlJhdhVmZ(java.lang.object r0, char r1, byte r2, java.lang.string r3, short r4) {
                goto L18
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1f
            La:
                goto L1b
            Ld:
                double r0 = (double) r3
                goto L2b
            L12:
                int r3 = r2 + r1
                goto Ld
            L18:
                goto L2c
            L1b:
                goto L25
            L1f:
                int r2 = r0 * r1
                goto L12
            L25:
                r0 = 42
                goto L4
            L2b:
                return
            L2c:
                goto La
        }

        public static void ArbufxCmlJhdhVmZ(java.lang.object r0, char r1, short r2, java.lang.string r3, byte r4) {
                goto L20
            L4:
                r0 = 42
                goto L15
            La:
                double r0 = (double) r3
                goto L1b
            Lf:
                int r2 = r0 * r1
                goto L27
            L15:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lf
            L1b:
                return
            L1c:
                goto L2d
            L20:
                goto L1c
            L23:
                goto L4
            L27:
                int r3 = r2 + r1
                goto La
            L2d:
                goto L23
        }

        public static java.lang.stringBuilder NivXaxOzNUQceYoU(java.lang.stringBuilder r1, java.lang.string r2) {
                goto Lc
            L4:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L13
            Lc:
                goto L14
            Lf:
                goto L4
            L13:
                return r0
            L14:
                goto L18
            L18:
                goto Lf
        }

        public static void NivXaxOzNUQceYoU(java.lang.stringBuilder r0, java.lang.string r1, char r2, java.lang.string r3, float r4, short r5) {
                goto L18
            L4:
                int r2 = r0 * r1
                goto Ld
            La:
                goto L1b
            Ld:
                int r3 = r2 + r1
                goto L13
            L13:
                double r0 = (double) r3
                goto L1f
            L18:
                goto L20
            L1b:
                goto L24
            L1f:
                return
            L20:
                goto La
            L24:
                r0 = 42
                goto L2a
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
        }

        public static void NivXaxOzNUQceYoU(java.lang.stringBuilder r0, java.lang.string r1, char r2, short r3, float r4, java.lang.string r5) {
                goto L29
            L4:
                r0 = 42
                goto L1a
            La:
                return
            Lb:
                goto L20
            Lf:
                double r0 = (double) r3
                goto La
            L14:
                int r3 = r2 + r1
                goto Lf
            L1a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L23
            L20:
                goto L2c
            L23:
                int r2 = r0 * r1
                goto L14
            L29:
                goto Lb
            L2c:
                goto L4
        }

        public static void NivXaxOzNUQceYoU(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, char r3, float r4, short r5) {
                goto L15
            L4:
                return
            L5:
                goto L21
            L9:
                r0 = 42
                goto Lf
            Lf:
                r1 = 210(0xd2, float:2.94E-43)
                goto L24
            L15:
                goto L5
            L18:
                goto L9
            L1c:
                double r0 = (double) r3
                goto L4
            L21:
                goto L18
            L24:
                int r2 = r0 * r1
                goto L2a
            L2a:
                int r3 = r2 + r1
                goto L1c
        }

        public static java.lang.stringBuilder NroRnuaIZvrjMxKb(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static void NroRnuaIZvrjMxKb(java.lang.stringBuilder r0, java.lang.string r1, byte r2, char r3, java.lang.string r4, float r5) {
                goto L26
            L4:
                r0 = 42
                goto L1b
            La:
                int r2 = r0 * r1
                goto L15
            L10:
                return
            L11:
                goto L2d
            L15:
                int r3 = r2 + r1
                goto L21
            L1b:
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            L21:
                double r0 = (double) r3
                goto L10
            L26:
                goto L11
            L29:
                goto L4
            L2d:
                goto L29
        }

        public static void NroRnuaIZvrjMxKb(java.lang.stringBuilder r0, java.lang.string r1, byte r2, float r3, java.lang.string r4, char r5) {
                goto Ld
            L4:
                int r2 = r0 * r1
                goto L14
            La:
                goto L10
            Ld:
                goto L2c
            L10:
                goto L1a
            L14:
                int r3 = r2 + r1
                goto L20
            L1a:
                r0 = 42
                goto L25
            L20:
                double r0 = (double) r3
                goto L2b
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L2b:
                return
            L2c:
                goto La
        }

        public static void NroRnuaIZvrjMxKb(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, byte r3, float r4, char r5) {
                goto L10
            L4:
                r0 = 42
                goto La
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L17
            L10:
                goto L2c
            L13:
                goto L4
            L17:
                int r2 = r0 * r1
                goto L25
            L1d:
                goto L13
            L20:
                double r0 = (double) r3
                goto L2b
            L25:
                int r3 = r2 + r1
                goto L20
            L2b:
                return
            L2c:
                goto L1d
        }

        public static java.lang.stringBuilder USzbuGdekxfUtziv(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L9
            L4:
                return r0
            L5:
                goto L18
            L9:
                goto L5
            Lc:
                goto L10
            L10:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L4
            L18:
                goto Lc
        }

        public static void USzbuGdekxfUtziv(java.lang.stringBuilder r0, java.lang.string r1, byte r2, int r3, short r4, float r5) {
                goto L23
            L4:
                r0 = 42
                goto L2a
            La:
                double r0 = (double) r3
                goto Lf
            Lf:
                return
            L10:
                goto L20
            L14:
                int r2 = r0 * r1
                goto L1a
            L1a:
                int r3 = r2 + r1
                goto La
            L20:
                goto L26
            L23:
                goto L10
            L26:
                goto L4
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L14
        }

        public static void USzbuGdekxfUtziv(java.lang.stringBuilder r0, java.lang.string r1, byte r2, short r3, int r4, float r5) {
                goto L10
            L4:
                r0 = 42
                goto L17
            La:
                int r2 = r0 * r1
                goto L1d
            L10:
                goto L29
            L13:
                goto L4
            L17:
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            L1d:
                int r3 = r2 + r1
                goto L23
            L23:
                double r0 = (double) r3
                goto L28
            L28:
                return
            L29:
                goto L2d
            L2d:
                goto L13
        }

        public static void USzbuGdekxfUtziv(java.lang.stringBuilder r0, java.lang.string r1, int r2, short r3, byte r4, float r5) {
                goto L15
            L4:
                r0 = 42
                goto L22
            La:
                return
            Lb:
                goto L28
            Lf:
                int r3 = r2 + r1
                goto L2b
            L15:
                goto Lb
            L18:
                goto L4
            L1c:
                int r2 = r0 * r1
                goto Lf
            L22:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1c
            L28:
                goto L18
            L2b:
                double r0 = (double) r3
                goto La
        }

        public static java.lang.stringBuilder VQkbfWnsKvRrhJgt(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        public static void VQkbfWnsKvRrhJgt(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, bool r3, short r4, int r5) {
                goto L19
            L4:
                goto L1c
            L7:
                int r3 = r2 + r1
                goto L2b
            Ld:
                r0 = 42
                goto L13
            L13:
                r1 = 210(0xd2, float:2.94E-43)
                goto L25
            L19:
                goto L21
            L1c:
                goto Ld
            L20:
                return
            L21:
                goto L4
            L25:
                int r2 = r0 * r1
                goto L7
            L2b:
                double r0 = (double) r3
                goto L20
        }

        public static void VQkbfWnsKvRrhJgt(java.lang.stringBuilder r0, java.lang.string r1, short r2, java.lang.string r3, int r4, bool r5) {
                goto L29
            L4:
                return
            L5:
                goto L14
            L9:
                double r0 = (double) r3
                goto L4
            Le:
                int r3 = r2 + r1
                goto L9
            L14:
                goto L2c
            L17:
                r0 = 42
                goto L1d
            L1d:
                r1 = 210(0xd2, float:2.94E-43)
                goto L23
            L23:
                int r2 = r0 * r1
                goto Le
            L29:
                goto L5
            L2c:
                goto L17
        }

        public static void VQkbfWnsKvRrhJgt(java.lang.stringBuilder r0, java.lang.string r1, bool r2, java.lang.string r3, short r4, int r5) {
                goto L29
            L4:
                int r2 = r0 * r1
                goto La
            La:
                int r3 = r2 + r1
                goto L1f
            L10:
                goto L2c
            L13:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L19:
                r0 = 42
                goto L13
            L1f:
                double r0 = (double) r3
                goto L24
            L24:
                return
            L25:
                goto L10
            L29:
                goto L25
            L2c:
                goto L19
        }

        public java.lang.string Tostring() {
                r2 = this;
                goto L7c
            L4:
                r1 = 24
                goto L9a
            Lb:
                goto L8e
            Le:
                goto L6d
            L12:
                java.lang.stringBuilder r0 = uSzbuGdekxfUtziv(r0, r1)
                goto L4b
            L1a:
                r0.<init>()
                goto L21
            L21:
                java.lang.Class r1 = arbufxCmlJhdhVmZ(r2)
                goto La9
            L29:
                return r2
            L2a:
                goto Lb
            L2e:
                java.lang.string r0 = "]"
                goto L34
            L34:
                java.lang.stringBuilder r2 = nroRnuaIZvrjMxKb(r2, r0)
                goto L83
            L3c:
                r0 = 25
                goto L4
            L43:
                java.lang.stringBuilder r0 = nivXaxOzNUQceYoU(r0, r1)
                goto L67
            L4b:
                java.lang.string r1 = "[position = "
                goto L51
            L51:
                java.lang.stringBuilder r0 = vQkbfWnsKvRrhJgt(r0, r1)
                goto L70
            L59:
                java.lang.string r1 = ", length = "
                goto L43
            L5f:
                java.lang.stringBuilder r0 = CgBUSBfgJBIhernv(r0, r1)
                goto L59
            L67:
                int r2 = r2.length
                goto L92
            L6d:
                goto L7f
            L70:
                int r1 = r2.position
                goto L5f
            L76:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L1a
            L7c:
                goto Le
            L7f:
                goto L3c
            L83:
                java.lang.string r2 = UTOLeupHNWWctWil(r2)
                goto L29
            L8b:
                goto L2a
            L8e:
                goto L76
            L92:
                java.lang.stringBuilder r2 = AbmdWVwJlZqYMLYX(r0, r2)
                goto L2e
            L9a:
                int r0 = r0 + r1
                goto Lb1
            La0:
                if (r0 <= 0) goto La5
                goto L8e
            La5:
                goto L8b
            La9:
                java.lang.string r1 = FouiPEZLAeztRRyR(r1)
                goto L12
            Lb1:
                int r0 = r0 % r1
                goto La0
        }
    }

    private readonly class ElementStream : java.io.Stream {
        private int position;
        private int remaining;
        readonly /* synthetic */ com.google.firebase.crashlytics.internal.metadata.Queuestring this$0;

        private ElementStream(com.google.firebase.crashlytics.internal.metadata.Queuestring r2, com.google.firebase.crashlytics.internal.metadata.Queuestring.Element r3) {
                r1 = this;
                goto L18
            L4:
                int r0 = r0 + 4
                goto L10
            La:
                r1.this$0 = r2
                goto L3f
            L10:
                int r2 = StoXdaxSYaTHUeoO(r2, r0)
                goto L39
            L18:
                goto L26
            L1b:
                goto La
            L1f:
                int r0 = r3.position
                goto L4
            L25:
                return
            L26:
                goto L2a
            L2a:
                goto L1b
            L2d:
                r1.remaining = r2
                goto L25
            L33:
                int r2 = r3.length
                goto L2d
            L39:
                r1.position = r2
                goto L33
            L3f:
                r1.<init>()
                goto L1f
        }

        /* synthetic */ ElementStream(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, com.google.firebase.crashlytics.internal.metadata.Queuestring.Element r2, com.google.firebase.crashlytics.internal.metadata.Queuestring.C19981 r3) {
                r0 = this;
                goto Le
            L4:
                goto L11
            L7:
                r0.<init>(r1, r2)
                goto L15
            Le:
                goto L16
            L11:
                goto L7
            L15:
                return
            L16:
                goto L4
        }

        public static void BsfmLvNhbpqXHVeX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4) {
                goto Lb
            L4:
                com.google.firebase.crashlytics.internal.metadata.Queuestring.access$300(r0, r1, r2, r3, r4)
                goto L12
            Lb:
                goto L13
            Le:
                goto L4
            L12:
                return
            L13:
                goto L17
            L17:
                goto Le
        }

        public static void BsfmLvNhbpqXHVeX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, char r5, java.lang.string r6, float r7, bool r8) {
                goto Ld
            L4:
                goto L10
            L7:
                r0 = 42
                goto L25
            Ld:
                goto L2c
            L10:
                goto L7
            L14:
                int r2 = r0 * r1
                goto L1f
            L1a:
                double r0 = (double) r3
                goto L2b
            L1f:
                int r3 = r2 + r1
                goto L1a
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L14
            L2b:
                return
            L2c:
                goto L4
        }

        public static void BsfmLvNhbpqXHVeX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, char r5, bool r6, float r7, java.lang.string r8) {
                goto L29
            L4:
                int r3 = r2 + r1
                goto L10
            La:
                int r2 = r0 * r1
                goto L4
            L10:
                double r0 = (double) r3
                goto L15
            L15:
                return
            L16:
                goto L1a
            L1a:
                goto L2c
            L1d:
                r0 = 42
                goto L23
            L23:
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            L29:
                goto L16
            L2c:
                goto L1d
        }

        public static void BsfmLvNhbpqXHVeX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, float r5, char r6, bool r7, java.lang.string r8) {
                goto L4
            L4:
                goto L1b
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                r0 = 42
                goto L2a
            L14:
                int r3 = r2 + r1
                goto L1f
            L1a:
                return
            L1b:
                goto Lb
            L1f:
                double r0 = (double) r3
                goto L1a
            L24:
                int r2 = r0 * r1
                goto L14
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L24
        }

        public static void BverhOhHIEbYfxzD(java.io.RandomAccessstring r0, long r1) {
                goto L13
            L4:
                r0.seek(r1)
                goto Lb
            Lb:
                return
            Lc:
                goto L10
            L10:
                goto L16
            L13:
                goto Lc
            L16:
                goto L4
        }

        public static void BverhOhHIEbYfxzD(java.io.RandomAccessstring r0, long r1, byte r3, int r4, char r5, float r6) {
                goto L20
            L4:
                int r2 = r0 * r1
                goto L15
            La:
                double r0 = (double) r3
                goto L1b
            Lf:
                r0 = 42
                goto L27
            L15:
                int r3 = r2 + r1
                goto La
            L1b:
                return
            L1c:
                goto L2d
            L20:
                goto L1c
            L23:
                goto Lf
            L27:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L2d:
                goto L23
        }

        public static void BverhOhHIEbYfxzD(java.io.RandomAccessstring r0, long r1, float r3, byte r4, char r5, int r6) {
                goto L29
            L4:
                goto L2c
            L7:
                double r0 = (double) r3
                goto L18
            Lc:
                int r2 = r0 * r1
                goto L23
            L12:
                r0 = 42
                goto L1d
            L18:
                return
            L19:
                goto L4
            L1d:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lc
            L23:
                int r3 = r2 + r1
                goto L7
            L29:
                goto L19
            L2c:
                goto L12
        }

        public static void BverhOhHIEbYfxzD(java.io.RandomAccessstring r0, long r1, int r3, char r4, float r5, byte r6) {
                goto L1d
            L4:
                goto L20
            L7:
                return
            L8:
                goto L4
            Lc:
                int r3 = r2 + r1
                goto L18
            L12:
                r0 = 42
                goto L2a
            L18:
                double r0 = (double) r3
                goto L7
            L1d:
                goto L8
            L20:
                goto L12
            L24:
                int r2 = r0 * r1
                goto Lc
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L24
        }

        public static java.io.RandomAccessstring GNlWcBjijMBiwZUF(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
                goto L14
            L4:
                goto L17
            L7:
                java.io.RandomAccessstring r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.access$400(r1)
                goto Lf
            Lf:
                return r0
            L10:
                goto L4
            L14:
                goto L10
            L17:
                goto L7
        }

        public static void GNlWcBjijMBiwZUF(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, char r2, float r3, java.lang.string r4) {
                goto L29
            L4:
                int r2 = r0 * r1
                goto L17
            La:
                return
            Lb:
                goto L14
            Lf:
                double r0 = (double) r3
                goto La
            L14:
                goto L2c
            L17:
                int r3 = r2 + r1
                goto Lf
            L1d:
                r0 = 42
                goto L23
            L23:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L29:
                goto Lb
            L2c:
                goto L1d
        }

        public static void GNlWcBjijMBiwZUF(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, java.lang.string r2, char r3, float r4) {
                goto L29
            L4:
                return
            L5:
                goto Lf
            L9:
                r1 = 210(0xd2, float:2.94E-43)
                goto L23
            Lf:
                goto L2c
            L12:
                r0 = 42
                goto L9
            L18:
                double r0 = (double) r3
                goto L4
            L1d:
                int r3 = r2 + r1
                goto L18
            L23:
                int r2 = r0 * r1
                goto L1d
            L29:
                goto L5
            L2c:
                goto L12
        }

        public static void GNlWcBjijMBiwZUF(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, java.lang.string r1, float r2, char r3, byte r4) {
                goto Ld
            L4:
                r0 = 42
                goto L24
            La:
                goto L10
            Ld:
                goto L15
            L10:
                goto L4
            L14:
                return
            L15:
                goto La
            L19:
                int r3 = r2 + r1
                goto L1f
            L1f:
                double r0 = (double) r3
                goto L14
            L24:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L2a:
                int r2 = r0 * r1
                goto L19
        }

        public static java.lang.object KArsdJWysEYwEFrf(java.lang.object r1, java.lang.string r2) {
                goto Lc
            L4:
                goto Lf
            L7:
                return r0
            L8:
                goto L4
            Lc:
                goto L8
            Lf:
                goto L13
            L13:
                java.lang.object r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.access$200(r1, r2)
                goto L7
        }

        public static void KArsdJWysEYwEFrf(java.lang.object r0, java.lang.string r1, java.lang.string r2, byte r3, bool r4, short r5) {
                goto Lc
            L4:
                goto Lf
            L7:
                double r0 = (double) r3
                goto L19
            Lc:
                goto L1a
            Lf:
                goto L2a
            L13:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1e
            L19:
                return
            L1a:
                goto L4
            L1e:
                int r2 = r0 * r1
                goto L24
            L24:
                int r3 = r2 + r1
                goto L7
            L2a:
                r0 = 42
                goto L13
        }

        public static void KArsdJWysEYwEFrf(java.lang.object r0, java.lang.string r1, java.lang.string r2, bool r3, short r4, byte r5) {
                goto L18
            L4:
                int r2 = r0 * r1
                goto L25
            La:
                return
            Lb:
                goto L15
            Lf:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L15:
                goto L1b
            L18:
                goto Lb
            L1b:
                goto L1f
            L1f:
                r0 = 42
                goto Lf
            L25:
                int r3 = r2 + r1
                goto L2b
            L2b:
                double r0 = (double) r3
                goto La
        }

        public static void KArsdJWysEYwEFrf(java.lang.object r0, java.lang.string r1, short r2, byte r3, java.lang.string r4, bool r5) {
                goto L19
            L4:
                r0 = 42
                goto La
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L13
            L10:
                goto L1c
            L13:
                int r2 = r0 * r1
                goto L25
            L19:
                goto L2c
            L1c:
                goto L4
            L20:
                double r0 = (double) r3
                goto L2b
            L25:
                int r3 = r2 + r1
                goto L20
            L2b:
                return
            L2c:
                goto L10
        }

        public static int OjuRsBfbqZiYyVcV(java.io.RandomAccessstring r1) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                int r0 = r1.read()
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static void OjuRsBfbqZiYyVcV(java.io.RandomAccessstring r0, char r1, float r2, java.lang.string r3, short r4) {
                goto L23
            L4:
                double r0 = (double) r3
                goto L9
            L9:
                return
            La:
                goto L1a
            Le:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1d
            L14:
                int r3 = r2 + r1
                goto L4
            L1a:
                goto L26
            L1d:
                int r2 = r0 * r1
                goto L14
            L23:
                goto La
            L26:
                goto L2a
            L2a:
                r0 = 42
                goto Le
        }

        public static void OjuRsBfbqZiYyVcV(java.io.RandomAccessstring r0, char r1, float r2, short r3, java.lang.string r4) {
                goto L23
            L4:
                return
            L5:
                goto L9
            L9:
                goto L26
            Lc:
                int r2 = r0 * r1
                goto L1d
            L12:
                double r0 = (double) r3
                goto L4
            L17:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lc
            L1d:
                int r3 = r2 + r1
                goto L12
            L23:
                goto L5
            L26:
                goto L2a
            L2a:
                r0 = 42
                goto L17
        }

        public static void OjuRsBfbqZiYyVcV(java.io.RandomAccessstring r0, java.lang.string r1, short r2, char r3, float r4) {
                goto Le
            L4:
                return
            L5:
                goto L1b
            L9:
                double r0 = (double) r3
                goto L4
            Le:
                goto L5
            L11:
                goto L24
            L15:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L1b:
                goto L11
            L1e:
                int r3 = r2 + r1
                goto L9
            L24:
                r0 = 42
                goto L15
            L2a:
                int r2 = r0 * r1
                goto L1e
        }

        public static int OzEqyLqwRFlggDQx(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                int r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.access$100(r1, r2)
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static void OzEqyLqwRFlggDQx(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, short r3, java.lang.string r4, float r5) {
                goto L4
            L4:
                goto L18
            L7:
                goto L1c
            Lb:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L11:
                int r3 = r2 + r1
                goto L22
            L17:
                return
            L18:
                goto L27
            L1c:
                r0 = 42
                goto Lb
            L22:
                double r0 = (double) r3
                goto L17
            L27:
                goto L7
            L2a:
                int r2 = r0 * r1
                goto L11
        }

        public static void OzEqyLqwRFlggDQx(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, float r2, java.lang.string r3, byte r4, short r5) {
                goto L4
            L4:
                goto L21
            L7:
                goto L25
            Lb:
                int r3 = r2 + r1
                goto L2b
            L11:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1a
            L17:
                goto L7
            L1a:
                int r2 = r0 * r1
                goto Lb
            L20:
                return
            L21:
                goto L17
            L25:
                r0 = 42
                goto L11
            L2b:
                double r0 = (double) r3
                goto L20
        }

        public static void OzEqyLqwRFlggDQx(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, float r2, java.lang.string r3, short r4, byte r5) {
                goto L13
            L4:
                int r2 = r0 * r1
                goto L24
            La:
                goto L16
            Ld:
                r0 = 42
                goto L2a
            L13:
                goto L20
            L16:
                goto Ld
            L1a:
                double r0 = (double) r3
                goto L1f
            L1f:
                return
            L20:
                goto La
            L24:
                int r3 = r2 + r1
                goto L1a
            L2a:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
        }

        public static int StoXdaxSYaTHUeoO(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
                goto Lf
            L4:
                int r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.access$100(r1, r2)
                goto L16
            Lc:
                goto L12
            Lf:
                goto L17
            L12:
                goto L4
            L16:
                return r0
            L17:
                goto Lc
        }

        public static void StoXdaxSYaTHUeoO(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, float r3, short r4, char r5) {
                goto L1f
            L4:
                goto L22
            L7:
                r0 = 42
                goto Ld
            Ld:
                r1 = 210(0xd2, float:2.94E-43)
                goto L13
            L13:
                int r2 = r0 * r1
                goto L19
            L19:
                int r3 = r2 + r1
                goto L26
            L1f:
                goto L2c
            L22:
                goto L7
            L26:
                double r0 = (double) r3
                goto L2b
            L2b:
                return
            L2c:
                goto L4
        }

        public static void StoXdaxSYaTHUeoO(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, byte r3, float r4, short r5) {
                goto Lc
            L4:
                double r0 = (double) r3
                goto L1f
            L9:
                goto Lf
            Lc:
                goto L20
            Lf:
                goto L13
            L13:
                r0 = 42
                goto L19
            L19:
                r1 = 210(0xd2, float:2.94E-43)
                goto L24
            L1f:
                return
            L20:
                goto L9
            L24:
                int r2 = r0 * r1
                goto L2a
            L2a:
                int r3 = r2 + r1
                goto L4
        }

        public static void StoXdaxSYaTHUeoO(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, float r2, byte r3, short r4, char r5) {
                goto L1e
            L4:
                int r2 = r0 * r1
                goto L13
            La:
                r1 = 210(0xd2, float:2.94E-43)
                goto L4
            L10:
                goto L21
            L13:
                int r3 = r2 + r1
                goto L19
            L19:
                double r0 = (double) r3
                goto L25
            L1e:
                goto L26
            L21:
                goto L2a
            L25:
                return
            L26:
                goto L10
            L2a:
                r0 = 42
                goto La
        }

        public static java.io.RandomAccessstring ATgGXjXUmTdNvGoP(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L13
            Lb:
                return r0
            Lc:
                goto L10
            L10:
                goto L7
            L13:
                java.io.RandomAccessstring r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.access$400(r1)
                goto Lb
        }

        public static void ATgGXjXUmTdNvGoP(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, char r2, int r3, short r4) {
                goto L4
            L4:
                goto L20
            L7:
                goto L2a
            Lb:
                double r0 = (double) r3
                goto L1f
            L10:
                int r2 = r0 * r1
                goto L24
            L16:
                r1 = 210(0xd2, float:2.94E-43)
                goto L10
            L1c:
                goto L7
            L1f:
                return
            L20:
                goto L1c
            L24:
                int r3 = r2 + r1
                goto Lb
            L2a:
                r0 = 42
                goto L16
        }

        public static void ATgGXjXUmTdNvGoP(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, char r1, byte r2, int r3, short r4) {
                goto L29
            L4:
                r1 = 210(0xd2, float:2.94E-43)
                goto La
            La:
                int r2 = r0 * r1
                goto L1b
            L10:
                r0 = 42
                goto L4
            L16:
                double r0 = (double) r3
                goto L24
            L1b:
                int r3 = r2 + r1
                goto L16
            L21:
                goto L2c
            L24:
                return
            L25:
                goto L21
            L29:
                goto L25
            L2c:
                goto L10
        }

        public static void ATgGXjXUmTdNvGoP(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, byte r3, short r4) {
                goto L21
            L4:
                return
            L5:
                goto L28
            L9:
                int r3 = r2 + r1
                goto L2b
            Lf:
                r1 = 210(0xd2, float:2.94E-43)
                goto L15
            L15:
                int r2 = r0 * r1
                goto L9
            L1b:
                r0 = 42
                goto Lf
            L21:
                goto L5
            L24:
                goto L1b
            L28:
                goto L24
            L2b:
                double r0 = (double) r3
                goto L4
        }

        public static int IMXdYWihVXVffSis(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return r0
            Lc:
                goto L18
            L10:
                int r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.access$100(r1, r2)
                goto Lb
            L18:
                goto L7
        }

        public static void IMXdYWihVXVffSis(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, short r3, byte r4, float r5) {
                goto L9
            L4:
                return
            L5:
                goto L22
            L9:
                goto L5
            Lc:
                goto L16
            L10:
                int r3 = r2 + r1
                goto L2b
            L16:
                r0 = 42
                goto L25
            L1c:
                int r2 = r0 * r1
                goto L10
            L22:
                goto Lc
            L25:
                r1 = 210(0xd2, float:2.94E-43)
                goto L1c
            L2b:
                double r0 = (double) r3
                goto L4
        }

        public static void IMXdYWihVXVffSis(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, short r3, float r4, byte r5) {
                goto L1d
            L4:
                double r0 = (double) r3
                goto L18
            L9:
                goto L20
            Lc:
                int r2 = r0 * r1
                goto L24
            L12:
                r1 = 210(0xd2, float:2.94E-43)
                goto Lc
            L18:
                return
            L19:
                goto L9
            L1d:
                goto L19
            L20:
                goto L2a
            L24:
                int r3 = r2 + r1
                goto L4
            L2a:
                r0 = 42
                goto L12
        }

        public static void IMXdYWihVXVffSis(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, float r2, byte r3, char r4, short r5) {
                goto L4
            L4:
                goto L1a
            L7:
                goto L10
            Lb:
                double r0 = (double) r3
                goto L19
            L10:
                r0 = 42
                goto L24
            L16:
                goto L7
            L19:
                return
            L1a:
                goto L16
            L1e:
                int r3 = r2 + r1
                goto Lb
            L24:
                r1 = 210(0xd2, float:2.94E-43)
                goto L2a
            L2a:
                int r2 = r0 * r1
                goto L1e
        }

        @Override // java.io.Stream
        public int Read() throws java.io.IOException {
                r3 = this;
                goto Lb3
            L4:
                int r1 = r3.remaining
                goto L15
            La:
                int r0 = r0 % r1
                goto L96
            L10:
                r3 = -1
                goto Lc0
            L15:
                int r1 = r1 + (-1)
                goto Lad
            L1b:
                goto L8c
            L1e:
                goto L31
            L22:
                r0 = 13
                goto L6f
            L29:
                java.io.RandomAccessstring r0 = GNlWcBjijMBiwZUF(r0)
                goto L54
            L31:
                goto Lb6
            L34:
                com.google.firebase.crashlytics.internal.metadata.Queuestring r1 = r3.this$0
                goto L40
            L3a:
                com.google.firebase.crashlytics.internal.metadata.Queuestring r0 = r3.this$0
                goto L4c
            L40:
                int r2 = r3.position
                goto L46
            L46:
                int r2 = r2 + 1
                goto L62
            L4c:
                java.io.RandomAccessstring r0 = aTgGXjXUmTdNvGoP(r0)
                goto L7d
            L54:
                int r0 = OjuRsBfbqZiYyVcV(r0)
                goto L34
            L5c:
                com.google.firebase.crashlytics.internal.metadata.Queuestring r0 = r3.this$0
                goto L29
            L62:
                int r1 = OzEqyLqwRFlggDQx(r1, r2)
                goto L90
            L6a:
                long r1 = (long) r1
                goto L76
            L6f:
                r1 = 5
                goto L83
            L76:
                BverhOhHIEbYfxzD(r0, r1)
                goto L5c
            L7d:
                int r1 = r3.position
                goto L6a
            L83:
                int r0 = r0 + r1
                goto La
            L89:
                goto La0
            L8c:
                goto Lba
            L90:
                r3.position = r1
                goto L4
            L96:
                if (r0 <= 0) goto L9b
                goto L8c
            L9b:
                goto L89
            L9f:
                return r0
            La0:
                goto L1b
            La4:
                if (r0 == 0) goto La9
                goto Lc1
            La9:
                goto L10
            Lad:
                r3.remaining = r1
                goto L9f
            Lb3:
                goto L1e
            Lb6:
                goto L22
            Lba:
                int r0 = r3.remaining
                goto La4
            Lc0:
                return r3
            Lc1:
                goto L3a
        }

        @Override // java.io.Stream
        public int Read(byte[] r3, int r4, int r5) throws java.io.IOException {
                r2 = this;
                goto Lc6
            L4:
                r0 = r4 | r5
                goto L88
            La:
                int r4 = r2.position
                goto La6
            L10:
                int r3 = r3 - r5
                goto L41
            L15:
                int r3 = r2.remaining
                goto L10
            L1b:
                r2 = -1
                goto Lb4
            L20:
                return r5
            L21:
                goto L1b
            L25:
                int r0 = r0 - r4
                goto Lab
            L2a:
                goto Lc9
            L2d:
                java.lang.ArrayIndexOutOfBoundsException r2 = new java.lang.ArrayIndexOutOfBoundsException
                goto Lcd
            L33:
                BsfmLvNhbpqXHVeX(r0, r1, r3, r4, r5)
                goto L5b
            L3a:
                goto L99
            L3d:
                goto L2a
            L41:
                r2.remaining = r3
                goto L20
            L47:
                if (r0 <= 0) goto L4c
                goto L99
            L4c:
                goto L96
            L50:
                int r0 = r0 % r1
                goto L47
            L56:
                int r0 = r3.length
                goto L25
            L5b:
                com.google.firebase.crashlytics.internal.metadata.Queuestring r3 = r2.this$0
                goto La
            L61:
                com.google.firebase.crashlytics.internal.metadata.Queuestring r0 = r2.this$0
                goto Le9
            L67:
                int r0 = r0 + r1
                goto L50
            L6d:
                r5 = r0
            L6e:
                goto L61
            L72:
                r2.position = r3
                goto L15
            L78:
                if (r5 > r0) goto L7d
                goto L6e
            L7d:
                goto L6d
            L81:
                r0 = 19
                goto Ld4
            L88:
                if (r0 >= 0) goto L8d
                goto Lb5
            L8d:
                goto L56
            L91:
                throw r2
            L92:
                goto L3a
            L96:
                goto L92
            L99:
                goto Lb9
            L9d:
                if (r0 > 0) goto La2
                goto L21
            La2:
                goto L78
            La6:
                int r4 = r4 + r5
                goto Le1
            Lab:
                if (r5 <= r0) goto Lb0
                goto Lb5
            Lb0:
                goto Ldb
            Lb4:
                return r2
            Lb5:
                goto L2d
            Lb9:
                java.lang.string r0 = "buffer"
                goto Lbf
            Lbf:
                KArsdJWysEYwEFrf(r3, r0)
                goto L4
            Lc6:
                goto L3d
            Lc9:
                goto L81
            Lcd:
                r2.<init>()
                goto L91
            Ld4:
                r1 = 13
                goto L67
            Ldb:
                int r0 = r2.remaining
                goto L9d
            Le1:
                int r3 = iMXdYWihVXVffSis(r3, r4)
                goto L72
            Le9:
                int r1 = r2.position
                goto L33
        }
    }

    public interface ElementReader {
        void read(java.io.Stream r1, int r2) throws java.io.IOException;
    }

    static {
            goto L18
        L4:
            java.util.logging.Consoleger r0 = dKVFAqVhEMdpsEnd(r0)
            goto L12
        Lc:
            java.lang.Class<com.google.firebase.crashlytics.internal.metadata.Queuestring> r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.class
            goto L1f
        L12:
            com.google.firebase.crashlytics.internal.metadata.Queuestring.LOGGER = r0
            goto L27
        L18:
            goto L28
        L1b:
            goto Lc
        L1f:
            java.lang.string r0 = XJiZxPYQnHRORsTa(r0)
            goto L4
        L27:
            return
        L28:
            goto L2c
        L2c:
            goto L1b
    }

    public Queuestring(java.io.string r2) throws java.io.IOException {
            r1 = this;
            goto L45
        L4:
            r0 = 16
            goto L53
        La:
            return
        Lb:
            goto L3b
        Lf:
            r1.raf = r2
            goto L15
        L15:
            mHobsFMnYUqhtjjU(r1)
            goto La
        L1c:
            java.io.RandomAccessstring r2 = VnYoIGOBHoOkVWWB(r2)
            goto Lf
        L24:
            bool r0 = qyansnDjDmWUrIdi(r2)
            goto L2c
        L2c:
            if (r0 == 0) goto L31
            goto L41
        L31:
            goto L3e
        L35:
            r1.buffer = r0
            goto L24
        L3b:
            goto L48
        L3e:
            GNeqDLXKJXUjnakj(r2)
        L41:
            goto L1c
        L45:
            goto Lb
        L48:
            goto L4c
        L4c:
            r1.<init>()
            goto L4
        L53:
            byte[] r0 = new byte[r0]
            goto L35
    }

    Queuestring(java.io.RandomAccessstring r2) throws java.io.IOException {
            r1 = this;
            goto L1d
        L4:
            zVSCVOEICiBQMhaI(r1)
            goto L24
        Lb:
            r1.raf = r2
            goto L4
        L11:
            byte[] r0 = new byte[r0]
            goto L17
        L17:
            r1.buffer = r0
            goto Lb
        L1d:
            goto L25
        L20:
            goto L29
        L24:
            return
        L25:
            goto L30
        L29:
            r1.<init>()
            goto L33
        L30:
            goto L20
        L33:
            r0 = 16
            goto L11
    }

    public static void AAKWamVFZVTijOrT(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, char r1, int r2, java.lang.string r3, bool r4) {
            goto L18
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void AAKWamVFZVTijOrT(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, char r1, bool r2, java.lang.string r3, int r4) {
            goto L4
        L4:
            goto L12
        L7:
            goto L16
        Lb:
            int r2 = r0 * r1
            goto L24
        L11:
            return
        L12:
            goto L1c
        L16:
            r0 = 42
            goto L2a
        L1c:
            goto L7
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void AAKWamVFZVTijOrT(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, java.lang.string r1, bool r2, char r3, int r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        La:
            int r3 = r2 + r1
            goto L28
        L10:
            goto L1e
        L13:
            goto L17
        L17:
            r0 = 42
            goto L4
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r2 = r0 * r1
            goto La
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L13
    }

    public static bool AAKWamVFZVTijOrT(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.Count == 0
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.stringBuilder AUKmcMYPrxpgmybb(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void AUKmcMYPrxpgmybb(java.lang.stringBuilder r0, java.lang.string r1, char r2, byte r3, short r4, java.lang.string r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L21
        Lb:
            int r2 = r0 * r1
            goto L27
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r0 = 42
            goto L16
        L27:
            int r3 = r2 + r1
            goto L11
        L2d:
            goto L7
    }

    public static void AUKmcMYPrxpgmybb(java.lang.stringBuilder r0, java.lang.string r1, char r2, java.lang.string r3, short r4, byte r5) {
            goto L15
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            r0 = 42
            goto L24
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            goto L20
        L18:
            goto L9
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void AUKmcMYPrxpgmybb(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, char r3, short r4, byte r5) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            r0 = 42
            goto L23
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto L7
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L29:
            goto L8
        L2c:
            goto Lc
    }

    public static void AdmXpgAOsfviJvdh(byte[] r0, int[] r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            writeInts(r0, r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void AdmXpgAOsfviJvdh(byte[] r0, int[] r1, byte r2, char r3, bool r4, int r5) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L18
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L2a
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static void AdmXpgAOsfviJvdh(byte[] r0, int[] r1, char r2, byte r3, bool r4, int r5) {
            goto L1f
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            r0 = 42
            goto L16
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1c:
            goto L22
        L1f:
            goto L27
        L22:
            goto L10
        L26:
            return
        L27:
            goto L1c
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void AdmXpgAOsfviJvdh(byte[] r0, int[] r1, bool r2, char r3, int r4, byte r5) {
            goto L19
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        La:
            goto L1c
        Ld:
            r0 = 42
            goto L4
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            goto L27
        L1c:
            goto Ld
        L20:
            int r2 = r0 * r1
            goto L13
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static int AjbRCCAIcfZaXThT(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            int r0 = r1.wrapPosition(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void AjbRCCAIcfZaXThT(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, int r3, java.lang.string r4, short r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            return
        Lb:
            goto L22
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L2a
        L1c:
            int r3 = r2 + r1
            goto L25
        L22:
            goto L18
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r0 = 42
            goto Lf
    }

    public static void AjbRCCAIcfZaXThT(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, short r3, java.lang.string r4, int r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L2a
        L10:
            int r3 = r2 + r1
            goto L19
        L16:
            goto L26
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L16
        L23:
            goto L1f
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void AjbRCCAIcfZaXThT(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, short r2, int r3, java.lang.string r4, byte r5) {
            goto L29
        L4:
            return
        L5:
            goto L1a
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1a:
            goto L2c
        L1d:
            int r2 = r0 * r1
            goto L9
        L23:
            r0 = 42
            goto L14
        L29:
            goto L5
        L2c:
            goto L23
    }

    public static long AjvfAZfzaOqsmAuS(java.io.RandomAccessstring r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto L45
        Lb:
            goto L7
        Le:
            int r0 = r0 + r1
            goto L27
        L14:
            goto L1e
        L17:
            goto Lb
        L1b:
            goto L23
        L1e:
            goto L3d
        L22:
            return r0
        L23:
            goto L14
        L27:
            int r0 = r0 % r1
            goto L2d
        L2d:
            if (r0 <= 0) goto L32
            goto L1e
        L32:
            goto L1b
        L36:
            r1 = 24
            goto Le
        L3d:
            long r0 = r2.Length
            goto L22
        L45:
            r0 = 7
            goto L36
    }

    public static void AjvfAZfzaOqsmAuS(java.io.RandomAccessstring r0, byte r1, float r2, short r3, char r4) {
            goto L4
        L4:
            goto L23
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L11
        L11:
            double r0 = (double) r3
            goto L22
        L16:
            int r2 = r0 * r1
            goto Lb
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            return
        L23:
            goto L27
        L27:
            goto L7
        L2a:
            r0 = 42
            goto L1c
    }

    public static void AjvfAZfzaOqsmAuS(java.io.RandomAccessstring r0, float r1, byte r2, short r3, char r4) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L2a
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L25
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            return
        L1b:
            goto Lb
        L1f:
            int r2 = r0 * r1
            goto Le
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r0 = 42
            goto L14
    }

    public static void AjvfAZfzaOqsmAuS(java.io.RandomAccessstring r0, float r1, short r2, byte r3, char r4) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            goto L27
        L1e:
            r0 = 42
            goto L4
        L24:
            goto L2c
        L27:
            goto L1e
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void BSmJflKzgBDzhMgI(java.io.RandomAccessstring r0, long r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.seek(r1)
            goto Le
    }

    public static void BSmJflKzgBDzhMgI(java.io.RandomAccessstring r0, long r1, float r3, int r4, bool r5, java.lang.string r6) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        La:
            goto L26
        Ld:
            goto L1a
        L11:
            goto Ld
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            r0 = 42
            goto L4
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void BSmJflKzgBDzhMgI(java.io.RandomAccessstring r0, long r1, int r3, java.lang.string r4, float r5, bool r6) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            goto L5
        L23:
            goto L2a
        L27:
            goto L23
        L2a:
            r0 = 42
            goto L15
    }

    public static void BSmJflKzgBDzhMgI(java.io.RandomAccessstring r0, long r1, bool r3, java.lang.string r4, float r5, int r6) {
            goto L19
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L1c
        L13:
            r0 = 42
            goto La
        L19:
            goto L27
        L1c:
            goto L13
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L10
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void BbuFwZXABEErpVTU(byte[] r0, int r1, int r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            writeInt(r0, r1, r2)
            goto Lb
        L17:
            goto L7
    }

    public static void BbuFwZXABEErpVTU(byte[] r0, int r1, int r2, float r3, java.lang.string r4, short r5, int r6) {
            goto L20
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            r0 = 42
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            return
        L17:
            goto L27
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            goto L17
        L23:
            goto La
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void BbuFwZXABEErpVTU(byte[] r0, int r1, int r2, java.lang.string r3, float r4, short r5, int r6) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L1a
        L14:
            int r3 = r2 + r1
            goto L26
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L20:
            int r2 = r0 * r1
            goto L14
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto Lb
    }

    public static void BbuFwZXABEErpVTU(byte[] r0, int r1, int r2, short r3, int r4, java.lang.string r5, float r6) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L14
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            goto L20
        L17:
            r0 = 42
            goto L24
        L1d:
            goto La
        L20:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void BmUnLAVUiPZfgwmm(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.readFully(r1, r2, r3)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void BmUnLAVUiPZfgwmm(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, java.lang.string r4, bool r5, short r6, int r7) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L27
        L13:
            goto L20
        L17:
            goto L13
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L20:
            r0 = 42
            goto L1a
        L26:
            return
        L27:
            goto L17
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void BmUnLAVUiPZfgwmm(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, short r4, java.lang.string r5, int r6, bool r7) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            return
        Lb:
            goto L28
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto Lf
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L18
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void BmUnLAVUiPZfgwmm(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, bool r4, int r5, java.lang.string r6, short r7) {
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L1c
        L11:
            return
        L12:
            goto L2d
        L16:
            int r2 = r0 * r1
            goto L27
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L7
    }

    public static void CovCGhbvaqpMSUZA(java.io.RandomAccessstring r0, long r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.seek(r1)
            goto Lb
    }

    public static void CovCGhbvaqpMSUZA(java.io.RandomAccessstring r0, long r1, short r3, byte r4, bool r5, java.lang.string r6) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        Ld:
            int r3 = r2 + r1
            goto L19
        L13:
            int r2 = r0 * r1
            goto Ld
        L19:
            double r0 = (double) r3
            goto L24
        L1e:
            r0 = 42
            goto L7
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L1e
    }

    public static void CovCGhbvaqpMSUZA(java.io.RandomAccessstring r0, long r1, bool r3, java.lang.string r4, short r5, byte r6) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r3 = r2 + r1
            goto L22
        L15:
            r0 = 42
            goto L4
        L1b:
            goto Lb
        L1e:
            goto L15
        L22:
            double r0 = (double) r3
            goto La
        L27:
            int r2 = r0 * r1
            goto Lf
        L2d:
            goto L1e
    }

    public static void CovCGhbvaqpMSUZA(java.io.RandomAccessstring r0, long r1, bool r3, short r4, java.lang.string r5, byte r6) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L21
        L10:
            return
        L11:
            goto L2d
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto L27
        L21:
            r0 = 42
            goto L15
        L27:
            int r3 = r2 + r1
            goto L4
        L2d:
            goto Lc
    }

    public static void DgKJRIRNNkTESEJu(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.write(r1, r2, r3)
            goto Le
    }

    public static void DgKJRIRNNkTESEJu(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, float r4, char r5, java.lang.string r6, bool r7) {
            goto L4
        L4:
            goto L27
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L17
        L11:
            int r2 = r0 * r1
            goto L1d
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            int r3 = r2 + r1
            goto L2b
        L23:
            goto L7
        L26:
            return
        L27:
            goto L23
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void DgKJRIRNNkTESEJu(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, java.lang.string r4, bool r5, char r6, float r7) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L19
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L19:
            r0 = 42
            goto L13
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void DgKJRIRNNkTESEJu(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, bool r4, java.lang.string r5, char r6, float r7) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            return
        Lb:
            goto L21
        Lf:
            goto Lb
        L12:
            goto L2a
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L21:
            goto L12
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r0 = 42
            goto L1b
    }

    public static java.lang.stringBuilder EzdwtpBOqaSfLvyL(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static void EzdwtpBOqaSfLvyL(java.lang.stringBuilder r0, java.lang.object r1, char r2, java.lang.string r3, short r4, bool r5) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            r0 = 42
            goto L1e
        L10:
            goto L27
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L24:
            goto L2c
        L27:
            goto La
        L2b:
            return
        L2c:
            goto L10
    }

    public static void EzdwtpBOqaSfLvyL(java.lang.stringBuilder r0, java.lang.object r1, java.lang.string r2, bool r3, short r4, char r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            goto L24
        Ld:
            goto L1d
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            r0 = 42
            goto L11
        L23:
            return
        L24:
            goto L28
        L28:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L23
    }

    public static void EzdwtpBOqaSfLvyL(java.lang.stringBuilder r0, java.lang.object r1, short r2, java.lang.string r3, bool r4, char r5) {
            goto L1e
        L4:
            r0 = 42
            goto L18
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L21
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1e:
            goto L2c
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto Lf
        L2b:
            return
        L2c:
            goto L15
    }

    public static int FVyJAyYtFPDWlPLD(byte[] r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = readInt(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void FVyJAyYtFPDWlPLD(byte[] r0, int r1, char r2, int r3, java.lang.string r4, bool r5) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L2a
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L26
        L1e:
            goto La
        L22:
            goto L1e
        L25:
            return
        L26:
            goto L22
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
    }

    public static void FVyJAyYtFPDWlPLD(byte[] r0, int r1, bool r2, char r3, java.lang.string r4, int r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L27
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L11:
            int r2 = r0 * r1
            goto L21
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto L17
        L27:
            r0 = 42
            goto Lb
        L2d:
            goto L7
    }

    public static void FVyJAyYtFPDWlPLD(byte[] r0, int r1, bool r2, java.lang.string r3, char r4, int r5) {
            goto L1e
        L4:
            r0 = 42
            goto L10
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L21
        L1e:
            goto L17
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto La
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void FsMDogwBJXypUZGb(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.writeHeader(r1, r2, r3, r4)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void FsMDogwBJXypUZGb(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, byte r5, bool r6, java.lang.string r7, int r8) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            int r2 = r0 * r1
            goto L19
        L11:
            goto L7
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto L11
    }

    public static void FsMDogwBJXypUZGb(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, int r5, byte r6, java.lang.string r7, bool r8) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto La
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void FsMDogwBJXypUZGb(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, java.lang.string r5, bool r6, int r7, byte r8) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L25
        L15:
            goto L26
        L18:
            goto La
        L1c:
            int r3 = r2 + r1
            goto L10
        L22:
            goto L18
        L25:
            return
        L26:
            goto L22
        L2a:
            int r2 = r0 * r1
            goto L1c
    }

    public static void GEXMzOdcvetFYVxC(java.io.RandomAccessstring r0, long r1) {
            goto Le
        L4:
            goto L11
        L7:
            r0.seek(r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void GEXMzOdcvetFYVxC(java.io.RandomAccessstring r0, long r1, byte r3, short r4, char r5, bool r6) {
            goto L13
        L4:
            goto L16
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            goto L26
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto Ld
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L20
    }

    public static void GEXMzOdcvetFYVxC(java.io.RandomAccessstring r0, long r1, char r3, byte r4, bool r5, short r6) {
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            r0 = 42
            goto L2a
        L12:
            int r3 = r2 + r1
            goto L25
        L18:
            goto L8
        L1b:
            goto Lc
        L1f:
            int r2 = r0 * r1
            goto L12
        L25:
            double r0 = (double) r3
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void GEXMzOdcvetFYVxC(java.io.RandomAccessstring r0, long r1, short r3, bool r4, char r5, byte r6) {
            goto Le
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L27
        Le:
            goto La
        L11:
            goto L15
        L15:
            r0 = 42
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto L11
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void GNeqDLXKJXUjnakj(java.io.string r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            initialize(r0)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void GNeqDLXKJXUjnakj(java.io.string r0, byte r1, bool r2, short r3, int r4) {
            goto Lf
        L4:
            return
        L5:
            goto L1c
        L9:
            int r3 = r2 + r1
            goto L1f
        Lf:
            goto L5
        L12:
            goto L2a
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            goto L12
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2a:
            r0 = 42
            goto L24
    }

    public static void GNeqDLXKJXUjnakj(java.io.string r0, short r1, int r2, byte r3, bool r4) {
            goto L20
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L2a
        Lf:
            int r3 = r2 + r1
            goto L15
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            int r2 = r0 * r1
            goto Lf
        L20:
            goto L5
        L23:
            goto L9
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void GNeqDLXKJXUjnakj(java.io.string r0, bool r1, byte r2, short r3, int r4) {
            goto L1a
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            int r3 = r2 + r1
            goto L15
        L10:
            return
        L11:
            goto L2d
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L11
        L1d:
            goto L27
        L21:
            int r2 = r0 * r1
            goto La
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L1d
    }

    public static java.lang.object GStfDAeyWFGwIqZG(java.lang.object r1, java.lang.string r2) {
            goto L11
        L4:
            java.lang.object r0 = nonNull(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void GStfDAeyWFGwIqZG(java.lang.object r0, java.lang.string r1, byte r2, bool r3, java.lang.string r4, short r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L1e
        Ld:
            goto L27
        L11:
            int r2 = r0 * r1
            goto L17
        L17:
            int r3 = r2 + r1
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            r0 = 42
            goto L4
        L2d:
            goto Ld
    }

    public static void GStfDAeyWFGwIqZG(java.lang.object r0, java.lang.string r1, java.lang.string r2, short r3, byte r4, bool r5) {
            goto L14
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            return
        Lb:
            goto L21
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L1b
        L1b:
            r0 = 42
            goto L4
        L21:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void GStfDAeyWFGwIqZG(java.lang.object r0, java.lang.string r1, short r2, bool r3, java.lang.string r4, byte r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            goto L2c
        Ld:
            goto L1f
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            goto Ld
        L1f:
            r0 = 42
            goto L11
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L1c
    }

    public static com.google.firebase.crashlytics.internal.metadata.Queuestring.Element GdJckQVoUlnOCwbm(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r1.readElement(r2)
            goto Lb
    }

    public static void GdJckQVoUlnOCwbm(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, byte r3, bool r4, float r5) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            int r3 = r2 + r1
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L9
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            double r0 = (double) r3
            goto L4
        L20:
            r0 = 42
            goto L15
        L26:
            goto L5
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void GdJckQVoUlnOCwbm(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, float r3, bool r4, byte r5) {
            goto L10
        L4:
            r0 = 42
            goto L17
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            goto L29
        L13:
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1d:
            int r3 = r2 + r1
            goto L23
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static void GdJckQVoUlnOCwbm(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, bool r2, byte r3, float r4, char r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            double r0 = (double) r3
            goto L24
        Lf:
            r0 = 42
            goto L4
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto La
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto Lf
    }

    public static void GlgUphwBGlgwoyHx(java.io.RandomAccessstring r0, long r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.seek(r1)
            goto Lb
    }

    public static void GlgUphwBGlgwoyHx(java.io.RandomAccessstring r0, long r1, char r3, bool r4, byte r5, short r6) {
            goto L21
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            return
        L11:
            goto L28
        L15:
            int r2 = r0 * r1
            goto L1b
        L1b:
            int r3 = r2 + r1
            goto L2b
        L21:
            goto L11
        L24:
            goto L4
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void GlgUphwBGlgwoyHx(java.io.RandomAccessstring r0, long r1, short r3, byte r4, char r5, bool r6) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            r0 = 42
            goto L2a
        L1b:
            return
        L1c:
            goto L20
        L20:
            goto L26
        L23:
            goto L1c
        L26:
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void GlgUphwBGlgwoyHx(java.io.RandomAccessstring r0, long r1, short r3, bool r4, char r5, byte r6) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L23
        L13:
            goto L1c
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            r0 = 42
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void HHdmvBShNvKXhSjG(byte[] r0, int r1, int r2) {
            goto Le
        L4:
            goto L11
        L7:
            writeInt(r0, r1, r2)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void HHdmvBShNvKXhSjG(byte[] r0, int r1, int r2, byte r3, bool r4, float r5, int r6) {
            goto Lf
        L4:
            r0 = 42
            goto L1f
        La:
            return
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            goto L12
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    public static void HHdmvBShNvKXhSjG(byte[] r0, int r1, int r2, byte r3, bool r4, int r5, float r6) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L1e
        L1b:
            goto L2c
        L1e:
            return
        L1f:
            goto L1b
        L23:
            r0 = 42
            goto L4
        L29:
            goto L1f
        L2c:
            goto L23
    }

    public static void HHdmvBShNvKXhSjG(byte[] r0, int r1, int r2, float r3, int r4, bool r5, byte r6) {
            goto L29
        L4:
            return
        L5:
            goto L26
        L9:
            r0 = 42
            goto L1a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            int r2 = r0 * r1
            goto L20
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            int r3 = r2 + r1
            goto Lf
        L26:
            goto L2c
        L29:
            goto L5
        L2c:
            goto L9
    }

    public static java.lang.string HrmbuGOOaLayZyPD(java.lang.stringBuilder r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.tostring()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void HrmbuGOOaLayZyPD(java.lang.stringBuilder r0, float r1, java.lang.string r2, bool r3, short r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L1b
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto L10
        L23:
            goto L11
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L15
    }

    public static void HrmbuGOOaLayZyPD(java.lang.stringBuilder r0, short r1, float r2, java.lang.string r3, bool r4) {
            goto L1d
        L4:
            goto L20
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto L4
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L13
        L20:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void HrmbuGOOaLayZyPD(java.lang.stringBuilder r0, bool r1, short r2, float r3, java.lang.string r4) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L1c
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            int r2 = r0 * r1
            goto L22
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L4
        L2d:
            goto L12
    }

    public static void IuIcHqptiqKrBFly(java.io.RandomAccessstring r0, byte[] r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.readFully(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void IuIcHqptiqKrBFly(java.io.RandomAccessstring r0, byte[] r1, char r2, java.lang.string r3, int r4, bool r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto L24
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L18
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void IuIcHqptiqKrBFly(java.io.RandomAccessstring r0, byte[] r1, int r2, bool r3, char r4, java.lang.string r5) {
            goto L24
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L10:
            goto L27
        L13:
            double r0 = (double) r3
            goto L2b
        L18:
            int r3 = r2 + r1
            goto L13
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto L10
    }

    public static void IuIcHqptiqKrBFly(java.io.RandomAccessstring r0, byte[] r1, java.lang.string r2, int r3, char r4, bool r5) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L2a
        L13:
            int r2 = r0 * r1
            goto L24
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L19
    }

    public static java.lang.string IvkoHrNHBYGUhrOd(java.lang.Class r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getSimpleName()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void IvkoHrNHBYGUhrOd(java.lang.Class r0, byte r1, char r2, short r3, bool r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L22
        La:
            goto L18
        Ld:
            goto L1c
        L11:
            int r2 = r0 * r1
            goto L4
        L17:
            return
        L18:
            goto L2d
        L1c:
            r0 = 42
            goto L27
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2d:
            goto Ld
    }

    public static void IvkoHrNHBYGUhrOd(java.lang.Class r0, byte r1, short r2, bool r3, char r4) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L15:
            goto L2c
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            r0 = 42
            goto Lf
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void IvkoHrNHBYGUhrOd(java.lang.Class r0, char r1, bool r2, short r3, byte r4) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L24
        Le:
            return
        Lf:
            goto L4
        L13:
            double r0 = (double) r3
            goto Le
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            r0 = 42
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void KUUtGpurtHtLSHCS(java.util.logging.Consoleger r0, java.util.logging.Level r1, java.lang.string r2, java.lang.Exception r3) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.log(r1, r2, r3)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void KUUtGpurtHtLSHCS(java.util.logging.Consoleger r0, java.util.logging.Level r1, java.lang.string r2, java.lang.Exception r3, float r4, java.lang.string r5, int r6, char r7) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L2c
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            return
        L25:
            goto Lf
        L29:
            goto L25
        L2c:
            goto L12
    }

    public static void KUUtGpurtHtLSHCS(java.util.logging.Consoleger r0, java.util.logging.Level r1, java.lang.string r2, java.lang.Exception r3, int r4, java.lang.string r5, char r6, float r7) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L14
        Ld:
            goto L26
        L10:
            goto L19
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void KUUtGpurtHtLSHCS(java.util.logging.Consoleger r0, java.util.logging.Level r1, java.lang.string r2, java.lang.Exception r3, java.lang.string r4, float r5, int r6, char r7) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L1c
        L10:
            r0 = 42
            goto L27
        L16:
            int r2 = r0 * r1
            goto L21
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto Lb
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto L7
    }

    public static void LBONNAcuHCijqMjj(com.google.firebase.crashlytics.internal.metadata.Queuestring r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.clear()
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void LBONNAcuHCijqMjj(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, java.lang.string r1, bool r2, char r3, int r4) {
            goto L15
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto L22
        Lf:
            int r2 = r0 * r1
            goto L1c
        L15:
            goto L23
        L18:
            goto L4
        L1c:
            int r3 = r2 + r1
            goto La
        L22:
            return
        L23:
            goto L27
        L27:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void LBONNAcuHCijqMjj(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, bool r1, char r2, int r3, java.lang.string r4) {
            goto L20
        L4:
            return
        L5:
            goto L2d
        L9:
            r0 = 42
            goto L14
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L1a:
            int r2 = r0 * r1
            goto L27
        L20:
            goto L5
        L23:
            goto L9
        L27:
            int r3 = r2 + r1
            goto Lf
        L2d:
            goto L23
    }

    public static void LBONNAcuHCijqMjj(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, bool r1, java.lang.string r2, int r3, char r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L14
        Ld:
            goto L26
        L10:
            goto L19
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static int LZSykzEvVbdBJgUY(byte[] r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = readInt(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void LZSykzEvVbdBJgUY(byte[] r0, int r1, int r2, short r3, float r4, java.lang.string r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L16
        L16:
            double r0 = (double) r3
            goto L28
        L1b:
            goto L29
        L1e:
            goto L22
        L22:
            r0 = 42
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static void LZSykzEvVbdBJgUY(byte[] r0, int r1, java.lang.string r2, float r3, short r4, int r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r3 = r2 + r1
            goto L2b
        Ld:
            return
        Le:
            goto L4
        L12:
            int r2 = r0 * r1
            goto L7
        L18:
            r0 = 42
            goto L25
        L1e:
            goto Le
        L21:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void LZSykzEvVbdBJgUY(byte[] r0, int r1, java.lang.string r2, short r3, float r4, int r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            goto L12
        Ld:
            goto L2a
        L11:
            return
        L12:
            goto L27
        L16:
            double r0 = (double) r3
            goto L11
        L1b:
            int r2 = r0 * r1
            goto L21
        L21:
            int r3 = r2 + r1
            goto L16
        L27:
            goto Ld
        L2a:
            r0 = 42
            goto L4
    }

    public static void LhiIfvcfmydGZjOt(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.setLength(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void LhiIfvcfmydGZjOt(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, float r3, byte r4, short r5) {
            goto L1d
        L4:
            goto L20
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L13
        L2a:
            r0 = 42
            goto Ld
    }

    public static void LhiIfvcfmydGZjOt(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, float r3, short r4, byte r5) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            return
        L11:
            goto L28
        L15:
            goto L11
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L22
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            goto L18
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void LhiIfvcfmydGZjOt(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, short r2, char r3, byte r4, float r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            r0 = 42
            goto L1f
        Lf:
            goto L26
        L12:
            goto L9
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void LiFHZiTUIxWaOCuN(java.io.RandomAccessstring r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.Dispose()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void LiFHZiTUIxWaOCuN(java.io.RandomAccessstring r0, byte r1, char r2, int r3, java.lang.string r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            goto L27
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L20
        L17:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            return
        L27:
            goto L17
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void LiFHZiTUIxWaOCuN(java.io.RandomAccessstring r0, byte r1, java.lang.string r2, char r3, int r4) {
            goto L1a
        L4:
            r0 = 42
            goto L21
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L27
        L1a:
            goto L16
        L1d:
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L10
    }

    public static void LiFHZiTUIxWaOCuN(java.io.RandomAccessstring r0, java.lang.string r1, char r2, int r3, byte r4) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            double r0 = (double) r3
            goto L16
        Lf:
            goto L17
        L12:
            goto L1e
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L12
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void LpFKhNdNxFNyYdSf(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.write(r1, r2, r3)
            goto L7
    }

    public static void LpFKhNdNxFNyYdSf(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, byte r4, int r5, java.lang.string r6, short r7) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L11:
            r0 = 42
            goto Lb
        L17:
            goto L7
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1a
        L2b:
            return
        L2c:
            goto L17
    }

    public static void LpFKhNdNxFNyYdSf(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, java.lang.string r4, short r5, byte r6, int r7) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L14:
            r0 = 42
            goto Le
        L1a:
            goto L5
        L1d:
            goto L14
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto L9
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void LpFKhNdNxFNyYdSf(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, java.lang.string r4, short r5, int r6, byte r7) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L1d
        L10:
            goto L26
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L14
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static long MAjFAxsmbJUWGTPC(java.nio.channels.stringChannel r2, long r3, long r5, java.nio.channels.WritablebyteChannel r7) {
            goto Lb
        L4:
            goto L3a
        L7:
            goto L12
        Lb:
            goto L7
        Le:
            goto L22
        L12:
            goto Le
        L15:
            int r0 = r0 + r1
            goto L3e
        L1b:
            r1 = 3
            goto L15
        L22:
            r0 = 17
            goto L1b
        L29:
            return r0
        L2a:
            goto L4
        L2e:
            if (r0 <= 0) goto L33
            goto L3a
        L33:
            goto L37
        L37:
            goto L2a
        L3a:
            goto L44
        L3e:
            int r0 = r0 % r1
            goto L2e
        L44:
            long r0 = r2.transferTo(r3, r5, r7)
            goto L29
    }

    public static void MAjFAxsmbJUWGTPC(java.nio.channels.stringChannel r0, long r1, long r3, java.nio.channels.WritablebyteChannel r5, byte r6, float r7, bool r8, char r9) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r0 = 42
            goto L14
        Lf:
            return
        L10:
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            goto L20
        L1d:
            goto L10
        L20:
            goto L9
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void MAjFAxsmbJUWGTPC(java.nio.channels.stringChannel r0, long r1, long r3, java.nio.channels.WritablebyteChannel r5, char r6, byte r7, bool r8, float r9) {
            goto L4
        L4:
            goto L23
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L16
        L11:
            double r0 = (double) r3
            goto L22
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1c:
            int r3 = r2 + r1
            goto L11
        L22:
            return
        L23:
            goto L2d
        L27:
            int r2 = r0 * r1
            goto L1c
        L2d:
            goto L7
    }

    public static void MAjFAxsmbJUWGTPC(java.nio.channels.stringChannel r0, long r1, long r3, java.nio.channels.WritablebyteChannel r5, float r6, bool r7, byte r8, char r9) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            goto L21
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto L4
        L2b:
            return
        L2c:
            goto L16
    }

    public static void MEPuXXkRCwHgnXsh(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.writeHeader(r1, r2, r3, r4)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void MEPuXXkRCwHgnXsh(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, char r5, java.lang.string r6, int r7, float r8) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L2a
        L14:
            r0 = 42
            goto L24
        L1a:
            goto L5
        L1d:
            goto L14
        L21:
            goto L1d
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void MEPuXXkRCwHgnXsh(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, int r5, char r6, float r7, java.lang.string r8) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L1f
        Ld:
            goto L1b
        L10:
            goto L14
        L14:
            r0 = 42
            goto L25
        L1a:
            return
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void MEPuXXkRCwHgnXsh(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, int r5, float r6, char r7, java.lang.string r8) {
            goto L1d
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L10:
            goto L20
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r0 = 42
            goto La
    }

    public static java.lang.stringBuilder MTknrsnFuoXfGdyY(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static void MTknrsnFuoXfGdyY(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, short r3, int r4, bool r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L2c
        L12:
            int r3 = r2 + r1
            goto L24
        L18:
            r0 = 42
            goto L1e
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L24:
            double r0 = (double) r3
            goto La
        L29:
            goto Lb
        L2c:
            goto L18
    }

    public static void MTknrsnFuoXfGdyY(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, bool r3, short r4, int r5) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1c
        L10:
            goto L18
        L13:
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto L13
        L2a:
            r0 = 42
            goto L4
    }

    public static void MTknrsnFuoXfGdyY(java.lang.stringBuilder r0, java.lang.string r1, short r2, int r3, java.lang.string r4, bool r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L2a
        L10:
            return
        L11:
            goto L15
        L15:
            goto Lc
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2a:
            r0 = 42
            goto L24
    }

    public static void MeuZPNqiiCseLDvj(java.io.RandomAccessstring r0, byte[] r1) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.write(r1)
            goto L4
    }

    public static void MeuZPNqiiCseLDvj(java.io.RandomAccessstring r0, byte[] r1, char r2, short r3, java.lang.string r4, bool r5) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto La
        L17:
            goto L21
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L21:
            r0 = 42
            goto L1b
        L27:
            int r2 = r0 * r1
            goto Le
        L2d:
            goto L17
    }

    public static void MeuZPNqiiCseLDvj(java.io.RandomAccessstring r0, byte[] r1, java.lang.string r2, char r3, bool r4, short r5) {
            goto L24
        L4:
            return
        L5:
            goto L9
        L9:
            goto L27
        Lc:
            r0 = 42
            goto L18
        L12:
            int r2 = r0 * r1
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto L5
        L27:
            goto Lc
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void MeuZPNqiiCseLDvj(java.io.RandomAccessstring r0, byte[] r1, bool r2, short r3, java.lang.string r4, char r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto L17
        L27:
            goto L7
        L2a:
            int r2 = r0 * r1
            goto L21
    }

    public static java.lang.string NUDfdleeGaSYgOIf(java.lang.stringBuilder r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.tostring()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void NUDfdleeGaSYgOIf(java.lang.stringBuilder r0, float r1, bool r2, byte r3, short r4) {
            goto L13
        L4:
            goto L16
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L1a
        L13:
            goto L26
        L16:
            goto L2a
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto L7
    }

    public static void NUDfdleeGaSYgOIf(java.lang.stringBuilder r0, short r1, byte r2, float r3, bool r4) {
            goto L1d
        L4:
            return
        L5:
            goto L15
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L15:
            goto L20
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            goto L5
        L20:
            goto L9
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static void NUDfdleeGaSYgOIf(java.lang.stringBuilder r0, short r1, bool r2, byte r3, float r4) {
            goto L4
        L4:
            goto L21
        L7:
            goto L25
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L11:
            int r2 = r0 * r1
            goto L1a
        L17:
            goto L7
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            return
        L21:
            goto L17
        L25:
            r0 = 42
            goto Lb
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void NVpMHQAgfZOywXlg(java.nio.channels.stringChannel r0, bool r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.force(r1)
            goto Le
    }

    public static void NVpMHQAgfZOywXlg(java.nio.channels.stringChannel r0, bool r1, java.lang.string r2, byte r3, short r4, char r5) {
            goto Ld
        L4:
            r0 = 42
            goto L14
        La:
            goto L10
        Ld:
            goto L20
        L10:
            goto L4
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto La
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    public static void NVpMHQAgfZOywXlg(java.nio.channels.stringChannel r0, bool r1, java.lang.string r2, char r3, short r4, byte r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            r0 = 42
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L25
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            goto L7
        L25:
            int r3 = r2 + r1
            goto Lb
        L2b:
            return
        L2c:
            goto L22
    }

    public static void NVpMHQAgfZOywXlg(java.nio.channels.stringChannel r0, bool r1, java.lang.string r2, short r3, byte r4, char r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            return
        Lb:
            goto L1c
        Lf:
            r0 = 42
            goto L4
        L15:
            goto Lb
        L18:
            goto Lf
        L1c:
            goto L18
        L1f:
            int r2 = r0 * r1
            goto L25
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void NdDWhYEGBmnvhDiZ(java.io.RandomAccessstring r0, long r1) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.seek(r1)
            goto L4
    }

    public static void NdDWhYEGBmnvhDiZ(java.io.RandomAccessstring r0, long r1, char r3, float r4, byte r5, java.lang.string r6) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            return
        Lb:
            goto L1c
        Lf:
            goto Lb
        L12:
            goto L1f
        L16:
            int r3 = r2 + r1
            goto L25
        L1c:
            goto L12
        L1f:
            r0 = 42
            goto L2a
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void NdDWhYEGBmnvhDiZ(java.io.RandomAccessstring r0, long r1, float r3, byte r4, char r5, java.lang.string r6) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0 = 42
            goto L2a
        L19:
            int r2 = r0 * r1
            goto L24
        L1f:
            double r0 = (double) r3
            goto Le
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
    }

    public static void NdDWhYEGBmnvhDiZ(java.io.RandomAccessstring r0, long r1, java.lang.string r3, float r4, byte r5, char r6) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto L21
        L1e:
            goto Lb
        L21:
            goto L25
        L25:
            r0 = 42
            goto L15
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void OJZETEwDaGrwXkWM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.writeHeader(r1, r2, r3, r4)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void OJZETEwDaGrwXkWM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, char r5, int r6, short r7, bool r8) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L23
        Ld:
            goto L1c
        L11:
            double r0 = (double) r3
            goto L22
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            r0 = 42
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto Ld
    }

    public static void OJZETEwDaGrwXkWM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, int r5, short r6, char r7, bool r8) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            goto L21
        L13:
            r0 = 42
            goto L4
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L13
        L25:
            double r0 = (double) r3
            goto L19
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void OJZETEwDaGrwXkWM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, bool r5, short r6, char r7, int r8) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L2c
        L12:
            goto L1f
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1c:
            goto L12
        L1f:
            r0 = 42
            goto L16
        L25:
            int r2 = r0 * r1
            goto L9
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void OWmMLUHhzlzjcMbu(java.io.RandomAccessstring r0, long r1) {
            goto Le
        L4:
            r0.setLength(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void OWmMLUHhzlzjcMbu(java.io.RandomAccessstring r0, long r1, float r3, char r4, short r5, bool r6) {
            goto L1d
        L4:
            return
        L5:
            goto L9
        L9:
            goto L20
        Lc:
            double r0 = (double) r3
            goto L4
        L11:
            int r2 = r0 * r1
            goto L24
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto Lc
        L2a:
            r0 = 42
            goto L17
    }

    public static void OWmMLUHhzlzjcMbu(java.io.RandomAccessstring r0, long r1, short r3, float r4, char r5, bool r6) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            r0 = 42
            goto L4
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto L15
        L25:
            int r2 = r0 * r1
            goto Lf
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void OWmMLUHhzlzjcMbu(java.io.RandomAccessstring r0, long r1, bool r3, float r4, short r5, char r6) {
            goto L12
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L2a
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r0 = 42
            goto L9
    }

    public static void OaeJCECVaQNLTWlu(java.io.RandomAccessstring r0, long r1) {
            goto Le
        L4:
            r0.seek(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void OaeJCECVaQNLTWlu(java.io.RandomAccessstring r0, long r1, byte r3, int r4, char r5, java.lang.string r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L29
        Ld:
            goto L17
        L11:
            int r3 = r2 + r1
            goto L23
        L17:
            r0 = 42
            goto L1d
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            double r0 = (double) r3
            goto L28
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void OaeJCECVaQNLTWlu(java.io.RandomAccessstring r0, long r1, byte r3, java.lang.string r4, char r5, int r6) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto La
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void OaeJCECVaQNLTWlu(java.io.RandomAccessstring r0, long r1, java.lang.string r3, byte r4, char r5, int r6) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L1d
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L29
        L13:
            goto L17
        L17:
            r0 = 42
            goto L22
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static java.io.RandomAccessstring ObfJCcoRsAiXNYIv(java.io.string r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.io.RandomAccessstring r0 = open(r1)
            goto L4
    }

    public static void ObfJCcoRsAiXNYIv(java.io.string r0, int r1, java.lang.string r2, float r3, bool r4) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        La:
            goto L1b
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L4
        L18:
            goto Le
        L1b:
            goto L12
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void ObfJCcoRsAiXNYIv(java.io.string r0, bool r1, float r2, int r3, java.lang.string r4) {
            goto L14
        L4:
            return
        L5:
            goto L2d
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L5
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto Lf
        L21:
            r0 = 42
            goto L9
        L27:
            int r2 = r0 * r1
            goto L1b
        L2d:
            goto L17
    }

    public static void ObfJCcoRsAiXNYIv(java.io.string r0, bool r1, int r2, float r3, java.lang.string r4) {
            goto L1a
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            return
        L11:
            goto L2d
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L11
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L27
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2d:
            goto L1d
    }

    public static int PEVoMoVmmCElsyYW(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.remainingbytes()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void PEVoMoVmmCElsyYW(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, char r2, java.lang.string r3, short r4) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        La:
            return
        Lb:
            goto L2d
        Lf:
            goto Lb
        L12:
            goto L27
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto La
        L27:
            r0 = 42
            goto L4
        L2d:
            goto L12
    }

    public static void PEVoMoVmmCElsyYW(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, char r1, java.lang.string r2, byte r3, short r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L16
        La:
            r0 = 42
            goto L25
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto La
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void PEVoMoVmmCElsyYW(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, short r1, byte r2, char r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r0 = 42
            goto L2a
        L17:
            int r3 = r2 + r1
            goto L22
        L1d:
            return
        L1e:
            goto L27
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void POpAbLmTgRqMfySi(java.io.RandomAccessstring r0, byte[] r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.write(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void POpAbLmTgRqMfySi(java.io.RandomAccessstring r0, byte[] r1, float r2, int r3, short r4, java.lang.string r5) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto L25
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            goto L21
        L18:
            r0 = 42
            goto Lf
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L4
        L2b:
            return
        L2c:
            goto L15
    }

    public static void POpAbLmTgRqMfySi(java.io.RandomAccessstring r0, byte[] r1, float r2, short r3, int r4, java.lang.string r5) {
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto L15
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void POpAbLmTgRqMfySi(java.io.RandomAccessstring r0, byte[] r1, short r2, float r3, java.lang.string r4, int r5) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L16
        Ld:
            r0 = 42
            goto L4
        L13:
            goto L21
        L16:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto La
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static int PaFkgmPpRpkCPRuB(java.io.RandomAccessstring r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.readInt()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void PaFkgmPpRpkCPRuB(java.io.RandomAccessstring r0, char r1, short r2, bool r3, float r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L23
        La:
            return
        Lb:
            goto L1a
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            goto L2c
        L1d:
            r0 = 42
            goto L14
        L23:
            int r3 = r2 + r1
            goto Lf
        L29:
            goto Lb
        L2c:
            goto L1d
    }

    public static void PaFkgmPpRpkCPRuB(java.io.RandomAccessstring r0, short r1, bool r2, float r3, char r4) {
            goto L14
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L1b
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L5
        L17:
            goto L27
        L1b:
            int r3 = r2 + r1
            goto Lf
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L17
    }

    public static void PaFkgmPpRpkCPRuB(java.io.RandomAccessstring r0, bool r1, short r2, float r3, char r4) {
            goto La
        L4:
            r0 = 42
            goto L1a
        La:
            goto L21
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            int r2 = r0 * r1
            goto L25
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L20:
            return
        L21:
            goto L11
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static java.nio.channels.stringChannel QEOaHbbBBcwZzrfX(java.nio.channels.stringChannel r1, long r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.nio.channels.stringChannel r0 = r1.position(r2)
            goto Le
    }

    public static void QEOaHbbBBcwZzrfX(java.nio.channels.stringChannel r0, long r1, byte r3, float r4, short r5, int r6) {
            goto L29
        L4:
            r0 = 42
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L2c
        L12:
            int r2 = r0 * r1
            goto L23
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto Lb
        L2c:
            goto L4
    }

    public static void QEOaHbbBBcwZzrfX(java.nio.channels.stringChannel r0, long r1, float r3, int r4, byte r5, short r6) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        Lf:
            r0 = 42
            goto L9
        L15:
            goto L5
        L18:
            goto Lf
        L1c:
            int r2 = r0 * r1
            goto L2a
        L22:
            double r0 = (double) r3
            goto L4
        L27:
            goto L18
        L2a:
            int r3 = r2 + r1
            goto L22
    }

    public static void QEOaHbbBBcwZzrfX(java.nio.channels.stringChannel r0, long r1, int r3, short r4, byte r5, float r6) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            goto L1e
        Ld:
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            r0 = 42
            goto L11
        L1d:
            return
        L1e:
            goto L2d
        L22:
            int r3 = r2 + r1
            goto L28
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto Ld
    }

    public static int SEsDPXumiEkbHRXC(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto L14
        L4:
            int r0 = r1.wrapPosition(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void SEsDPXumiEkbHRXC(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, short r3, byte r4, bool r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L26
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L1d:
            int r2 = r0 * r1
            goto L9
        L23:
            goto L10
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L17
    }

    public static void SEsDPXumiEkbHRXC(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, short r2, bool r3, byte r4, java.lang.string r5) {
            goto L1a
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r0 = 42
            goto L4
        L1a:
            goto Lb
        L1d:
            goto L14
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto Lf
        L2d:
            goto L1d
    }

    public static void SEsDPXumiEkbHRXC(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, bool r2, short r3, byte r4, java.lang.string r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        La:
            goto L20
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L1f
        L16:
            goto Ld
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            return
        L20:
            goto L16
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void SWgqwIhJoIfoeVwg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.expandIfNecessary(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void SWgqwIhJoIfoeVwg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, float r3, short r4, java.lang.string r5) {
            goto L1a
        L4:
            r0 = 42
            goto L21
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            return
        L11:
            goto L27
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            goto L11
        L1d:
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L27:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L15
    }

    public static void SWgqwIhJoIfoeVwg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, java.lang.string r3, short r4, float r5) {
            goto L29
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L20
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            int r2 = r0 * r1
            goto L23
        L20:
            goto L2c
        L23:
            int r3 = r2 + r1
            goto L15
        L29:
            goto Lb
        L2c:
            goto L4
    }

    public static void SWgqwIhJoIfoeVwg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, short r3, float r4, byte r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L24
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L2c
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            return
        L25:
            goto Lf
        L29:
            goto L25
        L2c:
            goto L12
    }

    public static void SwERfzWkdykRMWJw(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.ringRead(r1, r2, r3, r4)
            goto Le
    }

    public static void SwERfzWkdykRMWJw(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, byte r5, float r6, java.lang.string r7, int r8) {
            goto L21
        L4:
            return
        L5:
            goto L28
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r0 = 42
            goto L1b
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L21:
            goto L5
        L24:
            goto Lf
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void SwERfzWkdykRMWJw(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, float r5, java.lang.string r6, int r7, byte r8) {
            goto L24
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            int r2 = r0 * r1
            goto L15
        L21:
            goto L27
        L24:
            goto L2c
        L27:
            goto L4
        L2b:
            return
        L2c:
            goto L21
    }

    public static void SwERfzWkdykRMWJw(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, java.lang.string r5, float r6, int r7, byte r8) {
            goto L1d
        L4:
            r0 = 42
            goto L24
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L20
        L17:
            int r3 = r2 + r1
            goto La
        L1d:
            goto L10
        L20:
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    public static java.lang.stringBuilder TYSDqGcnxAKbblts(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void TYSDqGcnxAKbblts(java.lang.stringBuilder r0, java.lang.object r1, char r2, int r3, java.lang.string r4, float r5) {
            goto L20
        L4:
            r0 = 42
            goto L2a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L27
        L14:
            int r2 = r0 * r1
            goto L1a
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            goto L10
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void TYSDqGcnxAKbblts(java.lang.stringBuilder r0, java.lang.object r1, java.lang.string r2, char r3, float r4, int r5) {
            goto L15
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L25
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto La
        L1c:
            goto L18
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void TYSDqGcnxAKbblts(java.lang.stringBuilder r0, java.lang.object r1, java.lang.string r2, int r3, float r4, char r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            return
        Lb:
            goto L14
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto L2c
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto Lf
        L23:
            r0 = 42
            goto L4
        L29:
            goto Lb
        L2c:
            goto L23
    }

    public static void UhjuRXmOgucspgYw(java.io.string r0, java.io.string r1, byte r2, java.lang.string r3, char r4, int r5) {
            goto L17
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L1a
        Lc:
            return
        Ld:
            goto L9
        L11:
            r0 = 42
            goto L1e
        L17:
            goto Ld
        L1a:
            goto L11
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void UhjuRXmOgucspgYw(java.io.string r0, java.io.string r1, char r2, int r3, java.lang.string r4, byte r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L1f
        Le:
            int r3 = r2 + r1
            goto L1a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1a:
            double r0 = (double) r3
            goto L2b
        L1f:
            r0 = 42
            goto L14
        L25:
            int r2 = r0 * r1
            goto Le
        L2b:
            return
        L2c:
            goto L4
    }

    public static void UhjuRXmOgucspgYw(java.io.string r0, java.io.string r1, java.lang.string r2, char r3, byte r4, int r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L23
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L4
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L22
        L22:
            return
        L23:
            goto L27
        L27:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L17
    }

    public static bool UhjuRXmOgucspgYw(java.io.string r1, java.io.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.renameTo(r2)
            goto L4
        L18:
            goto Lc
    }

    public static int VbPQoQWSyBdCQisZ(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto Lf
        L4:
            int r0 = r1.wrapPosition(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void VbPQoQWSyBdCQisZ(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, char r3, float r4, short r5) {
            goto L20
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r2 = r0 * r1
            goto L1a
        Lf:
            return
        L10:
            goto L2d
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L1a:
            int r3 = r2 + r1
            goto L4
        L20:
            goto L10
        L23:
            goto L27
        L27:
            r0 = 42
            goto L14
        L2d:
            goto L23
    }

    public static void VbPQoQWSyBdCQisZ(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, short r3, char r4, float r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L17
        L11:
            r0 = 42
            goto L21
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto Lb
        L2d:
            goto L7
    }

    public static void VbPQoQWSyBdCQisZ(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, short r2, float r3, byte r4, char r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L2c
        L17:
            int r3 = r2 + r1
            goto La
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L10
        L2c:
            goto L23
    }

    public static java.io.RandomAccessstring VnYoIGOBHoOkVWWB(java.io.string r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.io.RandomAccessstring r0 = open(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void VnYoIGOBHoOkVWWB(java.io.string r0, byte r1, bool r2, char r3, java.lang.string r4) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L27
        Ld:
            r0 = 42
            goto L1e
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            return
        L1a:
            goto La
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L24:
            goto L1a
        L27:
            goto Ld
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static void VnYoIGOBHoOkVWWB(java.io.string r0, byte r1, bool r2, java.lang.string r3, char r4) {
            goto L18
        L4:
            goto L1b
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            goto L20
        L1b:
            goto L24
        L1f:
            return
        L20:
            goto L4
        L24:
            r0 = 42
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void VnYoIGOBHoOkVWWB(java.io.string r0, char r1, byte r2, bool r3, java.lang.string r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L27
        L10:
            return
        L11:
            goto L2d
        L15:
            goto L11
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L10
        L21:
            r0 = 42
            goto L4
        L27:
            int r3 = r2 + r1
            goto L1c
        L2d:
            goto L18
    }

    public static java.nio.channels.stringChannel WZDwWmDYrVgFsesx(java.io.RandomAccessstring r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.nio.channels.stringChannel r0 = r1.getChannel()
            goto Le
    }

    public static void WZDwWmDYrVgFsesx(java.io.RandomAccessstring r0, byte r1, bool r2, char r3, short r4) {
            goto L24
        L4:
            return
        L5:
            goto L1b
        L9:
            r0 = 42
            goto L1e
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            goto L27
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L24:
            goto L5
        L27:
            goto L9
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void WZDwWmDYrVgFsesx(java.io.RandomAccessstring r0, byte r1, bool r2, short r3, char r4) {
            goto L1d
        L4:
            int r3 = r2 + r1
            goto L13
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L20
        L13:
            double r0 = (double) r3
            goto L18
        L18:
            return
        L19:
            goto L10
        L1d:
            goto L19
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2a:
            r0 = 42
            goto L24
    }

    public static void WZDwWmDYrVgFsesx(java.io.RandomAccessstring r0, bool r1, byte r2, char r3, short r4) {
            goto L1b
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L15:
            int r2 = r0 * r1
            goto L22
        L1b:
            goto L2c
        L1e:
            goto L9
        L22:
            int r3 = r2 + r1
            goto L4
        L28:
            goto L1e
        L2b:
            return
        L2c:
            goto L28
    }

    public static java.lang.stringBuilder WjCTpVFybSOLTfys(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void WjCTpVFybSOLTfys(java.lang.stringBuilder r0, java.lang.string r1, char r2, float r3, int r4, java.lang.string r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            goto L2c
        Ld:
            goto L19
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            int r3 = r2 + r1
            goto L14
        L2b:
            return
        L2c:
            goto L11
    }

    public static void WjCTpVFybSOLTfys(java.lang.stringBuilder r0, java.lang.string r1, float r2, char r3, int r4, java.lang.string r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L21
        L10:
            int r3 = r2 + r1
            goto L1c
        L16:
            r0 = 42
            goto L24
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static void WjCTpVFybSOLTfys(java.lang.stringBuilder r0, java.lang.string r1, float r2, java.lang.string r3, int r4, char r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        Lf:
            int r2 = r0 * r1
            goto L24
        L15:
            return
        L16:
            goto L21
        L1a:
            goto L16
        L1d:
            goto L2a
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L9
    }

    public static java.lang.Class WwQfSBHgjorpliMe(java.lang.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.Class r0 = r1.GetType()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void WwQfSBHgjorpliMe(java.lang.object r0, float r1, char r2, int r3, bool r4) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L26
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            r0 = 42
            goto L2a
        L23:
            goto Lb
        L26:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void WwQfSBHgjorpliMe(java.lang.object r0, int r1, bool r2, float r3, char r4) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L1b
        Ld:
            return
        Le:
            goto La
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            goto Le
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            r0 = 42
            goto L12
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void WwQfSBHgjorpliMe(java.lang.object r0, bool r1, int r2, char r3, float r4) {
            goto L15
        L4:
            r0 = 42
            goto L24
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            return
        L11:
            goto L21
        L15:
            goto L11
        L18:
            goto L4
        L1c:
            double r0 = (double) r3
            goto L10
        L21:
            goto L18
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1c
    }

    public static java.lang.string XJiZxPYQnHRORsTa(java.lang.Class r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.string r0 = r1.getName()
            goto L7
    }

    public static void XJiZxPYQnHRORsTa(java.lang.Class r0, byte r1, float r2, java.lang.string r3, short r4) {
            goto L12
        L4:
            goto L15
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        Ld:
            return
        Le:
            goto L4
        L12:
            goto Le
        L15:
            goto L19
        L19:
            r0 = 42
            goto L7
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void XJiZxPYQnHRORsTa(java.lang.Class r0, byte r1, java.lang.string r2, short r3, float r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L1b
        Lc:
            int r3 = r2 + r1
            goto L4
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            goto L26
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    public static void XJiZxPYQnHRORsTa(java.lang.Class r0, byte r1, short r2, java.lang.string r3, float r4) {
            goto L23
        L4:
            return
        L5:
            goto L14
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L14:
            goto L26
        L17:
            r0 = 42
            goto Le
        L1d:
            int r2 = r0 * r1
            goto L2a
        L23:
            goto L5
        L26:
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void XaGdFPYWfnDfWMnw(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.readFully(r1, r2, r3)
            goto Le
    }

    public static void XaGdFPYWfnDfWMnw(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, byte r4, char r5, java.lang.string r6, bool r7) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto L21
        L18:
            r0 = 42
            goto Lf
        L1e:
            goto L2c
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto La
        L2b:
            return
        L2c:
            goto L15
    }

    public static void XaGdFPYWfnDfWMnw(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, char r4, java.lang.string r5, bool r6, byte r7) {
            goto L29
        L4:
            r0 = 42
            goto Ld
        La:
            goto L2c
        Ld:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            int r2 = r0 * r1
            goto L1d
        L29:
            goto L14
        L2c:
            goto L4
    }

    public static void XaGdFPYWfnDfWMnw(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, java.lang.string r4, bool r5, byte r6, char r7) {
            goto L23
        L4:
            return
        L5:
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        Lf:
            goto L26
        L12:
            int r3 = r2 + r1
            goto L1e
        L18:
            r0 = 42
            goto L9
        L1e:
            double r0 = (double) r3
            goto L4
        L23:
            goto L5
        L26:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L12
    }

    public static java.lang.stringBuilder XfuXatpxPLpAWiiU(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static void XfuXatpxPLpAWiiU(java.lang.stringBuilder r0, java.lang.string r1, char r2, int r3, bool r4, float r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L20
        L12:
            return
        L13:
            goto Lf
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L13
        L20:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L9
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void XfuXatpxPLpAWiiU(java.lang.stringBuilder r0, java.lang.string r1, int r2, char r3, float r4, bool r5) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            double r0 = (double) r3
            goto L18
        Lf:
            r0 = 42
            goto L2a
        L15:
            goto L20
        L18:
            return
        L19:
            goto L15
        L1d:
            goto L19
        L20:
            goto Lf
        L24:
            int r3 = r2 + r1
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void XfuXatpxPLpAWiiU(java.lang.stringBuilder r0, java.lang.string r1, bool r2, int r3, float r4, char r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            int r2 = r0 * r1
            goto L25
        L1b:
            goto L2c
        L1e:
            goto La
        L22:
            goto L1e
        L25:
            int r3 = r2 + r1
            goto L10
        L2b:
            return
        L2c:
            goto L22
    }

    public static void XmfZJBLrUDtFpsOZ(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.read(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static void XmfZJBLrUDtFpsOZ(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2, java.lang.string r3, bool r4, byte r5, short r6) {
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L25
        L12:
            r0 = 42
            goto L1f
        L18:
            goto L8
        L1b:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void XmfZJBLrUDtFpsOZ(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2, bool r3, java.lang.string r4, short r5, byte r6) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L2c
        Lc:
            return
        Ld:
            goto L9
        L11:
            r0 = 42
            goto L23
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L29:
            goto Ld
        L2c:
            goto L11
    }

    public static void XmfZJBLrUDtFpsOZ(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2, bool r3, short r4, java.lang.string r5, byte r6) {
            goto La
        L4:
            r0 = 42
            goto L19
        La:
            goto L15
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            return
        L15:
            goto L11
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static int YMEuXVbssyGeWiVy(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
            goto L14
        L4:
            int r0 = r1.usedbytes()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void YMEuXVbssyGeWiVy(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, char r1, short r2, bool r3, java.lang.string r4) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        La:
            goto L10
        Ld:
            goto L20
        L10:
            goto L2a
        L14:
            double r0 = (double) r3
            goto L1f
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            return
        L20:
            goto La
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r0 = 42
            goto L4
    }

    public static void YMEuXVbssyGeWiVy(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, short r1, java.lang.string r2, char r3, bool r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            double r0 = (double) r3
            goto L1e
        Lf:
            r0 = 42
            goto L18
        L15:
            goto L26
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            return
        L1f:
            goto L15
        L23:
            goto L1f
        L26:
            goto Lf
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static void YMEuXVbssyGeWiVy(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, short r1, bool r2, java.lang.string r3, char r4) {
            goto L21
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L28
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L15:
            r0 = 42
            goto Lf
        L1b:
            int r2 = r0 * r1
            goto L4
        L21:
            goto Lb
        L24:
            goto L15
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static java.lang.stringBuilder YwwTKHtPJjYefrwt(java.lang.stringBuilder r1, int r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static void YwwTKHtPJjYefrwt(java.lang.stringBuilder r0, int r1, float r2, byte r3, bool r4, short r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L25
        Lb:
            double r0 = (double) r3
            goto L2b
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L16:
            goto L7
        L19:
            int r3 = r2 + r1
            goto Lb
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            r0 = 42
            goto L10
        L2b:
            return
        L2c:
            goto L16
    }

    public static void YwwTKHtPJjYefrwt(java.lang.stringBuilder r0, int r1, short r2, byte r3, float r4, bool r5) {
            goto L15
        L4:
            return
        L5:
            goto L21
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L1c
        L15:
            goto L5
        L18:
            goto L24
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            goto L18
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void YwwTKHtPJjYefrwt(java.lang.stringBuilder r0, int r1, bool r2, float r3, short r4, byte r5) {
            goto La
        L4:
            r0 = 42
            goto L16
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L2d
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L11
        L27:
            int r2 = r0 * r1
            goto L1c
        L2d:
            goto Ld
    }

    public static void AAhhPnQipMbraaWF(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.ringWrite(r1, r2, r3, r4)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void AAhhPnQipMbraaWF(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, char r5, short r6, float r7, bool r8) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Ld:
            goto L1a
        L10:
            goto L2a
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L14
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r0 = 42
            goto L7
    }

    public static void AAhhPnQipMbraaWF(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, float r5, char r6, short r7, bool r8) {
            goto Lf
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            return
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L24
        L16:
            goto L12
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            r0 = 42
            goto L19
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void AAhhPnQipMbraaWF(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, bool r5, short r6, char r7, float r8) {
            goto La
        L4:
            r0 = 42
            goto L16
        La:
            goto L12
        Ld:
            goto L4
        L11:
            return
        L12:
            goto L1c
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1c:
            goto Ld
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L11
    }

    public static void AKRsCDrosrjTancB(byte[] r0, int[] r1) {
            goto L13
        L4:
            goto L16
        L7:
            writeInts(r0, r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void AKRsCDrosrjTancB(byte[] r0, int[] r1, char r2, bool r3, float r4, byte r5) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            goto L10
        L23:
            goto L27
        L27:
            r0 = 42
            goto L14
        L2d:
            goto L23
    }

    public static void AKRsCDrosrjTancB(byte[] r0, int[] r1, float r2, char r3, byte r4, bool r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            double r0 = (double) r3
            goto L25
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L25:
            return
        L26:
            goto L1c
        L2a:
            r0 = 42
            goto L1f
    }

    public static void AKRsCDrosrjTancB(byte[] r0, int[] r1, bool r2, char r3, byte r4, float r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L14
        Lb:
            goto L7
        Le:
            int r2 = r0 * r1
            goto L20
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto Lb
    }

    public static java.lang.stringBuilder AREqpcVOQFBbgVVV(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void AREqpcVOQFBbgVVV(java.lang.stringBuilder r0, java.lang.string r1, byte r2, short r3, java.lang.string r4, float r5) {
            goto Lf
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L16
        Lf:
            goto L5
        L12:
            goto L2a
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L21:
            int r2 = r0 * r1
            goto L9
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L1b
    }

    public static void AREqpcVOQFBbgVVV(java.lang.stringBuilder r0, java.lang.string r1, float r2, java.lang.string r3, short r4, byte r5) {
            goto L23
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L20
        L1a:
            int r3 = r2 + r1
            goto L10
        L20:
            goto L26
        L23:
            goto L16
        L26:
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static void AREqpcVOQFBbgVVV(java.lang.stringBuilder r0, java.lang.string r1, java.lang.string r2, byte r3, short r4, float r5) {
            goto L23
        L4:
            goto L26
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L13
        L13:
            int r3 = r2 + r1
            goto L1e
        L19:
            return
        L1a:
            goto L4
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            goto L1a
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L7
    }

    static /* synthetic */ int access$100(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = SEsDPXumiEkbHRXC(r0, r1)
            goto Le
    }

    static /* synthetic */ void access$100(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, float r3, java.lang.string r4, int r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r3 = r2 + r1
            goto Ld
        Ld:
            double r0 = (double) r3
            goto L2b
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1e:
            goto L2c
        L21:
            goto L12
        L25:
            int r2 = r0 * r1
            goto L7
        L2b:
            return
        L2c:
            goto L4
    }

    static /* synthetic */ void access$100(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, float r3, char r4, java.lang.string r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L14
        La:
            goto L18
        Le:
            double r0 = (double) r3
            goto L13
        L13:
            return
        L14:
            goto L4
        L18:
            r0 = 42
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto Le
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    static /* synthetic */ void access$100(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, char r3, float r4, int r5) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            goto L15
        L10:
            goto L24
        L14:
            return
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1f:
            double r0 = (double) r3
            goto L14
        L24:
            r0 = 42
            goto L19
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    static /* synthetic */ java.lang.object access$200(java.lang.object r0, java.lang.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.object r0 = GStfDAeyWFGwIqZG(r0, r1)
            goto Lb
    }

    static /* synthetic */ void access$200(java.lang.object r0, java.lang.string r1, char r2, float r3, short r4, int r5) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L2b
        L12:
            goto L8
        L15:
            goto L25
        L19:
            int r2 = r0 * r1
            goto Lc
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            r0 = 42
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L7
    }

    static /* synthetic */ void access$200(java.lang.object r0, java.lang.string r1, char r2, int r3, float r4, short r5) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L7
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            int r2 = r0 * r1
            goto L18
        L29:
            goto Le
        L2c:
            goto L12
    }

    static /* synthetic */ void access$200(java.lang.object r0, java.lang.string r1, float r2, char r3, short r4, int r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L26
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            goto L10
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L9
    }

    static /* synthetic */ void access$300(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4) throws java.io.IOException {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            mZuKtLOEhnJxpSlM(r0, r1, r2, r3, r4)
            goto Le
    }

    static /* synthetic */ void access$300(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, byte r5, char r6, bool r7, int r8) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L1e
        Lc:
            int r3 = r2 + r1
            goto L7
        L12:
            int r2 = r0 * r1
            goto Lc
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L1e:
            return
        L1f:
            goto L4
        L23:
            r0 = 42
            goto L18
        L29:
            goto L1f
        L2c:
            goto L23
    }

    static /* synthetic */ void access$300(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, char r5, byte r6, bool r7, int r8) {
            goto L11
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto Le
        Le:
            goto L14
        L11:
            goto La
        L14:
            goto L24
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            r0 = 42
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    static /* synthetic */ void access$300(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, bool r5, byte r6, char r7, int r8) {
            goto L4
        L4:
            goto L12
        L7:
            goto L22
        Lb:
            int r3 = r2 + r1
            goto L28
        L11:
            return
        L12:
            goto L2d
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L1c:
            int r2 = r0 * r1
            goto Lb
        L22:
            r0 = 42
            goto L16
        L28:
            double r0 = (double) r3
            goto L11
        L2d:
            goto L7
    }

    static /* synthetic */ java.io.RandomAccessstring access$400(com.google.firebase.crashlytics.internal.metadata.Queuestring r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L15
        La:
            goto Le
        Le:
            java.io.RandomAccessstring r0 = r0.raf
            goto L14
        L14:
            return r0
        L15:
            goto L4
    }

    static /* synthetic */ void access$400(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, byte r3, short r4) {
            goto Ld
        L4:
            r0 = 42
            goto L2a
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return
        L15:
            goto La
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L19
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    static /* synthetic */ void access$400(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, short r2, char r3, byte r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L14
        Ld:
            goto L2c
        L10:
            goto L20
        L14:
            int r3 = r2 + r1
            goto L26
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L20:
            r0 = 42
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L4
    }

    static /* synthetic */ void access$400(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, short r1, int r2, byte r3, char r4) {
            goto L20
        L4:
            int r2 = r0 * r1
            goto L27
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L1b
        L15:
            r0 = 42
            goto La
        L1b:
            return
        L1c:
            goto L2d
        L20:
            goto L1c
        L23:
            goto L15
        L27:
            int r3 = r2 + r1
            goto L10
        L2d:
            goto L23
    }

    public static java.lang.stringBuilder AtFunqDAOjhjHKjl(java.lang.stringBuilder r1, long r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void AtFunqDAOjhjHKjl(java.lang.stringBuilder r0, long r1, java.lang.string r3, bool r4, byte r5, float r6) {
            goto L12
        L4:
            r0 = 42
            goto L1f
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
        L19:
            int r2 = r0 * r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void AtFunqDAOjhjHKjl(java.lang.stringBuilder r0, long r1, bool r3, java.lang.string r4, byte r5, float r6) {
            goto Lf
        L4:
            return
        L5:
            goto L28
        L9:
            r0 = 42
            goto L22
        Lf:
            goto L5
        L12:
            goto L9
        L16:
            int r3 = r2 + r1
            goto L2b
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L28:
            goto L12
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void AtFunqDAOjhjHKjl(java.lang.stringBuilder r0, long r1, bool r3, java.lang.string r4, float r5, byte r6) {
            goto L1d
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L20
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L10
        L20:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static java.lang.object DKAJXsJRVYoPwnHS(java.lang.object r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = nonNull(r1, r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void DKAJXsJRVYoPwnHS(java.lang.object r0, java.lang.string r1, int r2, float r3, bool r4, char r5) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            return
        Lb:
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto L27
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            r0 = 42
            goto Lf
        L24:
            goto Lb
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void DKAJXsJRVYoPwnHS(java.lang.object r0, java.lang.string r1, int r2, bool r3, char r4, float r5) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L27
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L2b
        L24:
            goto L2c
        L27:
            goto L13
        L2b:
            return
        L2c:
            goto La
    }

    public static void DKAJXsJRVYoPwnHS(java.lang.object r0, java.lang.string r1, bool r2, char r3, int r4, float r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L21
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            return
        L1d:
            goto L27
        L21:
            r0 = 42
            goto L10
        L27:
            goto Lc
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static java.util.logging.Consoleger DKVFAqVhEMdpsEnd(java.lang.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.util.logging.Consoleger r0 = java.util.logging.Consoleger.getConsoleger(r1)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void DKVFAqVhEMdpsEnd(java.lang.string r0, float r1, short r2, byte r3, char r4) {
            goto L14
        L4:
            int r2 = r0 * r1
            goto L1b
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            goto L10
        L17:
            goto L27
        L1b:
            int r3 = r2 + r1
            goto La
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L17
    }

    public static void DKVFAqVhEMdpsEnd(java.lang.string r0, short r1, char r2, float r3, byte r4) {
            goto L14
        L4:
            return
        L5:
            goto L1b
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            goto L5
        L17:
            goto L2a
        L1b:
            goto L17
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto Le
        L2a:
            r0 = 42
            goto L1e
    }

    public static void DKVFAqVhEMdpsEnd(java.lang.string r0, short r1, float r2, char r3, byte r4) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L26
        L1d:
            int r2 = r0 * r1
            goto Lf
        L23:
            goto L16
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static void DSxvOWqgBmuOLiHg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1) {
            goto Lb
        L4:
            r0.setLength(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void DSxvOWqgBmuOLiHg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, float r3, java.lang.string r4, int r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L1d
        Ld:
            goto L2a
        L11:
            int r3 = r2 + r1
            goto L17
        L17:
            double r0 = (double) r3
            goto L1c
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L27:
            goto Ld
        L2a:
            r0 = 42
            goto L21
    }

    public static void DSxvOWqgBmuOLiHg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, int r3, float r4, java.lang.string r5) {
            goto L1a
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L2a
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L21
        L1a:
            goto L16
        L1d:
            goto La
        L21:
            goto L1d
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void DSxvOWqgBmuOLiHg(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, java.lang.string r3, float r4, char r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L1f
        Lf:
            int r2 = r0 * r1
            goto L2a
        L15:
            goto L20
        L18:
            goto L24
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto La
    }

    public static int DwxVIMefzEVxwWpS(byte[] r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = readInt(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void DwxVIMefzEVxwWpS(byte[] r0, int r1, java.lang.string r2, byte r3, bool r4, char r5) {
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            int r3 = r2 + r1
            goto L19
        L12:
            goto L5
        L15:
            goto L1e
        L19:
            double r0 = (double) r3
            goto L4
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto Lc
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void DwxVIMefzEVxwWpS(byte[] r0, int r1, java.lang.string r2, char r3, byte r4, bool r5) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L26
        L19:
            return
        L1a:
            goto L16
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            goto L1a
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto La
    }

    public static void DwxVIMefzEVxwWpS(byte[] r0, int r1, bool r2, char r3, java.lang.string r4, byte r5) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L15
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            r0 = 42
            goto L4
        L21:
            goto L2c
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    private void ExpandIfNecessary(int r9) throws java.io.IOException {
            r8 = this;
            goto L9d
        L4:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r8.first
            goto L198
        La:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r8.first
            goto L25
        L10:
            int r0 = r0 % r1
            goto Lc6
        L16:
            if (r9 < r0) goto L1b
            goto Le1
        L1b:
            goto L11d
        L1f:
            goto Lf3
        L21:
            goto L1b9
        L25:
            int r0 = r0.position
            goto L88
        L2b:
            int r9 = r9 + r0
            goto L179
        L30:
            r8.<init>(r9)
            goto Le0
        L37:
            int r0 = r8.elementCount
            goto L4
        L3d:
            QEOaHbbBBcwZzrfX(r2, r3)
            goto Lda
        L44:
            int r0 = r0.position
            goto L16
        L4a:
            LhiIfvcfmydGZjOt(r8, r1)
            goto L111
        L51:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r9 = r8.last
            goto L136
        L57:
            int r1 = r1 << 1
            goto La4
        L5d:
            r1 = 16
            goto L18c
        L64:
            int r9 = r9.position
            goto Lb3
        L6a:
            r3 = 16
            goto Leb
        L70:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r8.first
            goto L44
        L76:
            java.lang.string r9 = "Copied insufficient number of bytes!"
            goto L30
        L7c:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r8.last
            goto L97
        L82:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r8.last
            goto L126
        L88:
            if (r9 < r0) goto L8d
            goto L21
        L8d:
            goto Lf7
        L91:
            r8.fileLength = r1
            goto L157
        L97:
            int r0 = r0.position
            goto L2b
        L9d:
            goto L1b5
        La0:
            goto L1ab
        La4:
            if (r0 >= r9) goto La9
            goto L14d
        La9:
            goto L4a
        Lad:
            int r0 = r8.fileLength
            goto L12c
        Lb3:
            int r9 = r9 + 4
            goto L151
        Lb9:
            int r9 = r9 + 4
            goto L13c
        Lbf:
            r0.<init>(r9, r2)
            goto L192
        Lc6:
            if (r0 <= 0) goto Lcb
            goto L147
        Lcb:
            goto L144
        Lcf:
            goto Le1
        Ld0:
            goto L10b
        Ld4:
            int r2 = r2.length
            goto Lbf
        Lda:
            int r9 = r9 + (-4)
            goto L1a6
        Le0:
            throw r8
        Le1:
            goto L51
        Le5:
            int r0 = r0.position
            goto L82
        Leb:
            r7 = r2
            goto L19e
        Lf0:
            FsMDogwBJXypUZGb(r8, r1, r9, r0, r2)
        Lf3:
            goto L91
        Lf7:
            int r9 = r8.fileLength
            goto L7c
        Lfd:
            java.nio.channels.stringChannel r2 = WZDwWmDYrVgFsesx(r0)
            goto Lad
        L105:
            int r0 = r0.length
            goto L131
        L10b:
            java.lang.AssertionError r8 = new java.lang.AssertionError
            goto L76
        L111:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r9 = r8.last
            goto L64
        L117:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r8.last
            goto Ld4
        L11d:
            java.io.RandomAccessstring r0 = r8.raf
            goto Lfd
        L123:
            goto La0
        L126:
            int r2 = r2.position
            goto Lf0
        L12c:
            long r3 = (long) r0
            goto L3d
        L131:
            int r9 = r9 + r0
            goto L1ca
        L136:
            int r9 = r9.position
            goto La
        L13c:
            int r0 = PEVoMoVmmCElsyYW(r8)
            goto L16b
        L144:
            goto L158
        L147:
            goto Lb9
        L14b:
            int r1 = r8.fileLength
        L14d:
            goto L174
        L151:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r8.last
            goto L105
        L157:
            return
        L158:
            goto L1b2
        L15c:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r8.first
            goto Le5
        L162:
            if (r9 == 0) goto L167
            goto Ld0
        L167:
            goto Lcf
        L16b:
            if (r0 >= r9) goto L170
            goto L1c0
        L170:
            goto L1bf
        L174:
            int r0 = r0 + r1
            goto L57
        L179:
            int r9 = r9 + (-16)
            goto L37
        L17f:
            OJZETEwDaGrwXkWM(r8, r1, r0, r2, r9)
            goto L186
        L186:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$Element
            goto L117
        L18c:
            int r0 = r0 + r1
            goto L10
        L192:
            r8.last = r0
            goto L1f
        L198:
            int r2 = r2.position
            goto L17f
        L19e:
            long r2 = MAjFAxsmbJUWGTPC(r2, r3, r5, r7)
            goto L1c4
        L1a6:
            long r5 = (long) r9
            goto L6a
        L1ab:
            r0 = 29
            goto L5d
        L1b2:
            goto L147
        L1b5:
            goto L123
        L1b9:
            int r9 = r8.elementCount
            goto L15c
        L1bf:
            return
        L1c0:
            goto L14b
        L1c4:
            int r9 = (r2 > r5 ? 1 : (r2 == r5 ? 0 : -1))
            goto L162
        L1ca:
            int r9 = sFOSfMtZQnSJGZAt(r8, r9)
            goto L70
    }

    private void ExpandIfNecessary(int r1, byte r2, short r3, char r4, bool r5) {
            r0 = this;
            goto La
        L4:
            int r2 = r0 * r1
            goto L11
        La:
            goto L2c
        Ld:
            goto L20
        L11:
            int r3 = r2 + r1
            goto L26
        L17:
            goto Ld
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            r0 = 42
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    private void ExpandIfNecessary(int r1, byte r2, bool r3, short r4, char r5) {
            r0 = this;
            goto L1f
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L4
        L16:
            goto L22
        L19:
            r0 = 42
            goto La
        L1f:
            goto L2c
        L22:
            goto L19
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L16
    }

    private void ExpandIfNecessary(int r1, char r2, bool r3, byte r4, short r5) {
            r0 = this;
            goto L29
        L4:
            r0 = 42
            goto L16
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L24
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1c:
            goto L2c
        L1f:
            return
        L20:
            goto L1c
        L24:
            double r0 = (double) r3
            goto L1f
        L29:
            goto L20
        L2c:
            goto L4
    }

    public static java.lang.string FIqPLJLHlbvqScjA(java.io.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = r1.getPath()
            goto Lb
        L18:
            goto L7
    }

    public static void FIqPLJLHlbvqScjA(java.io.string r0, byte r1, int r2, short r3, bool r4) {
            goto L1a
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L2d
        L1a:
            goto L16
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L4
        L27:
            int r2 = r0 * r1
            goto La
        L2d:
            goto L1d
    }

    public static void FIqPLJLHlbvqScjA(java.io.string r0, int r1, short r2, bool r3, byte r4) {
            goto L18
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L1b
        Ld:
            int r3 = r2 + r1
            goto L1f
        L13:
            return
        L14:
            goto La
        L18:
            goto L14
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto L13
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    public static void FIqPLJLHlbvqScjA(java.io.string r0, short r1, bool r2, int r3, byte r4) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L14
        Ld:
            goto L1a
        L10:
            goto L24
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L4
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static java.nio.channels.stringChannel FfeJRBVLsUDSJtXr(java.io.RandomAccessstring r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.nio.channels.stringChannel r0 = r1.getChannel()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void FfeJRBVLsUDSJtXr(java.io.RandomAccessstring r0, int r1, float r2, short r3, java.lang.string r4) {
            goto L17
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        Lf:
            goto L1a
        L12:
            return
        L13:
            goto Lf
        L17:
            goto L13
        L1a:
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L9
    }

    public static void FfeJRBVLsUDSJtXr(java.io.RandomAccessstring r0, int r1, java.lang.string r2, float r3, short r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L2c
        Ld:
            goto L1f
        L11:
            double r0 = (double) r3
            goto L2b
        L16:
            goto Ld
        L19:
            int r3 = r2 + r1
            goto L11
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2b:
            return
        L2c:
            goto L16
    }

    public static void FfeJRBVLsUDSJtXr(java.io.RandomAccessstring r0, java.lang.string r1, short r2, float r3, int r4) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            goto L1d
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L21
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            goto Lc
        L2a:
            r0 = 42
            goto L10
    }

    public static int FwliNxadmRSuGaBV(byte[] r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = readInt(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void FwliNxadmRSuGaBV(byte[] r0, int r1, char r2, int r3, java.lang.string r4, float r5) {
            goto L1c
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L10:
            r0 = 42
            goto La
        L16:
            int r2 = r0 * r1
            goto L4
        L1c:
            goto L2c
        L1f:
            goto L10
        L23:
            goto L1f
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void FwliNxadmRSuGaBV(byte[] r0, int r1, float r2, int r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L2c
        L17:
            int r2 = r0 * r1
            goto L9
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            r0 = 42
            goto L1d
        L29:
            goto L10
        L2c:
            goto L23
    }

    public static void FwliNxadmRSuGaBV(byte[] r0, int r1, java.lang.string r2, float r3, char r4, int r5) {
            goto L1e
        L4:
            goto L21
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L2b
        L12:
            r0 = 42
            goto L25
        L18:
            int r2 = r0 * r1
            goto Lc
        L1e:
            goto L8
        L21:
            goto L12
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void FxLJqcdURBGJnslH(java.io.RandomAccessstring r0, long r1) {
            goto Le
        L4:
            r0.seek(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void FxLJqcdURBGJnslH(java.io.RandomAccessstring r0, long r1, java.lang.string r3, bool r4, byte r5, short r6) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L16
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r0 = 42
            goto Lb
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r3 = r2 + r1
            goto L11
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L7
    }

    public static void FxLJqcdURBGJnslH(java.io.RandomAccessstring r0, long r1, short r3, bool r4, byte r5, java.lang.string r6) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L27
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            return
        L14:
            goto La
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L1e:
            r0 = 42
            goto L18
        L24:
            goto L14
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void FxLJqcdURBGJnslH(java.io.RandomAccessstring r0, long r1, bool r3, short r4, java.lang.string r5, byte r6) {
            goto L29
        L4:
            r0 = 42
            goto L23
        La:
            goto L2c
        Ld:
            return
        Le:
            goto La
        L12:
            int r3 = r2 + r1
            goto L18
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r2 = r0 * r1
            goto L12
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto Le
        L2c:
            goto L4
    }

    public static java.lang.stringBuilder GfIcgMftSokrTEjW(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static void GfIcgMftSokrTEjW(java.lang.stringBuilder r0, java.lang.string r1, char r2, int r3, float r4, java.lang.string r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            goto L2c
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L20
        L17:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L26
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L17
    }

    public static void GfIcgMftSokrTEjW(java.lang.stringBuilder r0, java.lang.string r1, char r2, java.lang.string r3, int r4, float r5) {
            goto L13
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L1a
        L10:
            goto L16
        L13:
            goto L26
        L16:
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L20
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void GfIcgMftSokrTEjW(java.lang.stringBuilder r0, java.lang.string r1, int r2, float r3, java.lang.string r4, char r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L21
        La:
            goto L14
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L14:
            r0 = 42
            goto Le
        L1a:
            int r3 = r2 + r1
            goto L25
        L20:
            return
        L21:
            goto L4
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            int r2 = r0 * r1
            goto L1a
    }

    public static void HdoUJrrvChbsICJw(java.io.RandomAccessstring r0, long r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.seek(r1)
            goto Le
    }

    public static void HdoUJrrvChbsICJw(java.io.RandomAccessstring r0, long r1, char r3, float r4, java.lang.string r5, short r6) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            r0 = 42
            goto L2a
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto La
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void HdoUJrrvChbsICJw(java.io.RandomAccessstring r0, long r1, char r3, short r4, float r5, java.lang.string r6) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r2 = r0 * r1
            goto L25
        L15:
            goto L2c
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            r0 = 42
            goto L4
        L25:
            int r3 = r2 + r1
            goto La
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void HdoUJrrvChbsICJw(java.io.RandomAccessstring r0, long r1, short r3, float r4, java.lang.string r5, char r6) {
            goto L26
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L2d
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto L9
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            goto L10
        L29:
            goto L14
        L2d:
            goto L29
    }

    public static void IJIZDNbLxgiYOVxP(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, char r1, float r2, java.lang.string r3, byte r4) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L1f
        La:
            goto L12
        Ld:
            goto L16
        L11:
            return
        L12:
            goto L1c
        L16:
            r0 = 42
            goto L24
        L1c:
            goto Ld
        L1f:
            double r0 = (double) r3
            goto L11
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    public static void IJIZDNbLxgiYOVxP(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, float r1, byte r2, char r3, java.lang.string r4) {
            goto Ld
        L4:
            r0 = 42
            goto L25
        La:
            goto L10
        Ld:
            goto L15
        L10:
            goto L4
        L14:
            return
        L15:
            goto La
        L19:
            int r3 = r2 + r1
            goto L2b
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L14
    }

    public static void IJIZDNbLxgiYOVxP(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, float r1, java.lang.string r2, byte r3, char r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto L22
        L1c:
            int r3 = r2 + r1
            goto L10
        L22:
            r0 = 42
            goto La
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    public static bool IJIZDNbLxgiYOVxP(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
            goto L11
        L4:
            bool r0 = r1.Count == 0
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static com.google.firebase.crashlytics.internal.metadata.Queuestring.Element ILeXzwqwrhLSIMCu(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto L14
        L4:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r1.readElement(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void ILeXzwqwrhLSIMCu(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, int r3, float r4, bool r5) {
            goto L17
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            r0 = 42
            goto L24
        Lf:
            goto L1a
        L12:
            return
        L13:
            goto Lf
        L17:
            goto L13
        L1a:
            goto L9
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void ILeXzwqwrhLSIMCu(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, bool r3, float r4, int r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        La:
            goto L2c
        Ld:
            goto L17
        L11:
            int r2 = r0 * r1
            goto L25
        L17:
            r0 = 42
            goto L4
        L1d:
            double r0 = (double) r3
            goto L2b
        L22:
            goto Ld
        L25:
            int r3 = r2 + r1
            goto L1d
        L2b:
            return
        L2c:
            goto L22
    }

    public static void ILeXzwqwrhLSIMCu(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, bool r2, float r3, int r4, java.lang.string r5) {
            goto L29
        L4:
            return
        L5:
            goto L14
        L9:
            r0 = 42
            goto L23
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L2c
        L17:
            int r2 = r0 * r1
            goto L1d
        L1d:
            int r3 = r2 + r1
            goto Lf
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L29:
            goto L5
        L2c:
            goto L9
    }

    public static void IVoRSoDhfxaVjBDp(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.forEach(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void IVoRSoDhfxaVjBDp(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r1, byte r2, char r3, int r4, bool r5) {
            goto L4
        L4:
            goto L1a
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L24
        L11:
            double r0 = (double) r3
            goto L19
        L16:
            goto L7
        L19:
            return
        L1a:
            goto L16
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void IVoRSoDhfxaVjBDp(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r1, int r2, char r3, bool r4, byte r5) {
            goto La
        L4:
            r0 = 42
            goto L24
        La:
            goto L1a
        Ld:
            goto L4
        L11:
            goto Ld
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L11
        L1e:
            int r2 = r0 * r1
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L2a:
            int r3 = r2 + r1
            goto L14
    }

    public static void IVoRSoDhfxaVjBDp(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r1, bool r2, char r3, int r4, byte r5) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L12
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L1b
        L12:
            int r3 = r2 + r1
            goto La
        L18:
            goto L2c
        L1b:
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            r0 = 42
            goto L1f
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void IauzQntjXwhRZWJo(java.io.RandomAccessstring r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.Dispose()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void IauzQntjXwhRZWJo(java.io.RandomAccessstring r0, float r1, short r2, int r3, bool r4) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L20
        La:
            r0 = 42
            goto L10
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            goto L2c
        L19:
            goto La
        L1d:
            goto L19
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L1d
    }

    public static void IauzQntjXwhRZWJo(java.io.RandomAccessstring r0, float r1, bool r2, short r3, int r4) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto L21
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            r0 = 42
            goto L15
        L21:
            double r0 = (double) r3
            goto La
        L26:
            goto Lb
        L29:
            goto L1b
        L2d:
            goto L29
    }

    public static void IauzQntjXwhRZWJo(java.io.RandomAccessstring r0, int r1, short r2, bool r3, float r4) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        La:
            int r3 = r2 + r1
            goto L25
        L10:
            goto L21
        L13:
            goto L2a
        L17:
            int r2 = r0 * r1
            goto La
        L1d:
            goto L13
        L20:
            return
        L21:
            goto L1d
        L25:
            double r0 = (double) r3
            goto L20
        L2a:
            r0 = 42
            goto L4
    }

    private static void Initialize(java.io.string r5) throws java.io.IOException {
            goto Ld4
        L4:
            java.io.string r0 = new java.io.string
            goto L39
        La:
            throw r5
        Lb:
            goto Lbc
        Lf:
            bool r5 = UhjuRXmOgucspgYw(r0, r5)
            goto Lc3
        L17:
            goto Ld7
        L1a:
            r2 = 4096(0x1000, double:2.0237E-320)
            yKPLISvzqPbOCosy(r1, r2)     // Catch: java.lang.Exception -> L6c
            r2 = 0
            OaeJCECVaQNLTWlu(r1, r2)     // Catch: java.lang.Exception -> L6c
            r2 = 16
            byte[] r2 = new byte[r2]     // Catch: java.lang.Exception -> L6c
            r3 = 0
            r4 = 4096(0x1000, float:5.74E-42)
            int[] r3 = new int[]{r4, r3, r3, r3}     // Catch: java.lang.Exception -> L6c
            aKRsCDrosrjTancB(r2, r3)     // Catch: java.lang.Exception -> L6c
            POpAbLmTgRqMfySi(r1, r2)     // Catch: java.lang.Exception -> L6c
            goto Lb5
        L39:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L3f
        L3f:
            r1.<init>()
            goto L79
        L46:
            java.lang.string r2 = ".tmp"
            goto L91
        L4c:
            java.io.IOException r5 = new java.io.IOException
            goto L52
        L52:
            java.lang.string r0 = "Rename failed!"
            goto L99
        L58:
            r1 = 15
            goto La8
        L5f:
            iauzQntjXwhRZWJo(r1)
            goto La
        L66:
            return
        L67:
            goto L4c
        L6b:
            throw r5
        L6c:
            r5 = move-exception
            goto L5f
        L71:
            java.io.RandomAccessstring r1 = ObfJCcoRsAiXNYIv(r0)
            goto L1a
        L79:
            java.lang.string r2 = fIqPLJLHlbvqScjA(r5)
            goto La0
        L81:
            goto Lb
        L84:
            goto L4
        L88:
            if (r0 <= 0) goto L8d
            goto L84
        L8d:
            goto L81
        L91:
            java.lang.stringBuilder r1 = XfuXatpxPLpAWiiU(r1, r2)
            goto Lcc
        L99:
            r5.<init>(r0)
            goto L6b
        La0:
            java.lang.stringBuilder r1 = rwFvbItIvTjfprxC(r1, r2)
            goto L46
        La8:
            int r0 = r0 + r1
            goto Le2
        Lae:
            r0.<init>(r1)
            goto L71
        Lb5:
            LiFHZiTUIxWaOCuN(r1)
            goto Lf
        Lbc:
            goto L84
        Lbf:
            goto L17
        Lc3:
            if (r5 != 0) goto Lc8
            goto L67
        Lc8:
            goto L66
        Lcc:
            java.lang.string r1 = nIFCdjXdTCCOTDYr(r1)
            goto Lae
        Ld4:
            goto Lbf
        Ld7:
            goto Ldb
        Ldb:
            r0 = 3
            goto L58
        Le2:
            int r0 = r0 % r1
            goto L88
    }

    private static void Initialize(java.io.string r0, float r1, short r2, java.lang.string r3, char r4) {
            goto L4
        L4:
            goto L20
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L1f
        L10:
            goto L7
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L19:
            int r3 = r2 + r1
            goto Lb
        L1f:
            return
        L20:
            goto L10
        L24:
            int r2 = r0 * r1
            goto L19
        L2a:
            r0 = 42
            goto L13
    }

    private static void Initialize(java.io.string r0, java.lang.string r1, char r2, float r3, short r4) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L10
        Ld:
            goto L20
        L10:
            goto L2a
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto La
        L24:
            int r2 = r0 * r1
            goto L4
        L2a:
            r0 = 42
            goto L14
    }

    private static void Initialize(java.io.string r0, java.lang.string r1, short r2, char r3, float r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto L27
        Lb:
            int r2 = r0 * r1
            goto L21
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L2d
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L21:
            int r3 = r2 + r1
            goto L11
        L27:
            r0 = 42
            goto L1b
        L2d:
            goto L7
    }

    public static int JAetluXPuLxjLcwc(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto Lc
        L4:
            int r0 = r1.wrapPosition(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void JAetluXPuLxjLcwc(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, char r3, int r4, java.lang.string r5) {
            goto L1c
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            int r3 = r2 + r1
            goto L26
        L1c:
            goto L2c
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L23
    }

    public static void JAetluXPuLxjLcwc(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, byte r3, java.lang.string r4, char r5) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        La:
            goto L16
        Ld:
            r0 = 42
            goto L4
        L13:
            goto L27
        L16:
            goto Ld
        L1a:
            int r2 = r0 * r1
            goto L20
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void JAetluXPuLxjLcwc(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, char r3, byte r4, java.lang.string r5) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L1e
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            double r0 = (double) r3
            goto L7
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void JBhLIgTyVhNnKHst(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.ringWrite(r1, r2, r3, r4)
            goto L4
    }

    public static void JBhLIgTyVhNnKHst(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, char r5, byte r6, float r7, short r8) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            return
        Lb:
            goto L2d
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            int r3 = r2 + r1
            goto L1c
        L27:
            r0 = 42
            goto Lf
        L2d:
            goto L18
    }

    public static void JBhLIgTyVhNnKHst(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, short r5, char r6, float r7, byte r8) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L17
        La:
            goto L26
        Ld:
            goto L2a
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            int r3 = r2 + r1
            goto L20
        L1d:
            goto Ld
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto L1d
        L2a:
            r0 = 42
            goto L11
    }

    public static void JBhLIgTyVhNnKHst(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, short r5, float r6, byte r7, char r8) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L19
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            r0 = 42
            goto L24
        L1f:
            double r0 = (double) r3
            goto Lb
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static java.lang.stringBuilder JeoImixzbXezNhfL(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static void JeoImixzbXezNhfL(java.lang.stringBuilder r0, java.lang.string r1, char r2, int r3, bool r4, short r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            goto L23
        Lc:
            goto L1c
        L10:
            int r3 = r2 + r1
            goto L4
        L16:
            int r2 = r0 * r1
            goto L10
        L1c:
            r0 = 42
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L2d:
            goto Lc
    }

    public static void JeoImixzbXezNhfL(java.lang.stringBuilder r0, java.lang.string r1, int r2, bool r3, short r4, char r5) {
            goto Ld
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L2a
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L14
        L25:
            return
        L26:
            goto La
        L2a:
            r0 = 42
            goto L4
    }

    public static void JeoImixzbXezNhfL(java.lang.stringBuilder r0, java.lang.string r1, short r2, int r3, bool r4, char r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L2a
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto Lb
        L2a:
            r0 = 42
            goto L13
    }

    public static java.lang.stringBuilder JhjgdnufiVJlESNs(java.lang.stringBuilder r1, int r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static void JhjgdnufiVJlESNs(java.lang.stringBuilder r0, int r1, java.lang.string r2, char r3, short r4, bool r5) {
            goto L18
        L4:
            goto L1b
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L1f
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L18:
            goto L8
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto L7
        L24:
            r0 = 42
            goto L12
        L2a:
            int r2 = r0 * r1
            goto Lc
    }

    public static void JhjgdnufiVJlESNs(java.lang.stringBuilder r0, int r1, java.lang.string r2, short r3, bool r4, char r5) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            goto L18
        L13:
            goto La
        L17:
            return
        L18:
            goto L21
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            goto L13
        L24:
            int r3 = r2 + r1
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void JhjgdnufiVJlESNs(java.lang.stringBuilder r0, int r1, bool r2, short r3, char r4, java.lang.string r5) {
            goto L21
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            double r0 = (double) r3
            goto L2b
        L1b:
            r0 = 42
            goto L10
        L21:
            goto L2c
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static com.google.firebase.crashlytics.internal.metadata.Queuestring.Element JnQfeHzNfKXEPQVf(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r1.readElement(r2)
            goto L7
    }

    public static void JnQfeHzNfKXEPQVf(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, float r3, bool r4, char r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1b
        L10:
            r0 = 42
            goto L4
        L16:
            double r0 = (double) r3
            goto L24
        L1b:
            int r3 = r2 + r1
            goto L16
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L10
    }

    public static void JnQfeHzNfKXEPQVf(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, bool r2, float r3, char r4, java.lang.string r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r2 = r0 * r1
            goto L25
        Ld:
            r0 = 42
            goto L13
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L19:
            double r0 = (double) r3
            goto L2b
        L1e:
            goto L2c
        L21:
            goto Ld
        L25:
            int r3 = r2 + r1
            goto L19
        L2b:
            return
        L2c:
            goto L4
    }

    public static void JnQfeHzNfKXEPQVf(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, bool r2, java.lang.string r3, char r4, float r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L1b
        La:
            goto L25
        Le:
            int r3 = r2 + r1
            goto L2b
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            return
        L1b:
            goto L4
        L1f:
            int r2 = r0 * r1
            goto Le
        L25:
            r0 = 42
            goto L14
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static int KYklQjxGZJysTHDH(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto Lc
        L4:
            int r0 = r1.wrapPosition(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void KYklQjxGZJysTHDH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte r2, short r3, char r4, java.lang.string r5) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L24
        Lb:
            int r2 = r0 * r1
            goto L11
        L11:
            int r3 = r2 + r1
            goto L1f
        L17:
            goto L7
        L1a:
            return
        L1b:
            goto L17
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void KYklQjxGZJysTHDH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, java.lang.string r3, byte r4, short r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            goto L26
        Lc:
            goto L1f
        L10:
            goto Lc
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            r0 = 42
            goto L13
        L25:
            return
        L26:
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void KYklQjxGZJysTHDH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, java.lang.string r3, short r4, byte r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L17
        Ld:
            goto L24
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto Ld
        L1e:
            int r3 = r2 + r1
            goto L11
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static java.lang.stringBuilder KaPLCFMDsXzYZaTx(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void KaPLCFMDsXzYZaTx(java.lang.stringBuilder r0, java.lang.string r1, byte r2, short r3, float r4, java.lang.string r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L1b
        Ld:
            goto L25
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L17:
            goto Ld
        L1a:
            return
        L1b:
            goto L17
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            r0 = 42
            goto L11
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void KaPLCFMDsXzYZaTx(java.lang.stringBuilder r0, java.lang.string r1, float r2, java.lang.string r3, byte r4, short r5) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            return
        Lb:
            goto L20
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L20:
            goto L26
        L23:
            goto Lb
        L26:
            goto L14
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void KaPLCFMDsXzYZaTx(java.lang.stringBuilder r0, java.lang.string r1, short r2, float r3, java.lang.string r4, byte r5) {
            goto L1d
        L4:
            goto L20
        L7:
            int r2 = r0 * r1
            goto L24
        Ld:
            double r0 = (double) r3
            goto L12
        L12:
            return
        L13:
            goto L4
        L17:
            r0 = 42
            goto L2a
        L1d:
            goto L13
        L20:
            goto L17
        L24:
            int r3 = r2 + r1
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
    }

    public static java.lang.stringBuilder LeTWSzCMnzPsWSAw(java.lang.stringBuilder r1, int r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static void LeTWSzCMnzPsWSAw(java.lang.stringBuilder r0, int r1, float r2, bool r3, char r4, java.lang.string r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L22
        Lb:
            return
        Lc:
            goto L2d
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L1c
        L1c:
            int r3 = r2 + r1
            goto L28
        L22:
            r0 = 42
            goto L10
        L28:
            double r0 = (double) r3
            goto Lb
        L2d:
            goto L7
    }

    public static void LeTWSzCMnzPsWSAw(java.lang.stringBuilder r0, int r1, java.lang.string r2, bool r3, char r4, float r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            goto L1d
        Ld:
            goto L27
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L11
        L1c:
            return
        L1d:
            goto L2d
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L27:
            r0 = 42
            goto L21
        L2d:
            goto Ld
    }

    public static void LeTWSzCMnzPsWSAw(java.lang.stringBuilder r0, int r1, bool r2, float r3, char r4, java.lang.string r5) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            goto L17
        Ld:
            goto L1b
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L27
        L1b:
            r0 = 42
            goto L4
        L21:
            int r2 = r0 * r1
            goto L2a
        L27:
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L11
    }

    public static void MHobsFMnYUqhtjjU(com.google.firebase.crashlytics.internal.metadata.Queuestring r0) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.readHeader()
            goto L7
    }

    public static void MHobsFMnYUqhtjjU(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, char r2, int r3, java.lang.string r4) {
            goto L18
        L4:
            r0 = 42
            goto L12
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1b
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L18:
            goto Lb
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            int r2 = r0 * r1
            goto L1f
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void MHobsFMnYUqhtjjU(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, char r1, byte r2, int r3, java.lang.string r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            return
        Lb:
            goto L28
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L1b:
            goto Lb
        L1e:
            goto L22
        L22:
            r0 = 42
            goto L15
        L28:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void MHobsFMnYUqhtjjU(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, java.lang.string r1, int r2, byte r3, char r4) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            int r2 = r0 * r1
            goto L1a
        L14:
            r0 = 42
            goto L20
        L1a:
            int r3 = r2 + r1
            goto L4
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L26:
            goto La
        L29:
            goto L14
        L2d:
            goto L29
    }

    public static void MZuKtLOEhnJxpSlM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.ringRead(r1, r2, r3, r4)
            goto L4
    }

    public static void MZuKtLOEhnJxpSlM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, byte r5, char r6, bool r7, java.lang.string r8) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            goto L2c
        Ld:
            r0 = 42
            goto L4
        L13:
            double r0 = (double) r3
            goto L24
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            return
        L25:
            goto La
        L29:
            goto L25
        L2c:
            goto Ld
    }

    public static void MZuKtLOEhnJxpSlM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, byte r5, java.lang.string r6, bool r7, char r8) {
            goto Lf
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L21
        Lf:
            goto L5
        L12:
            goto L27
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L21:
            int r3 = r2 + r1
            goto L16
        L27:
            r0 = 42
            goto L1b
        L2d:
            goto L12
    }

    public static void MZuKtLOEhnJxpSlM(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, byte r5, bool r6, java.lang.string r7, char r8) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            double r0 = (double) r3
            goto L1b
        Lf:
            r0 = 42
            goto L4
        L15:
            int r2 = r0 * r1
            goto L20
        L1b:
            return
        L1c:
            goto L26
        L20:
            int r3 = r2 + r1
            goto La
        L26:
            goto L2c
        L29:
            goto L1c
        L2c:
            goto Lf
    }

    public static java.lang.string NIFCdjXdTCCOTDYr(java.lang.stringBuilder r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.string r0 = r1.tostring()
            goto L4
    }

    public static void NIFCdjXdTCCOTDYr(java.lang.stringBuilder r0, int r1, float r2, short r3, bool r4) {
            goto Lf
        L4:
            return
        L5:
            goto L1b
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Lf:
            goto L5
        L12:
            goto L1e
        L16:
            double r0 = (double) r3
            goto L4
        L1b:
            goto L12
        L1e:
            r0 = 42
            goto L9
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static void NIFCdjXdTCCOTDYr(java.lang.stringBuilder r0, int r1, bool r2, float r3, short r4) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            r0 = 42
            goto L4
        L21:
            goto L2c
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static void NIFCdjXdTCCOTDYr(java.lang.stringBuilder r0, bool r1, float r2, int r3, short r4) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L21
        L13:
            goto L25
        L17:
            goto L13
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            return
        L21:
            goto L17
        L25:
            r0 = 42
            goto La
        L2b:
            double r0 = (double) r3
            goto L20
    }

    private static <T> T NonNull(T r0, java.lang.string r1) {
            goto Lb
        L4:
            r0.<init>(r1)
            goto L29
        Lb:
            goto L2a
        Le:
            goto L12
        L12:
            if (r0 != 0) goto L17
            goto L1c
        L17:
            goto L1b
        L1b:
            return r0
        L1c:
            goto L23
        L20:
            goto Le
        L23:
            java.lang.NullPointerException r0 = new java.lang.NullPointerException
            goto L4
        L29:
            throw r0
        L2a:
            goto L20
    }

    private static void NonNull(java.lang.object r0, java.lang.string r1, float r2, short r3, java.lang.string r4, bool r5) {
            goto Lf
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            return
        Lb:
            goto L16
        Lf:
            goto Lb
        L12:
            goto L19
        L16:
            goto L12
        L19:
            r0 = 42
            goto L4
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    private static void NonNull(java.lang.object r0, java.lang.string r1, java.lang.string r2, short r3, float r4, bool r5) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L20
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L2d
        L1a:
            r0 = 42
            goto L4
        L20:
            int r3 = r2 + r1
            goto L10
        L26:
            goto L16
        L29:
            goto L1a
        L2d:
            goto L29
    }

    private static void NonNull(java.lang.object r0, java.lang.string r1, java.lang.string r2, bool r3, float r4, short r5) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1a
        L10:
            return
        L11:
            goto L20
        L15:
            double r0 = (double) r3
            goto L10
        L1a:
            int r3 = r2 + r1
            goto L15
        L20:
            goto L26
        L23:
            goto L11
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L4
    }

    public static void OfdFIGzalwRxqtTC(java.io.RandomAccessstring r0, long r1) {
            goto Lb
        L4:
            r0.seek(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void OfdFIGzalwRxqtTC(java.io.RandomAccessstring r0, long r1, int r3, char r4, short r5, java.lang.string r6) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L25
        L10:
            goto L16
        L13:
            goto L21
        L16:
            goto La
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            return
        L21:
            goto L10
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void OfdFIGzalwRxqtTC(java.io.RandomAccessstring r0, long r1, java.lang.string r3, int r4, char r5, short r6) {
            goto L16
        L4:
            r0 = 42
            goto L25
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            goto L21
        L19:
            goto L4
        L1d:
            goto L19
        L20:
            return
        L21:
            goto L1d
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void OfdFIGzalwRxqtTC(java.io.RandomAccessstring r0, long r1, short r3, java.lang.string r4, int r5, char r6) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L1f
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return
        L15:
            goto L4
        L19:
            int r3 = r2 + r1
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            int r2 = r0 * r1
            goto L19
    }

    private static java.io.RandomAccessstring Open(java.io.string r2) throws java.io.stringNotFoundException {
            goto L2d
        L4:
            goto Le
        L7:
            goto L2a
        Lb:
            goto L26
        Le:
            goto L34
        L12:
            r0.<init>(r2, r1)
            goto L25
        L19:
            int r0 = r0 % r1
            goto L4e
        L1f:
            java.lang.string r1 = "rwd"
            goto L12
        L25:
            return r0
        L26:
            goto L4
        L2a:
            goto L30
        L2d:
            goto L7
        L30:
            goto L3a
        L34:
            java.io.RandomAccessstring r0 = new java.io.RandomAccessstring
            goto L1f
        L3a:
            r0 = 16
            goto L47
        L41:
            int r0 = r0 + r1
            goto L19
        L47:
            r1 = 21
            goto L41
        L4e:
            if (r0 <= 0) goto L53
            goto Le
        L53:
            goto Lb
    }

    private static void Open(java.io.string r0, char r1, int r2, byte r3, float r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L23
        Ld:
            goto L1c
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            r0 = 42
            goto L11
        L22:
            return
        L23:
            goto L27
        L27:
            goto Ld
        L2a:
            int r3 = r2 + r1
            goto L17
    }

    private static void Open(java.io.string r0, float r1, char r2, byte r3, int r4) {
            goto L15
        L4:
            r0 = 42
            goto L1c
        La:
            int r2 = r0 * r1
            goto L22
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            goto L2c
        L18:
            goto L4
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L22:
            int r3 = r2 + r1
            goto L10
        L28:
            goto L18
        L2b:
            return
        L2c:
            goto L28
    }

    private static void Open(java.io.string r0, int r1, byte r2, float r3, char r4) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        La:
            int r3 = r2 + r1
            goto L21
        L10:
            return
        L11:
            goto L2d
        L15:
            r0 = 42
            goto L4
        L1b:
            int r2 = r0 * r1
            goto La
        L21:
            double r0 = (double) r3
            goto L10
        L26:
            goto L11
        L29:
            goto L15
        L2d:
            goto L29
    }

    public static void QBGFZDWfspSBwMVE(java.io.RandomAccessstring r0, long r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.seek(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static void QBGFZDWfspSBwMVE(java.io.RandomAccessstring r0, long r1, int r3, float r4, java.lang.string r5, byte r6) {
            goto L20
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        Lf:
            return
        L10:
            goto L27
        L14:
            r0 = 42
            goto L9
        L1a:
            int r2 = r0 * r1
            goto L2a
        L20:
            goto L10
        L23:
            goto L14
        L27:
            goto L23
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void QBGFZDWfspSBwMVE(java.io.RandomAccessstring r0, long r1, int r3, java.lang.string r4, byte r5, float r6) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto Ld
        La:
            goto L21
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            goto L26
        L21:
            goto L2a
        L25:
            return
        L26:
            goto La
        L2a:
            r0 = 42
            goto L12
    }

    public static void QBGFZDWfspSBwMVE(java.io.RandomAccessstring r0, long r1, java.lang.string r3, byte r4, float r5, int r6) {
            goto L15
        L4:
            return
        L5:
            goto L27
        L9:
            r0 = 42
            goto L21
        Lf:
            int r3 = r2 + r1
            goto L1c
        L15:
            goto L5
        L18:
            goto L9
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L27:
            goto L18
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static int QEiuQQDBXRnoBaeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.wrapPosition(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void QEiuQQDBXRnoBaeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, float r3, bool r4, java.lang.string r5) {
            goto L29
        L4:
            goto L2c
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L1d
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L18:
            double r0 = (double) r3
            goto L7
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            r0 = 42
            goto L12
        L29:
            goto L8
        L2c:
            goto L23
    }

    public static void QEiuQQDBXRnoBaeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, java.lang.string r3, bool r4, float r5) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            goto L21
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto L18
        L2b:
            return
        L2c:
            goto L15
    }

    public static void QEiuQQDBXRnoBaeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, float r3, bool r4, char r5) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Ld:
            goto L1b
        L10:
            goto L25
        L14:
            int r2 = r0 * r1
            goto L1f
        L1a:
            return
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r0 = 42
            goto L7
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    public static void QLkFSEEQACdOMniX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.writeHeader(r1, r2, r3, r4)
            goto Le
    }

    public static void QLkFSEEQACdOMniX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, char r5, int r6, byte r7, bool r8) {
            goto L1d
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L10:
            goto L20
        L13:
            return
        L14:
            goto L10
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L4
        L24:
            int r3 = r2 + r1
            goto L18
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void QLkFSEEQACdOMniX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, char r5, bool r6, byte r7, int r8) {
            goto Lc
        L4:
            goto Lf
        L7:
            double r0 = (double) r3
            goto L2b
        Lc:
            goto L2c
        Lf:
            goto L1f
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L19:
            int r3 = r2 + r1
            goto L7
        L1f:
            r0 = 42
            goto L13
        L25:
            int r2 = r0 * r1
            goto L19
        L2b:
            return
        L2c:
            goto L4
    }

    public static void QLkFSEEQACdOMniX(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, int r5, char r6, bool r7, byte r8) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L14
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto L26
        L17:
            int r2 = r0 * r1
            goto Le
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L23:
            goto La
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    public static void QyansnDjDmWUrIdi(java.io.string r0, byte r1, short r2, float r3, int r4) {
            goto L7
        L4:
            goto La
        L7:
            goto L26
        La:
            goto L2a
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L14
        L25:
            return
        L26:
            goto L4
        L2a:
            r0 = 42
            goto Le
    }

    public static void QyansnDjDmWUrIdi(java.io.string r0, short r1, byte r2, int r3, float r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L25
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            int r3 = r2 + r1
            goto L2b
        L1d:
            return
        L1e:
            goto L22
        L22:
            goto L7
        L25:
            r0 = 42
            goto L11
        L2b:
            double r0 = (double) r3
            goto L1d
    }

    public static void QyansnDjDmWUrIdi(java.io.string r0, short r1, float r2, byte r3, int r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            r0 = 42
            goto L21
        Lf:
            goto L1d
        L12:
            goto L9
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            return
        L1d:
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static bool QyansnDjDmWUrIdi(java.io.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.exists()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    private com.google.firebase.crashlytics.internal.metadata.Queuestring.Element ReadElement(int r4) throws java.io.IOException {
            r3 = this;
            goto L6c
        L4:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r3 = com.google.firebase.crashlytics.internal.metadata.Queuestring.Element.NULL
            goto L79
        La:
            goto L37
        Ld:
            goto L3b
        L11:
            int r0 = r0 + r1
            goto L5a
        L17:
            java.io.RandomAccessstring r3 = r3.raf
            goto L4b
        L1d:
            goto Ld
        L20:
            goto L33
        L24:
            java.io.RandomAccessstring r0 = r3.raf
            goto L67
        L2a:
            if (r0 <= 0) goto L2f
            goto Ld
        L2f:
            goto La
        L33:
            goto L6f
        L36:
            return r0
        L37:
            goto L1d
        L3b:
            if (r4 == 0) goto L40
            goto L7a
        L40:
            goto L4
        L44:
            r1 = 32
            goto L11
        L4b:
            int r3 = PaFkgmPpRpkCPRuB(r3)
            goto L60
        L53:
            fxLJqcdURBGJnslH(r0, r1)
            goto L73
        L5a:
            int r0 = r0 % r1
            goto L2a
        L60:
            r0.<init>(r4, r3)
            goto L36
        L67:
            long r1 = (long) r4
            goto L53
        L6c:
            goto L20
        L6f:
            goto L7e
        L73:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$Element
            goto L17
        L79:
            return r3
        L7a:
            goto L24
        L7e:
            r0 = 1
            goto L44
    }

    private void ReadElement(int r1, char r2, byte r3, bool r4, short r5) {
            r0 = this;
            goto L4
        L4:
            goto L26
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            int r3 = r2 + r1
            goto L1a
        L14:
            int r2 = r0 * r1
            goto Le
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto Lb
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    private void ReadElement(int r1, short r2, char r3, bool r4, byte r5) {
            r0 = this;
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            return
        Lb:
            goto L2d
        Lf:
            r0 = 42
            goto L4
        L15:
            int r2 = r0 * r1
            goto L27
        L1b:
            goto Lb
        L1e:
            goto Lf
        L22:
            double r0 = (double) r3
            goto La
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L1e
    }

    private void ReadElement(int r1, bool r2, short r3, char r4, byte r5) {
            r0 = this;
            goto L1e
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L21
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L9
        L1e:
            goto L2c
        L21:
            goto L25
        L25:
            r0 = 42
            goto L12
        L2b:
            return
        L2c:
            goto Lf
    }

    private void ReadHeader() throws java.io.IOException {
            r4 = this;
            goto Lb6
        L4:
            java.io.RandomAccessstring r0 = r4.raf
            goto L10c
        La:
            r0.<init>(r4)
            goto Le8
        L11:
            if (r0 <= 0) goto L16
            goto L102
        L16:
            goto Lff
        L1a:
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto Ldf
        L20:
            int r0 = LZSykzEvVbdBJgUY(r0, r1)
            goto L147
        L28:
            java.lang.string r2 = ", Actual length: "
            goto L2e
        L2e:
            java.lang.stringBuilder r1 = kaPLCFMDsXzYZaTx(r1, r2)
            goto L106
        L36:
            java.lang.stringBuilder r1 = leTWSzCMnzPsWSAw(r1, r2)
            goto L28
        L3e:
            long r0 = (long) r0
            goto L52
        L43:
            r0 = 11
            goto L15a
        L4a:
            int r0 = vfQSPgMNXpOEafar(r0, r1)
            goto Lb0
        L52:
            java.io.RandomAccessstring r2 = r4.raf
            goto L86
        L58:
            java.lang.stringBuilder r4 = atFunqDAOjhjHKjl(r1, r2)
            goto L7e
        L60:
            goto L102
        L63:
            goto L9b
        L67:
            java.lang.string r2 = "string is truncated. Expected length: "
            goto L8e
        L6d:
            r1 = 4
            goto L20
        L72:
            int r2 = r4.fileLength
            goto L36
        L78:
            byte[] r0 = r4.buffer
            goto Ld4
        L7e:
            java.lang.string r4 = NUDfdleeGaSYgOIf(r4)
            goto La
        L86:
            long r2 = tiCQkZaeCGVHcATX(r2)
            goto L1a
        L8e:
            r1.<init>(r2)
            goto L72
        L95:
            java.io.IOException r0 = new java.io.IOException
            goto L120
        L9b:
            goto Lb9
        L9e:
            r4.last = r0
            goto L14d
        La4:
            byte[] r0 = r4.buffer
            goto Lf9
        Laa:
            byte[] r0 = r4.buffer
            goto L6d
        Lb0:
            r4.fileLength = r0
            goto L3e
        Lb6:
            goto L63
        Lb9:
            goto L43
        Lbd:
            long r2 = AjvfAZfzaOqsmAuS(r4)
            goto L58
        Lc5:
            IuIcHqptiqKrBFly(r0, r1)
            goto L78
        Lcc:
            int r1 = fwliNxadmRSuGaBV(r1, r2)
            goto L126
        Ld4:
            r1 = 0
            goto L4a
        Ld9:
            java.io.RandomAccessstring r0 = r4.raf
            goto L11a
        Ldf:
            if (r0 <= 0) goto Le4
            goto L14e
        Le4:
            goto Laa
        Le8:
            throw r0
        Le9:
            goto L60
        Led:
            int r0 = r0 + r1
            goto Lf3
        Lf3:
            int r0 = r0 % r1
            goto L11
        Lf9:
            r1 = 8
            goto L112
        Lff:
            goto Le9
        L102:
            goto Ld9
        L106:
            java.io.RandomAccessstring r4 = r4.raf
            goto Lbd
        L10c:
            byte[] r1 = r4.buffer
            goto Lc5
        L112:
            int r0 = FVyJAyYtFPDWlPLD(r0, r1)
            goto L13b
        L11a:
            r1 = 0
            goto L12e
        L120:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L67
        L126:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = jnQfeHzNfKXEPQVf(r4, r0)
            goto L141
        L12e:
            BSmJflKzgBDzhMgI(r0, r1)
            goto L4
        L135:
            r2 = 12
            goto Lcc
        L13b:
            byte[] r1 = r4.buffer
            goto L135
        L141:
            r4.first = r0
            goto L152
        L147:
            r4.elementCount = r0
            goto La4
        L14d:
            return
        L14e:
            goto L95
        L152:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = iLeXzwqwrhLSIMCu(r4, r1)
            goto L9e
        L15a:
            r1 = 9
            goto Led
    }

    private void ReadHeader(char r1, int r2, bool r3, java.lang.string r4) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0 = 42
            goto L1e
        L19:
            double r0 = (double) r3
            goto L7
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    private void ReadHeader(int r1, java.lang.string r2, bool r3, char r4) {
            r0 = this;
            goto L29
        L4:
            return
        L5:
            goto L1a
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r2 = r0 * r1
            goto L23
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto Le
        L1a:
            goto L2c
        L1d:
            r0 = 42
            goto L14
        L23:
            int r3 = r2 + r1
            goto L9
        L29:
            goto L5
        L2c:
            goto L1d
    }

    private void ReadHeader(int r1, bool r2, java.lang.string r3, char r4) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L16
        L9:
            goto L5
        Lc:
            goto L2a
        L10:
            int r2 = r0 * r1
            goto L24
        L16:
            goto Lc
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto L19
    }

    private static int ReadInt(byte[] r2, int r3) {
            goto L72
        L4:
            int r1 = r1 << 8
            goto L37
        La:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L4
        L10:
            goto L56
        L13:
            goto L4f
        L17:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L8f
        L1d:
            r2 = r2[r3]
            goto L9b
        L23:
            goto L13
        L26:
            goto L3c
        L2a:
            r1 = 19
            goto La1
        L31:
            int r1 = r3 + 2
            goto L5a
        L37:
            int r0 = r0 + r1
            goto L95
        L3c:
            goto L75
        L3f:
            int r0 = r0 + r1
            goto L31
        L44:
            int r0 = r0 + r2
            goto L55
        L49:
            r1 = r2[r1]
            goto L17
        L4f:
            r0 = r2[r3]
            goto L66
        L55:
            return r0
        L56:
            goto L23
        L5a:
            r1 = r2[r1]
            goto La
        L60:
            int r1 = r3 + 1
            goto L49
        L66:
            r0 = r0 & 255(0xff, float:3.57E-43)
            goto L6c
        L6c:
            int r0 = r0 << 24
            goto L60
        L72:
            goto L26
        L75:
            goto L82
        L79:
            if (r0 <= 0) goto L7e
            goto L13
        L7e:
            goto L10
        L82:
            r0 = 19
            goto L2a
        L89:
            int r0 = r0 % r1
            goto L79
        L8f:
            int r1 = r1 << 16
            goto L3f
        L95:
            int r3 = r3 + 3
            goto L1d
        L9b:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto L44
        La1:
            int r0 = r0 + r1
            goto L89
    }

    private static void ReadInt(byte[] r0, int r1, char r2, int r3, java.lang.string r4, float r5) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L20
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L4
        L13:
            goto L26
        L16:
            goto L1a
        L1a:
            r0 = 42
            goto L2a
        L20:
            double r0 = (double) r3
            goto L25
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    private static void ReadInt(byte[] r0, int r1, float r2, char r3, int r4, java.lang.string r5) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            goto L26
        Ld:
            goto L1f
        L11:
            goto Ld
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    private static void ReadInt(byte[] r0, int r1, java.lang.string r2, float r3, char r4, int r5) {
            goto L1b
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L22
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            return
        L17:
            goto L27
        L1b:
            goto L17
        L1e:
            goto L2a
        L22:
            double r0 = (double) r3
            goto L16
        L27:
            goto L1e
        L2a:
            r0 = 42
            goto L4
    }

    private int Remainingbytes() {
            r1 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto L20
        Lb:
            goto L7
        Le:
            int r1 = wRiERreEfwHSxpeH(r1)
            goto L16
        L16:
            int r0 = r0 - r1
            goto L1b
        L1b:
            return r0
        L1c:
            goto Lb
        L20:
            int r0 = r1.fileLength
            goto Le
    }

    private void Remainingbytes(byte r1, java.lang.string r2, float r3, bool r4) {
            r0 = this;
            goto Lf
        L4:
            return
        L5:
            goto L22
        L9:
            int r3 = r2 + r1
            goto L25
        Lf:
            goto L5
        L12:
            goto L1c
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            r0 = 42
            goto L2a
        L22:
            goto L12
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
    }

    private void Remainingbytes(byte r1, java.lang.string r2, bool r3, float r4) {
            r0 = this;
            goto L23
        L4:
            int r3 = r2 + r1
            goto L15
        La:
            return
        Lb:
            goto L1a
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L26
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        L23:
            goto Lb
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L1d
    }

    private void Remainingbytes(java.lang.string r1, float r2, bool r3, byte r4) {
            r0 = this;
            goto L23
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L14
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto L26
        L17:
            r0 = 42
            goto L2a
        L1d:
            int r2 = r0 * r1
            goto Le
        L23:
            goto La
        L26:
            goto L17
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
    }

    private void RingRead(int r5, byte[] r6, int r7, int r8) throws java.io.IOException {
            r4 = this;
            goto La3
        L4:
            int r1 = r4.fileLength
            goto L72
        La:
            int r0 = r0 % r1
            goto L9a
        L10:
            java.io.RandomAccessstring r0 = r4.raf
            goto L56
        L16:
            xujTAxfptqwwvpFa(r4, r6, r7, r8)
            goto L5b
        L1d:
            long r2 = (long) r5
            goto L48
        L22:
            goto La6
        L25:
            int r8 = r8 - r1
            goto Lcc
        L2a:
            int r0 = r5 + r8
            goto L4
        L30:
            java.io.RandomAccessstring r0 = r4.raf
            goto L1d
        L36:
            java.io.RandomAccessstring r4 = r4.raf
            goto L60
        L3c:
            XaGdFPYWfnDfWMnw(r5, r6, r7, r1)
            goto L65
        L43:
            int r1 = r1 - r5
            goto L30
        L48:
            qBGFZDWfspSBwMVE(r0, r2)
            goto L7b
        L4f:
            goto Lb4
        L52:
            goto L22
        L56:
            long r1 = (long) r5
            goto L6b
        L5b:
            return
        L5c:
            goto L43
        L60:
            int r7 = r7 + r1
            goto L25
        L65:
            java.io.RandomAccessstring r5 = r4.raf
            goto L8f
        L6b:
            CovCGhbvaqpMSUZA(r0, r1)
            goto Lb8
        L72:
            if (r0 <= r1) goto L77
            goto L5c
        L77:
            goto L10
        L7b:
            java.io.RandomAccessstring r5 = r4.raf
            goto L3c
        L81:
            r0 = 24
            goto Laa
        L88:
            ofdFIGzalwRxqtTC(r5, r2)
            goto L36
        L8f:
            r2 = 16
            goto L88
        L95:
            return
        L96:
            goto L4f
        L9a:
            if (r0 <= 0) goto L9f
            goto Lb4
        L9f:
            goto Lb1
        La3:
            goto L52
        La6:
            goto L81
        Laa:
            r1 = 2
            goto Lc6
        Lb1:
            goto L96
        Lb4:
            goto Lbe
        Lb8:
            java.io.RandomAccessstring r4 = r4.raf
            goto L16
        Lbe:
            int r5 = kYklQjxGZJysTHDH(r4, r5)
            goto L2a
        Lc6:
            int r0 = r0 + r1
            goto La
        Lcc:
            BmUnLAVUiPZfgwmm(r4, r6, r7, r8)
            goto L95
    }

    private void RingRead(int r1, byte[] r2, int r3, int r4, byte r5, float r6, char r7, java.lang.string r8) {
            r0 = this;
            goto L14
        L4:
            r0 = 42
            goto L21
        La:
            return
        Lb:
            goto L2d
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            goto Lb
        L17:
            goto L4
        L1b:
            int r2 = r0 * r1
            goto L27
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            int r3 = r2 + r1
            goto Lf
        L2d:
            goto L17
    }

    private void RingRead(int r1, byte[] r2, int r3, int r4, float r5, char r6, byte r7, java.lang.string r8) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L16
        Lb:
            return
        Lc:
            goto L2d
        L10:
            int r2 = r0 * r1
            goto L27
        L16:
            r0 = 42
            goto L21
        L1c:
            double r0 = (double) r3
            goto Lb
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L27:
            int r3 = r2 + r1
            goto L1c
        L2d:
            goto L7
    }

    private void RingRead(int r1, byte[] r2, int r3, int r4, java.lang.string r5, byte r6, float r7, char r8) {
            r0 = this;
            goto L17
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L1a
        L17:
            goto L10
        L1a:
            goto L24
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L4
    }

    private void RingWrite(int r5, byte[] r6, int r7, int r8) throws java.io.IOException {
            r4 = this;
            goto L29
        L4:
            java.io.RandomAccessstring r0 = r4.raf
            goto L8f
        La:
            int r8 = r8 - r1
            goto Lb3
        Lf:
            int r0 = r0 + r1
            goto L36
        L15:
            java.io.RandomAccessstring r0 = r4.raf
            goto L8a
        L1b:
            DgKJRIRNNkTESEJu(r5, r6, r7, r1)
            goto Lba
        L22:
            r0 = 22
            goto L74
        L29:
            goto L9f
        L2c:
            goto L22
        L30:
            int r1 = r4.fileLength
            goto L7b
        L36:
            int r0 = r0 % r1
            goto Laa
        L3c:
            goto L2c
        L3f:
            return
        L40:
            goto L63
        L44:
            return
        L45:
            goto L9c
        L49:
            NdDWhYEGBmnvhDiZ(r5, r2)
            goto L5d
        L50:
            yWnYupJbVlkwuiIP(r4, r6, r7, r8)
            goto L3f
        L57:
            int r0 = r5 + r8
            goto L30
        L5d:
            java.io.RandomAccessstring r4 = r4.raf
            goto L68
        L63:
            int r1 = r1 - r5
            goto L4
        L68:
            int r7 = r7 + r1
            goto La
        L6d:
            GEXMzOdcvetFYVxC(r0, r2)
            goto L84
        L74:
            r1 = 19
            goto Lf
        L7b:
            if (r0 <= r1) goto L80
            goto L40
        L80:
            goto L15
        L84:
            java.io.RandomAccessstring r5 = r4.raf
            goto L1b
        L8a:
            long r1 = (long) r5
            goto La3
        L8f:
            long r2 = (long) r5
            goto L6d
        L94:
            int r5 = jAetluXPuLxjLcwc(r4, r5)
            goto L57
        L9c:
            goto Lcf
        L9f:
            goto L3c
        La3:
            hdoUJrrvChbsICJw(r0, r1)
            goto Lc0
        Laa:
            if (r0 <= 0) goto Laf
            goto Lcf
        Laf:
            goto Lcc
        Lb3:
            LpFKhNdNxFNyYdSf(r4, r6, r7, r8)
            goto L44
        Lba:
            java.io.RandomAccessstring r5 = r4.raf
            goto Lc6
        Lc0:
            java.io.RandomAccessstring r4 = r4.raf
            goto L50
        Lc6:
            r2 = 16
            goto L49
        Lcc:
            goto L45
        Lcf:
            goto L94
    }

    private void RingWrite(int r1, byte[] r2, int r3, int r4, float r5, int r6, java.lang.string r7, bool r8) {
            r0 = this;
            goto L29
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            r0 = 42
            goto L23
        L16:
            return
        L17:
            goto L20
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            goto L2c
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L29:
            goto L17
        L2c:
            goto L10
    }

    private void RingWrite(int r1, byte[] r2, int r3, int r4, int r5, float r6, bool r7, java.lang.string r8) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0 = 42
            goto L19
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto L7
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    private void RingWrite(int r1, byte[] r2, int r3, int r4, java.lang.string r5, float r6, bool r7, int r8) {
            r0 = this;
            goto L13
        L4:
            r0 = 42
            goto L2a
        La:
            goto L16
        Ld:
            int r2 = r0 * r1
            goto L1f
        L13:
            goto L1b
        L16:
            goto L4
        L1a:
            return
        L1b:
            goto La
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
    }

    public static void RmHhgJOMBMlDiCkE(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.writeHeader(r1, r2, r3, r4)
            goto Lb
        L17:
            goto L7
    }

    public static void RmHhgJOMBMlDiCkE(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, float r5, char r6, java.lang.string r7, int r8) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L10:
            goto L26
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            return
        L1a:
            goto L10
        L1e:
            double r0 = (double) r3
            goto L19
        L23:
            goto L1a
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto La
    }

    public static void RmHhgJOMBMlDiCkE(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, float r5, int r6, char r7, java.lang.string r8) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            int r3 = r2 + r1
            goto L19
        L10:
            r0 = 42
            goto L4
        L16:
            goto L26
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L16
        L23:
            goto L1f
        L26:
            goto L10
        L2a:
            int r2 = r0 * r1
            goto La
    }

    public static void RmHhgJOMBMlDiCkE(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, int r2, int r3, int r4, int r5, char r6, float r7, java.lang.string r8) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L10:
            goto L29
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L28
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L17
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L13
    }

    public static java.lang.stringBuilder RwFvbItIvTjfprxC(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void RwFvbItIvTjfprxC(java.lang.stringBuilder r0, java.lang.string r1, bool r2, byte r3, java.lang.string r4, float r5) {
            goto Lf
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L1c
        Lf:
            goto L5
        L12:
            goto L2a
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L21
    }

    public static void RwFvbItIvTjfprxC(java.lang.stringBuilder r0, java.lang.string r1, bool r2, float r3, byte r4, java.lang.string r5) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            double r0 = (double) r3
            goto L24
        L15:
            goto L2c
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1e:
            r0 = 42
            goto L18
        L24:
            return
        L25:
            goto L15
        L29:
            goto L25
        L2c:
            goto L1e
    }

    public static void RwFvbItIvTjfprxC(java.lang.stringBuilder r0, java.lang.string r1, bool r2, java.lang.string r3, byte r4, float r5) {
            goto L21
        L4:
            int r2 = r0 * r1
            goto L16
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            r0 = 42
            goto La
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto L2b
        L21:
            goto L2c
        L24:
            goto L10
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static int SFOSfMtZQnSJGZAt(com.google.firebase.crashlytics.internal.metadata.Queuestring r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.wrapPosition(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void SFOSfMtZQnSJGZAt(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, int r3, bool r4, float r5) {
            goto L23
        L4:
            return
        L5:
            goto L1a
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            r0 = 42
            goto L1d
        L1a:
            goto L26
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L23:
            goto L5
        L26:
            goto L14
        L2a:
            int r3 = r2 + r1
            goto Lf
    }

    public static void SFOSfMtZQnSJGZAt(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, char r2, bool r3, float r4, int r5) {
            goto L20
        L4:
            r0 = 42
            goto L27
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            int r3 = r2 + r1
            goto La
        L1a:
            int r2 = r0 * r1
            goto L14
        L20:
            goto L10
        L23:
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L2d:
            goto L23
    }

    public static void SFOSfMtZQnSJGZAt(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, bool r2, int r3, char r4, float r5) {
            goto L23
        L4:
            goto L26
        L7:
            return
        L8:
            goto L4
        Lc:
            double r0 = (double) r3
            goto L7
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L17:
            r0 = 42
            goto L11
        L1d:
            int r3 = r2 + r1
            goto Lc
        L23:
            goto L8
        L26:
            goto L17
        L2a:
            int r2 = r0 * r1
            goto L1d
    }

    private void SetLength(int r4) throws java.io.IOException {
            r3 = this;
            goto L4c
        L4:
            r4 = 1
            goto L37
        L9:
            long r1 = (long) r4
            goto L5c
        Le:
            goto L1c
        L11:
            goto L15
        L15:
            java.io.RandomAccessstring r0 = r3.raf
            goto L9
        L1b:
            return
        L1c:
            goto L63
        L20:
            int r0 = r0 % r1
            goto L53
        L26:
            r1 = 8
            goto L3e
        L2d:
            r0 = 13
            goto L26
        L34:
            goto L4f
        L37:
            NVpMHQAgfZOywXlg(r3, r4)
            goto L1b
        L3e:
            int r0 = r0 + r1
            goto L20
        L44:
            java.nio.channels.stringChannel r3 = ffeJRBVLsUDSJtXr(r3)
            goto L4
        L4c:
            goto L66
        L4f:
            goto L2d
        L53:
            if (r0 <= 0) goto L58
            goto L11
        L58:
            goto Le
        L5c:
            OWmMLUHhzlzjcMbu(r0, r1)
            goto L6a
        L63:
            goto L11
        L66:
            goto L34
        L6a:
            java.io.RandomAccessstring r3 = r3.raf
            goto L44
    }

    private void SetLength(int r1, byte r2, float r3, int r4, java.lang.string r5) {
            r0 = this;
            goto L1d
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            goto L20
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            goto Le
        L20:
            goto L24
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
    }

    private void SetLength(int r1, float r2, java.lang.string r3, int r4, byte r5) {
            r0 = this;
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L19
        L10:
            goto Lc
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            r0 = 42
            goto L25
        L1f:
            int r2 = r0 * r1
            goto L13
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            double r0 = (double) r3
            goto L4
    }

    private void SetLength(int r1, java.lang.string r2, byte r3, float r4, int r5) {
            r0 = this;
            goto L10
        L4:
            int r3 = r2 + r1
            goto L17
        La:
            r0 = 42
            goto L2a
        L10:
            goto L26
        L13:
            goto La
        L17:
            double r0 = (double) r3
            goto L25
        L1c:
            goto L13
        L1f:
            int r2 = r0 * r1
            goto L4
        L25:
            return
        L26:
            goto L1c
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void SlUTLllzUeNPPZjz(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte[] r1, int r2, int r3) {
            goto Lb
        L4:
            r0.Add(r1, r2, r3)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void SlUTLllzUeNPPZjz(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte[] r1, int r2, int r3, byte r4, java.lang.string r5, short r6, bool r7) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            r0 = 42
            goto L2a
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L20
        L1d:
            goto L16
        L20:
            goto Lf
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void SlUTLllzUeNPPZjz(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte[] r1, int r2, int r3, java.lang.string r4, byte r5, short r6, bool r7) {
            goto L4
        L4:
            goto L12
        L7:
            goto L1c
        Lb:
            int r2 = r0 * r1
            goto L16
        L11:
            return
        L12:
            goto L22
        L16:
            int r3 = r2 + r1
            goto L25
        L1c:
            r0 = 42
            goto L2a
        L22:
            goto L7
        L25:
            double r0 = (double) r3
            goto L11
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void SlUTLllzUeNPPZjz(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte[] r1, int r2, int r3, bool r4, java.lang.string r5, short r6, byte r7) {
            goto Le
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L5
        L11:
            goto L2a
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L1b:
            int r3 = r2 + r1
            goto L9
        L21:
            goto L11
        L24:
            int r2 = r0 * r1
            goto L1b
        L2a:
            r0 = 42
            goto L15
    }

    public static void TQKMyKItMvUwHxej(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2) {
            goto Lb
        L4:
            r0.read(r1, r2)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void TQKMyKItMvUwHxej(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2, byte r3, float r4, bool r5, int r6) {
            goto Lf
        L4:
            r0 = 42
            goto L1b
        La:
            return
        Lb:
            goto L27
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            double r0 = (double) r3
            goto La
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L21:
            int r2 = r0 * r1
            goto L2a
        L27:
            goto L12
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    public static void TQKMyKItMvUwHxej(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2, byte r3, int r4, float r5, bool r6) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto Lf
        La:
            double r0 = (double) r3
            goto L15
        Lf:
            int r3 = r2 + r1
            goto La
        L15:
            return
        L16:
            goto L2d
        L1a:
            r0 = 42
            goto L20
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L26:
            goto L16
        L29:
            goto L1a
        L2d:
            goto L29
    }

    public static void TQKMyKItMvUwHxej(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r0, java.io.Stream r1, int r2, float r3, int r4, byte r5, bool r6) {
            goto L23
        L4:
            goto L26
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        Ld:
            int r2 = r0 * r1
            goto L1d
        L13:
            return
        L14:
            goto L4
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto L14
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L7
    }

    public static void TeIxKQLdJMVQKZEi(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, java.lang.string r2, int r3, float r4) {
            goto L1e
        L4:
            goto L21
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L2b
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L1e:
            goto L8
        L21:
            goto L12
        L25:
            int r2 = r0 * r1
            goto Lc
        L2b:
            double r0 = (double) r3
            goto L7
    }

    public static void TeIxKQLdJMVQKZEi(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, java.lang.string r2, float r3, byte r4) {
            goto L18
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L1b
        L18:
            goto L2c
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2b:
            return
        L2c:
            goto L15
    }

    public static void TeIxKQLdJMVQKZEi(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, java.lang.string r1, int r2, float r3, byte r4) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L10:
            goto L24
        L13:
            goto L17
        L17:
            r0 = 42
            goto La
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            return
        L24:
            goto L28
        L28:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L23
    }

    public static bool TeIxKQLdJMVQKZEi(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.Count == 0
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static long TiCQkZaeCGVHcATX(java.io.RandomAccessstring r2) {
            goto L1e
        L4:
            goto L21
        L7:
            if (r0 <= 0) goto Lc
            goto L36
        Lc:
            goto L33
        L10:
            long r0 = r2.Length
            goto L47
        L18:
            int r0 = r0 % r1
            goto L7
        L1e:
            goto L28
        L21:
            goto L2c
        L25:
            goto L36
        L28:
            goto L4
        L2c:
            r0 = 17
            goto L3a
        L33:
            goto L48
        L36:
            goto L10
        L3a:
            r1 = 15
            goto L41
        L41:
            int r0 = r0 + r1
            goto L18
        L47:
            return r0
        L48:
            goto L25
    }

    public static void TiCQkZaeCGVHcATX(java.io.RandomAccessstring r0, byte r1, char r2, short r3, java.lang.string r4) {
            goto Lf
        L4:
            r0 = 42
            goto L16
        La:
            return
        Lb:
            goto L21
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            double r0 = (double) r3
            goto La
        L21:
            goto L12
        L24:
            int r3 = r2 + r1
            goto L1c
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void TiCQkZaeCGVHcATX(java.io.RandomAccessstring r0, char r1, java.lang.string r2, short r3, byte r4) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L18
        La:
            goto L2c
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L4
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L23:
            r0 = 42
            goto L1d
        L29:
            goto Le
        L2c:
            goto L23
    }

    public static void TiCQkZaeCGVHcATX(java.io.RandomAccessstring r0, short r1, java.lang.string r2, char r3, byte r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L21
        L12:
            int r3 = r2 + r1
            goto L2b
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            goto Lb
        L21:
            goto L25
        L25:
            r0 = 42
            goto L4
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static int VfQSPgMNXpOEafar(byte[] r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = readInt(r1, r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void VfQSPgMNXpOEafar(byte[] r0, int r1, byte r2, short r3, char r4, int r5) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L1c
        La:
            r0 = 42
            goto L2a
        L10:
            goto L23
        L13:
            goto La
        L17:
            double r0 = (double) r3
            goto L22
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            return
        L23:
            goto L27
        L27:
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void VfQSPgMNXpOEafar(byte[] r0, int r1, short r2, byte r3, char r4, int r5) {
            goto L18
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            goto L1b
        Ld:
            return
        Le:
            goto La
        L12:
            r0 = 42
            goto L1f
        L18:
            goto Le
        L1b:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static void VfQSPgMNXpOEafar(byte[] r0, int r1, short r2, int r3, char r4, byte r5) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r0 = 42
            goto L25
        L10:
            return
        L11:
            goto L15
        L15:
            goto L21
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            goto L11
        L21:
            goto La
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L2b:
            double r0 = (double) r3
            goto L10
    }

    public static void VyZdcoMWjUPbTNIW(java.io.RandomAccessstring r0) {
            goto Lb
        L4:
            r0.Dispose()
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void VyZdcoMWjUPbTNIW(java.io.RandomAccessstring r0, int r1, java.lang.string r2, char r3, bool r4) {
            goto La
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        La:
            goto L29
        Ld:
            goto L11
        L11:
            r0 = 42
            goto L4
        L17:
            int r3 = r2 + r1
            goto L1d
        L1d:
            double r0 = (double) r3
            goto L28
        L22:
            int r2 = r0 * r1
            goto L17
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto Ld
    }

    public static void VyZdcoMWjUPbTNIW(java.io.RandomAccessstring r0, java.lang.string r1, bool r2, char r3, int r4) {
            goto Lc
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto Lf
        Lc:
            goto L1a
        Lf:
            goto L2a
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L19:
            return
        L1a:
            goto L9
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r0 = 42
            goto L13
    }

    public static void VyZdcoMWjUPbTNIW(java.io.RandomAccessstring r0, bool r1, char r2, int r3, java.lang.string r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L22
        L10:
            return
        L11:
            goto L27
        L15:
            goto L11
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L2a
        L22:
            double r0 = (double) r3
            goto L10
        L27:
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static int WRiERreEfwHSxpeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            int r0 = r1.usedbytes()
            goto Lb
        L18:
            goto L7
    }

    public static void WRiERreEfwHSxpeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, float r1, short r2, bool r3, byte r4) {
            goto L23
        L4:
            return
        L5:
            goto Le
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            goto L26
        L11:
            int r3 = r2 + r1
            goto L9
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            r0 = 42
            goto L17
        L23:
            goto L5
        L26:
            goto L1d
        L2a:
            int r2 = r0 * r1
            goto L11
    }

    public static void WRiERreEfwHSxpeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, short r1, float r2, bool r3, byte r4) {
            goto L4
        L4:
            goto L27
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L11
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L17:
            int r2 = r0 * r1
            goto L20
        L1d:
            goto L7
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void WRiERreEfwHSxpeH(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, bool r1, byte r2, float r3, short r4) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L21
        Lb:
            return
        Lc:
            goto L27
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L16:
            double r0 = (double) r3
            goto Lb
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            r0 = 42
            goto L10
        L27:
            goto L7
        L2a:
            int r3 = r2 + r1
            goto L16
    }

    private int WrapPosition(int r1) {
            r0 = this;
            goto L1c
        L4:
            goto L1f
        L7:
            int r1 = r1 - r0
            goto L17
        Lc:
            return r1
        Ld:
            goto L2c
        L11:
            int r0 = r0.fileLength
            goto L23
        L17:
            return r1
        L18:
            goto L4
        L1c:
            goto L18
        L1f:
            goto L11
        L23:
            if (r1 < r0) goto L28
            goto Ld
        L28:
            goto Lc
        L2c:
            int r1 = r1 + 16
            goto L7
    }

    private void WrapPosition(int r1, char r2, java.lang.string r3, int r4, byte r5) {
            r0 = this;
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L10:
            goto L2c
        L13:
            goto L4
        L17:
            int r2 = r0 * r1
            goto L20
        L1d:
            goto L13
        L20:
            int r3 = r2 + r1
            goto L26
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto L1d
    }

    private void WrapPosition(int r1, java.lang.string r2, byte r3, int r4, char r5) {
            r0 = this;
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L24
        Lc:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L7
        L1e:
            r0 = 42
            goto Lc
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto L1e
    }

    private void WrapPosition(int r1, java.lang.string r2, int r3, char r4, byte r5) {
            r0 = this;
            goto L4
        L4:
            goto L20
        L7:
            goto L11
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L11:
            r0 = 42
            goto Lb
        L17:
            goto L7
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L17
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L1a
    }

    private void WriteHeader(int r2, int r3, int r4, int r5) throws java.io.IOException {
            r1 = this;
            goto L30
        L4:
            java.io.RandomAccessstring r2 = r1.raf
            goto L37
        La:
            MeuZPNqiiCseLDvj(r2, r1)
            goto L1f
        L11:
            int[] r2 = new int[]{r2, r3, r4, r5}
            goto L40
        L19:
            byte[] r1 = r1.buffer
            goto La
        L1f:
            return
        L20:
            goto L3d
        L24:
            byte[] r0 = r1.buffer
            goto L11
        L2a:
            java.io.RandomAccessstring r2 = r1.raf
            goto L19
        L30:
            goto L20
        L33:
            goto L24
        L37:
            r3 = 0
            goto L47
        L3d:
            goto L33
        L40:
            AdmXpgAOsfviJvdh(r0, r2)
            goto L4
        L47:
            GlgUphwBGlgwoyHx(r2, r3)
            goto L2a
    }

    private void WriteHeader(int r1, int r2, int r3, int r4, byte r5, short r6, bool r7, java.lang.string r8) {
            r0 = this;
            goto Lf
        L4:
            return
        L5:
            goto L27
        L9:
            int r3 = r2 + r1
            goto L1c
        Lf:
            goto L5
        L12:
            goto L2a
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            double r0 = (double) r3
            goto L4
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L27:
            goto L12
        L2a:
            r0 = 42
            goto L21
    }

    private void WriteHeader(int r1, int r2, int r3, int r4, java.lang.string r5, byte r6, bool r7, short r8) {
            r0 = this;
            goto L1a
        L4:
            int r2 = r0 * r1
            goto L14
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            goto Lb
        L1d:
            goto L21
        L21:
            r0 = 42
            goto L2a
        L27:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    private void WriteHeader(int r1, int r2, int r3, int r4, short r5, byte r6, java.lang.string r7, bool r8) {
            r0 = this;
            goto Ld
        L4:
            r0 = 42
            goto L1f
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L4
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L14
    }

    private static void WriteInt(byte[] r2, int r3, int r4) {
            goto L17
        L4:
            goto L5b
        L7:
            goto L7e
        Lb:
            r2[r3] = r4
            goto L2e
        L11:
            r2[r0] = r1
            goto L28
        L17:
            goto L7
        L1a:
            goto L51
        L1e:
            byte r0 = (byte) r0
            goto L45
        L23:
            byte r1 = (byte) r1
            goto L11
        L28:
            int r0 = r3 + 2
            goto L78
        L2e:
            return
        L2f:
            goto L4
        L33:
            int r1 = r4 >> 16
            goto L23
        L39:
            int r3 = r3 + 3
            goto L5f
        L3f:
            r2[r0] = r1
            goto L39
        L45:
            r2[r3] = r0
            goto L8e
        L4b:
            int r0 = r0 + r1
            goto L81
        L51:
            r0 = 1
            goto L87
        L58:
            goto L2f
        L5b:
            goto L69
        L5f:
            byte r4 = (byte) r4
            goto Lb
        L64:
            byte r1 = (byte) r1
            goto L3f
        L69:
            int r0 = r4 >> 24
            goto L1e
        L6f:
            if (r0 <= 0) goto L74
            goto L5b
        L74:
            goto L58
        L78:
            int r1 = r4 >> 8
            goto L64
        L7e:
            goto L1a
        L81:
            int r0 = r0 % r1
            goto L6f
        L87:
            r1 = 3
            goto L4b
        L8e:
            int r0 = r3 + 1
            goto L33
    }

    private static void WriteInt(byte[] r0, int r1, int r2, byte r3, float r4, bool r5, char r6) {
            goto L29
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r0 = 42
            goto L23
        L10:
            double r0 = (double) r3
            goto L18
        L15:
            goto L2c
        L18:
            return
        L19:
            goto L15
        L1d:
            int r2 = r0 * r1
            goto L4
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto L19
        L2c:
            goto La
    }

    private static void WriteInt(byte[] r0, int r1, int r2, char r3, bool r4, byte r5, float r6) {
            goto L4
        L4:
            goto L20
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L1f
        L10:
            goto L7
        L13:
            int r3 = r2 + r1
            goto Lb
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            return
        L20:
            goto L10
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2a:
            r0 = 42
            goto L24
    }

    private static void WriteInt(byte[] r0, int r1, int r2, bool r3, char r4, float r5, byte r6) {
            goto L29
        L4:
            goto L2c
        L7:
            int r3 = r2 + r1
            goto L1e
        Ld:
            return
        Le:
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L18:
            int r2 = r0 * r1
            goto L7
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            r0 = 42
            goto L12
        L29:
            goto Le
        L2c:
            goto L23
    }

    private static void WriteInts(byte[] r4, int... r5) {
            goto L62
        L4:
            r3 = r5[r1]
            goto L3b
        La:
            int r1 = r1 + 1
            goto L69
        L10:
            r1 = 31
            goto L24
        L17:
            goto L37
        L1a:
            goto L50
        L1e:
            int r0 = r0 % r1
            goto L53
        L24:
            int r0 = r0 + r1
            goto L1e
        L2a:
            r1 = 0
            goto L2f
        L2f:
            r2 = r1
        L30:
            goto L42
        L34:
            goto L6f
        L37:
            goto L4b
        L3b:
            BbuFwZXABEErpVTU(r4, r2, r3)
            goto L5c
        L42:
            if (r1 < r0) goto L47
            goto L6a
        L47:
            goto L4
        L4b:
            int r0 = r5.length
            goto L2a
        L50:
            goto L65
        L53:
            if (r0 <= 0) goto L58
            goto L37
        L58:
            goto L34
        L5c:
            int r2 = r2 + 4
            goto La
        L62:
            goto L1a
        L65:
            goto L73
        L69:
            goto L30
        L6a:
            goto L6e
        L6e:
            return
        L6f:
            goto L17
        L73:
            r0 = 28
            goto L10
    }

    private static void WriteInts(byte[] r0, int[] r1, float r2, java.lang.string r3, short r4, bool r5) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L16
        Ld:
            int r3 = r2 + r1
            goto L1f
        L13:
            goto L1b
        L16:
            goto L24
        L1a:
            return
        L1b:
            goto La
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r0 = 42
            goto L4
        L2a:
            int r2 = r0 * r1
            goto Ld
    }

    private static void WriteInts(byte[] r0, int[] r1, java.lang.string r2, short r3, float r4, bool r5) {
            goto L29
        L4:
            goto L2c
        L7:
            int r2 = r0 * r1
            goto L18
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L1e
        L18:
            int r3 = r2 + r1
            goto L24
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L24:
            double r0 = (double) r3
            goto Ld
        L29:
            goto Le
        L2c:
            goto L12
    }

    private static void WriteInts(byte[] r0, int[] r1, bool r2, float r3, java.lang.string r4, short r5) {
            goto L14
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L2d
        L14:
            goto L10
        L17:
            goto L27
        L1b:
            int r2 = r0 * r1
            goto L9
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L27:
            r0 = 42
            goto L21
        L2d:
            goto L17
    }

    public static void XmqHSxfKfJCuNFXN(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.ringRead(r1, r2, r3, r4)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void XmqHSxfKfJCuNFXN(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, byte r5, float r6, char r7, int r8) {
            goto L29
        L4:
            goto L2c
        L7:
            double r0 = (double) r3
            goto L18
        Lc:
            int r2 = r0 * r1
            goto L23
        L12:
            r0 = 42
            goto L1d
        L18:
            return
        L19:
            goto L4
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L23:
            int r3 = r2 + r1
            goto L7
        L29:
            goto L19
        L2c:
            goto L12
    }

    public static void XmqHSxfKfJCuNFXN(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, byte r5, int r6, char r7, float r8) {
            goto L13
        L4:
            r0 = 42
            goto L1a
        La:
            int r2 = r0 * r1
            goto L25
        L10:
            goto L16
        L13:
            goto L21
        L16:
            goto L4
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L20:
            return
        L21:
            goto L10
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void XmqHSxfKfJCuNFXN(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, int r1, byte[] r2, int r3, int r4, char r5, float r6, int r7, byte r8) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            r0 = 42
            goto L22
        L10:
            double r0 = (double) r3
            goto L2b
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            goto L2c
        L1e:
            goto La
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L28:
            goto L1e
        L2b:
            return
        L2c:
            goto L28
    }

    public static void XujTAxfptqwwvpFa(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.readFully(r1, r2, r3)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void XujTAxfptqwwvpFa(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, byte r4, java.lang.string r5, short r6, bool r7) {
            goto L17
        L4:
            return
        L5:
            goto L14
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L1a
        L17:
            goto L5
        L1a:
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto Lf
        L2a:
            r0 = 42
            goto L9
    }

    public static void XujTAxfptqwwvpFa(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, java.lang.string r4, short r5, bool r6, byte r7) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L28
        La:
            goto L12
        Ld:
            goto L1c
        L11:
            return
        L12:
            goto L2d
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L1c:
            r0 = 42
            goto L16
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            double r0 = (double) r3
            goto L11
        L2d:
            goto Ld
    }

    public static void XujTAxfptqwwvpFa(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, bool r4, byte r5, java.lang.string r6, short r7) {
            goto Lf
        L4:
            r0 = 42
            goto L1c
        La:
            return
        Lb:
            goto L22
        Lf:
            goto Lb
        L12:
            goto L4
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L22:
            goto L12
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void YKPLISvzqPbOCosy(java.io.RandomAccessstring r0, long r1) {
            goto Lb
        L4:
            r0.setLength(r1)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void YKPLISvzqPbOCosy(java.io.RandomAccessstring r0, long r1, char r3, short r4, java.lang.string r5, float r6) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L20
        L12:
            goto L24
        L16:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1c:
            goto L12
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L16
        L2a:
            int r2 = r0 * r1
            goto L9
    }

    public static void YKPLISvzqPbOCosy(java.io.RandomAccessstring r0, long r1, float r3, short r4, java.lang.string r5, char r6) {
            goto L4
        L4:
            goto L11
        L7:
            goto L2a
        Lb:
            double r0 = (double) r3
            goto L10
        L10:
            return
        L11:
            goto L21
        L15:
            int r2 = r0 * r1
            goto L24
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            goto L7
        L24:
            int r3 = r2 + r1
            goto Lb
        L2a:
            r0 = 42
            goto L1b
    }

    public static void YKPLISvzqPbOCosy(java.io.RandomAccessstring r0, long r1, java.lang.string r3, float r4, short r5, char r6) {
            goto L29
        L4:
            goto L2c
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        Ld:
            r0 = 42
            goto L7
        L13:
            int r2 = r0 * r1
            goto L19
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L24
        L24:
            return
        L25:
            goto L4
        L29:
            goto L25
        L2c:
            goto Ld
    }

    public static void YWnYupJbVlkwuiIP(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.write(r1, r2, r3)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void YWnYupJbVlkwuiIP(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, byte r4, short r5, int r6, bool r7) {
            goto L26
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L2d
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            goto La
        L29:
            goto L14
        L2d:
            goto L29
    }

    public static void YWnYupJbVlkwuiIP(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, int r4, byte r5, short r6, bool r7) {
            goto L12
        L4:
            r0 = 42
            goto L19
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void YWnYupJbVlkwuiIP(java.io.RandomAccessstring r0, byte[] r1, int r2, int r3, int r4, short r5, bool r6, byte r7) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            return
        Lb:
            goto L1c
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto Lb
        L18:
            goto L2a
        L1c:
            goto L18
        L1f:
            double r0 = (double) r3
            goto La
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            r0 = 42
            goto Lf
    }

    public static void ZVSCVOEICiBQMhaI(com.google.firebase.crashlytics.internal.metadata.Queuestring r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.readHeader()
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static void ZVSCVOEICiBQMhaI(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, char r2, float r3, short r4) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            int r3 = r2 + r1
            goto L1e
        L10:
            goto L2c
        L13:
            return
        L14:
            goto L10
        L18:
            int r2 = r0 * r1
            goto La
        L1e:
            double r0 = (double) r3
            goto L13
        L23:
            r0 = 42
            goto L4
        L29:
            goto L14
        L2c:
            goto L23
    }

    public static void ZVSCVOEICiBQMhaI(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, byte r1, float r2, char r3, short r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            goto L1a
        L12:
            goto L1e
        L16:
            goto L12
        L19:
            return
        L1a:
            goto L16
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void ZVSCVOEICiBQMhaI(com.google.firebase.crashlytics.internal.metadata.Queuestring r0, short r1, float r2, byte r3, char r4) {
            goto L29
        L4:
            r0 = 42
            goto L10
        La:
            int r2 = r0 * r1
            goto L16
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L16:
            int r3 = r2 + r1
            goto L1c
        L1c:
            double r0 = (double) r3
            goto L24
        L21:
            goto L2c
        L24:
            return
        L25:
            goto L21
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static java.lang.stringBuilder ZYSixnaqukNBmlyP(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
    }

    public static void ZYSixnaqukNBmlyP(java.lang.stringBuilder r0, java.lang.string r1, byte r2, float r3, int r4, bool r5) {
            goto L17
        L4:
            int r2 = r0 * r1
            goto L1e
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L1a
        L12:
            double r0 = (double) r3
            goto La
        L17:
            goto Lb
        L1a:
            goto L24
        L1e:
            int r3 = r2 + r1
            goto L12
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void ZYSixnaqukNBmlyP(java.lang.stringBuilder r0, java.lang.string r1, int r2, bool r3, byte r4, float r5) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L17
        L11:
            r0 = 42
            goto L2a
        L17:
            int r3 = r2 + r1
            goto L22
        L1d:
            return
        L1e:
            goto L27
        L22:
            double r0 = (double) r3
            goto L1d
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static void ZYSixnaqukNBmlyP(java.lang.stringBuilder r0, java.lang.string r1, bool r2, float r3, int r4, byte r5) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r2 = r0 * r1
            goto L1d
        Lf:
            goto L26
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L18:
            return
        L19:
            goto Lf
        L1d:
            int r3 = r2 + r1
            goto L4
        L23:
            goto L19
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public void Add(byte[] r3) throws java.io.IOException {
            r2 = this;
            goto L10
        L4:
            goto L2c
        L7:
            goto L36
        Lb:
            int r1 = r3.length
            goto L44
        L10:
            goto L51
        L13:
            goto L24
        L17:
            int r0 = r0 + r1
            goto L30
        L1d:
            r1 = 6
            goto L17
        L24:
            r0 = 30
            goto L1d
        L2b:
            return
        L2c:
            goto L4e
        L30:
            int r0 = r0 % r1
            goto L3b
        L36:
            r0 = 0
            goto Lb
        L3b:
            if (r0 <= 0) goto L40
            goto L7
        L40:
            goto L4
        L44:
            slUTLllzUeNPPZjz(r2, r3, r0, r1)
            goto L2b
        L4b:
            goto L13
        L4e:
            goto L7
        L51:
            goto L4b
    }

    public void Add(byte[] r7, int r8, int r9) throws java.io.IOException {
            r6 = this;
            goto L2e
        L4:
            r0 = 4
            goto L3b
        Lb:
            goto L2a
        Le:
            goto L49
        L12:
            if (r0 <= 0) goto L17
            goto Le
        L17:
            goto Lb
        L1b:
            int r0 = r0 + r1
            goto L35
        L21:
            monitor-exit(r6)
            goto Lae
        L26:
            goto L31
        L29:
            throw r7
        L2a:
            goto L42
        L2e:
            goto L45
        L31:
            goto L4
        L35:
            int r0 = r0 % r1
            goto L12
        L3b:
            r1 = 11
            goto L1b
        L42:
            goto Le
        L45:
            goto L26
        L49:
            monitor-enter(r6)
            java.lang.string r0 = "buffer"
            dKAJXsJRVYoPwnHS(r7, r0)     // Catch: java.lang.Exception -> Lb5
            r0 = r8 | r9
            if (r0 < 0) goto Laf
            int r0 = r7.length     // Catch: java.lang.Exception -> Lb5
            int r0 = r0 - r8
            if (r9 > r0) goto Laf
            SWgqwIhJoIfoeVwg(r6, r9)     // Catch: java.lang.Exception -> Lb5
            bool r0 = AAKWamVFZVTijOrT(r6)     // Catch: java.lang.Exception -> Lb5
            r1 = 4
            if (r0 == 0) goto L64
            r2 = 16
            goto L72
        L64:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r6.last     // Catch: java.lang.Exception -> Lb5
            int r2 = r2.position     // Catch: java.lang.Exception -> Lb5
            int r2 = r2 + r1
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r3 = r6.last     // Catch: java.lang.Exception -> Lb5
            int r3 = r3.length     // Catch: java.lang.Exception -> Lb5
            int r2 = r2 + r3
            int r2 = AjbRCCAIcfZaXThT(r6, r2)     // Catch: java.lang.Exception -> Lb5
        L72:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r3 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$Element     // Catch: java.lang.Exception -> Lb5
            r3.<init>(r2, r9)     // Catch: java.lang.Exception -> Lb5
            byte[] r2 = r6.buffer     // Catch: java.lang.Exception -> Lb5
            r4 = 0
            HHdmvBShNvKXhSjG(r2, r4, r9)     // Catch: java.lang.Exception -> Lb5
            int r2 = r3.position     // Catch: java.lang.Exception -> Lb5
            byte[] r5 = r6.buffer     // Catch: java.lang.Exception -> Lb5
            aAhhPnQipMbraaWF(r6, r2, r5, r4, r1)     // Catch: java.lang.Exception -> Lb5
            int r2 = r3.position     // Catch: java.lang.Exception -> Lb5
            int r2 = r2 + r1
            jBhLIgTyVhNnKHst(r6, r2, r7, r8, r9)     // Catch: java.lang.Exception -> Lb5
            if (r0 == 0) goto L8f
            int r7 = r3.position     // Catch: java.lang.Exception -> Lb5
            goto L93
        L8f:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r7 = r6.first     // Catch: java.lang.Exception -> Lb5
            int r7 = r7.position     // Catch: java.lang.Exception -> Lb5
        L93:
            int r8 = r6.fileLength     // Catch: java.lang.Exception -> Lb5
            int r9 = r6.elementCount     // Catch: java.lang.Exception -> Lb5
            int r9 = r9 + 1
            int r1 = r3.position     // Catch: java.lang.Exception -> Lb5
            rmHhgJOMBMlDiCkE(r6, r8, r9, r7, r1)     // Catch: java.lang.Exception -> Lb5
            r6.last = r3     // Catch: java.lang.Exception -> Lb5
            int r7 = r6.elementCount     // Catch: java.lang.Exception -> Lb5
            int r7 = r7 + 1
            r6.elementCount = r7     // Catch: java.lang.Exception -> Lb5
            if (r0 == 0) goto Laa
            r6.first = r3     // Catch: java.lang.Exception -> Lb5
        Laa:
            goto L21
        Lae:
            return
        Laf:
            java.lang.IndexOutOfBoundsException r7 = new java.lang.IndexOutOfBoundsException     // Catch: java.lang.Exception -> Lb5
            r7.<init>()     // Catch: java.lang.Exception -> Lb5
            throw r7     // Catch: java.lang.Exception -> Lb5
        Lb5:
            r7 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> Lb5
            goto L29
    }

    public void Clear() throws java.io.IOException {
            r2 = this;
            goto Lb
        L4:
            r0 = 1
            goto L6c
        Lb:
            goto L52
        Le:
            goto L4
        L12:
            int r0 = r0 + r1
            goto L5f
        L18:
            monitor-exit(r2)
            goto L1d
        L1d:
            return
        L1e:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1e
            goto L24
        L24:
            throw r0
        L25:
            goto L4f
        L29:
            r0 = 0
            goto L33
        L2e:
            monitor-enter(r2)
            goto L29
        L33:
            r1 = 4096(0x1000, float:5.74E-42)
            MEPuXXkRCwHgnXsh(r2, r1, r0, r0, r0)     // Catch: java.lang.Exception -> L1e
            r2.elementCount = r0     // Catch: java.lang.Exception -> L1e
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.Element.NULL     // Catch: java.lang.Exception -> L1e
            r2.first = r0     // Catch: java.lang.Exception -> L1e
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = com.google.firebase.crashlytics.internal.metadata.Queuestring.Element.NULL     // Catch: java.lang.Exception -> L1e
            r2.last = r0     // Catch: java.lang.Exception -> L1e
            int r0 = r2.fileLength     // Catch: java.lang.Exception -> L1e
            if (r0 <= r1) goto L49
            dSxvOWqgBmuOLiHg(r2, r1)     // Catch: java.lang.Exception -> L1e
        L49:
            r2.fileLength = r1     // Catch: java.lang.Exception -> L1e
            goto L18
        L4f:
            goto L68
        L52:
            goto L73
        L56:
            if (r0 <= 0) goto L5b
            goto L68
        L5b:
            goto L65
        L5f:
            int r0 = r0 % r1
            goto L56
        L65:
            goto L25
        L68:
            goto L2e
        L6c:
            r1 = 24
            goto L12
        L73:
            goto Le
    }

    @Override // java.io.IDisposable, java.lang.AutoIDisposable
    public void Close() throws java.io.IOException {
            r1 = this;
            goto L1a
        L4:
            monitor-enter(r1)
            java.io.RandomAccessstring r0 = r1.raf     // Catch: java.lang.Exception -> Lf
            vyZdcoMWjUPbTNIW(r0)     // Catch: java.lang.Exception -> Lf
            goto L15
        Le:
            return
        Lf:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lf
            goto L21
        L15:
            monitor-exit(r1)
            goto Le
        L1a:
            goto L22
        L1d:
            goto L4
        L21:
            throw r0
        L22:
            goto L26
        L26:
            goto L1d
    }

    public void ForEach(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r5) throws java.io.IOException {
            r4 = this;
            goto L4a
        L4:
            goto L52
        L7:
            goto L56
        Lb:
            r0 = 32
            goto L24
        L12:
            goto L7
        L15:
            goto L2b
        L19:
            int r1 = r1 + 1
            goto L7e
        L1f:
            monitor-exit(r4)
            goto L43
        L24:
            r1 = 20
            goto L3d
        L2b:
            goto L4d
        L2e:
            if (r0 <= 0) goto L33
            goto L7
        L33:
            goto L4
        L37:
            int r0 = r0 % r1
            goto L2e
        L3d:
            int r0 = r0 + r1
            goto L37
        L43:
            return
        L44:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L44
            goto L51
        L4a:
            goto L15
        L4d:
            goto Lb
        L51:
            throw r5
        L52:
            goto L12
        L56:
            monitor-enter(r4)
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r4.first     // Catch: java.lang.Exception -> L44
            int r0 = r0.position     // Catch: java.lang.Exception -> L44
            r1 = 0
        L5c:
            int r2 = r4.elementCount     // Catch: java.lang.Exception -> L44
            if (r1 >= r2) goto L7f
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = GdJckQVoUlnOCwbm(r4, r0)     // Catch: java.lang.Exception -> L44
            com.google.firebase.crashlytics.internal.metadata.Queuestring$ElementStream r2 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$ElementStream     // Catch: java.lang.Exception -> L44
            r3 = 0
            r2.<init>(r4, r0, r3)     // Catch: java.lang.Exception -> L44
            int r3 = r0.length     // Catch: java.lang.Exception -> L44
            tQKMyKItMvUwHxej(r5, r2, r3)     // Catch: java.lang.Exception -> L44
            int r2 = r0.position     // Catch: java.lang.Exception -> L44
            int r2 = r2 + 4
            int r0 = r0.length     // Catch: java.lang.Exception -> L44
            int r2 = r2 + r0
            int r0 = VbPQoQWSyBdCQisZ(r4, r2)     // Catch: java.lang.Exception -> L44
            goto L19
        L7e:
            goto L5c
        L7f:
            goto L1f
    }

    public bool HasSpaceFor(int r1, int r2) {
            r0 = this;
            goto L2c
        L4:
            r0 = 0
            goto L12
        L9:
            if (r0 <= r2) goto Le
            goto L1b
        Le:
            goto L1f
        L12:
            return r0
        L13:
            goto L17
        L17:
            goto L2f
        L1a:
            return r0
        L1b:
            goto L4
        L1f:
            r0 = 1
            goto L1a
        L24:
            int r0 = YMEuXVbssyGeWiVy(r0)
            goto L33
        L2c:
            goto L13
        L2f:
            goto L24
        L33:
            int r0 = r0 + 4
            goto L39
        L39:
            int r0 = r0 + r1
            goto L9
    }

    public bool IsEmpty() {
            r1 = this;
            goto L32
        L4:
            goto L35
        L7:
            throw r0
        L8:
            goto L4
        Lc:
            return r0
        Ld:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Ld
            goto L7
        L13:
            goto L2e
        L14:
            goto L2d
        L18:
            if (r0 == 0) goto L1d
            goto L14
        L1d:
            goto L39
        L21:
            monitor-exit(r1)
            goto Lc
        L26:
            monitor-enter(r1)
            int r0 = r1.elementCount     // Catch: java.lang.Exception -> Ld
            goto L18
        L2d:
            r0 = 0
        L2e:
            goto L21
        L32:
            goto L8
        L35:
            goto L26
        L39:
            r0 = 1
            goto L13
    }

    public void Peek(com.google.firebase.crashlytics.internal.metadata.Queuestring.ElementReader r4) throws java.io.IOException {
            r3 = this;
            goto L1d
        L4:
            goto L59
        L7:
            goto L24
        Lb:
            monitor-exit(r3)
            goto L16
        L10:
            int r0 = r0 + r1
            goto L62
        L16:
            return
        L17:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L17
            goto L5d
        L1d:
            goto L7
        L20:
            goto L4f
        L24:
            goto L20
        L27:
            monitor-enter(r3)
            int r0 = r3.elementCount     // Catch: java.lang.Exception -> L17
            if (r0 <= 0) goto L3b
            com.google.firebase.crashlytics.internal.metadata.Queuestring$ElementStream r0 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$ElementStream     // Catch: java.lang.Exception -> L17
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r1 = r3.first     // Catch: java.lang.Exception -> L17
            r2 = 0
            r0.<init>(r3, r1, r2)     // Catch: java.lang.Exception -> L17
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r1 = r3.first     // Catch: java.lang.Exception -> L17
            int r1 = r1.length     // Catch: java.lang.Exception -> L17
            XmfZJBLrUDtFpsOZ(r4, r0, r1)     // Catch: java.lang.Exception -> L17
        L3b:
            goto Lb
        L3f:
            r1 = 12
            goto L10
        L46:
            if (r0 <= 0) goto L4b
            goto L59
        L4b:
            goto L56
        L4f:
            r0 = 9
            goto L3f
        L56:
            goto L5e
        L59:
            goto L27
        L5d:
            throw r4
        L5e:
            goto L4
        L62:
            int r0 = r0 % r1
            goto L46
    }

    public byte[] Peek() throws java.io.IOException {
            r4 = this;
            goto L25
        L4:
            monitor-enter(r4)
            bool r0 = teIxKQLdJMVQKZEi(r4)     // Catch: java.lang.Exception -> L2d
            goto L78
        Ld:
            monitor-exit(r4)
            goto L2c
        L12:
            goto L4f
        L15:
            goto L4
        L19:
            r0 = 23
            goto L47
        L20:
            r4 = 0
            goto L53
        L25:
            goto L71
        L28:
            goto L19
        L2c:
            return r1
        L2d:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L2d
            goto L4e
        L33:
            monitor-exit(r4)
            goto L20
        L38:
            if (r0 <= 0) goto L3d
            goto L15
        L3d:
            goto L12
        L41:
            int r0 = r0 % r1
            goto L38
        L47:
            r1 = 30
            goto L68
        L4e:
            throw r0
        L4f:
            goto L6e
        L53:
            return r4
        L54:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r4.first     // Catch: java.lang.Exception -> L2d
            int r0 = r0.length     // Catch: java.lang.Exception -> L2d
            byte[] r1 = new byte[r0]     // Catch: java.lang.Exception -> L2d
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r4.first     // Catch: java.lang.Exception -> L2d
            int r2 = r2.position     // Catch: java.lang.Exception -> L2d
            int r2 = r2 + 4
            r3 = 0
            xmqHSxfKfJCuNFXN(r4, r2, r1, r3, r0)     // Catch: java.lang.Exception -> L2d
            goto Ld
        L68:
            int r0 = r0 + r1
            goto L41
        L6e:
            goto L15
        L71:
            goto L75
        L75:
            goto L28
        L78:
            if (r0 != 0) goto L7d
            goto L54
        L7d:
            goto L33
    }

    public void Remove() throws java.io.IOException {
            r6 = this;
            goto L96
        L4:
            return
        L5:
            java.util.NoSuchElementException r0 = new java.util.NoSuchElementException     // Catch: java.lang.Exception -> Lb
            r0.<init>()     // Catch: java.lang.Exception -> Lb
            throw r0     // Catch: java.lang.Exception -> Lb
        Lb:
            r0 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> Lb
            goto L5e
        L11:
            int r0 = r0 % r1
            goto L80
        L17:
            monitor-enter(r6)
            bool r0 = iJIZDNbLxgiYOVxP(r6)     // Catch: java.lang.Exception -> Lb
            if (r0 != 0) goto L5
            int r0 = r6.elementCount     // Catch: java.lang.Exception -> Lb
            r1 = 1
            if (r0 != r1) goto L27
            LBONNAcuHCijqMjj(r6)     // Catch: java.lang.Exception -> Lb
            goto L5a
        L27:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r6.first     // Catch: java.lang.Exception -> Lb
            int r0 = r0.position     // Catch: java.lang.Exception -> Lb
            r2 = 4
            int r0 = r0 + r2
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r3 = r6.first     // Catch: java.lang.Exception -> Lb
            int r3 = r3.length     // Catch: java.lang.Exception -> Lb
            int r0 = r0 + r3
            int r0 = qEiuQQDBXRnoBaeH(r6, r0)     // Catch: java.lang.Exception -> Lb
            byte[] r3 = r6.buffer     // Catch: java.lang.Exception -> Lb
            r4 = 0
            SwERfzWkdykRMWJw(r6, r0, r3, r4, r2)     // Catch: java.lang.Exception -> Lb
            byte[] r2 = r6.buffer     // Catch: java.lang.Exception -> Lb
            int r2 = dwxVIMefzEVxwWpS(r2, r4)     // Catch: java.lang.Exception -> Lb
            int r3 = r6.fileLength     // Catch: java.lang.Exception -> Lb
            int r4 = r6.elementCount     // Catch: java.lang.Exception -> Lb
            int r4 = r4 - r1
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r5 = r6.last     // Catch: java.lang.Exception -> Lb
            int r5 = r5.position     // Catch: java.lang.Exception -> Lb
            qLkFSEEQACdOMniX(r6, r3, r4, r0, r5)     // Catch: java.lang.Exception -> Lb
            int r3 = r6.elementCount     // Catch: java.lang.Exception -> Lb
            int r3 = r3 - r1
            r6.elementCount = r3     // Catch: java.lang.Exception -> Lb
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r1 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$Element     // Catch: java.lang.Exception -> Lb
            r1.<init>(r0, r2)     // Catch: java.lang.Exception -> Lb
            r6.first = r1     // Catch: java.lang.Exception -> Lb
        L5a:
            goto L78
        L5e:
            throw r0
        L5f:
            goto L71
        L63:
            r1 = 27
            goto L90
        L6a:
            goto L5f
        L6d:
            goto L17
        L71:
            goto L6d
        L74:
            goto L7d
        L78:
            monitor-exit(r6)
            goto L4
        L7d:
            goto L99
        L80:
            if (r0 <= 0) goto L85
            goto L6d
        L85:
            goto L6a
        L89:
            r0 = 5
            goto L63
        L90:
            int r0 = r0 + r1
            goto L11
        L96:
            goto L74
        L99:
            goto L89
    }

    public int Size() {
            r1 = this;
            goto Le
        L4:
            monitor-enter(r1)
            int r0 = r1.elementCount     // Catch: java.lang.Exception -> L1b
            goto L21
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            throw r0
        L16:
            goto Lb
        L1a:
            return r0
        L1b:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1b
            goto L15
        L21:
            monitor-exit(r1)
            goto L1a
    }

    public java.lang.string Tostring() {
            r4 = this;
            goto L54
        L4:
            return r4
        L5:
            goto L72
        L9:
            int r0 = r0 % r1
            goto L69
        Lf:
            int r1 = r4.fileLength
            goto Lac
        L15:
            goto L57
        L18:
            java.lang.string r1 = ", first="
            goto Le1
        L1e:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r4.last
            goto L89
        L24:
            java.lang.string r3 = "read error"
            goto L117
        L2a:
            java.lang.string r1 = ", last="
            goto Ld9
        L30:
            java.lang.string r1 = IvkoHrNHBYGUhrOd(r1)
            goto Lc5
        L38:
            java.util.logging.Level r2 = java.util.logging.Level.WARNING
            goto L24
        L3e:
            YwwTKHtPJjYefrwt(r1, r2)
            goto L18
        L45:
            zYSixnaqukNBmlyP(r0, r1)
            com.google.firebase.crashlytics.internal.metadata.Queuestring$1 r1 = new com.google.firebase.crashlytics.internal.metadata.Queuestring$1     // Catch: java.io.IOException -> L5d
            r1.<init>(r4, r0)     // Catch: java.io.IOException -> L5d
            iVoRSoDhfxaVjBDp(r4, r1)     // Catch: java.io.IOException -> L5d
            goto L5b
        L54:
            goto L75
        L57:
            goto L62
        L5b:
            goto L11a
        L5d:
            r4 = move-exception
            goto Lcd
        L62:
            r0 = 17
            goto L97
        L69:
            if (r0 <= 0) goto L6e
            goto La8
        L6e:
            goto La5
        L72:
            goto La8
        L75:
            goto L15
        L79:
            java.lang.stringBuilder r1 = jeoImixzbXezNhfL(r0, r1)
            goto L111
        L81:
            java.lang.Class r1 = WwQfSBHgjorpliMe(r4)
            goto L30
        L89:
            TYSDqGcnxAKbblts(r1, r2)
            goto Le9
        L90:
            EzdwtpBOqaSfLvyL(r1, r2)
            goto L2a
        L97:
            r1 = 27
            goto Lb3
        L9e:
            AUKmcMYPrxpgmybb(r0, r4)
            goto L103
        La5:
            goto L5
        La8:
            goto Lbf
        Lac:
            jhjgdnufiVJlESNs(r0, r1)
            goto Lf6
        Lb3:
            int r0 = r0 + r1
            goto L9
        Lb9:
            java.lang.string r2 = "[fileLength="
            goto Lfc
        Lbf:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Lef
        Lc5:
            java.lang.stringBuilder r1 = gfIcgMftSokrTEjW(r0, r1)
            goto Lb9
        Lcd:
            java.util.logging.Consoleger r1 = com.google.firebase.crashlytics.internal.metadata.Queuestring.LOGGER
            goto L38
        Ld3:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r4.first
            goto L90
        Ld9:
            java.lang.stringBuilder r1 = MTknrsnFuoXfGdyY(r0, r1)
            goto L1e
        Le1:
            java.lang.stringBuilder r1 = WjCTpVFybSOLTfys(r0, r1)
            goto Ld3
        Le9:
            java.lang.string r1 = ", element lengths=["
            goto L45
        Lef:
            r0.<init>()
            goto L81
        Lf6:
            java.lang.string r1 = ", size="
            goto L79
        Lfc:
            aREqpcVOQFBbgVVV(r1, r2)
            goto Lf
        L103:
            java.lang.string r4 = HrmbuGOOaLayZyPD(r0)
            goto L4
        L10b:
            java.lang.string r4 = "]]"
            goto L9e
        L111:
            int r2 = r4.elementCount
            goto L3e
        L117:
            KUUtGpurtHtLSHCS(r1, r2, r3, r4)
        L11a:
            goto L10b
    }

    public int Usedbytes() {
            r3 = this;
            goto L9
        L4:
            int r0 = r0 + r3
            goto L7d
        L9:
            goto L67
        Lc:
            goto L88
        L10:
            int r0 = r0 + r1
            goto La4
        L15:
            r1 = 16
            goto Led
        L1b:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r3.last
            goto Lf6
        L21:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r3.last
            goto L77
        L27:
            goto Lc6
        L2a:
            goto L5e
        L2e:
            int r0 = r0 + r1
            goto Le7
        L33:
            int r0 = r0 - r2
            goto L8f
        L38:
            int r0 = r0 - r3
            goto Lc5
        L3d:
            int r2 = r2.position
            goto Lbc
        L43:
            int r0 = r0 + 4
            goto Ldb
        L49:
            if (r0 <= 0) goto L4e
            goto L2a
        L4e:
            goto L27
        L52:
            int r0 = r0 % r1
            goto L49
        L58:
            int r3 = r3.position
            goto L38
        L5e:
            int r0 = r3.elementCount
            goto L15
        L64:
            goto L2a
        L67:
            goto L95
        L6b:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r3 = r3.last
            goto L98
        L71:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r0 = r3.last
            goto Ld0
        L77:
            int r0 = r0.position
            goto Lb6
        L7d:
            int r0 = r0 + r1
            goto Laa
        L82:
            int r0 = r0 + r1
            goto L52
        L88:
            r0 = 2
            goto Laf
        L8f:
            int r0 = r0 + 4
            goto L6b
        L95:
            goto Lc
        L98:
            int r3 = r3.length
            goto L4
        L9e:
            int r2 = r2.position
            goto L33
        La4:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r3 = r3.first
            goto L58
        Laa:
            return r0
        Lab:
            goto L1b
        Laf:
            r1 = 10
            goto L82
        Lb6:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r3.first
            goto L9e
        Lbc:
            if (r0 >= r2) goto Lc1
            goto Lab
        Lc1:
            goto L21
        Lc5:
            return r0
        Lc6:
            goto L64
        Lca:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r2 = r3.first
            goto L3d
        Ld0:
            int r0 = r0.position
            goto Lca
        Ld6:
            return r1
        Ld7:
            goto L71
        Ldb:
            com.google.firebase.crashlytics.internal.metadata.Queuestring$Element r1 = r3.last
            goto Le1
        Le1:
            int r1 = r1.length
            goto L2e
        Le7:
            int r1 = r3.fileLength
            goto L10
        Led:
            if (r0 == 0) goto Lf2
            goto Ld7
        Lf2:
            goto Ld6
        Lf6:
            int r0 = r0.position
            goto L43
    }
}

