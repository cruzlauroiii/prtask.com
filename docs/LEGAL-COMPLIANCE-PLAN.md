# PrTask Legal Compliance Plan

> Comprehensive legal requirements for PrTask -- a developer marketplace where clients post tasks with bounties and developers submit pull requests for payment.
>
> Last updated: 2026-03-23

---

## Table of Contents

1. [Data Privacy Laws by Country/Region](#1-data-privacy-laws-by-countryregion)
2. [Legal Pages Required](#2-legal-pages-required)
3. [Cookie Consent Requirements](#3-cookie-consent-requirements)
4. [Payment and Financial Compliance](#4-payment-and-financial-compliance)
5. [Tax Compliance](#5-tax-compliance)
6. [Intellectual Property and DMCA](#6-intellectual-property-and-dmca)
7. [Consumer Protection](#7-consumer-protection)
8. [Content Moderation](#8-content-moderation)
9. [Accessibility Requirements](#9-accessibility-requirements)
10. [Age Verification](#10-age-verification)
11. [Dispute Resolution](#11-dispute-resolution)
12. [AML/KYC Requirements](#12-amlkyc-requirements)
13. [Implementation Checklist](#13-implementation-checklist)
14. [Domain Constants Reference](#14-domain-constants-reference)

---

## 1. Data Privacy Laws by Country/Region

### 1.1 European Union -- GDPR (General Data Protection Regulation)

**Regulation:** Regulation (EU) 2016/679
**Applies when:** Processing personal data of individuals in the EU, OR offering goods/services to EU residents, OR monitoring behavior of EU residents.

**Mandatory Requirements:**
- Lawful basis for processing (consent, contract, legitimate interest, legal obligation, vital interests, public task)
- Transparent privacy notice in plain language
- Right to access, rectification, erasure ("right to be forgotten"), data portability, restriction of processing, objection
- Data Protection Impact Assessments (DPIAs) for high-risk processing
- Records of Processing Activities (ROPA) under Article 30
- Data Protection Officer (DPO) required when monitoring individuals at scale or processing sensitive data
- Breach notification to supervisory authority within 72 hours
- Breach notification to affected individuals when high risk to rights/freedoms
- Data Processing Agreements (DPAs) with all processors
- Cross-border transfer safeguards (Standard Contractual Clauses, adequacy decisions)
- Privacy by design and by default (Article 25)
- Global Privacy Control (GPC) signal recognition
- One-click reject mechanism with equal prominence to accept
- Granular consent per purpose

**Mandatory Website Disclosures:**
- Identity and contact details of the data controller
- Contact details of the Data Protection Officer (if applicable)
- Purposes of processing and lawful basis for each
- Categories of personal data collected
- Recipients or categories of recipients
- International transfer details and safeguards
- Retention periods or criteria for determining retention
- Data subject rights and how to exercise them
- Right to withdraw consent at any time
- Right to lodge a complaint with a supervisory authority
- Whether provision of data is statutory/contractual requirement
- Existence of automated decision-making, including profiling

**Penalties:**
- Lower tier: EUR 10 million or 2% of annual worldwide turnover (whichever is higher)
- Higher tier: EUR 20 million or 4% of annual worldwide turnover (whichever is higher)
- As of 2025: 2,245+ fines totaling approximately EUR 5.65 billion recorded

---

### 1.2 United Kingdom -- UK GDPR + Data Protection Act 2018

**Regulation:** Data Protection Act 2018, UK GDPR (retained EU law post-Brexit)
**Regulator:** Information Commissioner's Office (ICO)
**Applies when:** Processing personal data of UK residents.

**Mandatory Requirements:**
- Mirror GDPR requirements with UK-specific adaptations
- UK representative required for non-UK controllers
- Lawful basis documentation for all processing
- Privacy notices reflecting DPA 2018 requirements
- Data Protection Impact Assessments for high-risk processing
- Appropriate technical and organizational security measures
- Records demonstrating compliance (accountability principle)

**Penalties:**
- Standard maximum: GBP 8.7 million or 2% of worldwide turnover
- Higher maximum: GBP 17.5 million or 4% of worldwide turnover

---

### 1.3 California, USA -- CCPA/CPRA

**Regulation:** California Consumer Privacy Act (as amended by CPRA), effective regulations updated January 1, 2026
**Regulator:** California Privacy Protection Agency (CPPA)
**Applies when:** Annual revenue > USD 26,625,000, OR derive 50%+ revenue from selling/sharing personal information, OR process data of 100,000+ California residents/households.

**Mandatory Requirements:**
- Eleven mandatory disclosures in privacy policy
- "Do Not Sell or Share My Personal Information" link
- "Limit the Use of My Sensitive Personal Information" link
- Opt-out confirmation requirements (mandatory as of January 1, 2026)
- Annual privacy policy updates at minimum
- Respond to consumer requests within 45 days
- 12-month lookback on data categories collected
- Cybersecurity audits (phased compliance through 2030)
- Risk assessments for high-risk processing
- Automated decision-making technology (ADMT) disclosures
- Honor Global Privacy Control (GPC) signals

**Mandatory Website Disclosures:**
- Categories of personal information collected in last 12 months
- Categories of sources from which personal information is collected
- Business or commercial purpose for collection or selling
- Categories of third parties with whom personal information is shared
- Specific pieces of personal information collected about the consumer
- Categories disclosed to service providers for business purposes
- Whether personal information is sold or shared, and to whom

**Penalties:**
- USD 2,500 per unintentional violation
- USD 7,500 per intentional violation
- Private right of action for data breaches: USD 100-750 per consumer per incident

---

### 1.4 Philippines -- RA 10173 (Data Privacy Act of 2012)

**Regulation:** Republic Act No. 10173
**Regulator:** National Privacy Commission (NPC)
**Applies when:** Processing personal data of Philippine citizens/residents, or using equipment in the Philippines for processing.

**Mandatory Requirements:**
- Compliance with transparency, legitimate purpose, and proportionality principles
- Data Protection Officer (DPO) appointment mandatory for all entities processing personal data
- Privacy Impact Assessments for high-risk processing
- Organizational, physical, and technical security measures
- Data Processing Agreements between controllers and processors
- Breach notification to NPC and affected data subjects within 72 hours
- Registration with the NPC for entities processing sensitive personal information
- Data sharing agreements must be registered with the NPC

**Mandatory Website Disclosures:**
- Privacy notice/policy in Filipino or English
- Purpose of data collection
- Scope and method of personal data processing
- Recipients of personal data
- Methods for exercising data subject rights
- Contact details of the DPO
- Retention period

**Penalties:**
- Unauthorized processing: PHP 500,000 to PHP 2,000,000 fine + up to 3 years imprisonment
- Sensitive data breaches: up to PHP 5,000,000 fine + up to 6 years imprisonment
- Unauthorized disclosure: PHP 500,000 to PHP 1,000,000 fine + up to 5 years imprisonment
- Criminal liability applies to responsible officers

---

### 1.5 Canada -- PIPEDA (Personal Information Protection and Electronic Documents Act)

**Regulation:** PIPEDA (soon to be replaced by CPPA under Bill C-27)
**Regulator:** Office of the Privacy Commissioner of Canada (OPC)
**Applies when:** Processing personal information in the course of commercial activity involving Canadian residents.

**Mandatory Requirements:**
- Ten Fair Information Principles: accountability, identifying purposes, consent, limiting collection, limiting use/disclosure/retention, accuracy, safeguards, openness, individual access, challenging compliance
- Meaningful consent (not bundled or coercive)
- Purpose identification before or at time of collection
- Respond to access requests within 30 days
- Breach notification to OPC when real risk of significant harm
- Breach notification to affected individuals when real risk of significant harm
- Record of breaches for 24 months
- Privacy policy must be easy to read and understand

**Penalties:**
- Up to CAD 100,000 per violation under current PIPEDA
- Under proposed CPPA: up to CAD 25 million or 5% of global revenue

---

### 1.6 Brazil -- LGPD (Lei Geral de Protecao de Dados)

**Regulation:** Law No. 13,709/2018 (LGPD)
**Regulator:** ANPD (Autoridade Nacional de Protecao de Dados)
**Applies when:** Processing personal data collected in Brazil, or of individuals in Brazil, or offering goods/services to individuals in Brazil.

**Mandatory Requirements:**
- Lawful basis for processing (10 legal bases including consent, contract, legitimate interest)
- Data Protection Officer (DPO) appointment mandatory
- Respond to data subject requests within 15 days
- Privacy Impact Assessments for sensitive data processing
- International data transfers only with adequate safeguards
- Standard Contractual Clauses (ANPD-approved) required by August 2025
- Data breach notification to ANPD and data subjects within "reasonable time"
- Records of processing activities
- Security measures appropriate to risk

**Penalties:**
- Up to 2% of revenue in Brazil, capped at BRL 50 million per infraction
- Daily fines, public disclosure of violation, data blocking/deletion

---

### 1.7 Japan -- APPI (Act on Protection of Personal Information)

**Regulation:** APPI (2003, major amendments 2020, 2025-2027 reforms pending)
**Regulator:** Personal Information Protection Commission (PPC)
**Applies when:** Handling personal information of individuals in Japan.

**Mandatory Requirements:**
- Privacy policy stipulating purpose of data use
- Cybersecurity measures and physical safeguards
- Mandatory data breach notification to PPC and affected data subjects
- Consent required for handling sensitive personal information
- Opt-out mechanism for third-party data sharing
- Restrictions on cross-border data transfers
- Record-keeping for third-party data transfers (given and received)

**2025-2027 Updates:**
- Administrative surcharges for serious violations
- Expanded individual rights

**Penalties:**
- Criminal penalties: up to 1 year imprisonment or JPY 1 million fine for individuals
- Corporate penalties: up to JPY 100 million
- 2025-2027: introduction of administrative surcharges

---

### 1.8 Singapore -- PDPA (Personal Data Protection Act)

**Regulation:** PDPA 2012 (amended 2020)
**Regulator:** Personal Data Protection Commission (PDPC)
**Applies when:** Processing personal data of individuals in Singapore.

**Mandatory Requirements:**
- Consent and notification obligations
- Data Protection Officer (DPO) appointment mandatory (with notification to PDPC effective June 2025)
- DPO contact information must be publicly available
- Data protection policies and complaints processes available on request
- Cross-border transfer restrictions (comparable protection required)
- Data breach notification to PDPC when breach likely results in significant harm or is of significant scale
- Access and correction rights within 30 days
- Retention limitation (cease retaining when purpose no longer served)

**Penalties:**
- Up to SGD 1 million or 10% of annual turnover (whichever is higher)

---

### 1.9 Thailand -- PDPA (Personal Data Protection Act)

**Regulation:** PDPA B.E. 2562 (2019), fully effective June 1, 2022
**Regulator:** Personal Data Protection Committee (PDPC)
**Applies when:** Processing personal data of individuals in Thailand.

**Mandatory Requirements:**
- Consent required before collection/use/disclosure
- Data controller-processor agreements
- DPO required for public authorities, large-scale monitoring, or core sensitive data activities
- Security safeguards with regular audits
- Cross-border transfer controls (Binding Corporate Rules from September 2025)

**Penalties:**
- Administrative fines: up to THB 5 million
- Criminal fines: up to THB 1 million + imprisonment
- August 2025: first major fines issued (THB 21.5 million across 5 cases)

---

### 1.10 South Africa -- POPIA (Protection of Personal Information Act)

**Regulation:** POPIA (Act 4 of 2013), effective July 1, 2021
**Regulator:** Information Regulator of South Africa
**Applies when:** Processing personal information of South African residents.

**Mandatory Requirements:**
- Information Officer registration with Information Regulator (typically CEO or designated representative)
- Eight conditions for lawful processing: accountability, processing limitation, purpose specification, further processing limitation, information quality, openness, security safeguards, data subject participation
- Security compromise notification "as soon as reasonably sure" (2025 amendment)
- Cross-border transfer restrictions (adequate protection required)
- Direct marketing requires opt-in consent

**Penalties:**
- Administrative fines up to ZAR 10 million or 10% of annual turnover (whichever is higher)
- Criminal penalties: up to 10 years imprisonment for serious offenses

---

### 1.11 Australia -- Privacy Act 1988 (as amended 2024-2025)

**Regulation:** Privacy Act 1988, Australian Privacy Principles (APPs)
**Regulator:** Office of the Australian Information Commissioner (OAIC)
**Applies when:** Annual turnover > AUD 3 million, or trading in personal information, or providing health services, or a government entity.

**Mandatory Requirements:**
- 13 Australian Privacy Principles (APPs)
- Privacy policy required and must be kept up-to-date
- Notifiable Data Breaches scheme (notify OAIC and affected individuals)
- Statutory tort for serious privacy invasions (effective June 10, 2025)
- Automated decision-making disclosure in privacy policies (effective December 10, 2026)
- AI disclosure requirements (effective December 10, 2026)
- Children's Online Privacy Code (registered by December 10, 2026)

**Penalties:**
- Up to AUD 50 million, or 3x the benefit obtained, or 30% of adjusted turnover (whichever is greatest)

---

### 1.12 India -- DPDP Act 2023 (Digital Personal Data Protection Act)

**Regulation:** DPDP Act 2023, implementing rules effective with 18-month window
**Regulator:** Data Protection Board of India
**Applies when:** Processing digital personal data within India, or processing outside India in connection with offering goods/services to Indian data principals.

**Mandatory Requirements:**
- Consent must be specific, unambiguous, with "clear affirmative action"
- Notice before or at time of collection with purpose and rights information
- Security safeguards (encryption, access controls, monitoring, logging)
- Data breach notification to Board and affected individuals
- Significant Data Fiduciaries must appoint India-based DPO and independent data auditor
- Grievance redressal mechanism
- Data retention only as long as necessary for purpose

**Penalties:**
- INR 500 million (EUR 5.7 million) to INR 2.5 billion (EUR 28 million) depending on violation

---

### 1.13 South Korea -- PIPA (Personal Information Protection Act)

**Regulation:** PIPA (2011, major amendments 2023-2025)
**Regulator:** Personal Information Protection Commission (PIPC)
**Applies when:** Processing personal information of individuals in South Korea.

**Mandatory Requirements:**
- Truly voluntary consent (no bundled or coercive terms)
- Data portability rights (effective March 13, 2025) with secure machine-readable format
- Overseas controllers must appoint domestic representative (effective October 2, 2025)
- Transparency on AI/algorithmic processes and user profiling
- Cross-border transfer framework compliance
- Privacy notices clearly outlining all data uses
- Regular privacy policy and contract updates

**Penalties:**
- Up to 3% of related revenue or KRW 2 billion (whichever is higher)
- Criminal penalties: up to 5 years imprisonment

---

### 1.14 China -- PIPL (Personal Information Protection Law)

**Regulation:** PIPL (effective November 1, 2021)
**Regulator:** Cyberspace Administration of China (CAC)
**Applies when:** Processing personal information of individuals in China.

**Mandatory Requirements:**
- Local representative appointment for foreign processors
- Personal Information Protection Impact Assessments (PIAs) for sensitive data, automated decisions, third-party sharing, cross-border transfers
- Compliance audit requirements (effective May 1, 2025): processors of >1 million individuals must appoint DPO
- Separate consent for sensitive personal information (not combined with general consent)
- No bundled consent for multiple processing purposes
- Breach notification to CAC and affected individuals immediately
- Cross-border transfer: security review for >1 million individuals, standard contracts or certification for smaller transfers
- New national standard GB/T 45574-2025 on sensitive personal information security (effective November 1, 2025)

**Penalties:**
- Up to RMB 50 million or 5% of prior year's revenue
- Personal liability for responsible individuals: up to RMB 1 million + career ban
- Suspension or termination of services

---

### 1.15 New Zealand -- Privacy Act 2020

**Regulation:** Privacy Act 2020
**Regulator:** Office of the Privacy Commissioner
**Applies when:** Processing personal information of New Zealand residents by any organization doing business in New Zealand.

**Mandatory Requirements:**
- 13 Information Privacy Principles
- Breach notification within 72 hours for breaches causing serious harm
- Privacy policy with transparency about collection, use, storage, and sharing
- Compliance with cross-border disclosure restrictions

**Penalties:**
- Up to NZD 10,000 for individuals, NZD 50,000 for organizations per offense
- Human Rights Tribunal can award damages

---

## 2. Legal Pages Required

### 2.1 Privacy Policy (REQUIRED -- ALL JURISDICTIONS)

**Must Include:**
- Controller identity, contact details, registered address
- DPO contact information
- Categories of personal data collected (with specifics per CCPA categories)
- Purpose and lawful basis for each processing activity
- Categories of recipients/third parties
- International transfer details and safeguards (SCCs, adequacy decisions)
- Retention periods or criteria
- Data subject rights by jurisdiction (access, rectification, erasure, portability, restriction, objection)
- Right to withdraw consent
- Right to lodge complaint with supervisory authority
- Automated decision-making and profiling disclosures
- AI usage disclosure (required by Australia from December 2026)
- Cookie and tracking technology details
- Third-party service providers (analytics, payment, authentication)
- Children's data handling policy
- California-specific disclosures (CCPA categories, 12-month lookback, sale/sharing categories)
- "Do Not Sell or Share My Personal Information" instructions
- "Limit the Use of My Sensitive Personal Information" instructions
- Date of last update
- Version history

**Update Frequency:** At minimum annually; immediately upon material changes.

---

### 2.2 Terms of Service (REQUIRED)

**Must Include:**
- Platform description and services offered
- User eligibility (age requirements, geographic restrictions)
- Account registration and responsibilities
- Acceptable use policy
- Prohibited conduct
- Intellectual property rights (platform owns platform IP; developers retain code IP; clients receive license upon payment)
- Content ownership and licensing terms
- Payment terms (bounty posting, escrow, payout conditions, fees)
- Dispute resolution between clients and developers
- Limitation of liability
- Disclaimer of warranties
- Indemnification clause
- Termination and suspension rights
- Governing law and jurisdiction
- Modification procedures and notice requirements
- Force majeure
- Severability clause
- Entire agreement clause
- EU-specific: link to ADR/out-of-court dispute settlement mechanism
- EU-specific: content moderation policies and appeal procedures (DSA compliance)
- Repeat infringer policy (DMCA compliance)
- Compliance with all applicable laws acknowledgment

---

### 2.3 Cookie Policy (REQUIRED -- EU, UK, BRAZIL, THAILAND, AND OTHERS)

**Must Include:**
- What cookies are and how the platform uses them
- Categories of cookies: strictly necessary, functional, analytics, marketing/advertising
- Specific cookies used with name, provider, purpose, type, and duration
- Third-party cookies and their purposes
- How to manage/delete cookies via browser settings
- How to withdraw cookie consent
- Link to privacy policy
- Date of last update

---

### 2.4 Refund Policy (REQUIRED)

**Must Include:**
- EU: 14-day right of withdrawal for digital services (unless waived at point of purchase with explicit consent)
- EU: Clear "Cancel my contract" function required from June 2026
- Refund conditions specific to bounty marketplace (when work is not delivered, when work is rejected, partial completion)
- Refund timeline (EU: within 14 days of withdrawal notification)
- Payment method for refunds (same method as original payment)
- Non-refundable items/services clearly identified
- Dispute escalation process
- Country-specific consumer protection requirements

---

### 2.5 DMCA/Copyright Policy (REQUIRED)

**Must Include:**
- Designated DMCA agent contact information (name, address, phone, email)
- How to submit a takedown notice (required elements per 17 U.S.C. 512)
- Counter-notification procedure
- Repeat infringer policy and consequences
- Good faith belief statement requirement
- Perjury acknowledgment for takedown notices
- Timeline for content removal upon valid notice
- Safe harbor statement

**Registration Required:**
- Register DMCA agent with U.S. Copyright Office
- Make agent information publicly accessible on website

---

### 2.6 Acceptable Use Policy (REQUIRED)

**Must Include:**
- Prohibited activities (fraud, harassment, spam, malware, illegal content)
- Code of conduct for clients and developers
- Consequences of violations (warnings, suspension, termination, reporting to authorities)
- Content restrictions
- Security requirements for submitted code
- Reporting mechanism for violations

---

### 2.7 Accessibility Statement (REQUIRED FOR EU/US COMPLIANCE)

**Must Include:**
- Commitment to WCAG 2.2 Level AA compliance
- Known accessibility limitations
- Contact information for accessibility feedback
- Date of last accessibility audit
- Alternative access methods available
- Third-party accessibility audit results (if available)

---

## 3. Cookie Consent Requirements

### 3.1 EU/EEA (ePrivacy Directive + GDPR)

- **Prior consent required** before setting non-essential cookies
- **Opt-in model**: no cookies until explicit user permission
- **Granular consent**: users must be able to accept/reject by category (analytics, marketing, functional)
- **Equal prominence**: reject button must be as easy to find/use as accept button
- **No cookie walls**: cannot deny access for refusing non-essential cookies
- **Consent must be**: freely given, specific, informed, unambiguous
- **Record consent**: maintain auditable records of consent
- **Renewal**: consent should be renewed periodically (typically annually)
- **ePrivacy Directive withdrawal**: formal withdrawal of proposed ePrivacy Regulation in February 2025 means existing Directive remains in force

### 3.2 United Kingdom (PECR)

- **Explicit prior consent** for non-essential cookies
- **ICO enforcement**: 134 UK websites received cookie compliance warnings in 2025
- **DPDI Act**: may relax analytics cookie requirements in future, but ICO still requires consent as of 2026

### 3.3 California (CCPA/CPRA)

- **Opt-out model** for sale/sharing of personal information via cookies
- **Do Not Sell/Share link** required
- **Honor GPC signals** as valid opt-out
- **No consent required** to set cookies, but disclosure required

### 3.4 Brazil (LGPD)

- **Consent required** for non-essential cookies
- **Clear information** about cookie purposes
- **Opt-out mechanism** must be available

### 3.5 Other Jurisdictions

| Country | Model | Notes |
|---------|-------|-------|
| Canada (PIPEDA) | Implied consent for non-sensitive; express for sensitive | CPPA will require explicit consent |
| Japan (APPI) | Opt-out for non-sensitive | Consent for sensitive data |
| South Korea (PIPA) | Opt-in | Consent before cookie placement |
| Singapore (PDPA) | Deemed consent if reasonable | Notification required |
| Thailand (PDPA) | Opt-in consent | Consent for non-essential cookies |
| Australia | No specific cookie law | Privacy Act disclosure requirements |
| India (DPDP) | Consent required | Clear affirmative action |
| South Africa (POPIA) | Consent required | Opt-in for direct marketing |
| China (PIPL) | Consent required | Separate consent for sensitive data |

### 3.6 Implementation Requirements

- Cookie banner must load before any non-essential cookies
- Must block third-party scripts (analytics, ads, social) until consent
- Consent Management Platform (CMP) recommended
- CNIL (France) fines for cookie violations: EUR 139 million between Dec 2022 and Dec 2024
- Highest single cookie fine: EUR 150 million (SHEIN)

---

## 4. Payment and Financial Compliance

### 4.1 PCI DSS (Payment Card Industry Data Security Standard)

**Version:** PCI DSS 4.0 (all requirements enforceable as of March 31, 2025)
**Applies when:** Storing, processing, or transmitting cardholder data.

**Key Requirements (12 core):**
1. Install and maintain network security controls
2. Apply secure configurations to all system components
3. Protect stored account data
4. Protect cardholder data with strong cryptography during transmission
5. Protect all systems from malicious software
6. Develop and maintain secure systems and software
7. Restrict access by business need-to-know
8. Identify users and authenticate access
9. Restrict physical access to cardholder data
10. Log and monitor all access to system components and cardholder data
11. Test security of systems and networks regularly
12. Support information security with organizational policies and programs

**2025 Updates:**
- Multi-Factor Authentication (MFA) required for ALL access to cardholder data environment
- Risk-based approach: continuous monitoring instead of annual checks
- Quarterly security scan by Approved Scanning Vendor (ASV) mandatory

**PrTask Mitigation:** Use Stripe Connect to abstract from direct PCI compliance requirements. Stripe is PCI DSS Level 1 certified. Never store card data directly.

### 4.2 PSD2/PSD3 (EU Payment Services Directive)

- Platforms acting on behalf of buyers and sellers may need payment institution licensing
- Commercial agent exemption requirements tightening under PSD3 (expected 2026)
- Strong Customer Authentication (SCA) required for electronic payments
- **PrTask Mitigation:** Use Stripe Connect which handles PSD2/PSD3 compliance

### 4.3 Money Transmission Laws (US)

- State-by-state money transmitter licensing may apply to platforms facilitating payments
- **PrTask Mitigation:** Use Stripe Connect (Stripe holds money transmitter licenses)

### 4.4 Philippine Payment Regulations

- BSP (Bangko Sentral ng Pilipinas) supervision for fintech operations
- E-money issuer licensing for platforms facilitating payments
- **PrTask Mitigation:** Use licensed payment service provider

---

## 5. Tax Compliance

### 5.1 US -- IRS Form 1099-K

**Threshold (2025+):** More than USD 20,000 in gross payments AND more than 200 transactions per platform per payee per year.

**Requirements:**
- Collect W-9/W-8BEN from US/non-US payees respectively
- Issue 1099-K by January 31 for qualifying payees
- Report gross payments (not net of fees/refunds)
- Thresholds apply per platform (not aggregated across platforms)
- Backup withholding (24%) if TIN not provided

### 5.2 EU -- DAC7 (Directive on Administrative Cooperation)

**Effective:** January 1, 2023 (transposed into all EU member states)
**Applies when:** Digital platform facilitating relevant activities (including personal services) for consideration in the EU.

**Requirements:**
- Collect and verify seller information (name, address, TIN, date of birth, bank account)
- Report annually by January 31 for prior year activity
- Report to tax authority of the Member State where the platform is registered
- Covers: sale of goods, personal services, rental of immovable property, rental of transport
- Non-EU platforms must register in one EU Member State if facilitating EU activities
- Due diligence procedures on all reportable sellers

**Reportable Information:**
- Seller identification details
- Financial account identifier
- Each Member State of which seller is resident
- Total consideration paid per quarter
- Number of relevant activities per quarter
- Fees, commissions, or taxes withheld per quarter

### 5.3 Philippines -- VAT on Digital Services (RA 12023)

**Effective:** June 2, 2025
**Rate:** 12% VAT

**Requirements:**
- Registration via BIR VDS Portal for non-resident digital service providers
- Threshold: annual gross sales > PHP 3 million (~USD 55,000) to Philippine customers
- Compliant invoices in English with: transaction date, reference number, buyer ID, description, total including VAT
- B2B: Philippine customer withholds and remits 12% VAT
- B2C: non-resident DSP collects and remits 12% VAT

**Penalties:** Fines, suspension, or blocking of access to Philippine market.

### 5.4 OECD Model Reporting Rules for Digital Platforms

- Australia, Canada, New Zealand, UK use OECD-aligned reporting regimes
- Similar to DAC7 with jurisdiction-specific thresholds and deadlines
- Standardized DPI XML Schema for reporting

### 5.5 Other Tax Obligations

- **UK:** Digital Services Tax (2% on revenue from UK users if global revenue > GBP 500 million)
- **France:** Digital Services Tax (3% on digital services revenue from French users)
- **India:** Equalization Levy (repealed 2024, monitor for changes)
- **VAT/GST registration:** may be required in countries where services are consumed

---

## 6. Intellectual Property and DMCA

### 6.1 DMCA Safe Harbor (US -- 17 U.S.C. 512)

**Requirements for Safe Harbor Protection:**
1. Register designated DMCA agent with U.S. Copyright Office
2. Publish agent contact information on website
3. Implement and publish notice-and-takedown process
4. Implement counter-notification procedure
5. Adopt and reasonably implement repeat infringer policy
6. Accommodate standard technical measures
7. No actual or constructive knowledge of infringement
8. No direct financial benefit from infringing activity that platform can control
9. Expeditiously remove infringing material upon notification

**Takedown Notice Requirements (512(c)(3)):**
- Physical or electronic signature of copyright owner/agent
- Identification of copyrighted work
- Identification of infringing material with information sufficient to locate it
- Contact information of complaining party
- Good faith belief statement
- Statement of accuracy under penalty of perjury

**Counter-Notification Requirements:**
- Subscriber's signature
- Identification of removed material
- Statement under penalty of perjury that removal was by mistake or misidentification
- Consent to jurisdiction of federal court
- 10-14 business day putback timeline

### 6.2 EU Copyright Directive (Directive 2019/790)

- Article 17: platforms with user-uploaded content must obtain authorization or implement effective measures
- Complaint and redress mechanisms required
- Cooperation with rights holders

### 6.3 Code Ownership on PrTask

**Platform Terms Must Address:**
- Developers retain copyright to their code until bounty is paid
- Upon payment, client receives a license (define scope: exclusive/non-exclusive, perpetual, worldwide)
- Platform license to display/cache code for marketplace operations
- AI-generated code: developer must warrant they have rights to submit
- Open source license compliance requirements for submitted code

---

## 7. Consumer Protection

### 7.1 EU Digital Services Act (DSA)

**Effective:** February 17, 2024 for all in-scope services
**Applies when:** Providing intermediary services in the EU.

**Requirements for Online Marketplaces:**
- Seller/trader verification: collect and verify identity, contact details, and trader status
- Display seller contact details to consumers
- Illegal content removal mechanisms
- Transparent content moderation policies
- User complaint handling and appeal procedures
- Transparency reports (standardized templates from July 1, 2025)
- Non-EU platforms must appoint EU legal representative
- Annual systemic risk assessments (for VLOPs)
- Independent audits (for VLOPs)

**Penalties:** Up to 6% of global annual turnover.

### 7.2 EU Consumer Rights Directive

- **14-day withdrawal right** for online/distance contracts
- Exception for digital content/services if consumer gives explicit prior consent and acknowledges loss of withdrawal right
- Failure to inform about withdrawal right extends it to 1 year
- **June 2026:** "Cancel my contract" function required on websites/apps
- Pre-contractual information requirements (price, main characteristics, trader identity)

### 7.3 US -- INFORM Consumers Act

**Effective:** June 27, 2023
- Requires online marketplaces to collect, verify, and disclose information about high-volume third-party sellers
- High-volume = 200+ transactions or USD 5,000+ in revenue in a 12-month period
- Annual verification of high-volume sellers

### 7.4 EU General Product Safety Regulation (GPSR)

**Effective:** December 13, 2024
- Online marketplaces liable for ensuring products are safe and meet EU standards
- Not directly applicable to PrTask (software services, not physical products) but monitor for digital services expansion

---

## 8. Content Moderation

### 8.1 EU DSA Content Moderation Obligations

- Clear terms of service describing content moderation policies
- Information on algorithmic decision-making and human review processes
- Flagging mechanisms for illegal content
- Priority processing for notices from "trusted flaggers"
- Statement of reasons for every content moderation decision
- Internal complaint handling mechanism
- Access to out-of-court dispute settlement
- Transparency reporting on content moderation decisions
- Prohibit dark patterns in content moderation interfaces

### 8.2 General Requirements (All Jurisdictions)

- Mechanism to report illegal, harmful, or infringing content
- Timely review and action on reports
- Appeal process for affected users
- Transparent criteria for content removal
- Documentation of moderation decisions

---

## 9. Accessibility Requirements

### 9.1 European Accessibility Act (EAA)

**Effective:** June 28, 2025
**Standard:** EN 301 549 V3.2.1 (incorporating WCAG 2.1 AA); V4.1.1 with WCAG 2.2 AA planned for 2026

**Requirements:**
- Applies to companies selling products/services to EU customers
- Exemption only for micro-enterprises (<10 employees AND <EUR 2 million turnover)
- Website and web applications must conform to WCAG 2.1 Level AA minimum
- Mobile applications must also be accessible

### 9.2 US ADA (Americans with Disabilities Act)

**Standard:** WCAG 2.1 Level AA (ADA Title II finalized 2024); WCAG 2.2 AA for Section 508

**Requirements:**
- ADA Title III (private businesses): websites must be accessible to individuals with disabilities
- 5,000+ digital accessibility lawsuits filed in 2025 (20% increase year-over-year)
- No specific technical standard mandated for Title III, but courts consistently reference WCAG 2.1 AA

### 9.3 Section 508 (US Government)

- Applies to federal agencies and their contractors
- Updated to reference WCAG 2.2 AA as of 2024
- Relevant if PrTask contracts with US government entities

### 9.4 WCAG 2.2 Level AA Compliance Checklist

**Core Requirements:**
- Text alternatives for non-text content
- Captions and audio descriptions for media
- Adaptable content structure
- Distinguishable content (color contrast 4.5:1 minimum)
- Keyboard accessibility (all functionality)
- Sufficient time for user interactions
- No seizure-inducing content
- Navigable (page titles, focus order, link purpose)
- Readable text (language identified)
- Predictable behavior
- Input assistance (error identification, labels, suggestions)
- Compatible with assistive technologies

**New WCAG 2.2 Criteria (Level AA):**
- 2.4.11 Focus Not Obscured (Minimum)
- 2.4.13 Focus Appearance
- 2.5.7 Dragging Movements (alternatives provided)
- 2.5.8 Target Size (Minimum) -- 24x24 CSS pixels
- 3.2.6 Consistent Help (help mechanisms in same relative location)
- 3.3.7 Redundant Entry (don't require re-entering previously provided information)

---

## 10. Age Verification

### 10.1 General Requirements by Jurisdiction

| Jurisdiction | Minimum Age | Verification Required |
|-------------|-------------|----------------------|
| EU (GDPR) | 16 (or 13-16 per member state) | Parental consent for under-age |
| UK | 13 | Age-appropriate design code |
| US (COPPA) | 13 | Verifiable parental consent for <13 |
| Australia | 16 (social media ban, Dec 2025) | Age verification for social media |
| Philippines | 18 for contracts | Parental consent for minors |
| South Korea | 14 | Legal guardian consent for <14 |
| China | 14 | Guardian consent for <14, strict rules for <18 |
| Brazil | 18 for contracts (16 with parental consent) | Specific consent for children's data |

### 10.2 PrTask Implementation

- Minimum age of 18 for account creation (financial transactions require legal capacity)
- Age declaration at registration
- Terms of Service explicitly state minimum age requirement
- For EU: include age verification mechanism if under-16 data is processed

---

## 11. Dispute Resolution

### 11.1 EU Requirements

- **ODR Platform discontinued** July 20, 2025
- **ADR obligation remains**: sellers must inform consumers about willingness/obligation to participate in Alternative Dispute Resolution
- Must name responsible consumer arbitration board (name, address, website)
- Internal complaint handling mechanism required (DSA)
- Out-of-court dispute settlement access required (DSA)

### 11.2 International Arbitration

**Terms of Service Should Include:**
- Mandatory arbitration clause with opt-out period (30 days)
- Specification of arbitral institution (ICC, SIAC, HKIAC, etc.)
- Seat of arbitration
- Language of proceedings
- Class action waiver (where enforceable)
- Small claims exception (allow small claims court as alternative)
- Governing law selection

### 11.3 PrTask-Specific Dispute Resolution

- Internal dispute resolution for bounty disagreements (client vs developer)
- Escalation to platform mediation
- External arbitration as final step
- Clear criteria for bounty approval/rejection
- Evidence preservation requirements (PR history, commit logs, review comments)

---

## 12. AML/KYC Requirements

### 12.1 General AML Program Requirements

**Components:**
- Formal AML policy and procedures
- Designated Money Laundering Reporting Officer (MLRO)
- Customer Due Diligence (CDD) at onboarding
- Enhanced Due Diligence (EDD) for high-risk customers
- Ongoing transaction monitoring
- Suspicious Activity Reports (SARs) to relevant authority
- Record keeping (5+ years)
- Staff training and documentation
- Regular internal audits
- Risk-based approach to compliance

### 12.2 KYC Implementation for PrTask

**For Developers (Payees):**
- Identity verification before first payout (government-issued ID, selfie verification)
- Address verification
- Tax identification number collection (W-9/W-8BEN for US, equivalent for other countries)
- Bank account/payment method verification
- Periodic re-verification (perpetual KYC trend)

**For Clients (Payers):**
- Identity verification for accounts above transaction thresholds
- Business verification for corporate accounts (KYB: registration documents, ownership structure)
- Source of funds verification for large bounties

### 12.3 Philippine AMLA (RA 9160, as amended by RA 11521)

- Covered transactions: exceeding PHP 500,000 (~USD 8,940) per banking day
- Enhanced due diligence for high-risk customers and large transactions
- Anonymous accounts prohibited
- Record keeping for 5 years minimum
- Suspicious Transaction Reports to AMLC
- Penalties: PHP 100,000 to PHP 1,000,000 for individuals; PHP 500,000 per day for institutions

### 12.4 EU Anti-Money Laundering Directives (AMLD6)

- Risk-based approach to customer due diligence
- Beneficial ownership transparency
- Enhanced measures for high-risk third countries
- EU-wide AML Authority (AMLA) operational from 2025

---

## 13. Implementation Checklist

### Phase 1: Critical (Before Launch)

- [ ] Privacy Policy -- compliant with GDPR, CCPA, RA 10173, and all applicable laws
- [ ] Terms of Service -- with all required clauses for international marketplace
- [ ] Cookie Consent Banner -- opt-in for EU/UK, with granular category selection
- [ ] Cookie Policy -- detailed cookie inventory
- [ ] DMCA Policy -- with registered agent
- [ ] Refund Policy -- EU 14-day withdrawal compliance
- [ ] Acceptable Use Policy
- [ ] Accessibility Statement
- [ ] Data Processing Agreements with all third-party processors
- [ ] KYC/identity verification flow for developers before first payout
- [ ] Tax information collection (W-9/W-8BEN)
- [ ] Stripe Connect integration with PCI DSS compliance
- [ ] WCAG 2.1 Level AA audit
- [ ] Breach notification procedures documented
- [ ] Data subject rights request handling procedures

### Phase 2: Within 90 Days

- [ ] Register DMCA agent with U.S. Copyright Office
- [ ] Appoint Data Protection Officer (if required under GDPR/RA 10173)
- [ ] Records of Processing Activities (ROPA)
- [ ] Data Protection Impact Assessment for core processing activities
- [ ] DAC7 registration in EU Member State (if facilitating EU activities)
- [ ] Philippine BIR VDS Portal registration (if threshold met)
- [ ] EU legal representative appointment (if non-EU platform serving EU)
- [ ] DSA compliance: seller verification, transparency reporting setup
- [ ] Content moderation policy and appeal mechanism
- [ ] Internal dispute resolution process

### Phase 3: Within 6 Months

- [ ] Annual cybersecurity audit program
- [ ] AML transaction monitoring implementation
- [ ] Automated data subject rights request handling
- [ ] WCAG 2.2 Level AA upgrade
- [ ] Cookie consent records and audit trail
- [ ] Cross-border data transfer impact assessments
- [ ] Vendor/processor compliance audit program
- [ ] Incident response plan and tabletop exercises
- [ ] Accessibility audit by independent third party
- [ ] Privacy by design review of all features

### Phase 4: Ongoing

- [ ] Annual privacy policy review and update
- [ ] Quarterly security scans (PCI DSS ASV)
- [ ] DAC7/OECD reporting (by January 31 annually)
- [ ] 1099-K reporting (by January 31 annually)
- [ ] Annual DSA transparency reports
- [ ] Regular DPIA reviews for new features
- [ ] Staff privacy and security training
- [ ] Monitor regulatory changes across all jurisdictions
- [ ] Re-verification of seller/developer identities (perpetual KYC)

---

## 14. Domain Constants Reference

All legal page URLs, regulation names, and compliance strings should be defined as domain constants in the codebase. Below is the reference for constant naming:

```csharp
// PascalCase constants for all legal compliance strings

public static class LegalConstants
{
    // Page Routes
    public const string PrivacyPolicyRoute = "/Legal/Privacy";
    public const string TermsOfServiceRoute = "/Legal/Terms";
    public const string CookiePolicyRoute = "/Legal/CookiePolicy";
    public const string RefundPolicyRoute = "/Legal/Refund";
    public const string DmcaPolicyRoute = "/Legal/Dmca";
    public const string AcceptableUsePolicyRoute = "/Legal/AcceptableUse";
    public const string AccessibilityStatementRoute = "/Legal/Accessibility";
    public const string LicensesRoute = "/Legal/Licenses";

    // Regulation Names
    public const string GdprName = "General Data Protection Regulation (EU) 2016/679";
    public const string UkGdprName = "UK General Data Protection Regulation";
    public const string CcpaName = "California Consumer Privacy Act";
    public const string Ra10173Name = "Republic Act No. 10173 (Data Privacy Act of 2012)";
    public const string PipedaName = "Personal Information Protection and Electronic Documents Act";
    public const string LgpdName = "Lei Geral de Protecao de Dados (LGPD)";
    public const string AppiName = "Act on the Protection of Personal Information (APPI)";
    public const string PdpaSingaporeName = "Personal Data Protection Act 2012 (Singapore)";
    public const string PdpaThailandName = "Personal Data Protection Act B.E. 2562 (Thailand)";
    public const string PopiaName = "Protection of Personal Information Act (POPIA)";
    public const string AustralianPrivacyActName = "Privacy Act 1988 (Australia)";
    public const string DpdpActName = "Digital Personal Data Protection Act 2023 (India)";
    public const string PipaName = "Personal Information Protection Act (South Korea)";
    public const string PiplName = "Personal Information Protection Law (China)";
    public const string NzPrivacyActName = "Privacy Act 2020 (New Zealand)";
    public const string DsaName = "Digital Services Act (EU) 2022/2065";
    public const string EaaName = "European Accessibility Act (EU) 2019/882";
    public const string DmcaName = "Digital Millennium Copyright Act (17 U.S.C. 512)";
    public const string Dac7Name = "Council Directive (EU) 2021/514 (DAC7)";
    public const string AmlaPhName = "Anti-Money Laundering Act (RA 9160, as amended)";

    // Compliance Identifiers
    public const string DmcaAgentName = "PrTask DMCA Agent";
    public const string DmcaAgentEmail = "dmca@prtask.com";
    public const string DpoEmail = "dpo@prtask.com";
    public const string PrivacyEmail = "privacy@prtask.com";
    public const string LegalEmail = "legal@prtask.com";
    public const string AccessibilityEmail = "accessibility@prtask.com";

    // Consent Types
    public const string ConsentStrictlyNecessary = "StrictlyNecessary";
    public const string ConsentFunctional = "Functional";
    public const string ConsentAnalytics = "Analytics";
    public const string ConsentMarketing = "Marketing";

    // Data Subject Right Types
    public const string RightAccess = "Access";
    public const string RightRectification = "Rectification";
    public const string RightErasure = "Erasure";
    public const string RightPortability = "Portability";
    public const string RightRestriction = "Restriction";
    public const string RightObjection = "Objection";
    public const string RightWithdrawConsent = "WithdrawConsent";
    public const string RightDoNotSell = "DoNotSell";
    public const string RightLimitSensitive = "LimitSensitive";

    // Breach Notification Deadlines (hours)
    public const int GdprBreachNotificationHours = 72;
    public const int Ra10173BreachNotificationHours = 72;
    public const int NzBreachNotificationHours = 72;
    public const int CcpaBreachNotificationDays = 45;

    // Data Retention
    public const int DefaultRetentionYears = 5;
    public const int AmlRecordRetentionYears = 5;
    public const int BreachRecordRetentionMonths = 24;

    // Age Requirements
    public const int MinimumAccountAge = 18;
    public const int GdprMinimumConsentAge = 16;
    public const int CoppaMinimumAge = 13;

    // Financial Thresholds
    public const decimal CcpaRevenueThresholdUsd = 26_625_000m;
    public const int CcpaConsumerThreshold = 100_000;
    public const decimal Us1099KThresholdUsd = 20_000m;
    public const int Us1099KTransactionThreshold = 200;
    public const decimal PhAmlaThresholdPhp = 500_000m;
    public const decimal PhVatThresholdPhp = 3_000_000m;
    public const decimal PhVatRate = 0.12m;
}
```

---

## Sources

### GDPR
- [GDPR Compliance 2026 Guide](https://secureprivacy.ai/blog/gdpr-compliance-2026)
- [GDPR.eu Official Resource](https://gdpr.eu/)
- [GDPR Requirements 2026 - Sprinto](https://sprinto.com/blog/gdpr-requirements/)
- [GDPR Fines Enforcement Guide 2025](https://complydog.com/blog/gdpr-fines-penalties-2025-enforcement-guide)

### CCPA/CPRA
- [CCPA Requirements 2026 Complete Guide](https://secureprivacy.ai/blog/ccpa-requirements-2026-complete-compliance-guide)
- [CCPA Privacy Policy Requirements 2025](https://secureprivacy.ai/blog/ccpa-privacy-policy-requirements-2025)
- [California Privacy Protection Agency](https://cppa.ca.gov/faq.html)
- [CCPA 2026 Expanded Requirements - Lathrop GPM](https://www.lathropgpm.com/insights/ccpa-2026-navigating-the-expanded-consumer-privacy-compliance-requirements-for-businesses/)

### Philippines RA 10173
- [National Privacy Commission](https://privacy.gov.ph/data-privacy-act/)
- [Data Privacy Act Philippines Guide](https://secureprivacy.ai/blog/data-privacy-act-2012-philippines-guide)
- [Republic Act 10173 - Clym](https://www.clym.io/regulations/republic-act-no-10173-philippines)

### PIPEDA (Canada)
- [PIPEDA Requirements - OPC](https://www.priv.gc.ca/en/privacy-topics/privacy-laws-in-canada/the-personal-information-protection-and-electronic-documents-act-pipeda/pipeda_brief/)
- [PIPEDA Compliance 2026 Guide](https://geotargetly.com/blog/pipeda-compliance-guide-to-canada-privacy-law)
- [PIPEDA SaaS Compliance Guide](https://complydog.com/blog/pipeda-compliance-guide-canadian-privacy-law-saas-companies)

### LGPD (Brazil)
- [LGPD Brazil Official](https://lgpd-brazil.info/)
- [LGPD SaaS Compliance Guide](https://complydog.com/blog/brazil-lgpd-complete-data-protection-compliance-guide-saas)
- [LGPD Website Compliance - Lawwwing](https://lawwwing.com/en/is-your-website-lgpd-compliant-a-guide-for-digital-businesses-in-brazil/)

### APPI (Japan)
- [APPI Japan Compliance Guide 2026](https://secureprivacy.ai/blog/appi-japan-privacy-compliance)
- [APPI Data Protection Guide](https://www.privacyengine.io/blog/japans-appi-data-protection-law/)

### PDPA Singapore
- [PDPC Overview](https://www.pdpc.gov.sg/overview-of-pdpa/the-legislation/personal-data-protection-act)
- [PDPA Obligations Singapore](https://www.dpo-consulting.com/blog/pdpa-obligations-singapore)

### PDPA Thailand
- [PDPA Thailand 2025 Guide](https://www.pdpa.guide/)
- [Thailand PDPA Explained - Termly](https://termly.io/resources/articles/thailands-personal-data-protection-act/)

### POPIA (South Africa)
- [POPIA Official](https://popia.co.za/)
- [POPIA Compliance Checklist - Securiti](https://securiti.ai/blog/popia-compliance-checklist/)

### Australia Privacy Act
- [Australia Privacy Act Reforms 2025](https://secureprivacy.ai/blog/what-australia-privacy-act-reforms-mean-for-your-business-2025)
- [Privacy in Australia 2025-2026](https://www.spruson.com/privacy-in-australia-reflecting-on-2025-and-tips-for-preparing-for-2026/)

### UK DPA 2018
- [UK GDPR Guidance - ICO](https://ico.org.uk/for-organisations/uk-gdpr-guidance-and-resources/)
- [UK DPA 2018 Explained](https://www.dpo-consulting.com/blog/uk-data-protection-act-explained)

### India DPDP Act
- [DPDP Act Explained - FPF](https://fpf.org/blog/the-digital-personal-data-protection-act-of-india-explained/)
- [India Data Protection - DLA Piper](https://www.dlapiperdataprotection.com/?t=law&c=IN)

### South Korea PIPA
- [PIPA Updates 2025](https://crossborderadvisorysolutions.com/personal-information-protection-act-pipa-updates-2025/)
- [South Korea PIPA Guide - Didomi](https://www.didomi.io/blog/south-korea-pipa-everything-you-need-to-know)

### China PIPL
- [PIPL Compliance Guide - China Briefing](https://www.china-briefing.com/doing-business-guide/china/company-establishment/pipl-personal-information-protection-law)
- [PIPL Compliance Checklist - Securiti](https://securiti.ai/blog/pipl-compliance-checklist/)

### New Zealand Privacy Act
- [Privacy Act 2020 Legislation](https://www.legislation.govt.nz/act/public/2020/0031/latest/LMS23223.html)
- [NZ Privacy Principles](https://www.privacy.org.nz/privacy-principles/)

### Cookie Consent
- [Cookie Consent Trends 2026 - CookieYes](https://www.cookieyes.com/blog/cookie-consent-trends/)
- [Cookie Banner Requirements by Country 2026](https://privacychecker.pro/blog/cookie-banner-requirements-by-country)
- [GDPR Cookie Consent 2025](https://secureprivacy.ai/blog/gdpr-cookie-consent-requirements-2025)

### DMCA
- [DMCA Compliance Checklist 2025](https://patentpc.com/blog/the-complete-dmca-compliance-checklist-for-online-platforms-in-2025)
- [Section 512 Resources - Copyright Office](https://www.copyright.gov/512/)
- [DMCA Safe Harbor - Copyright Alliance](https://copyrightalliance.org/education/copyright-law-explained/the-digital-millennium-copyright-act-dmca/dmca-safe-harbor/)

### EU Digital Services Act
- [DSA Official - European Commission](https://digital-strategy.ec.europa.eu/en/policies/digital-services-act)
- [DSA Compliance Guide - Tipalti](https://tipalti.com/en-eu/resources/learn/dsa-compliance/)
- [EU Content Moderation Regulation - ITIF](https://itif.org/publications/2025/05/14/eu-content-moderation-regulation/)

### Consumer Protection
- [EU Consumer Rights Directive - Returns](https://europa.eu/youreurope/citizens/consumers/shopping/returns/index_en.htm)
- [EU Consumer Guarantees](https://europa.eu/youreurope/business/dealing-with-customers/consumer-contracts-guarantees/consumer-guarantees/index_en.htm)
- [INFORM Consumers Act](https://www.mytotalretail.com/article/the-inform-consumers-act-a-must-know-for-online-marketplaces/)

### AML/KYC
- [AML Requirements for Payment Processors - Fenergo](https://resources.fenergo.com/blogs/aml-requirements-for-payment-processors)
- [AML/KYC Philippines 2025 - Sumsub](https://sumsub.com/blog/aml-kyc-in-the-philippines/)
- [KYC for Freelancing Platforms - Shufti Pro](https://shuftipro.com/blog/why-do-freelancing-platforms-need-kyc/)

### Payment Compliance
- [PCI DSS 2025 - Shopware](https://www.shopware.com/en/news/pci-dss-2025/)
- [Stripe PCI Compliance Guide](https://stripe.com/guides/pci-compliance)
- [PSD3 Guide - Stripe](https://stripe.com/guides/what-platforms-and-marketplaces-can-expect-from-psd3)

### Tax Compliance
- [DAC7 - European Commission](https://taxation-customs.ec.europa.eu/taxation/tax-transparency-cooperation/administrative-co-operation-and-mutual-assistance/dac7_en)
- [OECD Model Reporting Rules](https://www.oecd.org/en/topics/sub-issues/international-tax-compliance-policies-and-best-practices/model-reporting-rules-for-digital-platforms.html)
- [Philippines VAT on Digital Services - BIR RR 3-2025](https://www.taxumo.com/blog/understanding-bir-revenue-regulations-3-2025-and-14-2025-vat-on-digital-services-in-the-philippines/)
- [IRS Form 1099-K](https://www.irs.gov/businesses/understanding-your-form-1099-k)

### Accessibility
- [Accessibility Testing 2026 Guide](https://www.vervali.com/blog/accessibility-testing-services-in-2026-the-complete-guide-to-wcag-2-2-ada-section-508-and-eaa-compliance/)
- [EAA 2025 Key Requirements](https://www.adacompliancepros.com/blog/eaa-2025-key-accessibility-requirements-for-businesses)
- [WCAG 2.2 Complete Guide](https://www.allaccessible.org/blog/wcag-22-complete-guide-2025)

### Age Verification
- [Age Verification Laws 2025 Update](https://shuftipro.com/blog/age-verification-laws-2025-update/)
- [Age Verification in Europe](https://www.euronews.com/next/2025/11/17/the-age-verification-era-which-eu-countries-are-restricting-access-to-adult-sites)

### Dispute Resolution
- [OECD Online Dispute Resolution Framework](https://www.oecd.org/content/dam/oecd/en/publications/reports/2024/10/oecd-online-dispute-resolution-framework_e88b6c6a/325e6edc-en.pdf)

### Global Privacy Overview
- [Data Protection Laws of the World](https://www.dlapiperdataprotection.com/)
- [Privacy Laws 2026 Global Guide](https://secureprivacy.ai/blog/privacy-laws-2026)
- [Global Privacy Developments 2025-2026](https://www.mcdonaldhopkins.com/insights/news/u-s-and-international-data-privacy-developments-in-2025-and-compliance-considerations-for-2026)
