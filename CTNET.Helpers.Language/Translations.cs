using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace CTNET.Helpers.Language
{
    public static class Translations
    {
        /// <summary>
        /// Object that holds the dictionary items in memory.
        /// </summary>
        public static SortedDictionary<string, string> Dictionary;

        /// <summary>
        /// Name of the JSON file in use.
        /// </summary>
        private static string _filename;

        /// <summary>
        /// Method extension that return the translated text.
        /// If the translation is not found return the input text.
        /// </summary>
        /// <param name="text">Text string to be translated.</param>
        /// <example>Use in this way:
        /// <code>string myText = Trans.Translate("Text to be translated"); 
        /// MessageBox.Show("Text to be translated".Translate());
        /// </code>
        /// </example>
        /// <returns>Return the translated string or the input string.</returns>
        public static string Translate(this string text)
        {
            if (Dictionary == null) return text;
            if (Dictionary.ContainsKey(text))
                return Dictionary[text];
            else
                return text;
        }

        /// <summary>
        /// Load Dictionary object from JSON file.
        /// </summary>
        /// <param name="filename">Full path filename of the JSON file containing translations.</param>
        public static void LoadDictionary(string filename)
        { 
            _filename = filename;
            using (StreamReader stream = File.OpenText(_filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                Dictionary = (SortedDictionary<string, string>)serializer.Deserialize(stream, typeof(SortedDictionary<string, string>));
            }
        }
                
        /// <summary>
        /// Add a new translation to the dictionary.
        /// </summary>
        /// <param name="text">Text to be translated.</param>
        /// <param name="translation">Translation for the text.</param>
        /// <param name="save">Optional: False=Write in memory. You must invoke SaveDictionary(filename) to make the modification persistent.
        /// True=Write immediately to the file.</param>
        public static void AddTranslation(string text, string translation, bool save=false)
        {
            Dictionary.Add(text, translation);
            if (save) SaveDictionary(_filename);
        }

        /// <summary>
        /// Remove a text translation from the dictionary.
        /// </summary>
        /// <param name="text">Text to be removed.</param>
        /// <param name="save">Optional: False=Write in memory. You must invoke SaveDictionary(filename) to make the modification persistent.
        public static void RemoveTranslation(string text, bool save = false)
        {
            Dictionary.Remove(text);
        }

        /// <summary>
        /// Save current dictionary definitions to a JSON file.
        /// </summary>
        /// <param name="filename">Full path filename of the JSON file that will be saved.</param>
        public static void SaveDictionary(string filename)
        {
            _filename = filename;
            using (StreamWriter stream = File.CreateText(_filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(stream, Dictionary);
            }
        }

    }
}
