namespace WillowMaze.Wasm.Decompiled;


public class DictionaryUtils {
    public static java.lang.stringBuilder CKGpbhoatYlbwOAt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GgmeOhmuJPDEmICI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JBMUSbPuRmVDlgSa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool LXboNtFiTHgBPCMD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder SRuvJEbfBnWjuxrN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.IEnumerator WtVZzARIwMHTpbVo(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object AgvWVPuPGRzLRSPW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.HashSet AwsgdKvsFOIkdonc(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.stringBuilder DSJdTdtmGrrjszrj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GjYAdpDVahBLWHkT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HGBoIcZYvcDtZShK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MIgOaXSkXXXolnIz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ONaPIXQWFPcELIHD(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.stringBuilder QOfXQhWVICOJNaXX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VFEPLdKKGWpNYaHT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WritestringDictionaryToJson(java.lang.stringBuilder sb, java.util.HashDictionary<java.lang.string, java.lang.string> map) {
        if ((18 + 32) % 32 > 0) {
        }
        SRuvJEbfBnWjuxrN(sb, "{");
        java.util.IEnumerator itWtVZzARIwMHTpbVo = WtVZzARIwMHTpbVo(awsgdKvsFOIkdonc(map));
        bool z = true;
        while (LXboNtFiTHgBPCMD(itWtVZzARIwMHTpbVo)) {
            java.lang.string str = (java.lang.string) agvWVPuPGRzLRSPW(itWtVZzARIwMHTpbVo);
            if (!z) {
                hGBoIcZYvcDtZShK(sb, ",");
            }
            java.lang.string str2 = (java.lang.string) oNaPIXQWFPcELIHD(map, str);
            mIgOaXSkXXXolnIz(sb, "\"");
            GgmeOhmuJPDEmICI(sb, str);
            CKGpbhoatYlbwOAt(sb, "\":");
            if (str2 is not null) {
                JBMUSbPuRmVDlgSa(sb, "\"");
                vFEPLdKKGWpNYaHT(sb, str2);
                dSJdTdtmGrrjszrj(sb, "\"");
            } else {
                gjYAdpDVahBLWHkT(sb, "null");
            }
            z = false;
        }
        qOfXQhWVICOJNaXX(sb, "}");
    }
}

