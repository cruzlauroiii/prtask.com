namespace WillowMaze.Wasm.Decompiled;


readonly class zzoc {
    public static java.lang.stringBuilder ApHTpEWfIpMmPqZP(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder DJcBfEaHGOQsxWxF(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder DYzQMTRadNdRhmgH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DaaQmvNzbjmREKoM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GHJUltgkMHKsxnXH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JRwLHUflPAHVPhyR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KuEmSuuehsxXSHUJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WxokriZLWcMrViEc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AbwMJEETkyuaUUJx(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder DyVmemEGANFPmfFe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FNlwPCPEaglrTRfC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder HZzbQHHHrowCxYOh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IUDNCSMXHNFuzXXV(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return zzldVar.zzd();
    }

    public static java.lang.stringBuilder JFBkEryIVNOqilpC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LLwFGJiLRyySxNia(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder NcRwccZRBKhFnCEw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte OUUoRRrtaqkRaRpT(com.google.android.gms.internal.measurement.zzld zzldVar, int i) {
        return zzldVar.zza(i);
    }

    public static int QCxIYWqlOCmZEwRH(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return zzldVar.zzd();
    }

    public static java.lang.stringBuilder VKiRtbxKRWYXNkMd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static java.lang.string Zza(com.google.android.gms.internal.measurement.zzld zzldVar) {
        if ((9 + 30) % 30 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iUDNCSMXHNFuzXXV(zzldVar));
        for (int i = 0; i < qCxIYWqlOCmZEwRH(zzldVar); i++) {
            byte bOUUoRRrtaqkRaRpT = oUUoRRrtaqkRaRpT(zzldVar, i);
            if (bOUUoRRrtaqkRaRpT == 34) {
                hZzbQHHHrowCxYOh(sb, "\\\"");
            } else if (bOUUoRRrtaqkRaRpT == 39) {
                ncRwccZRBKhFnCEw(sb, "\\'");
            } else if (bOUUoRRrtaqkRaRpT != 92) {
                switch (bOUUoRRrtaqkRaRpT) {
                    case 7:
                        WxokriZLWcMrViEc(sb, "\\a");
                        break;
                    case 8:
                        DYzQMTRadNdRhmgH(sb, "\\b");
                        break;
                    case 9:
                        jFBkEryIVNOqilpC(sb, "\\t");
                        break;
                    case 10:
                        dyVmemEGANFPmfFe(sb, "\\n");
                        break;
                    case 11:
                        JRwLHUflPAHVPhyR(sb, "\\v");
                        break;
                    case 12:
                        vKiRtbxKRWYXNkMd(sb, "\\f");
                        break;
                    case 13:
                        KuEmSuuehsxXSHUJ(sb, "\\r");
                        break;
                    default:
                        if (bOUUoRRrtaqkRaRpT >= 32 && bOUUoRRrtaqkRaRpT <= 126) {
                            DJcBfEaHGOQsxWxF(sb, (char) bOUUoRRrtaqkRaRpT);
                        } else {
                            abwMJEETkyuaUUJx(sb, '\\');
                            ApHTpEWfIpMmPqZP(sb, (char) (((bOUUoRRrtaqkRaRpT >>> 6) & 3) + 48));
                            fNlwPCPEaglrTRfC(sb, (char) (((bOUUoRRrtaqkRaRpT >>> 3) & 7) + 48));
                            lLwFGJiLRyySxNia(sb, (char) ((bOUUoRRrtaqkRaRpT & 7) + 48));
                        }
                        break;
                }
            } else {
                GHJUltgkMHKsxnXH(sb, "\\\\");
            }
        }
        return DaaQmvNzbjmREKoM(sb);
    }
}

