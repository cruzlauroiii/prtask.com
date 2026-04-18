namespace WillowMaze.Wasm.Decompiled;


public class Transaction {
    public bool activeInterface;
    public java.lang.string amount;
    public java.lang.string cvm;
    public bool eligibleContact;
    public bool eligibleContactless;
    public bool eligibleQR;
    public com.visa.vac.tc.emvconverter.EmvReader emvReader;
    public java.lang.string errorCode;
    public java.lang.string finalStatus;
    public java.lang.string receipt;
    public java.util.HashDictionary<java.lang.string, byte[]> resultTlv;
    public java.lang.string transactionDisplay;
    public java.lang.string transactionId;
    public int transactionInterface;
    public java.lang.string transactionSequenceCounter;
    public java.lang.string transactionType;
    public bool useReader;

    public Transaction() {
        if (this.resultTlv is not null) {
            return;
        }
        this.resultTlv = new java.util.HashDictionary<>();
    }
}

