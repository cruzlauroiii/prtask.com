namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_RolloutAssignment : com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment {
    private readonly java.lang.string parameterKey;
    private readonly java.lang.string parameterValue;
    private readonly java.lang.string rolloutId;
    private readonly long templateVersion;
    private readonly java.lang.string variantId;

    private AutoValue_RolloutAssignment(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, long j) {
        this.rolloutId = str;
        this.variantId = str2;
        this.parameterKey = str3;
        this.parameterValue = str4;
        this.templateVersion = j;
    }

    AutoValue_RolloutAssignment(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, long j, com.google.firebase.remoteconfig.interop.rollouts.AutoValue_RolloutAssignment$1 autoValue_RolloutAssignment$1) {
        this(str, str2, str3, str4, j);
    }

    public static bool BCrIFQtIRmVLUBAi(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder GkHTBNzwfHmsbDQC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JNuTytDthjgNPEZI(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getRolloutId();
    }

    public static java.lang.stringBuilder KFCmSYMVjcECoJlg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KzcrRwiGmMvLmHSl(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder NeucptULaERQLVVz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PCbrqqjpUOuIkkQf(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int PvmSVahuNQJkxSvD(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder PyObIwmzhhEzJQWG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TvAUISSFMtkhpWPM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WguWolAhifkDaLYp(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder AUDHLBxikHxZXdVc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long BKLtYUpYWOYfNRyA(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        if ((6 + 17) % 17 > 0) {
        }
        return rolloutAssignment.getTemplateVersion();
    }

    public static java.lang.stringBuilder BirWNMfcNCmLnNCF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool CGUqknzKfUlUHddz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string DwdVuHOtmpwMESzd(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getVariantId();
    }

    public static java.lang.string EIOQDbNfIvmqCboQ(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getParameterKey();
    }

    public static bool EZkCKKQeNrQdOCwY(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string ILHGVJyYsxMcovVJ(com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment) {
        return rolloutAssignment.getParameterValue();
    }

    public static int NrKxrojRFBKKEYwH(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder QffZmBljCZcjYThz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SYDneQyIogeBldwM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UpdxMTXhDsCsLCOF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XWOvaraOCKTcypwA(java.lang.string str) {
        return str.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 1) % 1 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment) {
            com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment rolloutAssignment = (com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment) obj;
            if (cGUqknzKfUlUHddz(this.rolloutId, JNuTytDthjgNPEZI(rolloutAssignment)) && BCrIFQtIRmVLUBAi(this.variantId, dwdVuHOtmpwMESzd(rolloutAssignment)) && WguWolAhifkDaLYp(this.parameterKey, eIOQDbNfIvmqCboQ(rolloutAssignment)) && eZkCKKQeNrQdOCwY(this.parameterValue, iLHGVJyYsxMcovVJ(rolloutAssignment)) && this.templateVersion == bKLtYUpYWOYfNRyA(rolloutAssignment)) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string GetParameterKey() {
        return this.parameterKey;
    }

    public override java.lang.string GetParameterValue() {
        return this.parameterValue;
    }

    public override java.lang.string GetRolloutId() {
        return this.rolloutId;
    }

    public override long GetTemplateVersion() {
        if ((14 + 28) % 28 > 0) {
        }
        return this.templateVersion;
    }

    public override java.lang.string GetVariantId() {
        return this.variantId;
    }

    public int HashCode() {
        if ((4 + 20) % 20 > 0) {
        }
        int iPvmSVahuNQJkxSvD = (((((((PvmSVahuNQJkxSvD(this.rolloutId) ^ 1000003) * 1000003) ^ xWOvaraOCKTcypwA(this.variantId)) * 1000003) ^ nrKxrojRFBKKEYwH(this.parameterKey)) * 1000003) ^ KzcrRwiGmMvLmHSl(this.parameterValue)) * 1000003;
        long j = this.templateVersion;
        return ((int) (j ^ (j >>> 32))) ^ iPvmSVahuNQJkxSvD;
    }

    public java.lang.string Tostring() {
        if ((31 + 28) % 28 > 0) {
        }
        return sYDneQyIogeBldwM(aUDHLBxikHxZXdVc(PCbrqqjpUOuIkkQf(NeucptULaERQLVVz(birWNMfcNCmLnNCF(TvAUISSFMtkhpWPM(qffZmBljCZcjYThz(KFCmSYMVjcECoJlg(GkHTBNzwfHmsbDQC(PyObIwmzhhEzJQWG(updxMTXhDsCsLCOF(new java.lang.stringBuilder("RolloutAssignment{rolloutId="), this.rolloutId), ", variantId="), this.variantId), ", parameterKey="), this.parameterKey), ", parameterValue="), this.parameterValue), ", templateVersion="), this.templateVersion), "}"));
    }
}

