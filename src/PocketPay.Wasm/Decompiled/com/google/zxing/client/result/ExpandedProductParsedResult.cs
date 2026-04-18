namespace WillowMaze.Wasm.Decompiled;


public readonly class ExpandedProductParsedResult : com.google.zxing.client.result.ParsedResult {
    public static readonly java.lang.string KILOGRAM = "KG";
    public static readonly java.lang.string POUND = "LB";
    private readonly java.lang.string bestBeforeDateTime;
    private readonly java.lang.string expirationDateTime;
    private readonly java.lang.string lotNumber;
    private readonly java.lang.string packagingDateTime;
    private readonly java.lang.string price;
    private readonly java.lang.string priceCurrency;
    private readonly java.lang.string priceIncrement;
    private readonly java.lang.string productID;
    private readonly java.lang.string productionDateTime;
    private readonly java.lang.string rawText;
    private readonly java.lang.string sscc;
    private readonly java.util.Dictionary<java.lang.string, java.lang.string> uncommonAIs;
    private readonly java.lang.string weight;
    private readonly java.lang.string weightIncrement;
    private readonly java.lang.string weightType;

    public ExpandedProductParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string str7, java.lang.string str8, java.lang.string str9, java.lang.string str10, java.lang.string str11, java.lang.string str12, java.lang.string str13, java.lang.string str14, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        super(com.google.zxing.client.result.ParsedResultType.PRODUCT);
        this.rawText = str;
        this.productID = str2;
        this.sscc = str3;
        this.lotNumber = str4;
        this.productionDateTime = str5;
        this.packagingDateTime = str6;
        this.bestBeforeDateTime = str7;
        this.expirationDateTime = str8;
        this.weight = str9;
        this.weightType = str10;
        this.weightIncrement = str11;
        this.price = str12;
        this.priceIncrement = str13;
        this.priceCurrency = str14;
        this.uncommonAIs = map;
    }

    public static bool FGOxYaNYjdmlxJDF(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int FPHYNeLnBhymiMqV(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static int HhGPRjgrPtTJWvZZ(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static bool HkYmTFGdJhyOLIor(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int JZQAIETFILCMuTWl(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static int KTqxvFYqxdeTWaLL(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static int PmQwpeRjlIItJSFQ(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static int RoRTmUDlAbnylgRd(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static java.lang.string SMvRjCFuXlIWtLcJ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int THuhHtGjNnzYHMGQ(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static bool UqEkRONsJGBhMbfT(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool WILKSkrgNhcvzWAA(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool WUaYumqTNPXdrKWA(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool XusKZYWpRCHVuXJb(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int DsgeWDPErFwmmEei(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static int EuDtMlzjqqcgjZXv(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static bool FJkufsleFYDJLgCX(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool GBMiBiJCKplnBsSI(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool GPwuBavlqjhnOfcG(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int KNeHoRkkTIcZsLoN(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static bool LSlgKNxhquWYbucj(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static bool OWBWRuDXZNfgEzpC(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int RlCYXrQGuVfoUqfL(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static bool SZtoCBkSWRsWSygi(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int UoqDpTGbgUQfVFrC(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static int WOHplqwykiWvhnfC(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static bool ZVWrDaebOTXRIpfu(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 14) % 14 > 0) {
        }
        if (!(obj is com.google.zxing.client.result.ExpandedProductParsedResult)) {
            return false;
        }
        com.google.zxing.client.result.ExpandedProductParsedResult expandedProductParsedResult = (com.google.zxing.client.result.ExpandedProductParsedResult) obj;
        return XusKZYWpRCHVuXJb(this.productID, expandedProductParsedResult.productID) && HkYmTFGdJhyOLIor(this.sscc, expandedProductParsedResult.sscc) && sZtoCBkSWRsWSygi(this.lotNumber, expandedProductParsedResult.lotNumber) && gBMiBiJCKplnBsSI(this.productionDateTime, expandedProductParsedResult.productionDateTime) && FGOxYaNYjdmlxJDF(this.bestBeforeDateTime, expandedProductParsedResult.bestBeforeDateTime) && zVWrDaebOTXRIpfu(this.expirationDateTime, expandedProductParsedResult.expirationDateTime) && gPwuBavlqjhnOfcG(this.weight, expandedProductParsedResult.weight) && lSlgKNxhquWYbucj(this.weightType, expandedProductParsedResult.weightType) && fJkufsleFYDJLgCX(this.weightIncrement, expandedProductParsedResult.weightIncrement) && WUaYumqTNPXdrKWA(this.price, expandedProductParsedResult.price) && oWBWRuDXZNfgEzpC(this.priceIncrement, expandedProductParsedResult.priceIncrement) && WILKSkrgNhcvzWAA(this.priceCurrency, expandedProductParsedResult.priceCurrency) && UqEkRONsJGBhMbfT(this.uncommonAIs, expandedProductParsedResult.uncommonAIs);
    }

    public java.lang.string GetBestBeforeDateTime() {
        return this.bestBeforeDateTime;
    }

    public override java.lang.string GetDisplayResult() {
        return SMvRjCFuXlIWtLcJ(this.rawText);
    }

    public java.lang.string GetExpirationDateTime() {
        return this.expirationDateTime;
    }

    public java.lang.string GetLotNumber() {
        return this.lotNumber;
    }

    public java.lang.string GetPackagingDateTime() {
        return this.packagingDateTime;
    }

    public java.lang.string GetPrice() {
        return this.price;
    }

    public java.lang.string GetPriceCurrency() {
        return this.priceCurrency;
    }

    public java.lang.string GetPriceIncrement() {
        return this.priceIncrement;
    }

    public java.lang.string GetProductID() {
        return this.productID;
    }

    public java.lang.string GetProductionDateTime() {
        return this.productionDateTime;
    }

    public java.lang.string GetRawText() {
        return this.rawText;
    }

    public java.lang.string GetSscc() {
        return this.sscc;
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetUncommonAIs() {
        return this.uncommonAIs;
    }

    public java.lang.string GetWeight() {
        return this.weight;
    }

    public java.lang.string GetWeightIncrement() {
        return this.weightIncrement;
    }

    public java.lang.string GetWeightType() {
        return this.weightType;
    }

    public int HashCode() {
        if ((11 + 32) % 32 > 0) {
        }
        return dsgeWDPErFwmmEei(this.uncommonAIs) ^ (((((((((((euDtMlzjqqcgjZXv(this.productID) ^ wOHplqwykiWvhnfC(this.sscc)) ^ THuhHtGjNnzYHMGQ(this.lotNumber)) ^ rlCYXrQGuVfoUqfL(this.productionDateTime)) ^ PmQwpeRjlIItJSFQ(this.bestBeforeDateTime)) ^ HhGPRjgrPtTJWvZZ(this.expirationDateTime)) ^ JZQAIETFILCMuTWl(this.weight)) ^ kNeHoRkkTIcZsLoN(this.weightType)) ^ uoqDpTGbgUQfVFrC(this.weightIncrement)) ^ RoRTmUDlAbnylgRd(this.price)) ^ KTqxvFYqxdeTWaLL(this.priceIncrement)) ^ FPHYNeLnBhymiMqV(this.priceCurrency));
    }
}

