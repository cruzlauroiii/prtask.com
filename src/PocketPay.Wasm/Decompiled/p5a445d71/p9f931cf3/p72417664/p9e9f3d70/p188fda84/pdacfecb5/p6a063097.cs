namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes7.dex */
class p6a063097 : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    private java.security.PublicKey f047b2b56;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 f1751642c;
    private bool f1a74383f;
    private int f1dfa5bfa;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f201da641;
    private javax.security.auth.x500.X500Principal f22e12151;
    private long[] f2a70cc83;
    private javax.security.auth.x500.X500Principal f33ddd61f;
    private long[] f35cdadcd;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 f3983bfb6;
    private int f491de0d7;
    private javax.security.auth.x500.X500Principal f50bd04fa;
    private readonly java.lang.object f574c04d3;
    private java.security.PublicKey f608a7a0d;
    private long[] f6625c008;
    private readonly java.lang.object f684ece30;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f68622eef;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 f6c90e3fe;
    private readonly java.lang.object f85864305;
    private int f89e25c8a;
    private bool f93b0200a;
    private bool f9f651ec5;
    private readonly java.lang.object fa19d97df;
    private int fa4069d38;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb fc1aa0632;
    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 fcac9c5d9;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb fdf4b272d;
    private bool fe2011431;
    private javax.security.auth.x500.X500Principal ff125dffb;
    private readonly java.lang.object ffc505465;

    private static class p3393e2e6 : java.security.cert.CertificateEncodingException {
        private readonly java.lang.Exception f560220fc;
        private readonly java.lang.Exception f72fe9110;
        private readonly java.lang.Exception f8b24484c;
        private readonly java.lang.Exception f90d6fda9;
        private readonly java.lang.Exception fa39f2f57;

        p3393e2e6(java.lang.Exception r1) {
                r0 = this;
                goto L16
            L4:
                r0.f560220fc = r1
                goto La
            La:
                return
            Lb:
                goto L1d
            Lf:
                r0.<init>()
                goto L4
            L16:
                goto Lb
            L19:
                goto Lf
            L1d:
                goto L19
        }

        @Override // java.lang.Exception
        public java.lang.Exception GetCause() {
                r0 = this;
                goto L12
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L15
            Lc:
                java.lang.Exception r0 = r0.f560220fc
                goto L4
            L12:
                goto L5
            L15:
                goto Lc
        }
    }

    p6a063097(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 r8, p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r9) throws java.security.cert.CertificateParsingException {
            r7 = this;
            goto L52
        L4:
            r7.<init>()
            goto L64
        Lb:
            java.lang.string r5 = m83af66ea(r9)
            goto L98
        L13:
            r0 = r7
            goto L8c
        L18:
            r2 = r9
            goto L91
        L1d:
            java.lang.object r7 = new java.lang.object
            goto L4
        L23:
            if (r0 <= 0) goto L28
            goto L48
        L28:
            goto L45
        L2c:
            r0.f201da641 = r7
            goto L32
        L32:
            return
        L33:
            goto L76
        L37:
            r0 = 32
            goto L3e
        L3e:
            r1 = 27
            goto L4c
        L45:
            goto L33
        L48:
            goto L5c
        L4c:
            int r0 = r0 + r1
            goto L70
        L52:
            goto L79
        L55:
            goto L37
        L59:
            goto L55
        L5c:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 r3 = m149188ef(r9)
            goto L84
        L64:
            r0.f684ece30 = r7
            goto L6a
        L6a:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64 r7 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64
            goto L7d
        L70:
            int r0 = r0 % r1
            goto L23
        L76:
            goto L48
        L79:
            goto L59
        L7d:
            r7.<init>()
            goto L2c
        L84:
            bool[] r4 = m0354c228(r9)
            goto Lb
        L8c:
            r1 = r8
            goto L18
        L91:
            r0.<init>(r1, r2, r3, r4, r5, r6)
            goto L1d
        L98:
            byte[] r6 = mbabc5ce6(r9)
            goto L13
    }

    private static bool[] M0354c228(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r7) throws java.security.cert.CertificateParsingException {
            goto L58
        L4:
            goto L6c
        L7:
            java.lang.string r0 = "2.5.29.15"
            byte[] r7 = getExtensionOctets(r7, r0)     // Catch: java.lang.Exception -> Lb5
            if (r7 != 0) goto L11
            r7 = 0
            return r7
        L11:
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 r7 = p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(r7)     // Catch: java.lang.Exception -> Lb5
            p5a445d71.p9f931cf3.pca323100.p1522cc54 r7 = p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102(r7)     // Catch: java.lang.Exception -> Lb5
            byte[] r0 = r7.getbytes()     // Catch: java.lang.Exception -> Lb5
            int r1 = r0.length     // Catch: java.lang.Exception -> Lb5
            int r1 = r1 * 8
            int r7 = r7.getPadBits()     // Catch: java.lang.Exception -> Lb5
            int r1 = r1 - r7
            r7 = 9
            if (r1 >= r7) goto L2a
            goto L2b
        L2a:
            r7 = r1
        L2b:
            bool[] r7 = new bool[r7]     // Catch: java.lang.Exception -> Lb5
            r2 = 0
            r3 = r2
        L2f:
            if (r3 == r1) goto L80
            int r4 = r3 / 8
            r4 = r0[r4]     // Catch: java.lang.Exception -> Lb5
            int r5 = r3 % 8
            r6 = 128(0x80, float:1.8E-43)
            int r5 = r6 >>> r5
            r4 = r4 & r5
            if (r4 == 0) goto L40
            r4 = 1
            goto L41
        L40:
            r4 = r2
        L41:
            r7[r3] = r4     // Catch: java.lang.Exception -> Lb5
            goto L84
        L47:
            r0.<init>(r7)
            goto L6b
        L4e:
            goto L5b
        L51:
            r1.<init>(r2)
            goto Lac
        L58:
            goto L99
        L5b:
            goto Lba
        L5f:
            java.lang.string r2 = "cannot construct KeyUsage: "
            goto L51
        L65:
            java.security.cert.CertificateParsingException r0 = new java.security.cert.CertificateParsingException
            goto L9d
        L6b:
            throw r0
        L6c:
            goto L96
        L70:
            java.lang.string r7 = r7.tostring()
            goto L47
        L78:
            r1 = 19
            goto L90
        L7f:
            goto L2f
        L80:
            goto Lb4
        L84:
            int r3 = r3 + 1
            goto L7f
        L8a:
            int r0 = r0 % r1
            goto La3
        L90:
            int r0 = r0 + r1
            goto L8a
        L96:
            goto L7
        L99:
            goto L4e
        L9d:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L5f
        La3:
            if (r0 <= 0) goto La8
            goto L7
        La8:
            goto L4
        Lac:
            java.lang.stringBuilder r7 = r1.append(r7)
            goto L70
        Lb4:
            return r7
        Lb5:
            r7 = move-exception
            goto L65
        Lba:
            r0 = 27
            goto L78
    }

    private static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 M149188ef(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r3) throws java.security.cert.CertificateParsingException {
            goto L24
        L4:
            r0.<init>(r3)
            goto L39
        Lb:
            return r3
        Lc:
            r3 = move-exception
            goto L18
        L11:
            r0 = 7
            goto L76
        L18:
            java.security.cert.CertificateParsingException r0 = new java.security.cert.CertificateParsingException
            goto L86
        L1e:
            java.lang.string r2 = "cannot construct BasicConstraints: "
            goto L5e
        L24:
            goto L41
        L27:
            goto L11
        L2b:
            int r0 = r0 % r1
            goto L7d
        L31:
            java.lang.string r3 = r3.tostring()
            goto L4
        L39:
            throw r0
        L3a:
            goto L3e
        L3e:
            goto L48
        L41:
            goto L6d
        L45:
            goto L3a
        L48:
            java.lang.string r0 = "2.5.29.19"
            byte[] r3 = getExtensionOctets(r3, r0)     // Catch: java.lang.Exception -> Lc
            if (r3 != 0) goto L52
            r3 = 0
            return r3
        L52:
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 r3 = p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(r3)     // Catch: java.lang.Exception -> Lc
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 r3 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11.m8bab0102(r3)     // Catch: java.lang.Exception -> Lc
            goto Lb
        L5e:
            r1.<init>(r2)
            goto L65
        L65:
            java.lang.stringBuilder r3 = r1.append(r3)
            goto L31
        L6d:
            goto L27
        L70:
            int r0 = r0 + r1
            goto L2b
        L76:
            r1 = 17
            goto L70
        L7d:
            if (r0 <= 0) goto L82
            goto L48
        L82:
            goto L45
        L86:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L1e
    }

    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 M3ff6ddc5() {
            r12 = this;
            goto L44
        L4:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 r6 = r12.f8966d166
            goto L64
        La:
            r11 = r2
        Lb:
            goto L1f
        Lf:
            goto Lb
        L10:
            r0 = move-exception
            goto Lde
        L15:
            goto Ld5
        L18:
            goto L70
        L1c:
            goto L47
        L1f:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r3 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454
            goto L4b
        L25:
            int r0 = r0 % r1
            goto La0
        L2b:
            r1 = 28
            goto L6a
        L32:
            monitor-enter(r1)
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r0 = r12.fcac9c5d9     // Catch: java.lang.Exception -> L3f
            if (r0 == 0) goto L39
            monitor-exit(r1)     // Catch: java.lang.Exception -> L3f
            return r0
        L39:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L3f
            goto L76
        L3e:
            throw r12
        L3f:
            r0 = move-exception
            goto Lb5
        L44:
            goto Lb1
        L47:
            goto Lc7
        L4b:
            p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 r4 = r12.f723435f3
            goto Lce
        L51:
            java.lang.object r2 = r12.f684ece30
            goto L88
        L57:
            r2.<init>(r0)
            goto La9
        L5e:
            java.lang.string r8 = r12.f2505866c
            goto L9a
        L64:
            bool[] r7 = r12.fd5edbddb
            goto L5e
        L6a:
            int r0 = r0 + r1
            goto L25
        L70:
            java.lang.object r1 = r12.f684ece30
            goto L32
        L76:
            r1 = 0
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r0 = r12.f4a8a08f0     // Catch: java.io.IOException -> L10
            java.lang.string r2 = "ffdda26cedc437534c55ee9300d68a8f5d9e4f2e8e8ce7e8e3537573c564c8"
            java.lang.string r2 = com.decryptstringmanager.Decryptstring.decryptstring(r2)     // Catch: java.io.IOException -> L10
            byte[] r0 = r0.getEncoded(r2)     // Catch: java.io.IOException -> L10
            goto Ld9
        L88:
            monitor-enter(r2)
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r0 = r12.fcac9c5d9     // Catch: java.lang.Exception -> L93
            if (r0 != 0) goto L8f
            r12.fcac9c5d9 = r3     // Catch: java.lang.Exception -> L93
        L8f:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r12 = r12.fcac9c5d9     // Catch: java.lang.Exception -> L93
            monitor-exit(r2)     // Catch: java.lang.Exception -> L93
            return r12
        L93:
            r0 = move-exception
            r12 = r0
            monitor-exit(r2)     // Catch: java.lang.Exception -> L93
            goto L3e
        L9a:
            byte[] r9 = r12.fdfef16e0
            goto Lc0
        La0:
            if (r0 <= 0) goto La5
            goto L18
        La5:
            goto L15
        La9:
            r10 = r1
            goto La
        Lae:
            goto L18
        Lb1:
            goto L1c
        Lb5:
            r12 = r0
            monitor-exit(r1)     // Catch: java.lang.Exception -> L3f
            goto Ld4
        Lbb:
            r11 = r1
            goto Lf
        Lc0:
            r3.<init>(r4, r5, r6, r7, r8, r9, r10, r11)
            goto L51
        Lc7:
            r0 = 21
            goto L2b
        Lce:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r5 = r12.f4a8a08f0
            goto L4
        Ld4:
            throw r12
        Ld5:
            goto Lae
        Ld9:
            r10 = r0
            goto Lbb
        Lde:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097$p3393e2e6 r2 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097$p3393e2e6
            goto L57
    }

    private static java.lang.string M83af66ea(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r3) throws java.security.cert.CertificateParsingException {
            goto L5a
        L4:
            int r0 = r0 % r1
            goto L16
        La:
            return r3
        Lb:
            r3 = move-exception
            goto L10
        L10:
            java.security.cert.CertificateParsingException r0 = new java.security.cert.CertificateParsingException
            goto L54
        L16:
            if (r0 <= 0) goto L1b
            goto L73
        L1b:
            goto L70
        L1f:
            throw r0
        L20:
            goto L24
        L24:
            goto L73
        L27:
            goto L7f
        L2b:
            java.lang.string r3 = r3.tostring()
            goto L39
        L33:
            java.lang.string r2 = "cannot construct SigAlgName: "
            goto L69
        L39:
            r0.<init>(r3)
            goto L1f
        L40:
            r1 = 28
            goto L4e
        L47:
            r0 = 12
            goto L40
        L4e:
            int r0 = r0 + r1
            goto L4
        L54:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L33
        L5a:
            goto L27
        L5d:
            goto L47
        L61:
            java.lang.stringBuilder r3 = r1.append(r3)
            goto L2b
        L69:
            r1.<init>(r2)
            goto L61
        L70:
            goto L20
        L73:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 r3 = r3.getSignatureAlgorithm()     // Catch: java.lang.Exception -> Lb
            java.lang.string r3 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m6d7cc104(r3)     // Catch: java.lang.Exception -> Lb
            goto La
        L7f:
            goto L5d
    }

    private static byte[] Mbabc5ce6(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r3) throws java.security.cert.CertificateParsingException {
            goto L57
        L4:
            r1.<init>(r2)
            goto L6a
        Lb:
            goto L5a
        Le:
            goto L38
        L11:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 r3 = r3.getSignatureAlgorithm()     // Catch: java.lang.Exception -> L65
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 r3 = r3.getParameters()     // Catch: java.lang.Exception -> L65
            if (r3 != 0) goto L1d
            r3 = 0
            return r3
        L1d:
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 r3 = r3.toASN1Primitive()     // Catch: java.lang.Exception -> L65
            java.lang.string r0 = "04fd2c49aa53b66f7282b937adbfd10638ba1e1af688dc3bcd958948d3fa1f"
            java.lang.string r0 = com.decryptstringmanager.Decryptstring.decryptstring(r0)     // Catch: java.lang.Exception -> L65
            byte[] r3 = r3.getEncoded(r0)     // Catch: java.lang.Exception -> L65
            goto L64
        L30:
            goto L11
        L33:
            goto Lb
        L37:
            throw r0
        L38:
            goto L30
        L3c:
            int r0 = r0 % r1
            goto L78
        L42:
            int r0 = r0 + r1
            goto L3c
        L48:
            r0 = 3
            goto L81
        L4f:
            java.lang.string r3 = r3.tostring()
            goto L88
        L57:
            goto L33
        L5a:
            goto L48
        L5e:
            java.lang.string r2 = "cannot construct SigAlgParams: "
            goto L4
        L64:
            return r3
        L65:
            r3 = move-exception
            goto L8f
        L6a:
            java.lang.stringBuilder r3 = r1.append(r3)
            goto L4f
        L72:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L5e
        L78:
            if (r0 <= 0) goto L7d
            goto L11
        L7d:
            goto Le
        L81:
            r1 = 25
            goto L42
        L88:
            r0.<init>(r3)
            goto L37
        L8f:
            java.security.cert.CertificateParsingException r0 = new java.security.cert.CertificateParsingException
            goto L72
    }

    @Override // p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a, java.security.cert.X509Certificate
    public void CheckValidity(java.util.DateTime r5) throws java.security.cert.CertificateExpiredException, java.security.cert.CertificateNotYetValidException {
            r4 = this;
            goto L105
        L4:
            throw r5
        L5:
            goto L98
        L9:
            long[] r5 = r4.getValidityValues()
            goto Lcb
        L11:
            int r2 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L84
        L17:
            r2 = r5[r2]
            goto L5a
        L1d:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r4 = r4.f4a8a08f0
            goto Lbc
        L23:
            if (r5 >= 0) goto L28
            goto L11a
        L28:
            goto L119
        L2c:
            java.lang.string r1 = "certificate expired on "
            goto Lf6
        L32:
            if (r0 <= 0) goto L37
            goto L115
        L37:
            goto L112
        L3b:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5 r4 = r4.getEndDateTime()
            goto L60
        L43:
            int r0 = r0 + r1
            goto L6f
        L49:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r4 = r4.f4a8a08f0
            goto L3b
        L4f:
            java.lang.stringBuilder r4 = r0.append(r4)
            goto La5
        L57:
            goto L108
        L5a:
            int r5 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L23
        L60:
            java.lang.string r4 = r4.getTime()
            goto L4f
        L68:
            r5.<init>(r4)
            goto L4
        L6f:
            int r0 = r0 % r1
            goto L32
        L75:
            r0 = 7
            goto Lad
        L7c:
            long r0 = r5.getTime()
            goto L9
        L84:
            if (r2 <= 0) goto L89
            goto Ld1
        L89:
            goto L8d
        L8d:
            r2 = 0
            goto L17
        L92:
            java.security.cert.CertificateExpiredException r5 = new java.security.cert.CertificateExpiredException
            goto Ld5
        L98:
            goto L115
        L9b:
            goto L57
        L9f:
            r2 = r5[r2]
            goto L11
        La5:
            java.lang.string r4 = r4.tostring()
            goto L68
        Lad:
            r1 = 21
            goto L43
        Lb4:
            java.lang.string r4 = r4.getTime()
            goto Lfd
        Lbc:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5 r4 = r4.getStartDateTime()
            goto Lb4
        Lc4:
            r0.<init>(r1)
            goto L1d
        Lcb:
            r2 = 1
            goto L9f
        Ld0:
            throw r5
        Ld1:
            goto L92
        Ld5:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L2c
        Ldb:
            java.lang.string r4 = r4.tostring()
            goto Le9
        Le3:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Lf0
        Le9:
            r5.<init>(r4)
            goto Ld0
        Lf0:
            java.lang.string r1 = "certificate not valid till "
            goto Lc4
        Lf6:
            r0.<init>(r1)
            goto L49
        Lfd:
            java.lang.stringBuilder r4 = r0.append(r4)
            goto Ldb
        L105:
            goto L9b
        L108:
            goto L75
        L10c:
            java.security.cert.CertificateNotYetValidException r5 = new java.security.cert.CertificateNotYetValidException
            goto Le3
        L112:
            goto L5
        L115:
            goto L7c
        L119:
            return
        L11a:
            goto L10c
    }

    @Override // java.security.cert.Certificate
    public bool Equals(java.lang.object r4) {
            r3 = this;
            goto Lfd
        L4:
            return r1
        L5:
            goto L42
        L9:
            int r0 = r0 % r1
            goto L90
        Lf:
            if (r0 != 0) goto L14
            goto L2c
        L14:
            goto L99
        L18:
            if (r0 != 0) goto L1d
            goto La9
        L1d:
            goto L30
        L21:
            int r2 = r4.f491de0d7
            goto L65
        L27:
            if (r0 == 0) goto L2c
            goto L5
        L2c:
            goto L112
        L30:
            int r0 = r3.f491de0d7
            goto L21
        L36:
            r1 = 0
            goto L11e
        L3b:
            r1 = 10
            goto L8a
        L42:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r3 = r3.m3ff6ddc5()
            goto Lf5
        L4a:
            goto Ld5
        L4d:
            goto Lcf
        L51:
            bool r0 = r4 is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097
            goto L104
        L57:
            if (r0 != 0) goto L5c
            goto L5
        L5c:
            goto L84
        L60:
            return r3
        L61:
            goto L51
        L65:
            if (r0 != r2) goto L6a
            goto L5
        L6a:
            goto La8
        L6e:
            bool r3 = r3.Equals(r4)
            goto L10d
        L76:
            bool r0 = r4.fe2011431
            goto L18
        L7c:
            bool r0 = r0.Equals(r2)
            goto Lb5
        L84:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r2 = r4.f4a8a08f0
            goto Lad
        L8a:
            int r0 = r0 + r1
            goto L9
        L90:
            if (r0 <= 0) goto L95
            goto Ld5
        L95:
            goto Ld2
        L99:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r0 = r4.fcac9c5d9
            goto L27
        L9f:
            if (r4 == r3) goto La4
            goto L61
        La4:
            goto Lca
        La8:
            return r1
        La9:
            goto Lbe
        Lad:
            p5a445d71.p9f931cf3.pca323100.p29d19857 r2 = r2.getSignature()
            goto L7c
        Lb5:
            if (r0 == 0) goto Lba
            goto L5
        Lba:
            goto L4
        Lbe:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r0 = r3.fcac9c5d9
            goto Lf
        Lc4:
            bool r0 = r3.fe2011431
            goto L36
        Lca:
            r3 = 1
            goto L60
        Lcf:
            goto L100
        Ld2:
            goto Le9
        Ld5:
            goto L9f
        Ld9:
            r0 = 13
            goto L3b
        Le0:
            p5a445d71.p9f931cf3.pca323100.p29d19857 r0 = r0.getSignature()
            goto L57
        Le8:
            goto Lf9
        Le9:
            goto L4a
        Led:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r3 = r3.m3ff6ddc5()
            goto Le8
        Lf5:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r4 = r4.m3ff6ddc5()
        Lf9:
            goto L6e
        Lfd:
            goto L4d
        L100:
            goto Ld9
        L104:
            if (r0 != 0) goto L109
            goto L10e
        L109:
            goto L118
        L10d:
            return r3
        L10e:
            goto Led
        L112:
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 r0 = r3.f4a8a08f0
            goto Le0
        L118:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097 r4 = (p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p6a063097) r4
            goto Lc4
        L11e:
            if (r0 != 0) goto L123
            goto La9
        L123:
            goto L76
    }

    @Override // p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb
    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a r1) {
            r0 = this;
            goto Lc
        L4:
            p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 r0 = r0.getBagAttribute(r1)
            goto L1c
        Lc:
            goto L1d
        Lf:
            goto L13
        L13:
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb r0 = r0.f201da641
            goto L4
        L19:
            goto Lf
        L1c:
            return r0
        L1d:
            goto L19
    }

    @Override // p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb
    public java.util.Enumeration GetBagAttributeKeys() {
            r0 = this;
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
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb r0 = r0.f201da641
            goto L19
        L19:
            java.util.Enumeration r0 = r0.getBagAttributeKeys()
            goto Le
    }

    @Override // java.security.cert.Certificate
    public byte[] GetEncoded() throws java.security.cert.CertificateEncodingException {
            r0 = this;
            goto L24
        L4:
            goto L27
        L7:
            return r0
        L8:
            goto L4
        Lc:
            byte[] r0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(r0)
            goto L7
        L14:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r0 = r0.m3ff6ddc5()
            goto L1c
        L1c:
            byte[] r0 = r0.getEncoded()
            goto Lc
        L24:
            goto L8
        L27:
            goto L14
    }

    @Override // p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a, java.security.cert.X509Certificate
    public javax.security.auth.x500.X500Principal GetIssuerX500Principal() {
            r3 = this;
            goto L29
        L4:
            java.lang.object r0 = r3.f684ece30
            goto L30
        La:
            goto L2c
        Ld:
            goto L4e
        L10:
            goto L4
        L14:
            throw r3
        L15:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L15
            goto L4d
        L1b:
            javax.security.auth.x500.X500Principal r0 = super.getIssuerX500Principal()
            goto L76
        L23:
            int r0 = r0 + r1
            goto L70
        L29:
            goto L65
        L2c:
            goto L52
        L30:
            monitor-enter(r0)
            javax.security.auth.x500.X500Principal r1 = r3.f33ddd61f     // Catch: java.lang.Exception -> L15
            if (r1 == 0) goto L37
            monitor-exit(r0)     // Catch: java.lang.Exception -> L15
            return r1
        L37:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L15
            goto L1b
        L3c:
            monitor-enter(r1)
            javax.security.auth.x500.X500Principal r2 = r3.f33ddd61f     // Catch: java.lang.Exception -> L47
            if (r2 != 0) goto L43
            r3.f33ddd61f = r0     // Catch: java.lang.Exception -> L47
        L43:
            javax.security.auth.x500.X500Principal r3 = r3.f33ddd61f     // Catch: java.lang.Exception -> L47
            monitor-exit(r1)     // Catch: java.lang.Exception -> L47
            return r3
        L47:
            r3 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L47
            goto L14
        L4d:
            throw r3
        L4e:
            goto L62
        L52:
            r0 = 27
            goto L69
        L59:
            if (r0 <= 0) goto L5e
            goto L10
        L5e:
            goto Ld
        L62:
            goto L10
        L65:
            goto La
        L69:
            r1 = 16
            goto L23
        L70:
            int r0 = r0 % r1
            goto L59
        L76:
            java.lang.object r1 = r3.f684ece30
            goto L3c
    }

    @Override // p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a, java.security.cert.Certificate
    public java.security.PublicKey GetPublicKey() {
            r3 = this;
            goto L48
        L4:
            goto L4b
        L7:
            r3 = 0
            goto L6e
        Lc:
            throw r3
        Ld:
            goto L23
        L11:
            if (r0 <= 0) goto L16
            goto L2d
        L16:
            goto L2a
        L1a:
            if (r0 == 0) goto L1f
            goto L6f
        L1f:
            goto L7
        L23:
            goto L2d
        L26:
            goto L4
        L2a:
            goto Ld
        L2d:
            goto L7a
        L31:
            monitor-enter(r1)
            java.security.PublicKey r2 = r3.f047b2b56     // Catch: java.lang.Exception -> L3c
            if (r2 != 0) goto L38
            r3.f047b2b56 = r0     // Catch: java.lang.Exception -> L3c
        L38:
            java.security.PublicKey r3 = r3.f047b2b56     // Catch: java.lang.Exception -> L3c
            monitor-exit(r1)     // Catch: java.lang.Exception -> L3c
            return r3
        L3c:
            r3 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L3c
            goto L80
        L42:
            int r0 = r0 + r1
            goto L61
        L48:
            goto L26
        L4b:
            goto L73
        L4f:
            monitor-enter(r0)
            java.security.PublicKey r1 = r3.f047b2b56     // Catch: java.lang.Exception -> L81
            if (r1 == 0) goto L56
            monitor-exit(r0)     // Catch: java.lang.Exception -> L81
            return r1
        L56:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L81
            goto L87
        L5b:
            java.lang.object r1 = r3.f684ece30
            goto L31
        L61:
            int r0 = r0 % r1
            goto L11
        L67:
            r1 = 4
            goto L42
        L6e:
            return r3
        L6f:
            goto L5b
        L73:
            r0 = 16
            goto L67
        L7a:
            java.lang.object r0 = r3.f684ece30
            goto L4f
        L80:
            throw r3
        L81:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L81
            goto Lc
        L87:
            java.security.PublicKey r0 = super.getPublicKey()
            goto L1a
    }

    @Override // p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a, java.security.cert.X509Certificate
    public javax.security.auth.x500.X500Principal GetSubjectX500Principal() {
            r3 = this;
            goto L21
        L4:
            goto L40
        L7:
            goto L44
        Lb:
            int r0 = r0 + r1
            goto L4a
        L11:
            throw r3
        L12:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            goto L3f
        L18:
            if (r0 <= 0) goto L1d
            goto L7
        L1d:
            goto L4
        L21:
            goto L2b
        L24:
            goto L2f
        L28:
            goto L7
        L2b:
            goto L36
        L2f:
            r0 = 5
            goto L50
        L36:
            goto L24
        L39:
            java.lang.object r1 = r3.f684ece30
            goto L63
        L3f:
            throw r3
        L40:
            goto L28
        L44:
            java.lang.object r0 = r3.f684ece30
            goto L57
        L4a:
            int r0 = r0 % r1
            goto L18
        L50:
            r1 = 15
            goto Lb
        L57:
            monitor-enter(r0)
            javax.security.auth.x500.X500Principal r1 = r3.f50bd04fa     // Catch: java.lang.Exception -> L12
            if (r1 == 0) goto L5e
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            return r1
        L5e:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            goto L74
        L63:
            monitor-enter(r1)
            javax.security.auth.x500.X500Principal r2 = r3.f50bd04fa     // Catch: java.lang.Exception -> L6e
            if (r2 != 0) goto L6a
            r3.f50bd04fa = r0     // Catch: java.lang.Exception -> L6e
        L6a:
            javax.security.auth.x500.X500Principal r3 = r3.f50bd04fa     // Catch: java.lang.Exception -> L6e
            monitor-exit(r1)     // Catch: java.lang.Exception -> L6e
            return r3
        L6e:
            r3 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L6e
            goto L11
        L74:
            javax.security.auth.x500.X500Principal r0 = super.getSubjectX500Principal()
            goto L39
    }

    public long[] GetValidityValues() {
            r6 = this;
            goto L58
        L4:
            throw r6
        L5:
            goto L9e
        L9:
            int r0 = r0 + r1
            goto L73
        Lf:
            long r2 = r2.getTime()
            goto L7f
        L17:
            if (r0 <= 0) goto L1c
            goto L41
        L1c:
            goto L3e
        L20:
            long r0 = r0.getTime()
            goto L5f
        L28:
            monitor-enter(r1)
            long[] r0 = r6.f6625c008     // Catch: java.lang.Exception -> L33
            if (r0 != 0) goto L2f
            r6.f6625c008 = r4     // Catch: java.lang.Exception -> L33
        L2f:
            long[] r6 = r6.f6625c008     // Catch: java.lang.Exception -> L33
            monitor-exit(r1)     // Catch: java.lang.Exception -> L33
            return r6
        L33:
            r6 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L33
            goto L84
        L39:
            r5 = 0
            goto L45
        L3e:
            goto L5
        L41:
            goto L91
        L45:
            r4[r5] = r0
            goto La5
        L4b:
            r0 = 32
            goto L97
        L52:
            java.lang.object r1 = r6.f684ece30
            goto L28
        L58:
            goto La1
        L5b:
            goto L4b
        L5f:
            java.util.DateTime r2 = super.getNotAfter()
            goto Lf
        L67:
            monitor-enter(r0)
            long[] r1 = r6.f6625c008     // Catch: java.lang.Exception -> L85
            if (r1 == 0) goto L6e
            monitor-exit(r0)     // Catch: java.lang.Exception -> L85
            return r1
        L6e:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L85
            goto Lad
        L73:
            int r0 = r0 % r1
            goto L17
        L79:
            r4[r0] = r2
            goto L52
        L7f:
            r4 = 2
            goto L8b
        L84:
            throw r6
        L85:
            r6 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L85
            goto L4
        L8b:
            long[] r4 = new long[r4]
            goto L39
        L91:
            java.lang.object r0 = r6.f684ece30
            goto L67
        L97:
            r1 = 5
            goto L9
        L9e:
            goto L41
        La1:
            goto Laa
        La5:
            r0 = 1
            goto L79
        Laa:
            goto L5b
        Lad:
            java.util.DateTime r0 = super.getNotBefore()
            goto L20
    }

    @Override // java.security.cert.Certificate
    public int HashCode() {
            r1 = this;
            goto L4
        L4:
            goto L39
        L7:
            goto L3d
        Lb:
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r0 = r1.m3ff6ddc5()
            goto L30
        L13:
            int r1 = r1.f491de0d7
            goto L38
        L19:
            r0 = 1
            goto L1e
        L1e:
            r1.fe2011431 = r0
        L20:
            goto L13
        L24:
            goto L7
        L27:
            if (r0 == 0) goto L2c
            goto L20
        L2c:
            goto Lb
        L30:
            int r0 = r0.GetHashCode()
            goto L43
        L38:
            return r1
        L39:
            goto L24
        L3d:
            bool r0 = r1.fe2011431
            goto L27
        L43:
            r1.f491de0d7 = r0
            goto L19
    }

    public int OriginalHashCode() {
            r4 = this;
            goto L59
        L4:
            r0 = 0
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p510a4454 r4 = r4.m3ff6ddc5()     // Catch: java.security.cert.CertificateEncodingException -> L19
            byte[] r4 = r4.getEncoded()     // Catch: java.security.cert.CertificateEncodingException -> L19
            r1 = 1
            r2 = r0
        Lf:
            int r3 = r4.length     // Catch: java.security.cert.CertificateEncodingException -> L19
            if (r1 >= r3) goto L43
            r3 = r4[r1]     // Catch: java.security.cert.CertificateEncodingException -> L19
            goto L67
        L18:
            return r2
        L19:
            goto L4d
        L1d:
            r0 = 27
            goto L60
        L24:
            goto L55
        L27:
            goto L31
        L2b:
            int r0 = r0 % r1
            goto L39
        L31:
            goto L5c
        L34:
            int r2 = r2 + r3
            goto L47
        L39:
            if (r0 <= 0) goto L3e
            goto L55
        L3e:
            goto L52
        L42:
            goto Lf
        L43:
            goto L18
        L47:
            int r1 = r1 + 1
            goto L42
        L4d:
            return r0
        L4e:
            goto L24
        L52:
            goto L4e
        L55:
            goto L4
        L59:
            goto L27
        L5c:
            goto L1d
        L60:
            r1 = 8
            goto L6c
        L67:
            int r3 = r3 * r1
            goto L34
        L6c:
            int r0 = r0 + r1
            goto L2b
    }

    @Override // p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb
    public void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a r1, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 r2) {
            r0 = this;
            goto L19
        L4:
            r0.setBagAttribute(r1, r2)
            goto L14
        Lb:
            p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb r0 = r0.f201da641
            goto L4
        L11:
            goto L1c
        L14:
            return
        L15:
            goto L11
        L19:
            goto L15
        L1c:
            goto Lb
    }
}

