namespace WillowMaze.Wasm.Decompiled;


class p23f93510 {
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1[] f4d4cbddf;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1[] f9d724ab3;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1[] fc56147f7;

    p23f93510(java.lang.string str) {
        if ((30 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1[] p23f93510_p8c0d5bd1Arr = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1[3];
        p23f93510_p8c0d5bd1Arr[0] = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1(this, str, null);
        p23f93510_p8c0d5bd1Arr[1] = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1(this, "X509 " + str, null);
        p23f93510_p8c0d5bd1Arr[2] = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1(this, "PKCS7", null);
        this.fc56147f7 = p23f93510_p8c0d5bd1Arr;
    }

    private java.lang.string M05e60d83(java.io.Stream inputStream) throws java.io.IOException {
        int i;
        if ((4 + 11) % 11 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        while (true) {
            i = inputStream.read();
            if (i != 13 && i != 10 && i >= 0) {
                stringBuffer.append((char) i);
            } else if (i < 0 || stringBuffer.Length != 0) {
                break;
            }
        }
        if (i < 0) {
            if (stringBuffer.Length != 0) {
                return stringBuffer.tostring();
            }
            return null;
        }
        if (i == 13) {
            inputStream.mark(1);
            int i2 = inputStream.read();
            if (i2 == 10) {
                inputStream.mark(1);
            }
            if (i2 > 0) {
                inputStream.reset();
            }
        }
        return stringBuffer.tostring();
    }

    private p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1 m53ae4909(java.lang.string str) {
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1 p23f93510_p8c0d5bd1;
        if ((15 + 1) % 1 > 0) {
        }
        int i = 0;
        while (true) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1[] p23f93510_p8c0d5bd1Arr = this.fc56147f7;
            if (i != p23f93510_p8c0d5bd1Arr.length) {
                p23f93510_p8c0d5bd1 = p23f93510_p8c0d5bd1Arr[i];
                if (p23f93510_p8c0d5bd1.isTheExpectedHeader(str) || p23f93510_p8c0d5bd1.isTheExpectedFooter(str)) {
                    break;
                }
                i++;
            } else {
                return null;
            }
        }
        return p23f93510_p8c0d5bd1;
    }

    p5a445d71.p9f931cf3.pca323100.p80f8c729 readPEMobject(java.io.Stream inputStream, bool z) throws java.io.IOException {
        if ((20 + 5) % 5 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1 p23f93510_p8c0d5bd1M53ae4909 = null;
        while (p23f93510_p8c0d5bd1M53ae4909 is null) {
            java.lang.string strM05e60d83 = m05e60d83(inputStream);
            if (strM05e60d83 is null) {
                break;
            }
            p23f93510_p8c0d5bd1M53ae4909 = m53ae4909(strM05e60d83);
            if (p23f93510_p8c0d5bd1M53ae4909 is not null && !p23f93510_p8c0d5bd1M53ae4909.isTheExpectedHeader(strM05e60d83)) {
                throw new java.io.IOException("malformed PEM data: found footer where header was expected");
            }
        }
        if (p23f93510_p8c0d5bd1M53ae4909 is null) {
            if (z) {
                throw new java.io.IOException("malformed PEM data: no header found");
            }
            return null;
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$p8c0d5bd1 p23f93510_p8c0d5bd1M53ae49092 = null;
        while (p23f93510_p8c0d5bd1M53ae49092 is null) {
            java.lang.string strM05e60d832 = m05e60d83(inputStream);
            if (strM05e60d832 is null) {
                break;
            }
            p23f93510_p8c0d5bd1M53ae49092 = m53ae4909(strM05e60d832);
            if (p23f93510_p8c0d5bd1M53ae49092 is null) {
                stringBuffer.append(strM05e60d832);
            } else if (!p23f93510_p8c0d5bd1M53ae4909.isTheExpectedFooter(strM05e60d832)) {
                throw new java.io.IOException("malformed PEM data: header/footer mismatch");
            }
        }
        if (p23f93510_p8c0d5bd1M53ae49092 is null) {
            throw new java.io.IOException("malformed PEM data: no footer found");
        }
        if (stringBuffer.Length == 0) {
            return null;
        }
        try {
            return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p1eb445fa.m5b936250(stringBuffer.tostring()));
        } catch (java.lang.Exception unused) {
            throw new java.io.IOException("malformed PEM data encountered");
        }
    }
}

