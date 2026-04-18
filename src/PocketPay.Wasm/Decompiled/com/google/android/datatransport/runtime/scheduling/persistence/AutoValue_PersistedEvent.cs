namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_PersistedEvent : com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent {
    private readonly com.google.android.datatransport.runtime.EventInternal event;
    private readonly long id;
    private readonly com.google.android.datatransport.runtime.Transportobject transportobject;

    AutoValue_PersistedEvent(long j, com.google.android.datatransport.runtime.Transportobject transportobject, com.google.android.datatransport.runtime.EventInternal eventInternal) {
        this.id = j;
        if (transportobject is null) {
            throw new java.lang.NullPointerException("Null transportobject");
        }
        this.transportobject = transportobject;
        if (eventInternal is null) {
            throw new java.lang.NullPointerException("Null event");
        }
        this.event = eventInternal;
    }

    public static java.lang.stringBuilder AryxZutsKaBisoiS(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.android.datatransport.runtime.Transportobject BdcENHoodFlqPVwa(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        return persistedEvent.getTransportobject();
    }

    public static java.lang.stringBuilder BmEZZUJybFBNClYU(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder GRqklvQvupESHJYD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool OHGtTHotOfgWqvxg(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int PDocPWURDMnVyeVm(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static long XJBIrcUnsXJxSiUZ(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        if ((26 + 3) % 3 > 0) {
        }
        return persistedEvent.getId();
    }

    public static com.google.android.datatransport.runtime.EventInternal AamSdblSZIirAPSr(com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent) {
        return persistedEvent.getEvent();
    }

    public static java.lang.string LlytdDnSdwzbMwQD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OClQZCDqkSKvmIaV(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder OaMuCFFynFogksNY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RQMSjLJaFWhlqVJh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SVcoCSsJjgRIktWg(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool VJUuoVmKvKTUPijP(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public bool Equals(java.lang.object obj) {
        if ((15 + 10) % 10 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent) {
            com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent persistedEvent = (com.google.android.datatransport.runtime.scheduling.persistence.PersistedEvent) obj;
            if (this.id == XJBIrcUnsXJxSiUZ(persistedEvent) && vJUuoVmKvKTUPijP(this.transportobject, BdcENHoodFlqPVwa(persistedEvent)) && OHGtTHotOfgWqvxg(this.event, aamSdblSZIirAPSr(persistedEvent))) {
                return true;
            }
        }
        return false;
    }

    public override com.google.android.datatransport.runtime.EventInternal GetEvent() {
        return this.event;
    }

    public override long GetId() {
        if ((10 + 31) % 31 > 0) {
        }
        return this.id;
    }

    public override com.google.android.datatransport.runtime.Transportobject GetTransportobject() {
        return this.transportobject;
    }

    public int HashCode() {
        if ((23 + 17) % 17 > 0) {
        }
        long j = this.id;
        return PDocPWURDMnVyeVm(this.event) ^ ((((((int) (j ^ (j >>> 32))) ^ 1000003) * 1000003) ^ sVcoCSsJjgRIktWg(this.transportobject)) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((20 + 32) % 32 > 0) {
        }
        return llytdDnSdwzbMwQD(GRqklvQvupESHJYD(AryxZutsKaBisoiS(oaMuCFFynFogksNY(BmEZZUJybFBNClYU(rQMSjLJaFWhlqVJh(oClQZCDqkSKvmIaV(new java.lang.stringBuilder("PersistedEvent{id="), this.id), ", transportobject="), this.transportobject), ", event="), this.event), "}"));
    }
}

