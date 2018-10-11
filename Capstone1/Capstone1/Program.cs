using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Capstone1
{
    class Program
    {
        static void Main()
        {
                Console.WriteLine("Welcome to the Pig Latin Translator!");
            while (true)
            {
                Console.WriteLine("");
                startText();
                Console.WriteLine("");
                Console.Write("Translate another line? (y/n) ");
                if (Char.ToLower(Console.ReadKey().KeyChar) == 'n') break;
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Now the real fun begins");
            startSpeech();
        }

        static void startText()
        {
            string userInput = null;
            while (string.IsNullOrEmpty(userInput))
            {
                Console.Write("Enter a word to be translated: ");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine(translate(userInput));
        }

        static string translate(string input)
        {
            //initialize to use ToTitleCase
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            string [] inputArray = input.Split(' ');

            string [] output = new string [inputArray.Length];
            
            for (int j = 0; j < inputArray.Length; j++)
            {
                string word = inputArray[j];

                //check the string only contains alphabet and punctuations else leave it the same
                if (Regex.IsMatch(word, @"^[A-Za-z\',;.!?]+$"))
                {
                    //checks if the word is in title case
                    bool titleCase = Regex.IsMatch(word, @"([A-Z][^A-Z])\w+");
                    string punctuation = " ";
                    //check if there is punctuation, if so, chop it off and store for later
                    if (Regex.IsMatch(word[word.Length - 1].ToString(), @"[,;.!?]"))
                    {
                        int firstPunctuation = word.Length - 1;
                        //go back to where the punctuation starts
                        for (int i = word.Length; i > 0; i--)
                        {
                            if (!Regex.IsMatch(word[i-1].ToString(), @"[,;.!?]"))
                            {
                                firstPunctuation = i;
                                break;
                            }
                        }
                        punctuation = word.Substring(firstPunctuation);
                        word = word.Substring(0, firstPunctuation);
                    }
                    //if starts with vowel add way to end else move all consonants before first vowel to the end then add ay to the end of the word.
                    if (Regex.IsMatch(word[0].ToString(), @"[aeiouAEIOU]"))
                    {
                        word += "way";
                    }
                    else
                    {
                        int firstVowel = 0;
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (Regex.IsMatch(word[i].ToString(), @"[aeiouAEIOU]"))
                            {
                                firstVowel = i;
                                break;
                            }
                        }
                        word = word.Substring(firstVowel) + word.Substring(0, firstVowel) + "ay";
                    }
                    //if the input is title case make sure the output is too
                    if (titleCase)
                    {
                        word = textInfo.ToTitleCase(word);
                    }
                    //if there was punchtuation put it back
                    if (punctuation != " ")
                    {
                        word += punctuation;
                    }
                    //Make all upper case if the first two letter are upper case (indicative of all upper case)
                    if (Regex.IsMatch(word,@"([A-Z][A-Z])\w+"))
                    {
                        word = word.ToUpper();
                    }
                }
                output[j] = word;
            }
            return String.Join(" ",output);
        }

        static void startSpeech()
        {
            // Create a SpeechRecognitionEngine object for the default recognizer in the en-US locale.
            using (
            SpeechRecognitionEngine recognizer =
              new SpeechRecognitionEngine(
                new System.Globalization.CultureInfo("en-US")))
            {

                recognizer.LoadGrammarAsync(new DictationGrammar());

                // Add a handler for the speech recognized event.
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(displayResults);

                // Configure the input to the speech recognizer.
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Keep the console window open.
                while (true)
                {
                    Console.ReadLine();
                }
            }
        }

        // Handle the SpeechRecognized event.
        static void displayResults(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
            Console.WriteLine("Translated text: " + translate(e.Result.Text));
            saySomething(translate(e.Result.Text));
            Console.WriteLine("");
        }

        static void saySomething(string something)
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(something);
        }
    }
}
