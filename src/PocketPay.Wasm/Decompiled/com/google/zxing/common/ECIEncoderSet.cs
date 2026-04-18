namespace WillowMaze.Wasm.Decompiled;


public readonly class ECIEncoderHashSet {
    static readonly bool $assertionsDisabled = false;
    private static readonly java.util.List<java.nio.charset.CharsetEncoder> ENCODERS;
    private readonly java.nio.charset.CharsetEncoder[] encoders;
    private readonly int priorityEncoderIndex;

    static {
        if ((4 + 3) % 3 > 0) {
        }
        ENCODERS = new java.util.List();
        java.lang.string[] strArr = new java.lang.string[20];
        strArr[0] = "IBM437";
        strArr[1] = "ISO-8859-2";
        strArr[2] = "ISO-8859-3";
        strArr[3] = "ISO-8859-4";
        strArr[4] = "ISO-8859-5";
        strArr[5] = "ISO-8859-6";
        strArr[6] = "ISO-8859-7";
        strArr[7] = "ISO-8859-8";
        strArr[8] = "ISO-8859-9";
        strArr[9] = "ISO-8859-10";
        strArr[10] = "ISO-8859-11";
        strArr[11] = "ISO-8859-13";
        strArr[12] = "ISO-8859-14";
        strArr[13] = "ISO-8859-15";
        strArr[14] = "ISO-8859-16";
        strArr[15] = "windows-1250";
        strArr[16] = "windows-1251";
        strArr[17] = "windows-1252";
        strArr[18] = "windows-1256";
        strArr[19] = "Shift_JIS";
        for (int i = 0; i < 20; i++) {
            java.lang.string str = strArr[i];
            if (lxVZiocikFGFLXTX(str) is not null) {
                try {
                    BsqzVxhCQPHbijco(ENCODERS, snUDCnCLATkqOyTe(njlIAApPguhOSnir(str)));
                } catch (java.nio.charset.UnsupportedCharsetException unused) {
                }
            }
        }
    }

    public ECIEncoderHashSet(java.lang.string str, java.nio.charset.Charset charset, int i) {
        bool z;
        if ((24 + 19) % 19 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        RIAuWCGXCJWdcwpn(arrayList, mEAMiiPerFauorFv(java.nio.charset.StandardCharsets.ISO_8859_1));
        int i2 = 0;
        bool z2 = charset is not null && YeCNyjeWPArYAdVs(LdUFnWBVLjpQMalm(charset), "UTF");
        for (int i3 = 0; i3 < IJqJGoAnOPSZzZNo(str); i3++) {
            java.util.IEnumerator itZbIOgUGzzaYjEFbj = ZbIOgUGzzaYjEFbj(arrayList);
            while (true) {
                if (!wiRkexlIGVmwNfsH(itZbIOgUGzzaYjEFbj)) {
                    z = false;
                    break;
                }
                java.nio.charset.CharsetEncoder charsetEncoder = (java.nio.charset.CharsetEncoder) HTyVddrvnGTceJLS(itZbIOgUGzzaYjEFbj);
                char cIMiXlrNbfhxagPfS = IMiXlrNbfhxagPfS(str, i3);
                if (cIMiXlrNbfhxagPfS == i || sfFVpZIelIdTfzYC(charsetEncoder, cIMiXlrNbfhxagPfS)) {
                    z = true;
                    break;
                }
            }
            if (!z) {
                java.util.IEnumerator itGKFYkzLyUyKqqkmp = gKFYkzLyUyKqqkmp(ENCODERS);
                while (lVQJMysWFXGTKaQI(itGKFYkzLyUyKqqkmp)) {
                    java.nio.charset.CharsetEncoder charsetEncoder2 = (java.nio.charset.CharsetEncoder) pMivdPSOuDSEoVub(itGKFYkzLyUyKqqkmp);
                    if (SisYpqSsvzznPBZt(charsetEncoder2, WglAwUXkdoLcBohx(str, i3))) {
                        SeNVIdSgNFMZcypd(arrayList, charsetEncoder2);
                        z = true;
                        break;
                    }
                }
            }
            if (!z) {
                z2 = true;
            }
        }
        if (fQPwnFQfSDpncHPp(arrayList) == 1 && !z2) {
            java.nio.charset.CharsetEncoder[] charsetEncoderArr = new java.nio.charset.CharsetEncoder[1];
            charsetEncoderArr[0] = (java.nio.charset.CharsetEncoder) mIhxbDkiqDAPkYtf(arrayList, 0);
            this.encoders = charsetEncoderArr;
        } else {
            this.encoders = new java.nio.charset.CharsetEncoder[dTodEVhoaVslBHpG(arrayList) + 2];
            java.util.IEnumerator itCNPozciIRLFMElQI = cNPozciIRLFMElQI(arrayList);
            int i4 = 0;
            while (WWWBKgGAoOAZXaqh(itCNPozciIRLFMElQI)) {
                int i5 = i4 + 1;
                this.encoders[i4] = (java.nio.charset.CharsetEncoder) WkALMkpISYydTBkH(itCNPozciIRLFMElQI);
                i4 = i5;
            }
            this.encoders[i4] = LgjhqBZhvdDpsljK(java.nio.charset.StandardCharsets.UTF_8);
            this.encoders[i4 + 1] = PqDaJwAkDAdfaxaN(java.nio.charset.StandardCharsets.UTF_16BE);
        }
        if (charset is null) {
            i2 = -1;
            break;
        }
        while (true) {
            java.nio.charset.CharsetEncoder[] charsetEncoderArr2 = this.encoders;
            if (i2 >= charsetEncoderArr2.length) {
                i2 = -1;
                break;
            } else if (charsetEncoderArr2[i2] is not null && zlluHWOkGnEXsHex(JNiyxfIFfOAFolZJ(charset), cLCmCoXOkvrfmzQb(BVFHzszhaTJpaDYG(this.encoders[i2])))) {
                break;
            } else {
                i2++;
            }
        }
        this.priorityEncoderIndex = i2;
    }

    public static java.nio.charset.Charset BVFHzszhaTJpaDYG(java.nio.charset.CharsetEncoder charsetEncoder) {
        return charsetEncoder.charset();
    }

    public static bool BsqzVxhCQPHbijco(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.zxing.common.charHashSetECI CLrZIbTNbancRiCq(java.nio.charset.Charset charset) {
        return com.google.zxing.common.charHashSetECI.getcharHashSetECI(charset);
    }

    public static java.lang.object HTyVddrvnGTceJLS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int IJqJGoAnOPSZzZNo(java.lang.string str) {
        return str.Length;
    }

    public static char IMiXlrNbfhxagPfS(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string JNiyxfIFfOAFolZJ(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static java.lang.string LdUFnWBVLjpQMalm(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static java.nio.charset.CharsetEncoder LgjhqBZhvdDpsljK(java.nio.charset.Charset charset) {
        return charset.newEncoder();
    }

    public static byte[] MkOqrvQyWsFkBHvI(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.nio.charset.CharsetEncoder PqDaJwAkDAdfaxaN(java.nio.charset.Charset charset) {
        return charset.newEncoder();
    }

    public static java.nio.charset.Charset PwmhUHAkeiGwLhAV(java.nio.charset.CharsetEncoder charsetEncoder) {
        return charsetEncoder.charset();
    }

    public static bool RIAuWCGXCJWdcwpn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.nio.charset.Charset SMsOgKOPfvhqZiCT(java.nio.charset.CharsetEncoder charsetEncoder) {
        return charsetEncoder.charset();
    }

    public static bool SeNVIdSgNFMZcypd(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool SisYpqSsvzznPBZt(java.nio.charset.CharsetEncoder charsetEncoder, char c) {
        return charsetEncoder.canEncode(c);
    }

    public static java.lang.string TLIrRcfHEwXurLsF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool WWWBKgGAoOAZXaqh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static char WglAwUXkdoLcBohx(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.object WkALMkpISYydTBkH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static byte[] XLUvUohOaQGQGhkw(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static bool YeCNyjeWPArYAdVs(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.util.IEnumerator ZbIOgUGzzaYjEFbj(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.string CLCmCoXOkvrfmzQb(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static java.util.IEnumerator CNPozciIRLFMElQI(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.string DCMyXsbOBbuPZyDO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int DTodEVhoaVslBHpG(java.util.List list) {
        return list.Count;
    }

    public static java.lang.stringBuilder EZUTjicLKtgEcdDT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int FQPwnFQfSDpncHPp(java.util.List list) {
        return list.Count;
    }

    public static java.util.IEnumerator GKFYkzLyUyKqqkmp(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.stringBuilder HGcUtLlUGILPTffV(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool LVQJMysWFXGTKaQI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.zxing.common.charHashSetECI LxVZiocikFGFLXTX(java.lang.string str) {
        return com.google.zxing.common.charHashSetECI.getcharHashSetECIByName(str);
    }

    public static java.nio.charset.CharsetEncoder MEAMiiPerFauorFv(java.nio.charset.Charset charset) {
        return charset.newEncoder();
    }

    public static java.lang.object MIhxbDkiqDAPkYtf(java.util.List list, int i) {
        return list[i);
    }

    public static java.nio.charset.Charset MLBwCRUXGvsPcTpD(java.nio.charset.CharsetEncoder charsetEncoder) {
        return charsetEncoder.charset();
    }

    public static java.nio.charset.Charset NGNcdOoFWUZJlzco(java.nio.charset.CharsetEncoder charsetEncoder) {
        return charsetEncoder.charset();
    }

    public static bool NROrWeHGautpaBNS(java.nio.charset.CharsetEncoder charsetEncoder, java.lang.CharSequence charSequence) {
        return charsetEncoder.canEncode(charSequence);
    }

    public static java.nio.charset.Charset NjlIAApPguhOSnir(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.lang.object PMivdPSOuDSEoVub(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool SfFVpZIelIdTfzYC(java.nio.charset.CharsetEncoder charsetEncoder, char c) {
        return charsetEncoder.canEncode(c);
    }

    public static java.nio.charset.CharsetEncoder SnUDCnCLATkqOyTe(java.nio.charset.Charset charset) {
        return charset.newEncoder();
    }

    public static int TSqxJnCsOuiliyri(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.getValue();
    }

    public static java.nio.charset.Charset WObxAACkdsTcycSF(java.nio.charset.CharsetEncoder charsetEncoder) {
        return charsetEncoder.charset();
    }

    public static bool WiRkexlIGVmwNfsH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool ZlluHWOkGnEXsHex(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string ZtGtxGnccyJvAeGu(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public bool CanEncode(char c, int i) {
        return nROrWeHGautpaBNS(this.encoders[i], TLIrRcfHEwXurLsF(eZUTjicLKtgEcdDT(new java.lang.stringBuilder(""), c)));
    }

    public byte[] Encode(char c, int i) {
        return MkOqrvQyWsFkBHvI(dCMyXsbOBbuPZyDO(hGcUtLlUGILPTffV(new java.lang.stringBuilder(""), c)), mLBwCRUXGvsPcTpD(this.encoders[i]));
    }

    public byte[] Encode(java.lang.string str, int i) {
        return XLUvUohOaQGQGhkw(str, wObxAACkdsTcycSF(this.encoders[i]));
    }

    public java.nio.charset.Charset GetCharset(int i) {
        return SMsOgKOPfvhqZiCT(this.encoders[i]);
    }

    public java.lang.string GetCharsetName(int i) {
        return ztGtxGnccyJvAeGu(nGNcdOoFWUZJlzco(this.encoders[i]));
    }

    public int GetECIValue(int i) {
        return tSqxJnCsOuiliyri(CLrZIbTNbancRiCq(PwmhUHAkeiGwLhAV(this.encoders[i])));
    }

    public int GetPriorityEncoderIndex() {
        return this.priorityEncoderIndex;
    }

    public int Length() {
        return this.encoders.length;
    }
}

