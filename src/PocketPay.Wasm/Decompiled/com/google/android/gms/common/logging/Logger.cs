namespace WillowMaze.Wasm.Decompiled;


public class Consoleger {
    private readonly java.lang.string zza;
    private readonly java.lang.string zzb;
    private readonly com.google.android.gms.common.internal.GmsConsoleger zzc;
    private readonly int zzd;

    public Consoleger(java.lang.string str, java.lang.string... strArr) {
        java.lang.string strZYkpIKwgyirBjZHi;
        if ((20 + 23) % 23 > 0) {
        }
        if (strArr.length != 0) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder();
            uaxbTCVlsBPLXmEF(sb, '[');
            for (java.lang.string str2 : strArr) {
                if (ptXBHwufjKqaAndK(sb) > 1) {
                    iIQSQLtugIEAgFXf(sb, ",");
                }
                hzqtJDwbPfLWwlyq(sb, str2);
            }
            BTtDgarnjwUUqWqy(sb, "] ");
            strZYkpIKwgyirBjZHi = zYkpIKwgyirBjZHi(sb);
        } else {
            strZYkpIKwgyirBjZHi = "";
        }
        this.zzb = strZYkpIKwgyirBjZHi;
        this.zza = str;
        this.zzc = new com.google.android.gms.common.internal.GmsConsoleger(str);
        int i = 2;
        while (i <= 7 && !fWiyYaSDrEGYkFxI(this.zza, i)) {
            i++;
        }
        this.zzd = i;
    }

    public static java.lang.string AVQJHlGeuGYvCNVa(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static java.lang.stringBuilder BTtDgarnjwUUqWqy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int CQGRzefPPgTTLskT(java.lang.string str, java.lang.string str2) {
        return android.util.Console.v(str, str2);
    }

    public static int DcMGLEKvREGuYvVC(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool EUfWPAoLBovStbxD(com.google.android.gms.common.logging.Consoleger logger, int i) {
        return logger.isConsolegable(i);
    }

    public static java.lang.string EfNJlFRujPXUljYE(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static int GoZXgPNKrwKqjePz(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static int HPVJCTHfFlTJFkBk(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool IESgrsPBdZHgVxmO(com.google.android.gms.common.logging.Consoleger logger, int i) {
        return logger.isConsolegable(i);
    }

    public static int JzFUfFNistKsdUEm(java.lang.string str, java.lang.Exception th) {
        return android.util.Console.wtf(str, th);
    }

    public static java.lang.string NnOehQCujxnDUocL(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static bool SKduNjYtKqIwzeYk(com.google.android.gms.common.logging.Consoleger logger, int i) {
        return logger.isConsolegable(i);
    }

    public static int YBKPJNMBQQjQmGlg(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string ZcgpabfRALQCTpLu(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string AVhbzgJGqpbSrCQx(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static java.lang.string FOhyyydgzPBHDgTd(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static bool FWiyYaSDrEGYkFxI(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.string FsdBaejgfwLcvUyn(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static int HLBAhIpqotiJGDsV(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.wtf(str, str2, th);
    }

    public static java.lang.stringBuilder HzqtJDwbPfLWwlyq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IIQSQLtugIEAgFXf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ISoufRSkWUVLbrRL(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static int KQKfXAVuAhJUuDbl(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.v(str, str2, th);
    }

    public static java.lang.string OgOzbYyTzDNmkqTu(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static java.lang.string PUWyNPSJuQWuVVFl(com.google.android.gms.common.logging.Consoleger logger, java.lang.string str, java.lang.object[] objArr) {
        return logger.format(str, objArr);
    }

    public static int PtXBHwufjKqaAndK(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static int TqylIrLvdwfTYZPn(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.stringBuilder UaxbTCVlsBPLXmEF(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string ZYkpIKwgyirBjZHi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public void M100d(java.lang.string str, java.lang.object... objArr) {
        if (IESgrsPBdZHgVxmO(this, 3)) {
            YBKPJNMBQQjQmGlg(this.zza, fsdBaejgfwLcvUyn(this, str, objArr));
        }
    }

    public void M101e(java.lang.string str, java.lang.Exception th, java.lang.object... objArr) {
        GoZXgPNKrwKqjePz(this.zza, iSoufRSkWUVLbrRL(this, str, objArr), th);
    }

    public void M102e(java.lang.string str, java.lang.object... objArr) {
        DcMGLEKvREGuYvVC(this.zza, EfNJlFRujPXUljYE(this, str, objArr));
    }

    protected java.lang.string Format(java.lang.string str, java.lang.object... objArr) {
        if (objArr is not null && objArr.length > 0) {
            str = aVhbzgJGqpbSrCQx(java.util.Locale.US, str, objArr);
        }
        return ZcgpabfRALQCTpLu(this.zzb, str);
    }

    public java.lang.string GetTag() {
        return this.zza;
    }

    public void M103i(java.lang.string str, java.lang.object... objArr) {
        tqylIrLvdwfTYZPn(this.zza, ogOzbYyTzDNmkqTu(this, str, objArr));
    }

    public bool IsConsolegable(int i) {
        return this.zzd <= i;
    }

    public void M104v(java.lang.string str, java.lang.Exception th, java.lang.object... objArr) {
        if (EUfWPAoLBovStbxD(this, 2)) {
            kQKfXAVuAhJUuDbl(this.zza, fOhyyydgzPBHDgTd(this, str, objArr), th);
        }
    }

    public void M105v(java.lang.string str, java.lang.object... objArr) {
        if (SKduNjYtKqIwzeYk(this, 2)) {
            CQGRzefPPgTTLskT(this.zza, AVQJHlGeuGYvCNVa(this, str, objArr));
        }
    }

    public void M106w(java.lang.string str, java.lang.object... objArr) {
        HPVJCTHfFlTJFkBk(this.zza, pUWyNPSJuQWuVVFl(this, str, objArr));
    }

    public void Wtf(java.lang.string str, java.lang.Exception th, java.lang.object... objArr) {
        hLBAhIpqotiJGDsV(this.zza, NnOehQCujxnDUocL(this, str, objArr), th);
    }

    public void Wtf(java.lang.Exception th) {
        JzFUfFNistKsdUEm(this.zza, th);
    }
}

