namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_Event<T> : com.google.android.datatransport.Event<T> {
    private readonly java.lang.int code;
    private readonly com.google.android.datatransport.Eventobject eventobject;
    private readonly T payload;
    private readonly com.google.android.datatransport.Priority priority;
    private readonly com.google.android.datatransport.ProductData productData;

    AutoValue_Event(java.lang.int num, T t, com.google.android.datatransport.Priority priority, com.google.android.datatransport.ProductData productData, com.google.android.datatransport.Eventobject eventobject) {
        this.code = num;
        if (t is null) {
            throw new java.lang.NullPointerException("Null payload");
        }
        this.payload = t;
        if (priority is null) {
            throw new java.lang.NullPointerException("Null priority");
        }
        this.priority = priority;
        this.productData = productData;
        this.eventobject = eventobject;
    }

    public static int ATAkPmsCntleCHZd(java.lang.int num) {
        return num.GetHashCode();
    }

    public static bool BaTTqJuWOusLXTRr(com.google.android.datatransport.Priority priority, java.lang.object obj) {
        return priority.Equals(obj);
    }

    public static java.lang.stringBuilder EaioQbrkinPrczdy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder FRxdKcLysjZIrjSQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object GUkeLQkaSFhbyfGu(com.google.android.datatransport.Event event) {
        return event.getPayload();
    }

    public static bool LluVFjaJpSwvssfT(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.int LolXkSFOUpoxoNBX(com.google.android.datatransport.Event event) {
        return event.getCode();
    }

    public static java.lang.stringBuilder MTNkNJusPdYENRbJ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.android.datatransport.ProductData NdieIfHTfBhktIPT(com.google.android.datatransport.Event event) {
        return event.getProductData();
    }

    public static bool QliEDNeYuWoSqQRC(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool WgeJEkAtYklCcAwA(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string XaxMiGkACewXzarZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.datatransport.ProductData YaQftxBVizEkTbol(com.google.android.datatransport.Event event) {
        return event.getProductData();
    }

    public static java.lang.stringBuilder ADEBogWgYmcrhnLV(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.android.datatransport.Priority AiZPWKphaVCBTifz(com.google.android.datatransport.Event event) {
        return event.getPriority();
    }

    public static int BCoQAzToQxzgKWpC(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder HieEeKLLslerjgqV(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder JaldBUjnCWBueIKD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.datatransport.Eventobject KYlPuXhaCzYIPGGq(com.google.android.datatransport.Event event) {
        return event.getEventobject();
    }

    public static int KYrLaeDPrUqVAHaF(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int LLOuQIwuYYiyGGlu(com.google.android.datatransport.Priority priority) {
        return priority.GetHashCode();
    }

    public static java.lang.stringBuilder MHbWvtcUsMVDrBRk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder OgEpmWqIAHKmGJYY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PFxBOZxkzxTqUinO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool PfAcQTzCKMLjascU(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.int PnwcWHpcyfoMtwqo(com.google.android.datatransport.Event event) {
        return event.getCode();
    }

    public static com.google.android.datatransport.Eventobject PukSoqszRoFBeXGQ(com.google.android.datatransport.Event event) {
        return event.getEventobject();
    }

    public static java.lang.stringBuilder UICvZjUFZZpnBDbW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VfZgwHLeRNbMrMCi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(java.lang.object obj) {
        com.google.android.datatransport.ProductData productData;
        com.google.android.datatransport.Eventobject eventobject;
        if ((7 + 19) % 19 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.Event) {
            com.google.android.datatransport.Event event = (com.google.android.datatransport.Event) obj;
            java.lang.int num = this.code;
            if (num is null ? pnwcWHpcyfoMtwqo(event) is null : LluVFjaJpSwvssfT(num, LolXkSFOUpoxoNBX(event))) {
                if (QliEDNeYuWoSqQRC(this.payload, GUkeLQkaSFhbyfGu(event)) && BaTTqJuWOusLXTRr(this.priority, aiZPWKphaVCBTifz(event)) && ((productData = this.productData) is null ? NdieIfHTfBhktIPT(event) is null : pfAcQTzCKMLjascU(productData, YaQftxBVizEkTbol(event))) && ((eventobject = this.eventobject) is null ? kYlPuXhaCzYIPGGq(event) is null : WgeJEkAtYklCcAwA(eventobject, pukSoqszRoFBeXGQ(event)))) {
                    return true;
                }
            }
        }
        return false;
    }

    public override java.lang.int GetCode() {
        return this.code;
    }

    public override com.google.android.datatransport.Eventobject GetEventobject() {
        return this.eventobject;
    }

    public override T GetPayload() {
        return this.payload;
    }

    public override com.google.android.datatransport.Priority GetPriority() {
        return this.priority;
    }

    public override com.google.android.datatransport.ProductData GetProductData() {
        return this.productData;
    }

    public int HashCode() {
        if ((23 + 8) % 8 > 0) {
        }
        java.lang.int num = this.code;
        int iATAkPmsCntleCHZd = ((((((num is not null ? ATAkPmsCntleCHZd(num) : 0) ^ 1000003) * 1000003) ^ pFxBOZxkzxTqUinO(this.payload)) * 1000003) ^ lLOuQIwuYYiyGGlu(this.priority)) * 1000003;
        com.google.android.datatransport.ProductData productData = this.productData;
        int iKYrLaeDPrUqVAHaF = (iATAkPmsCntleCHZd ^ (productData is not null ? kYrLaeDPrUqVAHaF(productData) : 0)) * 1000003;
        com.google.android.datatransport.Eventobject eventobject = this.eventobject;
        return iKYrLaeDPrUqVAHaF ^ (eventobject is not null ? bCoQAzToQxzgKWpC(eventobject) : 0);
    }

    public java.lang.string Tostring() {
        if ((11 + 32) % 32 > 0) {
        }
        return XaxMiGkACewXzarZ(ogEpmWqIAHKmGJYY(mHbWvtcUsMVDrBRk(FRxdKcLysjZIrjSQ(MTNkNJusPdYENRbJ(uICvZjUFZZpnBDbW(EaioQbrkinPrczdy(jaldBUjnCWBueIKD(aDEBogWgYmcrhnLV(vfZgwHLeRNbMrMCi(hieEeKLLslerjgqV(new java.lang.stringBuilder("Event{code="), this.code), ", payload="), this.payload), ", priority="), this.priority), ", productData="), this.productData), ", eventobject="), this.eventobject), "}"));
    }
}

