namespace CybersecurityChatbot
{
    public class SecurityKnowledgeBase
    {
        public string GetPasswordSecurity()
        {
            return @"
🔐 STRONG PASSWORD PRACTICES:

✓ DO:
  • Use at least 12 characters (longer is better)
  • Mix uppercase, lowercase, numbers, and special characters
  • Use unique passwords for each account
  • Use a password manager (1Password, Bitwarden, LastPass)
  • Change passwords if you suspect a breach
  • Enable two-factor authentication for added security

✗ DON'T:
  • Use personal information (name, birthdate, pet names)
  • Reuse passwords across multiple sites
  • Share passwords with anyone
  • Write passwords on sticky notes
  • Use simple patterns (123456, password, qwerty)
  • Include dictionary words

💡 Example of a strong password:
   Tr0pic@l$Sunset#2024xyz

For more help, ask about 'two-factor authentication' or '2FA'";
        }

        public string GetPhishingAwareness()
        {
            return @"
🎣 PHISHING AWARENESS:

Phishing is a social engineering attack where attackers impersonate legitimate 
organizations to steal your credentials or sensitive information.

⚠️ WARNING SIGNS OF PHISHING:
  • Requests to verify personal or financial information
  • Urgent language ('Act now!' or 'Confirm immediately')
  • Mismatched or suspicious email addresses
  • Generic greetings ('Dear Customer' instead of your name)
  • Spelling and grammar errors
  • Suspicious links (hover to check URL)
  • Attachments from unexpected sources
  • Pressure to click links or download files

✓ HOW TO PROTECT YOURSELF:
  1. Verify sender's email address carefully
  2. Don't click links - go directly to the website instead
  3. Check if the URL matches the organization's domain
  4. Look for HTTPS and padlock icon
  5. Report suspicious emails to IT security
  6. Never download attachments from unknown senders
  7. Use email filters and security software

🛡️ REMEMBER: Real companies won't ask for passwords via email!";
        }

        public string GetMalwareProtection()
        {
            return @"
🛡️ MALWARE PROTECTION:

Malware is malicious software designed to harm your computer and steal data.
Types: viruses, trojans, ransomware, spyware, adware, worms.

✓ PROTECTION STRATEGIES:
  1. Install reputable antivirus/anti-malware software
  2. Keep software and operating systems updated
  3. Use a firewall
  4. Don't download files from untrusted sources
  5. Be cautious with email attachments
  6. Avoid clicking suspicious ads or links
  7. Use browser extensions that block malware
  8. Regularly scan your system
  9. Back up important data regularly
  10. Use strong passwords

⚠️ SIGNS YOUR DEVICE MAY BE INFECTED:
  • Slower than usual performance
  • Frequent crashes or freezing
  • Unexpected pop-ups
  • New toolbars or search engines
  • Unusual network activity
  • High disk/CPU usage
  • Disabled antivirus software

🆘 IF INFECTED:
  1. Disconnect from the internet
  2. Run antivirus in Safe Mode
  3. Seek professional IT support
  4. Change passwords from a clean device";
        }

        public string GetTwoFactorAuthentication()
        {
            return @"
🔐 TWO-FACTOR AUTHENTICATION (2FA):

2FA adds an extra layer of security by requiring two forms of verification:
1. Something you know (password)
2. Something you have (phone, security key) or are (fingerprint)

📱 COMMON 2FA METHODS:
  ✓ SMS Text Messages - Code sent to your phone
  ✓ Authenticator Apps - Google Authenticator, Authy, Microsoft Authenticator
  ✓ Hardware Security Keys - Physical keys (YubiKey, etc.)
  ✓ Biometric - Fingerprint or facial recognition
  ✓ Email Verification - Code sent to email

✅ BENEFITS:
  • Protects against password breaches
  • Prevents unauthorized access even if password is compromised
  • Adds minimal inconvenience
  • Works across most platforms

🎯 BEST PRACTICES:
  1. Enable 2FA on email, banking, and social media accounts
  2. Use authenticator apps instead of SMS when possible (more secure)
  3. Save backup codes in a secure location
  4. Keep your phone secure
  5. Update contact information regularly

💡 Start with your most important accounts:
   Email → Online Banking → Social Media → Work Accounts";
        }

        public string GetSocialEngineering()
        {
            return @"
🎭 SOCIAL ENGINEERING AWARENESS:

Social engineering exploits human psychology to manipulate people into 
divulging confidential information or performing security-compromising actions.

🚩 COMMON TACTICS:
  1. PRETEXTING - Creating false scenarios to build trust
  2. PHISHING - Fraudulent emails pretending to be legitimate
  3. BAITING - Offering something enticing to lure victims
  4. TAILGATING - Following authorized personnel through secure doors
  5. QUID PRO QUO - Offering service in exchange for information
  6. VISHING - Voice phishing (phone calls)

⚠️ RED FLAGS:
  • Requests for passwords or sensitive information
  • Creating urgency or fear ('Your account will be closed!')
  • Excessive flattery or appeals to authority
  • Requests to bypass security procedures
  • Offers that seem too good to be true
  • Unexpected contact from 'support' or 'IT'

✓ HOW TO RESPOND:
  1. Stay calm and think before acting
  2. Verify the person's identity independently
  3. Never provide sensitive information over the phone unless YOU initiated the call
  4. Consult your manager or IT security team
  5. Report suspicious activity
  6. Ask detailed questions about their request
  7. Follow your organization's security policies

🛡️ REMEMBER: 
   Security is everyone's responsibility. When in doubt, ask your IT department!";
        }

        public string GetVPNSecurity()
        {
            return @"
🌐 VPN (VIRTUAL PRIVATE NETWORK) SECURITY:

A VPN encrypts your internet connection and masks your IP address, protecting
your privacy and security, especially on public networks.

✅ BENEFITS OF USING A VPN:
  • Encrypts all data transmitted between your device and VPN server
  • Masks your real IP address
  • Protects on public WiFi networks
  • Prevents ISP from seeing your browsing activity
  • Helps protect against man-in-the-middle attacks
  • Provides anonymity online

🔍 CHOOSING A VPN:
  ✓ Look for:
    - Strong encryption (256-bit AES)
    - No-logs policy
    - Multiple server locations
    - Good customer reviews
    - Reputable company
  
  ✗ Avoid:
    - Free VPNs (may log data or inject ads)
    - Unknown providers
    - Services with unclear privacy policies

⚠️ WHEN TO USE A VPN:
  • Public WiFi (cafes, airports, hotels)
  • Traveling internationally
  • Using untrusted networks
  • Accessing work files remotely
  • Banking or shopping online

💡 POPULAR VPN PROVIDERS:
   ExpressVPN, NordVPN, ProtonVPN, Mullvad, Surfshark

🛡️ REMEMBER: A VPN adds security but doesn't replace other protections!";
        }

        public string GetDataBackup()
        {
            return @"
💾 DATA BACKUP & RECOVERY BEST PRACTICES:

Regular backups protect your data from ransomware, hardware failure, 
accidental deletion, and other disasters.

📋 THE 3-2-1 BACKUP RULE:
  3 - Keep 3 copies of important data
  2 - Store on 2 different types of media (HDD, cloud, etc.)
  1 - Keep 1 copy offsite (cloud or external location)

✅ BACKUP METHODS:
  1. CLOUD BACKUP - Google Drive, OneDrive, Dropbox, iCloud
     Pros: Automatic, accessible anywhere
     Cons: Requires internet, privacy concerns
  
  2. EXTERNAL HARD DRIVE - USB or Thunderbolt drives
     Pros: Fast, portable, affordable
     Cons: Can be lost or damaged
  
  3. NAS (Network Attached Storage) - Home/office network storage
     Pros: Multiple backups, networked access
     Cons: Initial cost, requires setup

🎯 BACKUP FREQUENCY:
  • Daily for critical files
  • Weekly for documents and projects
  • Monthly for complete system backups

⚠️ IMPORTANT REMINDERS:
  ✓ Test your backups regularly
  ✓ Encrypt sensitive backups
  ✓ Store external drives in a secure location
  ✓ Keep cloud accounts secure with 2FA
  ✓ Document your backup procedures
  ✓ Maintain backups during and after cyber incidents

🆘 RANSOMWARE PROTECTION:
   Keep one backup disconnected from your network at all times!";
        }

        public string GetPublicWifiSecurity()
        {
            return @"
📡 PUBLIC WIFI SECURITY:

Public WiFi networks in cafes, airports, and hotels are convenient but 
pose significant security risks. Here's how to stay safe.

⚠️ RISKS OF PUBLIC WIFI:
  • Man-in-the-middle attacks
  • Unencrypted data interception
  • Malware distribution
  • Rogue access points ('Evil Twin')
  • Packet sniffing
  • Credential theft

✓ SAFETY TIPS:
  1. USE A VPN - Essential protection
     Encrypts all traffic to a secure server
  
  2. DISABLE AUTO-CONNECT
     Turn off automatic WiFi connection
  
  3. TURN OFF FILE SHARING
     Disable file sharing and AirDrop on your device
  
  4. USE HTTPS ONLY
     Only visit websites with HTTPS (padlock icon)
  
  5. AVOID SENSITIVE TRANSACTIONS
     Don't do banking or shopping on public WiFi
  
  6. UPDATE FIREWALL
     Enable your device's built-in firewall
  
  7. DISABLE BLUETOOTH
     Turn off Bluetooth when not needed
  
  8. USE STRONG AUTHENTICATION
     Enable 2FA on important accounts
  
  9. VERIFY THE NETWORK
     Confirm WiFi name with establishment staff
  
  10. USE MOBILE HOTSPOT
      Your phone's hotspot is often safer than public WiFi

🛡️ BEST PRACTICE:
   When using public WiFi, assume nothing is private without a VPN!";
        }
    }
}