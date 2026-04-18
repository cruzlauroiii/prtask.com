// Generate JSON translation files for all 13 languages (321 missing keys each)
const fs = require('fs');
const path = require('path');

const outDir = '/tmp/translations';
if (!fs.existsSync(outDir)) fs.mkdirSync(outDir, { recursive: true });

// All translations organized by language
const translations = {};

// ===================== CHINESE (zh) =====================
translations.zh = {
"AboutAcceptableUseLinkText": "\u53ef\u63a5\u53d7\u4f7f\u7528\u653f\u7b56",
"AboutAccessibilityLinkText": "\u65e0\u969c\u788d\u58f0\u660e",
"AboutAchievementsDescription": "\u6bcf\u4e2a\u5408\u5e76\u7684 PR \u90fd\u4f1a\u6839\u636e\u91cc\u7a0b\u7891\u83b7\u5f97\u6210\u5c31\u5fbd\u7ae0\u3002\u89e3\u9501\u60a8\u7684\u7b2c\u4e00\u4e2a PR\u3001\u7b2c\u5341\u4e2a PR\u3001\u6536\u5165\u91cc\u7a0b\u7891\u548c\u6392\u884c\u699c\u9876\u7ea7\u4f4d\u7f6e\u7684\u5fbd\u7ae0\u3002\u5728\u6309\u603b\u6536\u5165\u6392\u540d\u7684\u516c\u5171\u6392\u884c\u699c\u4e0a\u7ade\u4e89\u3002\u6240\u6709\u62c9\u53d6\u8bf7\u6c42\u90fd\u662f\u516c\u5f00\u7684\u3002",
"AboutAchievementsHeading": "\u6210\u5c31\u5fbd\u7ae0",
"AboutCommunityDescription": "PrTask \u9a71\u52a8\u7740\u4e00\u4e2a\u84ec\u52c3\u53d1\u5c55\u7684\u5168\u7403\u5f00\u53d1\u8005\u548c\u5ba2\u6237\u793e\u533a\uff0c\u8de8\u8d8a\u56fd\u754c\u548c\u65f6\u533a\u534f\u4f5c\uff0c\u5171\u540c\u6784\u5efa\u66f4\u597d\u7684\u8f6f\u4ef6\u3002",
"AboutCommunityHeading": "\u793e\u533a\u5f71\u54cd\u529b"
};

// I need to write all 321 keys. Let me use a more efficient approach.
// Rather than escape every character, I'll write the translations directly.

// Actually, let me write the translations using a template approach.
// For keys that are identical across languages (like brand names, versions, technical terms),
// I can share them.

// Universal keys (same in all languages)
const universal = {
  "AboutStatCountries": "85+",
  "AboutStatDevelopersActive": "3,200+",
  "AboutStatTasksCompleted": "12,500+",
  "AboutStatTotalPaid": "$2.4M+",
  "BoardDeleteColumnButtonText": "x",
  "DeploymentPreviewPlatformValue": "Cloudflare Pages",
  "DownloadCurrentVersion": "1.0.0",
  "DownloadIosHeading": "iOS",
  "DownloadLinuxHeading": "Linux",
  "DownloadMacosHeading": "macOS",
  "SettingsProviderGitHubLabel": "GitHub",
  "SettingsProviderGoogleLabel": "Google",
  "SettingsProviderMicrosoftLabel": "Microsoft",
  "SettingsProviderOktaLabel": "Okta",
  "SettingsPayoutPaypalLabel": "PayPal",
  "SettingsTimezoneUtcLabel": "UTC",
  "SettingsTimezoneLondonLabel": "London (GMT+0)",
  "SettingsTimezoneManilaLabel": "Asia/Manila (GMT+8)",
  "SettingsTimezoneNewYorkLabel": "Eastern Time (GMT-5)",
  "PricingClientFeature2": "",  // Will be set per-language below
};

// Write the complete translations for all languages
// This function builds the full 321-key translation object for a language
function buildTranslations(lang, t) {
  // Add universal keys
  const result = { ...t };
  for (const [k, v] of Object.entries(universal)) {
    if (!result[k] && v) result[k] = v;
  }
  return result;
}

// Due to the extreme size requirements, I'll write a helper that creates
// the translation files by reading existing data and filling gaps

const resDir = path.join('C:', 'work', 'prtask.com', 'src', 'PrTask.SharedUI', 'Resources');

function readResx(fp) {
  const content = fs.readFileSync(fp, 'utf-8');
  const entries = {};
  const re = /<data name="([^"]+)" xml:space="preserve"><value>([\s\S]*?)<\/value><\/data>/g;
  let m;
  while ((m = re.exec(content)) !== null) entries[m[1]] = m[2];
  return entries;
}

const en = readResx(path.join(resDir, 'SharedResource.resx'));
const allKeys = Object.keys(en).sort();
const zh = readResx(path.join(resDir, 'SharedResource.zh.resx'));
const existingKeys = new Set(Object.keys(zh));
const missingKeys = allKeys.filter(k => !existingKeys.has(k));

console.log(`Total English keys: ${allKeys.length}`);
console.log(`Missing keys: ${missingKeys.length}`);

// Output missing keys with their English values
const missingEn = {};
missingKeys.forEach(k => missingEn[k] = en[k]);
fs.writeFileSync(path.join(outDir, 'missing_keys.json'), JSON.stringify(missingEn, null, 2));
console.log('Written missing_keys.json');

// Output the list of missing keys
fs.writeFileSync(path.join(outDir, 'missing_keys_list.txt'), missingKeys.join('\n'));
console.log('Written missing_keys_list.txt');
console.log('Done. Use these files to generate per-language translation JSONs.');
