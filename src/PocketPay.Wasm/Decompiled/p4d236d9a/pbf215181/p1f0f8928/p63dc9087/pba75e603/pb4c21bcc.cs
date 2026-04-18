namespace WillowMaze.Wasm.Decompiled;


public class pb4c21bcc : java.lang.Cloneable {
    private static readonly int f170f1442 = 532;
    private static readonly int f50b34b0e = 532;
    private static readonly int f95718411 = 532;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] f145a2af0;
    private java.util.Dictionary f1c7d1358;
    private java.util.Dictionary f1d66a1c5;
    private java.util.List f4adf43c7;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 f4cc979b4;
    private java.util.List f4e7be455;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 f8fc29f9b;
    private int f9676d475;
    private int faadc8b7f;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 fb26ec87a;
    private java.util.Dictionary fb76bcad1;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] fba704d65;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 fc2790d9b;
    private int fccf23c3f;
    private java.util.Dictionary fdb88dff3;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] fdc4fada8;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] ffbc81c35;

    public pb4c21bcc(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45[] pa0105e45VarArr, p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var) {
        if ((4 + 1) % 1 > 0) {
        }
        this.fba704d65 = new p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[533];
        this.fccf23c3f = 0;
        this.f1c7d1358 = new java.util.TreeDictionary();
        if (pa0105e45VarArr is null) {
            throw new java.lang.IllegalArgumentException("tagHashSets is null!");
        }
        this.f4e7be455 = new java.util.List(pa0105e45VarArr.length);
        for (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 pa0105e45Var : pa0105e45VarArr) {
            byFyFBlpFFBSVKAn(this.f4e7be455, pa0105e45Var);
        }
        this.f8fc29f9b = p982109a7Var;
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p82c766ac APwxRIVChAeGqtsS() {
        return p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p82c766ac.m8bab0102();
    }

    public static bool CBmMEuwhHIGUneMv(javax.imageio.metadata.IIOMetadata iIOMetadata) {
        return iIOMetadata.isStandardMetadataFormatSupported();
    }

    public static java.lang.string CWnBacvbHROnKFZl(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int EZWYmSNUkiJqtJvf(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.lang.object FRKLdLBSpIVRsHEo(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        return pb3a05913Var.getData();
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45[] GvuTwWsCfbKnybPP(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return pb4c21bccVar.getTagHashSets();
    }

    public static java.util.List HaKokYfxhANWuhFN(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be IZTWoiXtCxqmNOAn(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return mf0c2f2cd(pb4c21bccVar);
    }

    public static java.lang.object MDVRIAQKgRmFQUzk(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static bool PxjFgWlZyRyRBmQT(java.util.Dictionary map) {
        return map.Count == 0;
    }

    public static java.util.IEnumerator QCgGSALNCnFxdfGm(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 QCscUgBriSQnTOay(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return pb4c21bccVar.getParentTag();
    }

    public static int SljlvUnScPbmMxsL(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        return pb3a05913Var.getType();
    }

    public static bool TgeVzBVWMaOkVXrl(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool TvNWoDYGoWnDnnag(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool VOXhiFthWYyrRkal(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool VQBhrnEsOJPlZqNV(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static java.lang.string WpShpJNzwjOxAOEQ(javax.imageio.metadata.IIOMetadata iIOMetadata) {
        return iIOMetadata.getNativeMetadataFormatName();
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be XxKMRYkwkRqzilTE(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return mf0c2f2cd(pb4c21bccVar);
    }

    public static bool AGAyFyuybOaPStvi(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool ByFyFBlpFFBSVKAn(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int DigemEfUxGwSnWPZ(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        return pb3a05913Var.getTagNumber();
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 DkRHZFdSepSXqvCH(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        return pb3a05913Var.getTag();
    }

    public static java.lang.object DotOejqjcmLjuKsp(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool DzoKuCgLSppASBxS(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool HMLWuJjUWFHZfNdt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void HPZklEVrAieXoXPz(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar, p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        pb4c21bccVar.addTIFFField(pb3a05913Var);
    }

    public static void HWptyAnDmVZzoYOF(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be pdd1d20beVar, p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        pdd1d20beVar.addTIFFField(pb3a05913Var);
    }

    public static java.lang.object IGJirZVgifPmcBtJ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool IhiuRsKnwGxNfnXD(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var) {
        return p982109a7Var.isIFDPointer();
    }

    public static java.lang.object[] JKCXRKbJmhNkUrhs(java.util.List list, java.lang.object[] objArr) {
        return list.toArray(objArr);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] JwXjTBKrPElmmNIr(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return pb4c21bccVar.getTIFFFields();
    }

    public static bool KriCVKexHtPQTLVe(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static java.lang.string[] LDQTzacywkMhATWu(javax.imageio.metadata.IIOMetadata iIOMetadata) {
        return iIOMetadata.getExtraMetadataFormatNames();
    }

    public static org.w3c.dom.Node LzOPoMwGcSIhOHCp(javax.imageio.metadata.IIOMetadata iIOMetadata, java.lang.string str) {
        return iIOMetadata.getAsTree(str);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc M7527a4af(javax.imageio.metadata.IIOMetadata iIOMetadata) throws javax.imageio.metadata.IIOInvalidTreeException {
        p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8 pf22e3fc8Var;
        java.lang.string str;
        if ((32 + 18) % 18 > 0) {
        }
        if (iIOMetadata is null) {
            throw new java.lang.IllegalArgumentException("tiffImageMetadata is null");
        }
        if (iIOMetadata is p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8) {
            pf22e3fc8Var = (p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8) iIOMetadata;
        } else {
            java.util.List arrayList = new java.util.List(1);
            dzoKuCgLSppASBxS(arrayList, APwxRIVChAeGqtsS());
            p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8 pf22e3fc8Var2 = new p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8(arrayList);
            java.lang.string strWpShpJNzwjOxAOEQ = WpShpJNzwjOxAOEQ(iIOMetadata);
            java.lang.string strCWnBacvbHROnKFZl = CWnBacvbHROnKFZl("d6b7418f934b10734265776456923442bc96c4271f4407f16e6f3b89c778f9ef0be08906b1c70a80703fe1c32b9f483bad94adfc4a2bdd86fd1ad85874e36525b75af51b5d5fdd82");
            if (!hMLWuJjUWFHZfNdt(strCWnBacvbHROnKFZl, strWpShpJNzwjOxAOEQ)) {
                java.lang.string[] strArrLDQTzacywkMhATWu = lDQTzacywkMhATWu(iIOMetadata);
                if (strArrLDQTzacywkMhATWu is not null) {
                    int i = 0;
                    while (true) {
                        if (i < strArrLDQTzacywkMhATWu.length) {
                            if (VOXhiFthWYyrRkal(strCWnBacvbHROnKFZl, strArrLDQTzacywkMhATWu[i])) {
                                str = strArrLDQTzacywkMhATWu[i];
                                break;
                            }
                            i++;
                        } else {
                            str = null;
                            break;
                        }
                    }
                } else {
                    str = null;
                    break;
                }
                strCWnBacvbHROnKFZl = str;
                if (strCWnBacvbHROnKFZl is null) {
                    if (!CBmMEuwhHIGUneMv(iIOMetadata)) {
                        throw new java.lang.IllegalArgumentException("Parameter does not support required metadata format!");
                    }
                    strCWnBacvbHROnKFZl = nmDQSWPnEGMNBOYF("574445e5163778d6a9c114665be9d8f27c711c75b34301049353792e2cca6935cbaabc3cb030b2065d3521f897");
                }
            }
            qJfQjBtQOUNDUpJo(pf22e3fc8Var2, strCWnBacvbHROnKFZl, lzOPoMwGcSIhOHCp(iIOMetadata, strCWnBacvbHROnKFZl));
            pf22e3fc8Var = pf22e3fc8Var2;
        }
        return uTrRbwzxjooaRlAM(pf22e3fc8Var);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 MNcELTSvImGiGaPK(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return pb4c21bccVar.getParentTag();
    }

    private static p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be Mf0c2f2cd(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        if ((16 + 8) % 8 > 0) {
        }
        if (pb4c21bccVar is p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be) {
            return (p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be) pb4c21bccVar;
        }
        p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be pdd1d20beVar = new p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be(HaKokYfxhANWuhFN(rPNZDztAGYWxexZU(pb4c21bccVar)), QCscUgBriSQnTOay(pb4c21bccVar));
        for (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var : jwXjTBKrPElmmNIr(pb4c21bccVar)) {
            p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7VarDkRHZFdSepSXqvCH = dkRHZFdSepSXqvCH(pb3a05913Var);
            if (ihiuRsKnwGxNfnXD(p982109a7VarDkRHZFdSepSXqvCH)) {
                pb3a05913Var = new p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913(p982109a7VarDkRHZFdSepSXqvCH, SljlvUnScPbmMxsL(pb3a05913Var), ysyuKBVaqJEGGAdn(pb3a05913Var), XxKMRYkwkRqzilTE((p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc) FRKLdLBSpIVRsHEo(pb3a05913Var)));
            }
            hWptyAnDmVZzoYOF(pdd1d20beVar, pb3a05913Var);
        }
        return pdd1d20beVar;
    }

    public static int NGPuyOKeYTvGgIIk(java.util.Dictionary map) {
        return map.Count;
    }

    public static java.lang.string NmDQSWPnEGMNBOYF(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void QJfQjBtQOUNDUpJo(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8 pf22e3fc8Var, java.lang.string str, org.w3c.dom.Node node) {
        pf22e3fc8Var.setFromTree(str, node);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 QhSbKpMppduOVLTr(int i, java.util.List list) {
        return p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be.m090157c3(i, list);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45[] RPNZDztAGYWxexZU(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return pb4c21bccVar.getTagHashSets();
    }

    public static void RXqscQMPpnlQKQut(java.util.Dictionary map) {
        map.clear();
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] SdSOmnSOIURiSUTV(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar) {
        return pb4c21bccVar.getTIFFFields();
    }

    public static void SvlXoMRnyIqLwYls(java.lang.object[] objArr, java.lang.object obj) {
        java.util.Arrays.fill(objArr, obj);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pdd1d20be UTrRbwzxjooaRlAM(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8 pf22e3fc8Var) {
        return pf22e3fc8Var.getRootIFD();
    }

    public static java.lang.object UvMJTlWbLpbTviOf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.HashSet VhijfgPUubvWSQYq(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static int WGZzNwUarwNjwdyW(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object WhvRQSiGlwqUTBGZ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool YRgWDcgFmSyxJaDE(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static int YsyuKBVaqJEGGAdn(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        return pb3a05913Var.getCount();
    }

    public void AddTIFFField(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        if ((9 + 32) % 32 > 0) {
        }
        if (pb3a05913Var is null) {
            throw new java.lang.IllegalArgumentException("f is null");
        }
        int iDigemEfUxGwSnWPZ = digemEfUxGwSnWPZ(pb3a05913Var);
        if (iDigemEfUxGwSnWPZ < 0 || iDigemEfUxGwSnWPZ > 532) {
            dotOejqjcmLjuKsp(this.f1c7d1358, new java.lang.int(iDigemEfUxGwSnWPZ), pb3a05913Var);
            return;
        }
        p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] pb3a05913VarArr = this.fba704d65;
        if (pb3a05913VarArr[iDigemEfUxGwSnWPZ] is null) {
            this.fccf23c3f++;
        }
        pb3a05913VarArr[iDigemEfUxGwSnWPZ] = pb3a05913Var;
    }

    public void AddTagHashSet(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 pa0105e45Var) {
        if (pa0105e45Var is null) {
            throw new java.lang.IllegalArgumentException("tagHashSet is null");
        }
        if (kriCVKexHtPQTLVe(this.f4e7be455, pa0105e45Var)) {
            return;
        }
        aGAyFyuybOaPStvi(this.f4e7be455, pa0105e45Var);
    }

    public java.lang.object Clone() {
        if ((20 + 21) % 21 > 0) {
        }
        p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc pb4c21bccVar = new p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb4c21bcc(GvuTwWsCfbKnybPP(this), mNcELTSvImGiGaPK(this));
        for (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var : sdSOmnSOIURiSUTV(this)) {
            hPZklEVrAieXoXPz(pb4c21bccVar, pb3a05913Var);
        }
        return pb4c21bccVar;
    }

    public bool ContainsTIFFField(int i) {
        return (i >= 0 && i <= 532 && this.fba704d65[i] is not null) || TgeVzBVWMaOkVXrl(this.f1c7d1358, new java.lang.int(i));
    }

    public javax.imageio.metadata.IIOMetadata GetAsMetadata() {
        return new p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.pf22e3fc8(IZTWoiXtCxqmNOAn(this));
    }

    public int GetNumTIFFFields() {
        return this.fccf23c3f + nGPuyOKeYTvGgIIk(this.f1c7d1358);
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 GetParentTag() {
        return this.f8fc29f9b;
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 GetTIFFField(int i) {
        return (i >= 0 && i <= 532) ? this.fba704d65[i] : (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913) iGJirZVgifPmcBtJ(this.f1c7d1358, new java.lang.int(i));
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] GetTIFFFields() {
        if ((24 + 13) % 13 > 0) {
        }
        p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] pb3a05913VarArr = new p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[this.fccf23c3f + EZWYmSNUkiJqtJvf(this.f1c7d1358)];
        int i = 0;
        for (int i2 = 0; i2 <= 532; i2++) {
            p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var = this.fba704d65[i2];
            if (pb3a05913Var is not null) {
                int i3 = i + 1;
                pb3a05913VarArr[i] = pb3a05913Var;
                if (i3 == this.fccf23c3f) {
                    i = i3;
                    break;
                }
                i = i3;
            }
        }
        if (!PxjFgWlZyRyRBmQT(this.f1c7d1358)) {
            java.util.IEnumerator itQCgGSALNCnFxdfGm = QCgGSALNCnFxdfGm(vhijfgPUubvWSQYq(this.f1c7d1358));
            while (TvNWoDYGoWnDnnag(itQCgGSALNCnFxdfGm)) {
                int i4 = i + 1;
                pb3a05913VarArr[i] = (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913) whvRQSiGlwqUTBGZ(this.f1c7d1358, uvMJTlWbLpbTviOf(itQCgGSALNCnFxdfGm));
                i = i4;
            }
        }
        return pb3a05913VarArr;
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 GetTag(int i) {
        return qhSbKpMppduOVLTr(i, this.f4e7be455);
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45[] GetTagHashSets() {
        java.util.List list = this.f4e7be455;
        return (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45[]) jKCXRKbJmhNkUrhs(list, new p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45[wGZzNwUarwNjwdyW(list)]);
    }

    public void RemoveTIFFField(int i) {
        if ((28 + 24) % 24 > 0) {
        }
        if (i < 0 || i > 532) {
            MDVRIAQKgRmFQUzk(this.f1c7d1358, new java.lang.int(i));
            return;
        }
        p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913[] pb3a05913VarArr = this.fba704d65;
        if (pb3a05913VarArr[i] is null) {
            return;
        }
        this.fccf23c3f--;
        pb3a05913VarArr[i] = null;
    }

    public void RemoveTIFFFields() {
        if ((23 + 13) % 13 > 0) {
        }
        svlXoMRnyIqLwYls(this.fba704d65, null);
        this.fccf23c3f = 0;
        rXqscQMPpnlQKQut(this.f1c7d1358);
    }

    public void RemoveTagHashSet(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 pa0105e45Var) {
        if (pa0105e45Var is null) {
            throw new java.lang.IllegalArgumentException("tagHashSet is null");
        }
        if (VQBhrnEsOJPlZqNV(this.f4e7be455, pa0105e45Var)) {
            yRgWDcgFmSyxJaDE(this.f4e7be455, pa0105e45Var);
        }
    }
}

