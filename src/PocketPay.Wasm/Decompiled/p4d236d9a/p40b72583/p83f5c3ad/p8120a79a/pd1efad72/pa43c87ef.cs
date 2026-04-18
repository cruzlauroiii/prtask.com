namespace WillowMaze.Wasm.Decompiled;


public class pa43c87ef : p4d236d9a.p40b72583.p0435bc88.p8120a79a.p9f0bb99f {
    private static readonly int f112af041 = 50;
    private static readonly int f721f7f36 = 50;
    private static readonly int f7b9a4187 = 50;
    private static readonly int f829c3c6f = 50;
    private static readonly int fd164c985 = 50;
    private bool f0356f4fd;
    private readonly android.os.Vibrator f0998624c;
    private readonly android.view.LayoutInflater f0ae7f9d1;
    private bool f100e2e3f;
    private int f153c4b99;
    private readonly android.view.LayoutInflater f27509d50;
    private int f2fa4f425;
    private int f31117203;
    private readonly android.os.Vibrator f3cb73423;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 f41ef3aed;
    private p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 f464956da;
    private readonly java.util.List f4cd76ab1;
    private readonly java.util.List f52df2737;
    private int f5677e410;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 f5fd767fc;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 f68bb97d6;
    private int f71215592;
    private readonly java.util.List f7196fbee;
    private readonly bool f77bb7ab9;
    private int f787ee01b;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 f7c18c8bd;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 f7e112629;
    private int f886e0d6f;
    private readonly bool f95970a55;
    private readonly java.util.List fa1387eec;
    private readonly java.util.List fa9521f34;
    private bool fad8d29c3;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 fb1e0c036;
    private readonly bool fb2888405;
    private bool fb2d1c6f2;
    private int fb435e227;
    private p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 fbe7dcc75;
    private readonly bool fbee13c13;
    private int fc1ad8328;
    private readonly android.view.LayoutInflater fc4c2586b;
    private int fc64c270b;
    private readonly bool fcce460d5;
    private readonly bool fcd8ea749;
    private int fd362fd89;
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 fe2bde32f;
    private readonly bool fe8db1aaf;
    private readonly bool fe9ff9220;
    private int feaae26a6;
    private readonly android.os.Vibrator feff1c2ad;
    private readonly java.util.List ff31ef499;
    private readonly java.util.List ff77a3133;
    private int ffb956220;
    private bool fffc67194;
    private readonly java.util.List<p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e> f0f94e356 = new java.util.List<>();
    private readonly p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 ff1c7b7a1 = new p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705();
    private readonly java.util.List<byte[]> f7a58f750 = new java.util.List<>();

    public pa43c87ef(android.content.object context, p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var, bool z, bool z2) {
        this.f0ae7f9d1 = (android.view.LayoutInflater) dqNpwuzhOnByEZda(context, "layout_inflater");
        this.fb1e0c036 = pb5ef1632Var;
        this.fcce460d5 = z;
        this.f77bb7ab9 = z2;
        this.f0998624c = (android.os.Vibrator) ZgASIfiFLUolFNLB(context, "vibrator");
    }

    public static void AjDUuCdbuQxRDIXU(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar, p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35[] p963ccf35VarArr) {
        pa43c87efVar.m0e22ac9c(p963ccf35VarArr);
    }

    public static android.graphics.Bitmap AvMfvBuiBSOSQyIS(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static android.view.object BbHnuqSgudlqhozy(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static void CTkgphniFrbCwvpn(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 p719e8491Var) {
        p719e8491Var.onPinPadReadyToGenerate();
    }

    public static int DbxCtjIAFnYqmtQA(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool DlgroUGjTjsRKpqT(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void EOlwjdmqdlalcLtw(android.os.Vibrator vibrator, long j) {
        vibrator.vibrate(j);
    }

    public static void GaCCoyUrxoNgrCIh(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar) {
        pa43c87efVar.m6fd9f244();
    }

    public static p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 HUjDhoSwHoqapAbE(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e pecc9832eVar) {
        return pecc9832eVar.getPinEntity();
    }

    public static int JcdjmfncEXPGriCf(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void KeCIpklCeUYyxgay(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void KjfresGJxksalUqR(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar) {
        pa43c87efVar.maff81f96();
    }

    public static p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35[] LyhlFDZawLhEtDjO(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 p2faee705Var) {
        return p2faee705Var.generatePinButtons();
    }

    public static void OLfoIlgBBAndjTKD(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar) {
        pa43c87efVar.maff81f96();
    }

    public static int ObpMKqYHCbxqtndE(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.view.object OfWAQcshIWSFZzZw(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static void OxbrCMPoUUbfFGbc(android.widget.LinearLayout linearLayout, int i, int i2, int i3, int i4) {
        linearLayout.layout(i, i2, i3, i4);
    }

    public static bool QnVcIrITuGsmAdpv(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e pecc9832eVar, int i, int i2) {
        return pecc9832eVar.checkClickButton(i, i2);
    }

    public static bool TOTgFriBFLVipYKU(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35[] UPaVcryktvRKvLCq(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 p2faee705Var, byte[] bArr, bool z) {
        return p2faee705Var.generatePinButtons(bArr, z);
    }

    public static bool UWCWeZmhxDbkTuPJ(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void VIiNOSCpLPxybiMY(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var) {
        pb5ef1632Var.onPinobjectProcessPrepare();
    }

    public static java.lang.object YkhRynHmSnPsRIMR(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZGGggZZSTdPTFbIE(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var, bool z) {
        pb5ef1632Var.onPinobjectProcessPressed(z);
    }

    public static java.lang.object ZgASIfiFLUolFNLB(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void ZrXuvRmWFZoLiETq(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar, p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35[] p963ccf35VarArr) {
        pa43c87efVar.m0e22ac9c(p963ccf35VarArr);
    }

    public static void AfgSCDfkXPXYMSWp(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 p719e8491Var) {
        p719e8491Var.onPinPadCancelButton();
    }

    public static void AkOjLMqMTwsWVKzi(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var, android.graphics.Bitmap bitmap) {
        pb5ef1632Var.onPinobjectProcessImageBitmap(bitmap);
    }

    public static p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e BAxLAGCbpZSvdIRu(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe644b7fe pe644b7feVar) {
        return pe644b7feVar.getobjectInfo();
    }

    public static bool BDElySQlgoeuOutX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator BSvxbdJfZgfVaDQc(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void BoGiDnDPlVHUBbKO(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe3c02a70 pe3c02a70Var, int i) {
        pe3c02a70Var.setBullets(i);
    }

    public static void DEoLbXiYWDsxtqZs(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var) {
        pb5ef1632Var.onPinobjectProcessDone();
    }

    public static java.lang.object DqNpwuzhOnByEZda(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void HVQRridDpLHkfoNZ(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 p719e8491Var, int i) {
        p719e8491Var.onPinPadProgress(i);
    }

    public static java.lang.object INERlfCBFGtUtPVk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object[] IohUuDTmVdNYTcwa(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static void JPgdQPsfJpgTJtPW(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas) {
        linearLayout.draw(canvas);
    }

    public static void KxOEjIRPtbTuUlaA(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar) {
        pa43c87efVar.me64416da();
    }

    public static bool LKXWQECohDZzNNJw(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    private void M0e22ac9c(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35[] p963ccf35VarArr) {
        if ((6 + 26) % 26 > 0) {
        }
        if (this.feaae26a6 > 0 && this.fb435e227 > 0) {
            qATyaESYKHsOdmJN(this.f0f94e356);
            android.widget.LinearLayout linearLayout = (android.widget.LinearLayout) xodOjqlcBroupwvD(this.f0ae7f9d1, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$layout.toph_pinpad_layout_container, null);
            p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.p5f0b6ebc.pe96c5b79 pe96c5b79Var = (p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.p5f0b6ebc.pe96c5b79) OfWAQcshIWSFZzZw(linearLayout, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$id.tophPadContainer);
            java.util.List arrayList = new java.util.List();
            for (p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35 p963ccf35Var : p963ccf35VarArr) {
                TOTgFriBFLVipYKU(arrayList, qNcwDyWMGUOlzNCc(p963ccf35Var, this.f0ae7f9d1, pe96c5b79Var));
            }
            boGiDnDPlVHUBbKO((p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe3c02a70) BbHnuqSgudlqhozy(linearLayout, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$id.tophPadBullets), JcdjmfncEXPGriCf(this.f7a58f750));
            hVQRridDpLHkfoNZ(this.fbe7dcc75, DbxCtjIAFnYqmtQA(this.f7a58f750));
            oAeEUFfPdYWFbvNG(linearLayout, ObpMKqYHCbxqtndE(this.feaae26a6, 1073741824), yEsReORmJhDKhksa(this.fb435e227, 1073741824));
            OxbrCMPoUUbfFGbc(linearLayout, 0, 0, this.feaae26a6, this.fb435e227);
            java.util.IEnumerator itYtTCmczFLyeEQjgd = ytTCmczFLyeEQjgd(arrayList);
            while (bDElySQlgoeuOutX(itYtTCmczFLyeEQjgd)) {
                UWCWeZmhxDbkTuPJ(this.f0f94e356, ndoMzkZYXbnybhjc(bAxLAGCbpZSvdIRu((p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe644b7fe) iNERlfCBFGtUtPVk(itYtTCmczFLyeEQjgd)), scvoooCDSxZfJLEJ(pe96c5b79Var) + this.f153c4b99));
            }
            android.graphics.Bitmap bitmapAvMfvBuiBSOSQyIS = AvMfvBuiBSOSQyIS(this.feaae26a6, this.fb435e227, android.graphics.Bitmap$Config.ARGB_8888);
            jPgdQPsfJpgTJtPW(linearLayout, new android.graphics.Canvas(bitmapAvMfvBuiBSOSQyIS));
            p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var = this.fb1e0c036;
            if (pb5ef1632Var is null) {
                return;
            }
            akOjLMqMTwsWVKzi(pb5ef1632Var, bitmapAvMfvBuiBSOSQyIS);
        }
    }

    private void M6fd9f244() {
        p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var = this.fb1e0c036;
        if (pb5ef1632Var is null) {
            return;
        }
        dEoLbXiYWDsxtqZs(pb5ef1632Var);
    }

    private void Maff81f96() {
        p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var = this.fb1e0c036;
        if (pb5ef1632Var is null) {
            return;
        }
        ZGGggZZSTdPTFbIE(pb5ef1632Var, this.f100e2e3f);
    }

    private void Me64416da() {
        p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var = this.fb1e0c036;
        if (pb5ef1632Var is null) {
            return;
        }
        VIiNOSCpLPxybiMY(pb5ef1632Var);
    }

    public static byte[] NYyOfSnmPGstJXdR(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e pecc9832eVar) {
        return pecc9832eVar.getKey();
    }

    public static int NZuFOLRdEjlkwmCs(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p1b22e7dc$p7142c551 p1b22e7dc_p7142c551) {
        return p1b22e7dc_p7142c551.ordinal();
    }

    public static p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e NdoMzkZYXbnybhjc(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e pecc9832eVar, int i) {
        return pecc9832eVar.calc(i);
    }

    public static void OAeEUFfPdYWFbvNG(android.widget.LinearLayout linearLayout, int i, int i2) {
        linearLayout.measure(i, i2);
    }

    public static void OBWYKmxdIYxXlheC(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 p719e8491Var) {
        p719e8491Var.onPinPadReadyToGenerate();
    }

    public static void PqQOZmgrUmnDPSbS(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void QATyaESYKHsOdmJN(java.util.List arrayList) {
        arrayList.clear();
    }

    public static p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pe644b7fe QNcwDyWMGUOlzNCc(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p96b798a2.p593616de.p963ccf35 p963ccf35Var, android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup) {
        return p963ccf35Var.inflate(layoutInflater, viewGroup);
    }

    public static void QzyGsmktjINckCDu(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var, java.lang.string str) {
        pb5ef1632Var.onPinobjectProcessError(str);
    }

    public static void RRsxxtYnVZpfkabF(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef pa43c87efVar) {
        pa43c87efVar.me64416da();
    }

    public static int ScvoooCDSxZfJLEJ(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.p5f0b6ebc.pe96c5b79 pe96c5b79Var) {
        return pe96c5b79Var.getTop();
    }

    public static p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2b3583e6.p9e9719ee SdQimgMsBmxNZlHU(p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2faee705 p2faee705Var) {
        return p2faee705Var.getSP800SecureRandomGenerator();
    }

    public static void ULfpyXsawydtmhzq(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 p719e8491Var, p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p2b3583e6.p9e9719ee p9e9719eeVar, byte[][] bArr) {
        p719e8491Var.onPinPadOkButton(p9e9719eeVar, bArr);
    }

    public static android.view.object XodOjqlcBroupwvD(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static int YEsReORmJhDKhksa(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static java.util.IEnumerator YtTCmczFLyeEQjgd(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public override void ConfirmPin() {
        if ((4 + 23) % 23 > 0) {
        }
        this.f100e2e3f = true;
        uLfpyXsawydtmhzq(this.fbe7dcc75, sdQimgMsBmxNZlHU(this.ff1c7b7a1), (byte[][]) iohUuDTmVdNYTcwa(this.f7a58f750, new byte[0][]));
        pqQOZmgrUmnDPSbS(this.f7a58f750);
        GaCCoyUrxoNgrCIh(this);
    }

    public override void GeneratePinPad(byte[] bArr) {
        if ((1 + 19) % 19 > 0) {
        }
        KeCIpklCeUYyxgay(this.f7a58f750);
        this.f100e2e3f = false;
        ZrXuvRmWFZoLiETq(this, UPaVcryktvRKvLCq(this.ff1c7b7a1, bArr, this.f77bb7ab9));
        OLfoIlgBBAndjTKD(this);
    }

    public void OnPinobjectClick(int i, int i2) {
        if ((11 + 6) % 6 > 0) {
        }
        if (this.f100e2e3f) {
            return;
        }
        java.util.IEnumerator itBSvxbdJfZgfVaDQc = bSvxbdJfZgfVaDQc(this.f0f94e356);
        while (lKXWQECohDZzNNJw(itBSvxbdJfZgfVaDQc)) {
            p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e pecc9832eVar = (p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.p59a14a57.pecc9832e) YkhRynHmSnPsRIMR(itBSvxbdJfZgfVaDQc);
            if (QnVcIrITuGsmAdpv(pecc9832eVar, i, i2) && this.fbe7dcc75 is not null) {
                KjfresGJxksalUqR(this);
                if (this.fcce460d5) {
                    EOlwjdmqdlalcLtw(this.f0998624c, 50L);
                }
                switch (p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pa43c87ef$1.$SwitchDictionary$com$psr$toph$pinpad$internal$Enums$PinEntity[nZuFOLRdEjlkwmCs(HUjDhoSwHoqapAbE(pecc9832eVar))]) {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        DlgroUGjTjsRKpqT(this.f7a58f750, nYyOfSnmPGstJXdR(pecc9832eVar));
                        AjDUuCdbuQxRDIXU(this, LyhlFDZawLhEtDjO(this.ff1c7b7a1));
                        break;
                    case 11:
                        this.f100e2e3f = true;
                        afgSCDfkXPXYMSWp(this.fbe7dcc75);
                        break;
                    case 12:
                        this.f100e2e3f = true;
                        rRsxxtYnVZpfkabF(this);
                        oBWYKmxdIYxXlheC(this.fbe7dcc75);
                        break;
                }
                return;
            }
        }
    }

    public void OnPinobjectReady(int i, int i2, int i3) {
        this.feaae26a6 = i;
        this.f153c4b99 = i3;
        this.fb435e227 = i2 - i3;
        kxOEjIRPtbTuUlaA(this);
        p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 p719e8491Var = this.fbe7dcc75;
        if (p719e8491Var is null) {
            return;
        }
        CTkgphniFrbCwvpn(p719e8491Var);
    }

    public override void SetErrorInput(java.lang.string str) {
        p4d236d9a.p40b72583.p83f5c3ad.p8120a79a.pd1efad72.pb5ef1632 pb5ef1632Var = this.fb1e0c036;
        if (pb5ef1632Var is null) {
            return;
        }
        qzyGsmktjINckCDu(pb5ef1632Var, str);
    }

    public override void SetOnPinPadActionListener(p4d236d9a.p40b72583.p0435bc88.p8120a79a.p719e8491 p719e8491Var) {
        this.fbe7dcc75 = p719e8491Var;
    }
}

