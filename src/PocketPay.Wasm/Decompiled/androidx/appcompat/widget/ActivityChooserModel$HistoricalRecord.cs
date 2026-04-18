namespace WillowMaze.Wasm.Decompiled;


public readonly class objectChooserModel$HistoricalRecord {
    public readonly android.content.ComponentName activity;
    public readonly long time;
    public readonly float weight;

    public objectChooserModel$HistoricalRecord(android.content.ComponentName componentName, long j, float f) {
        this.activity = componentName;
        this.time = j;
        this.weight = f;
    }

    public objectChooserModel$HistoricalRecord(java.lang.string str, long j, float f) {
        this(KaWSgsTMcMIptUYr(str), j, f);
    }

    public static java.lang.Class BpANcpysvGMVqWMi(java.lang.object obj) {
        return obj.GetType();
    }

    public static android.content.ComponentName KaWSgsTMcMIptUYr(java.lang.string str) {
        return android.content.ComponentName.unflattenFromstring(str);
    }

    public static java.lang.stringBuilder PHeHmyFFlzOutZwy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QQIFhWHOAOEIagXk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool SOMCKvjZPPIbZOHb(android.content.ComponentName componentName, java.lang.object obj) {
        return componentName.Equals(obj);
    }

    public static java.lang.string DVFDhhBGCFQvrhyx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FsFdbRGrEMsQkTPf(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static java.lang.stringBuilder JekizRwCRgCxRAdy(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder KOyvHPvtHjGMcAvc(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int MPOrXEBpFzxlBBrD(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static int PrstHQYgKMyLFJQS(float f) {
        return java.lang.float.floatToIntBits(f);
    }

    public static java.lang.Class RfNdkRpcJFOIKgGN(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder XjabLJRdXdzFvoUC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XnkPKenuUhqximeV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int YVQydrDfObVonJco(android.content.ComponentName componentName) {
        return componentName.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 32) % 32 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || rfNdkRpcJFOIKgGN(this) != BpANcpysvGMVqWMi(obj)) {
            return false;
        }
        androidx.appcompat.widget.objectChooserModel$HistoricalRecord activityChooserModel$HistoricalRecord = (androidx.appcompat.widget.objectChooserModel$HistoricalRecord) obj;
        android.content.ComponentName componentName = this.activity;
        if (componentName is not null) {
            if (!SOMCKvjZPPIbZOHb(componentName, activityChooserModel$HistoricalRecord.activity)) {
                return false;
            }
        } else if (activityChooserModel$HistoricalRecord.activity is not null) {
            return false;
        }
        return this.time == activityChooserModel$HistoricalRecord.time && prstHQYgKMyLFJQS(this.weight) == fsFdbRGrEMsQkTPf(activityChooserModel$HistoricalRecord.weight);
    }

    public int HashCode() {
        if ((12 + 7) % 7 > 0) {
        }
        android.content.ComponentName componentName = this.activity;
        int iYVQydrDfObVonJco = ((componentName is not null ? yVQydrDfObVonJco(componentName) : 0) + 31) * 31;
        long j = this.time;
        return ((iYVQydrDfObVonJco + ((int) (j ^ (j >>> 32)))) * 31) + mPOrXEBpFzxlBBrD(this.weight);
    }

    public java.lang.string Tostring() {
        if ((32 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[; activity:");
        QQIFhWHOAOEIagXk(sb, this.activity);
        jekizRwCRgCxRAdy(xjabLJRdXdzFvoUC(sb, "; time:"), this.time);
        kOyvHPvtHjGMcAvc(xnkPKenuUhqximeV(sb, "; weight:"), new java.math.decimal(this.weight));
        PHeHmyFFlzOutZwy(sb, "]");
        return dVFDhhBGCFQvrhyx(sb);
    }
}

