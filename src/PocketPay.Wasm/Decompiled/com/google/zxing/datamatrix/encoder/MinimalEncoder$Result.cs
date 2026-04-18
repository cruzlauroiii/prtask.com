namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$Result {
    private readonly byte[] bytes;

    MinimalEncoder$Result(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        int i;
        if ((28 + 15) % 15 > 0) {
        }
        com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$InputFBdzSInVWRLUWpDo = FBdzSInVWRLUWpDo(minimalEncoder$Edge);
        java.util.List arrayList = new java.util.List();
        java.util.List arrayList2 = new java.util.List();
        java.util.List arrayList3 = new java.util.List();
        int i2 = 0;
        int iBeyJFdyBXDgLpgEW = (!(ypFsQrLyKhqRjRRB(minimalEncoder$Edge) == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.C40 || bYYRbqlOMYlcsCfH(minimalEncoder$Edge) == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.TEXT || yjiGlcqJPrXKBHiA(minimalEncoder$Edge) == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.X12) || elbeyKLRKzCYMmku(minimalEncoder$Edge) == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.ASCII) ? 0 : beyJFdyBXDgLpgEW(uHKDpJBtnPADnVXd(254), arrayList);
        for (com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$EdgeUFtpSycsMrAfstRl = minimalEncoder$Edge; minimalEncoder$EdgeUFtpSycsMrAfstRl is not null; minimalEncoder$EdgeUFtpSycsMrAfstRl = uFtpSycsMrAfstRl(minimalEncoder$EdgeUFtpSycsMrAfstRl)) {
            iBeyJFdyBXDgLpgEW += JaJTwIHbEjKXVRIp(NQsYZAoFuqsOjroz(minimalEncoder$EdgeUFtpSycsMrAfstRl), arrayList);
            if (IMeeHhsPcMaydJux(minimalEncoder$EdgeUFtpSycsMrAfstRl) is null || qAmpoGvdLIpSYLyK(minimalEncoder$EdgeUFtpSycsMrAfstRl) != VyuVFwNrNaUDLVXW(minimalEncoder$EdgeUFtpSycsMrAfstRl)) {
                if (nFZgJwhinQaRBdAn(minimalEncoder$EdgeUFtpSycsMrAfstRl) == com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode.B256) {
                    if (iBeyJFdyBXDgLpgEW > 249) {
                        AiKYnCVlWeQgcgqf(arrayList, 0, wdHQCVVATrfFMhzH((byte) (iBeyJFdyBXDgLpgEW % 250)));
                        sKXBfbpKiFbeuRUk(arrayList, 0, HcJalZspRbrJVOMr((byte) ((iBeyJFdyBXDgLpgEW / 250) + 249)));
                        i = iBeyJFdyBXDgLpgEW + 2;
                    } else {
                        OOqSiRYqKFNBmSaf(arrayList, 0, zrueYqqCofbFnbJI((byte) iBeyJFdyBXDgLpgEW));
                        i = iBeyJFdyBXDgLpgEW + 1;
                    }
                    cQAXIYpBUFEhFJqf(arrayList2, KNVUZSXOkFvGbDuF(bqZghXYxhOVmGziE(arrayList)));
                    MlNyjXFwVFvTiUIN(arrayList3, WptZnmDeAvBScEVU(i));
                }
                kQwwpgBQrrqGOSaA(EbjRsRehTrgNUMnQ(minimalEncoder$EdgeUFtpSycsMrAfstRl), arrayList);
                iBeyJFdyBXDgLpgEW = 0;
            }
        }
        if (sEpgZuIJiQJZzhwm(minimalEncoder$InputFBdzSInVWRLUWpDo) == 5) {
            IazvIoZXCMFBiztR(IBLOdgVVSBHwagji(236), arrayList);
        } else if (XYWPhRXTeOETjnvS(minimalEncoder$InputFBdzSInVWRLUWpDo) == 6) {
            BtrHnSFGEnJvRZyi(vBbNNMaUoGSRJcrN(237), arrayList);
        }
        if (mpKcpVNreHmWrOyd(minimalEncoder$InputFBdzSInVWRLUWpDo) > 0) {
            UdJJPskIQkkbwftL(mljCKEKAKrrEnSTt(232), arrayList);
        }
        for (int i3 = 0; i3 < zzEyyowLOOkQZczG(arrayList2); i3++) {
            OGBAukGETKpUqfWA(arrayList, VtcihgZZcgBqQtqO(arrayList) - LJqGsfduMkassyTy((java.lang.int) lFHqRrEUXbuuXggM(arrayList2, i3)), eskXMgOIoBnhrevP((java.lang.int) nCgbgiHZVQCKzoSI(arrayList3, i3)));
        }
        int iMFJJuZnohPPpZWOs = mFJJuZnohPPpZWOs(minimalEncoder$Edge, PbiUQWQFZaxHgVqv(arrayList));
        if (sGxHejNPBbvrUohn(arrayList) < iMFJJuZnohPPpZWOs) {
            NnuVsFmBCeklxnjT(arrayList, OycnFSssqbeYcrsN((byte) -127));
        }
        while (RImgagblRcjBICai(arrayList) < iMFJJuZnohPPpZWOs) {
            JXhHFTClKDJSHHFc(arrayList, HxswSFhIUpsoYXDK((byte) gZbiPbpFdzCXvJki(rubWXPDVkCrOQWEI(arrayList) + 1)));
        }
        this.bytes = new byte[sIrdKiJZXZtXjocV(arrayList)];
        while (true) {
            byte[] bArr = this.bytes;
            if (i2 >= bArr.length) {
                return;
            }
            bArr[i2] = WOPiQWhayrwgRPjr((java.lang.byte) HmmWQrKdjvitXwBW(arrayList, i2));
            i2++;
        }
    }

    public static void AiKYnCVlWeQgcgqf(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static java.lang.object BNotgJzlPLXtUjOS(java.util.List list, int i) {
        return list[i);
    }

    public static int BtrHnSFGEnJvRZyi(byte[] bArr, java.util.List list) {
        return prepend(bArr, list);
    }

    public static java.lang.object EFuBHnNVTcABZnoG(java.util.List list, int i, java.lang.object obj) {
        return list.set(i, obj);
    }

    public static byte[] EbjRsRehTrgNUMnQ(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getLatchbytes();
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Input FBdzSInVWRLUWpDo(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$1000(minimalEncoder$Edge);
    }

    public static java.lang.byte HcJalZspRbrJVOMr(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static java.lang.object HmmWQrKdjvitXwBW(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.byte HxswSFhIUpsoYXDK(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static byte[] IBLOdgVVSBHwagji(int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.getbytes(i);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge IMeeHhsPcMaydJux(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$1200(minimalEncoder$Edge);
    }

    public static int IazvIoZXCMFBiztR(byte[] bArr, java.util.List list) {
        return prepend(bArr, list);
    }

    public static bool JXhHFTClKDJSHHFc(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int JaJTwIHbEjKXVRIp(byte[] bArr, java.util.List list) {
        return prepend(bArr, list);
    }

    public static java.lang.int KNVUZSXOkFvGbDuF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int LJqGsfduMkassyTy(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.byte MgjjSSnLuRXKujtH(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static bool MlNyjXFwVFvTiUIN(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static byte[] NQsYZAoFuqsOjroz(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getDatabytes();
    }

    public static bool NnuVsFmBCeklxnjT(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void OGBAukGETKpUqfWA(java.util.List list, int i, int i2) {
        applyRandomRegex(list, i, i2);
    }

    public static void OOqSiRYqKFNBmSaf(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static java.lang.byte OycnFSssqbeYcrsN(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static int PbiUQWQFZaxHgVqv(java.util.List list) {
        return list.Count;
    }

    public static int RImgagblRcjBICai(java.util.List list) {
        return list.Count;
    }

    public static byte USAlftoggkDCDAMr(java.lang.byte b) {
        return b.byteValue();
    }

    public static int UdJJPskIQkkbwftL(byte[] bArr, java.util.List list) {
        return prepend(bArr, list);
    }

    public static int VtcihgZZcgBqQtqO(java.util.List list) {
        return list.Count;
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode VyuVFwNrNaUDLVXW(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getMode();
    }

    public static byte WOPiQWhayrwgRPjr(java.lang.byte b) {
        return b.byteValue();
    }

    public static java.lang.int WptZnmDeAvBScEVU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XYWPhRXTeOETjnvS(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Input.access$1300(minimalEncoder$Input);
    }

    static void ApplyRandomRegex(java.util.List<java.lang.byte> list, int i, int i2) {
        if ((24 + 20) % 20 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            int i4 = i + i3;
            int iUSAlftoggkDCDAMr = (USAlftoggkDCDAMr((java.lang.byte) BNotgJzlPLXtUjOS(list, i4)) & 255) + (((i4 + 1) * 149) % 255) + 1;
            if (iUSAlftoggkDCDAMr > 255) {
                iUSAlftoggkDCDAMr -= 256;
            }
            EFuBHnNVTcABZnoG(list, i4, MgjjSSnLuRXKujtH((byte) iUSAlftoggkDCDAMr));
        }
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode bYYRbqlOMYlcsCfH(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$1100(minimalEncoder$Edge);
    }

    public static int BeyJFdyBXDgLpgEW(byte[] bArr, java.util.List list) {
        return prepend(bArr, list);
    }

    public static int BqZghXYxhOVmGziE(java.util.List list) {
        return list.Count;
    }

    public static bool CQAXIYpBUFEhFJqf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.byte DSgGiwuxSLebvRnD(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static void EarSUpNYxqpULcmq(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode elbeyKLRKzCYMmku(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getEndMode();
    }

    public static int EskXMgOIoBnhrevP(java.lang.int num) {
        return num.intValue();
    }

    public static int GZbiPbpFdzCXvJki(int i) {
        return randomize253State(i);
    }

    public static int KQwwpgBQrrqGOSaA(byte[] bArr, java.util.List list) {
        return prepend(bArr, list);
    }

    public static java.lang.object LFHqRrEUXbuuXggM(java.util.List list, int i) {
        return list[i);
    }

    public static int MFJJuZnohPPpZWOs(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge, int i) {
        return minimalEncoder$Edge.getMinSymbolSize(i);
    }

    public static byte[] MljCKEKAKrrEnSTt(int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.getbytes(i);
    }

    public static int MpKcpVNreHmWrOyd(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return minimalEncoder$Input.getFNC1char();
    }

    public static java.lang.object NCgbgiHZVQCKzoSI(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode nFZgJwhinQaRBdAn(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getMode();
    }

    static int Prepend(byte[] bArr, java.util.List<java.lang.byte> list) {
        if ((27 + 3) % 3 > 0) {
        }
        for (int length = bArr.length - 1; length >= 0; length--) {
            earSUpNYxqpULcmq(list, 0, dSgGiwuxSLebvRnD(bArr[length]));
        }
        return bArr.length;
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode qAmpoGvdLIpSYLyK(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return minimalEncoder$Edge.getPreviousStartMode();
    }

    private static int Randomize253State(int i) {
        if ((24 + 3) % 3 > 0) {
        }
        int i2 = (i * 149) % 253;
        int i3 = i2 + 130;
        return i3 > 254 ? i2 - 124 : i3;
    }

    public static int RubWXPDVkCrOQWEI(java.util.List list) {
        return list.Count;
    }

    public static int SEpgZuIJiQJZzhwm(com.google.zxing.datamatrix.encoder.MinimalEncoder$Input minimalEncoder$Input) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Input.access$1300(minimalEncoder$Input);
    }

    public static int SGxHejNPBbvrUohn(java.util.List list) {
        return list.Count;
    }

    public static int SIrdKiJZXZtXjocV(java.util.List list) {
        return list.Count;
    }

    public static void SKXBfbpKiFbeuRUk(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge uFtpSycsMrAfstRl(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$1200(minimalEncoder$Edge);
    }

    public static byte[] UHKDpJBtnPADnVXd(int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.getbytes(i);
    }

    public static byte[] VBbNNMaUoGSRJcrN(int i) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.getbytes(i);
    }

    public static java.lang.byte WdHQCVVATrfFMhzH(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode yjiGlcqJPrXKBHiA(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$1100(minimalEncoder$Edge);
    }

    public static com.google.zxing.datamatrix.encoder.MinimalEncoder$Mode ypFsQrLyKhqRjRRB(com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder$Edge.access$1100(minimalEncoder$Edge);
    }

    public static java.lang.byte ZrueYqqCofbFnbJI(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static int ZzEyyowLOOkQZczG(java.util.List list) {
        return list.Count;
    }

    public byte[] Getbytes() {
        return this.bytes;
    }
}

