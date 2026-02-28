using System;

namespace StringProcessingApp.Services
{
    public class StringService
    {
        private string originalText = string.Empty;
        private string currentText = string.Empty;

        public void SetText(string text)
        {
            originalText = text;
            currentText = text;
        }

        public string GetText() => currentText;

        public string ToUppercase() => currentText.ToUpper();

        public string ToLowercase() => currentText.ToLower();

        public int CountCharacters() => currentText.Length;

        public bool ContainsWord(string word) => currentText.Contains(word);

        public string ReplaceWord(string oldWord, string newWord) =>
            currentText.Replace(oldWord, newWord);

        public string ExtractSubstring(int startIndex, int length) =>
            currentText.Substring(startIndex, length);

        public string TrimSpaces() => currentText.Trim();

        public void ResetText() => currentText = originalText;

        public void UpdateText(string newText) => currentText = newText;
    }
}
