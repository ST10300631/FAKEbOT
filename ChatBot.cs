using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityChatbot
{
    public class ChatBot
    {
        private SecurityKnowledgeBase knowledgeBase;
        private List<string> conversationHistory;

        public ChatBot()
        {
            knowledgeBase = new SecurityKnowledgeBase();
            conversationHistory = new List<string>();
        }

        public string GetResponse(string userInput)
        {
            string lowerInput = userInput.ToLower().Trim();
            conversationHistory.Add(userInput);

            // Handle help command
            if (lowerInput == "help")
                return GetHelpMessage();

            // Handle specific security topics
            if (lowerInput.Contains("password"))
                return knowledgeBase.GetPasswordSecurity();

            if (lowerInput.Contains("phishing"))
                return knowledgeBase.GetPhishingAwareness();

            if (lowerInput.Contains("malware"))
                return knowledgeBase.GetMalwareProtection();

            if (lowerInput.Contains("two-factor") || lowerInput.Contains("2fa"))
                return knowledgeBase.GetTwoFactorAuthentication();

            if (lowerInput.Contains("social engineering"))
                return knowledgeBase.GetSocialEngineering();

            if (lowerInput.Contains("vpn"))
                return knowledgeBase.GetVPNSecurity();

            if (lowerInput.Contains("backup") || lowerInput.Contains("data loss"))
                return knowledgeBase.GetDataBackup();

            if (lowerInput.Contains("public wifi") || lowerInput.Contains("wifi"))
                return knowledgeBase.GetPublicWifiSecurity();

            if (lowerInput.Contains("tip") || lowerInput.Contains("suggest"))
                return GetRandomSecurityTip();

            if (lowerInput.Contains("quiz"))
                return GetSecurityQuiz();

            // Default response for unrecognized input
            return "I'm not sure about that topic. Try asking about: password, phishing, malware, " +
                   "two-factor authentication, social engineering, VPN, backup, or wifi security. " +
                   "Type 'help' for more options.";
        }

        private string GetHelpMessage()
        {
            return @"
Available Topics:
  • PASSWORD      - Learn about strong password practices
  • PHISHING      - Understand phishing attack prevention
  • MALWARE       - Know how to protect against malware
  • 2FA           - Two-factor authentication importance
  • SOCIAL ENGINEERING - Recognize manipulation tactics
  • VPN           - Virtual Private Network benefits
  • BACKUP        - Data backup best practices
  • PUBLIC WIFI   - Stay safe on public networks
  • TIP           - Get a random security tip
  • QUIZ          - Test your security knowledge

Type any of these keywords in your question to learn more.";
        }

        private string GetRandomSecurityTip()
        {
            List<string> tips = new List<string>
            {
                "🔒 Use unique passwords for each online account. Consider using a password manager.",
                "🎣 Never click links or download attachments from unknown senders.",
                "🔐 Enable two-factor authentication (2FA) on all important accounts.",
                "🌐 Never enter sensitive information on unsecured websites (check for HTTPS).",
                "📱 Keep your devices updated with the latest security patches.",
                "🚨 Be skeptical of urgent requests for personal information.",
                "🔒 Use a password manager to generate and store strong passwords securely.",
                "⚠️ Verify the sender's email address before responding to requests.",
                "🛡️ Install and maintain updated antivirus software.",
                "🔄 Regularly backup your important data to an external drive or cloud service."
            };

            Random random = new Random();
            return tips[random.Next(tips.Count)];
        }

        private string GetSecurityQuiz()
        {
            return @"
🎯 SECURITY QUIZ - Answer the following:

Q: What should you do if you receive a suspicious email asking for your password?
A) Reply with your password
B) Click the link in the email
C) Report it and do NOT click any links or provide information
D) Forward it to friends

Correct Answer: C

Did you know? Most security breaches start with a single phishing email. 
Always verify unusual requests before providing sensitive information.

Want to learn more? Ask about: phishing, password, or social engineering.";
        }
    }
}