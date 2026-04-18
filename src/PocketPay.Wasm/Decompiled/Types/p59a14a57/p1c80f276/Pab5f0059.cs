namespace WillowMaze.Wasm.Decompiled;

public class Pab5f0059 : Pb0e16e3d
{
    public static string F630c49e6;
    public static string F64ede003;
    public static string F6e9d0048;
    public static string F89c4d2a4;
    public static pab5f0059$p910eef8c F910eef8c;
    public static string Fe444f739;
    public static pab5f0059$p910eef8c Febdad432;
    private List<object> F24b8a2ab;
    private List<object> F3aa73e21;
    private List<object> F4079a50f;
    private MultiFormatReader F508a5479;
    private List<object> F70a30153;
    private List<object> F8898a80a;
    private MultiFormatReader F97dd70f5;
    private List<object> F9a5244b1;
    private List<object> Faebec7f1;
    private MultiFormatReader Fb49461ff;
    private pab5f0059$p2f0e47d4 Fbf8ddea5;
    private pab5f0059$p2f0e47d4 Fbfe04437;
    private List<object> Fd59e0cc6;
    private MultiFormatReader Fe03208aa;
    private pab5f0059$p2f0e47d4 Fe7078297;
    private MultiFormatReader Ff5bf947b;

    private ICollection<object> M0134f22d()
    {
        // field: p59a14a57.p1c80f276.pab5f0059.f8898a80a
        // field: p59a14a57.p1c80f276.pab5f0059.fd59e0cc6
        return default!;
    }

    private static void M2ba1321b(pab5f0059 P0, Result P1)
    {
        // call: pab5f0059$p2f0e47d4.handleResult
        // field: p59a14a57.p1c80f276.pab5f0059.fe7078297
    }

    private PlanarYUVLuminanceSource M83f8ca88(byte[] P0, int P1, int P2)
    {
        // call: Rect.width
        // call: Rect.height
        // call: PlanarYUVLuminanceSource.<init>
        // call: pab5f0059.getFramingRectInPreview
        // call: FirebaseCrashlytics.getInstance
        // call: FirebaseCrashlytics.recordException
        // field: android.graphics.Rect.left
        // field: android.graphics.Rect.top
        // type: PlanarYUVLuminanceSource
        return default!;
    }

    private void Me4724a3a()
    {
        // call: Dictionary<string, object>.put
        // call: MultiFormatReader.setHints
        // call: pab5f0059.m0134f22d
        // call: EnumMap.<init>
        // call: MultiFormatReader.<init>
        // field: p59a14a57.p1c80f276.pab5f0059.ff5bf947b
        // field: com.google.zxing.DecodeHintType.POSSIBLE_FORMATS
        // type: DecodeHintType
        // type: EnumMap
        // type: MultiFormatReader
    }

    public static void Mf600559d(pab5f0059 P0, Result P1)
    {
        // call: pab5f0059.m2ba1321b
    }

    public void OnPreviewFrame(byte[] P0, Camera P1)
    {
        // str: "f108096cff94be2a45daed7823ce2616fd7895c2123c02f4514499f7a41390cfe4f88358608597580f00d990"
        // str: "data"
        // str: "mMultiFormatReader"
        // str: "camera"
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNullParameter
        // call: Console.e
        // call: Exception.toString
        // call: Camera.getParameters
        // call: Camera$Parameters.getPreviewSize
        // call: pab5f0059.getContext
        // call: p29726be6.m4c1bf7fa
        // call: pab5f0059.getRotationCount
        // call: pab5f0059.getRotatedData
        // call: pab5f0059.m83f8ca88
        // call: HybridBinarizer.<init>
        // call: BinaryBitmap.<init>
        // call: Intrinsics.throwUninitializedPropertyAccessException
        // call: MultiFormatReader.decodeWithState
        // call: MultiFormatReader.reset
        // call: PlanarYUVLuminanceSource.invert
        // call: pab5f0059.getHandler
        // call: pab5f0059$pd41d8cd9$p95263d50.<init>
        // call: object.post
        // field: p59a14a57.p1c80f276.pab5f0059.fe7078297
        // field: android.hardware.Camera$Size.width
        // field: android.hardware.Camera$Size.height
        // field: p59a14a57.p1c80f276.pab5f0059.ff5bf947b
        // type: BinaryBitmap
        // type: HybridBinarizer
        // type: pab5f0059$pd41d8cd9$p95263d50
    }

    public void ResumeCameraPreview(pab5f0059$p2f0e47d4 P0)
    {
        // str: "resultHandler"
        // call: pb0e16e3d.resumeCameraPreview
        // call: Intrinsics.checkNotNullParameter
        // field: p59a14a57.p1c80f276.pab5f0059.fe7078297
    }

    public void SetFormats(List<object> P0)
    {
        // call: pab5f0059.me4724a3a
        // field: p59a14a57.p1c80f276.pab5f0059.f8898a80a
    }

    public void SetResultHandler(pab5f0059$p2f0e47d4 P0)
    {
        // str: "resultHandler"
        // call: Intrinsics.checkNotNullParameter
        // field: p59a14a57.p1c80f276.pab5f0059.fe7078297
    }

}
