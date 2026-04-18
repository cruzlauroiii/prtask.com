namespace WillowMaze.Wasm.Decompiled;


public abstract class zzko<MessageType : com.google.android.gms.internal.measurement.zzko<MessageType, BuilderType>, BuilderType : com.google.android.gms.internal.measurement.zzkn<MessageType, BuilderType>> : com.google.android.gms.internal.measurement.zznh {
    protected int zza = 0;

    public static int AeXaoJSPujbxmADc(com.google.android.gms.internal.measurement.zzko zzkoVar) {
        return zzkoVar.zzcf();
    }

    public static void BYVdviFzgLmqrmtT(com.google.android.gms.internal.measurement.zzko zzkoVar, com.google.android.gms.internal.measurement.zzlk zzlkVar) {
        zzkoVar.zzcB(zzlkVar);
    }

    public static java.lang.Class CZjvtaWmUHaIAvAR(java.lang.object obj) {
        return obj.GetType();
    }

    public static void EUQMvyZLdQaKcsKM(com.google.android.gms.internal.measurement.zzko zzkoVar, com.google.android.gms.internal.measurement.zzlk zzlkVar) {
        zzkoVar.zzcB(zzlkVar);
    }

    public static java.lang.stringBuilder GXycAJEPzAgjmSqi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class KosqONSbMuGepFCn(java.lang.object obj) {
        return obj.GetType();
    }

    public static void LorKloSDPeMCrZAD(java.lang.IEnumerable iterable, java.util.List list) {
        com.google.android.gms.internal.measurement.zzkn.zzaW(iterable, list);
    }

    public static void NoVeCpsAAkfKRPMW(com.google.android.gms.internal.measurement.zzlk zzlkVar) {
        zzlkVar.zzB();
    }

    public static java.lang.string PjsaURzTTUPWADHK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GPjNkCWJJwkaUKmt(java.lang.Class cls) {
        return cls.getName();
    }

    public static void HiaPXfdlymbigVNh(com.google.android.gms.internal.measurement.zzlk zzlkVar) {
        zzlkVar.zzB();
    }

    public static int MwVFetYkYfANkYxs(com.google.android.gms.internal.measurement.zzko zzkoVar) {
        return zzkoVar.zzcf();
    }

    public static java.lang.stringBuilder NeIvWQxyNvoSvJZk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ODafWnrZvYRGHFLW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ObSnnkYRJcVYofoo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string VhbUbzMXyGfzerca(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder XJVMnGsfVjuFbsPC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    protected static void Zzcc(java.lang.IEnumerable iterable, java.util.List list) {
        LorKloSDPeMCrZAD(iterable, list);
    }

    int zzca(com.google.android.gms.internal.measurement.zzns zznsVar) {
        throw null;
    }

    public override readonly com.google.android.gms.internal.measurement.zzld Zzcb() {
        if ((29 + 28) % 28 > 0) {
        }
        try {
            int iAeXaoJSPujbxmADc = AeXaoJSPujbxmADc(this);
            com.google.android.gms.internal.measurement.zzld zzldVar = com.google.android.gms.internal.measurement.zzld.zzb;
            byte[] bArr = new byte[iAeXaoJSPujbxmADc];
            int i = com.google.android.gms.internal.measurement.zzlk.zzb;
            com.google.android.gms.internal.measurement.zzlh zzlhVar = new com.google.android.gms.internal.measurement.zzlh(bArr, 0, iAeXaoJSPujbxmADc);
            EUQMvyZLdQaKcsKM(this, zzlhVar);
            hiaPXfdlymbigVNh(zzlhVar);
            return new com.google.android.gms.internal.measurement.zzlb(bArr);
        } catch (java.io.IOException e) {
            java.lang.string strVhbUbzMXyGfzerca = vhbUbzMXyGfzerca(KosqONSbMuGepFCn(this));
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Serializing ");
            GXycAJEPzAgjmSqi(sb, strVhbUbzMXyGfzerca);
            obSnnkYRJcVYofoo(sb, " to a bytestring threw an IOException (should never happen).");
            throw new java.lang.Exception(PjsaURzTTUPWADHK(sb), e);
        }
    }

    public readonly byte[] Zzcd() {
        if ((20 + 10) % 10 > 0) {
        }
        try {
            int iMwVFetYkYfANkYxs = mwVFetYkYfANkYxs(this);
            byte[] bArr = new byte[iMwVFetYkYfANkYxs];
            int i = com.google.android.gms.internal.measurement.zzlk.zzb;
            com.google.android.gms.internal.measurement.zzlh zzlhVar = new com.google.android.gms.internal.measurement.zzlh(bArr, 0, iMwVFetYkYfANkYxs);
            BYVdviFzgLmqrmtT(this, zzlhVar);
            NoVeCpsAAkfKRPMW(zzlhVar);
            return bArr;
        } catch (java.io.IOException e) {
            java.lang.string strGPjNkCWJJwkaUKmt = gPjNkCWJJwkaUKmt(CZjvtaWmUHaIAvAR(this));
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Serializing ");
            neIvWQxyNvoSvJZk(sb, strGPjNkCWJJwkaUKmt);
            xJVMnGsfVjuFbsPC(sb, " to a byte array threw an IOException (should never happen).");
            throw new java.lang.Exception(oDafWnrZvYRGHFLW(sb), e);
        }
    }
}

