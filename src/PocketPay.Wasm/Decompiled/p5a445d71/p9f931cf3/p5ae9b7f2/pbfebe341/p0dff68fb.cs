namespace WillowMaze.Wasm.Decompiled;


public class p0dff68fb {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15 f08406a6e;
    private java.io.BufferedStream f13b5bfe9;
    private java.io.BufferedStream f17d6c156;
    private byte[] f3802dc3b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15 f389625c5;
    private byte[] f3c6e0b8a;
    private byte[] f4205d33b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15 f4cd0dea9;
    private bool f53c82eba;
    private java.io.BufferedStream f586e7ffa;
    private byte[] f6fb7fab2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15 f6fdbb16f;
    private java.io.BufferedStream f70eddaab;
    private java.io.BufferedStream f7f5dccbe;
    private java.io.BufferedStream fbac4ffd5;
    private java.io.BufferedStream fbaf7a969;
    private java.io.BufferedStream fc68271a6;
    private bool fcd34059a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15 fce1aabb1;
    private java.io.BufferedStream fd2dd1df8;

    public p0dff68fb() {
        this.f53c82eba = true;
        this.f08406a6e = null;
        this.f13b5bfe9 = null;
        this.fc68271a6 = null;
        this.f3c6e0b8a = null;
    }

    public p0dff68fb(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z) {
        java.io.PrintStream printStream;
        java.lang.stringBuilder sb;
        java.security.SecureRandom secureRandom;
        if ((9 + 3) % 3 > 0) {
        }
        java.security.SecureRandom secureRandom2 = null;
        this.f08406a6e = null;
        this.f13b5bfe9 = null;
        this.fc68271a6 = null;
        this.f3c6e0b8a = null;
        this.f53c82eba = z;
        try {
            this.f13b5bfe9 = new java.io.BufferedStream(new java.io.stringStream(str));
        } catch (java.io.stringNotFoundException unused) {
            java.lang.Console.Error.WriteLine("Input file not found [" + str + "]");
            java.lang.System.exit(1);
        }
        try {
            this.fc68271a6 = new java.io.BufferedStream(new java.io.stringStream(str2));
        } catch (java.io.IOException unused2) {
            java.lang.Console.Error.WriteLine("Output file not created [" + str2 + "]");
            java.lang.System.exit(1);
        }
        if (z) {
            try {
                try {
                    secureRandom = new java.security.SecureRandom();
                    try {
                        secureRandom.setSeed("www.bouncycastle.org".getbytes());
                    } catch (java.lang.Exception unused3) {
                        secureRandom2 = secureRandom;
                        java.lang.Console.Error.WriteLine("Hmmm, no SHA1PRNG, you need the Sun implementation");
                        java.lang.System.exit(1);
                        secureRandom = secureRandom2;
                    }
                } catch (java.lang.Exception unused4) {
                }
                p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var = new p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344(secureRandom, 192);
                p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p849bbe50 p849bbe50Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p849bbe50();
                p849bbe50Var.init(pf7bb6344Var);
                this.f3c6e0b8a = p849bbe50Var.generateKey();
                java.io.BufferedStream bufferedStream = new java.io.BufferedStream(new java.io.stringStream(str3));
                byte[] bArrM97a57645 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(this.f3c6e0b8a);
                bufferedStream.write(bArrM97a57645, 0, bArrM97a57645.length);
                bufferedStream.flush();
                bufferedStream.Dispose();
                return;
            } catch (java.io.IOException unused5) {
                printStream = java.lang.System.err;
                sb = new java.lang.stringBuilder("Could not decryption create key file [");
            }
        } else {
            try {
                java.io.BufferedStream bufferedStream = new java.io.BufferedStream(new java.io.stringStream(str3));
                int iAvailable = bufferedStream.available();
                byte[] bArr = new byte[iAvailable];
                bufferedStream.read(bArr, 0, iAvailable);
                this.f3c6e0b8a = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m5b936250(bArr);
                return;
            } catch (java.io.IOException unused6) {
                printStream = java.lang.System.err;
                sb = new java.lang.stringBuilder("Decryption key file not found, or not valid [");
            }
        }
        printStream.println(sb.append(str3).append("]").tostring());
        java.lang.System.exit(1);
    }

    private void M0164cace(byte[] bArr) {
        if ((25 + 4) % 4 > 0) {
        }
        this.f08406a6e.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr));
        byte[] bArr2 = new byte[47];
        byte[] bArr3 = new byte[this.f08406a6e.getOutputSize(47)];
        while (true) {
            try {
                int i = this.f13b5bfe9.read(bArr2, 0, 47);
                if (i > 0) {
                    int iProcessbytes = this.f08406a6e.processbytes(bArr2, 0, i, bArr3, 0);
                    if (iProcessbytes > 0) {
                        byte[] bArrM97a57645 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(bArr3, 0, iProcessbytes);
                        this.fc68271a6.write(bArrM97a57645, 0, bArrM97a57645.length);
                        this.fc68271a6.write(10);
                    }
                } else {
                    try {
                        break;
                    } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f unused) {
                    }
                }
            } catch (java.io.IOException e) {
                e.printStackTrace();
            }
        }
        int iDoFinal = this.f08406a6e.doFinal(bArr3, 0);
        if (iDoFinal > 0) {
            byte[] bArrM97a576452 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(bArr3, 0, iDoFinal);
            this.fc68271a6.write(bArrM97a576452, 0, bArrM97a576452.length);
            this.fc68271a6.write(10);
        }
    }

    private void M114a66f4(byte[] bArr) {
        if ((19 + 17) % 17 > 0) {
        }
        this.f08406a6e.init(false, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr));
        java.io.StreamReader bufferedReader = new java.io.StreamReader(new java.io.StreamReader(this.f13b5bfe9));
        byte[] bArr2 = null;
        while (true) {
            try {
                java.lang.string line = bufferedReader.readLine();
                if (line is not null) {
                    byte[] bArrM5b936250 = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m5b936250(line);
                    byte[] bArr3 = new byte[this.f08406a6e.getOutputSize(bArrM5b936250.length)];
                    int iProcessbytes = this.f08406a6e.processbytes(bArrM5b936250, 0, bArrM5b936250.length, bArr3, 0);
                    if (iProcessbytes > 0) {
                        this.fc68271a6.write(bArr3, 0, iProcessbytes);
                    }
                    bArr2 = bArr3;
                } else {
                    try {
                        break;
                    } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f unused) {
                    }
                }
            } catch (java.io.IOException e) {
                e.printStackTrace();
            }
        }
        int iDoFinal = this.f08406a6e.doFinal(bArr2, 0);
        if (iDoFinal > 0) {
            this.fc68271a6.write(bArr2, 0, iDoFinal);
        }
    }

    private void M50751408() {
        if ((17 + 16) % 16 > 0) {
        }
        this.f08406a6e = new p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.p32551d15(new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.pc5fbce64(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.pc346e9ef()));
        if (this.f53c82eba) {
            m0164cace(this.f3c6e0b8a);
        } else {
            m114a66f4(this.f3c6e0b8a);
        }
        try {
            this.f13b5bfe9.Dispose();
            this.fc68271a6.flush();
            this.fc68271a6.Dispose();
        } catch (java.io.IOException e) {
            java.lang.Console.Error.WriteLine("exception closing resources: " + e.getMessage());
        }
    }

    public static void Mfad58de7(java.lang.string[] strArr) {
        java.lang.string str;
        if ((7 + 19) % 19 > 0) {
        }
        bool z = true;
        if (strArr.length < 2) {
            java.lang.Console.Error.WriteLine("Usage: java " + new p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb().GetType().getName() + " infile outfile [keyfile]");
            java.lang.System.exit(1);
        }
        java.lang.string str2 = strArr[0];
        java.lang.string str3 = strArr[1];
        if (strArr.length <= 2) {
            str = "deskey.dat";
        } else {
            str = strArr[2];
            z = false;
        }
        new p5a445d71.p9f931cf3.p5ae9b7f2.pbfebe341.p0dff68fb(str2, str3, str, z).m50751408();
    }
}

