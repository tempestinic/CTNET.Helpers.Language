# CTNET.Helpers.Language

Very simple project explaining how to manage translations/localizations using JSON files.
Written in C#, use .NET Framework, but can be easily used in .NET Core.

## Example
The translation is obtained calling the string method extension "Translate()" from the class Translations, so it can be used as 1 line call.
If the translation is not found then it returns the input text.

```csharp

// Load JSON file containing translations
Translations.LoadDictionary(filename);

// Add a translation to the dictionary (in memory)
Translations.AddTranslation("text", "translation");

// Add a translation to the dictionary and save to the disk
Translations.AddTranslation("text", "translation", true);

// Remove a translation from the dictionary (in memory)
Translations.RemoveTranslation("text");

// Remove a translation from the dictionary and save to the disk
Translations.RemoveTranslation("text", true);

// Save dictionary to JSON file
Translations.SaveDictionary(filename);

// Translate a string
string example = "String to translate".Translate()
// or
string example = Translations.Translate("String to translate")

// Translate a string using placeholders
Translations.AddTranslation("lblPerson", "Name: {0} - Surname: {1}");
string example = String.Format("lblPerson".Translate(), "John", "Doe");
```

## Changelog

- v1.0.0 First Release
