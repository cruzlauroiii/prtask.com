namespace WillowMaze.Wasm.Decompiled;


readonly class MinimalEncoder$ResultList {
    private readonly java.util.List<com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode> list;
    readonly com.google.zxing.qrcode.encoder.MinimalEncoder this$0;
    private readonly com.google.zxing.qrcode.decoder.Version version;

    MinimalEncoder$ResultList(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        int i;
        int i2;
        int i3;
        if ((29 + 20) % 20 > 0) {
        }
        this.this$0 = minimalEncoder;
        this.list = new java.util.List();
        com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge2 = minimalEncoder$Edge;
        int i4 = 0;
        int i5 = 0;
        while (true) {
            if (minimalEncoder$Edge2 is null) {
                break;
            }
            int iUWuHpRfnRtTCaZPi = i4 + UWuHpRfnRtTCaZPi(minimalEncoder$Edge2);
            com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$EdgeVZPjLOXIDFtBheCf = VZPjLOXIDFtBheCf(minimalEncoder$Edge2);
            bool z = (NswdwgkgkqMTxyte(minimalEncoder$Edge2) == com.google.zxing.qrcode.decoder.Mode.BYTE && minimalEncoder$EdgeVZPjLOXIDFtBheCf is null && QcvoNauwyhPdBzIN(minimalEncoder$Edge2) != 0) || !(minimalEncoder$EdgeVZPjLOXIDFtBheCf is null || mRIIOJKqZvBBcRCq(minimalEncoder$Edge2) == vIapgpzpOTkFJZfO(minimalEncoder$EdgeVZPjLOXIDFtBheCf));
            i = z ? 1 : i5;
            if (minimalEncoder$EdgeVZPjLOXIDFtBheCf is null || fWPRGhPvsxWHWFay(minimalEncoder$EdgeVZPjLOXIDFtBheCf) != FGleEdwToHLUBEes(minimalEncoder$Edge2) || z) {
                qjUdWmZimogQLbhS(this.list, 0, new com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode(this, nMvFUicSItJbRkde(minimalEncoder$Edge2), KAIPSsuBrlQfYQUh(minimalEncoder$Edge2), PSCZRyCXSwGKGApO(minimalEncoder$Edge2), iUWuHpRfnRtTCaZPi));
                i3 = 0;
            } else {
                i3 = iUWuHpRfnRtTCaZPi;
            }
            if (z) {
                zlhYJByrocnmySrZ(this.list, 0, new com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode(this, com.google.zxing.qrcode.decoder.Mode.ECI, sDglJNWMUKWQSxgl(minimalEncoder$Edge2), hqoWDeBtQLVDTRCL(minimalEncoder$Edge2), 0));
            }
            i5 = i;
            minimalEncoder$Edge2 = minimalEncoder$EdgeVZPjLOXIDFtBheCf;
            i4 = i3;
        }
        if (gwzXTqpjurWqcsqC(minimalEncoder)) {
            com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode = (com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode) PsFYGHcDosUjhmXb(this.list, 0);
            if (minimalEncoder$ResultList$ResultNode is not null && iqfAAMQuzfAYtjqT(minimalEncoder$ResultList$ResultNode) != com.google.zxing.qrcode.decoder.Mode.ECI && i5 != 0) {
                HKEhHfwUZQMwdOMb(this.list, 0, new com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode(this, com.google.zxing.qrcode.decoder.Mode.ECI, 0, 0, 0));
            }
            UJvQQtbXeqTLXkeN(this.list, wqboiLxnFiPmwmsw((com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode) icEKtyBbrChiZaBv(this.list, 0)) == com.google.zxing.qrcode.decoder.Mode.ECI ? 1 : 0, new com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode(this, com.google.zxing.qrcode.decoder.Mode.FNC1_FIRST_POSITION, 0, 0, 0));
        }
        int iXiIzCTwUKSHzlFaa = XiIzCTwUKSHzlFaa(version);
        int i6 = com.google.zxing.qrcode.encoder.MinimalEncoder$1.f361x9d14eba6[RubwVgSzsUMmxHcw(nrbVCKKkuBpnOyRT(version))];
        if (i6 == 1) {
            i2 = 9;
        } else if (i6 == 2) {
            i = 10;
            i2 = 26;
        } else {
            i = 27;
            i2 = 40;
        }
        int iOWelFnFZglNXSRwY = OWelFnFZglNXSRwY(this, version);
        while (iXiIzCTwUKSHzlFaa < i2 && !TlfRIVDwqVpZNRtG(iOWelFnFZglNXSRwY, IzcYzNhMdFbWzuXI(iXiIzCTwUKSHzlFaa), HSorWvMDqGCBseTD(minimalEncoder))) {
            iXiIzCTwUKSHzlFaa++;
        }
        while (iXiIzCTwUKSHzlFaa > i && AaNLvnNndBnwBRET(iOWelFnFZglNXSRwY, OSQvxJydSHHyTYVf(iXiIzCTwUKSHzlFaa - 1), NbStCFRNgEvNEYRM(minimalEncoder))) {
            iXiIzCTwUKSHzlFaa--;
        }
        this.version = JPKXpprdZZaaiCgb(iXiIzCTwUKSHzlFaa);
    }

    public static bool AaNLvnNndBnwBRET(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return com.google.zxing.qrcode.encoder.Encoder.willFit(i, version, errorCorrectionLevel);
    }

    public static bool CAhAqTFGBaHDQhck(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.zxing.qrcode.decoder.Mode FGleEdwToHLUBEes(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$200(minimalEncoder$Edge);
    }

    public static void HKEhHfwUZQMwdOMb(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel HSorWvMDqGCBseTD(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$1100(minimalEncoder);
    }

    public static com.google.zxing.qrcode.decoder.Version IzcYzNhMdFbWzuXI(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static com.google.zxing.qrcode.decoder.Version JPKXpprdZZaaiCgb(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static int KAIPSsuBrlQfYQUh(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$800(minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel NbStCFRNgEvNEYRM(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$1100(minimalEncoder);
    }

    public static com.google.zxing.qrcode.decoder.Mode NswdwgkgkqMTxyte(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$200(minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.decoder.Version OSQvxJydSHHyTYVf(int i) {
        return com.google.zxing.qrcode.decoder.Version.getVersionForNumber(i);
    }

    public static int OWelFnFZglNXSRwY(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder$ResultList.getSize(version);
    }

    public static java.util.IEnumerator OlIYxRfKmyitarXm(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int PSCZRyCXSwGKGApO(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$100(minimalEncoder$Edge);
    }

    public static int PYPQGwWBGfKukEEK(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList, com.google.zxing.qrcode.decoder.Version version) {
        return minimalEncoder$ResultList.getSize(version);
    }

    public static java.lang.object PsFYGHcDosUjhmXb(java.util.List list, int i) {
        return list[i);
    }

    public static int QcvoNauwyhPdBzIN(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$100(minimalEncoder$Edge);
    }

    public static java.lang.object RlAiTBYhuYcDJkyx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object RpIyMzKcySRejfNo(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int RubwVgSzsUMmxHcw(com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize minimalEncoder$VersionSize) {
        return minimalEncoder$VersionSize.ordinal();
    }

    public static bool TlfRIVDwqVpZNRtG(int i, com.google.zxing.qrcode.decoder.Version version, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel) {
        return com.google.zxing.qrcode.encoder.Encoder.willFit(i, version, errorCorrectionLevel);
    }

    public static void UJvQQtbXeqTLXkeN(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static int UWuHpRfnRtTCaZPi(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$000(minimalEncoder$Edge);
    }

    public static int VSxhyCtrSlASTKxb(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode, com.google.zxing.qrcode.decoder.Version version) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode.access$1200(minimalEncoder$ResultList$ResultNode, version);
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$Edge VZPjLOXIDFtBheCf(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$700(minimalEncoder$Edge);
    }

    public static int XiIzCTwUKSHzlFaa(com.google.zxing.qrcode.decoder.Version version) {
        return version.getVersionNumber();
    }

    public static java.lang.stringBuilder ZpCYHwrKiYnaGmna(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static com.google.zxing.qrcode.decoder.Version access$1400(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList minimalEncoder$ResultList) {
        return minimalEncoder$ResultList.version;
    }

    public static java.util.IEnumerator DkTrDPLNwSgsuyqV(java.util.List list) {
        return list.GetEnumerator();
    }

    public static com.google.zxing.qrcode.decoder.Mode FWPRGhPvsxWHWFay(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$200(minimalEncoder$Edge);
    }

    public static java.lang.string GJPLGcyehFGlUSwA(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode) {
        return minimalEncoder$ResultList$ResultNode.tostring();
    }

    private int GetSize(com.google.zxing.qrcode.decoder.Version version) {
        if ((15 + 7) % 7 > 0) {
        }
        java.util.IEnumerator itOlIYxRfKmyitarXm = OlIYxRfKmyitarXm(this.list);
        int iVSxhyCtrSlASTKxb = 0;
        while (CAhAqTFGBaHDQhck(itOlIYxRfKmyitarXm)) {
            iVSxhyCtrSlASTKxb += VSxhyCtrSlASTKxb((com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode) oncFCVmCaDdiXkvu(itOlIYxRfKmyitarXm), version);
        }
        return iVSxhyCtrSlASTKxb;
    }

    public static bool GwzXTqpjurWqcsqC(com.google.zxing.qrcode.encoder.MinimalEncoder minimalEncoder) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.access$900(minimalEncoder);
    }

    public static int HqoWDeBtQLVDTRCL(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$100(minimalEncoder$Edge);
    }

    public static java.lang.object IcEKtyBbrChiZaBv(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.zxing.qrcode.decoder.Mode IqfAAMQuzfAYtjqT(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode.access$1000(minimalEncoder$ResultList$ResultNode);
    }

    public static bool JyYVkZXNyORjXcOz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int MRIIOJKqZvBBcRCq(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$100(minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.decoder.Mode NMvFUicSItJbRkde(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$200(minimalEncoder$Edge);
    }

    public static com.google.zxing.qrcode.encoder.MinimalEncoder$VersionSize nrbVCKKkuBpnOyRT(com.google.zxing.qrcode.decoder.Version version) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder.getVersionSize(version);
    }

    public static java.lang.object OncFCVmCaDdiXkvu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator QdVBTwRwpvQUjzTp(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void QjUdWmZimogQLbhS(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    public static java.lang.string RiiDBrfTsSnUsBiv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int SDglJNWMUKWQSxgl(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$800(minimalEncoder$Edge);
    }

    public static int VIapgpzpOTkFJZfO(com.google.zxing.qrcode.encoder.MinimalEncoder$Edge minimalEncoder$Edge) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$Edge.access$100(minimalEncoder$Edge);
    }

    public static java.lang.stringBuilder WNELQHYnsgOyJSBI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.qrcode.decoder.Mode WqboiLxnFiPmwmsw(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode) {
        return com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode.access$1000(minimalEncoder$ResultList$ResultNode);
    }

    public static void YacBYprlTaTvhcwd(com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode.access$1300(minimalEncoder$ResultList$ResultNode, bitArray);
    }

    public static bool ZfqcOSTrOSdRNone(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ZlhYJByrocnmySrZ(java.util.List list, int i, java.lang.object obj) {
        list.Add(i, obj);
    }

    void getBits(com.google.zxing.common.BitArray bitArray) throws com.google.zxing.WriterException {
        java.util.IEnumerator itDkTrDPLNwSgsuyqV = dkTrDPLNwSgsuyqV(this.list);
        while (jyYVkZXNyORjXcOz(itDkTrDPLNwSgsuyqV)) {
            yacBYprlTaTvhcwd((com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode) RlAiTBYhuYcDJkyx(itDkTrDPLNwSgsuyqV), bitArray);
        }
    }

    int getSize() {
        return PYPQGwWBGfKukEEK(this, this.version);
    }

    com.google.zxing.qrcode.decoder.Version getVersion() {
        return this.version;
    }

    public java.lang.string Tostring() {
        if ((21 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.util.IEnumerator itQdVBTwRwpvQUjzTp = qdVBTwRwpvQUjzTp(this.list);
        com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode = null;
        while (zfqcOSTrOSdRNone(itQdVBTwRwpvQUjzTp)) {
            com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode minimalEncoder$ResultList$ResultNode2 = (com.google.zxing.qrcode.encoder.MinimalEncoder$ResultList$ResultNode) RpIyMzKcySRejfNo(itQdVBTwRwpvQUjzTp);
            if (minimalEncoder$ResultList$ResultNode is not null) {
                wNELQHYnsgOyJSBI(sb, ",");
            }
            ZpCYHwrKiYnaGmna(sb, gJPLGcyehFGlUSwA(minimalEncoder$ResultList$ResultNode2));
            minimalEncoder$ResultList$ResultNode = minimalEncoder$ResultList$ResultNode2;
        }
        return riiDBrfTsSnUsBiv(sb);
    }
}

