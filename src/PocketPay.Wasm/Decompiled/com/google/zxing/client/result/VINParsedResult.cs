namespace WillowMaze.Wasm.Decompiled;


public readonly class VINParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string countryCode;
    private readonly int modelYear;
    private readonly char plantCode;
    private readonly java.lang.string sequentialNumber;
    private readonly java.lang.string vehicleAttributes;
    private readonly java.lang.string vehicleDescriptorSection;
    private readonly java.lang.string vehicleIdentifierSection;
    private readonly java.lang.string vin;
    private readonly java.lang.string worldManufacturerID;

    public VINParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, int i, char c, java.lang.string str7) {
        super(com.google.zxing.client.result.ParsedResultType.VIN);
        this.vin = str;
        this.worldManufacturerID = str2;
        this.vehicleDescriptorSection = str3;
        this.vehicleIdentifierSection = str4;
        this.countryCode = str5;
        this.vehicleAttributes = str6;
        this.modelYear = i;
        this.plantCode = c;
        this.sequentialNumber = str7;
    }

    public static java.lang.stringBuilder ACAjGPmsBABIqGJD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string BjPZkbsjUSOITPyl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder HZfHajRbBlpxwhJF(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder HahPwhNvkqVlyOWe(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder IqzgRHAhMAVizNmy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KgkgSLKuMtQpRmEZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder KohRDuDBmqJzGvLH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LNEFVytgWWfzzMLU(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder OMmspzDvGxiuMeAN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder OwGqpfwSJGkDsXpW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder QJgoldIFbKAYjnRt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XIXTNBDrwaVtNsBC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XrYTJDqjzSgIEWHI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IECtrJIvgQivEoVZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder KTlcfzioTSClVUlz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public java.lang.string GetCountryCode() {
        return this.countryCode;
    }

    public override java.lang.string GetDisplayResult() {
        if ((30 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(50);
        OMmspzDvGxiuMeAN(QJgoldIFbKAYjnRt(sb, this.worldManufacturerID), ' ');
        OwGqpfwSJGkDsXpW(KohRDuDBmqJzGvLH(sb, this.vehicleDescriptorSection), ' ');
        kTlcfzioTSClVUlz(IqzgRHAhMAVizNmy(sb, this.vehicleIdentifierSection), '\n');
        java.lang.string str = this.countryCode;
        if (str is not null) {
            HahPwhNvkqVlyOWe(XIXTNBDrwaVtNsBC(sb, str), ' ');
        }
        ACAjGPmsBABIqGJD(HZfHajRbBlpxwhJF(sb, this.modelYear), ' ');
        iECtrJIvgQivEoVZ(KgkgSLKuMtQpRmEZ(sb, this.plantCode), ' ');
        LNEFVytgWWfzzMLU(XrYTJDqjzSgIEWHI(sb, this.sequentialNumber), '\n');
        return BjPZkbsjUSOITPyl(sb);
    }

    public int GetModelYear() {
        return this.modelYear;
    }

    public char GetPlantCode() {
        return this.plantCode;
    }

    public java.lang.string GetSequentialNumber() {
        return this.sequentialNumber;
    }

    public java.lang.string GetVIN() {
        return this.vin;
    }

    public java.lang.string GetVehicleAttributes() {
        return this.vehicleAttributes;
    }

    public java.lang.string GetVehicleDescriptorSection() {
        return this.vehicleDescriptorSection;
    }

    public java.lang.string GetVehicleIdentifierSection() {
        return this.vehicleIdentifierSection;
    }

    public java.lang.string GetWorldManufacturerID() {
        return this.worldManufacturerID;
    }
}

