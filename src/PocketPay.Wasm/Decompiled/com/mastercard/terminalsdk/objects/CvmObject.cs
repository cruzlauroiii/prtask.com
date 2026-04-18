namespace WillowMaze.Wasm.Decompiled;


public abstract class Cvmobject {

    private com.mastercard.terminalsdk.objects.CvmType f530e;

    public Cvmobject(com.mastercard.terminalsdk.objects.CvmType cvmType) {
        this.f530e = cvmType;
    }

    public com.mastercard.terminalsdk.objects.CvmType GetCvmType() {
        return this.f530e;
    }

    public abstract java.lang.string GetPin();

    public abstract com.mastercard.terminalsdk.utility.PINUtility$PINFormat getPinFormat();
}

