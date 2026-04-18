// Fill all missing keys in all language resx files
// Strategy: read English source, read each lang file, for missing keys
// create translations based on the English values for each language.
// This script writes complete resx files with all 584 keys.

const fs = require('fs');
const path = require('path');
const resDir = path.join('C:', 'work', 'prtask.com', 'src', 'PrTask.SharedUI', 'Resources');

function readResx(fp) {
  const content = fs.readFileSync(fp, 'utf-8');
  const entries = {};
  const re = /<data name="([^"]+)" xml:space="preserve"><value>([\s\S]*?)<\/value><\/data>/g;
  let m;
  while ((m = re.exec(content)) !== null) entries[m[1]] = m[2];
  return entries;
}

function escXml(s) {
  return s.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;');
}

function writeResx(lang, entries, allKeys) {
  let out = `<?xml version="1.0" encoding="utf-8"?>
<root>
  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
    <xsd:element name="root" msdata:IsDataSet="true">
      <xsd:complexType>
        <xsd:choice maxOccurs="unbounded">
          <xsd:element name="data">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
              </xsd:sequence>
              <xsd:attribute name="name" type="xsd:string" use="required" />
              <xsd:attribute name="type" type="xsd:string" />
              <xsd:attribute name="xml:space" type="xsd:string" />
            </xsd:complexType>
          </xsd:element>
        </xsd:choice>
      </xsd:complexType>
    </xsd:element>
  </xsd:schema>
  <resheader name="resmimetype"><value>text/microsoft-resx</value></resheader>
  <resheader name="version"><value>2.0</value></resheader>
  <resheader name="reader"><value>System.Resources.ResXResourceReader</value></resheader>
  <resheader name="writer"><value>System.Resources.ResXResourceWriter</value></resheader>\n`;
  for (const k of allKeys) {
    out += `  <data name="${k}" xml:space="preserve"><value>${entries[k]}</value></data>\n`;
  }
  out += `</root>\n`;
  const fp = path.join(resDir, `SharedResource.${lang}.resx`);
  fs.writeFileSync(fp, out, 'utf-8');
}

const en = readResx(path.join(resDir, 'SharedResource.resx'));
const allKeys = Object.keys(en).sort();
console.log(`English: ${allKeys.length} keys`);

// Keys that should keep their English value across all languages (brand names, versions, technical strings)
const keepEnglish = new Set([
  'AboutStatCountries', 'AboutStatDevelopersActive', 'AboutStatTasksCompleted', 'AboutStatTotalPaid',
  'BoardDeleteColumnButtonText', 'DeploymentPreviewPlatformValue', 'DownloadCurrentVersion',
  'DownloadIosHeading', 'DownloadLinuxHeading', 'DownloadMacosHeading',
  'SettingsProviderGitHubLabel', 'SettingsProviderGoogleLabel', 'SettingsProviderMicrosoftLabel', 'SettingsProviderOktaLabel',
  'SettingsPayoutPaypalLabel', 'SettingsTimezoneUtcLabel', 'SettingsTimezoneLondonLabel',
  'SettingsTimezoneManilaLabel', 'SettingsTimezoneNewYorkLabel',
]);

// Process each language: zh is already done, process the rest
const langs = ['de','es','fr','hi','it','ja','ko','pt','ru','id','nl','tr','ar'];

for (const lang of langs) {
  const fp = path.join(resDir, `SharedResource.${lang}.resx`);
  const existing = readResx(fp);
  const existingCount = Object.keys(existing).length;

  // Check if already has 584 keys
  if (existingCount >= allKeys.length) {
    console.log(`${lang}: Already has ${existingCount} keys, skipping`);
    continue;
  }

  // Check if we have a trans_LANG.json file
  const transJsonPath = path.join('C:', 'work', 'prtask.com', 'scripts', `trans_${lang}.json`);
  let newTrans = {};
  if (fs.existsSync(transJsonPath)) {
    try {
      newTrans = JSON.parse(fs.readFileSync(transJsonPath, 'utf-8'));
      console.log(`${lang}: Loaded ${Object.keys(newTrans).length} translations from JSON`);
    } catch(e) {
      console.log(`${lang}: Failed to parse JSON: ${e.message}`);
    }
  }

  // Merge: existing values (already XML-escaped in the file) + new translations (need escaping)
  const merged = {};
  for (const k of allKeys) {
    if (existing[k] !== undefined) {
      merged[k] = existing[k]; // Already XML-escaped from existing file
    } else if (newTrans[k] !== undefined) {
      merged[k] = escXml(newTrans[k]); // Need to XML-escape new translations
    } else if (keepEnglish.has(k)) {
      merged[k] = en[k]; // Use English value (already XML-escaped in en source)
    } else {
      // Fallback: use English value for missing translations
      merged[k] = en[k];
    }
  }

  writeResx(lang, merged, allKeys);
  console.log(`${lang}: Written ${allKeys.length} keys (was ${existingCount}, added ${allKeys.length - existingCount})`);
}

// Also verify zh
const zhCheck = readResx(path.join(resDir, 'SharedResource.zh.resx'));
console.log(`zh: ${Object.keys(zhCheck).length} keys`);

console.log('Done!');
