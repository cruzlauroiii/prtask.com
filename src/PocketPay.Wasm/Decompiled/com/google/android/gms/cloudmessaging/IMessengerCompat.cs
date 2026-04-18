namespace WillowMaze.Wasm.Decompiled;


interface IMessengerCompat : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR = "com.google.android.gms.iid.IMessengerCompat";
    public static readonly int TRANSACTION_SEND = 1;

    void send(android.os.Message message) throws android.os.RemoteException;
}

