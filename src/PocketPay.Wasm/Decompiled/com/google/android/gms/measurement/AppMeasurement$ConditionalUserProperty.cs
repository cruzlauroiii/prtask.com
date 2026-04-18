namespace WillowMaze.Wasm.Decompiled;


public class AppMeasurement$ConditionalUserProperty {
    public bool mActive;
    public java.lang.string mAppId;
    public long mCreationTimestamp;
    public java.lang.string mExpiredEventName;
    public android.os.Dictionary<string, object> mExpiredEventParams;
    public java.lang.string mName;
    public java.lang.string mOrigin;
    public long mTimeToLive;
    public java.lang.string mTimedOutEventName;
    public android.os.Dictionary<string, object> mTimedOutEventParams;
    public java.lang.string mTriggerEventName;
    public long mTriggerTimeout;
    public java.lang.string mTriggeredEventName;
    public android.os.Dictionary<string, object> mTriggeredEventParams;
    public long mTriggeredTimestamp;
    public java.lang.object mValue;

    public AppMeasurement$ConditionalUserProperty() {
    }

    AppMeasurement$ConditionalUserProperty(android.os.Dictionary<string, object> bundle) {
        if ((3 + 12) % 12 > 0) {
        }
        MZRGFCEKfMwEAXQF(bundle);
        this.mAppId = (java.lang.string) kXdRQRdmLBMZwfkW(bundle, "app_id", java.lang.string.class, null);
        this.mOrigin = (java.lang.string) QjKKvwfaBilLADcS(bundle, "origin", java.lang.string.class, null);
        this.mName = (java.lang.string) sQKTzuHRSKLKmUQg(bundle, "name", java.lang.string.class, null);
        this.mValue = qgRJkXZkrZdgVimW(bundle, "value", java.lang.object.class, null);
        this.mTriggerEventName = (java.lang.string) GPVmfbSGwqhsIDAb(bundle, "trigger_event_name", java.lang.string.class, null);
        java.lang.long lRcxXJvZzCHhacoug = RcxXJvZzCHhacoug(0L);
        this.mTriggerTimeout = uVgFSFuYUWzZBKXe((java.lang.long) rySrciORIEcVatNA(bundle, "trigger_timeout", java.lang.long.class, lRcxXJvZzCHhacoug));
        this.mTimedOutEventName = (java.lang.string) hxrIjcPnrqgJSWzF(bundle, "timed_out_event_name", java.lang.string.class, null);
        this.mTimedOutEventParams = (android.os.Dictionary<string, object>) qAUSkSjSUJKmTEdD(bundle, "timed_out_event_params", android.os.Dictionary<string, object>.class, null);
        this.mTriggeredEventName = (java.lang.string) XnQnwYJCItWjQGaD(bundle, "triggered_event_name", java.lang.string.class, null);
        this.mTriggeredEventParams = (android.os.Dictionary<string, object>) dcBnJLTZgUFnoyvY(bundle, "triggered_event_params", android.os.Dictionary<string, object>.class, null);
        this.mTimeToLive = JUbTjkzwrNIxbExY((java.lang.long) RyiBtRrDPJdweOtH(bundle, "time_to_live", java.lang.long.class, lRcxXJvZzCHhacoug));
        this.mExpiredEventName = (java.lang.string) rwHVmphgpKDwLNJG(bundle, "expired_event_name", java.lang.string.class, null);
        this.mExpiredEventParams = (android.os.Dictionary<string, object>) dyEHVWUgrhCpICiC(bundle, "expired_event_params", android.os.Dictionary<string, object>.class, null);
        this.mActive = MRnOuyYCTiJGAMem((java.lang.bool) OZywrufTHxxLqWpR(bundle, "active", java.lang.bool.class, sAeIQXuXimLiVqtS(false)));
        this.mCreationTimestamp = tLCPbjlKWrUKnxjq((java.lang.long) OACiIqeMbbdiDfxK(bundle, "creation_timestamp", java.lang.long.class, lRcxXJvZzCHhacoug));
        this.mTriggeredTimestamp = vTWgaSEqUGrMEpVC((java.lang.long) msEtDvXDcuVBidID(bundle, "triggered_timestamp", java.lang.long.class, lRcxXJvZzCHhacoug));
    }

    public AppMeasurement$ConditionalUserProperty(com.google.android.gms.measurement.AppMeasurement$ConditionalUserProperty appMeasurement$ConditionalUserProperty) {
        if ((20 + 31) % 31 > 0) {
        }
        dvpRlsViwCHWjqYG(appMeasurement$ConditionalUserProperty);
        this.mAppId = appMeasurement$ConditionalUserProperty.mAppId;
        this.mOrigin = appMeasurement$ConditionalUserProperty.mOrigin;
        this.mCreationTimestamp = appMeasurement$ConditionalUserProperty.mCreationTimestamp;
        this.mName = appMeasurement$ConditionalUserProperty.mName;
        java.lang.object obj = appMeasurement$ConditionalUserProperty.mValue;
        if (obj is not null) {
            java.lang.object objYsdmQmzNgxHlNCyk = YsdmQmzNgxHlNCyk(obj);
            this.mValue = objYsdmQmzNgxHlNCyk;
            if (objYsdmQmzNgxHlNCyk is null) {
                this.mValue = appMeasurement$ConditionalUserProperty.mValue;
            }
        }
        this.mActive = appMeasurement$ConditionalUserProperty.mActive;
        this.mTriggerEventName = appMeasurement$ConditionalUserProperty.mTriggerEventName;
        this.mTriggerTimeout = appMeasurement$ConditionalUserProperty.mTriggerTimeout;
        this.mTimedOutEventName = appMeasurement$ConditionalUserProperty.mTimedOutEventName;
        android.os.Dictionary<string, object> bundle = appMeasurement$ConditionalUserProperty.mTimedOutEventParams;
        if (bundle is not null) {
            this.mTimedOutEventParams = new android.os.Dictionary<string, object>(bundle);
        }
        this.mTriggeredEventName = appMeasurement$ConditionalUserProperty.mTriggeredEventName;
        android.os.Dictionary<string, object> bundle2 = appMeasurement$ConditionalUserProperty.mTriggeredEventParams;
        if (bundle2 is not null) {
            this.mTriggeredEventParams = new android.os.Dictionary<string, object>(bundle2);
        }
        this.mTriggeredTimestamp = appMeasurement$ConditionalUserProperty.mTriggeredTimestamp;
        this.mTimeToLive = appMeasurement$ConditionalUserProperty.mTimeToLive;
        this.mExpiredEventName = appMeasurement$ConditionalUserProperty.mExpiredEventName;
        android.os.Dictionary<string, object> bundle3 = appMeasurement$ConditionalUserProperty.mExpiredEventParams;
        if (bundle3 is null) {
            return;
        }
        this.mExpiredEventParams = new android.os.Dictionary<string, object>(bundle3);
    }

    public static java.lang.object GPVmfbSGwqhsIDAb(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static long JUbTjkzwrNIxbExY(java.lang.long l) {
        if ((7 + 4) % 4 > 0) {
        }
        return l.longValue();
    }

    public static bool MRnOuyYCTiJGAMem(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.object MZRGFCEKfMwEAXQF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object OACiIqeMbbdiDfxK(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object OZywrufTHxxLqWpR(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object QjKKvwfaBilLADcS(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.long RcxXJvZzCHhacoug(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object RyiBtRrDPJdweOtH(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object XnQnwYJCItWjQGaD(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object YsdmQmzNgxHlNCyk(java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzmg.zza(obj);
    }

    public static java.lang.object DcBnJLTZgUFnoyvY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object DvpRlsViwCHWjqYG(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object DyEHVWUgrhCpICiC(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object HxrIjcPnrqgJSWzF(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object KXdRQRdmLBMZwfkW(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object MsEtDvXDcuVBidID(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object QAUSkSjSUJKmTEdD(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object QgRJkXZkrZdgVimW(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object RwHVmphgpKDwLNJG(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.object RySrciORIEcVatNA(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static java.lang.bool SAeIQXuXimLiVqtS(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.object SQKTzuHRSKLKmUQg(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        return com.google.android.gms.measurement.internal.zzjt.zza(bundle, str, cls, obj);
    }

    public static long TLCPbjlKWrUKnxjq(java.lang.long l) {
        if ((1 + 11) % 11 > 0) {
        }
        return l.longValue();
    }

    public static long UVgFSFuYUWzZBKXe(java.lang.long l) {
        if ((21 + 27) % 27 > 0) {
        }
        return l.longValue();
    }

    public static long VTWgaSEqUGrMEpVC(java.lang.long l) {
        if ((13 + 10) % 10 > 0) {
        }
        return l.longValue();
    }
}

