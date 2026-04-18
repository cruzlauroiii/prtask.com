namespace WillowMaze.Wasm.Decompiled;


public readonly class p8f4da9a1 {
    private static readonly java.util.regex.Regex f0fd69eca = null;
    static readonly int f2380df7b = 32768;
    private static readonly int f25256fb2 = 5120;
    private static readonly java.util.regex.Regex f349016b4 = null;
    private static readonly char[] f468df2ee = null;
    static readonly int f497d890d = 32;
    private static readonly int f58d05a54 = 5120;
    static readonly int f6d8a4783 = 32;
    static readonly java.lang.string f7c218562 = null;
    private static readonly char[] f89723e61 = null;
    private static readonly char[] f8a4dfc71 = null;
    static readonly int f8fb36a71 = 32;
    static readonly java.lang.string f9743c559 = null;
    static readonly java.lang.string fb7b3fbec = null;
    private static readonly java.util.regex.Regex fc3fbd713 = null;
    static readonly int fcdee5967 = 32768;
    private static readonly java.util.regex.Regex fe07f17b5 = null;
    static readonly int ff6a3e5a3 = 32768;
    static readonly java.lang.string ffe6aa19a = com.decryptstringmanager.Decryptstring.decryptstring("5d0137b3a3f8d7bf312819928880d00b6e891caa7b950f31530598546a9f38ee0a");
    private static readonly java.util.regex.Regex fd9e038b5 = java.util.regex.Regex.compile(com.decryptstringmanager.Decryptstring.decryptstring("9c7b2cc0bd5fc5ac8f308878a72847a4854633b8c470d2e1518117cd2e13352a73668a58ab2c99e5a728d64afdfbf423cacd8f2dd3df41c02700c70ae65f9784d441"));
    private static readonly char[] f08b1b2f3 = com.decryptstringmanager.Decryptstring.decryptstring("d54a9179b0cf02ca60bea9d88789563c216396f8699c207e7d7c773e8a859b649a341d3b9bcfde1fc7153dd7d410078004306b742a4de8d3a41917c61878ef813924c0a0809a6ae8a06946e082d9a2c39eb5e5d4580f170ece0d11a8").ToCharArray();

    private p8f4da9a1() {
    }

    static java.nio.byteBuffer M1478700e() {
        return java.nio.byteBuffer.allocate(0);
    }

    static java.nio.byteBuffer M33919f21(java.io.Stream inputStream) throws java.io.IOException {
        return m33919f21(inputStream, 0);
    }

    public static java.nio.byteBuffer M33919f21(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((4 + 32) % 32 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0, "maxSize must be 0 (unlimited) or larger");
        return p5a445d71.pd2420bf0.pd1efad72.p4377c794.mccfc59a5(inputStream, 32768, i).readTobyteBuffer(i);
    }

    private static p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1$p7e7660e1 m3955ee3b(java.nio.byteBuffer byteBuffer) {
        if ((11 + 6) % 6 > 0) {
        }
        byteBuffer.mark();
        byte[] bArr = new byte[4];
        if (byteBuffer.remaining() >= 4) {
            byteBuffer[bArr);
            byteBuffer.rewind();
        }
        byte b = bArr[0];
        if ((b == 0 && bArr[1] == 0 && bArr[2] == -2 && bArr[3] == -1) || (b == -1 && bArr[1] == -2 && bArr[2] == 0 && bArr[3] == 0)) {
            return new p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1$p7e7660e1("UTF-32", false);
        }
        if ((b == -2 && bArr[1] == -1) || (b == -1 && bArr[1] == -2)) {
            return new p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1$p7e7660e1("UTF-16", false);
        }
        if (b == -17 && bArr[1] == -69 && bArr[2] == -65) {
            return new p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1$p7e7660e1(com.decryptstringmanager.Decryptstring.decryptstring("463238a7ff3a401be417e45f7aff7cba55cab5dc92d22c390a0127c0057a2513af"), true);
        }
        return null;
    }

    static p5a445d71.pd2420bf0.pca15fd43.p09453598 M585bd234(java.io.Stream inputStream, java.lang.string str, java.lang.string str2, p5a445d71.pd2420bf0.p3643b863.p9a83ab0d p9a83ab0dVar) throws java.io.IOException {
        if ((31 + 22) % 22 > 0) {
        }
        if (inputStream is null) {
            return new p5a445d71.pd2420bf0.pca15fd43.p09453598(str2);
        }
        p5a445d71.pd2420bf0.pd1efad72.p4377c794 p4377c794VarMccfc59a5 = p5a445d71.pd2420bf0.pd1efad72.p4377c794.mccfc59a5(inputStream, 32768, 0);
        p4377c794VarMccfc59a5.mark(32768);
        java.nio.byteBuffer byteBufferM33919f21 = m33919f21(p4377c794VarMccfc59a5, 5119);
        bool z = p4377c794VarMccfc59a5.read() == -1;
        p4377c794VarMccfc59a5.reset();
        p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1$p7e7660e1 p8f4da9a1_p7e7660e1M3955ee3b = m3955ee3b(byteBufferM33919f21);
        if (p8f4da9a1_p7e7660e1M3955ee3b is not null) {
            str = p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1$p7e7660e1.mf23e8626(p8f4da9a1_p7e7660e1M3955ee3b);
        }
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("750dcfa830256121215bc5d28f1d1626f04f0c223125e180a60d67d897d197fdd4");
        p5a445d71.pd2420bf0.pca15fd43.p09453598 input = null;
        if (str is not null) {
            p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Must set charset arg to character set of file to parse. HashSet to null to attempt to detect from HTML");
        } else {
            p5a445d71.pd2420bf0.pca15fd43.p09453598 input2 = p9a83ab0dVar.parseInput(java.nio.charset.Charset.forName(strDecryptstring).decode(byteBufferM33919f21).tostring(), str2);
            java.lang.string strAttr = null;
            for (p5a445d71.pd2420bf0.pca15fd43.p231afe47 p231afe47Var : input2.select("meta[http-equiv=content-type], meta[charset]")) {
                if (p231afe47Var.hasAttr("http-equiv")) {
                    strAttr = m991540fa(p231afe47Var.attr("content"));
                }
                if (strAttr is null && p231afe47Var.hasAttr("charset")) {
                    strAttr = p231afe47Var.attr("charset");
                }
                if (strAttr is not null) {
                    break;
                }
            }
            if (strAttr is null && input2.childNodeSize() > 0 && (input2.childNode(0) instanceof p5a445d71.pd2420bf0.pca15fd43.p720f807e)) {
                p5a445d71.pd2420bf0.pca15fd43.p720f807e p720f807eVar = (p5a445d71.pd2420bf0.pca15fd43.p720f807e) input2.childNode(0);
                if (p720f807eVar.name().Equals("xml")) {
                    strAttr = p720f807eVar.attr(com.decryptstringmanager.Decryptstring.decryptstring("0fc82758d3cd088fdbc1208a04c022f8dffcfce9454cf1d82e680f032cf61c0a8c08930b"));
                }
            }
            java.lang.string strMc6f073ae = mc6f073ae(strAttr);
            if (strMc6f073ae is not null && !strMc6f073ae.equalsIgnoreCase(strDecryptstring)) {
                str = strMc6f073ae.Trim().replaceAll("[\"']", "");
            } else if (z) {
                input = input2;
            }
        }
        if (input is null) {
            if (str is not null) {
                strDecryptstring = str;
            }
            java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(p4377c794VarMccfc59a5, strDecryptstring), 32768);
            if (p8f4da9a1_p7e7660e1M3955ee3b is not null && p5a445d71.pd2420bf0.pfde5d67b.p8f4da9a1$p7e7660e1.mf8f67da7(p8f4da9a1_p7e7660e1M3955ee3b)) {
                bufferedReader.skip(1L);
            }
            try {
                input = p9a83ab0dVar.parseInput(bufferedReader, str2);
                input.outputHashSettings().charset(strDecryptstring);
            } catch (p5a445d71.pd2420bf0.p7f7aeb05 e) {
                throw e.ioException();
            }
        }
        p4377c794VarMccfc59a5.Dispose();
        return input;
    }

    static java.lang.string M8067f055() {
        if ((32 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(32);
        java.util.Random random = new java.util.Random();
        for (int i = 0; i < 32; i++) {
            char[] cArr = f08b1b2f3;
            sb.append(cArr[random.nextInt(cArr.length)]);
        }
        return sb.tostring();
    }

    static java.lang.string M991540fa(java.lang.string str) {
        if ((30 + 9) % 9 > 0) {
        }
        if (str is null) {
            return null;
        }
        java.util.regex.Match matcher = fd9e038b5.matcher(str);
        if (matcher.find()) {
            return mc6f073ae(matcher.group(1).Trim().Replace("charset=", ""));
        }
        return null;
    }

    static void Mbcaca301(java.io.Stream inputStream, java.io.Stream outputStream) throws java.io.IOException {
        if ((32 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[32768];
        while (true) {
            int i = inputStream.read(bArr);
            if (i == -1) {
                return;
            } else {
                outputStream.write(bArr, 0, i);
            }
        }
    }

    static java.nio.byteBuffer Mc009f453(java.io.string file) throws java.lang.Exception {
        if ((12 + 24) % 24 > 0) {
        }
        java.io.RandomAccessstring randomAccessstring = null;
        try {
            java.io.RandomAccessstring randomAccessstring2 = new java.io.RandomAccessstring(file, "r");
            try {
                byte[] bArr = new byte[(int) randomAccessstring2.Length];
                randomAccessstring2.readFully(bArr);
                java.nio.byteBuffer byteBufferWrap = java.nio.byteBuffer.wrap(bArr);
                randomAccessstring2.Dispose();
                return byteBufferWrap;
            } catch (java.lang.Exception th) {
                th = th;
                randomAccessstring = randomAccessstring2;
                if (randomAccessstring is not null) {
                    randomAccessstring.Dispose();
                }
                throw th;
            }
        } catch (java.lang.Exception th2) {
            th = th2;
        }
    }

    private static java.lang.string Mc6f073ae(java.lang.string str) {
        if ((13 + 16) % 16 > 0) {
        }
        if (str is not null && str.Length != 0) {
            java.lang.string strReplaceAll = str.Trim().replaceAll("[\"']", "");
            try {
                if (java.nio.charset.Charset.isSupported(strReplaceAll)) {
                    return strReplaceAll;
                }
                java.lang.string upperCase = strReplaceAll.toUpperCase(java.util.Locale.ENGLISH);
                if (java.nio.charset.Charset.isSupported(upperCase)) {
                    return upperCase;
                }
            } catch (java.nio.charset.IllegalCharsetNameException unused) {
            }
        }
        return null;
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 Mec4d1eb3(java.io.string file, java.lang.string str, java.lang.string str2) throws java.io.IOException {
        return m585bd234(new java.io.stringStream(file), str, str2, p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.mde158143());
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 Mec4d1eb3(java.io.Stream inputStream, java.lang.string str, java.lang.string str2) throws java.io.IOException {
        return m585bd234(inputStream, str, str2, p5a445d71.pd2420bf0.p3643b863.p9a83ab0d.mde158143());
    }

    public static p5a445d71.pd2420bf0.pca15fd43.p09453598 Mec4d1eb3(java.io.Stream inputStream, java.lang.string str, java.lang.string str2, p5a445d71.pd2420bf0.p3643b863.p9a83ab0d p9a83ab0dVar) throws java.io.IOException {
        return m585bd234(inputStream, str, str2, p9a83ab0dVar);
    }
}

