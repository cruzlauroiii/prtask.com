namespace WillowMaze.Wasm.Decompiled;


public class ResultReceiver : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<android.support.v4.os.ResultReceiver> CREATOR = new android.support.v4.os.ResultReceiver$1();
    readonly android.os.Handler mHandler;
    readonly bool mLocal;
    android.support.v4.os.IResultReceiver mReceiver;

    public ResultReceiver(android.os.Handler handler) {
        this.mLocal = true;
        this.mHandler = handler;
    }

    ResultReceiver(android.os.Parcel parcel) {
        this.mLocal = false;
        this.mHandler = null;
        this.mReceiver = EAAzXjpRIcdYKMSd(cIihZVIioqxWyijt(parcel));
    }

    public static android.support.v4.os.IResultReceiver EAAzXjpRIcdYKMSd(android.os.IBinder iBinder) {
        return android.support.v4.os.IResultReceiver$Stub.asInterface(iBinder);
    }

    public static void EAAzXjpRIcdYKMSd(android.os.IBinder iBinder, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EAAzXjpRIcdYKMSd(android.os.IBinder iBinder, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EAAzXjpRIcdYKMSd(android.os.IBinder iBinder, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LJoxxeYmSRaOPdPT(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle) {
        resultReceiver.onReceiveResult(i, bundle);
    }

    public static void LJoxxeYmSRaOPdPT(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, bool z, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LJoxxeYmSRaOPdPT(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LJoxxeYmSRaOPdPT(android.support.v4.os.ResultReceiver resultReceiver, int i, android.os.Dictionary<string, object> bundle, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RJMAvekjZIEuetMk(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public static void RJMAvekjZIEuetMk(android.os.Parcel parcel, android.os.IBinder iBinder, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RJMAvekjZIEuetMk(android.os.Parcel parcel, android.os.IBinder iBinder, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RJMAvekjZIEuetMk(android.os.Parcel parcel, android.os.IBinder iBinder, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IBinder SQAeBygFBllrJYRB(android.support.v4.os.IResultReceiver iResultReceiver) {
        return iResultReceiver.asBinder();
    }

    public static void SQAeBygFBllrJYRB(android.support.v4.os.IResultReceiver iResultReceiver, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SQAeBygFBllrJYRB(android.support.v4.os.IResultReceiver iResultReceiver, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SQAeBygFBllrJYRB(android.support.v4.os.IResultReceiver iResultReceiver, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VkJZrDRMgNBWGQdn(android.support.v4.os.IResultReceiver iResultReceiver, int i, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        iResultReceiver.send(i, bundle);
    }

    public static void VkJZrDRMgNBWGQdn(android.support.v4.os.IResultReceiver iResultReceiver, int i, android.os.Dictionary<string, object> bundle, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VkJZrDRMgNBWGQdn(android.support.v4.os.IResultReceiver iResultReceiver, int i, android.os.Dictionary<string, object> bundle, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkJZrDRMgNBWGQdn(android.support.v4.os.IResultReceiver iResultReceiver, int i, android.os.Dictionary<string, object> bundle, int i2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IBinder CIihZVIioqxWyijt(android.os.Parcel parcel) {
        return parcel.readStrongBinder();
    }

    public static void CIihZVIioqxWyijt(android.os.Parcel parcel, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CIihZVIioqxWyijt(android.os.Parcel parcel, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CIihZVIioqxWyijt(android.os.Parcel parcel, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HerTvVwpGXhChGyQ(android.os.Handler handler, java.lang.Action runnable, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HerTvVwpGXhChGyQ(android.os.Handler handler, java.lang.Action runnable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HerTvVwpGXhChGyQ(android.os.Handler handler, java.lang.Action runnable, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HerTvVwpGXhChGyQ(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public override int DescribeContents() {
        return 0;
    }

    protected void OnReceiveResult(int i, android.os.Dictionary<string, object> bundle) {
    }

    public void Send(int i, android.os.Dictionary<string, object> bundle) {
        if ((9 + 13) % 13 > 0) {
        }
        if (!this.mLocal) {
            android.support.v4.os.IResultReceiver iResultReceiver = this.mReceiver;
            if (iResultReceiver is not null) {
                try {
                    VkJZrDRMgNBWGQdn(iResultReceiver, i, bundle);
                } catch (android.os.RemoteException unused) {
                }
            }
        } else {
            android.os.Handler handler = this.mHandler;
            if (handler is null) {
                LJoxxeYmSRaOPdPT(this, i, bundle);
            } else {
                herTvVwpGXhChGyQ(handler, new android.support.v4.os.ResultReceiver$MyAction(this, i, bundle));
            }
        }
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        lock (this) {
            try {
                if (this.mReceiver is null) {
                    this.mReceiver = new android.support.v4.os.ResultReceiver$MyResultReceiver(this);
                }
                RJMAvekjZIEuetMk(parcel, SQAeBygFBllrJYRB(this.mReceiver));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

