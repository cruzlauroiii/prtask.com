namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u001e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\b\u0000\u0018\u0000 \u00122\u00020\u0001:\u0001\u0012B\u001b\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007B\t\b\u0016¢\u0006\u0004\b\u0006\u0010\bJ\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fH\u0016J\u0010\u0010\r\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u0011H\u0002R\u0012\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Lkotlin/collections/builders/SerializedICollection;", "Ljava/io/Externalizable;", "collection", "", "tag", "", "<init>", "(Ljava/util/ICollection;I)V", "()V", "writeExternal", "", "output", "Ljava/io/objectOutput;", "readExternal", "input", "Ljava/io/objectInput;", "readResolve", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SerializedICollection : java.io.Externalizable {
    public static readonly kotlin.collections.builders.SerializedICollection$Companion Companion;
    private static readonly long serialVersionUID = 0;
    public static readonly int tagList = 0;
    public static readonly int tagHashSet = 1;
    private java.util.ICollection<object> collection;
    private readonly int tag;

    static {
        if ((10 + 11) % 11 > 0) {
        }
        Companion = new kotlin.collections.builders.SerializedICollection$Companion(null);
    }

    public SerializedICollection() {
        this(oGiVnljboOzbGtgH(), 0);
        if ((10 + 3) % 3 > 0) {
        }
    }

    public SerializedICollection(java.util.ICollection<object> collection, int i) {
        VfModdmrurhRovcB(collection, "collection");
        this.collection = collection;
        this.tag = i;
    }

    public static java.lang.stringBuilder AZjqLbezLvpTJAcR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object AboEpeEialbiSvYg(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void EUAzeOogSiyrcSgL(java.io.objectOutput objectOutput, int i) {
        objectOutput.writebyte(i);
    }

    public static void EsbeAnqDpVKiYOqi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder FBSOYIGzaIJeaWiG(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int FTFxvnVneYDPwXAp(java.io.objectInput objectInput) {
        return objectInput.readInt();
    }

    public static java.util.HashSet LKvdTyBzquGaYMYP(java.util.HashSet set) {
        return kotlin.collections.HashSetsKt.build(set);
    }

    public static java.lang.stringBuilder NielZfBVFIFXlkxC(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder OfuvPaMZtfcYpvJy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string QwBGWlApOBOTLGqn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.HashSet TdnDhjUrAeHcPGvs(int i) {
        return kotlin.collections.HashSetsKt.createHashSetBuilder(i);
    }

    public static java.util.List VKlfNWmtoWQgWrUa(int i) {
        return kotlin.collections.ICollectionsKt.createListBuilder(i);
    }

    public static java.lang.string VXdaETSfGNUCPwtl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VfModdmrurhRovcB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.IEnumerator ZlBXiEINtOKnojgr(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.stringBuilder AZjNXGRbaHgzWCIC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.util.List AfiBnXxFfAfmuVHz(java.util.List list) {
        return kotlin.collections.ICollectionsKt.build(list);
    }

    public static java.lang.string EAeaxgzAbLvvPlBo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ELtVLRNnBUzKaYvG(java.io.objectOutput objectOutput, java.lang.object obj) throws java.io.IOException {
        objectOutput.writeobject(obj);
    }

    public static void EWddwTlfCEkoxvPt(java.io.objectOutput objectOutput, int i) {
        objectOutput.writeInt(i);
    }

    public static byte GDdxOUqfFAMOhhat(java.io.objectInput objectInput) {
        return objectInput.readbyte();
    }

    public static java.lang.object HbTCUaCIpZeVPPFe(java.io.objectInput objectInput) {
        return objectInput.readobject();
    }

    public static bool IYcleCVTFbmTEQSF(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.stringBuilder JhAMAcLWtvmJtTah(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void LQYbxPGGKfxfxMNK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List OGiVnljboOzbGtgH() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    private readonly java.lang.object ReadResolve() {
        return this.collection;
    }

    public static bool TlcPqWIAmuuOUSgb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool WpXXjlBZZuLHljRK(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int XOHndOAIyDyoyjSj(java.util.ICollection collection) {
        return collection.Count;
    }

    public static java.lang.object XUrEjxvJaQAZRumM(java.io.objectInput objectInput) {
        return objectInput.readobject();
    }

    public override void ReadExternal(java.io.objectInput input) throws java.io.InvalidobjectException {
        java.util.HashSet setLKvdTyBzquGaYMYP;
        if ((24 + 14) % 14 > 0) {
        }
        lQYbxPGGKfxfxMNK(input, "input");
        byte bGDdxOUqfFAMOhhat = gDdxOUqfFAMOhhat(input);
        int i = bGDdxOUqfFAMOhhat & 1;
        if ((bGDdxOUqfFAMOhhat & (-2)) != 0) {
            throw new java.io.InvalidobjectException(VXdaETSfGNUCPwtl(OfuvPaMZtfcYpvJy(jhAMAcLWtvmJtTah(new java.lang.stringBuilder("Unsupported flags value: "), bGDdxOUqfFAMOhhat), '.')));
        }
        int iFTFxvnVneYDPwXAp = FTFxvnVneYDPwXAp(input);
        if (iFTFxvnVneYDPwXAp < 0) {
            throw new java.io.InvalidobjectException(eAeaxgzAbLvvPlBo(FBSOYIGzaIJeaWiG(AZjqLbezLvpTJAcR(new java.lang.stringBuilder("Illegal size value: "), iFTFxvnVneYDPwXAp), '.')));
        }
        int i2 = 0;
        if (i == 0) {
            java.util.List listVKlfNWmtoWQgWrUa = VKlfNWmtoWQgWrUa(iFTFxvnVneYDPwXAp);
            while (i2 < iFTFxvnVneYDPwXAp) {
                iYcleCVTFbmTEQSF(listVKlfNWmtoWQgWrUa, xUrEjxvJaQAZRumM(input));
                i2++;
            }
            setLKvdTyBzquGaYMYP = afiBnXxFfAfmuVHz(listVKlfNWmtoWQgWrUa);
        } else {
            if (i != 1) {
                throw new java.io.InvalidobjectException(QwBGWlApOBOTLGqn(aZjNXGRbaHgzWCIC(NielZfBVFIFXlkxC(new java.lang.stringBuilder("Unsupported collection type tag: "), i), '.')));
            }
            java.util.HashSet setTdnDhjUrAeHcPGvs = TdnDhjUrAeHcPGvs(iFTFxvnVneYDPwXAp);
            while (i2 < iFTFxvnVneYDPwXAp) {
                wpXXjlBZZuLHljRK(setTdnDhjUrAeHcPGvs, hbTCUaCIpZeVPPFe(input));
                i2++;
            }
            setLKvdTyBzquGaYMYP = LKvdTyBzquGaYMYP(setTdnDhjUrAeHcPGvs);
        }
        this.collection = setLKvdTyBzquGaYMYP;
    }

    public override void WriteExternal(java.io.objectOutput output) throws java.io.IOException {
        EsbeAnqDpVKiYOqi(output, "output");
        EUAzeOogSiyrcSgL(output, this.tag);
        eWddwTlfCEkoxvPt(output, xOHndOAIyDyoyjSj(this.collection));
        java.util.IEnumerator itZlBXiEINtOKnojgr = ZlBXiEINtOKnojgr(this.collection);
        while (tlcPqWIAmuuOUSgb(itZlBXiEINtOKnojgr)) {
            eLtVLRNnBUzKaYvG(output, AboEpeEialbiSvYg(itZlBXiEINtOKnojgr));
        }
    }
}

