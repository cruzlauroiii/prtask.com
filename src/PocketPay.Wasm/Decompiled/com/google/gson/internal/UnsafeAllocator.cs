namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public abstract class UnsafeAllocator {
    public static readonly com.google.gson.internal.UnsafeAllocator INSTANCE = null;





    static {
            goto L12
        L4:
            com.google.gson.internal.UnsafeAllocator r0 = iGkbqiwIEtbnFUbl()
            goto Lc
        Lc:
            com.google.gson.internal.UnsafeAllocator.INSTANCE = r0
            goto L19
        L12:
            goto L1a
        L15:
            goto L4
        L19:
            return
        L1a:
            goto L1e
        L1e:
            goto L15
    }

    public UnsafeAllocator() {
            r0 = this;
            goto Le
        L4:
            goto L11
        L7:
            r0.<init>()
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

    public static java.lang.string FdKqCLyRDkiDHzgL(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto Le
    }

    public static void IfCurylLNSPyklqW(java.lang.Class r0) {
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
            assertInstantiable(r0)
            goto Le
    }

    public static java.lang.reflect.Method MAEWiENUqKWSdRSr(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.reflect.Method r0 = r1.getDeclaredMethod(r2, r3)
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

    public static java.lang.object MVMEqqIHIiFBVvvx(java.lang.reflect.Method r1, java.lang.object r2, java.lang.object[] r3) {
            goto L14
        L4:
            java.lang.object r0 = r1.invoke(r2, r3)
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

    public static void MtRmrjtqwVYwTnGY(java.lang.reflect.Method r0, bool r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.setAccessible(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static java.lang.stringBuilder PbEiRGeEWLALRjiW(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static java.lang.string QrhxyOvSACswkbRi(java.lang.Class r1) {
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
            java.lang.string r0 = com.google.gson.internal.ConstructorConstructor.checkInstantiable(r1)
            goto Le
    }

    public static void SzSqrcPSaBflCTYl(java.lang.reflect.Method r0, bool r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setAccessible(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static java.lang.reflect.Method WYjpLyeyaLrPeMiS(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
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
            java.lang.reflect.Method r0 = r1.getMethod(r2, r3)
            goto L4
    }

    public static java.lang.Class YdMyRsEHuXeRBuna(java.lang.string r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.Class r0 = java.lang.Class.forName(r1)
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

    static /* synthetic */ void access$000(java.lang.Class r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            IfCurylLNSPyklqW(r0)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    private static void AssertInstantiable(java.lang.Class<object> r3) {
            goto L4
        L4:
            goto L69
        L7:
            goto Lb
        Lb:
            r0 = 4
            goto L59
        L12:
            r0.<init>(r3)
            goto L7e
        L19:
            return
        L1a:
            goto L2d
        L1e:
            goto L7
        L21:
            int r0 = r0 + r1
            goto L3c
        L27:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L60
        L2d:
            java.lang.AssertionError r0 = new java.lang.AssertionError
            goto L27
        L33:
            if (r3 == 0) goto L38
            goto L1a
        L38:
            goto L19
        L3c:
            int r0 = r0 % r1
            goto L75
        L42:
            java.lang.string r3 = QrhxyOvSACswkbRi(r3)
            goto L33
        L4a:
            java.lang.stringBuilder r3 = PbEiRGeEWLALRjiW(r1, r3)
            goto L6d
        L52:
            r1.<init>(r2)
            goto L4a
        L59:
            r1 = 21
            goto L21
        L60:
            java.lang.string r2 = "UnsafeAllocator is used for non-instantiable type: "
            goto L52
        L66:
            goto L86
        L69:
            goto L1e
        L6d:
            java.lang.string r3 = FdKqCLyRDkiDHzgL(r3)
            goto L12
        L75:
            if (r0 <= 0) goto L7a
            goto L86
        L7a:
            goto L83
        L7e:
            throw r0
        L7f:
            goto L66
        L83:
            goto L7f
        L86:
            goto L42
    }

    private static com.google.gson.internal.UnsafeAllocator Create() {
            goto L83
        L4:
            r1 = 0
            goto La7
        L9:
            return r1
        La:
            goto L6f
        Le:
            int r0 = r0 + r1
            goto L5a
        L14:
            return r6
        L15:
            java.lang.Class<java.io.objectStream> r1 = java.io.objectStream.class
            java.lang.Class[] r4 = new java.lang.Class[r4]     // Catch: java.lang.Exception -> La
            java.lang.Class<java.lang.Class> r5 = java.lang.Class.class
            r4[r2] = r5     // Catch: java.lang.Exception -> La
            java.lang.Class<java.lang.Class> r2 = java.lang.Class.class
            r4[r3] = r2     // Catch: java.lang.Exception -> La
            java.lang.reflect.Method r0 = MAEWiENUqKWSdRSr(r1, r0, r4)     // Catch: java.lang.Exception -> La
            iBmtVDGyDstFCFQx(r0, r3)     // Catch: java.lang.Exception -> La
            com.google.gson.internal.UnsafeAllocator$3 r1 = new com.google.gson.internal.UnsafeAllocator$3     // Catch: java.lang.Exception -> La
            r1.<init>(r0)     // Catch: java.lang.Exception -> La
            goto L9
        L31:
            r3 = 1
            java.lang.string r4 = "sun.misc.Unsafe"
            java.lang.Class r4 = YdMyRsEHuXeRBuna(r4)     // Catch: java.lang.Exception -> L61
            java.lang.string r5 = "theUnsafe"
            java.lang.reflect.Field r5 = hqJEIudECvHYtYNj(r4, r5)     // Catch: java.lang.Exception -> L61
            dajBEGILhHlLZnAR(r5, r3)     // Catch: java.lang.Exception -> L61
            java.lang.object r5 = dAMXGuTlOKjGXqig(r5, r1)     // Catch: java.lang.Exception -> L61
            java.lang.string r6 = "allocateInstance"
            java.lang.Class[] r7 = new java.lang.Class[r3]     // Catch: java.lang.Exception -> L61
            java.lang.Class<java.lang.Class> r8 = java.lang.Class.class
            r7[r2] = r8     // Catch: java.lang.Exception -> L61
            java.lang.reflect.Method r4 = WYjpLyeyaLrPeMiS(r4, r6, r7)     // Catch: java.lang.Exception -> L61
            com.google.gson.internal.UnsafeAllocator$1 r6 = new com.google.gson.internal.UnsafeAllocator$1     // Catch: java.lang.Exception -> L61
            r6.<init>(r4, r5)     // Catch: java.lang.Exception -> L61
            goto L60
        L5a:
            int r0 = r0 % r1
            goto L97
        L60:
            return r6
        L61:
            goto Lb1
        L65:
            goto L86
        L68:
            r0 = 26
            goto L7c
        L6f:
            com.google.gson.internal.UnsafeAllocator$4 r0 = new com.google.gson.internal.UnsafeAllocator$4
            goto L90
        L75:
            goto Lad
        L78:
            goto L8a
        L7c:
            r1 = 3
            goto Le
        L83:
            goto La3
        L86:
            goto L68
        L8a:
            java.lang.string r0 = "newInstance"
            goto L4
        L90:
            r0.<init>()
            goto Lac
        L97:
            if (r0 <= 0) goto L9c
            goto L78
        L9c:
            goto L75
        La0:
            goto L78
        La3:
            goto L65
        La7:
            r2 = 0
            goto L31
        Lac:
            return r0
        Lad:
            goto La0
        Lb1:
            r4 = 2
            java.lang.Class<java.io.objectStreamClass> r5 = java.io.objectStreamClass.class
            java.lang.string r6 = "getConstructorId"
            java.lang.Class[] r7 = new java.lang.Class[r3]     // Catch: java.lang.Exception -> L15
            java.lang.Class<java.lang.Class> r8 = java.lang.Class.class
            r7[r2] = r8     // Catch: java.lang.Exception -> L15
            java.lang.reflect.Method r5 = pEymwvKcruDjggtC(r5, r6, r7)     // Catch: java.lang.Exception -> L15
            SzSqrcPSaBflCTYl(r5, r3)     // Catch: java.lang.Exception -> L15
            java.lang.Class<java.lang.object> r6 = java.lang.object.class
            java.lang.object[] r6 = new java.lang.object[]{r6}     // Catch: java.lang.Exception -> L15
            java.lang.object r1 = MVMEqqIHIiFBVvvx(r5, r1, r6)     // Catch: java.lang.Exception -> L15
            java.lang.int r1 = (java.lang.int) r1     // Catch: java.lang.Exception -> L15
            int r1 = qzxgpcXOjCAhebbE(r1)     // Catch: java.lang.Exception -> L15
            java.lang.Class<java.io.objectStreamClass> r5 = java.io.objectStreamClass.class
            java.lang.Class[] r6 = new java.lang.Class[r4]     // Catch: java.lang.Exception -> L15
            java.lang.Class<java.lang.Class> r7 = java.lang.Class.class
            r6[r2] = r7     // Catch: java.lang.Exception -> L15
            java.lang.Class r7 = java.lang.int.TYPE     // Catch: java.lang.Exception -> L15
            r6[r3] = r7     // Catch: java.lang.Exception -> L15
            java.lang.reflect.Method r5 = kHNMclSAncphQZBE(r5, r0, r6)     // Catch: java.lang.Exception -> L15
            MtRmrjtqwVYwTnGY(r5, r3)     // Catch: java.lang.Exception -> L15
            com.google.gson.internal.UnsafeAllocator$2 r6 = new com.google.gson.internal.UnsafeAllocator$2     // Catch: java.lang.Exception -> L15
            r6.<init>(r5, r1)     // Catch: java.lang.Exception -> L15
            goto L14
    }

    public static java.lang.object DAMXGuTlOKjGXqig(java.lang.reflect.Field r1, java.lang.object r2) {
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
            java.lang.object r0 = r1[r2)
            goto Le
    }

    public static void DajBEGILhHlLZnAR(java.lang.reflect.Field r0, bool r1) {
            goto L10
        L4:
            r0.setAccessible(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static java.lang.reflect.Field HqJEIudECvHYtYNj(java.lang.Class r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.reflect.Field r0 = r1.getDeclaredField(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void IBmtVDGyDstFCFQx(java.lang.reflect.Method r0, bool r1) {
            goto Le
        L4:
            goto L11
        L7:
            r0.setAccessible(r1)
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

    public static com.google.gson.internal.UnsafeAllocator IGkbqiwIEtbnFUbl() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.gson.internal.UnsafeAllocator r0 = create()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.reflect.Method KHNMclSAncphQZBE(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
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
            java.lang.reflect.Method r0 = r1.getDeclaredMethod(r2, r3)
            goto Le
    }

    public static java.lang.reflect.Method PEymwvKcruDjggtC(java.lang.Class r1, java.lang.string r2, java.lang.Class[] r3) {
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
            java.lang.reflect.Method r0 = r1.getDeclaredMethod(r2, r3)
            goto L7
    }

    public static int QzxgpcXOjCAhebbE(java.lang.int r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.intValue()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public abstract <T> T NewInstance(java.lang.Class<T> r1) throws java.lang.Exception;
}

