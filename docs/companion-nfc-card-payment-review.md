# Companion NFC Card Payment — Complete Review

## Summary

To replicate PocketPay's card payment, we need 3 layers:
1. **NFC/EMV Layer** — read card via APDU commands (we CAN do this)
2. **Acquirer Layer** — send cryptogram to bank for authorization (we NEED this)
3. **Receipt Layer** — post receipt to PSR API (we ALREADY have this)

## What's In The APK (Decompiled)

234 classes extracted. Key SDKs found:

### Visa Tap to Phone Kernel
- `com.visa.app.ttpkernel.ContactlessKernel` — Visa pre-certified L2 EMV kernel
- `com.visa.app.ttpkernel.NfcTransceiver` — NFC APDU transport
- `com.visa.app.ttpkernel.TtpOutcome` — transaction result
- `com.visa.vac.tc.emvconverter.*` — EMV data converter (BERTLV, ApduCommand, EmvReader, CAL)
- Transaction models: `Begin_Transaction`, `Cancel_Transaction`, `TransactionCompletion`, `Close`

### Mastercard Terminal SDK
- `com.mastercard.terminalsdk.TerminalSdk` — main SDK entry
- `com.mastercard.terminalsdk.TransactionInterface` — transaction processing
- `com.mastercard.terminalsdk.listeners.TransactionOutcomeObserver` — result callback
- `com.mastercard.terminalsdk.objects.OutcomeParameterSet.OnlineResponseData` — acquirer response
- `com.mastercard.terminalsdk.objects.ReaderOutcome` — final result
- EMV tag handling, error codes (L1/L2/L3), CVM management

### Obfuscated Wrapper
- `com.d.c.*` — bridges Visa+Mastercard kernels
- `com.d.c.BuildConfig` — contains `ContactlessKernel`, `setCAKeys`, `setTerminalData`, `ContactlessConfiguration`
- Heavily obfuscated (fake overloads, meaningless method names)

### Encryption
- `com.decryptstringmanager.DecryptString` — decrypts all API endpoints (hex-encoded encrypted strings)
- `com.decryptassetmanager.DecryptAsset` — decrypts embedded assets
- `javax.crypto.Cipher`, `SecretKey` — card data encryption

## Transaction Flow (From Logs + Decompilation)

```
1. Login
   POST /api/v3/authorize → JWT token

2. Load Store Data
   GET /api/v2/market/user/.../stores
   GET /mobile-cashier/device/info
   GET /stores/.../products
   GET /stores/.../product-groups
   GET /api/v2/market/user/.../roles/...

3. Card Tap (LOCAL — Visa/MC kernel)
   NFC reader mode activated
   APDU: SELECT PPSE → SELECT AID → GPO → READ RECORD
   EMV kernel processes: ODA, CVM, risk management
   Kernel generates ARQC (Authorization Request Cryptogram)
   Kernel returns EMV data tags to app

4. Online Authorization (HIDDEN — not in OkHttp logs)
   App sends ISO 8583 message (or REST equivalent) to acquirer
   Contains: PAN, Track2, EMV ICC data (DE55), amount, terminal/merchant IDs
   Acquirer → Visa/Mastercard network → Issuing bank
   Bank validates ARQC, returns authCode + responseCode
   THIS CONNECTION USES A DIFFERENT NETWORK STACK (not OkHttp)

5. Receipt
   POST /api/v3/receipt with:
   - payment_type: "TAP_ON_PHONE"
   - authCode: "R99895" (from acquirer, R = referral approval)
   - terminalId: "SFT07056"
   - merchantId: "177397344332991"
   - responseCode: "000" (approved)
   - referenceNumber, stan
```

## The Missing Piece: Acquirer Connection

### What We Know
- The acquirer is **BPC SmartVista** (GCash's processing partner)
- PSR/Evotor (`pulsar.psr-it.com`) sits between the app and SmartVista
- The connection does NOT use OkHttp (not visible in logcat)
- The `DecryptString` class hides the actual endpoint URL
- Terminal ID `SFT07056` = SoftPOS Terminal, Merchant ID `177397344332991`

### Why We Can't Reuse PocketPay's Credentials
1. **PCI MPoC device binding** — SoftPOS is cryptographically bound to the device+app combination
2. **App attestation** — kernel validates signing key, package name, root status
3. **Terminal ID binding** — one terminal ID = one device + one app instance
4. **PSR device registration** — `pulsar.psr-it.com` registers each device with attestation token
5. **Acquirer validation** — SmartVista validates terminal ID + merchant ID + device fingerprint + app cert hash

### AuthCode "R99895" Meaning
- `R` prefix = **Referral approval** — issuer flagged for manual review but approved
- Common for first-time NFC transactions or near floor limit
- ISO 8583 response code `01` = "Refer to card issuer"
- Transaction settles normally after referral approval

## What We CAN Build

### Phase 1: NFC Card Reader (No Payment)
Read card data via EMV APDU commands — PAN (masked), expiry, cardholder name. No acquirer needed.

```
SELECT PPSE → get AIDs
SELECT AID (Visa/MC) → get PDOL
GET PROCESSING OPTIONS → get AFL
READ RECORD → get PAN (5A), Expiry (5F24), Name (5F20), Track2 (57)
```

### Phase 2: Use DCEMV Open-Source Stack
**DCEMV** (`github.com/vicente-da-silva/dcemv`) — full C#/.NET EMV stack:
- Contact + Contactless EMV Kernels 1, 2, 3
- Simulated Payment Provider (validates ARQC, generates ARPC)
- Android NFC driver
- REST API payment server + in-memory HSM
- Could be adapted to connect to a real acquirer

### Phase 3: Real Acquirer Integration
Options for the Philippines:
1. **BPC SmartVista Developer Portal** — `dev.bpcbt.com` has sandbox with Banking API, test cards
2. **Direct acquirer partnership** — BDO, BPI, Metrobank, UnionBank (ISO 8583, private NDA)
3. **iPOSpays In-App SDK** — commercial SoftPOS SDK with acquirer integration

**No Philippine payment gateway** (PayMongo, Xendit, Maya, DragonPay) accepts raw EMV data via public API. Card-present acquiring is always a private integration.

## ISO 8583 Fields Needed for Authorization

| Field | Name | Content |
|-------|------|---------|
| DE2 | PAN | From EMV tag 5A |
| DE3 | Processing Code | `000000` (purchase) |
| DE4 | Amount | In minor units |
| DE11 | STAN | System Trace Audit Number |
| DE14 | Expiry | YYMM from tag 5F24 |
| DE22 | POS Entry Mode | `071` (contactless chip) |
| DE35 | Track 2 | From EMV tag 57 |
| DE37 | Reference Number | 12-digit reference |
| DE41 | Terminal ID | `SFT07056` |
| DE42 | Merchant ID | `177397344332991` |
| DE55 | EMV ICC Data | TLV: 9F26 (ARQC), 9F27, 9F10, 9F37, 9F36, 95, 9A, 9C, 9F02, 82, 9F1A, 5F2A |

## Recommended Next Steps

1. **Build NFC card reader** in companion app (APDU commands, TLV parser, display masked PAN)
2. **Explore BPC SmartVista sandbox** at `dev.bpcbt.com` for acquirer API testing
3. **Port DCEMV** to .NET 11 Android for full EMV kernel without Visa/Mastercard certification
4. **Capture the hidden acquirer endpoint** — run the PocketPay app with network traffic capture (tcpdump via root or VPN-based proxy like mitmproxy) to find the non-OkHttp connection
5. **Reverse `DecryptString`** — decompile the decryption algorithm to reveal encrypted API endpoints

## Acquirer Integration Options

### Option 1: iPOSpays SDK (Recommended — Fastest Path)
- Commercial SoftPOS SDK, Android 8.1+, PCI-CPOC certified
- One API call does everything: NFC → EMV kernel → acquirer auth → response
- `registerDevice(tpn, merchantCode)` → 24-hour session key
- `performTransaction({type:"SALE", amount:"1.00"}, sessionKey)` → card tap + auth
- Returns: status, last4, card type, timestamp
- Contact: devsupport@dejavoo.io for TPN + Merchant Code onboarding
- GitHub: `github.com/dejavoo-integration/Tap-to-Pay-on-Android-In-App-SDK`
- Gradle: `com.denovo:topliteapp:1.7.5.5`

### Option 2: BPC SmartVista Sandbox
- Signup: `dev.bpcbt.com/cabinet/index.html#/auth?login`
- eCommerce API v2: `dev.bpcbt.com/cabinet/ecom_api_v2.html`
- Direct payments: `dev.bpcbt.com/en/integration/apiv2/structure/direct-integration-apiv2.html`
- Test cards: `dev.bpcbt.com/en/integration/structure/test-cards.html`
- NOTE: No SoftPOS/card-present API publicly documented — eCommerce only

### Option 3: Build Custom with NetCore8583
- NuGet: `NetCore8583` v2.4.0
- Build ISO 8583 0100 authorization messages
- Need acquirer relationship (BDO, BPI, Metrobank) for host connection
- Most effort but full control

### DecryptString — CRACKED
- Algorithm: AES-256-GCM/NoPadding + PBKDF2WithHmacSHA1
- Password: `HTxJJaZxBMzl6hR37pogA5fIcx0Chyqg`
- Salt: password bytes (32 bytes)
- Iterations: **128**
- Data layout: `[IV:12][ciphertext:N][GCM tag:16]`
- **2,878 / 3,235 strings decrypted (89%)**

### Discovered Hidden Endpoints
- **`https://mobilecashier.psr-it.com/api/v2/market/`** — Tap on Phone order/transaction API (`provideTophOrderApi`)
- **`https://mobilecashier.ru/api/v2/device/`** — Tap on Phone device auth API (`provideTophAuthDeviceApi`)
- `https://clients3.google.com/generate_204` — connectivity check

### Tap on Phone Flow (Decrypted — Complete)

**Endpoints:**
- Device auth: `https://mobilecashier.ru/api/v2/device/`
- Transaction: `https://mobilecashier.psr-it.com/api/v2/market/`
- Receipt: `https://pulsar.psr-it.com/api/v3/receipt`

**Auth:**
- Header: `x-merchant-api-key` (merchant-specific API key)
- Token: `access_token` stored in `pref.accessToken`
- Device auth returns token at `toph_auth_success`

**Transaction types:**
- `TRANSACTION_TYPE_PURCHASE` (sale)
- `TRANSACTION_TYPE_REFUND`
- `TRANSACTION_TYPE_PURCHASE_WITH_CASHBACK`

**EMV data sent:**
- `emv.card.AuthCDO` — Authorization Cryptogram Data Object
- `paymentsystem.tx.$.TTQ` — Terminal Transaction Qualifiers
- `paymentsystem.card.CardAuthenticationData`
- `emv.card.FirstGenDataCDO.TransactionType`
- `emv.txp.tm.TransactionCompletionSecondGenContainer`

**Response:**
- `emv.tx.$.AuthResponseCode` — authorization response code
- `emv.tx.$.AuthStatus` — authorization status
- `emv.card.IssuerAuthResult` — issuer authentication result

**Merchant config:**
- `ONLINE_ONLY_MERCHANT_ATTENDED` — merchant type
- `emv.config.tm.MerchantName`
- `emv.poi.MerchantNameLocation`

**Flow (CONFIRMED from jadx decompilation):**
1. `POST https://mobilecashier.ru/api/v2/device/status/toph` — device auth (WORKS, 200 OK)
   - Body: `{"user_id":"...","device_uuid":"...","mid":"177397344332991","tid":"SFT07056"}`
   - Auth: `Authorization: Bearer <JWT>`, `AndroidId: <deviceImei>`
   - Retrofit path annotation: `@pa02439ec("status/toph")`

2. NFC EMV kernel reads card → generates ARQC + AuthCDO

3. `POST https://mobilecashier.ru/api/v3/market/order/toph` — send EMV data for authorization (EXISTS, 403)
   - Body: `{"user_id":"...","phone":"...","fio":"","inn":"","region_id":0}` (TophOrderRequest)
   - Retrofit path annotation: `@pa02439ec("order/toph")`
   - Base URL decrypted: `https://mobilecashier.psr-it.com/api/v2/market/` (DNS dead, likely migrated to mobilecashier.ru)
   - Needs real x-merchant-api-key from PocketPay SharedPreferences

4. `POST https://pulsar.psr-it.com/api/v3/receipt` + JWT → receipt stored

## Complete API Contract (from Decompilation)

### 1. Device Info (Confirmed Working)
```
GET https://mobilecashier.ru/api/v2/device/info?deviceId=<id>&userId=<id>
Header: Authorization: Bearer <JWT from pulsar.psr-it.com>
Response: 400 (needs correct params — endpoint is LIVE)
```

### 2. Market API (Confirmed Working)
```
GET/POST https://mobilecashier.ru/api/v3/market/
Header: Authorization: Bearer <JWT>
Header: AndroidId: <deviceImei>
Response: 403 (needs additional auth — endpoint is LIVE)
```

### API Probing Results (Verified Live)
- `mobilecashier.ru` is LIVE
- `pulsar.psr-it.com` is LIVE — all endpoints responding with real data
- JWT from `pulsar.psr-it.com/api/v3/authorize` is accepted by both servers
- `/api/v2/device/info` = GET only, with `x-merchant-api-key` header causes TIMEOUT (server processing)
- `/api/v3/market/*` needs `AndroidId` header + separate auth token (NOT JWT, NOT device token)
- Device token from pulsar (`b84a6501-c81e-4e95-a148-77b12670102b`) returns "TOKEN INVALID" on mobilecashier
- `mobilecashier.psr-it.com` does NOT resolve
- Auth flow: `authDevice` returns a session token → used for all subsequent mobilecashier calls
- The `authDevice` request model (`pd239a801`) needs to be decompiled to find required fields

### Pulsar API Data Retrieved
```json
Device: { uuid: "a29e8f74-e57b-46cf-80a9-a5dff92f49a2", imei: "e14ceab085867eab", token: "b84a6501-c81e-4e95-a148-77b12670102b" }
Store: { id: "fc0f2f09-7b94-4140-b5f3-9fc589d7fa18", name: "My store", address: "PH" }
User: { role: "Administrator", grants: ["CASH_OPERATIONS_SELL", ...] }
```

### 3. Send Transaction (Card Payment — Estimated)
```
POST https://mobilecashier.ru/api/v3/market/<path>
Header: Authorization: Bearer <JWT>
Header: AndroidId: <deviceImei>
Body: {
  transaction_type: "TRANSACTION_TYPE_PURCHASE",
  amount: <amount>,
  currency: "PHP",
  device_id: "<deviceImei>",
  emv_data: {
    PAN: "<from tag 5A>",
    ExpiryDate: "<from tag 5F24>",
    PANSequenceNumber: "<from tag 5F34>",
    Track2EquivalentData: "<from tag 57>",
    AuthCDO: "<ARQC cryptogram>",
    TTQ: "<Terminal Transaction Qualifiers>"
  }
}
Response: {
  AuthResponseCode: "000",
  authCode: "R99895",
  stan: "144908",
  referenceNumber: "144908746259"
}
```

### 3. Store Receipt
```
POST https://pulsar.psr-it.com/api/v3/receipt
Header: Authorization: Bearer <jwt from /api/v3/authorize>
Body: <receipt JSON with payment_type, transaction data>
Response: <receipt with number, sessionId>
```

### Retrofit Client Configuration (from decompiled classes21.dex)
- OkHttpClient with interceptors for `x-merchant-api-key` header
- Encrypted base URLs (decrypted via AES/GCM)
- Coroutine-based (Kotlin suspend functions)
- Three API interfaces: AuthDevice, Order, TokenByPhone

### Request Models (Decompiled from DEX)

**authDevice** — `POST https://mobilecashier.ru/api/v2/device/`
```json
{ "userId": "string", "deviceUuid": "string", "mid": "string", "tid": "string" }
```

**sendOrder** — transaction API
```json
{ "userId": "string", "phone": "string", "fio": "string", "inn": "string", "regionId": int }
```

**getTokenByPhone** — token API
```json
{ "phone": long }
```

### Blocker: x-merchant-api-key
- Stored in PocketPay's encrypted SharedPreferences under `com.psr.pulsar.integration_registry_key`
- Set during initial PocketPay merchant onboarding
- NOT in APK binary, NOT in logcat, NOT derivable from JWT
- Added as HTTP header by OkHttp interceptor in Retrofit client
- Cannot read without: root, PCAPdroid TLS decryption, or Frida hook
- The `mobilecashier.ru` API returns 403 "AUTHORIZATION HEADER MISSING" without it

### What Works Without x-merchant-api-key
- All `pulsar.psr-it.com` endpoints (JWT auth) — device info, stores, products, receipts
- NFC card reading (local APDU commands)
- QR payments via receipt API
- Full device monitoring via companion

### Decompiled API Classes
- `p83f5c3ad.p8a5da52e.p40de21f4` — ToPH Auth Device API (Retrofit interface)
- `p83f5c3ad.p8a5da52e.p7b8552a1` — ToPH Order API (Retrofit interface)
- `p83f5c3ad.p8a5da52e.pd53f9bcf` — ToPH Token API (Retrofit interface)
- `p83f5c3ad.p690382dd.p44fcbc21` — Koin DI module registering all APIs

## Current Status

**The transpiler generates 3 projects that build clean (0 errors):**
1. **Backoffice** — WSS-only server, ADB logcat monitor, receipt relay
2. **Companion APK** — NFC card reader, auto-discovers backoffice via UDP
3. **WASM** — Standalone UI with auto-discover JS

**What works standalone:**
- QR payments (end-to-end, money moves)
- NFC card reading (PAN, expiry, network, cardholder name)
- Receipt posting to PSR API
- Auto-login with captured credentials
- Real-time PocketPay receipt capture via ADB logcat

**For production card charges (real money):**
- **2C2P SoftPOS SDK** (BEST — Philippines sandbox ready)
  - Gradle: `com.2c2p:softpos-sdk-sandbox:1.2.1`
  - Philippines Merchant: JT05, Key: 71138119281833EB...
  - Sandbox: `https://sandbox-pgw.2c2p.com/payment/4.3/paymentInstruction`
  - Test Visa: 4111111111111111, OTP: 123456
- Or Mastercard SDK (free — email contactless@mastercard.com)
- Or Stripe Terminal SDK (not yet in Philippines)

**Why standalone card charges don't work yet:**
- The card's chip generates the ARQC cryptogram
- The ARQC must go to an acquirer (bank) for authorization via ISO 8583 over TCP
- No Philippine acquirer offers public TCP endpoints — requires formal merchant agreement + VPN
- PocketPay uses BPC SmartVista via `mobilecashier.ru` but the API requires a session token from device registration which uses an unknown POST path

## Files
- `docs/pocketpay-payment-workflows.md` — captured QR + card payment request/response
- `docs/pocketpay-softpos-decompiled.md` — 234 decompiled SoftPOS classes (5MB)
- `docs/pocketpay-toph-api-decompiled.md` — 39 ToPH API classes (853KB)
- `docs/decryptstring-reversed.md` — 2,878 decrypted strings with caller context (456KB)
- `scripts/decrypt-all.csx` — batch decryptor (AES-256-GCM, PBKDF2, 128 iterations)
- `scripts/crack-decrypt.csx` — brute-force cracker that found the parameters
- `src/PocketPay.Companion/Services/EmvCardReader.cs` — NFC EMV card reader (APDU commands)
- `src/PocketPay.Companion/Platforms/Android/NfcReaderActivity.cs` — NFC reader Activity
- `src/PocketPay.Companion/` — companion app with HTTP server, logcat reader, settings toggle
- `src/Companion.Backoffice/` — HTTPS backoffice with WSS, device info, permissions, controls
